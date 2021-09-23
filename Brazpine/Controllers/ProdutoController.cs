using Brazpine.Data;
using Brazpine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brazpine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ProdutoController (AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Produtos.ToArray());
        }

        [HttpPost]
        public IActionResult Post([FromForm] Produto _produto)
        {
            _context.Add(new Produto {
                Descricao = _produto.Descricao,
                ValorUnitario = _produto.ValorUnitario,
                DataCadastro = _produto.DataCadastro,
                Quantidade = _produto.Quantidade,
                Tipo = _produto.Tipo
            });
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPatch]
        public IActionResult Patch([FromForm] Produto _produto)
        {
            Produto produto = _context.Produtos.Find(_produto.ID);
            produto.Descricao = _produto.Descricao;
            produto.ValorUnitario = _produto.ValorUnitario;
            produto.DataCadastro = _produto.DataCadastro;
            produto.Quantidade = _produto.Quantidade;
            produto.Tipo = _produto.Tipo;
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpDelete]
        public IActionResult Delete(int ID)
        {
            Produto produto = _context.Produtos.Find(ID);
            _context.Remove(produto);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    }
}
