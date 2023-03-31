using System;

namespace _03.CourierExpress
{
    internal class CourierExpress
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string deliveryType = Console.ReadLine();
            int kilometers = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            double orderPrice = 0;
            double weightPrice = 0;
            double kilometersPrice = 0;
            double expressPrice = 0;

            if (deliveryType == "standart")
            {
                if (weight < 1)
                {
                    orderPrice = kilometers * 0.03;
                }
                else if (weight < 10)
                {
                    orderPrice = kilometers * 0.05;
                }
                else if (weight < 40)
                {
                    orderPrice = kilometers * 0.1;
                }
                else if (weight < 90)
                {
                    orderPrice = kilometers * 0.15;
                }
                else if (weight < 150)
                {
                    orderPrice = kilometers * 0.2;
                }
            }
            else if (deliveryType == "express")
            {
                if (weight < 1)
                {
                    orderPrice = kilometers * 0.03;
                    expressPrice = 0.03 * 0.8;
                    weightPrice = expressPrice * weight;
                    kilometersPrice = weightPrice * kilometers;
                    finalPrice = orderPrice + kilometersPrice;

                }
                else if (weight < 10)
                {
                    orderPrice = kilometers * 0.05;
                    expressPrice = 0.05 * 0.4;
                    weightPrice = expressPrice * weight;
                    kilometersPrice = weightPrice * kilometers;
                    finalPrice = orderPrice + kilometersPrice;
                }
                else if (weight < 40)
                {
                    orderPrice = kilometers * 0.1;
                    expressPrice = 0.1 * 0.05;
                    weightPrice = expressPrice * weight;
                    kilometersPrice = weightPrice * kilometers;
                    finalPrice = orderPrice + kilometersPrice;
                }
                else if (weight < 90)
                {
                    orderPrice = kilometers * 0.15;
                    expressPrice = 0.15 * 0.02;
                    weightPrice = expressPrice * weight ;
                    kilometersPrice = weightPrice * kilometers;
                    finalPrice = orderPrice + kilometersPrice;
                    
                }
                else if (weight < 150)
                {
                    orderPrice = kilometers * 0.2;
                    expressPrice = 0.2 * 0.01;
                    weightPrice = expressPrice * weight;
                    kilometersPrice = weightPrice * kilometers;
                    finalPrice = orderPrice + kilometersPrice;
                }

            }
            if (deliveryType == "standart")
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {orderPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {finalPrice:f2} lv.");
            }
            
        }
    }
}
