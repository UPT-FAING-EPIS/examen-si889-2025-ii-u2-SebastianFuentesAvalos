using System;
using System.IO;

namespace OrderApp.Domain.Tests;

/// <summary>
/// Unit tests for OrderProcessor and OrderFacade classes using the Facade pattern.
/// </summary>
public class OrderProcessorTests
{
    /// <summary>
    /// Tests that OrderProcessor executes all steps when processing an order.
    /// </summary>
    [Fact]
    public void ProcessOrder_ExecutesAllSteps()
    {
        // Arrange - Capture console output to verify the operations
        var sw = new StringWriter();
        Console.SetOut(sw);

        var orderFacade = new OrderFacade();
        var processor = new OrderProcessor(orderFacade);

        // Act - Process the order
        processor.ProcessOrder("P001", "C123", 99.99m, "123 Main St");

        // Assert - Verify all operations were executed
        var output = sw.ToString();
        Assert.Contains("Checking stock", output);
        Assert.Contains("Processing payment", output);
        Assert.Contains("Shipping", output);
    }

    /// <summary>
    /// Tests that OrderFacade directly executes all steps when processing an order.
    /// </summary>
    [Fact]
    public void OrderFacade_ProcessOrder_ExecutesAllSteps()
    {
        // Arrange - Capture console output to verify the operations
        var sw = new StringWriter();
        Console.SetOut(sw);

        var facade = new OrderFacade();

        // Act - Process the order using facade directly
        facade.ProcessOrder("P001", "C123", 99.99m, "123 Main St");

        // Assert - Verify all operations were executed
        var output = sw.ToString();
        Assert.Contains("Checking stock", output);
        Assert.Contains("Processing payment", output);
        Assert.Contains("Shipping", output);
    }

    /// <summary>
    /// Tests that OrderProcessor can be initialized with default constructor.
    /// </summary>
    [Fact]
    public void OrderProcessor_DefaultConstructor_InitializesSuccessfully()
    {
        // Act - Create processor with default constructor
        var processor = new OrderProcessor();

        // Assert - Processor should be created successfully
        Assert.NotNull(processor);
    }

    /// <summary>
    /// Tests that OrderFacade can be initialized with custom services.
    /// </summary>
    [Fact]
    public void OrderFacade_CustomServices_InitializesSuccessfully()
    {
        // Arrange - Create custom service instances
        var inventoryService = new InventoryService();
        var paymentService = new PaymentService();
        var shippingService = new ShippingService();

        // Act - Create facade with custom services
        var facade = new OrderFacade(inventoryService, paymentService, shippingService);

        // Assert - Facade should be created successfully
        Assert.NotNull(facade);
    }

    /// <summary>
    /// Tests the complete order processing workflow with specific product details.
    /// </summary>
    [Fact]
    public void ProcessOrder_WithSpecificProductDetails_ExecutesCorrectly()
    {
        // Arrange
        var sw = new StringWriter();
        Console.SetOut(sw);

        var processor = new OrderProcessor();

        // Act
        processor.ProcessOrder("LAPTOP001", "CUSTOMER456", 1299.99m, "456 Oak Avenue, Tech City");

        // Assert
        var output = sw.ToString();
        Assert.Contains("Checking stock for LAPTOP001", output);
        Assert.Contains("Processing payment for CUSTOMER456 of amount 1299.99", output);
        Assert.Contains("Shipping LAPTOP001 to 456 Oak Avenue, Tech City", output);
    }
}