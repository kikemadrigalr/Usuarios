using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Usuarios.Models;
using Usuarios.Services;

namespace Usuarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicesAPi _services;

        //inyeccion del servicio al constructor del controlador
        public HomeController(IServicesAPi servicesApi)
        {
           _services = servicesApi;
            //_services permitira ejecutar los metodos para la consulta a la API
        }

        public async Task<IActionResult> Index()
        {
            List<User> users = new List<User>();
            users = await GetUsers();
            return View(users);
        }

        public async Task<IActionResult> DetailsUser()
        {
            List<User> users = new List<User>();
            users = await GetUsers();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Funcion para cargar el listado de los usuarios y enviarlos a la vista
        public async Task<List<User>> GetUsers() 
        {
            List<User> users = new List<User>();
            users = await _services.GetAll();
            return users;
        }
    }
}