namespace atm;
public class Bill
{
    private bool _IsPaid = false;
    public Card Destination { get; init; }
    public string Title { get; init; }
    public String Description { get; init; }
    public Decimal Value { get; init; }
    public Bill(Card emiter, string title, string description, decimal amount)
    {
        this.Destination = emiter;
        this.Title = title;
        this.Value = amount;
    }
    public Bill(Card emiter, string title, decimal amount) : this(emiter, title, "no description provided", amount)
    {

    }
public Bill(Card emiter, decimal amount):this(emiter, "no title provided", "no description provided", amount)
{
    
}
Transaction Pay(Card source)
{
_IsPaid=true;
return new(source, Destination, Value);
}
}