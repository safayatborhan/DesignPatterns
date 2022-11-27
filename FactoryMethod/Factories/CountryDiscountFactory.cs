/*
 * Requirements:
 * Imagine creation of a shopping cart system.
 * At a certain moment, a discount can be applied.
 * Discount can come up from two different crieteria. 
 * One is discount code and another is country.
 * Discount percentage is needed for this.
 */

using FactoryMethod.Services;

namespace FactoryMethod.Factories;

public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryIdentifier;

    public CountryDiscountFactory(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}
