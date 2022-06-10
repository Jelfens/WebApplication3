using Microsoft.AspNetCore.Mvc;
using WebApplication3.Interfaces;
using WebApplication3.Classes;

namespace WebApplication3.Controllers
{
    [Route("api/Home")]
    public class HomeController : Controller
    {
        public static List<Vehicle> vehicles = new List<Vehicle>(){
                new Car() { Id = 1,Color = "Red",Name = "Red Car",HeadLight = false,wheels=4},
                new Car() { Id = 2,Color = "Blue",Name = "Blue Car",HeadLight = false,wheels=4},
                new Car() { Id = 3,Color = "Black",Name = "Black Car",HeadLight = false,wheels=4},
                new Car() { Id = 4,Color = "White",Name = "White Car",HeadLight = false,wheels=4},
                new Boat() { Id = 5,Color = "Red",Name = "Red Boat"},
                new Boat() { Id = 6,Color = "Blue",Name = "Blue Boat"},
                new Boat() { Id = 7,Color = "Black",Name = "Black Boat" },
                new Boat() { Id = 8,Color = "White",Name = "White Boat"},
                new Bus() { Id = 9,Color = "Red", Name = "Red Bus"},
                new Bus() { Id = 10,Color = "Blue",Name = "Blue Bus"},
                new Bus() { Id = 11,Color = "Black",Name = "Black Bus"},
                new Bus() { Id = 12,Color = "White",Name = "White Bus"} };


        private readonly IVehicleOpServices _vehicleOpServices;
        public HomeController(IVehicleOpServices vehicleOpServices)
        {

            _vehicleOpServices = vehicleOpServices;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View(_vehicleOpServices.GetVehicle(vehicles));
        }
        [HttpGet("Car/color/{Color}")]
        public IActionResult Index1(string Color)
        {
            if(_vehicleOpServices.GetCar(vehicles,Color) != null)
            {
                return View(_vehicleOpServices.GetCar(vehicles, Color));
            }
            else
                 return null;
        
        }
        [HttpGet("Car/id/{Id}")]
        public IActionResult Index1(int id)
        {
            return View(_vehicleOpServices.GetCar(vehicles, id));
        }
        [HttpGet("Bus/color/{Color}")]
        public IActionResult Index2(string Color)
        {
            if (_vehicleOpServices.GetBus(vehicles, Color) != null)
            {
                return View(_vehicleOpServices.GetBus(vehicles, Color));
            }
            else
                return null;
        }
        [HttpGet("Boat/color/{Color}")]
        public IActionResult Index3(string Color)
        {
            if (_vehicleOpServices.GetBoat(vehicles, Color) != null)
            {
                return View(_vehicleOpServices.GetBoat(vehicles, Color));
            }
            else
                return null;
        }
        [HttpPost]
        public void Post_hLOnOff([FromBody]int Id)
        {
            
            _vehicleOpServices.hLOnOff(vehicles, Id);
          
        }
        [HttpDelete("{Id}")]
        public void delete_Vehicle(int Id)
        {
            _vehicleOpServices.deleteVehicle(vehicles, Id);
        }
    }
}
