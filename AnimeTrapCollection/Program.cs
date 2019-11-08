using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeTrapCollection
{
    interface ITrap
    {
        bool ayBakla();
    }

    class Trap : ITrap
    {
        private string pangalan;
        public string Pangalan
        {
            get => pangalan;
            set => pangalan = value;
        }
        private bool bakla;

        public Trap(string pangalan, bool bakla)
        {
            this.pangalan = pangalan;
            this.bakla = bakla;
        }

        public bool ayBakla()
        {
            return this.bakla;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrap> list = new List<ITrap>();

            list.Add(new Trap("Seishiro Tsugumi", false));
            list.Add(new Trap("Astolfo", true));

            foreach (Trap item in list)
            {
                if (item.ayBakla())
                {
                    Console.WriteLine("PANGANIB " + item.Pangalan + " ay bakla!");
                }

                if(!item.ayBakla())
                {
                    Console.WriteLine(item.Pangalan);
                }
            }

            Console.ReadKey();
        }
    }
}
