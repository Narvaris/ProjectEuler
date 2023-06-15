public class Problem2{

    private List<int> FibonacciSeries {get;}
    public Problem2(){
        FibonacciSeries = new List<int>(new int[] {1,2});
        int Sum = 2;
        int MaxValue = 4000000;
        while(FibonacciSeries.Last() < MaxValue){
            int newEntry = GenerateFibonacci();
            FibonacciSeries.Add(newEntry);
            if (newEntry < MaxValue && newEntry % 2 == 0){
                Sum += newEntry;
            }
        }
        Console.WriteLine($"SUM:{Sum}");
    }

    public int GenerateFibonacci(){
        int lastIndex = FibonacciSeries.Count - 1;
        return FibonacciSeries[lastIndex] + FibonacciSeries[lastIndex - 1];
    }
}