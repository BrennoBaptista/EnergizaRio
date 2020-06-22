using EstacaoRecargaDDD.Aplicacao.Interfaces;
using EstacaoRecargaDDD.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacaoRecargaDDD.MVC.Controllers
{
    public class EstacaoRecargaMVCController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public EstacaoRecargaMVCController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        // GET: ProdutoMVC
        public ActionResult Index()
        {
            return View(_estacaoRecargaApp.Listar());
        }

        // GET: ProdutoMVC/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // GET: ProdutoMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: ProdutoMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: ProdutoMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Atualizar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoMVC/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: ProdutoMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Excluir(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
