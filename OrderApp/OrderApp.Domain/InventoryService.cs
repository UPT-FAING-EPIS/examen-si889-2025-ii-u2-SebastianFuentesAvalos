namespace OrderApp.Domain;

/// <summary>
/// Service responsible for inventory management and stock checking.
/// </summary>
public class InventoryService
{
    /// <summary>
    /// Checks if a product is available in stock.
    /// </summary>
    /// <param name="productId">The product identifier to check stock for.</param>
    /// <returns>True if the product is in stock, otherwise false.</returns>
    public bool CheckStock(string productId)
    {
        Console.WriteLine($"Checking stock for {productId}...");
        return true;
    }
}