using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Business.Genericos;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProdutosModel();

            foreach(var produto in Produto.Read())
            {
                model.Produtos.Add(new ProdutoModel(produto));
            }

            return View(model);
        }
    }
}
