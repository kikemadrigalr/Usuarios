namespace Usuarios.Models
{
    /// <summary>
    /// clase para manejar la respuesta de la APi usuarios
    /// </summary>
    public class ResultadoApi
    {
        public string Mensaje { get; set; }

        public List<User> lista { get; set; }

        public User ObjUser { get; set; }
    }
}
