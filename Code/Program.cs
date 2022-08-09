/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

namespace IvanovAleksei
{
    class ControlWork
    {
        public static void Main(string[] args)
        {
            string[]array = new string[]{"hello", "2", "world", ":-)"};
            string[]result = new string[array.Length];
            FillNewArray(array, result);
            PrintArray(result);
        }
        public static void FillNewArray(string[]array, string[]result)
        {
            int count = 0;
            for(int i = 0; i< array.Length; i++) 
            {
                if(array[i].Length <= 3)
                {
                result[count] = array[i];
                count++;
                }
            }           
        }
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();
        }      
    }
}