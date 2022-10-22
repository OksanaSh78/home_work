/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные чмсла от 1 до N
 5 -> 2, 4
 8 -> 2, 4, 6, 8
*/
int n;
int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + n);
            while (i <= n)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

           