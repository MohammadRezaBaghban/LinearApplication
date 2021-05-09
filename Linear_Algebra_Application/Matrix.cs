using System;

namespace Linear_Algebra_Application
{
    public static class Matrix
    {

        public static int Dot_Product(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length || array1.Length==0 || array2.Length==0)
                throw new Exception("Size of array is not same");

            var sum = 0;
            for (int i = 0; i < array1.Length; i++) { sum += array1[i] * array2[i]; }
            return sum;
        }

        public static double Vector_Length(int[] array)
        {
            if(array.Length<1)
                throw new Exception("Array size should be more than 1");

            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += (int)Math.Pow(array[i], 2);
            }
            return sum;
        }

        public static double Angle_Two_Vector(int[] array1, int[] array2)
        {
            var numerator = Dot_Product(array1, array2);
            var denominator = Math.Round(Math.Sqrt(Vector_Length(array1)) * Math.Sqrt(Vector_Length(array2)),2);
            return numerator/ denominator;
        }

        public static double Cosine_Reverse(double input)
        {
            var angle = Math.Acos(input) * 180 / Math.PI;
            return Math.Round(angle, 2);
        }

    }
}
