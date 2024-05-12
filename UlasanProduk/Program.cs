using System;
using ProductReview;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan ulasan produk:");
        string review = Console.ReadLine();

        if (ReviewAutomata.CheckReviewContent(review))
        {
            ProductReview<string> productReview = new ProductReview<string>(review);
            Console.WriteLine("Ulasan produk telah disimpan: " + productReview.ReviewData);

            // Analisis sentimen ulasan
            ProductReviewAnalyzer<string> reviewAnalyzer = new ProductReviewAnalyzer<string>(review);
            string sentiment = reviewAnalyzer.AnalyzeSentiment();
            Console.WriteLine("Sentimen: " + sentiment);
        }
        else
        {
            Console.WriteLine("Ulasan produk tidak valid.");
        }
    }
}
