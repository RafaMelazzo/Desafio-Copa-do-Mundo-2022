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
    public class PartidasClubesController : ControllerBase
    {
        private DbContexto db;
        public PartidasClubesController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.PartidasClubes.ToList());
        }

        [HttpGet]
        [Route("{partidaId}")]
        public ActionResult Get(int partidaId)
        {
            if (partidaId < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id precisa ser maior que 0"
                });
            }

            var partidaClubeDb = db.PartidasClubes.Find(partidaId);
            if (partidaClubeDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id não existe no banco de dados"
                });
            }

            return StatusCode(200, partidaClubeDb);
        }

        [HttpPost]
        public ActionResult Post([FromBody] PartidaClube partidaClube)
        {
            db.PartidasClubes.Add(partidaClube);
            db.SaveChanges();

            return StatusCode(201, partidaClube);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] PartidaClube partidaClube)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id precisa ser maior que 0"
                });
            }

            var partidaClubeDb = db.PartidasClubes.Find(id);
            if (partidaClubeDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id não existe no banco de dados"
                });
            }

            partidaClubeDb.PartidaId = partidaClube.PartidaId;
            partidaClubeDb.ClubeIdA = partidaClube.ClubeIdA;
            partidaClubeDb.ClubeIdB = partidaClube.ClubeIdB;

            db.PartidasClubes.Update(partidaClubeDb);
            db.SaveChanges();

            return StatusCode(200, partidaClubeDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id precisa ser maior que 0"
                });
            }

            var partidaClubeDb = db.PartidasClubes.Find(id);
            if (partidaClubeDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Partida de Clubes não encontrado, id não existe no banco de dados"
                });
            }

            db.PartidasClubes.Remove(partidaClubeDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
