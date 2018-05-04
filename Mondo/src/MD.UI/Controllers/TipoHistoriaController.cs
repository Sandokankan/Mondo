using MD.Application.Interfaces;
using MD.Application.Service;
using MD.Application.ViewModels;
using MD.Infra.CrossCutting.MvcFilters;
using System;
using System.Net;
using System.Web.Mvc;

namespace MD.UI.Controllers
{
    // ModuloTipoHistoria THL,THI,THE,THD,THX

    [Authorize]
    public class TipoHistoriaController : Controller
    {
        private ITipoHistoriaAppService _TipoHistoriaAppService;

        public TipoHistoriaController(ITipoHistoriaAppService pobTipoHistoriaAppService)
        {
            _TipoHistoriaAppService = pobTipoHistoriaAppService;
        }

        [AllowAnonymous]
        // GET: TipoHistoria
        public ActionResult Index()
        {
            return View(_TipoHistoriaAppService.ObterTodos());
        }

        [ClaimsAuthorize("ModuloTipoHistoria", "THD")]
        // GET: TipoHistoria/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistoriaViewModel tipoHistoriaViewModel = _TipoHistoriaAppService.ObterPorId(id.Value);
            if (tipoHistoriaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistoriaViewModel);
        }

        // GET: TipoHistoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoHistoria/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodTipoHistoria,DataInclusao,DataEdicao,Ativo,Titulo,Descricao")] TipoHistoriaViewModel tipoHistoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                _TipoHistoriaAppService.Adicionar(tipoHistoriaViewModel);
                return RedirectToAction("Index");
            }

            return View(tipoHistoriaViewModel);
        }

        // GET: TipoHistoria/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistoriaViewModel tipoHistoriaViewModel = _TipoHistoriaAppService.ObterPorId(id.Value);
            if (tipoHistoriaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistoriaViewModel);
        }

        // POST: TipoHistoria/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodTipoHistoria,DataInclusao,DataEdicao,Ativo,Titulo,Descricao")] TipoHistoriaViewModel tipoHistoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                tipoHistoriaViewModel = _TipoHistoriaAppService.Atualizar(tipoHistoriaViewModel);
                return RedirectToAction("Index");
            }
            return View(tipoHistoriaViewModel);
        }

        [ClaimsAuthorize("ModuloTipoHistoria","THX")]
        // GET: TipoHistoria/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistoriaViewModel tipoHistoriaViewModel = _TipoHistoriaAppService.ObterPorId(id.Value);
            if (tipoHistoriaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistoriaViewModel);
        }

        [ClaimsAuthorize("ModuloTipoHistoria", "THX")]
        // POST: TipoHistoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {

            _TipoHistoriaAppService.Desativar(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _TipoHistoriaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
