using Usuarios.Models;

//En la interfaz se declaran los metodos que utilizara el servicio que se encargara de procesar los usuarios
namespace Usuarios.Services
{
    public interface IServicesAPi
    {
        Task<List<User>> GetAll();

        Task<User> GetById(int id);

        Task<bool> Create(User user);

        Task<bool> Update(User user);

        Task<bool> Delete(int id);
    }
}
