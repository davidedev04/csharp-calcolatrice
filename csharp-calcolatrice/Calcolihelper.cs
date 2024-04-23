using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public class SommaNumInt
    {
        public static int NumInt1 { get; set; }
        public static int NumInt2 { get; set; }

        public SommaNumInt(int numint1, int numint2)
        {
            NumInt1 = numint1;
            NumInt2 = numint2;
            
            int sum = numint1 + numint2;

            Console.WriteLine($"la somma dei due numeri interi é {sum}");
        }

    }

    public class SommaNumDouble
    {
        public static double NumDouble1 { get; set; }
        public static double NumDouble2 { get; set; }

        public SommaNumDouble(double numdouble1, double numdouble2)
        {
            NumDouble1 = numdouble1;
            NumDouble2 = numdouble2;

            double sum = numdouble1 + numdouble2;

            Console.WriteLine($"la somma dei due numeri decimali é {sum}");
        }

    }

    public class DiffNumInt
    {
        public static int NumInt1 { get; set; }
        public static int NumInt2 { get; set; }

        public DiffNumInt(int numint1, int numint2)
        {
            NumInt1 = numint1;
            NumInt2 = numint2;

            Console.WriteLine($"la differenza tra i due numeri interi é {numint2 % numint1}"); 
        }

    }

    public class DiffNumDouble
    {
        public static double NumDouble1 { get; set; }
        public static double NumDouble2 { get; set; }

        public DiffNumDouble(double numdouble1, double numdouble2)
        {
            NumDouble1 = numdouble1;
            NumDouble2 = numdouble2;

            Console.WriteLine($"la differenza tra i due numeri decimali é {numdouble2 % numdouble1}");
        }

    }

    public class xNumInt
    {
        public static int Numx1 { get; set; }
        public static int Numx2 { get; set; }

        public xNumInt(int numx1, int numx2)
        {
            Numx1 = numx1;
            Numx2 = numx2;

            int sum = numx1 * numx2;

            Console.WriteLine($"la moltiplicazione dei due numeri interi é {sum}");
        }

    }

    public class xNumDouble
    {
        public static double NumxDouble1 { get; set; }
        public static double NumxDouble2 { get; set; }

        public xNumDouble(double numxdouble1, double numxdouble2)
        {
            NumxDouble1 = numxdouble1;
            NumxDouble2 = numxdouble2;

            double sum = numxdouble1 * numxdouble2;

            Console.WriteLine($"la moltiplicazione dei due numeri decimali é {sum}");
        }

    }

    public class MinNumInt
    {
        public static int NumChoise1 { get; set; }
        public static int NumChoise2 { get; set; }

        public MinNumInt(int numChoise1, int numChoise2) 
        { 
            NumChoise1 = numChoise1;
            NumChoise2 = numChoise2;

            Console.WriteLine("Il numero intero più piccolo é " + int.Min(numChoise1, numChoise2));
        }
    }

    public class MinNumDouble
    {
        public static double NumChoiseDouble1 { get; set; }
        public static double NumChoiseDouble2 { get; set; }

        public MinNumDouble(double numChoisedouble1, double numChoisedouble2)
        {
            NumChoiseDouble1 = numChoisedouble1;
            NumChoiseDouble2 = numChoisedouble2;

            Console.WriteLine("Il numero decimale più piccolo é " + double.Min(numChoisedouble1, numChoisedouble2));
        }
    }

    public class MaxNumInt
    {
        public static int NumChoise1 { get; set; }
        public static int NumChoise2 { get; set; }

        public MaxNumInt(int numChoise1, int numChoise2)
        {
            NumChoise1 = numChoise1;
            NumChoise2 = numChoise2;

            Console.WriteLine("Il numero intero più grande é " + int.Max(numChoise1, numChoise2));
        }
    }

    public class MaxNumDouble
    {
        public static double NumChoiseDouble1 { get; set; }
        public static double NumChoiseDouble2 { get; set; }

        public MaxNumDouble(double numChoisedouble1, double numChoisedouble2)
        {
            NumChoiseDouble1 = numChoisedouble1;
            NumChoiseDouble2 = numChoisedouble2;

            Console.WriteLine("Il numero decimale più grande é " + double.Max(numChoisedouble1, numChoisedouble2));
        }
    }
}
