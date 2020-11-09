using ConsumirCli.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ConsumirCli.Controllers
{
    public class FotosController : Controller
    {
        string Baseurl = "https://jsonplaceholder.typicode.com/photos";
        // GET: Fotos
        public async Task<ActionResult> Index()
        {
            List<Fotos> fotos = new List<Fotos>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("/Photos");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    fotos = JsonConvert.DeserializeObject<List<Fotos>>(response);
                }
                return View(fotos);
            }
        }
    }
}