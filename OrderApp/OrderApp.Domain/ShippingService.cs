namespace OrderApp.Domain;

/// <summary>
/// Service responsible for shipping products to customers.
/// </summary>
public class ShippingService
{
    /// <summary>
    /// Ships a product to the specified address.
    /// </summary>
    /// <param name="productId">The product identifier to be shipped.</param>
    /// <param name="address">The destination address for shipping.</param>
    public void ShipProduct(string productId, string address)
    {
        Console.WriteLine($"Shipping {productId} to {address}...");
    }
}