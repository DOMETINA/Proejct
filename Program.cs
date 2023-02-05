// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых 
//меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// int[] filterEvens(int[] array)
// {
//     int[] result = { };
//     int[] tmpArray = new int[10];
//     int tal = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 != 0)
//         {
//             continue;
//         }
//         tmpArray[tal++] = array[i];
//         if (tal >= tmpArray.Length)
//         {
//             int oldSize = result.Length;
//             Array.Resize(ref result, oldSize + tal);
//             Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
//             tal = 0;
//         }
//     }

//     if (tal > 0)
//     {
//         int oldSize = result.Length;
//         Array.Resize(ref result, oldSize + tal);
//         Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
//     }

//     return result;
// }


// using System;
// using static System.Console;

// Clear();

// string[] array = AskArray();
// string[] result = FindLessThan(array, 3);
// WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

// string[] FindLessThan(string[] input, int n) {
//     string[] output = new string[CountLessThan(input, n)];

//     for(int i = 0, j = 0; i < input.Length; i++) {
//         if(input[i].Length <= n) {
//             output[j] = input[i];
//             j++;
//         }
//     }

//     return output;
// }

// int CountLessThan(string[] input, int n) {
//     int count = 0;

//     for(int i = 0; i < input.Length; i++) {
//         if(input[i].Length <= n) {
//             count++;
//         }
//     }

//     return count;
// }

// string[] AskArray() {
//     Write("Введите значения через пробел: ");
//     return ReadLine().Split(" ");
// }


// Выводим запрос на ввод количества элементов массива(size).
// Пользователь заполняет массив с клавиатуры.
// Задаем массив arr1 размером size.
// Задаем переменную i (индекс элемента).
// Вводим переменную count (счетчик элементов подходящих под условие).
// Выводим на экран полученный массив arr1.
// Вводим переменную maxSymbols (максимально допустимое количество символов в элементе). По условию maxSymbols = 3.
// Вводим элементы массива начиная с первого arr1[0], до тех пор, пока индекс [i] меньше длины массива size, прибавляя по одному.
// Каждый элемент массива проверяем по условию: длинна элемента arr[i] <= maxSymbols. Если условие соблюдено, увеличиваем count на один. Если нет - переходим к проверке следующего элемента массива arr1[i+1].
// Заполняем новый массив arr2 в пределах цикла. Для этого повторно проводим проверку каждого элемента массива, чтобы длина элемента arr1[i] была больше или равна maxSymbols. Если условие соблюдено, элементу arr2[j] присваиваем соответствующее значение элемента arr1[i]. Записываем его в массив arr2. Если нет, переходим к проверке следующего элемента arr1[i+1].
// Выводим полученный массив arr2 на экран.


// class Program
//     {
//         static void Main(string[] args)
//         {
//             string text = Console.ReadLine();
//             string[] spled = text.Split(new char[]{' ', ':','.',',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
//             var res = from word in spled
//                       where word.Length == 3
//                       select word;
//             if (res.Count() == 0)
//             {
//                 Console.WriteLine("no 3 length words");
//             }
//             else
//             {
//                 foreach (string s in res)
//                 {
//                     Console.WriteLine(s);
//                 }
//             }
//             Console.ReadLine();
//         }
//     }