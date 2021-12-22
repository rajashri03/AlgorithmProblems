// See https://aka.ms/new-console-template for more information
using AlgorithmProblems;

Console.WriteLine("********* Permutations of a String**********");

Console.WriteLine("Enter String");
var str = Console.ReadLine();
int n = str.Length;
PermuteString.permute(str, 0, n-1);