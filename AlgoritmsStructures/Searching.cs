static public class Searching
{

    //check IndexOf(5) [5 1 2 3 5] -- 
    //check IndexOf(myObject_inst2) [myObject_inst1 myObject_inst2 myObject_inst3]
    static public int LinearSearch(int[] array, int item)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == item)
                return i;

        return -1;
        //return array.ToList().IndexOf(item);
        //var a = array.ToList().Select(x => x * x);
        //return 0;
    }


    static public int BinarySearch(int[] array, int item)
    {
        var start = 0;
        var end = array.Length-1;
        int middle;

        //while (start <= end)
        //{
        //    middle = (start + end) / 2;
        //    if (array[middle] == item)
        //        return middle;

        //    if (array[middle] < item)
        //        start = middle + 1;
        //    else
        //        end = middle - 1;

        //}
        while (start + 1 < end)
        {
            middle = (start + end) / 2;

            if (array[middle] < item)
                start = middle;
            else
                end = middle;
        }
        if (array[start]==item)
            return start;
        else if (array[end]==item)
            return end;
        else
            return -1;

    }


    static public int RecursiveBinarySearch(int[] array, int item) => RecursiveBinarySearch(array, item, 0, array.Length-1);

    static private int RecursiveBinarySearch(int[] array, int item, int start, int end)
    {
        int middle = (start + end) / 2;

        if (array[middle] == item)
            return middle;
        else if (start == end)
            return -1;

        if (array[middle] < item)
            return RecursiveBinarySearch(array, item, middle + 1, end);
        else
            return RecursiveBinarySearch(array, item, start, middle-1);

    }
}

