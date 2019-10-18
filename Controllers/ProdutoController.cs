using Ecommerce.DAL;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }

        //Métodos dentro de um controller são de chamados
        //de actions
        public IActionResult Index()
        {
            ViewBag.Produtos = _produtoDAO.Listar();
            ViewBag.DataHora = DateTime.Now;
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string txtNome,
            string txtDescricao, string txtPreco,
            string txtQuantidade)
        {
            Produto p = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToDouble(txtPreco),
                Quantidade = Convert.ToInt32(txtQuantidade)
            };
            _produtoDAO.Cadastrar(p);
            return RedirectToAction("Index");
        }

        public IActionResult Remover(int? id)
        {
            //remover o produto.
            //buscar o produto pelo id
            //remover o produto com base no objeto.
            if(id != null)
            {

            }

            return RedirectToAction("Index");
        }


    }
}