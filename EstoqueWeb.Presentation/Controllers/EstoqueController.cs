using EstoqueWeb.Infra.Data.Entities;
using EstoqueWeb.Infra.Data.Interfaces;
using EstoqueWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueWeb.Presentation.Controllers
{
    public class EstoqueController : Controller
    {
        //atributo
        private readonly IProdutoRepository _produtoRepository;

        //construtor para inicializar o atributo
        public EstoqueController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //Annotation inidica que o método será executado no SUBMIT
        public IActionResult Cadastro(ProdutoCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = new Produto
                    {
                        Id = Guid.NewGuid(),
                        Nome = model.Nome,
                        Preco = Convert.ToDecimal(model.Preco),
                        Quantidade = model.Quantidade,
                        Data = Convert.ToDateTime(model.Data),
                        Descricao = model.Descricao,
                        DataInclusao = DateTime.Now,
                        DataAlteracao = DateTime.Now,
                    };

                    _produtoRepository.Create(produto);

                    TempData["MensagemSucesso"] = $"Produto {produto.Nome}, cadastrado com sucesso.";

                    ModelState.Clear(); //limpando os campos do formulário (model)
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            else
            {
                TempData["MensagemAlerta"] = "Ocorreram erros de validação no preenchimento do formulário.";
            }

            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}
