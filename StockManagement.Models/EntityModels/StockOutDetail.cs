namespace StockManagement.Models.EntityModels
{
    public class StockOutDetail
    {
        public int Id { get; set; }

        public int StockOutId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }


        public StockOut StockOut { get; set; }

        public Product Product { get; set; }


    }
}