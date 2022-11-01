using System;

namespace atm;
public class Card
{
    public Guid CardNumber { get; set; }
    private string Pin { get; set; }
    public Decimal Amount { get; private set; }
    private bool IsUnlocked;

    public Card(string pin, decimal amount)
    {
        this.CardNumber = Guid.NewGuid();
        this.Pin = pin;
        this.Amount = amount;
    }

    public bool Unlock(string code)
    {
        if (code == this.Pin)
        {
            IsUnlocked = true;
            return true;
        }
        return false;
    }
    public void Retrieve(Decimal sum)
    {
        if (Amount - sum < 0)
        {
            throw new InvalidOperationException("overdraft protection isn't enabled, can't take more than you already have");
        }
        Amount -= sum;
    }
    public void Deposit(Decimal sum)
    {
        //I don't think there are any invalid states here
        Amount += sum;
    }
    public void Lock()
    {
        IsUnlocked = false;
    }
}