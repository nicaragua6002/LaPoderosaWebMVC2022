using Microsoft.Owin;
using Owin;
using LaPoderosaWebMVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(LaPoderosaWebMVC.Startup))]
namespace LaPoderosaWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //Creamos roles y usuarios
             CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            //accedemos al modelo de la seguridad integrada
            ApplicationDbContext context = new ApplicationDbContext();

            //definimos las variables manejadoras de roles y usuarios
            var ManejadorRol = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var ManejadorUsuario = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Verificamos la excistencia de los roles por defecto
            if (!ManejadorRol.RoleExists("Admin"))
            {
                //sino existe, se crea el rol y se asigna un nuevo usuario con ese rol

                var rol = new IdentityRole();
                rol.Name = "Admin";
                ManejadorRol.Create(rol);

                //creamos un primer usuario para ese rol
                var user = new ApplicationUser();
                user.UserName = "Admin@unan.edu.ni";
                user.Email = "Admin@unan.edu.ni";
                string PWD = "12345678";

                var chkUser = ManejadorUsuario.Create(user, PWD);

                //si se creo con exito

            if(chkUser.Succeeded)
                {
                    ManejadorUsuario.AddToRole(user.Id, "Admin");
                }
                    
             }

            //Verificamos la excistencia de los roles por defecto
            if (!ManejadorRol.RoleExists("Digitador"))
            {
                //sino existe, se crea el rol y se asigna un nuevo usuario con ese rol

                var rol = new IdentityRole();
                rol.Name = "Digitador";
                ManejadorRol.Create(rol);

                //creamos un primer usuario para ese rol
                var user = new ApplicationUser();
                user.UserName = "rsolis@unan.edu.ni";
                user.Email = "rsolis@unan.edu.ni";
                string PWD = "12345678";

                var chkUser = ManejadorUsuario.Create(user, PWD);
            }
            }
    }
}
