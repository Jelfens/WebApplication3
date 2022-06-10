using WebApplication3.Classes;

namespace WebApplication3.Interfaces
{
    public interface IVehicleOpServices
    {
        public List<Vehicle> GetVehicle(List<Vehicle> vehicles);
        public Vehicle GetCar(List<Vehicle> vehicles, string s);
        public Vehicle GetCar(List<Vehicle> vehicles, int Id);
        public Vehicle GetBus(List<Vehicle> vehicles, string s);
        public Vehicle GetBoat(List<Vehicle> vehicles, string s);
        public void hLOnOff(List<Vehicle> vehicles, int Id);
        public void deleteVehicle(List<Vehicle> vehicles, int id);
    }
}
