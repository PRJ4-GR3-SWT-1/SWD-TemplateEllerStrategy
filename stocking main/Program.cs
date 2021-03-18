using System;
using System.Runtime.InteropServices.WindowsRuntime;
using CompressionStocking.BusinessLogic;
using CompressionStocking.Devices.Compression;
using CompressionStocking.Devices.UserInterface;
using CompressionStocking.Mechanisms.Compression;
using CompressionStocking.Mechanisms.UserInterface;

namespace CompressionStockingApplication
{
    public class SuperFactory
    {
        public ICompressionMechanism CreateStocking(ConsoleKey key)
        {
            if (key == ConsoleKey.A)
            {
                return new AirStockingFactory().CreateCompressionMechanism();
                
            }
            else if (key == ConsoleKey.Z)
            {

                return new LaceStockingFactory().CreateCompressionMechanism();

            }
            else return null;
        }
    }

    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Compression Stocking Configuration");
            Console.WriteLine("A:   Air compression mechanism");
            Console.WriteLine("Z:   Laces compresison mechanism");
            Console.WriteLine("ESC: Terminate application");
            var configOk = false;

            // Read user input and create the applicable compression mechanism
            ICompressionMechanism compressionMechanism = null;  // Will be initiated below according to user's choice
            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character

                compressionMechanism = new SuperFactory().CreateStocking(consoleKeyInfo.Key);

                configOk = true;
                if (consoleKeyInfo.Key == ConsoleKey.Escape)
                    return;

            } while (compressionMechanism==null);

            // Create the Stocking Controller using the factory corresponding to user's choice
            IUserOutput userOutput = new UserOutput(new LED(), new LED(), new Vibrator());
            StockingCtrl stockingCtrl = new StockingCtrl(compressionMechanism, userOutput);
            compressionMechanism.CompressionEventListener = stockingCtrl;   // Set up call-back receiver


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A) stockingCtrl.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z) stockingCtrl.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
