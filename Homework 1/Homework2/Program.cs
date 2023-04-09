using Homework2.Domain.Enums;
using Homework2.Domain.Models;

Console.WriteLine("Car:");
Car car = new Car(VehicleType.Car, "Audi");
car.Drive();

Console.WriteLine("Truck:");
Truck truck = new Truck(VehicleType.Truck, "Mercedes");
truck.Drive();

Console.WriteLine("Car center:");
CarCenter carCenter = new CarCenter();
carCenter.WashCar(car);
carCenter.WashTrailer(truck);
carCenter.CheckVehicle(car);
carCenter.CheckVehicle(truck);
carCenter.FixVehicle(car);
carCenter.FixVehicle(truck);
carCenter.PumpGas(car);
carCenter.PumpGas(truck);

Console.WriteLine("Car Wash:");
CarWash carWash = new CarWash();
carWash.WashCar(car);
carWash.WashTrailer(truck);

Console.WriteLine("Gas Pump:");
GasPump gasPump = new GasPump();
gasPump.PumpGas(car);
gasPump.PumpGas(truck);

Console.WriteLine("Repair Service:");
RepairService repairService = new RepairService();
repairService.CheckVehicle(car);
repairService.CheckVehicle(truck);
repairService.FixVehicle(car);
repairService.FixVehicle(truck);





