using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Net;

namespace Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clubes()
        {
            string clubesUrl = new WebClient().DownloadString("https://localhost:5001/api/Clubes");
            string ClubesJson = System.IO.File.ReadAllText(clubesUrl);
            JArray parseClubes = JArray.Parse(ClubesJson);
            ViewData["ClubeViewModel"] = parseClubes;
            return View();

            //return View(parseClubes);

            //var clubesDeserialized = JsonConvert.DeserializeObject<ClubesJson>((string)parseClubes);
            //return View(clubesDeserialized.clubes);

            //IEnumerable<ClubeViewModel> clubes = null;

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44308/api/");
            //    //HTTP GET
            //    var responseTask = client.GetAsync("clube");
            //    responseTask.Wait();

            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<IList<ClubeViewModel>>();
            //        readTask.Wait();

            //        clubes = readTask.Result;
            //    }
            //    else //web api sent error response 
            //    {
            //        //log response status here...

            //        clubes = Enumerable.Empty<ClubeViewModel>();

            //        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //    }
            //}
            //return View();
        }
    }
}
