using System;

namespace _02.MaidenParty
{
    internal class MaidenParty
    {
        static void Main(string[] args)
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyHangers = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckySurprice = int.Parse(Console.ReadLine());

            double loveLettersPrice = loveLetters * 0.60;
            double rosesPrice = roses * 7.20;
            double keyHangersPrice = keyHangers * 3.60;
            double caricaturesPrice = caricatures * 18.20;
            double luckySurpricePrice = luckySurprice * 22;
            double orderPrice = loveLettersPrice + rosesPrice + keyHangersPrice + caricaturesPrice + luckySurpricePrice;

            int orderCount = loveLetters + roses + keyHangers + caricatures + luckySurprice;

            if (orderCount >= 25)
            {
                orderPrice -= orderPrice * 0.35;
            }
            orderPrice -= orderPrice * 0.1;
            double moneyDiff = Math.Abs(maidenPartyPrice - orderPrice);
            if (orderPrice >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {moneyDiff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyDiff:f2} lv needed.");
            }
        }
    }
}
