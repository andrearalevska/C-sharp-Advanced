
using Homework2.Domain;
using Homework2.Domain.Helpers;
using Homework2.Domain.Models;

DataBase.Vehicles.Add(new Vehicle(1, "Bus", 1996, 100));
DataBase.Vehicles.Add(new Vehicle(2, "Plane", 2000, 500));
DataBase.Vehicles.Add(new Vehicle(3, "Van", 2008, 75));
DataBase.Vehicles.Add(new Car(4, "Car", 1996, 500, 75, new List<string> { "Germany", "Poland" }));
DataBase.Vehicles.Add(new Bike(5, "Bike", 2005, 123, "Black"));

foreach(var vehicle in DataBase.Vehicles)
{
    vehicle.PrintVehicle();
}


Car car = new Car(6, "", 1998, 600, 85, new List<string> { "England", "France", "Italy" });
Bike bike = new Bike(0, "Bike", 2008, 256, "Green");
Validator.Validate(car);
Validator.Validate(bike);



          