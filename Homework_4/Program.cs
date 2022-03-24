
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите цикл, который принимает на вход два натуральных числа (А и В) и возводит число А в степень B. ");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

Console.WriteLine("Введите натуральные числа А и В ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int i = 1;
int St = 1;
while (i <= B )
{
    St = St * A;
    i++;
}
Console.WriteLine(A + "  в степени " + B + " = " + St);


Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum =Math.Abs(N);
int count = 0;

while (Sum > 0 )
{
   int num = Sum - Sum/10*10;
   Sum = Sum/10;
   count += num;
}

Console.WriteLine("сумма цифр в числе  " + N + " = " + count);


Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

int [] array = new int[8];
Method_FillArray (array);

void Method_FillArray (int[] array)                         // метод заполнения чвссива случайными числами
{
    int index =  0;
    while (index < array.Length)
    {
    array[index] = new Random().Next(-1000,1000);     
    index++;
    }   
}

void PrintArray (int[] array)                                // метод распечатки элементов массива
{
    int count = array.Length;
    for (int i = 0; i< count; i++ )
    {
    Console.Write($"{array[i]}  ");
    }
Console.WriteLine ();
}

Console.WriteLine("исходный массив");
PrintArray (array);

void SelectionSort (int[] array)                         // метод сортировки элементов массива от мин значения к максимальному по модулю
{
    for (int i = 0; i < array.Length - 1; i++ )
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++ )
        {
            if (Math.Abs(array[j]) < Math.Abs(array [minPosition])) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;
    }    

}

SelectionSort  (array);
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("отсортированный по модулю от минимального к максимальному");
PrintArray (array);



// Дополнительные задания

Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

Console.WriteLine("Введите десятичное число ");
int number = Convert.ToInt32(Console.ReadLine());
void Dvcod (int number)                                       // метод перевода десятичного числа в двоичный
{
    string DvFigura1 = "";
    while (number >= 1)
    {
        DvFigura1 = DvFigura1 + Convert.ToString(number % 2);
        number = number / 2;
    }   
    int L = DvFigura1.Length;
    char [] sDvFigura = DvFigura1.ToCharArray();                     // преобразовать строку в символьный массив, затем выполнить реверсирование массива и этот массив преобразовать в строку.
    char [] sDvFigura1 = new char [L];                     // символьный массив для перевернутого числа
    int j=L;
    for (int i=0; i < L; i++)                         // цикл для переворота числа 
    {
    j=j-1;   
    sDvFigura1 [j] = sDvFigura [i];
    }
    string DvFigura2 = new string(sDvFigura1);
    
    if (DvFigura1 == DvFigura2) 
        Console.WriteLine ("десятичное число " + number + " = двоичному числу " + DvFigura2 + " - полиндром");
    else
        Console.WriteLine ("десятичное число " + number + " = двоичному числу " + DvFigura2 + " - не полиндром");
}
Dvcod (number);
