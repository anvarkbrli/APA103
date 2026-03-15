namespace _02_HeapStackRefOutArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 34, 76, 88 };
            int[] resizedArray = ArrayResize(numbers, 11, 22, 33, 44, 48, 96, 12);
            for (int i=0; i< resizedArray.Length; i++)
            {
                Console.Write(resizedArray[i] + " ");
            }
        }
          
        public static int[] ArrayResize(int[] array, params int[] newElements)
        {
            int[] newArray = new int[array.Length + newElements.Length];

            for (int i = 0; i <newArray.Length; i++)
            {
                if (i < array.Length)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i] = newElements[i - array.Length];
                }

            }
            return newArray;
            
        }
    }
}
