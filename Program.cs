// See https://aka.ms/new-console-template for more information
using _21DaysOfCode;

CoinChange coinChange = new CoinChange();
var ans = coinChange.GetChange(new int[] { 1, 2, 5 }, 11);
Console.WriteLine(ans);
