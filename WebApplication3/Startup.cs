using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication3.Classes;
using WebApplication3.Interfaces;
using WebApplication3.Services;
namespace WebApplication3
{
    public class Startup
    {
                public List<Vehicle> vehicles = new List<Vehicle>(){
                new Car() { Id = 1,Color = "Red",Name = "Red Car",HeadLight = false},
                new Car() { Id = 2,Color = "Blue",Name = "Blue Car",HeadLight = false},
                new Car() { Id = 3,Color = "Black",Name = "Black Car",HeadLight = false },
                new Car() { Id = 4,Color = "White",Name = "White Car",HeadLight = false},
                new Boat() { Id = 5,Color = "Red",Name = "Red Boat"},
                new Boat() { Id = 6,Color = "Blue",Name = "Blue Boat"},
                new Boat() { Id = 7,Color = "Black",Name = "Black Boat" },
                new Boat() { Id = 8,Color = "White",Name = "White Boat"},
                new Bus() { Id = 9,Color = "Red", Name = "Red Bus"},
                new Bus() { Id = 10,Color = "Blue",Name = "Blue Bus"},
                new Bus() { Id = 11,Color = "Black",Name = "Black Bus"},
                new Bus() { Id = 12,Color = "White",Name = "White Bus"} };

        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddMvc();
            services.AddScoped<IVehicleOpServices,VehicleOpServices>();
            services.AddControllers();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
