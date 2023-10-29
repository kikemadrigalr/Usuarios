using System.Net;

//Modelo Usuario
namespace Usuarios.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

    }
}
