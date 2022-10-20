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
    public class FasesController : ControllerBase
    {
        private DbContexto db;
        public FasesController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Fases.ToList());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fases não encontrado, id precisa ser maior que 0"
                });
            }

            var faseDb = db.Fases.Find(id);
            if (faseDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fases não encontrado, id não existe no banco de dados"
                });
            }

            return StatusCode(200, faseDb);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Fase fase)
        {
            db.Fases.Add(fase);
            db.SaveChanges();

            return StatusCode(201, fase);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Fase fase)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fase não encontrado, id precisa ser maior que 0"
                });
            }

            var faseDb = db.Fases.Find(id);
            if (faseDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fase não encontrado, id não existe no banco de dados"
                });
            }

            faseDb.Nome = fase.Nome;

            db.Fases.Update(faseDb);
            db.SaveChanges();

            return StatusCode(200, faseDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fase não encontrado, id precisa ser maior que 0"
                });
            }

            var faseDb = db.Fases.Find(id);
            if (faseDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Fase não encontrado, id não existe no banco de dados"
                });
            }

            db.Fases.Remove(faseDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
