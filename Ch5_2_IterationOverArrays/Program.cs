using System;

namespace Ch5_2_IterationOverArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // 1- for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine((i + 1) + ". element: " + numbers[i]);
            }

            /* Örnekler; 
                - çift sayıları say
                - tek sayıları say,
                - bir sayıdan küçük olan sayıları say


            */




            // 2- foreach loop
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            /* Ne zaman foreach?
                - for ile yapılan her şey foreach ile, foreach ile yapılan her şey for ile yapılabilir.
                - for ile foreach'in performans anlamında birbirine üstünlüğü yoktur

                * Eğerki dizinin indexleriyle ilgilenmiyorsak foreach kullanmak daha iyidir.
                * Eğerki dizinin eleman tipini bilmiyorsak, custom implement edilmiş bir şey olabilir, o zaman yine foreach kullanmak mantıklıdır.
                
            */

        }
    }
}

