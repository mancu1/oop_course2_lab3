/*

Объявить класс, содержащий одномерный целочисленный массив, 
также функцию, для печати элементов этого массива. Конструктор 
класса принимает один параметр – ссылку на массив (внешний массив). 
Конструктор выделяет память под внутренний массив размерностью 
совпадающий с размерностью внешнего массива, затем значения 
элементов внешнего массива копирует во внутренний массив. Класс 
также должен содержать поля readonly для минимального и 
максимального элемента массива. Значения этих полей определяются в 
результате работы конструктора. Элементы внешнего массива ввести с 
клавиатуры. Создать объект этого класса . Распечатать элементы 
массива объекта, минимальное и максимальное значение массива 
объекта.

*/



namespace lab3
{
    class ArrayClass
    {
        public readonly int[] Arr;
        public readonly int MaxArr;
        public readonly int MinArr;
        
        public ArrayClass(ref int[] arr)
        {
            Arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                Arr[i] = arr[i];
            }
            MinArr = Arr[0];
            MaxArr = Arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                MinArr = MinArr < Arr[i] ? MinArr : Arr[i];
                MaxArr = MaxArr > Arr[i] ? MaxArr : Arr[i];
            }
        }
    }
    
    internal static class Program
    {
        static void Main(string[] args)
        {
            // input array
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // create object
            ArrayClass obj = new ArrayClass(ref arr);
            
            // print array
            
            for (int i = 0; i < obj.Arr.Length; i++)
            {
                Console.Write(obj.Arr[i] + " ");
            }
            
            // print min and max
            
            Console.WriteLine("\nMin: {0}\nMax: {1}", obj.MinArr, obj.MaxArr);
        }
    }
}