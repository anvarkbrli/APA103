using _07_NullableEnumStruct.Enums;
using _07_NullableEnumStruct.Models;

namespace _07_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder order1 = new(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            //order1.DisplayOrder();
            //order1.UpdateStatus(Enums.OrderStatus.Preparing);
            //order1.UpdateStatus(Enums.OrderStatus.Ready);
            //order1.UpdateStatus(Enums.OrderStatus.Delivered);

            DrinkOrder order2 = new(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            //order2.DisplayOrder();
            //order2.UpdateStatus(Enums.OrderStatus.Ready);

            DrinkOrder order3 = new(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
            //order3.DisplayOrder();

            //Getvalues metodlari
            //foreach (DrinkType drink in Enum.GetValues(typeof(DrinkType)))
            //{
            //    Console.WriteLine(drink);
            //}

            //foreach (DrinkSize size in Enum.GetValues(typeof(DrinkSize)))
            //{
            //    Console.WriteLine(size);
            //}

            //foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            //{
            //    Console.WriteLine(status);
            //}

            //ToString()
            //Console.WriteLine(DrinkType.Coffee.ToString());
            //Console.WriteLine(DrinkSize.Large.ToString());

            //Parse
            //DrinkType drink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            //DrinkSize size = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            //Console.WriteLine(drink);
            //Console.WriteLine(size);

            //Statistika
            Console.WriteLine("Umumi sifaris sayi: 3");

            Console.WriteLine("Ilk sifarisin qiymeti:");
            Console.WriteLine(order1.CalculatePrice() + " AZN");

            Console.WriteLine("Ikinci sifarisin qiymeti:");
            Console.WriteLine(order2.CalculatePrice() + " AZN");

            Console.WriteLine("Ucuncu sifarisin qiymeti:");
            Console.WriteLine(order3.CalculatePrice() + " AZN");

            decimal orderPrice1 = order1.CalculatePrice();
            decimal orderPrice2 = order2.CalculatePrice();
            decimal orderPrice3 = order3.CalculatePrice();
            decimal TotalPrice = orderPrice1 + orderPrice2 + orderPrice3;


            Console.WriteLine($"Umumi mebleg: " + TotalPrice + " AZN");
        }

    }
}
