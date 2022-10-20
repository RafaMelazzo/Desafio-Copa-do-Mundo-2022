using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using API_Copa_do_Mundo_2022.Models;

namespace TestsAPI
{
    public class AdministradoresTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var adm = await http.GetAsync("https://localhost:49159/api/Administradores");
            Assert.Equal(HttpStatusCode.OK, adm.StatusCode);
        }

        [Fact]
        public async Task GetOneTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var adm = await http.GetAsync("https://localhost:49159/api/Administradores/{id}");
            Assert.Equal(HttpStatusCode.OK, adm.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var adm = await http.PostAsync("https://localhost:49159/api/Administradores",,);
            Assert.Equal(HttpStatusCode.OK, adm.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var adm = await http.PutAsync("https://localhost:49159/api/Administradores",,);
            Assert.Equal(HttpStatusCode.OK, adm.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var adm = await http.DeleteAsync("https://localhost:49159/api/Administradores/{id}");
            Assert.Equal(HttpStatusCode.OK, adm.StatusCode);
        }
    }
}
