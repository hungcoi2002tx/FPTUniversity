// See https://aka.ms/new-console-template for more information
// Fetch the Regular Bike and Car Details
// Creating RegularVehicleFactory instance
using AbstractFactoryPattern;

IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
IBike regularBike = regularVehicleFactory.CreateBike();
regularBike.GetDetails();
ICar regularCar = regularVehicleFactory.CreateCar();
regularCar.GetDetails();

IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
IBike sportsBike = sportsVehicleFactory.CreateBike();
sportsBike.GetDetails();
ICar sportsCar = sportsVehicleFactory.CreateCar();
sportsCar.GetDetails();
Console.ReadKey();
