﻿using System;

public class Customer
{
    public int customerId { get; set; }
    public string lastName { get; set; }
    public string firstName { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zipCode { get; set; }
    public string phone { get; set; }
    public string eMail { get; set; }
    public string password { get; set; }

    public Customer()
    {
        customerId = 0;
        lastName = "Null";
        firstName = "Null";
        street = "Null";
        city = "Null";
        state = "Null";
        zipCode = "Null";
        phone = "Null";
        eMail = "Null";
        password = "Null";
    }

    public Customer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string eMail, string password)
    {
        this.customerId = customerId;
        this.lastName = lastName;
        this.firstName = firstName;
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
        this.phone = phone;
        this.eMail = eMail;
        this.password = password;
    }
}

public class RetailCustomer : Customer
{
    public string creditCardType { get; set; }
    public string creditCardNo { get; set; }

    public RetailCustomer() : base()
    {
        creditCardType = "Null";
        creditCardNo = "Null";
    }

    public RetailCustomer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string eMail, string password, string creditCardType, string creditCardNo)
        : base(customerId, lastName, firstName, street, city, state, zipCode, phone, eMail, password)
    {
        this.creditCardType = creditCardType;
        this.creditCardNo = creditCardNo;
    }
}

public class CorporateCustomer : Customer
{
    public string companyName { get; set; }
    public int frequentFlyerPts { get; set; }
    public string billingAccountNo { get; set; }

    public CorporateCustomer() : base()
    {
        companyName = "Null";
        frequentFlyerPts = 0;
        billingAccountNo = "Null";
    }

    public CorporateCustomer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string eMail, string password, string companyName, int frequentFlyerPts, string billingAccountNo)
        : base(customerId, lastName, firstName, street, city, state, zipCode, phone, eMail, password)
    {
        this.companyName = companyName;
        this.frequentFlyerPts = frequentFlyerPts;
        this.billingAccountNo = billingAccountNo;
    }
}

public class Reservation
{
    public int reservationNo { get; set; }
    public DateTime date { get; set; }

    public Reservation()
    {
        reservationNo = 0;
        date = DateTime.MinValue;
    }

    public Reservation(int reservationNo, DateTime date)
    {
        this.reservationNo = reservationNo;
        this.date = date;
    }
}

public class Seat
{
    public int rowNo { get; set; }
    public int seatNo { get; set; }
    public decimal price { get; set; }
    public string status { get; set; }

    public Seat()
    {
        rowNo = 0;
        seatNo = 0;
        price = 0.0m;
        status = "Null";
    }

    public Seat(int rowNo, int seatNo, decimal price, string status)
    {
        this.rowNo = rowNo;
        this.seatNo = seatNo;
        this.price = price;
        this.status = status;
    }
}

public class Flight
{
    public int flightId { get; set; }
    public DateTime date { get; set; }
    public string origin { get; set; }
    public string destination { get; set; }
    public TimeSpan departureTime { get; set; }
    public TimeSpan arrivalTime { get; set; }
    public int seatingCapacity { get; set; }

    public Flight()
    {
        flightId = 0;
        date = DateTime.MinValue;
        origin = "Null";
        destination = "Null";
        departureTime = TimeSpan.Zero;
        arrivalTime = TimeSpan.Zero;
        seatingCapacity = 0;
    }

    public Flight(int flightId, DateTime date, string origin, string destination, TimeSpan departureTime, TimeSpan arrivalTime, int seatingCapacity)
    {
        this.flightId = flightId;
        this.date = date;
        this.origin = origin;
        this.destination = destination;
        this.departureTime = departureTime;
        this.arrivalTime = arrivalTime;
        this.seatingCapacity = seatingCapacity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RetailCustomer retailCustomer1 = new RetailCustomer(1, "Sami", "Abdul", "Ghanta Ghar", "Faisalabad", "Punjab", "38000", "1234567890", "sami@example.com", "1234", "Visa", "4111111111111111");
        CorporateCustomer corporateCustomer1 = new CorporateCustomer(2, "Furqan", "Ahmad", "MDA Chowk", "Multan", "Punjab", "60000", "0987654321", "ahmad@example.com", "4321", "Medical", 10000, "12345678");
        Reservation reservation1 = new Reservation(101, DateTime.Now);
        Seat seat1 = new Seat(2, 10, 200.0m, "Available");
        Flight flight1 = new Flight(121, DateTime.Today.AddDays(5), "Faisalabad", "Multan", new TimeSpan(15, 30, 0), new TimeSpan(17, 30, 0), 180);

        Console.WriteLine("----------------------------- Updated Values of Class 'Retail Customer'");
        Console.WriteLine($" Customer ID: {retailCustomer1.customerId}\n Last Name: {retailCustomer1.lastName}\n First Name: {retailCustomer1.firstName}\n Street: {retailCustomer1.street}\n City: {retailCustomer1.city}\n State: {retailCustomer1.state}\n Zip Code: {retailCustomer1.zipCode}\n Phone: {retailCustomer1.phone}\n Email: {retailCustomer1.eMail}\n Password: {retailCustomer1.password}\n Credit Card Type: {retailCustomer1.creditCardType}\n Credit Card No.: {retailCustomer1.creditCardNo}\n");

        Console.WriteLine("----------------------------- Updated Values of Class 'Corporate Customer'");
        Console.WriteLine($" Customer ID: {corporateCustomer1.customerId}\n Last Name: {corporateCustomer1.lastName}\n First Name: {corporateCustomer1.firstName}\n Street: {corporateCustomer1.street}\n City: {corporateCustomer1.city}\n State: {corporateCustomer1.state}\n Zip Code: {corporateCustomer1.zipCode}\n Phone: {corporateCustomer1.phone}\n Email: {corporateCustomer1.eMail}\n Password: {corporateCustomer1.password}\n Company Name: {corporateCustomer1.companyName}\n Frequent Flyer Points: {corporateCustomer1.frequentFlyerPts}\n Billing Account No.: {corporateCustomer1.billingAccountNo}\n");

        Console.WriteLine("----------------------------- Updated Values of Class 'Reservation'");
        Console.WriteLine($" Reservation No.: {reservation1.reservationNo}\n Date: {reservation1.date}\n");

        Console.WriteLine("----------------------------- Updated Values of Class 'Seat'");
        Console.WriteLine($" Row No.: {seat1.rowNo}\n Seat No.: {seat1.seatNo}\n Price: {seat1.price}\n Status: {seat1.status}\n");

        Console.WriteLine("----------------------------- Updated Values of Class 'Flight'");
        Console.WriteLine($" Flight ID: {flight1.flightId}\n Date: {flight1.date}\n Origin: {flight1.origin}\n Destination: {flight1.destination}\n Departure Time: {flight1.departureTime}\n Arrival Time: {flight1.arrivalTime}\n Seating Capacity: {flight1.seatingCapacity}\n");
    }



}
