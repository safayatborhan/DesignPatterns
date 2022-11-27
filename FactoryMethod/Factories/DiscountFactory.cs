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

public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}
