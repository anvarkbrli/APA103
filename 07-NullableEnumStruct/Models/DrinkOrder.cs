using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullableEnumStruct.Models
{
    public class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size, OrderStatus status =  OrderStatus.New)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
        }

        public decimal CalculatePrice()
        {
            switch (Drink)
            {
                case DrinkType.Coffee:
                    switch (Size)
                    {
                        case DrinkSize.Small:
                            return Price = 3;
                           
                        case DrinkSize.Medium:
                            return Price = 4;
                            
                        case DrinkSize.Large:
                            return Price = 5;
                            

                    }
                    break;
                    
                case DrinkType.Tea:
                    switch (Size)
                    {
                        case DrinkSize.Small:
                            return Price = 2;
                            
                        case DrinkSize.Medium:
                            return Price = 3;
                            
                        case DrinkSize.Large:
                            return Price = 4;
                            

                    }
                    break;

                case DrinkType.Juice:
                    switch (Size)
                    {
                        case DrinkSize.Small:
                            return Price = 4;
                            
                        case DrinkSize.Medium:
                            return Price = 5;
                            
                        case DrinkSize.Large:
                            return Price = 6;
                            

                    }
                    break;

                case DrinkType.Water:
                    switch (Size)
                    {
                        case DrinkSize.Small:
                            return Price = 1;
                            
                        case DrinkSize.Medium:
                            return Price = 1.5M;
                            
                        case DrinkSize.Large:
                            return Price = 2;
                            
                    }
                    break;

            }
            return 0;

        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifaris : {OrderNumber}, statusu: {Status}");
        }
        public void DisplayOrder()
        {
            CalculatePrice();
            Console.WriteLine("Siferis detallari");
            Console.WriteLine($"Sifrais Nomresi: {OrderNumber}");
            Console.WriteLine($"Musterinin adi: {CustomerName}");
            Console.WriteLine($"Icki novu: {Drink}");
            Console.WriteLine($"Ickinin olcusu: {Size}");
            Console.WriteLine($"Sifarisin statusu: {Status}");
            Console.WriteLine($"Odenecek mebleg: {Price} AZN");

        }
    }
}
