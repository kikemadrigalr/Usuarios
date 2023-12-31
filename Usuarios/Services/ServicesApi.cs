﻿using Usuarios.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Usuarios.Services
{
    public class ServicesApi : IServicesAPi
    {
        private static string  _baseUrl;

        public ServicesApi()
        {
            //acceder al archivo de configuracion appsettings para acceder a la informaciond e la Api
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            //Obtener la ruta del Api
            _baseUrl = builder.GetSection("ApiSettings:BaseUrl").Value;
        }

        //Obtener el listado de todos los usuarios del API
        public async Task<List<User>> GetAll()
        {
            List<User> lista = new List<User>();

            //Se define un objeto del tipo Http y la ruta para realizar las consultas al api
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var response = await client.GetAsync("/users");

            //Peticion correcta
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<User>>(json_response);
                lista = result;
            }

            return lista;
        }
    }
}
