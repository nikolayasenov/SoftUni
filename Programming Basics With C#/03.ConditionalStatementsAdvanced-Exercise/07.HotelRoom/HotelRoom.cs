using System;

namespace _07.HotelRoom
{
    internal class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = numberOfDays * 50;
                apartmentPrice = numberOfDays * 65;
                if (numberOfDays > 7 && numberOfDays < 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
                else if (numberOfDays > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.3;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
                }    
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numberOfDays * 75.20;
                apartmentPrice = numberOfDays * 68.70;
                if (numberOfDays > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.2;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;

                }
            }
            else
            {
                studioPrice = numberOfDays * 76;
                apartmentPrice = numberOfDays * 77;
                if (numberOfDays > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
                }
                
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
