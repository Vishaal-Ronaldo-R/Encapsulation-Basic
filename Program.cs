// This program demonstrates encapsulation by using a class to manage the bank account balance.
using System;

//The Balance is the namespace that contains the BankBalance class.
using Balance;


public class BankSystem
{
    public static void Main(String[] args)
    {

        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the amount you want to withdraw");
        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
        BankBalance obj = new BankBalance();
       
        obj.Setter(amount);
        obj.Getter();

        Withdraw withdrawObj = new Withdraw();
        withdrawObj.withdrawAmount(withdrawAmount);


    
    }
}