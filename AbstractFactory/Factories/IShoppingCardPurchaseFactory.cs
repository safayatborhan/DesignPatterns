using AbstractFactory.Services;

namespace AbstractFactory.Factories;

public interface IShoppingCardPurchaseFactory
{
    public IShippingCostsService CreateShippingCostsService();

    public IDiscountService CreateDiscountService();
}
