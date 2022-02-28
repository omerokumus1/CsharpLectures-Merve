using System;
using System.Runtime.ConstrainedExecution;

namespace Ch3_2_WhileLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  Yapısı:
             *  while (boolean-expression){
             *      statements..
             *  }
             *  -> boolean-expression doğru olduğu sürece blok içerisine yazılan kodlar çalışmaya devam eder
             *  -> Kod sırası while satırına gelince boolean-exp kontrol edilir. Doğru ise içerisindeki kodlar çalışır
             *      yanlış ise bloğun sonuna atlanır.
             *  -> Boolean-exp doğru ise kodlar çalışır ve bloğun sonuna gelinir. Daha sonra boolean-exp tekrar kontrol edilir
             *      eğer doğru ise kodlar baştan aşağı tekrar çalışır değil ise bloğun dışına çıkılıp devam edilir.
             */
            
            // Örnek: ekrana 1'den 10'a kadar olan rakamları yazdır
            int i = 0;
            while (i < 10) // i < 10 -> loop continuation condition (döngünün devamlılık koşulu)
            { // loop body
                Console.WriteLine(i);
                i++;
            }
            // Döngünün devamlılık koşulu önünde sonunda false olmak zorundadır. Olmaz ise sonsuz döngü (infinite loop) oluşur
            // Döngünün devamlılık koşulu AND, OR gibi işlemlerle de belirlenebilir. (if gibi)
            
            /*  Döngü oluşturmadan önce:
             *      1. Döngünün kaç kez çalışacağını belirle: bir sayı ver veya bilgisayara buldurt
             *      2. Yapılacak işi (bloklarlar arasına yazılacak kodları) belirle
             * 
             */
            
            // Örnek: 1'den n'ye kadar olan sayıların toplamı (n dahil)
            
            // 1 2 3 4 5 6 7 8 9 10
            int n = 10; // döngünün bir nevi durma koşulunu belirleyen eleman
            int sum = 0;
            i = 1; // loop counter: döngünün kaç kere çalışacağını belirleyen eleman
            while (i <= n)
            {
                sum += i;
                i++;
            } 
            Console.WriteLine("sum: " + sum);
            
            // Örnek: 1'den n'ye kadar olan sayılardan çift olanları say (n dahil değil)
            n = 10;
            int evenNumbers = 0;
            i = 1; // loop counter
            while (i < n)
            {
                if (i % 2 == 0)
                    evenNumbers++;
                i++;
            }
            Console.WriteLine("Even numbers: " + evenNumbers);
            
            
            // Örnek: Kullanıcıdan input al, tek basamaklı sayıları say
            int limit = 5; // döngünün kaç kere çalışacağı
            int count = 0;
            int number;
            int inputNumber = 1; // döngünün doğruluk koşulunu oluşturmak için
            while (inputNumber <= limit)
            {
                Console.Write("Enter an integer: ");
                Int32.TryParse(Console.ReadLine(), out number);
                if (number >= 0 && number <= 9)
                    count++;

                inputNumber++;
            }
            Console.WriteLine("You have entered " + count + " digits.");
            
            // Örnek: Toplama quizi örneği
            int questionNumber = 5;
            int correctAnswers = 0;
            int n1, n2;
            Random random = new Random();
            int answer;
            int currentQuestion = 1; // kaçıncı döngüde olduğumuzun tabiki bununla yapılacak
            while (currentQuestion <= questionNumber)
            {
                n1 = random.Next(10);
                n2 = random.Next(10);
                Console.Write(currentQuestion + ") " + n1 + " + " + n2 + " = ");
                Int32.TryParse(Console.ReadLine(), out answer);
                if (answer == (n1 + n2))
                    correctAnswers++; // sayma işlemi

                currentQuestion++;
            }
            Console.WriteLine("You have " + correctAnswers + " correct answers.");

            /*
                Döngünün çalışması bir sayaca (loop counter'a) bağlı olduğu için bu döngülere counter-controlled loop denir
                Bir diğer döngü tipi ise sentinel controlled loop diye isimlendirilir. Burada döngünün durması belirli bir olayın gerçekleşmesine bağlıdır.
                
                Örn; Kullanıcıdan yanlış input girildiği sürece input istemeye devam eden bir program olsun. Burada oluşturulan döngünün bitmesi için
                kullanıcının doğru input girmesi gerekiyor. Buradaki olay kullanıcının doğru input girmesi. Bu olay gerçekleşirse döngü biter, gerçekleşmezse döngü bitmez.
                
                Örn; Bir dizi hesaplama yapan bir program olsun. Bu programa "0'ı bulunca dur" diyorsak bu sentinel controlled loop olur. Çünkü döngünün durması
                bir olayın yani 0'ın bulunması olayının gerçekleşmesine bağlıdır.
             */
        }
    }
}