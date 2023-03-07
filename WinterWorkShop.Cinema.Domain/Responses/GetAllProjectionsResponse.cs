namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class GetAllProjectionsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrojSale { get; set; }
        public DateTime DateTime { get; set; }
        public int MovieId { get; set; }
        public string Descripton { get; set; }
    }
}
