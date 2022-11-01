namespace atm;
public class Transaction
{
    private Card From { get; init; }
    private Card To { get; init; }
    private Decimal Sum { get; init; }
    public Transaction(Card from, Card to, Decimal sum)
    {
        this.From = from;
        this.To = to;
        this.Sum = sum;
    }
    public void Perform()
    {
        //begin transaction
        From.Retrieve(Sum);
        To.Deposit(Sum);
        //commit
    }
}