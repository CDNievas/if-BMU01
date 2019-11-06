using System;

namespace BMU01
{
    class Program
    {
        static void Main(string[] args)
        {

            int port = 3;
            int baud = 14400;

            Device dev = BMU.connect(port, baud);
            dev.beep(1);

            Console.ReadLine();

        }
    
    }
}
