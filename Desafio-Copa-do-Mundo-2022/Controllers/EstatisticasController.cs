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
    public class EstatisticasController : ControllerBase
    {
        private DbContexto db;
        public EstatisticasController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, db.Estatisticas.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Estatistica estatistica)
        {
            db.Estatisticas.Add(estatistica);
            db.SaveChanges();

            return StatusCode(201, estatistica);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Estatistica estatistica)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Estatistica não encontrado, id precisa ser maior que 0"
                });
            }

            var estatisticaDb = db.Estatisticas.Find(id);
            if (estatisticaDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Estatistica não encontrado, id não existe no banco de dados"
                });
            }

            estatisticaDb.PartidaId = estatistica.PartidaId;
            estatisticaDb.ClubesId = estatistica.ClubesId;
            estatisticaDb.Chutes = estatistica.Chutes;
            estatisticaDb.ChutesAGol = estatistica.ChutesAGol;
            estatisticaDb.PosseDeBola = estatistica.PosseDeBola;
            estatisticaDb.Passes = estatistica.Passes;
            estatisticaDb.PrecisaoDePasses = estatistica.PrecisaoDePasses;
            estatisticaDb.Faltas = estatistica.Faltas;
            estatisticaDb.CartoesAmarelos = estatistica.CartoesAmarelos;
            estatisticaDb.CartoesVermelhos = estatistica.CartoesVermelhos;
            estatisticaDb.Impedimentos = estatistica.Impedimentos;
            estatisticaDb.Escanteios = estatistica.Escanteios;

            db.Estatisticas.Update(estatisticaDb);
            db.SaveChanges();

            return StatusCode(200, estatisticaDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if (id < 1)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Estatistica não encontrado, id precisa ser maior que 0"
                });
            }

            var estatisticaDb = db.Estatisticas.Find(id);
            if (estatisticaDb == null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "Estatistica não encontrado, id não existe no banco de dados"
                });
            }

            db.Estatisticas.Remove(estatisticaDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
