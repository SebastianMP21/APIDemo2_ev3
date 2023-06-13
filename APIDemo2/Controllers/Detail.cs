using APIDemo2.Models;

namespace APIDemo2.Controllers
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        public int InvoiceID { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
