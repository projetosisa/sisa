using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using sisa.Models;
using sisa.DAO;
using System.Data.Entity;

namespace sisa.Controllers
{
    public class ContratoController : Controller
    {
        private SisaEntities db = new SisaEntities();
        public ActionResult ListaContratos(int codcli, string banco)
        {
            var lista = new sisa.DAO.Contrato().RetornaContratos(codcli,banco);
            return View("Lista",lista);
        }

        public PartialViewResult ListaBancos(int codcli)
        {
            var lista = new sisa.DAO.Contrato().RetornaBancos(codcli);
            return PartialView("_Bancos", lista);
        }
        public PartialViewResult ListaParcelas(string codcontrato)
        {
            var lista = new sisa.DAO.Contrato().ListaParcelas(codcontrato);
            return PartialView("Parcelas", lista);
        }

        // GET: Contrato
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contrato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        void CarregaListas()
        {
            ViewBag.ListaTipoContrato = new Dados().RetornaSelectList("SELECT TIPOCONTRATO FROM VW_TIPOCONTRATO");
            ViewBag.ListaInformativo = new Dados().RetornaSelectList("SELECT INFORMATIVO FROM VW_INFORMATIVO");
            ViewBag.ListaFaixa = new Dados().RetornaSelectList("SELECT FAIXA FROM VW_FAIXA");
            ViewBag.ListaExcluido = new Dados().ListaSelecione();
        }

        // GET: Contrato/Create
        public ActionResult Create(int codcli, string banco)
        {
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;
            ViewBag.CodBanco = new Contrato().RetornaIdBanco(banco);
            CarregaListas();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TB_CONTRATO tbContrato)
        {
            try
            {
                //if (tbContrato.VL_TOT_CONTRATO != null)
                //{
                //    tbContrato.VL_TOT_CONTRATO = Convert.ToDecimal(tbContrato.VL_TOT_CONTRATO.ToString().Replace(".", ""));
                //}

                //if (ModelState.IsValid)
                //{
                    db.TB_CONTRATO.Add(tbContrato);
                    db.SaveChanges();
                    TempData["Msg"] = "Gravado com sucesso.";
                    string dsBanco = new Contrato().RetornaNomeBanco(tbContrato.ID_BANCO);
                    return RedirectToRoute("PessoaContratos", new {codcli=tbContrato.CD_CLIENTE, banco = dsBanco });
                //}
                //else
                //{
                    TempData["MsgErro"] = "Erro: Verificar dados, tente novamente";
                //}
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro: Verificar dados, tente novamente," + ex.Message;
            }
            
            CarregaListas();
            ViewBag.CodCliente = tbContrato.CD_CLIENTE;
            ViewBag.Banco = new Contrato().RetornaNomeBanco(tbContrato.ID_BANCO);
            ViewBag.CodBanco = tbContrato.ID_BANCO;
            return View(tbContrato);

        }

        // POST: Contrato/Create
        [HttpPost]
        public ActionResult CreateOriginal(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contrato/Edit/5
        public ActionResult Edit(string contrato)
        {   try
            {
            CarregaListas();
            var ct = new Contrato(contrato);
            ViewBag.CodCliente = ct.CodCliente;
            ViewBag.CodBanco = ct.IdBanco;
            ViewBag.Banco = ct.NomeBanco;
            
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro: Verificar dados, tente novamente," + ex.Message;
            }
            
            return View(db.TB_CONTRATO.SingleOrDefault(c=>c.CD_CONTRATO.Equals(contrato)));
        }

        // POST: Contrato/Edit/5
        [HttpPost]
        public ActionResult Edit(TB_CONTRATO tbl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CarregaListas();
                    ViewBag.CodCliente = tbl.CD_CLIENTE;
                    ViewBag.Banco = new Contrato().RetornaNomeBanco(tbl.ID_BANCO);
                    ViewBag.CodBanco = tbl.ID_BANCO;

                    db.Entry(tbl).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Msg"] = "Gravado com sucesso.";
                    string dsBanco = new Contrato().RetornaNomeBanco(tbl.ID_BANCO);
                    new Historico().Alteracao(tbl.CD_CLIENTE, tbl.ID_BANCO, "Contrato " + tbl.CD_CONTRATO + " alterado pelo usuário " + Session["CodUsuario"] + " em " + DateTime.Now, DateTime.Now, Session["NmUsuario"].ToString());
                    
                    return RedirectToRoute("PessoaContratos", new { codcli = tbl.CD_CLIENTE, banco = dsBanco });
                }
            }
            catch(Exception ex)
            {
                TempData["MsgErro"] = "Erro: Verificar dados, tente novamente," + ex.Message;
                
            }
            return View();
        }

        // GET: Contrato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Excluir(int id)
        {
            try
            {
                var db = Conexao.Banco;
                var hst = db.TB_CONTRATO.First(c => c.ID_CONTRATO == id);
                var ct = new Contrato(hst.CD_CONTRATO);      

                db.TB_CONTRATO.Remove(hst);
                db.SaveChanges();

                TempData["Msg"] = "Contrato excluído.";
                string dsBanco = new Contrato().RetornaNomeBanco(ct.IdBanco);
                new Historico().Exclusao(ct.CodCliente, ct.IdBanco, "Contrato " + ct.CdContrato + " excluído pelo usuário " + Session["CodUsuario"] + " em " + DateTime.Now, DateTime.Now, Session["NmUsuario"].ToString());
                return RedirectToRoute("PessoaContratos", new { codcli = ct.CodCliente, banco = dsBanco });
            }
            catch
            {
                return View();
            }
        }

        // POST: Contrato/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
