/*
 * Requirements:
 * Imagine creation of a shopping cart system.
 * At a certain moment, a discount can be applied.
 * Discount can come up from two different crieteria. 
 * One is discount code and another is country.
 * Discount percentage is needed for this.
 */

namespace FactoryMethod.Services;

public abstract class DiscountService
{
    public abstract int DiscountPercentage
    {
        get;
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}
