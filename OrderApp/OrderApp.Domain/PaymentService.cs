namespace OrderApp.Domain;

/// <summary>
/// Service responsible for processing payments.
/// </summary>
public class PaymentService
{
    /// <summary>
    /// Processes a payment for a customer.
    /// </summary>
    /// <param name="customerId">The customer identifier for the payment.</param>
    /// <param name="amount">The amount to be charged.</param>
    /// <returns>True if the payment was processed successfully, otherwise false.</returns>
    public bool ProcessPayment(string customerId, decimal amount)
    {
        Console.WriteLine($"Processing payment for {customerId} of amount {amount}...");
        return true;
    }
}