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
    public class UsuarioController : Controller
    {
        private SisaEntities db = new SisaEntities();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            try
            {
                string usu = frm["usuario"].ToUpper();
                string psw = frm["senha"].ToString();

                var login = db.TB_USUARIO.Where(u => u.CD_USUARIO.Equals(usu) && u.AN_SENHA.Equals(psw)).ToList();
                if (login.Count > 0)
                {
                    Session["login"] = "1";
                    Session["CodUsuario"] = login[0].ID_USUARIO.ToString();
                    Session["NmUsuario"] = login[0].NM_NOME.ToString();
                    TempData["Msg"] = "Login efetuado com sucesso, bem vindo "+login[0].NM_NOME.ToString();
                    return RedirectToRoute("Principal");
                }
                else
                {
                    Session["login"] = "0";
                    TempData["MsgErro"] = "Usuário ou senha inválidos, tente novamente";
                }
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Ocorreu o seguinte erro: ," + ex.Message;
            }
            return View("Index");
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_USUARIO tB_USUARIO = db.TB_USUARIO.Find(id);
            if (tB_USUARIO == null)
            {
                return HttpNotFound();
            }
            return View(tB_USUARIO);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_USUARIO,CD_USUARIO,GRUPO_USUARIO,AN_SENHA,IN_NIVEL,NM_NOME,AN_EMAIL,CD_HORARIO,FL_LOCALIZADOR,FL_PESQUISA,FL_GESTOR,FL_ADVOGADO,FL_ACIONADOR,FL_FINANCEIRO,FL_ADMINISTRADOR,FL_LIBERA_HONORARIOS,FL_IMPRIME_RECIBO,FL_ATIVO,FL_TROCA_SENHA,FL_INCLUI_ALTERA_PARCELA,FL_ALTERA_DADOS_ACORDO,FL_EXCLUI_CLIENTE,FL_IMPRIME_BOLETO,FL_BASE_ELETRONICA,FL_EMITE_MINUTAS,FL_EXCLUI_DADOS_PROCESSO,FL_AUTORIZA_DESCONTO,FL_LIBERA_CUSTAS,FL_LIBERA_ESTORNO_PAGAMENTO,QT_EVENTOS_DIA,TEMPO_EVENTOS_DIA,QT_BOLETOS_DIA,VL_META,NR_FILIAL,AN_GESTOR,NM_CEDENTE,AN_CIDADE,AN_ENDERECO,DT_ALTERA_SENHA,DT_INCLUSAO,DT_ALTERACAO,CD_USUARIO_INC,CD_USUARIO_ALT,FL_ACESSA_ALFA,FL_ACESSA_DAYCOVAL,FL_ACESSA_FICSA,FL_ACESSA_OMNI,FL_ACESSA_RENNER,FL_ACESSA_SULFINANCEIRA,FL_ACESSA_OUTROBANCOS,VL_META_ALFA,VL_META_DAYCOVAL,VL_META_FICSA,VL_META_RENNER,VL_META_OMNI,VL_META_SULFINANCEIRA,VL_META_OUTROSBANCOS,NR_RECIBO,NR_BOLETO,NR_CNPJ_CARTORIO,FL_EXCLUI_PARCELA,AN_TIPO_SELECAO")] TB_USUARIO tB_USUARIO)
        {
            if (ModelState.IsValid)
            {
                db.TB_USUARIO.Add(tB_USUARIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_USUARIO);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_USUARIO tB_USUARIO = db.TB_USUARIO.Find(id);
            if (tB_USUARIO == null)
            {
                return HttpNotFound();
            }
            return View(tB_USUARIO);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_USUARIO,CD_USUARIO,GRUPO_USUARIO,AN_SENHA,IN_NIVEL,NM_NOME,AN_EMAIL,CD_HORARIO,FL_LOCALIZADOR,FL_PESQUISA,FL_GESTOR,FL_ADVOGADO,FL_ACIONADOR,FL_FINANCEIRO,FL_ADMINISTRADOR,FL_LIBERA_HONORARIOS,FL_IMPRIME_RECIBO,FL_ATIVO,FL_TROCA_SENHA,FL_INCLUI_ALTERA_PARCELA,FL_ALTERA_DADOS_ACORDO,FL_EXCLUI_CLIENTE,FL_IMPRIME_BOLETO,FL_BASE_ELETRONICA,FL_EMITE_MINUTAS,FL_EXCLUI_DADOS_PROCESSO,FL_AUTORIZA_DESCONTO,FL_LIBERA_CUSTAS,FL_LIBERA_ESTORNO_PAGAMENTO,QT_EVENTOS_DIA,TEMPO_EVENTOS_DIA,QT_BOLETOS_DIA,VL_META,NR_FILIAL,AN_GESTOR,NM_CEDENTE,AN_CIDADE,AN_ENDERECO,DT_ALTERA_SENHA,DT_INCLUSAO,DT_ALTERACAO,CD_USUARIO_INC,CD_USUARIO_ALT,FL_ACESSA_ALFA,FL_ACESSA_DAYCOVAL,FL_ACESSA_FICSA,FL_ACESSA_OMNI,FL_ACESSA_RENNER,FL_ACESSA_SULFINANCEIRA,FL_ACESSA_OUTROBANCOS,VL_META_ALFA,VL_META_DAYCOVAL,VL_META_FICSA,VL_META_RENNER,VL_META_OMNI,VL_META_SULFINANCEIRA,VL_META_OUTROSBANCOS,NR_RECIBO,NR_BOLETO,NR_CNPJ_CARTORIO,FL_EXCLUI_PARCELA,AN_TIPO_SELECAO")] TB_USUARIO tB_USUARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_USUARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_USUARIO);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_USUARIO tB_USUARIO = db.TB_USUARIO.Find(id);
            if (tB_USUARIO == null)
            {
                return HttpNotFound();
            }
            return View(tB_USUARIO);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_USUARIO tB_USUARIO = db.TB_USUARIO.Find(id);
            db.TB_USUARIO.Remove(tB_USUARIO);
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
