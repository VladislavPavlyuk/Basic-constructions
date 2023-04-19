// See https://aka.ms/new-console-template for more information

/*
1. Определить, является ли введённое число любой разрядности палиндромом (например, 1234321 – палиндром, 12345 – не палиндром).
2. Осуществить циклический сдвиг введённого числа на N разрядов. Направление сдвига задает пользователь. Например, при сдвиге числа 12345 влево на 3 разряда получится число 45123. При сдвиге числа 12345 вправо на 3 разряда получится число 34512.
3. В цикле с клавиатуры вводятся 15 целых чисел. Необходимо найти самую длинную неубывающую цепочку чисел. На экран вывести найденную максимальную длину цепочки и порядковый номер того числа, с которого цепочка началась
*/


using System;

namespace Program
{
    class Move
    {
        public void test()
        {
            Console.Write("Пожалуйста введите число для сдвига : ");
            
            int A = int.Parse(Console.ReadLine());

            int digits = 0;

            bool check = true;

            int B = A;

            while (check)       // Подсчет количества знаков
            {
                B /= 10;

                if (B > 1)
                    digits++;
                else
                    check = false;
            }

            B = A;            

            Console.Write("Ведите количество раздрядов для сдвига вправо. Ставьте знак минус, если сдвиг нужно произвести влево : ");

            int N = int.Parse(Console.ReadLine());

            if (N >= 0)
            {
                for (int i = 0; i < N; i++)         //сдвиг вправо
                {
                    int lastX = (int)B % 10;        //узнаем последнюю цифру

                    int tempX = (int)B / 10;


                    B = (int)Math.Pow(10, digits) * lastX + tempX;

                }
            }
            else
            {
                N = N * (-1);

                for (int i = 0; i < N; i++)         //сдвиг влево
                {
                    int firstX = (int)B / (int)Math.Pow(10, digits);        //узнаем первую цифру

                    int tempX = (int)B * 10 + firstX;

                    B = tempX - firstX * (int)Math.Pow(10, digits + 1);

                }
            }

            Console.WriteLine("Введенное значение : " + A);
            Console.WriteLine("Полученное значение : " + B);
        }
    }
    class Palindrome
    {       
        public void test()
        {            
            Console.Write("Пожалуйста введите число для проверки : ");

            string A = Console.ReadLine();

            int j = A.Length - 1;

            bool a = false;

            for (int i = 0; i <= A.Length; i++) 
            {
                if (A[i] != A[j])
                {
                    Console.WriteLine("Сожалею! Введенное число не является палиндромом!");

                    return;
                }
                else
                {
                    a = true;
                }

                j--;

                if (((i == j) || (i <= j)) && (a))
                {
                    Console.WriteLine("Поздравляю! Введенное число является палиндромом!");
                    return;
                }
            }            
        }
    }
    class MainClass
    {
        static void Main()
        {            
            string answer;
            do
            {
                Console.Clear();

                Console.WriteLine("" +
                    "1. Определить, является ли введённое число любой разрядности палиндромом (например, 1234321 – палиндром, 12345 – не палиндром).\r\n2. Осуществить циклический сдвиг введённого числа на N разрядов. Направление сдвига задает пользователь. Например, при сдвиге числа 12345 влево на 3 разряда получится число 45123. При сдвиге числа 12345 вправо на 3 разряда получится число 34512.\r\n3. В цикле с клавиатуры вводятся 15 целых чисел. Необходимо найти самую длинную неубывающую цепочку чисел. На экран вывести найденную максимальную длину цепочки и порядковый номер того числа, с которого цепочка началась" +
                    "\r\n0. Выход");

                Console.Write("Введите номер задания: ");

                string str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        Console.WriteLine("Палиндром");

                        Palindrome obj = new Palindrome();

                        obj.test();

                        break;

                    case "2":
                        Console.WriteLine("Сдвиг");

                        Move move = new Move();

                        move.test();

                        break;

                    case "3":
                        Console.WriteLine("Wednesday");
                        break;
                    case "0":
                        Console.WriteLine("Thank you!");
                        return;
                        break;
 
                    default:
                        Console.WriteLine("Такого задания нет!");
                        break;
                }
                Console.WriteLine("Ещё раз? д/н");
                answer = Console.ReadLine();
            } while (answer == "д" || answer == "Д");


        }
    }

    
}


