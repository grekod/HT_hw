namespace HT.API.DAL.EF
{
    public enum CpuFoglalat
    {
        AM3,
        AM4,
        FM2,
        LGA1050,
        LGA1051,
    }
    public enum RamFoglalat
    {
        DDR3,
        DDR4,
    }
    public enum Meret
    {
        mITX,
        mATX,
        ATX,
        eATX,
    }
    public class MotherBoard : Product
    {
        public CpuFoglalat CpuSocket { get; set; }
        public RamFoglalat RamSocket { get; set; }
        public int UsbNumber { get; set; }
        public bool WiFi { get; set; }
        public Meret Size { get; set; }
    }
}