using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestsAPI
{
    public class PartidasTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var ptd = await http.GetAsync("https://localhost:49159/api/Partidas");
            Assert.Equal(HttpStatusCode.OK, ptd.StatusCode);
        }

        [Fact]
        public async Task GetOneTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var ptd = await http.GetAsync("https://localhost:49159/api/Partidas/{id}");
            Assert.Equal(HttpStatusCode.OK, ptd.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var ptd = await http.PostAsync("https://localhost:49159/api/Partidas",,);
            Assert.Equal(HttpStatusCode.OK, ptd.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var ptd = await http.PutAsync("https://localhost:49159/api/Partidas",,);
            Assert.Equal(HttpStatusCode.OK, ptd.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var ptd = await http.DeleteAsync("https://localhost:49159/api/Partidas/{id}");
            Assert.Equal(HttpStatusCode.OK, ptd.StatusCode);
        }
    }
}
