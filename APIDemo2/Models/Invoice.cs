using APIDemo2.Controllers;

namespace APIDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public string Customer { get; set; }
        public List<Detail>? Details { get; set; }
    }
}
