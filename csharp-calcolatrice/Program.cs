namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SommaNumInt somma = new SommaNumInt(3, 6);

            SommaNumDouble somma2 = new SommaNumDouble(6.5, 7.3);

            DiffNumInt somma3 = new DiffNumInt(89, 100);

            DiffNumDouble somma4 = new DiffNumDouble(56.3, 90.7);

            xNumInt somma5 = new xNumInt(2, 20);

            xNumDouble somma6 = new xNumDouble(6.4, 20.7);

            AbsoluteNumInt somma7 = new AbsoluteNumInt(-78);

            AbsoluteNumDouble somma8 = new AbsoluteNumDouble(-45.7);

            MinNumInt somma9 = new MinNumInt(89, 34);

            MinNumDouble somma10 = new MinNumDouble(46.8, 78.4);

            MaxNumInt somma11 = new MaxNumInt(231, 456);

            MaxNumDouble somma12 = new MaxNumDouble(874.6, 346.3);
        }
    }
}
