using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApp.Models
{
    public class InvoiceItem
    {
        [Key]
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; }
    }
}