using System;
using System.Collections.Generic;
using System.IO;

public class CsvHelper
{
    // This method writes a list of transactions to a CSV file.
    public static void SaveToCsv(List<Transaction> transactions, string filePath)
    {
        try
        {
            // Open or create the file to save data
            using (var writer = new StreamWriter(filePath, false))
            {
                // Write the header
                writer.WriteLine("Date,Description,Amount,Category");

                // Write each transaction data
                foreach (var transaction in transactions)
                {
                    writer.WriteLine($"{transaction.Date},{transaction.Description},{transaction.Amount},{transaction.Category}");
                }
            }
            Console.WriteLine("Data has been saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

// Example of Transaction class (you may adjust this based on your existing class)
public abstract class Transaction
{
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }

    public abstract bool IsIncome { get; }

    public Transaction(DateTime date, string description, decimal amount, string category)
    {
        Date = date;
        Description = description;
        Amount = amount;
        Category = category;
    }
}
