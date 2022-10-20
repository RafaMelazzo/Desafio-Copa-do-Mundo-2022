using API_Copa_do_Mundo_2022.Models;
using API_Copa_do_Mundo_2022.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Copa_do_Mundo_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradoresController : ControllerBase
    {
        private DbContexto db;
        public AdministradoresController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Administradores.ToList());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id precisa ser maior que 0"
                });
            }

            var administradorDb = db.Administradores.Find(id);
            if (administradorDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id não existe no banco de dados"
                });
            }

            return StatusCode(200, administradorDb);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Administrador administrador)
        {
            db.Administradores.Add(administrador);
            db.SaveChanges();

            return StatusCode(201, administrador);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Administrador administrador)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id precisa ser maior que 0"
                });
            }

            var administradorDb = db.Administradores.Find(id);
            if (administradorDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id não existe no banco de dados"
                });
            }

            administradorDb.Nome = administrador.Nome;
            administradorDb.Email = administrador.Email;
            administradorDb.Senha = administrador.Senha;

            db.Administradores.Update(administradorDb);
            db.SaveChanges();

            return StatusCode(200, administradorDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id precisa ser maior que 0"
                });
            }

            var administradorDb = db.Administradores.Find(id);
            if (administradorDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Administrador não encontrado, id não existe no banco de dados"
                });
            }

            db.Administradores.Remove(administradorDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
