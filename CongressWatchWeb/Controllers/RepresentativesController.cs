using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CongressWatchWeb.Models;
using Newtonsoft.Json;

namespace CongressWatchWeb.Controllers
{
    public class RepresentativesController : Controller
    {
        static Uri s_ServiceBaseUri = new Uri("http://congresswatch.azurewebsites.net");
 
        public RepresentativesController()
        {
        }

        // GET: Representatives
        public IActionResult Index()
        {
            return View();
        }

        // GET: Representatives/ZipCode/5
        public async Task<IActionResult> ZipCode(string zipcode)
        {
            List<Representative> representatives = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = s_ServiceBaseUri;
                var response = await client.GetAsync("/zipcode/" + zipcode);
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                representatives = JsonConvert.DeserializeObject<List<Representative>>(stringResult);
            }

            return View(representatives);
        }

        // GET: Representatives/SenateList
        public async Task<IActionResult> SenateList()
        {
            List<RepresentativeDetail> representatives = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = s_ServiceBaseUri;
                var response = await client.GetAsync("/senate");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                representatives = JsonConvert.DeserializeObject<List<RepresentativeDetail>>(stringResult);
            }

            return View(representatives);
        }

        // GET: Representatives/HouseList
        public async Task<IActionResult> HouseList()
        {
            List<RepresentativeDetail> representatives = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = s_ServiceBaseUri;
                var response = await client.GetAsync("/house");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                representatives = JsonConvert.DeserializeObject<List<RepresentativeDetail>>(stringResult);
            }

            return View(representatives);
        }
    }
}
