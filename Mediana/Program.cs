namespace Mediana
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //ввод исходного массива
            Console.WriteLine("Введите количество элементов массива");
            int countnum = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[countnum];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            

            //вызов функции добавления массива 
            arr = AddNum(arr, 4);
            //вызов функции нахлождения медианы
            double MediaFinder = FindMedian(arr);
            Console.WriteLine("Вывод итогового массива");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Медиана равна = {MediaFinder}");


        }


        static double FindMedian(int[] arr) //нахождение медианы
        {
            double sum = 0;
            double result = 0;
            
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr.Length % 2 == 0) //если длина массива четная, то мы должны найти среднее значение двух средних чисел 
                {
                    int mid1 = arr[arr.Length / 2 - 1];
                    int mid2 = arr[arr.Length / 2];
                    return (mid1 + mid2) / 2.0; 
                }
                else // если нечетная длинна массива, то заносим просто средний элемент массива
                {
                    return arr[arr.Length / 2]; 
                }
            }
            return result;
            
        }
        //функция добавления числа в исходный массив
        static int[] AddNum(int[] arr, int num)
    {
        // создаем новый массив с новым размером
        int[] newArray = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArray[i] = arr[i];
        }

        newArray[newArray.Length - 1] = num;

        return newArray;
    }
    }
}
