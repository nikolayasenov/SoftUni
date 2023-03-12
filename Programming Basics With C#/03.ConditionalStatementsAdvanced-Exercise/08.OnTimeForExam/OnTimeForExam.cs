using System;

namespace _08.OnTimeForExam
{
    internal class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int hourToExam = int.Parse(Console.ReadLine());
            int minutesToExam = int.Parse(Console.ReadLine());
            int hourOfArriving = int.Parse(Console.ReadLine());
            int minutesOfArriving = int.Parse(Console.ReadLine());

            int examNorm = hourToExam * 60 + minutesToExam;
            int arrivalNorm = hourOfArriving * 60 + minutesOfArriving;
            int hours = 0;
            int minutes = 0;
            if (arrivalNorm > examNorm)
            {
                Console.WriteLine("Late");
                if (arrivalNorm - examNorm >= 60)
                {
                    hours = (arrivalNorm - examNorm) / 60;
                    minutes = (arrivalNorm - examNorm) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else
                {
                    minutes = (arrivalNorm - examNorm) % 60;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                
            }
            else 
            {
                if (arrivalNorm >= examNorm - 30)
                {
                    minutes = (examNorm - arrivalNorm) % 60;
                    if (minutes == 0)
                    {
                        Console.WriteLine("On time"); 
                    }
                    else
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
                else
                {
                    hours = (examNorm - arrivalNorm) / 60;
                    minutes = (examNorm - arrivalNorm) % 60;
                    Console.WriteLine("Early");
                    if (hours == 0)
                    {
  
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                    else
                    {
                        if (minutes < 10)
                        {
                            Console.WriteLine($"{hours}:0{minutes} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hours}:{minutes} hours before the start");
                        }
                    }

                }
                    
            }

        
        }
    }
}
