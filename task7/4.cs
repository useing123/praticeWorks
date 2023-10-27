public class MyArray
{
    private int[] elements;

    public MyArray(int[] values)
    {
        elements = values;
    }

    public static MyArray operator *(MyArray array1, MyArray array2)
    {
        int length = Math.Min(array1.Length, array2.Length);
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = array1[i] * array2[i];
        }
        return new MyArray(result);
    }

    public int this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    public static int operator true(MyArray array)
    {
        return array.Length;
    }

    public static bool operator ==(MyArray array1, MyArray array2)
    {
        return array1.elements.SequenceEqual(array2.elements);
    }

    public static bool operator !=(MyArray array1, MyArray array2)
    {
        return !array1.elements.SequenceEqual(array2.elements);
    }

    public static bool operator <=(MyArray array1, MyArray array2)
    {
        return array1.Length <= array2.Length;
    }

    public int Length => elements.Length;
}
