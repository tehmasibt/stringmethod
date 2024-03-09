using System.Net.WebSockets;
using System.Xml;

namespace strmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Result(3,3,'/'); // task-1

            //SimvolReturn("tagiy$$$ev"); // task-2

            //Console.WriteLine(KelimeSayisi("hello how are you"));  //  task-3

            //Console.WriteLine(NumberSum(12642)); // task-4

            //QuvveteYukselt(12, 2); // task-5

            //EverthingNumberPlus(-12, -4, 32, -16, -20); // task-6

            //Console.WriteLine(ReturnString("academy")); // task-7
        }
        #region task-1
        //static void Result(int a, int b,char c)
        //{
        //    switch (c)
        //    {
        //        case '+':
        //            Console.WriteLine(a+b);
        //            break;
        //        case '-':
        //            Console.WriteLine(a+b);
        //            break;
        //        case '*':
        //            Console.WriteLine(a+b);
        //            break;
        //        case '/':
        //            if (b == 0)
        //            {
        //                Console.WriteLine("0-a bolme yoxdur");
        //            }
        //            else
        //            {
        //                Console.WriteLine(a/b);
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("dogru riyazi emel daxil et");
        //            break;
        //    }
        //}
        #endregion
        #region task-2
        //static void SimvolReturn(string word)
        //{
        //    char[] chars = word.ToCharArray();
        //    int count = 0;
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (chars[i] == '$')
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}
        #endregion
        #region task-3
        //static int KelimeSayisi(string cumle)
        //{

        //    string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    return kelimeler.Length;
        //}
        #endregion
        #region task-4
        //static int NumberSum(int a)
        //{
        //    int sum = 0;
        //    while (a>=1)
        //    {
        //        int b = a % 10;
        //        sum = sum + b;
        //        a /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region task-5
        //static void QuvveteYukselt(int a, int b)
        //{
        //    int result = 1;
        //    for (int i = 0; i < b; i++)
        //    {
        //        result *= a;
        //    }
        //    Console.WriteLine(result);
        //}
        #endregion
        #region task-6
        //static void EverthingNumberPlus(params int[] numbers)
        //{
        //    int[] ints = new int[numbers.Length];         
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < 1)
        //        {
        //            numbers[i] *= -1;                   

        //        }
        //        ints[i] = numbers[i];
        //        Console.WriteLine(ints[i]);
        //    }           
        //}
        #endregion
        #region task-7
        //static string ReturnString(string str)
        //{
        //    string newword=string.Empty;
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        newword += str[i];
        //    }
        //    return newword;
        //}
        #endregion
    }
}
