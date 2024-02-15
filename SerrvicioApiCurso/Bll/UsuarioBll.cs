using SerrvicioApiCurso.Models;

namespace SerrvicioApiCurso.Bll
{
    public class UsuarioBll
    {

    List<UsersServiceModel> Usuarios = new List<UsersServiceModel>
    {
        new UsersServiceModel
        {
            Id = 1,
            Name = "Javier",
            LastName = "Contreras",
            Age = 35,
        },
        new UsersServiceModel
        {
            Id = 2,
            Name = "Jahir",
            LastName = "Mendoza",
            Age = 25,
        },
        new UsersServiceModel
        {
            Id = 3,
            Name = "Josué",
            LastName = "Albarracín",
            Age = 32,
        },
        new UsersServiceModel
        {
            Id = 4,
            Name = "José",
            LastName = "Pérez",
            Age = 48,
        },

    };

        public List<UsersServiceModel> GetUsuarios() {
            return Usuarios.ToList();
        }

        public UsersServiceModel GetUser(int Id)
        {
            try
            {
                return Usuarios.Where(x => x.Id == Id).First();

            } catch
            {
                return null;
            }

        }

    }
}
