
Console.WriteLine(" Задача 54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine(" Задача 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine("введите размерность массива");

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());;
int [,] array = new int [rows, columns];

FillArray ();
Console.WriteLine("исходный массив");
PrintArray ();
Zadacha54 ();
Console.WriteLine("упорядоченный массив по убыванию по строкам ");
PrintArray ();
Console.WriteLine();
Console.WriteLine("задача 56 находит строку с наименьшей суммой элементов.");
Console.WriteLine("Прямоугольный массив");
PrintArray ();
Zadacha56 (); 

void FillArray ()                                   // метод заполнгения массива
{
    Random rand = new Random();
    for (int i= 0; i < rows; i++)                    
    {
        for (int j= 0; j < columns; j++)            
        {
            array [i, j] =  rand.Next(-10, 9);
        }
        
    }
}
void PrintArray ()                                // метод вывода массива
{
    for (int i= 0; i < rows; i++)
    {
        for (int j= 0; j < columns; j++)             
        {
           Console.Write (" {0}  ",  array [i, j]);
        }
        Console.WriteLine();
    }
}


void Zadacha54 ()                                //метод упорядочения элементов строки массива от максимального к минимальному
{
   
 for (int m = 0; m < columns - 1; m++)
 {

    for (int i= 0; i < rows; i++)                    
    {
        for (int j= 0; j < columns - 1; j++)            
        {
            if (array [i, j] < array [i, j+1])
            {
               int temp = array[i, j];
                array [i, j] = array[i, j+1];
                array[i, j+1] = temp;
            }
        }
    }
 }    
}


void Zadacha56 ()                              // метод нахождения строки в массиве с наименьшей суммой элементов
{
    int rowMinSum = 1; int min_i =1;
    for (int i= 0; i < rows; i++)                    
    {
        int temp1 = 0;
        for (int j= 0; j < columns; j++)            
        {
          temp1 = array[i, j] + temp1;
        }
        if  ( temp1 < rowMinSum) 
        {
            min_i = i;
            rowMinSum = temp1;
        }   
    }    
Console.WriteLine("минимальная сумма строк = " + rowMinSum + ", в строке под номером: " + (min_i +1));
}

Console.ReadLine();

Console.WriteLine(" Задача 58----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("   Выполните умножение двух двумерных матриц.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" введите кол строк и столюцов матрицы А");
int row1 = Convert.ToInt32(Console.ReadLine());
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите кол строк и столюцов матрицы B");
int row2 = Convert.ToInt32(Console.ReadLine());
int column2 = Convert.ToInt32(Console.ReadLine());

int [,] arr1 = new int [row1,column1];
int [,] arr2 = new int [row2,column2]; 

FillArr1 (arr1);
FillArr1 (arr2);
Console.WriteLine("Матрица А");
PrintArr1 (arr1);
Console.WriteLine("Матрица B");
PrintArr1 (arr2);
Console.WriteLine("Матрица С = А * В :");
Multiplication (arr1, arr2);
PrintArr1 (Multiplication(arr1, arr2));


int[,] Multiplication(int[,] a, int[,] b)                            // метод перемножения матриц
{
        
    if (a.GetLength(1) != b.GetLength(0)) 
    {
      if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить. Введите другие размерности матриц");  // принудительная генерация исключения 
    }
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
            return r;
}
 void PrintArr1(int[,] c)                                             // метод вывода массива
        {
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write("{0} ", c[i, j]);
                }
                Console.WriteLine();
            }
        }
    


void FillArr1 (int [,] array)                                           // метод запорлнения массива
{ 
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    Random rand = new Random();
    for (int i= 0; i < row; i++)                    
    {
        for (int j= 0; j < column; j++)            
        {
            array [i, j] =  rand.Next(-9, 8);
        }
        
    }
}


Console.ReadLine();

