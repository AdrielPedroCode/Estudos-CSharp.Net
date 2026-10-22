
using Exercicio_Exception.Entities.Exception;

internal class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account()
    {
    }
    public Account(int number, string holder, double balance, double withDrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withDrawLimit;
    }
    public void Deposit(double amount)
    {
        amount += Balance;
    }
    public void Withdraw(double amount)
    {
        Balance -= amount;

        if (amount > WithdrawLimit)
        {
            throw new DomainException("Withdraw error: the amount exceeds withdraw limit");
        }
        if (Balance < amount)
        {
            throw new DomainException("Withdraw error: Not enouth balance");
        }

    }

}

