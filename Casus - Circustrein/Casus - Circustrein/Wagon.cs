using System.Collections.Generic;

namespace Casus___Circustrein
{
    class Wagon
    {
        private int wagonID = 1;
        public static int size = 0;

        List<Animal> animals = new List<Animal>();

        public int Diet { get; set; }
        public int Size { get; set; }
        public int WagonID { get; set; }

        private void AddWagon()
        {
            wagonID++;
        }
        public Wagon()
        {
            AddWagon();
            WagonID = wagonID;
        }

        public int AddAnimalToWagon(int size, int diet)
        {
            if (Wagon.size >= 10)
            {
                Wagon.size = 0;
                AddWagon();
            }
            else
            {
                if (size == 1)
                {
                    if (diet == 1)
                    {
                        Wagon.size++;
                    }
                    else
                    {
                        Wagon.size++;
                    }
                }
                else if (size == 3)
                {
                    if (diet == 1)
                    {
                        Wagon.size += 3;
                    }
                    else
                    {
                        Wagon.size += 3;
                    }
                }
                else
                {
                    if (diet == 1)
                    {
                        Wagon.size += 5;
                    }
                    else
                    {
                        Wagon.size += 5;
                    }
                }
            }

            return WagonID;
        }

        private void CheckIfWagonIsFull()
        {

        }
    }
}
