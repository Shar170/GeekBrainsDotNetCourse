/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetSecondDigit(int num){
    int n_count = (int)Math.Ceiling(Math.Log10(Math.Abs(num)));
    if (n_count != 3) return -1;

    return (num%100)/10;
}

int GetThirdDigit(int num){
    int n_count = (int)Math.Ceiling(Math.Log10(Math.Abs(num)));
    if (n_count < 3) return -1;
    int result = num / (int)Math.Pow(10,n_count-3) %10;
    return result;
}

bool IsWeekend(int dayOfWeek){
    if (dayOfWeek > 7 || dayOfWeek <= 5 || dayOfWeek < 1) return false;
    return true;
}



int a = -1;
while(a != 0){
    Console.Write("Введите номер задачи 10,13,15 выход из программы 0: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (a == 0) break;
    int n1;
    int r;
    Console.ForegroundColor = ConsoleColor.Blue;
    switch (a){
        case 10:
            Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа ");
            Console.Write("Введите число : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            r = GetSecondDigit(n1);
            if (r != -1){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Вторая цифра числа: {r}");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вторая цифра в числе {n1} отсутсвует");
            }
            break;
        case 13:
            Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
            Console.Write("Введите число : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            r = GetThirdDigit(n1);
            if (r != -1){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Третья цифра числа: {r}");
            }
            else{ 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Третья цифра в числе {n1} отсутсвует");
            }
            break;
        case 15:
            Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
            Console.Write("Введите номер дня недели(1-7): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            bool isWeekend = IsWeekend(n1);
            if (isWeekend){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Это выходной :)" );
            }else{ 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Увы, это не выходной :(");
            }
            break;
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n--------------------------------------------------\n\n");
    Console.ResetColor();
}