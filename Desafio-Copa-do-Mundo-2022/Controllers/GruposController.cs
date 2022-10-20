using API_Copa_do_Mundo_2022.Models;
using API_Copa_do_Mundo_2022.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace API_Copa_do_Mundo_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private DbContexto db;
        public GruposController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Grupos.ToList());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id precisa ser maior que 0"
                });
            }

            var grupoDb = db.Grupos.Find(id);
            if (grupoDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id não existe no banco de dados"
                });
            }

            return StatusCode(200, grupoDb);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Grupo grupo)
        {
            db.Grupos.Add(grupo);
            db.SaveChanges();

            return StatusCode(201, grupo);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Grupo grupo)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id precisa ser maior que 0"
                });
            }

            var grupoDb = db.Grupos.Find(id);
            if (grupoDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id não existe no banco de dados"
                });
            }

            grupoDb.Nome = grupo.Nome;

            db.Grupos.Update(grupoDb);
            db.SaveChanges();

            return StatusCode(200, grupoDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id precisa ser maior que 0"
                });
            }

            var grupoDb = db.Grupos.Find(id);
            if (grupoDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Grupo não encontrado, id não existe no banco de dados"
                });
            }

            db.Grupos.Remove(grupoDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
