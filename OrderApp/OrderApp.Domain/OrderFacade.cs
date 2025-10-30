namespace OrderApp.Domain;

/// <summary>
/// Facade pattern implementation that simplifies order processing by coordinating
/// inventory, payment, and shipping services.
/// </summary>
public class OrderFacade
{
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly ShippingService _shippingService;

    /// <summary>
    /// Initializes a new instance of the OrderFacade with default service instances.
    /// </summary>
    public OrderFacade()
    {
        _inventoryService = new InventoryService();
        _paymentService = new PaymentService();
        _shippingService = new ShippingService();
    }

    /// <summary>
    /// Initializes a new instance of the OrderFacade with custom service instances.
    /// This constructor enables dependency injection for better testability.
    /// </summary>
    /// <param name="inventoryService">The inventory service to use.</param>
    /// <param name="paymentService">The payment service to use.</param>
    /// <param name="shippingService">The shipping service to use.</param>
    public OrderFacade(InventoryService inventoryService, PaymentService paymentService, ShippingService shippingService)
    {
        _inventoryService = inventoryService;
        _paymentService = paymentService;
        _shippingService = shippingService;
    }

    /// <summary>
    /// Processes an order by coordinating inventory check, payment processing, and shipping.
    /// </summary>
    /// <param name="productId">The product identifier to order.</param>
    /// <param name="customerId">The customer identifier placing the order.</param>
    /// <param name="amount">The order amount to be charged.</param>
    /// <param name="address">The shipping address for the order.</param>
    public void ProcessOrder(string productId, string customerId, decimal amount, string address)
    {
        if (_inventoryService.CheckStock(productId) && _paymentService.ProcessPayment(customerId, amount))
        {
            _shippingService.ShipProduct(productId, address);
        }
    }
}