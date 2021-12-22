// See https://aka.ms/new-console-template for more information
using AlgorithmProblems;
bool status = true;
while(status)
{
    Console.WriteLine("Algorithms Problems:\n1)Permutation of string\n2)Bubble Sort\n");
    int op = Convert.ToInt32(Console.ReadLine());
    switch(op)
    {
        case 1:
            Console.WriteLine("********* Permutations of a String**********");
            Console.WriteLine("Enter String");
            var str = Console.ReadLine();
            int n = str.Length;
            PermuteString.permute(str, 0, n - 1);
            break;
        case 2:
            Console.WriteLine("********* Bubble Sort**********");
            BubbleSort b = new BubbleSort();
            b.BSort();
            break;

    }
}

