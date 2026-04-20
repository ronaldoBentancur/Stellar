using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.InterfacesRepositorio;
using LogicaAplicacion.CasosDeUso;
using CasosUso.InterfacesCU;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>(); 
            builder.Services.AddScoped<ILogin, Login>();

            builder.Services.AddSession();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Usuario}/{action=Login}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
