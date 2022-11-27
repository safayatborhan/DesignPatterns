/*
 * Requirements:
 * Imagine creation of a shopping cart system.
 * At a certain moment, a discount can be applied.
 * Discount can come up from two different crieteria. 
 * One is discount code and another is country.
 * Discount percentage is needed for this.
 */

namespace FactoryMethod.Services;

public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case "BD":
                    return 20;
                default:
                    return 10;
            }
        }
    }
}
