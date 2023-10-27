using System;
using System.Collections.Generic;
using System.Linq;

class Passenger
{
    public string Destination { get; set; }
    public DateTime TravelDate { get; set; }

    public Train ChooseTrain(List<Train> availableTrains)
    {
        List<Train> suitableTrains = availableTrains
            .Where(train => train.EndStation == Destination)
            .ToList();

        if (suitableTrains.Count == 0)
        {
            Console.WriteLine("No suitable trains available for the destination.");
            return null;
        }

        Console.WriteLine("Available Trains:");
        foreach (var train in suitableTrains)
        {
            Console.WriteLine($"Train Number: {train.TrainNumber}, Price: ${train.Price}");
        }

        Console.Write("Enter the Train Number you want to choose: ");
        int selectedTrainNumber = int.Parse(Console.ReadLine());

        Train selectedTrain = suitableTrains.FirstOrDefault(train => train.TrainNumber == selectedTrainNumber);

        if (selectedTrain == null)
        {
            Console.WriteLine("Invalid Train Number. Please try again.");
            return null;
        }

        return selectedTrain;
    }
}

class Train
{
    public int TrainNumber { get; set; }
    public string StartStation { get; set; }
    public string EndStation { get; set; }
    public decimal Price { get; set; }

    public decimal CalculatePrice()
    {
        return Price;
    }
}

class Ticket
{
    public Passenger Passenger { get; set; }
    public Train ChosenTrain { get; set; }
    public decimal PaymentAmount { get; set; }
}

class TicketSystem
{
    private List<Train> availableTrains;

    public TicketSystem(List<Train> trains)
    {
        availableTrains = trains;
    }

    public Ticket RegisterRequest(Passenger passenger)
    {
        Train selectedTrain = passenger.ChooseTrain(availableTrains);

        if (selectedTrain == null)
        {
            return null;
        }

        decimal paymentAmount = selectedTrain.CalculatePrice();
        Ticket ticket = new Ticket { Passenger = passenger, ChosenTrain = selectedTrain, PaymentAmount = paymentAmount };
        return ticket;
    }
}

class Program
{
    static void Main()
    {
        // Create and initialize trains
        List<Train> trains = new List<Train>
        {
            new Train { TrainNumber = 1, StartStation = "StationA", EndStation = "StationB", Price = 50.0m },
            new Train { TrainNumber = 2, StartStation = "StationB", EndStation = "StationC", Price = 60.0m },
            // Add more trains
        };

        TicketSystem ticketSystem = new TicketSystem(trains);

        // Create a passenger and register a request
        Passenger passenger = new Passenger
        {
            Destination = "StationC",
            TravelDate = DateTime.Now.Date,
        };

        Ticket ticket = ticketSystem.RegisterRequest(passenger);

        if (ticket != null)
        {
            // Display the ticket information
            Console.WriteLine("Ticket Information:");
            Console.WriteLine($"Passenger: Destination - {ticket.Passenger.Destination}, Date - {ticket.Passenger.TravelDate.ToShortDateString()}");
            Console.WriteLine($"Chosen Train: Train Number - {ticket.ChosenTrain.TrainNumber}, Price - ${ticket.ChosenTrain.Price}");
            Console.WriteLine($"Payment Amount: ${ticket.PaymentAmount}");
        }
    }
}
