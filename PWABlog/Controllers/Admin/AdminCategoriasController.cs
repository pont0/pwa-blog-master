using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PWABlog.Models.Blog.Categoria;
using PWABlog.RequestModels.AdminCategorias;
using PWABlog.ViewModels.Admin;
using System;

namespace PWABlog.Controllers.Admin
{
    [Authorize]
    public class AdminCategoriasController : Controller
    {
        private readonly CategoriaOrmService _categoriaOrmService;

        public AdminCategoriasController(
            CategoriaOrmService categoriaOrmService
        )
        {
            _categoriaOrmService = categoriaOrmService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            AdminCategoriasListarViewModel model = new AdminCategoriasListarViewModel();

            // Obter as Categorias
            var listaCategorias = _categoriaOrmService.ObterCategorias();

            // Alimentar o model com as Categorias que serão listadas
            foreach (var categoriaEntity in listaCategorias)
            {
                var CategoriaAdminCategorias = new CategoriaAdminCategorias();
                CategoriaAdminCategorias.Id = categoriaEntity.Id;
                CategoriaAdminCategorias.Nome = categoriaEntity.Nome;
               

                model.Categorias.Add(CategoriaAdminCategorias);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Detalhar(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Criar()
        {
            ViewBag.erro = TempData["erro-msg"];

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Criar(AdminCategoriasCriarRequestModel request)
        {
            var nome = request.Nome;

            try
            {
                _categoriaOrmService.CriarCategoria(nome);
            }
            catch (Exception exception)
            {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Criar");
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
           
            
            
            ViewBag.id = id;
            ViewBag.erro = TempData["erro-msg"];

            AdminCategoriasEditarViewModel model = new AdminCategoriasEditarViewModel();

            // Obter as Categorias
            var listaCategorias = _categoriaOrmService.ObterCategorias();

            // Alimentar o model com as Categorias que serão listadas
            foreach (var categoriaEntity in listaCategorias)
            {
                var CategoriaAdminCategorias = new CategoriaAdminCategorias();
                CategoriaAdminCategorias.Id = categoriaEntity.Id;
                CategoriaAdminCategorias.Nome = categoriaEntity.Nome;


                model.Categorias.Add(CategoriaAdminCategorias);
            }

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Editar(AdminCategoriasEditarRequestModel request)
        {
            var id = request.Id;
            var nome = request.Nome;

            try
            {
                _categoriaOrmService.EditarCategoria(id, nome);
            }
            catch (Exception exception)
            {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Editar", new { id = id });
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            ViewBag.id = id;
            ViewBag.erro = TempData["erro-msg"];

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Remover(AdminCategoriasRemoverRequestModel request)
        {
            var id = request.Id;

            try
            {
                _categoriaOrmService.RemoverCategoria(id);
            }
            catch (Exception exception)
            {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Remover", new { id = id });
            }

            return RedirectToAction("Listar");
        }
    }
}