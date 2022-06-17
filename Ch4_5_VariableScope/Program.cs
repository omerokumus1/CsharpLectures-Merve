using System;

namespace Ch4_5_VariableScope
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  Variable scope
             *  Değişkenlere erişebildiğimiz en geniş aralık variable scope olarak tanımlanır.
             *  Scope (blok) süslü parantezlerle oluşturulur. Örn; if bloğu, döngü bloğu, method bloğu vs
             *  Scope bitince değişken ölür, yok edilir
             *  Variable scope'sini belirlemek:
             *      - Değişkenin declare edildiği en küçük bloktur
             */

            int x = 3;

            if (true)
            {
                int y = 5; // bu değişkenin scope'si if bloğudur. İf bloğu dışında erişilemez, çünkü if bloğu bitince y yok edilir.
                x = 2; // x'in scopesi içinde olduğumuz için sorun yok
            } // aynı örnek while, do-while ve for döngüleri için de yapılabilir.
            
            // y = 3; // hata, y'nin scope'si dışında erişim yapılamaz

            for (int i = 0; i < 5; i++) // i değişkeninin scope'si for döngüsüdür
            {
                int y = 4; // y değişkeninin scopesi for bloğudur. Yukarıdaki y değişkeni if bloğu bitince yok edilir. 
                            // Bu sebeple y isimli başka bir değişken oluşturabiliriz. for bloğu işini bitirince i ve y 
                            // değişkenleri yok edilir.
            }

            for (int i = 0; i < 5; i++) // yukarıdaki i değişkeni yukarı for bitince öldüğü için i ismini bir kez daha kullanabilirim
            {
                Console.Write("");
            }

            // if (true)
                // int y2 = 3; // tek satırlık scope'lerde declaration yapılmaz

        }

        public static void Multiply(int n1, int n2) // parametrelerin scopesi method bloğu olur
        {
            var res = n1 * n2; // res değişkeninin scopesi method bloğudur
            Console.WriteLine(res);
        }
    }
}