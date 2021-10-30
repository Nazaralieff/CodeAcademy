using System;

namespace VolumeOfBox
{
    class Program
    {
        static void Main(string[] args)
        {

            Volume vol = new Volume()
            {
                width = 2,
                lenhtg = 3,
                height = 4
            };
            static void VolumeOfBox(Volume obj)
            {
                Console.WriteLine(obj.width * obj.height * obj.lenhtg);
            }

            VolumeOfBox(vol);
        }

    }
        class Volume
    {
        public int width;
        public int lenhtg;
        public int height;
    }
}
