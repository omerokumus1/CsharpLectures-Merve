using System;

namespace Ch5_1_ArraysBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrayler indexlenebilir yapılardır. Stringlerdeki gibi belirli
            // indexteki elemana erişebiliriz

            // 1- Array Declaration
            // dataType[] arrayName; -> dataType: int, double, string, boolean ...
            // dataType: dizinin tutacağı elemanların tipidir. int ise dizi içinde sadece int eleman olabilir
            int[] numbers;


            // 2- Array Initialization (memory allocation for arrays)
            // arrayName = new dataType[SIZE]; -> new zorunludur. SIZE ile arrayin boyutu belirlenir
            numbers = new int[5];
            

            // 3- Array Declaration and Initialization in One Line
            // dataType[] arrayName = new dataType[SIZE];
            bool[] bools = new bool[5];


            // 4- Dizinin bir elemanına erişmek
            // arrayName[index]
            Console.WriteLine(numbers[2]); // default 0 basar
            Console.WriteLine(bools[2]); // default False basar

            // new ile dizi oluşturulunca bütün elemanlar data tipinin default değerine setlenir
            // int için default değer 0'dır. Yani bütün elemanlar sıfır değerine sahip olur
            // bool için False'dir.
            // Bu şekilde tüm data tipler için default değerler mevcuttur


            // 4.1- Dizinin son elemanına erişmek
            Console.WriteLine(bools[bools.Length - 1]);
            Console.WriteLine(bools[^1]); // ^1 -> son index

            // 5- Dizinin bir elemanını değiştirmek
            // arrayName[index] = e;
            numbers[0] = 11;
            Console.WriteLine(numbers[0]);


            // 6- Array Initialization with Elements
            double[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[2]);


        }
    }
}

