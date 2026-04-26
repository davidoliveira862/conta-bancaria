using System;




public class Account

{

public double Number { get; private set; }
public String Holder { get; private set; }
public double Balance { get; private set; }
public double WithdrawLimit { get; private set; }

public Account(double number, string holder, double balance,double withdrawlimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawlimit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;

    }

    public void Withdraw(double amount)
    {
        if(amount > WithdrawLimit)
        {

            throw new  Exception("Error : value exepet Withdraw Limit.");

        }

        if(amount > Balance)
        {
            throw new Exception("Error: Balance insufficient");
        }

        Balance -= amount;
    }


}

