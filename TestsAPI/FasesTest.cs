using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestsAPI
{
    public class FasesTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var fas = await http.GetAsync("https://localhost:49159/api/Fases");
            Assert.Equal(HttpStatusCode.OK, fas.StatusCode);
        }

        [Fact]
        public async Task GetOneTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var fas = await http.GetAsync("https://localhost:49159/api/Fases/{id}");
            Assert.Equal(HttpStatusCode.OK, fas.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var fas = await http.PostAsync("https://localhost:49159/api/Fases",,);
            Assert.Equal(HttpStatusCode.OK, fas.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var fas = await http.PutAsync("https://localhost:49159/api/Fases",,);
            Assert.Equal(HttpStatusCode.OK, fas.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest()
        {
            var random = new ORandom();
            int id = random.random();
            var http = new HttpClient();
            var fas = await http.DeleteAsync("https://localhost:49159/api/Fases/{id}");
            Assert.Equal(HttpStatusCode.OK, fas.StatusCode);
        }
    }
}
