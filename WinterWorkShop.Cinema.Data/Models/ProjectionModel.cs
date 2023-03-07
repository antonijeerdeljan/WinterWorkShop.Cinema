namespace WinterWorkShop.Cinema.Data.Models
{
    public class ProjectionModel
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrojSale { get; set; }
        public DateTime DateTime { get; set; }
    
    }
}
