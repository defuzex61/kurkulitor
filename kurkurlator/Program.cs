
{
    Console.WriteLine("1.Сложить 2 числа");
    Console.WriteLine("2.Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    int choose = Convert.ToInt32(Console.ReadLine());
    while (choose < 9)
    {

        Console.WriteLine("Введите числа ");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        if (choose == 1)
        {
            c = a + b;
            Console.WriteLine("Ответ ", c);
        }
        else if (choose == 2)
        {
            c = a - b;
            Console.WriteLine("Ответ ", c);
        }
        else if (choose == 3)
        {
            c = a * b;
            Console.WriteLine("Ответ ", c);
        }
        else if (choose == 4)
        {
            c = a / b;
            Console.WriteLine("Ответ ", c);
        }

        else if (choose == 5)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                c = a * c;

            }
            Console.WriteLine("Ответ ", c);
        }
        else if (choose == 6)
        {
            c = (int)Math.Sqrt(a);
            int c1 = (int)Math.Sqrt(b);
            Console.WriteLine("Ответ ", c);
            Console.WriteLine(c1);
        }
        else if (choose == 7)
        {

            c = (int)(b * 0.01);
            int c1 = (int)(a * 0.01);
            Console.WriteLine("Ответ ", c);
            Console.WriteLine(c1);
        }
        else if (choose == 8)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                a = a * i;
            }
            Console.WriteLine("Ответ ", a);
        }
    }
