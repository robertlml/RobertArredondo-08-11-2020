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
    public class AlbumsController : Controller
    {
        // GET: Albums
        string Baseurl = "https://jsonplaceholder.typicode.com/albums";
        public async Task<ActionResult> Index()
        {
            List<Albums> albums = new List<Albums>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("/Albums");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    albums = JsonConvert.DeserializeObject<List<Albums>>(response);
                }
                return View(albums);
            }


        }

        public async Task<ActionResult> Vizualizar()
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
        public async Task<ActionResult> Comentarios()
        {
            List<Comentarios> comentarios = new List<Comentarios>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("/Comments");
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    comentarios = JsonConvert.DeserializeObject<List<Comentarios>>(response);
                }
                return View(comentarios);
            }
        }

    }
}