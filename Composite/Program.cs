// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, Composite!");

var firstProduct = new ComposedProduct();
firstProduct.AddItem(new Product(29.99m));
firstProduct.AddItem(new Box(0.99m));

var secondProduct = new ComposedProduct();
secondProduct.AddItem(new Product(99.99m));
secondProduct.AddItem(new Box(1.99m));

var thirdProduct = new ComposedProduct();
thirdProduct.AddItem(secondProduct);
thirdProduct.AddItem(new Product(9.99m));
thirdProduct.AddItem(new Box(0.49m));

var christmasPresents = new List<IPrice>()
{
    firstProduct,
    thirdProduct
};

Console.WriteLine($"Total price for all Christmas presents: {christmasPresents.Sum(present => present.GetPrice()):C2}");