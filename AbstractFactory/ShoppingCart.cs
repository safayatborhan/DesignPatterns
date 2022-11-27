using AbstractFactory.Factories;
using AbstractFactory.Services;

namespace AbstractFactory;

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private readonly int _orderCosts;

    public ShoppingCart(IShoppingCardPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();

        _orderCosts = 200;
    }    

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}
