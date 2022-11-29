using System;

namespace RepetitionOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 3, 2, 5, 5, 5, 2, 2, 5, 2, 7, 8, 4, 4, 2, 2, 2, 5, 1, 1 };

            Console.WriteLine("Исходная последовательность:");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int[] temp = new int[array.Length];
            int count = 0;

            // Проверка на равность элементов с идущими далее (в случае того, что после элемента идет отличающийся, элемент добавляется в временный массив)
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    temp[count++] = array[i];
                }
            }
            // Добавление во временный массив последнего элемента исходного массива, так как после него в любом случае не может быть поатора
            temp[count++] = array[array.Length - 1];

            // Пересоздание исходного массива с учетом нового размера
            array = new int[count];
            // Копирование временного масива в исходный, но уже с новым размером
            Array.Copy(temp, array, count);

            Console.WriteLine("Последовательность после ликвидации идущих подряд повторов элементов:");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
