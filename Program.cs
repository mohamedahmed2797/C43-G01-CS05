using System.Security.Cryptography.X509Certificates;

namespace assignment_5
{
    internal class Program
    {
        #region Q1 P1
        //public static void ChangeValue(int x)
        //{
        //    x = 10;
        //}
        #endregion

        #region Q1 P2
        //public static void ChangeValueByRef(ref int x)
        //{
        //    x = 10;
        //}
        #endregion

        #region Q2 P1
        //public static string ModifyName(string[] name)
        //{
        //    string total = " ";
        //    name[0]= "mohamed ";
        //    if (name != null)
        //    {
        //        for (int i = 0; i < name.Length; i++)
        //        {

        //            total += name[i];


        //        }
        //    }
        //    return total;
        //}
        #endregion

        #region Q2 P2
        //public static void ModifyNameByRef(ref string  name)
        //{
        //    name = "mohamed";
        //}
        #endregion

        #region Q3
        //public static void Operations(int sum, int sub, out int Rsum, out int Rsub)
        //{
        //    Rsum = sum + sub;
        //    Rsub = sum - sub;
        //}
        #endregion
        #region Q4

        //public static int sumDigits(int number)
        //{
        //    int sum = 0;
        //    string numStr = number.ToString();
        //    foreach (char c in numStr)
        //    {
        //        sum += int.Parse(c.ToString());
        //    }
        //    return sum;
        //}
        public static void a () {

            }
        #endregion
        #region Q5
        //public static bool isPrime(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return false;
        //    }
        //        for (int i = 2; i <= number / 2; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }

        //        }    
        //                return true;

        //    }



        #endregion
        #region Q6
        //public static int [] MinMaxArray( int[] arr ,ref int max , ref int min)
        //{
        //     max = arr[0];
        //     min = arr[0];
        //    foreach (int i in arr)
        //    {
        //        if (i > max)
        //        {
        //            max = i;
        //        }
        //        if (i < min)
        //        {
        //            min = i;
        //        }
        //    }

        //    return [min, max];
        //}

        #endregion
        #region Q7
        //public static int iterative (int number)
        //{
        //    int sum = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        if (i < 1)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //             sum *= i;
        //        }
        //    }
        //    return sum;
        //}

        #endregion
        #region Q8
        //public static void ChangeChar(ref string text, int position, char letter)
        //{
        //    text = text.Remove(position, 1);
        //    text = text.Insert(position, letter.ToString());

        
        //}

        #endregion
        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //1- passing by value
            //Must Be Initialized Before Passing 
            //Changes Inside Method , Don't Affect The Orignial Value 
            //Read Value Only

            //int a = 100;
            //Console.WriteLine("Before Changing : " + a);
            //ChangeValue(a);
            //Console.WriteLine("After Changing : " + a);
            //-----------------------------------
            //2-passing by reference
            //Must Be Initialized Before Passing
            //Changes Inside Method , Affect The Orignial Value 
            //Read First Then Write[Optional]

            //int a = 100;
            //Console.WriteLine($"before changing :{a}" );
            //ChangeValueByRef(ref a);
            //Console.WriteLine($"after changing :{a}");
            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //1- passing by value
            //Must Be Initialized Before Passing 
            //Changes Inside Method, Don't Affect The Original Value
            //Read Value Only

            //string[] N1 = { "pota ", "ahmed ", "kamal " };
            //Console.WriteLine(N1[0]);
            //string result = ModifyName(N1);
            //Console.WriteLine(result);

            //---------------------------------

            //2- Passing By Reference
            //	Must be initialized before passing
            //Changes Inside Method, Affect The Original Value
            //read First Then Write [Optional]:



            //string Na = "pota";
            //Console.WriteLine($"Name Before Modify : {Na}");
            //ModifyNameByRef(ref Na);
            //Console.WriteLine($"Name After Modify : {Na}");
            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //   int sum1 = 0;
            //   int sub1 = 0;
            //   Console.Write("please enter first number ");
            //   int.TryParse(Console.ReadLine(), out int n1 );

            //   Console.Write("please enter secend number ");
            //   int.TryParse(Console.ReadLine(), out int n2);
            //Operations(  n1 , n2 , out  sum1, out  sub1 );
            //   Console.WriteLine(sum1);
            //   Console.WriteLine(sub1);
            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine() , out int a);
            //int result = sumDigits(a);
            //Console.WriteLine(result);

            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //   Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //   bool result = isPrime(number);
            //   if (result) {
            //       Console.WriteLine($"{number} is a prime number");
            //           }
            //   else
            //       Console.WriteLine($"{number} is not a prime number");
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int [] arra = { 1, 2, 3 ,5,6,7,8,9,10,11,12,77};

            //int a = 0;
            //int b = 0;
            // MinMaxArray(arra ,ref a ,ref b );
            //Console.WriteLine($"max value {a}");
            //Console.WriteLine($"min value {b}");
            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int a = 5;
            //int result = iterative (a);
            //Console.WriteLine (result);
            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string modify = "mohamed";
            //ChangeChar(ref modify, 0, 's');
            //Console.WriteLine(modify);

            #endregion
        }
    }
}
