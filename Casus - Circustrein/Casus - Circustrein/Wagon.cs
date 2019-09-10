using System.Collections.Generic;

namespace Casus___Circustrein
{
    class Wagon
    {
        public static int size = 0;
        public static List<Wagon> list = new List<Wagon>();
        public int Diet { get; set; }
        public int Size { get; set; }

        

        public int AddAnimalToWagon(int size, int diet)
        {
            if (Wagon.size >= 10)
            {
                Wagon.size = 0;
            }
            else
            {
                if (diet == 0)
                {
                    if (size == 5)
                    {
                        Wagon.size++;
                    }
                    else if (size == 3)
                    {

                    }
                }
            }

            return 1;
        }

        private void CheckIfWagonIsFull()
        {

        }
    }
}
