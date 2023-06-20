using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa2.Contexts;
using Etapa2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etapa2.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ContatoController : ControllerBase
	{
		// Uma variável apenas de leitura do tipo Context é criada pois
		// a controller será a responsável por gerenciar as ações do 
		// banco de dados, ou seja, configurar as requisições para
		// que seja possível realizar operações no banco de dados atual 
		// ("Agenda") 
		private readonly AgendaContext _context;

		// Atribuindo o contexto para dentro do controller
		public ContatoController(AgendaContext context)
		{
			// Uma vez atribuida, _context é imutável para o contexto indicado
			_context = context;
		}

		// POST
		// Criando o endpoint com requisição POST
		[HttpPost]
		public IActionResult Create(Contato contato)
		{
			_context.Add(contato);
			_context.SaveChanges();
			return CreatedAtAction(nameof(GetById), new { id = contato.Id }, contato);
		}

		// PUT
		//		QUAL A DIFERENÇA DO PATCH PARA O PUT?
		//		Para o PUT é necessário fornecer todos os dados para serem atualizados
		//		No OATCH não é necesário fornecer todos os dados, apenas aqueles dados que
		//		se deseja atualizar
		// Criando o endpoint com requisição PUT (update)
		[HttpPut("{id}")]
		public IActionResult Update(int id, Contato contato)
		{
			Contato dbContato = _context.Contatos.Find(id);

			if (dbContato == null) return NotFound();
			
			if (contato.Nome != null) dbContato.Nome = contato.Nome;
			if (contato.Telefone != null) dbContato.Telefone = contato.Telefone;
			if (contato.Ativo != null) dbContato.Ativo = contato.Ativo;

			_context.Contatos.Update(dbContato);
			_context.SaveChanges();

			return Ok(dbContato);
		}

		// GET
		// Endpoint para obter todos os contatos
		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_context.Contatos);
		}

		// Endpoint para obter contato por id
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var contato = _context.Contatos.Find(id);

			if (contato == null)
			{
				return NotFound();
			}

			return Ok(contato);
		}

		// Endpoint para obter por nome
		[HttpGet("name/{nome}")]
		public IActionResult GetByName(string nome)
		{
			var dbContatos = _context.Contatos.Where(c => c.Nome.Contains(nome));

			if (dbContatos == null) return NotFound();

			return Ok(dbContatos);
		}

		// DELETE
		// Endpoint para deletar um contato pelo id
		[HttpDelete("{id}")]
		public IActionResult DeleteById(int id)
		{
			Contato rmContato = _context.Contatos.Find(id);

			if (rmContato == null)
			{
				return NotFound();
			}
			
			_context.Contatos.Remove(rmContato);
			_context.SaveChanges();

			return NoContent(); // O item foi deletado com sucesso
		}
	}
}