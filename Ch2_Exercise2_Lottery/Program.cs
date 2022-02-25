using System;

namespace Ch2_Exercise2_Lottery
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * The program randomly generates a
                lottery of a two-digit number, prompts the user to enter a two-digit number, and determines
                whether the user wins according to the following rules:
                1. If the user input matches the lottery number in the exact order, the award is $10,000.
                2. If all digits in the user input match all digits in the lottery number, the award is $3,000.
                3. If one digit in the user input matches a digit in the lottery number, the award is $1,000.
                Note that the digits of a two-digit number may be 0. If a number is less than 10, we assume
                the number is preceded by a 0 to form a two-digit number. For example, number 8 is treated
                as 08 and number 0 is treated as 00 in the program.
             */

            /* TODO:
             *      1. Generate a two-digit random number (lottery number)
             *      2. Take input from the user
             *      3. If the user knows the lottery number, provide $10,000
             *      4. if digits match, provide $3,000
             *      5. if one digit matches, provide $1,000
             *      Note. if input is one digit, then append 0 at the begginning: 8 -> 08
             */

            // 1. Generate a two-digit random number (lottery number)
            Random random = new Random(); // burada Seed testlerin hızlı yapılması amaçlı kullanılıyor
            int lotteryNumber = random.Next(10, 100);
            
            // 2. Take input from the user
            Console.Write("Enter your guess: ");
            int guess;
            Int32.TryParse(Console.ReadLine(), out guess);
            
            // 3. If the user knows the lottery number, provide $10,000
            if (guess == lotteryNumber)
                Console.WriteLine("You've earned $10,000");
            else
            {
                // guess = 23 -> digit1 = 3, digit2 = 2 -> 10*digit1 + digit2 = 30 + 2 = 32;
                // 4. if digits match, provide $3,000
                int guessDigit1 = guess % 10;
                int guessDigit2 =
                    guess / 10; // tek basamaklı inputlarda burası otomatik olarak sıfır olur. Örn; 8 / 10 = 0
                int guessReverse = 10 * guessDigit1 + guessDigit2;
                if (guessReverse == lotteryNumber)
                    Console.WriteLine("You've earned $3,000");
                else // Note: if if bağlantıları hatalı. İki if de çalışacağı durumlar var bundan sebep else kullandık
                {
                    // 5. if one digit matches, provide $1,000
                    int lotteryDigit1 = lotteryNumber % 10;
                    int lotteryDigit2 = lotteryNumber / 10;
                    if (guessDigit1 == lotteryDigit1 || guessDigit1 == lotteryDigit2 || guessDigit2 == lotteryDigit1 ||
                        guessDigit2 == lotteryDigit2)
                        Console.WriteLine("You've earned $1,000");
                }
                Console.WriteLine("Lottery number was " + lotteryNumber);
                
                // if if bağlantı hatası için başka bir çözüm
                // int lotteryDigit1 = lotteryNumber % 10;
                // int lotteryDigit2 = lotteryNumber / 10;
                // if (guessReverse == lotteryNumber)
                //     Console.WriteLine("You've earned $3,000");
                // // 5. if one digit matches, provide $1,000
                // else if (guessDigit1 == lotteryDigit1 || guessDigit1 == lotteryDigit2 || guessDigit2 == lotteryDigit1 ||
                //          guessDigit2 == lotteryDigit2)
                //     Console.WriteLine("You've earned $1,000");
            }
        }
    }
}