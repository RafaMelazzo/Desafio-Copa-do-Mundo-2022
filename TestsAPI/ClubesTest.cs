using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestsAPI
{
    public class ClubesTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var cls = await http.GetAsync("https://localhost:49159/api/Clubes");
            Assert.Equal(HttpStatusCode.OK, cls.StatusCode);
        }

        [Fact]
        public async Task GetTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var cls = await http.GetAsync("https://localhost:49159/api/Clubes/{id}");
            Assert.Equal(HttpStatusCode.OK, cls.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var cls = await http.PostAsync("https://localhost:49159/api/Clubes",,);
            Assert.Equal(HttpStatusCode.OK, cls.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var cls = await http.PutAsync("https://localhost:49159/api/Clubes",,);
            Assert.Equal(HttpStatusCode.OK, cls.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var cls = await http.DeleteAsync("https://localhost:49159/api/Clubes/{id}");
            Assert.Equal(HttpStatusCode.OK, cls.StatusCode);
        }
    }
}
