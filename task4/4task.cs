using System;
using System.Collections.Generic;

class Vehicle
{
    public string ID { get; set; }
    public string Name { get; set; }
}

class Driver
{
    public string Name { get; set; }
    public Vehicle AssignedVehicle { get; set; }
}

class Dispatch
{
    private List<Driver> drivers = new List<Driver>();
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AssignDriverToVehicle(Driver driver, Vehicle vehicle)
    {
        driver.AssignedVehicle = vehicle;
    }

    public void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

    public void RemoveDriver(Driver driver)
    {
        drivers.Remove(driver);
    }

    public void RepairRequest(Driver driver)
    {
        Console.WriteLine($"Repair request from {driver.Name} for vehicle {driver.AssignedVehicle.Name}");
    }

    public void SuspendDriver(Driver driver)
    {
        Console.WriteLine($"{driver.Name} is suspended from work.");
        driver.AssignedVehicle = null;
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle { ID = "1", Name = "Vehicle1" };
        Vehicle vehicle2 = new Vehicle { ID = "2", Name = "Vehicle2" };

        Driver driver1 = new Driver { Name = "Driver1" };
        Driver driver2 = new Driver { Name = "Driver2" };

        Dispatch dispatch = new Dispatch();
        dispatch.AddDriver(driver1);
        dispatch.AddDriver(driver2);

        dispatch.AssignDriverToVehicle(driver1, vehicle1);
        dispatch.AssignDriverToVehicle(driver2, vehicle2);

        dispatch.RepairRequest(driver1);
        dispatch.SuspendDriver(driver1);
    }
}
