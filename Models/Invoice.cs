using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public ICollection<InvoiceItem> Items { get; set; }
    }
}