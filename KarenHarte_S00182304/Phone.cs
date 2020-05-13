using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarenHarte_S00182304
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(string name, int price, string operatingSystem, string osImage, string phoneImage)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = osImage;
            Phone_Image = phoneImage;

        }

        public void IncreasePrice(int percentageValue)
        {
            Price = percentageValue / 100 * Price;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
