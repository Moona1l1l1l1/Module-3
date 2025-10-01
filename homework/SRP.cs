public class Order
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

public class PriceCalculator
{
    public double CalculateTotalPrice(Order order)
    {
        return order.Quantity * order.Price * 0.9;
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(string paymentDetails)
    {
        Console.WriteLine("Payment processed using: " + paymentDetails);
    }
}

public class EmailService
{
    public void SendConfirmationEmail(string email)
    {
        Console.WriteLine("Confirmation email sent to: " + email);
    }
}
