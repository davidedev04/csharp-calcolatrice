namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SommaNumInt somma = new SommaNumInt(3, 6);

            SommaNumDouble somma2 = new SommaNumDouble(6.5, 7.3);

            xNumInt somma3 = new xNumInt(2, 20);

            xNumDouble somma4 = new xNumDouble(6.4, 20.7);

            MinNumInt somma5 = new MinNumInt(89, 34);

            MinNumDouble somma6 = new MinNumDouble(46.8, 78.4);

            MaxNumInt somma7 = new MaxNumInt(231, 456);

            MaxNumDouble somma8 = new MaxNumDouble(874.6, 346.3);
        }
    }
}
