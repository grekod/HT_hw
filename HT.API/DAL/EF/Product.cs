namespace HT.API.DAL.EF
{
    public class Product
    {
        public int Id { get; set; }
        public string Manufacturer { get; set;}
        public string Type { get; set;}
        public string ImgURL { get; set;}
        public int PurchasePrice { get; set;}
        public int SellingPrice { get; set;}
        public bool Archived { get; set; } = false;
    }
}