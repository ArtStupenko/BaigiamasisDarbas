using System;

namespace Baigiamasis_Darbas
{
    internal class Program
    {
        static void Main(string[] args)
    {
            Pasirinkimai pasirinkimai = new Pasirinkimai();
            while (true)
            {
                pasirinkimai.SukurtiMenu();
            }
        }
    }
}
