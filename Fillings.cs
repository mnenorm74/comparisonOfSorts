using System;

namespace comparisonOfSorts
{
    public static class Fillings
    {
        //Заполнение массива значениями по возрастанию
        public static int[] FillAscending(int[] array)
        {
            var size = array.Length;
            for (var i = 0; i < size; i++)
            {
                array[i] = i;
            }
            return array;
        }

        //Заполнение массива значениями по убыванию
        public static int[] FillDescending(int[] array)
        {
            var size = array.Length;
            for (var i = 0; i < size; i++)
            {
                array[i] = size - i;
            }
            return array;
        }

        //Заполнение массива случайными числами
        public static int[] FillRandomly(int[] array)
        {
            var size = array.Length;
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                array[i] = random.Next();
            }
            return array;
        }
    }
}