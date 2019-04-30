namespace comparisonOfSorts
{
    public class Sorts
    {
        static int[] temporaryArray;
        
        // Пузырьковая сортировка
        public static void BubbleSort(int[] array)
        {
            var size = array.Length;
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var secondValue = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = secondValue;
                    }
                }
            }
        }

        //Сортировка вставками
        public static void InsertionSort(int[] array)
        {
            var size = array.Length;
            for (var i = 1; i < size; i++)
            {
                var value = array[i];
                var index = i;
                while (index > 0 && value < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = value;
            }
        }
        
        //Сортировка слиянием
        public static void MergeSort(int[] array)
        {
            var size = array.Length;
            temporaryArray = new int[size];
            MergeSort(array, 0, size - 1);
        }
        
        private static void MergeSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            var middle = (start + end) / 2;
            MergeSort(array, start, middle);
            MergeSort(array, middle + 1, end);
            MergeArrays(array, start, middle, end);
        }
        
        private static void MergeArrays(int[] array, int start, int middle, int end)
        {
            var left = start;
            var right = middle + 1;
            var length = end - start + 1;
            for (var i = 0; i < length; i++)
            {
                if (right > end || (left <= middle && array[left] < array[right]))
                {
                    temporaryArray[i] = array[left];
                    left++;
                }
                else
                {
                    temporaryArray[i] = array[right];
                    right++;
                }
            }

            for (var i = 0; i < length; i++)
            {
                array[i + start] = temporaryArray[i];
            }
        }
        
        //Быстрая сортировка
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        
        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            var supportingElement = array[end];
            var storeIndex = start;
            for (var i = start; i <= end - 1; i++)
            {
                if (array[i] <= supportingElement)
                {
                    var currentValue = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = currentValue;
                    storeIndex++;
                }
            }

            var storeValue = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = storeValue;
            if (storeIndex > start) 
                QuickSort(array, start, storeIndex - 1);
            if (storeIndex < end) 
                QuickSort(array, storeIndex + 1, end);
        }

        //Сортировка выбором
        public static void SelectionSort(int[] array)
        {
            var size = array.Length;
            for (var i = 0; i < size - 1; i++)
            {
                var minimumIndex = i;
                for (var j = i + 1; j < size; j++)
                {
                    if (array[j] < array[minimumIndex])
                        minimumIndex = j;
                }
                
                var currentValue = array[i];
                array[i] = array[minimumIndex];
                array[minimumIndex] = currentValue;
            }
        }
        
        //Шейкерная сортировка
        public static void ShakerSort(int[] array)
        {
            var leftBorder = 0;
            var rightBorder = array.Length - 1;
 
            while (leftBorder <= rightBorder)
            {
                for (var i = leftBorder; i < rightBorder; i++) 
                {
                    if (array[i] > array[i + 1])
                    {
                        var currentValue = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = currentValue;
                    }
                }
                rightBorder--;
 
                for (var i = rightBorder; i > leftBorder; i--) 
                {
                    if (array[i - 1] > array[i])
                    {
                        var currentValue = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = currentValue;
                    }
                }
                leftBorder++; 
            }
        } 
    }
}