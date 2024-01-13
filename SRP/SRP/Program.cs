using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
    }

    class OrderItem
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
    }

    class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Logic to process the order
            Console.WriteLine($"Processing order #{order.Id} with {order.Items.Count} items.");
        }
    }

    class InvoicePrinter
    {
        public void PrintInvoice(Order order)
        {
            // Logic to print the invoice
            Console.WriteLine($"Printing invoice for order #{order.Id}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Id = 1, Items = new List<OrderItem> { new OrderItem { Product = "Widget", Quantity = 2 } } };

            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder(order);

            InvoicePrinter invoicePrinter = new InvoicePrinter();
            invoicePrinter.PrintInvoice(order);

            Console.WriteLine("Order processing and invoice printing completed.");

            Console.ReadLine();
        }
    }
}
