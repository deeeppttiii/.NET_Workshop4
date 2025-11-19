public class Parameter
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Deepti Dhungana";  
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
