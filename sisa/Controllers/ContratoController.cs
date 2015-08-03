using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using sisa.Models;
using sisa.DAO;

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

                if (ModelState.IsValid)
                {
                    db.TB_CONTRATO.Add(tbContrato);
                    db.SaveChanges();
                    TempData["Msg"] = "Gravado com sucesso.";
                    string dsBanco = new Contrato().RetornaNomeBanco(tbContrato.ID_BANCO);
                    return RedirectToRoute("PessoaContratos", new {codcli=tbContrato.CD_CLIENTE, banco = dsBanco });
                }
                else
                {
                    TempData["MsgErro"] = "Erro: Verificar dados, tente novamente";
                }
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contrato/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contrato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
