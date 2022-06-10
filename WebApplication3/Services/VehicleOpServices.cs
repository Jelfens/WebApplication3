using WebApplication3.Classes;
using WebApplication3.Interfaces;
using WebApplication3.Controllers;


namespace WebApplication3.Services
{
    public class VehicleOpServices : IVehicleOpServices

    {
   
        public List<Vehicle> GetVehicle(List<Vehicle> vehicles)
        {


            return vehicles;
        }
        public Vehicle? GetCar(List<Vehicle> vehicles,string s)
        {
            foreach (var v in vehicles)
            {
                if(v.GetType() == typeof(Car))
                if (v.Color == s)
                    return v;
            }
            return null;
        }
        public Vehicle? GetCar(List<Vehicle> vehicles, int Id)
        {
            foreach (var v in vehicles)
            {
                if (v.GetType() == typeof(Car))
                    if (v.Id == Id)
                        return v;
            }
            return null;
        }
        public Vehicle? GetBus(List<Vehicle> vehicles, string s)
        {
            foreach (var v in vehicles)
            {
                if(v.GetType().Equals(typeof(Bus)))
                if (v.Color == s)
                    return v;
            }
            return null;
        }
        public Vehicle? GetBoat(List<Vehicle> vehicles, string s)
        {
            foreach (var v in vehicles)
            {
                if (v.GetType() == typeof(Boat))
                    if(v.Color == s)
                    return v;
            }
            return null;
        }
        public void hLOnOff(List<Vehicle> vehicles, int Id)
        {
            foreach(var vehicle in vehicles)
            {
                if(vehicle.Id == Id)
                {
                    if (vehicle is Car)
                    {
                        ((Car)vehicle).HeadLight = !((Car)vehicle).HeadLight;
                        break;
                    }

                         
                }
            }
        }
        public void deleteVehicle(List<Vehicle> vehicles, int id)
        {
            for(int i = 0; i<vehicles.Count; i++)
            {
                if(vehicles[i].Id == id)
                {
                    vehicles.RemoveAt(i);
                    break;
                }       
            }
        }
    }
}
