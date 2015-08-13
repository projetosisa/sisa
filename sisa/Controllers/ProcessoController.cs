using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using sisa.Models;
using sisa.DAO;

namespace sisa.Controllers
{
    public class ProcessoController : Controller
    {
        private SisaEntities db = new SisaEntities();

        // GET: Processo
        public ActionResult Index()
        {
            return View(db.TB_PROCESSO.ToList());
        }

        // GET: Processo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_PROCESSO tB_PROCESSO = db.TB_PROCESSO.Find(id);
            if (tB_PROCESSO == null)
            {
                return HttpNotFound();
            }
            return View(tB_PROCESSO);
        }

        public JsonResult GetTipoProcesso(int codcli, string banco, string tipo)
        {
            string nomeCliente = new Pessoa(codcli).Nome??"";
            string nomeBanco = banco;
            
            var clsTipo = new TipoProcesso();
            if (tipo == "Ativa")
            {
                clsTipo.Autor = nomeBanco;
                clsTipo.Reu = nomeCliente;
            }
            else
            {
                clsTipo.Autor = nomeCliente;
                clsTipo.Reu = nomeBanco;
            }
            //ViewBag.CodCliente = id;
            return Json(clsTipo);
        }

        void CarregaListas(string codcli,string codbanco)
        {
            var p = new Processo();
            ViewBag.LstTipoProcesso = p.ListaTipoProcesso();
            ViewBag.LstTipoAcao = p.ListaAcao();
            ViewBag.LstChancePerda = p.ListaChancePerda();
            ViewBag.LstComarca = p.ListaComarca();
            ViewBag.LstSituProcesso = p.ListaSituacaoProcesso();
            ViewBag.LstUF = p.ListaUF();
            ViewBag.LstAdvogados = p.ListaAdvogados();
            ViewBag.LstTribunal = p.ListaTribunal();
            ViewBag.LstContratos = p.ListaContratos(codcli,codbanco);
        }

        // GET: Processo/Create
        public ActionResult Create(int codcli, string banco)
        {
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;
            int idBanco = new Contrato().RetornaIdBanco(banco);
            ViewBag.CodBanco = idBanco;
            CarregaListas(codcli.ToString(), idBanco.ToString());
            return View();
        }

        // POST: Processo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TB_PROCESSO tbl)
        {
            try
            {
                ViewBag.CodCliente = tbl.CD_CLIENTE;
                int idBanco = tbl.ID_BANCO;
                ViewBag.Banco = new Contrato().RetornaNomeBanco(idBanco);
                ViewBag.CodBanco = idBanco;
                CarregaListas(tbl.CD_CLIENTE.ToString(), idBanco.ToString());

                //if (ModelState.IsValid)
                //{
                    db.TB_PROCESSO.Add(tbl);
                    db.SaveChanges();
                    TempData["Msg"] = "Gravado com sucesso.";
                    string dsBanco = new Contrato().RetornaNomeBanco(tbl.ID_BANCO);
                    return RedirectToRoute("PessoaContratos", new { codcli = tbl.CD_CLIENTE, banco = dsBanco });
                //}
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro, verificar dados. "+ex.Message;
            }

            return View(tbl);
        }

        public ActionResult Editar(int? id)
        {
            TB_PROCESSO tblProcesso = null;
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                tblProcesso = db.TB_PROCESSO.Find(id);

                ViewBag.CodCliente = tblProcesso.CD_CLIENTE;
                int idBanco = tblProcesso.ID_BANCO;
                ViewBag.Banco = new Contrato().RetornaNomeBanco(idBanco);
                ViewBag.CodBanco = idBanco;
                CarregaListas(tblProcesso.CD_CLIENTE.ToString(), idBanco.ToString());
                
                if (tblProcesso == null)
                {
                    TempData["MsgErro"] = "Nenhum processo encontrato com esse Id";
                }
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro, verificar dados. " + ex.Message;
            }
            return View("Edit",tblProcesso);

        }

        // GET: Processo/Edit/5
        public ActionResult Edit(int? id, int codcli, int codbanco)
        {
            TB_PROCESSO tB_PROCESSO = null;
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                ViewBag.CodCliente = codcli;
                int idBanco = codbanco;
                ViewBag.Banco = new Contrato().RetornaNomeBanco(codbanco);
                ViewBag.CodBanco = codbanco;
                CarregaListas(codcli.ToString(), codbanco.ToString());

                tB_PROCESSO = db.TB_PROCESSO.Find(id);
                if (tB_PROCESSO == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro, verificar dados. " + ex.Message;
            }
            return View(tB_PROCESSO);
            
        }

        // POST: Processo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TB_PROCESSO tblProcesso)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(tblProcesso).State = EntityState.Modified;
            //    db.SaveChanges();
            //    TempData["Msg"] = "Gravado com sucesso.";
            //}
            //else
            //{
            //    TempData["MsgErro"] = "Não foi possível gravar, verificar dados.";
            //}
            try
            {
                db.Entry(tblProcesso).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Msg"] = "Gravado com sucesso.";
            }
            catch(Exception ex)
            {
                TempData["MsgErro"] = "Não foi possível gravar, verificar dados. "+ex.Message;
            }

            ViewBag.CodCliente = tblProcesso.CD_CLIENTE;
            int idBanco = tblProcesso.ID_BANCO;
            ViewBag.Banco = new Contrato().RetornaNomeBanco(idBanco);
            ViewBag.CodBanco = idBanco;
            CarregaListas(tblProcesso.CD_CLIENTE.ToString(), idBanco.ToString());
            return RedirectToAction("Edit", new { id = tblProcesso.ID_PROCESSO, codcli = tblProcesso.CD_CLIENTE, codbanco = tblProcesso.ID_BANCO });
        }

        public ActionResult Excluir(int id)
        {
            var db = Conexao.Banco;
            var hst = db.TB_PROCESSO.First(c => c.ID_PROCESSO == id);
            int CodCliente = hst.CD_CLIENTE;
            int IdBanco = hst.ID_BANCO;
            string dsBanco = new Contrato().RetornaNomeBanco(IdBanco);
            try
            {
                db.TB_PROCESSO.Remove(hst);
                db.SaveChanges();
                TempData["Msg"] = "Processo excluído.";
                new Historico().Exclusao(CodCliente, IdBanco, "Processo " + id.ToString() + " excluído pelo usuário " + Session["CodUsuario"] + " em " + DateTime.Now, DateTime.Now, Session["NmUsuario"].ToString());
                return RedirectToRoute("PessoaProcesso", new { codcli = CodCliente, banco = dsBanco });
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "Erro ao tentar excluir, verificar dados. " + ex.Message;
            }
            return RedirectToAction("Edit", new { codcli = CodCliente, banco = dsBanco });
        }

        // GET: Processo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_PROCESSO tB_PROCESSO = db.TB_PROCESSO.Find(id);
            if (tB_PROCESSO == null)
            {
                return HttpNotFound();
            }
            return View(tB_PROCESSO);
        }

        // POST: Processo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_PROCESSO tB_PROCESSO = db.TB_PROCESSO.Find(id);
            db.TB_PROCESSO.Remove(tB_PROCESSO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
