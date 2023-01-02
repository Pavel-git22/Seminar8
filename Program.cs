// // Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // В итоге получается вот такой массив:

// // 8 4 2 4
// // 5 9 2 3
// // 1 4 7 2



// int[,] Create2DRandomArray (int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] ChangeRows (int[,] array, int row1, int row2)
// {
//     if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
//     return array;
//     else
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[row1,j];
//         array[row1,j] = array[row2,j];
//         array[row2,j] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер строки которую хотите поменять:");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер второй строки которую хотите поменять:");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// Console.WriteLine();
// ChangeRows(myArray, r1, r2);
// Show2DArray(myArray);


// Задание 2. Напишите программу, которая меняет строки и столбцы местами


// int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] RowsToColomns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//         return array;
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i+1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// myArray = RowsToColomns(myArray);
// Show2DArray(myArray);


// //Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// // то есть удалаем и строку и столбец в которой находится этот элемент


// int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}


// int[,] FindMinNumber(int[,] array)
// {
//     int min = array[0, 0];
//     int newi = 0;
//     int newj = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min >=  array[i, j])
//             {
//                 min = array[i, j];
//                 newi = i;
//                 newj = j;
//             }
//         }
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array [newi,i] = 0; 
//     }

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array [j,newj] = 0; 
//     }
//     return array;
// }


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// myArray = FindMinNumber(myArray);
// Show2DArray(myArray);


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] array54 = {
// {1, 4, 7, 2},
// {5, 9, 2, 3,},
// {8, 4, 2, 4}
// };


// Show2DArray(array54);
// Console.WriteLine();


// int[,] organizesColomns(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int Count= 0 ;
//         for (int j = 0; j < array.GetLength(1) - Count+1; j++)
//         {

//             for (int k = 0; k < array.GetLength(1) -1; k++)
//             {                
//                 if (array[i, k] < array[i, k+1])
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, k+1];
//                     array[i, k+1] = temp;
//                     Count++;
//                 }

//             }

//         }
//     }
//     return array;
// }

// Show2DArray(organizesColomns(array54));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] array56 = {

{1, 4, 7, 2},

{5, 9, 2, 3},

{8, 4, 2, 4},

{5, 2, 6, 7},
};

int minRow(int[,] array)
{
    int[,] SumArray = new int[4, 4];
    int[,] minSumArray = new int[4, 4];
    int RowMin = 0;
    int stroka = 1;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        RowMin = RowMin + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int RowMinTemp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            RowMinTemp = RowMinTemp + array[i, j];
        }
        if (RowMinTemp < RowMin)
        {
            RowMin = RowMinTemp;
            stroka = i+1;
        }
    }
    return stroka;
}

Console.WriteLine($"  Cтроки с наименьшей суммой элементов :  {minRow(array56)}  строка");






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Array1 ={
//     {2,4},
//     {3,2}
// };

// int[,] Array2 ={
//     {3,4},
//     {3,3}
// };


// int[,] mulArray(int[,] array1, int[,] array2)
// {
//     int[,] arrMul = { { 0, 0 }, { 0, 0 } };

//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(1); k++)

//                // arrMul[i,j] = array1[i,j]*array2[i,j] + array1[i, k] * array2[k, j];
//                 arrMul[i, j] += array1[i, k] * array2[k, j];

//         }
//     }


//     return arrMul;

// }

// Show2DArray(mulArray(Array1, Array2));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] Create3DRandomArray(int rows, int colomns, int zz)
// {
//     int[,,] newArray = new int[rows, colomns, zz];
//     int Count = 1;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             for (int k = 0; k < zz; k++)
//             {       
//                 int a = 10*Count;
//                 int b =10+10*Count;         
//                 newArray[i, j, k] = new Random().Next(a, b);
//                 ++Count;
//             }
//         }
//     }
//     return newArray;
// }


// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"  {array[i, j, k]}  ( {i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] MyArray1 = Create3DRandomArray(2, 2, 2);
// Show3DArray(MyArray1);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] arrSpiral()
{
    int number = 1;
    int[,] arr = { { 0, 0, 0, 0 }, { 0, 0, 0, 0, }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
    while (number < 17)
    {
        if (number < 5)
        {
            arr[0, number - 1] = number;

        }
        if (number > 4 && number < 8)
        {

            arr[number - 4, 3] = number;
        }
        if (number > 7 && number < 11)
        {

            arr[3, 10 - number] = number;
        }
        if (number > 10 && number < 13)
        {
            arr[13 - number, 0] = number;
        }
        if (number > 12 && number < 15)
        {
            arr[1, number - 12] = number;
        }
        if (number > 14 && number < 17)
            arr[2, 17 - number] = number;




        number++;

    }
    return arr;
}

Show2DArray(arrSpiral());
