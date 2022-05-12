static public class Sorting
{
    static void Swap<T>(ref T leftElem, ref T rightElem)
    {
        T tmp = leftElem;
        leftElem = rightElem;
        rightElem = tmp;
    }


    static int[] SelectionSort(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
                if (array[minIndex] > array[j])
                    minIndex = j;

            int tmp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tmp;
        }


        return array;
    }

    static int[] BubbleSort(int[] array)
    {
        //add checking if swap was produced (TO IMPROVE)
        for (int i = 0; i < array.Length-1; i++)
            for (int j = 0; j < array.Length-1; j++)
                if (array[j] > array[j + 1])
                {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }

        return array;
    }

    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
            return array;

        int pivotIndex = minIndex;
        for (int i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                Swap(ref array[i], ref array[pivotIndex]); //transfer little elements to the left side
                pivotIndex++; //counting how many elements are less than last. according to this, we increase pivotIndex
            }
        }
        Swap(ref array[pivotIndex], ref array[maxIndex]); //put pivot to the correct place in array

        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }
    
}

