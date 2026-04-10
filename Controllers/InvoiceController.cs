
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using InvoiceApp.Models;

namespace InvoiceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvoiceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = _context.InvoiceItems.ToList();
            if (items.Any())
            {
                return Ok(new { items = items.Select(i => new { name = i.Name, price = i.Price }) });
            }
            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
        }
    }
}
