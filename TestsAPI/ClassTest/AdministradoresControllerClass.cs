using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Copa_do_Mundo_2022.Services;
using API_Copa_do_Mundo_2022.Models;
using API_Copa_do_Mundo_2022.Controllers;

namespace TestsAPI.ClassTest
{
    public class AdministradoresControllerClass : IAdministradoresController
    {
        private readonly List<Administrador> _administrador;

        public AdministradoresControllerClass()
        {
            _administrador = new List<Administrador>()
            {
                new Administrador(){Id=1,Nome="Rodolfo",Email="Rodolfo@gmail.com",Senha="ROdo"},
                new Administrador(){Id=2,Nome="Agusto",Email= "Agusto@gmail.com", Senha="pereira64"},
                new Administrador(){Id=3,Nome="tulio",Email="tulio@gmail.com",Senha="rodado"},
                new Administrador(){Id=4,Nome="Azevedo ramos",Email="azramos@gmail.com",Senha="653107"},
                new Administrador(){Id=5,Nome="Eu",Email="Tu@gmail.com",Senha="Nos"}
            };
        }
        public List<Administrador> Get()
        {
            return _administrador;
        }

        public Administrador Post(Administrador administrador)
        {
            _administrador.Add(administrador);
            return administrador;
        }

        public Administrador Atualizar(int id, Administrador administrador)
        {

            var adm = _administrador.Find(i => i.Id == id);
            string nome = string.Empty;
            string email = string.Empty;
            string senha = string.Empty;
            adm.Nome = (nome=BOOL()?"Rafael":"");
            adm.Email = administrador.Email = (email = BOOL() ? "rafaMelazzo@gmail.com" : "");
            adm.Senha = administrador.Senha = (senha = BOOL() ? "R4Me1ae1m31azz0" : "");

            return (adm);
        }
        public void Excluir(int id)
        {
            _administrador.Remove(_administrador.Find(i => i.Id == id));
        }

        static bool BOOL()
        {
            Random random = new Random();
            return random.Next(0,1)==1;
        }
    }
}
