namespace OrderApp.Domain;

/// <summary>
/// Refactored OrderProcessor that uses the Facade pattern to simplify order processing.
/// This class now delegates the complex order processing logic to the OrderFacade.
/// </summary>
public class OrderProcessor
{
    private readonly OrderFacade _orderFacade;

    /// <summary>
    /// Initializes a new instance of the OrderProcessor with a default OrderFacade.
    /// </summary>
    public OrderProcessor()
    {
        _orderFacade = new OrderFacade();
    }

    /// <summary>
    /// Initializes a new instance of the OrderProcessor with a custom OrderFacade.
    /// This constructor enables dependency injection for better testability.
    /// </summary>
    /// <param name="orderFacade">The order facade to use for processing orders.</param>
    public OrderProcessor(OrderFacade orderFacade)
    {
        _orderFacade = orderFacade;
    }

    /// <summary>
    /// Processes an order using the facade pattern.
    /// </summary>
    /// <param name="productId">The product identifier to order.</param>
    /// <param name="customerId">The customer identifier placing the order.</param>
    /// <param name="amount">The order amount to be charged.</param>
    /// <param name="address">The shipping address for the order.</param>
    public void ProcessOrder(string productId, string customerId, decimal amount, string address)
    {
        _orderFacade.ProcessOrder(productId, customerId, amount, address);
    }
}