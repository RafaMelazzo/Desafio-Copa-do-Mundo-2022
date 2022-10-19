using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestsAPI
{
    public class GruposTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var grs = await http.GetAsync("https://localhost:49159/api/Grupos");
            Assert.Equal(HttpStatusCode.OK, grs.StatusCode);
        }

        [Fact]
        public async Task GetTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var grs = await http.GetAsync("https://localhost:49159/api/Grupos/{id}");
            Assert.Equal(HttpStatusCode.OK, grs.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var grs = await http.PostAsync("https://localhost:49159/api/Grupos",,);
            Assert.Equal(HttpStatusCode.OK, grs.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var grs = await http.PutAsync("https://localhost:49159/api/Grupos",,);
            Assert.Equal(HttpStatusCode.OK, grs.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var grs = await http.DeleteAsync("https://localhost:49159/api/Grupos/{id}");
            Assert.Equal(HttpStatusCode.OK, grs.StatusCode);
        }
    }
}
