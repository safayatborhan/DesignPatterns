using AbstractFactory.Services;

namespace AbstractFactory.Factories;

public class BangladeshShoppingCardPurchaseFactory : IShoppingCardPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BangladeshDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new BangladeshShippingCostsService();
    }
}
