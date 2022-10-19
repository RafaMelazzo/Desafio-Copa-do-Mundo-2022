using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
