using API_Copa_do_Mundo_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Copa_do_Mundo_2022.Services
{
    public interface IAdministradoresController
    {
        public List<Administrador> Get();
        public Administrador Post(Administrador administrador);
        public Administrador Atualizar(int id, Administrador administrador);
        public void Excluir(int id);
    }
}