Console.WriteLine(" Задача 60----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("    Сформируйте трёхмерный прямоугольный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");


Random rnd = new Random();


int r1 = rnd.Next(2, 5);
int r2 = rnd.Next(2, 5);
int r3 = rnd.Next(2, 5);
int [, ,] arr = new int [r1, r2, r3];   // инициализация прямоугольного массива (z,y,x) заполненный нулевыми значениями 
int [][][] arrZ = new int [rnd.Next (3,6)][][];         // инициализация зубчатого трехмерного массива на рондомное кол стр



FillArr ();
PrintArr ();
Console.ReadLine();
FillArrZ ();
PrintArrZ ();


void FillArr ()                                   // метод заполнения прямоугольного 3-ех мерного массива
{
    Random rand = new Random();
    
    int L1 = arr.GetLength(0);
    int L2 = arr.GetLength(1);
    int L3 = arr.GetLength(2);
    int L4 = L1*L2*L3;
    int [] mass = new int [L4];                  // массив для проверки чисел на неповторяемость 
    mass [0] = 0;
    int k = 0;
    int q = 0;
    int g =0;

    for (int m= 0; m < L1; m++)
    {
        for (int i= 0; i < L2; i++)                    
        {
             for (int j= 0; j < L3; j++)            
            {
                int numm = rand.Next(10, 98);
                
                for (k = 0; k < L4; k++)                    // проверка на уникальность значений, вводимых в  3-ех мерный массив
                {
                    if (mass [k] != numm)
                       q++;
                }       
                    if (q == L4)
                    {
                        arr [m, i, j] = numm;
                        q = 0;
                        mass [g] = numm;
                        g++;
                    }
                    else
                    {
                        q = 0;
                        j--;
                    }
            }
        
        }
    }
}

void PrintArr ()                                // метод  вывода 3-ех мерного  прямоугольного  массива
{
    
    int L1 = arr.GetLength(0);
    int L2 =arr.GetLength(1);
    int L3 = arr.GetLength(2);
    Console.WriteLine ("Прямоугольный трехмерный массив размерностью: [" + L1 + ", "+ L2 + ", "+ L3 + "] ");
    for (int m= 0; m < L1; m++)
    {
         Console.WriteLine ("Page №: " + (m));

        for (int i= 0; i < L2; i++)                    
        {
             for (int j= 0; j < L3; j++)            
            {
               Console.Write ("arr ["+ m + ", " + i + ", "+ j + "] = "+ arr [m, i, j] + "; ");
            }
        Console.WriteLine ();
        }
    Console.WriteLine ("===========================================================================================");
    }
}
    
  void FillArrZ ()                                   // метод заполнения зубчатого 3-ех мерного массива
{
    Random rand = new Random();
    int L = arrZ.Length;
    for (int i= 0; i < L; i++)                    
    {
      arrZ [i] = new int [rand.Next(2, 9)][];     // генерация случайного кол строк для каждой из стр 
        for (int j= 0; j < arrZ[i].Length; j++)    // перебор строк       
        {
            arrZ [i][j] = new int [rand.Next(2, 9)];     // для каждой строки генерация рондомно кол элементов        
            for (int k= 0; k < arrZ[i][j].Length; k++)    //        
                {
                   arrZ [i][j][k] = rand.Next(100);     // для каждого элемента генерация рондомно значения        
                }
        }
    }
}

void PrintArrZ ()                                // метод  вывода 3-ех мерного зубчатого  массива
{
    
    Console.WriteLine ("Трехмерный зубчатый массив: ");
    for (int i= 0; i < arrZ.Length; i++)
    {
         Console.WriteLine ("Page №: " + (i));

        for (int j= 0; j < arrZ[i].Length; j++)                    
        {
             for (int k= 0; k < arrZ[i][j].Length; k++)            
            {
               Console.Write ("arr ["+ i + ", " + j + ", "+ k + "] = "+ arrZ [i][j][k] + "; ");
            }
        Console.WriteLine ();
        }
    Console.WriteLine ("==============================================================================================");
    }
}
    
Console.WriteLine(); 



Console.ReadLine();

Console.WriteLine(" Задача 62----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("    Заполнение спирально двумерного массива");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine(); 
int[,] myArr = new int [10, 10];
FillHelix (myArr, 10, 10);

void FillHelix( int [,] Mas, int sizeY, int sizeX )   // метод заполнения матрицы по спирали
{
  int Summ = sizeX * sizeY;
  int CorrectY = 0;
  int CorrectX = 0;
  int Count = 1;
  while( sizeY > 0 )
  {
    for ( int y = 0; y < 4; y++ )
    {
      for ( int x = 0; x < ( ( sizeX < sizeY ) ? sizeY : sizeX ); x++ )
      {
        if ( y == 0 && x < sizeX - CorrectX && Count <= Summ )
          Mas[(y + CorrectY),(x + CorrectX)] = Count++;
        if ( y == 1 && x < sizeY - CorrectY && x != 0 && Count <= Summ )
          Mas[(x + CorrectY),(sizeX - 1)] = Count++;
        if ( y == 2 && x < sizeX - CorrectX && x != 0 && Count <= Summ )
          Mas[(sizeY - 1),(sizeX - (x + 1))] = Count++;
        if ( y == 3 && x < sizeY - ( CorrectY + 1 ) && x != 0 && Count <= Summ )
          Mas[(sizeY - (x + 1)),(CorrectY)] = Count++;
      }
    }
    sizeY--;
    sizeX--;
    CorrectY += 1;
    CorrectX += 1;
  }
  PrintArrayM (Mas);
}		

void PrintArrayM (int [,] array)                                // метод вывода массива
{
    for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)             
        {
           Console.Write (" {0}  ",  array [i, j]);
        }
        Console.WriteLine();
    }
}



//ДОПНИКИ

Console.WriteLine(" Задача 1----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("    Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали. А элементы последней строки, элементами побочной диагонали.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine(); 
Console.WriteLine("введите размерность массива");

int rows1 = Convert.ToInt32(Console.ReadLine());
int columns1 = Convert.ToInt32(Console.ReadLine());;
int [,] array1 = new int [rows1, columns1];



FillArray1 (array1);
Console.WriteLine("исходный массив");
PrintArray1 (array1);
Console.WriteLine("упорядоченный массив c заменой строк ");
Zadacha1 (array1); 
PrintArray1 (array1);


void Zadacha1 (int [,] array)                                    // метод замены строк в массиве
{
    int temp = 0;
    int j ;
    int l1 = array.GetLength(0);
    int l2 = array.GetLength(1);
    for (j= 0; j < l2; j++)            
        {  if (j >l1-1) break;
            temp =  array [l1-1-j,  j];
           array [0, j] = array [j, j];
           array [l1-1, j] = array [l1-1-j,  j];
        }
        
        array [l1-1, j-1] = temp;
    
}

void FillArray1 (int [,] array)                                   // метод заполнгения массива
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);;
    for (int i= 0; i < rows; i++)                    
    {
        for (int j= 0; j < columns; j++)            
        {
            array [i, j] =  rand.Next(-10, 9);
        }
        
    }
}
void PrintArray1 (int [,] array)                                // метод вывода массива
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);;
    for (int i= 0; i < rows; i++)
    {
        for (int j= 0; j < columns; j++)             
        {
           Console.Write ( array [i, j] +"   ");
        }
        Console.WriteLine();
    }
}