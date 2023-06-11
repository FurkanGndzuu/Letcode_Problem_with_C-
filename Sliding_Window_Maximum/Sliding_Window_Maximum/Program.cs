using Sliding_Window_Maximum;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] asa = { 1, 3, -1, -3, 5, 3, 6, 7 };
        new Solution().MaxSlidingWindow(asa, 3);
    }
}