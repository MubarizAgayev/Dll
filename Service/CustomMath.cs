﻿namespace Service
{
    public class CustomMath
    {

        public void Factorial(int n)
        {
            int result = 1;
            for(int i=1; i<=n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }


        public void Nums(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}