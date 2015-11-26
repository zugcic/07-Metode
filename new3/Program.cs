using System;

namespace new3
{
    class Bazna
    {
        public void NapisiMe()
        {
            Console.WriteLine("Bazna klasa");
            IspisiMiClanove();
        }

        protected virtual void IspisiMiClanove()
        {
            Console.WriteLine("Isključivo članovi Bazna su:");
        }

    }
    class Izvedena : Bazna
    {
        public new void NapisiMe()
        {
            Console.Write("Izvedena klasa, izvedena iz: ");
            base.NapisiMe();
        }

        new protected virtual void IspisiMiClanove()
        {
            Console.WriteLine("Isključivo članovi Izvedena su:");
        }

        /*
        protected override void IspisiMiClanove()
        {
            Console.WriteLine("Isključivo članovi Izvedena su:");
        }
         */

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bazna b = new Bazna();
            b.NapisiMe();
            b = new Izvedena();
            b.NapisiMe();
            Izvedena i = new Izvedena();
            i.NapisiMe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
