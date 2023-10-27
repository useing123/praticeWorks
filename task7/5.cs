public class MyArray
{
    private int[] elements;

    public MyArray(int[] values)
    {
        elements = values;
    }

    public int this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    public static bool operator ==(MyArray array1, MyArray array2)
    {
        return array1.elements.SequenceEqual(array2.elements);
    }

    public static bool operator !=(MyArray array1, MyArray array2)
    {
        return !array1.elements.SequenceEqual(array2.elements);
    }

    public static MyArray operator +(MyArray array1, MyArray array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length for addition.");
        }
        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }
        return new MyArray(result);
    }

    public int Length => elements.Length;
}
