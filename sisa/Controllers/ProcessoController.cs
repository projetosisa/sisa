using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sisa.Models;

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

        // GET: Processo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Processo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROCESSO,CD_CLIENTE,ID_BANCO,ID_CONTRATO,AN_PROCESSO,AN_CNJ,IN_TP_ACAO,IN_TP_PROCESSO,DT_CADASTRO,CD_ADVOGADO,DT_DISTRIBUICAO,AN_ESTADO,NM_COMARCA,VL_CUSTAS,CD_VARA,VL_ACAO,IN_CHANCE_PERDA,DT_COPIA_RECEB,DT_ORIGINAL_RECEB,DT_MINUTA_PROTOCOL,IN_FASE_PROCESSUAL,IN_LIMINAR,QT_ALVARA_LEV,VL_ALVARA_LEV,VL_TOT_ALVARA_LEV,QT_DEPOSITO_DEP,VL_DEPOSITO_DEP,IN_TIPO_ACORDO,VL_TOTAL_ACORDO,VL_ENTRADA_ACORDO,QT_PARCELAS_ACORDO,VL_PARCELA,DT_VCTO,AN_SITUACAO_ACORDO,AN_PRESTACAO_CONTAS,AN_INSTANCIA,AN_AGRAVO,VL_PROVISIONAMENTO,DT_AUDIENCIA,AN_RAZAO_ENCERRAMENTO,AN_VL_CONDENACAO,AN_IDENTIFICACAO_ALVARA,AN_SITUACAO_PROCESSUAL,DT_ANDAMENTO,AN_TIPO_ENVIO,NR_CODIGO,AN_SENTENCA,AN_VL_DISCUTIDO_EXTRA,AN_OBSERVACAO,AN_VL_ENTRADA_ACORDO_ESP,AN_FASE,VL_ALVARA_ACORDO,AN_SPC_SERASA,IN_RET_ACAO_COB,IN_PEND_LIQ_SENT,AN_PROVIDENCIAS,AN_DESCRICAO,AN_VL_ALVARA_EXTRA,AN_SITUACAO_PROCESSO,DT_ENCERRAMENTO,AN_SETOR_RESPONSAVEL,AN_JUSTICA,NR_PASTA,DT_ALTERACAO,DT_INCLUSAO,CD_USUARIO_INC,CD_USUARIO_ALT")] TB_PROCESSO tB_PROCESSO)
        {
            if (ModelState.IsValid)
            {
                db.TB_PROCESSO.Add(tB_PROCESSO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_PROCESSO);
        }

        // GET: Processo/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Processo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROCESSO,CD_CLIENTE,ID_BANCO,ID_CONTRATO,AN_PROCESSO,AN_CNJ,IN_TP_ACAO,IN_TP_PROCESSO,DT_CADASTRO,CD_ADVOGADO,DT_DISTRIBUICAO,AN_ESTADO,NM_COMARCA,VL_CUSTAS,CD_VARA,VL_ACAO,IN_CHANCE_PERDA,DT_COPIA_RECEB,DT_ORIGINAL_RECEB,DT_MINUTA_PROTOCOL,IN_FASE_PROCESSUAL,IN_LIMINAR,QT_ALVARA_LEV,VL_ALVARA_LEV,VL_TOT_ALVARA_LEV,QT_DEPOSITO_DEP,VL_DEPOSITO_DEP,IN_TIPO_ACORDO,VL_TOTAL_ACORDO,VL_ENTRADA_ACORDO,QT_PARCELAS_ACORDO,VL_PARCELA,DT_VCTO,AN_SITUACAO_ACORDO,AN_PRESTACAO_CONTAS,AN_INSTANCIA,AN_AGRAVO,VL_PROVISIONAMENTO,DT_AUDIENCIA,AN_RAZAO_ENCERRAMENTO,AN_VL_CONDENACAO,AN_IDENTIFICACAO_ALVARA,AN_SITUACAO_PROCESSUAL,DT_ANDAMENTO,AN_TIPO_ENVIO,NR_CODIGO,AN_SENTENCA,AN_VL_DISCUTIDO_EXTRA,AN_OBSERVACAO,AN_VL_ENTRADA_ACORDO_ESP,AN_FASE,VL_ALVARA_ACORDO,AN_SPC_SERASA,IN_RET_ACAO_COB,IN_PEND_LIQ_SENT,AN_PROVIDENCIAS,AN_DESCRICAO,AN_VL_ALVARA_EXTRA,AN_SITUACAO_PROCESSO,DT_ENCERRAMENTO,AN_SETOR_RESPONSAVEL,AN_JUSTICA,NR_PASTA,DT_ALTERACAO,DT_INCLUSAO,CD_USUARIO_INC,CD_USUARIO_ALT")] TB_PROCESSO tB_PROCESSO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_PROCESSO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_PROCESSO);
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
