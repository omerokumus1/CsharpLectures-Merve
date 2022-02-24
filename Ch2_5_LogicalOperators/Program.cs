using System;

namespace Ch2_5_LogicalOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Logical Operators   
                INVERSE: !
                AND: &&
                OR: ||
                Exclusive OR: ^
            
            Ne için kullanılırlar: AND ve OR Olayları/sonuçları birbirine bağlarlar (boolean olarak) ve boolean sonuç üretir. 
                                    INVERSE ise bir olayın değilini/tersini alır. Yani true ise false, false ise true yapar
            
            AND operatörü hangi durumda true üretir? Olayların hepsi true ise sonuç true olur, en az 1 tane false varsa sonuç false olur
            OR operatörü hangi durumda true üretir? Olayların hepsi false ise sonuç false olur, en az 1 true varsa sonuç true olur
            
            AND ile OR birbirinin tümleyenidir -> AND'in değili = OR, OR'un değili = AND
            
            // AND ve OR kombinasyonu -> Bilgisayarın 8GB RAM'i VE 256GB hafızası varsa VEYA 8GB RAM VE 512GB Hafızası varsa satın alırım
                                         (Bilgisayarın 8GB RAM'i VE 256GB hafızası varsa) VEYA (8GB RAM VE 512GB Hafızası varsa satın alırım)
                                         ((Bilgisayarın 8GB RAM'i) VE (256GB hafızası varsa)) VEYA ((8GB RAM) VE (512GB Hafızası varsa satın alırım))
                                         8GB ram'e sahip olması bool ram8 ile tutulsun, 256gb hafızası olması bool hafıza256 ile, 512 ise hafıza 512 ile tutulsun.
                                         bool satınAlma = (ram8 && hafıza256) || (ram8 && hafıza512)
            */
            bool ram8, hafıza256, hafıza512;
            ram8 = true;
            hafıza256 = false;
            hafıza512 = false;
            bool satınAlma = ram8 && hafıza256 || ram8 && hafıza512; // sıkıştırılmış hali: ram8 && (hafıza256 || hafıza512) (tercih etme)
            if (satınAlma)
            {
                Console.WriteLine("Satın alma gerçekleşti");
            }
            else
            {
                Console.WriteLine("Gerekli configurasyonlar olmadığından satın alınamadı.");
            }
            
            // Exercise: girilen bir sayının 4'ün ve 5'in katı olduğunu bulmak
            int n = 36;
            // olayları isimlerdirerek anlamlandırma
            bool isDivisibleByFive = n % 5 == 0; 
            bool isDivisibleByFour = n % 4 == 0;
            if (isDivisibleByFive && isDivisibleByFour)
                Console.WriteLine(n + " is divisible by both 4 and 5.");
            else
                Console.WriteLine(n + " is not divisible by both 4 and 5.");

            
            // Exercise: girilen bir sayının 4'ün veya 5'in katı olduğunu bulmak
            if (isDivisibleByFive || isDivisibleByFour)
                Console.WriteLine(n + " is divisible by either 4 or 5.");
            else
                Console.WriteLine(n + " is not divisible by either 4 or 5.");
            
            
            // INVERSE: !
            // verilen bir sayının 5'in katı olduğunu bulmak
            n = 20;
            isDivisibleByFive = n % 5 == 0;
            if(isDivisibleByFive)
                Console.WriteLine(n + " is Divisible by 5");

            // verilen bir sayının 5'in katı olmadığını bulmak
            if (!isDivisibleByFive)
                Console.WriteLine(n + " is not divisible by 5");

            // AND ile OR arasında geçiş
            // girilen bir sayının 4'ün ve 5'in katı olmadığını bulmak 
            if (!(isDivisibleByFive && isDivisibleByFour))
                Console.WriteLine(n + " is not divisible by both 4 and 5");

            
            



        }
    }
}