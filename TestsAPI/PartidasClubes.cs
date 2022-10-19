using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestsAPI
{
    public class PartidasClubesTest
    {
        [Fact]
        public async Task GetTest()
        {
            var http = new HttpClient();
            var pcs = await http.GetAsync("https://localhost:49159/api/PartidasClubes");
            Assert.Equal(HttpStatusCode.OK, pcs.StatusCode);
        }

        [Fact]
        public async Task GetTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var pcs = await http.GetAsync("https://localhost:49159/api/PartidasClubes/{id}");
            Assert.Equal(HttpStatusCode.OK, pcs.StatusCode);
        }

        /*[Fact]
        public async Task PostTest()
        {
            var http = new HttpClient();
            var pcs = await http.PostAsync("https://localhost:49159/api/PartidasClubes",,);
            Assert.Equal(HttpStatusCode.OK, pcs.StatusCode);
        }*/

        /*[Fact]
        public async Task PutTest()
        {
            var http = new HttpClient();
            var pcs = await http.PutAsync("https://localhost:49159/api/PartidasClubes",,);
            Assert.Equal(HttpStatusCode.OK, pcs.StatusCode);
        }*/

        [Fact]
        public async Task DeleteTest(ORandom random)
        {
            int id = random();
            var http = new HttpClient();
            var pcs = await http.DeleteAsync("https://localhost:49159/api/PartidasClubes/{id}");
            Assert.Equal(HttpStatusCode.OK, pcs.StatusCode);
        }
    }
}
