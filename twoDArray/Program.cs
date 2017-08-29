using System;
using System.Collections.Generic;
using System.Drawing;

//class Program
//{
//    static void Main()
//    {
//        Point[] points = { new Point(100, 200), new Point(150, 250), new Point(275, 395), new Point(300, 495) };
//        Point[] point = Array.FindAll(points, ProductGT10);
//        foreach (Point p in point)
//        {
//            Console.WriteLine("Found: X= {0},Y={1}", p.X, p.Y);
//        }
//        Console.WriteLine("Press any key to exit");
//        Console.ReadKey();
//    }
//       private static bool ProductGT10(Point P)
//        {
//         return P.X * P.Y > 100000;
//        }
//}
//class Program
//{
//    static void Main()
//    {
//        Point[] points = { new Point(100, 200), new Point(150, 250), new Point(275, 395), new Point(300, 495) };
//        Point P = Array.Find(points, element => element.X * element.Y > 100000);
//        Console.WriteLine("Found: X= {0},Y={1}", P.X, P.Y);
//        Console.WriteLine("Press any key to exit");
//        Console.ReadKey();
//    }
//}
class Program
{
    static void Main()
    {
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 4, 5 }, { 6, 7 }, { 8, 9 }, 
            { 5, 6 }, { 7, 8 }, { 9, 10 } };
        int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };
        int Sum2D = 0;
        int Sum3D = 0;
        for(int i=0;i<array2D.GetLength(0);i++)
        {
            for(int j=0;j<array2D.GetLength(1);j++)
            {
                Sum2D += array2D[i, j];
            }
        }
        Console.WriteLine("Total Sum of 2D array elements is {0} Method1", Sum2D);

        int sum2 = sumNums(array2D);
        Console.WriteLine("Total Sum of 2D array elements is {0} Method2", sum2);
        for (int i=0; i<array3D.GetLength(0);i++)
        {
            for(int j=0;j<array3D.GetLength(1);j++)
            {
                for(int k=0;k<array3D.GetLength(2);k++)
                {
                    Sum3D += array3D[i, j, k];
                }
            }
        }
        Console.WriteLine("Total Sum of 3D array elements is {0}", Sum3D);
        //average of students
        int[,] grades = new int[,] {{1, 82, 74, 89, 100},
                                    {2, 93, 96, 85, 86},
                                    {3, 83, 72, 95, 89},
                                    {4, 91, 98, 79, 88}};
        int last_grade = grades.GetUpperBound(1);
        double average = 0.0;
        int total;
        int last_student = grades.GetUpperBound(0);
        for (int row = 0; row <= last_student; row++)
        {
            total = 0;
            for (int col = 0; col <= last_grade; col++)
            {
                total += grades[row, col];
            }
                average = total / last_grade;
                Console.WriteLine("Average: " + average);
        }
        //access items from 2D array
     int grade = grades[2, 2];
     int grade1 = (int)grades.GetValue(0, 2);
        Console.WriteLine(grade);
        Console.WriteLine(grade1);
        grades[2, 2] = 99;

    Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    static int sumNums(int[,] nums)
    {
        int sum = 0;
        for (int i = 0; i <= nums.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= nums.GetUpperBound(1); j++)
                sum += nums[i,j];
        }
        return sum;
    }
}