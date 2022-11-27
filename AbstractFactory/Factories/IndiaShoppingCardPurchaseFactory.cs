using AbstractFactory.Services;

namespace AbstractFactory.Factories;

public class IndiaShoppingCardPurchaseFactory : IShoppingCardPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new IndiaDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new IndiaShippingCostsService();
    }
}
