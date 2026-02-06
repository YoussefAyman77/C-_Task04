using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            // //normal
            // int[] arr = new int[3];
            // arr[0] = 10;
            // arr[1] = 20;
            // arr[2] = 30;
            // //init list
            // int[] arr2 = { 1, 2, 3 };
            // //syntax sugar 
            // int[] arr3 = new int[] { 4, 5, 6 };

            // foreach (int i in arr) Console.Write(i+" ");
            // Console.WriteLine("");
            // foreach (int i in arr2) Console.Write(i+" ");
            // Console.WriteLine("");
            // foreach (int i in arr3) Console.Write(i+" ");
            // Console.WriteLine("");
            // //IndexOutOfRangeException
            // Console.WriteLine(arr[4]);
            // // according to the datatype  for ex an integer array assigns the default value which is zero
            #endregion

            #region problem2
            // //shallow copy
            // int[] arr1 = { 1, 2, 3 };
            // int[] arr2 = { 4, 5, 6 };
            // // arr2 = arr1;
            // // Console.WriteLine(arr2[1]);
            // //deep copy
            // arr2 = (int[])arr1.Clone();
            // Console.WriteLine(arr2[2]);
            // Console.WriteLine(arr1.GetHashCode());
            // Console.WriteLine(arr2.GetHashCode());

            // //both copy() and clone() performs shallow copy
            // //copy has no return value 
            // //copy is more flexiable since it allows resizeng and partial copy
            #endregion

            #region problem3
            // int[,] grades = new int[2, 3];
            // //read
            // for (int i = 0; i < grades.GetLength(0); i++)
            // {
            //     Console.WriteLine($"for student {i + 1}");
            //     for (int j = 0; j < grades.GetLength(1);)
            //     {
            //         Console.Write($"enter the grade for the {j + 1} subject: ");
            //         bool f = int.TryParse(Console.ReadLine(), out grades[i, j]);
            //         if (f && grades[i, j] > 0) j++;
            //     }
            // }
            // //print
            // for (int i = 0; i < grades.GetLength(0); i++)
            // {
            //     Console.Write($"grades for the {i + 1} student are: ");
            //     for (int j = 0; j < grades.GetLength(1); j++)
            //         Console.Write(grades[i, j] + " ");
            //     Console.WriteLine(" ");
            // }

            // //getlength() returns the length of a specific dimension 
            // //while length returns the total number of elements
            #endregion

            #region problem4
            // int[] arr1 = { 5, 3, 4, 4, 1 };
            // int[] arr2 = { 5, 6, 7, 8, 9 };
            // int[] arr3 = new int[5];
            // Array.Sort(arr1);
            // foreach (int i in arr1) Console.Write(i + " ");
            // Console.WriteLine(" ");
            // Array.Reverse(arr1);
            // foreach (int i in arr1) Console.Write(i + " ");
            // Console.WriteLine(" ");
            // int idx1 = Array.IndexOf(arr1, 4);
            // Console.WriteLine(idx1);
            // Array.Copy(arr2, arr3, 3);
            // foreach (int i in arr3) Console.Write(i + " ");
            // Console.WriteLine(" ");
            // Array.Clear(arr2, 1, 3);
            // foreach (int i in arr2) Console.Write(i + " ");
            // Console.WriteLine(" ");
            // //using copy doesn't guarntee reliable transfer 
            // //constrained copy is a reliable tranfer with each exception throughs doesn't affect the destinaiton array
            #endregion

            #region problem5
            // int[] arr = { 1, 2, 3, 4, 5 };
            // //for loop
            // for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            // Console.WriteLine();
            // //foreach
            // foreach (int i in arr) Console.Write(i + " ");
            // Console.WriteLine();
            // //while 
            // int idx = arr.Length - 1;

            // while (idx >= 0)
            // {
            //     Console.Write(arr[idx] + " ");
            //     idx--;
            // }

            // Console.WriteLine();
            // //it is like a read only method so that you can't modify the array
            #endregion

            #region problem6
            // bool f;
            // int num;
            // do
            // {
            //     Console.Write("enter a positive odd number: ");
            //     f = int.TryParse(Console.ReadLine(), out num);

            // } while (!f || num % 2 == 0 || num <= 0);
            // //user inputs maybe wrong , causing exception or undesired behaviuor
            #endregion

            #region problem7
            // int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // for (int i = 0; i < mat.GetLength(0); i++)
            // {
            //     for (int j = 0; j < mat.GetLength(1); j++)
            //         Console.Write(mat[i, j] + " ");
            //     Console.WriteLine();
            // }
            // //using labels , also some functions for padding like PadLeft() or PadRigth()
            // //using them when the numbers have different digit length
            #endregion

            #region problem8
            // Console.Write("enter month number: ");
            // int num = int.Parse(Console.ReadLine());
            // // if (num == 1) Console.WriteLine("junu");
            // // else if (num == 2) Console.WriteLine("feb");
            // // else if (num == 3) Console.WriteLine("march");
            // // else Console.WriteLine("after march");
            // switch (num)
            // {
            //     case 1:
            //         Console.WriteLine("junu");
            //         break;
            //     case 2:
            //         Console.WriteLine("feb");
            //         break;
            //     case 3:
            //         Console.WriteLine("march");
            //         break;
            //     default:
            //         Console.WriteLine("after march");
            //         break;
            // }
            // //switch provides better redeability and high performance (jump table)

            #endregion

            #region problem9
            // int[] arr = { 5, 3, 2, 3, 4 };
            // Array.Sort(arr);
            // foreach (int i in arr) Console.Write(i + " ");
            // Console.WriteLine();
            // int idx1 = Array.IndexOf(arr, 3);
            // Console.WriteLine($"first occ of num is: {idx1}");
            // int idx2 = Array.LastIndexOf(arr, 3);
            // Console.WriteLine($"last occ of num is: {idx2}");

            // //time complexity is o(nlogn) on average
            #endregion

            #region problem10
            // int[] arr = { 1, 2, 3, 4, 5 };
            // int sum = 0;
            // for (int i = 0; i < arr.Length; i++) sum += arr[i];
            // Console.WriteLine($"the sum of all elements is : {sum}");
            // sum = 0;
            // foreach (int i in arr) sum += i;
            // Console.WriteLine($"the sum of all elements is : {sum}");
            // //foreach is more readable and safe than for loop
            #endregion

            #region Enumproblem
            // Console.Write("enter a number from 1 to 7: ");
            // int num = int.Parse(Console.ReadLine());
            // week day = (week)Enum.Parse(typeof(week), num.ToString());
            // Console.WriteLine(day);
            // program will through ArgumentException
            #endregion
        }
    }
    #region weekdaysEnum
    enum week
    {

        saturday = 1,
        sunday = 2,
        monday = 3,
        tuesday = 4,
        wendesday = 5,
        thursday = 6,
        friday = 7
    }

    #endregion

}
