namespace HT.API.DAL.EF
{
    public enum Foglalat
    {
        DDR3,
        DDR4,
    }
    public class Memory : Product
    {
        public Foglalat Socket { get; set; }
        public int MemorySize { get; set; }
        public int Size { get; set; }
        public int Latency { get; set; }
    }
}