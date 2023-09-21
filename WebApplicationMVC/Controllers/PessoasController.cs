using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplicationMVC.Business.Genericos;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class PessoasController : Controller
    {
        public IActionResult Index()
        {
            var model = new PessoasModel();

            foreach (Pessoa pessoa in Pessoa.PessoasCadastradas)
            {
                model.Pessoas.Add(new PessoaModel()
                {
                    Id = pessoa.Id,
                    Nome = pessoa.Nome,
                });
            }

            return View(model);
        }

        public IActionResult Update(long id)
        {
            var pessoaCadastrada = Pessoa.PessoasCadastradas.FirstOrDefault(x => x.Id == id);
            if (pessoaCadastrada == null)
            {
                throw new Exception("Essa pessoa não existe!");
            }

            var model = new PessoaModel();
            model.Id = id;
            model.Nome = pessoaCadastrada.Nome;

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(PessoaModel pessoaModel)
        {
            var pessoaCadastrada = Pessoa.PessoasCadastradas.FirstOrDefault(x => x.Id == pessoaModel.Id);
            if (pessoaCadastrada == null)
            {
                throw new Exception("Essa pessoa não existe!");
            }

            pessoaCadastrada.Nome = pessoaModel.Nome;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(PessoaModel pessoaModel)
        {
            Pessoa.PessoasCadastradas.Add(new Pessoa() { Nome = pessoaModel.Nome});

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Delete(long id)
        {
            var pessoaCadastrada = Pessoa.PessoasCadastradas.FirstOrDefault(x => x.Id == id);
            if (pessoaCadastrada == null)
            {
                throw new Exception("Essa pessoa não existe!");
            }

            var model = new PessoaModel();
            model.Id = id;
            model.Nome = pessoaCadastrada.Nome;

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(PessoaModel pessoaModel)
        {
            var pessoaCadastrada = Pessoa.PessoasCadastradas.FirstOrDefault(x => x.Id == pessoaModel.Id);
            if (pessoaCadastrada == null)
            {
                throw new Exception("Essa pessoa não existe!");
            }

            Pessoa.PessoasCadastradas.Remove(pessoaCadastrada);

            return RedirectToAction("Index");
        }
    }
}
