using CompressionStocking.Devices.Compression;
using CompressionStocking.Mechanisms.Compression;
using CompressionStockingApplication;

namespace CompressionStockingApplication
{
    public interface IStockingFactory
    {
        public ICompressionMechanism CreateCompressionMechanism();
    }

    public class AirStockingFactory : IStockingFactory
    {
        public ICompressionMechanism CreateCompressionMechanism()
        {
            return new AirCompressionMechanism(new Pump(), 5000, 2000);
        }
    }

    public class LaceStockingFactory : IStockingFactory
    {
        public ICompressionMechanism CreateCompressionMechanism()
        {
            return new LaceCompressionMechanism(40, 100, new LaceTighteningDevice());
        }
    }
}

