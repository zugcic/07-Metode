using System;

namespace Metode
{
    class Bazna
    {
        public void NapisiMe()
        {
            Console.WriteLine("Bazna klasa");
        }
        /*
        protected virtual void IspisiMiClanove()
        {
            Console.WriteLine("Isključivo moji članovi su:");
        }
         */

    }
    class Izvedena : Bazna
    {
        public new void NapisiMe()
        {
            Console.WriteLine("Izvedena klasa, izvedena iz:");
            base.NapisiMe();
            IspisiMiClanove();
        }

        protected virtual void IspisiMiClanove()
        {
            Console.WriteLine("Isključivo moji članovi su:");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
