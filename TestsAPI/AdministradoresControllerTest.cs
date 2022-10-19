using API_Copa_do_Mundo_2022;
using API_Copa_do_Mundo_2022.Controllers;
using API_Copa_do_Mundo_2022.Models;
using API_Copa_do_Mundo_2022.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TestsAPI.ClassTest;
using Xunit;

namespace TestsAPI
{
    public class AdministradoresControllerTest
    {
        [Fact]
        public async Task HelloWorldTest()
        {
            var http = new HttpClient();
            var clientes = await http.GetAsync("https://localhost:49159/api/Administradores");
            Assert.Equal(HttpStatusCode.OK, clientes.StatusCode);
        }
    }
}
