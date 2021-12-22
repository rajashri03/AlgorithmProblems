using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class PermuteString
    {
        /// <summary>
        /// Permutation Method-to generate permutation of string
        /// </summary>
        /// <param name="str"></param>
        internal static void permute(string str,int startindex,int endindex)
        {
            if(startindex==endindex)
            {
                Console.WriteLine(str);
            }
            else
            {
                for(int i=startindex;i<=endindex;i++)
                {
                    //swapping the string
                    str = swap(str, startindex, i);
                    //Recursively calling function-for another characters
                    permute(str, startindex + 1, endindex); 
                    //swapping the string again
                    str = swap(str, startindex, i);
                }
            }
        }
        /// <summary>
        /// method for swapping the charcters at position i with j
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        internal static string swap(string a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            //return array into single string
            return s;
        }
    }
}

