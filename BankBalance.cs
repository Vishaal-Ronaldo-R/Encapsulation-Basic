//The balance of the bank account is stored in a static variable.

using System;
namespace Balance
{
    
    public class BankBalance
    {
        private static int accountBalance = 0;
    
// The setter method adds the amount to the existing balance.

    public void Setter(int amount)
    {

        accountBalance += amount;
         
    }

// The getter method displays the current balance of the account.
    
    public void Getter()
     {
        Console.WriteLine("The account balance is " + accountBalance);
     }
    }
}