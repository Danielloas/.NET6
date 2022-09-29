
//задаем для консоли переменные. К примеру num1 and nom2;
float num1 = 0; //(число 1 , 0 - это пустая ячейка которую будет задавать) (fload - все возможные числа с долями)
float num2 = 0; //(число 2 , 0 - это пустая ячейка которую будет задавать) (int - целые числа)

//сделаем креативное привественное окно =)
Console.WriteLine("Hello my programm c# =)\r");
Console.WriteLine("------------------------\n");

//теперь придумаем что будем делать с num1 and num2. Например: будем в процессе работы выбирать 
Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine()); //конвертируем значения которые будем указывать в консоли (значение #1)

Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine()); //конвертируем значения которые будем указывать в консоли (значение #2)

//создадим вариации возможных операций с числами
Console.WriteLine("Какую совершим операцию: ");
Console.WriteLine("\ta - сумма чисел");
Console.WriteLine("\ts - вычитание");
Console.WriteLine("\td - умножение");
Console.WriteLine("\tf - диление");
Console.Write("Какое выполняем действие?");

//теперь ко всем вариациям привяжем значения и вырожение выполняемых действий (a-s-d-f)
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Вывод: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Вывод: {num1} - {num2} = " + (num1 - num2));
        break;
    case "d":
        Console.WriteLine($"Вывод: {num1} * {num2} = " + (num1 * num2));
        break;
    //добавим условие если будем выполнять упражнения с 0
    case "f":
        while ( num2 == 0)
        {
            Console.WriteLine("Так делать нельзя, введите значение > or < 0");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Вывод: {num1} / {num2} = " + (num1 / num2));
        break;

}

Console.Write("Конец программы! Для выхода нажмите пожалуйста Enter....");
Console.ReadKey();
