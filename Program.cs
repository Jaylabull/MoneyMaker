using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CAPTURING INPUT
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter amount to convert to coins: ");
            string totalAsString = Console.ReadLine();

            double totalAsDouble = Convert.ToDouble(totalAsString);

            Console.WriteLine($"You are converting {totalAsDouble} cents to: ");

            //CONVERT TO COINS
            int goldCoinValue = 10;
            int silverCoinValue = 5;

            double goldCoin = Math.Floor(totalAsDouble / goldCoinValue);
            double remainder = totalAsDouble % 10;

            double silverCoin = Math.Floor(remainder / silverCoinValue);

            remainder = remainder % silverCoinValue;

            Console.WriteLine($"Gold coins: {goldCoin}\nSilver coins: {silverCoin}\n");

        }
    }
}