using System;
using QuickMartPOS;

class Program
{
    static void Main()
    {

        var milk = new Product("Milk", 60.00m, VatCategory.ZeroRated);
        var tv = new Product("TV", 35000.00m, VatCategory.Standard);
        var mask = new Product("Medical Mask", 20.00m, VatCategory.Exempt);

        
        var receipt = new Receipt();

        // Add items to the receipt
        receipt.AddItem(new SaleItem(tv, 1));
        receipt.AddItem(new SaleItem(milk, 2));
        receipt.AddItem(new SaleItem(mask, 5));

        // Print the receipt to console
        receipt.PrintReceipt();
    }
}