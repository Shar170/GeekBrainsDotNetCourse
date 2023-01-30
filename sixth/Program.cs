/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

void task41(){
    
    Console.WriteLine("Вводите числа по очереди, по окончанию ввода, без ввода числа нажмите Enter");
    int counter = 0;
    while(true){
        string? str = Console.ReadLine();
        if (str != null && str.Length > 0){
            int a = Convert.ToInt32(str);
            if (a > 0) counter++; 
        }else{
            break;
        }
    }
    Console.WriteLine($"Чисел больше 0: {counter}");
}



void task43(){
    Console.WriteLine("Ищем пересечение прямых: \ny = k1 * x + b1\ny = k2 * x + b2\nВведите коэффициенты");
    double b1, k1, b2, k2;
    
    Console.Write("Введите значение для b1: ");
    b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите значение для k1: ");
    k1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите значение для b2: ");
    b2 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите значение для k2: ");
    k2 = Convert.ToDouble(Console.ReadLine());

    if(k1 == k2){
        if(b1 == b2){
            Console.WriteLine("Прямые совпадают");
            return;
        }else{
            Console.WriteLine("Прямые параллельны");
            return;
        }
    }else{
        double x = (b2-b1)/(k1 - k2);
        double y = k1*x+b1;
        Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
    }


}






task43();