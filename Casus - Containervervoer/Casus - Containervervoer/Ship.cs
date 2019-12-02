using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Containervervoer
{
    public class Ship
    {
        public int Lenght { get; set; }
        public int Width { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }

        public Ship(int lenght, int width)
        {
            Lenght = lenght;
            Width = width;
            MaxWeight = CalculateMaxWeight(lenght, width);
            MinWeight = CalculateMinWeight(lenght, width);

        }

        private int CalculateMaxWeight(int length, int width)
        {
            int result = length * width;
            result = result * 150;
            return result;
        }

        private int CalculateMinWeight(int length, int width)
        {
            int result = length * width;
            result = result * 150;
            result = result / 2;
            return result;
        }

    }
    
    
}
