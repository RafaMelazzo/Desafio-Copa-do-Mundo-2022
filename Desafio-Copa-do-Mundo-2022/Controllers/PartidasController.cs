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
    public class PartidasController : ControllerBase
    {
        private DbContexto db;
        public PartidasController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Partidas.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Partida partida)
        {
            db.Partidas.Add(partida);
            db.SaveChanges();

            return StatusCode(201, partida);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Partida partida)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida não encontrado, id precisa ser maior que 0"
                });
            }

            var partidaDb = db.Partidas.Find(id);
            if (partidaDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida não encontrado, id não existe no banco de dados"
                });
            }

            partidaDb.FasesId = partida.FasesId;
            partidaDb.DataHora = partida.DataHora;
            partidaDb.Iniciado = partida.Iniciado;
            partidaDb.Finalizado = partida.Finalizado;

            db.Partidas.Update(partidaDb);
            db.SaveChanges();

            return StatusCode(200, partidaDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida não encontrado, id precisa ser maior que 0"
                });
            }

            var partidaDb = db.Partidas.Find(id);
            if (partidaDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida não encontrado, id não existe no banco de dados"
                });
            }

            db.Partidas.Remove(partidaDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
