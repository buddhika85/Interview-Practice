// Q1

//var inputArray = new[] { 3, 5, -4, 8, 11, 1, -1, 0 };
//var result = new Q1TwoSumNum().TwoNumberSum(inputArray, 10);
//Write($"{result[0]} , {result[1]}");


using Answers;

var inputArray = new[] { 3, 5, -4, 8, 11, 1, -1, 0 };
//new Q1TwoSumNum().Sort(inputArray);
//WriteLine(string.Join(" | ", inputArray));
var result = new Q1TwoSumNum().TwoNumberSumV2(inputArray, 10);
Console.WriteLine($"{result[0]} , {result[1]}");
