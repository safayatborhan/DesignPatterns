using AbstractFactory;
using AbstractFactory.Factories;

Console.Title = "Abstract Factory";

var bangladeshShoppingCartPurchaseFactory = new BangladeshShoppingCardPurchaseFactory();
var bangladeshShoppingCart = new ShoppingCart(bangladeshShoppingCartPurchaseFactory);
bangladeshShoppingCart.CalculateCosts();

var indiaShoppingCartPurchaseFactory = new IndiaShoppingCardPurchaseFactory();
var indiaShoppingCart = new ShoppingCart(indiaShoppingCartPurchaseFactory);
indiaShoppingCart.CalculateCosts();

Console.ReadKey();