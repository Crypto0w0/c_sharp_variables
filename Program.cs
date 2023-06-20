internal class Program
{
    private static void Main(string[] args)
    {
        #region Middle
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine((num1 + num2 + num3) / 3);
        #endregion
 
        #region Pow
        int num = Convert.ToInt32(Console.ReadLine());
        int pov = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(num, pov));
        #endregion

        #region CurrencyConvert
        double grivna = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Euro: " + Math.Round(grivna * 39));
        Console.WriteLine("Dollar: " + Math.Round(grivna * 36));
        #endregion

        #region KMtoMILE
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sea Mile: " + Math.Round(km / 1.852));
        Console.WriteLine("Land Mile: " + Math.Round(km / 1.609));
        #endregion
 
        #region Percent
        double N = Convert.ToDouble(Console.ReadLine());
        double P = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(N / 100 * P);
        #endregion

        #region CelciumToFarenheit
        int Celsium = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Round(Celsium * 1.8));
        int Farenheit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Round(Farenheit / 1.8));
        #endregion
    }
}