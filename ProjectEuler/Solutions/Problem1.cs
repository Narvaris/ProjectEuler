

using System.Net.Http.Headers;

public class Problem1{

    public Problem1(){
        int num1 = 3;
        int num2 = 5;
        int MaxValue = 999;


        int lcm = GetLcm(new int[] {num1, num2});

        int sum = CalculateSumOfMultiplies(num1, MaxValue) +
                  CalculateSumOfMultiplies(num2, MaxValue) -
                  CalculateSumOfMultiplies(lcm, MaxValue);
        Console.WriteLine(sum);
    }


    private int GetLcm(int[] numbers)
    {
        return numbers.Aggregate((x, y) => x * y / Gcd(x, y));
    }
    private int Gcd(int a, int b)
    {
        if (b == 0)
            return a;
        return Gcd(b, a % b);
    }
    private int CalculateSumOfMultiplies(int Value, int MaxValue)
    {
        int m =  MaxValue / Value;
 
        int sum = m * (m + 1) / 2;
  
        return Value * sum;
    }
}