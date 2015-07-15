using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sisa.Controllers
{
    public class ContratoController : Controller
    {
        
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

        // GET: Contrato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contrato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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
