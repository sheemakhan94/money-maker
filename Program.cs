using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.Write("Enter an amount to convert to gold (10 cents), silver (5 cents) and bronze (1 cent) coins: ");
      string amountAsString = Console.ReadLine();

      double amount = Math.Floor(Convert.ToDouble(amountAsString));

      int goldCoin = 10;
      int silverCoin = 5;

      double goldCoins = Math.Floor(amount / goldCoin);

      double remainder = amount % goldCoin;

      double silverCoins = Math.Floor(remainder / 5);

      remainder = remainder % silverCoin;

      Console.WriteLine($"{amountAsString} is equal to... \n Gold coins: {goldCoins} \n Silver coins: {silverCoins} \n Bronze coins: {remainder}");

    }
  }
}
