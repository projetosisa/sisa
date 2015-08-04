using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using sisa.Models;
using sisa.DAO;

namespace sisa.Controllers
{
    public class PessoaController : Controller
    {
        private SisaEntities db = new SisaEntities();

        // GET: Pessoa
        public ActionResult Index(int codcli = 0,string banco=null,string contrato=null,int id_contrato=0)
        {
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;
            ViewBag.Contrato = contrato;
            ViewBag.IdContrato = id_contrato;
            ViewBag.ExibirConsulta = true;
            if (codcli > 0)
            {
                ViewBag.ExibirConsulta = false;
                ViewBag.Contratos = new Contrato().RetornaContratos(codcli,banco);
                ViewBag.Parcelas = new Parcela().ListaTb(codcli, banco, contrato);
            }
            return View();
        }

        public ActionResult ListaContratos(int codcli, string banco)
        {
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;

            var ct = new Contrato().RetornaContratos(codcli, banco);
            ViewBag.Contratos = ct;
            if(ct.Count()==1){
                foreach(var itm in ct){
                    ViewBag.Parcelas = new Parcela().ListaTb(codcli, banco, itm.CD_CONTRATO.ToString());
                }
            }

            ViewBag.ExibirConsulta = false;
            return View("Index");
        }

        public ActionResult ListaProcessos(int codcli, string banco, string contrato=null)
        {
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;
            ViewBag.Contrato = contrato;
            var lista = new Processo().Lista(codcli, banco);
            ViewBag.ExibirConsulta = false;
            return View("Processos",lista);
        }
        public ActionResult ListaParcelas(int codcli, string banco, string contrato)
        {
            var lista = new Parcela().ListaTb(codcli, banco, contrato);
            ViewBag.CodCliente = codcli;
            ViewBag.Banco = banco;
            ViewBag.Contrato = contrato;
            ViewBag.exibirConsulta = false;
            return View("Parcelas", lista);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AutoCompletePessoa(string term)
        {
            var result = new List<KeyValuePair<string, string>>();
            IList<SelectListItem> List = new List<SelectListItem>();

            var lista = new DAO.Dados().RetornaDados("select CAST(REPLICATE('0', 7 - LEN(CD_CLIENTE)) + RTrim(CD_CLIENTE) as varchar(10))+' - '+NM_PESSOA AS NM_PESSOA,CD_CLIENTE from TB_PESSOA WHERE NM_PESSOA LIKE '" + term.ToLower() + "%'");

            /*var lista = (from r in db.TB_PESSOA
                         where r.NM_PESSOA.ToLower().Contains(term.ToLower())
                         select new { r.NM_PESSOA, r.CD_CLIENTE }).ToList();*/

            foreach (System.Data.DataRow item in lista.Rows)
            {
                result.Add(new KeyValuePair<string, string>(item["CD_CLIENTE"].ToString(), item["NM_PESSOA"].ToString()));
            }
            var result3 = result.Where(s => s.Value.ToLower().Contains(term.ToLower())).Select(w => w).ToList();

            return Json(result3, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetDetail(int id)
        {
            var pes = new TB_PESSOA();

            if (id == 0)
            {
                pes.CD_CLIENTE = 0;
                pes.NM_PESSOA = "NENHUM";
            }
            else
            {
                pes = db.TB_PESSOA.Where(p => p.CD_CLIENTE == id).SingleOrDefault();
            }
            ViewBag.CodCliente = id;
            return Json(pes);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_PESSOA tB_PESSOA = db.TB_PESSOA.Find(id);
            if (tB_PESSOA == null)
            {
                return HttpNotFound();
            }
            return View(tB_PESSOA);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PESSOA,CD_CLIENTE,NM_PESSOA,IN_F_J,AN_CNPJ_CPF,AN_OCUPACAO,AN_CARGO,AN_RG,DT_EMISSAO_RG,AN_ORGAO_EMISSAO_RG,CD_UF_RG,AN_SEXO,DT_NASCIMENTO,AN_NATURALIDADE,AN_NACIONALIDADE,AN_ESTADO_CIVIL,AN_NOME_CONJUGE,AN_NOME_PAI,AN_NOME_MAE,DT_ALTERACAO,DT_INCLUSAO,CD_USUARIO_INC,CD_USUARIO_ALT")] TB_PESSOA tB_PESSOA)
        {
            if (ModelState.IsValid)
            {
                db.TB_PESSOA.Add(tB_PESSOA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_PESSOA);
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_PESSOA tB_PESSOA = db.TB_PESSOA.Find(id);
            if (tB_PESSOA == null)
            {
                return HttpNotFound();
            }
            return View(tB_PESSOA);
        }

        // POST: Pessoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PESSOA,CD_CLIENTE,NM_PESSOA,IN_F_J,AN_CNPJ_CPF,AN_OCUPACAO,AN_CARGO,AN_RG,DT_EMISSAO_RG,AN_ORGAO_EMISSAO_RG,CD_UF_RG,AN_SEXO,DT_NASCIMENTO,AN_NATURALIDADE,AN_NACIONALIDADE,AN_ESTADO_CIVIL,AN_NOME_CONJUGE,AN_NOME_PAI,AN_NOME_MAE,DT_ALTERACAO,DT_INCLUSAO,CD_USUARIO_INC,CD_USUARIO_ALT")] TB_PESSOA tB_PESSOA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_PESSOA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_PESSOA);
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_PESSOA tB_PESSOA = db.TB_PESSOA.Find(id);
            if (tB_PESSOA == null)
            {
                return HttpNotFound();
            }
            return View(tB_PESSOA);
        }

        // POST: Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_PESSOA tB_PESSOA = db.TB_PESSOA.Find(id);
            db.TB_PESSOA.Remove(tB_PESSOA);
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
