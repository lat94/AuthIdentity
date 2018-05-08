using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuthIdentity.Models;
using AuthIdentity.Models.HomeViewModels;
using AuthIdentity.Services;
using Microsoft.AspNetCore.Authorization;

namespace AuthIdentity.Controllers
{
    public class HomeController : Controller
    {

        public WebRestClient rest = new WebRestClient(); 

        [Authorize]
        public IActionResult Index()
        {
           

            List<ClientViewModel> clients = rest.getClients();
            List<SalesViewModel> sales = rest.getSales();
            List<FreightViewModel> freights = rest.getFreights();

            ViewData["Clients"] = clients;
            ViewData["Sales"] = sales;
            ViewData["Freights"] = freights;



            ViewBag.SubTitle = "Listagem de Clientes";


            return View();
        }


        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Authorize]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /*public IActionResult CurvaABC()
        {  
            List<CurvaABCViewModel> curvaABC = rest.getEmployees();     


            return View();
        }*/

        /*public IActionResult LoadClients()
        {
            List<ClientViewModel> clients = rest.getClient();

            ViewData["Clients"] = clients;
            ViewBag.SubTitle = "Listagem de Clientes";




            return View("ClientList");


        }*/


        [Authorize]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
