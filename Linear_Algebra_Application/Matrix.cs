using System;
using System.Linq;

namespace Linear_Algebra_Application
{
    public static class Matrix
    {

        public static int Dot_Product(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length || array1.Length==0 || array2.Length==0)
                throw new Exception("Size of array is not same");

            var sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != 3 && array2[i] !=3)
                    sum += array1[i] * array2[i];
            }
            return sum;
        }

        public static double Vector_Length(int[] array,bool compelete = false)
        {
            if(array.Length<1)
                throw new Exception("Array size should be more than 1");

            var sum = 0;
            var length = compelete ? 5 : array.Length;
            for (int i = 0; i < length; i++)
            {
                if(array[i]!=3 )
                    sum += (int)Math.Pow(array[i], 2);
            }
            return sum;
        }

        public static double Angle_Two_Vector(int[] array1, int[] array2)
        {
            var guessing = array1.Contains(3) || array2.Contains(3);
            var numerator = Dot_Product(array1, array2);
            var lengthA = Vector_Length(array1, guessing);
            var lengthB = Vector_Length(array2, guessing);
            var denominator = Math.Round(Math.Sqrt(lengthA) * Math.Sqrt(lengthB),2);
            return numerator/ denominator;
        }

        public static double Cosine_Reverse(double input)
        {
            var angle = Math.Acos(input) * 180 / Math.PI;
            return Math.Round(angle, 2);
        }

    }
}
