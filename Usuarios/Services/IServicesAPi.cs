using Usuarios.Models;

//En la interfaz se declaran los metodos que utilizara el servicio que se encargara de procesar los usuarios
namespace Usuarios.Services
{
    public interface IServicesAPi
    {
        Task<List<User>> GetAll();
    }
}
