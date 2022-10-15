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
    public class ClubesController : ControllerBase
    {
        private DbContexto db;
        public ClubesController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Clubes.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Clube clube)
        {
            db.Clubes.Add(clube);
            db.SaveChanges();

            return StatusCode(201, clube);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Clube clube)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Clube não encontrado, id precisa ser maior que 0"
                });
            }

            var clubeDb = db.Clubes.Find(id);
            if (clubeDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Clube não encontrado, id não existe no banco de dados"
                });
            }

            clubeDb.Nome = clube.Nome;
            clubeDb.Descricao = clube.Descricao;
            clubeDb.UrlBandeira = clube.UrlBandeira;
            clubeDb.GruposId = clube.GruposId;

            db.Clubes.Update(clubeDb);
            db.SaveChanges();

            return StatusCode(200, clubeDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Clube não encontrado, id precisa ser maior que 0"
                });
            }

            var clubeDb = db.Clubes.Find(id);
            if (clubeDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Clube não encontrado, id não existe no banco de dados"
                });
            }

            db.Clubes.Remove(clubeDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
