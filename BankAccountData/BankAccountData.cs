using System;


class BankAccountData
{
    static void Main()
    {
        string firstName = "Asya";
        string middleName = "Milkova";
        string lastName = "Milkova";
        decimal availableAmount = 100.88888m;
        string bankName = "Raiffeisen";
        string iban = "bg12rzbb66666666666666";     
        string creditCard1 = "CrCard 1111111111";
        string creditCard2 = "CrCard 1111111112";
        string creditCard3 = "CrCard 1111111113";
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Lasr Name: " + lastName);
        Console.WriteLine("Available Amount: " + availableAmount);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit Card 1: " + creditCard1);
        Console.WriteLine("Credit Card 2: " + creditCard2);
        Console.WriteLine("Credit Card 3: " + creditCard3);
        
    }
}

