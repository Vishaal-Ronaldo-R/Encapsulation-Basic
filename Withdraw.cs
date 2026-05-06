using System;
using Balance;

public class Withdraw : BankBalance
{
    public void withdrawAmount(int amount)
    {
        if (accountBalance <= 0)
        {
            Console.WriteLine("Your account balance is zero. You cannot withdraw amount");
        }

        else 
        {
            if(amount > 0 && amount <= accountBalance)
            {
                Console.WriteLine("You have withdrawn " + amount + " from your account");
                accountBalance -= amount;
                Console.WriteLine("Your current account balance is " + accountBalance);
            }
            else
            {
                Console.WriteLine("You cannot withdraw this amount. Please enter a valid amount");
            }
        }
    }
}