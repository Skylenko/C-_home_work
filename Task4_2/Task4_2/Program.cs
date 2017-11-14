namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArifmeticProgresion arifm = new ArifmeticProgresion(2, 4);
            double rez = arifm.SumOfFirstArguments();
            double rez2 = arifm.AverageOfArifmeticProgress();
        }
    }
}