// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 1)
{    Console.WriteLine("Понедельник");}
else
{
    if (N == 2)
    {Console.WriteLine("Вторник");}
    else 
    {
        if (N == 3)
        {Console.WriteLine("Среда");}
        else 
        {
            if (N == 4)
            {Console.WriteLine("Четверг");}
            else
            {
                    if (N == 5)
                {Console.WriteLine("Пятница");}
                else
                {
                    if (N == 6)
                    {Console.WriteLine("Суббота");}
                    else
                    {
                        if (N == 7)
                        {Console.WriteLine("Воскресенье");}
                        else
                        {Console.WriteLine("Ошибка");}
                    }
            
            }

            }
            }
    }
}