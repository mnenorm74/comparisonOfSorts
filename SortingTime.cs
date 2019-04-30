using ZedGraph;
using System.Diagnostics;
using static comparisonOfSorts.Sorts;
using static comparisonOfSorts.Fillings;

namespace comparisonOfSorts
{
    class SortingTime
    {
        public static PointPairList GetSortingList(string fillingType, string sortingType)
        {
            var list = new PointPairList();
            for (var i=0; i < 10000; i+=1000)
            {
                var array = new int[i];
                switch(fillingType)
                {
                    case "Случайно":
                        FillRandomly(array);
                        break;
                    case "По возрастанию":
                        FillAscending(array);
                        break;
                    case "По убыванию":
                        FillDescending(array);
                        break;
                }
                list.Add(i, GetSortingTime(array, sortingType)); 
            }
            return list;
        }

        public static long GetSortingTime(int[] array, string type)
        {
            var time = new Stopwatch();
            time.Start();
            switch (type)
            {
                case "Пузырьковая":
                    BubbleSort(array);
                    break;
                case "Вставками":
                    InsertionSort(array);
                    break;
                case "Слиянием":
                    MergeSort(array);
                    break;
                case "Быстрая":
                    QuickSort(array);
                    break;
                case "Выбором":
                    SelectionSort(array);
                    break;
                case "Шейкерная":
                    ShakerSort(array);
                    break;
            }
            time.Stop();
            return time.ElapsedMilliseconds;
        }
    }
}
