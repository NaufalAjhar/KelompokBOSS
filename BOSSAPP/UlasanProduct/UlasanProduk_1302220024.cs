using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    // Generic class untuk merepresentasikan ulasan produk
    public class ProductReview<T>
    {
        private T reviewData;

        public ProductReview(T data)
        {
            this.reviewData = data;
        }

        public T ReviewData
        {
            get { return reviewData; }
            set { reviewData = value; }
        }
    }

    // Automata untuk mengecek konten ulasan
    public class ReviewAutomata
    {
        public static bool CheckReviewContent(string review)
        {
            // Implementasi automata untuk mengecek konten ulasan
            // Di sini kita akan melakukan pengecekan sederhana
            return review.Length >= 10; // Contoh: minimal 10 karakter
        }
    }

    public class ProductReviewAnalyzer<T>
    {
        private T reviewText;

        public ProductReviewAnalyzer(T reviewText)
        {
            this.reviewText = reviewText;
        }

        public string AnalyzeSentiment()
        {
            // Implementasi automata untuk analisis sentimen
            // Disini bisa menambahkan logika untuk menentukan sentimen berdasarkan teks ulasan
            // Contoh sederhana: Jika ulasan mengandung kata "bagus", maka sentimen adalah positif

            string[] positiveWords = { "bagus", "baik", "rapi", "aman" };
            string[] negativeWords = { "rusak", "jelek", "tidak sesuai", "kecewa" };

            foreach (string word in positiveWords)
            {
                if (reviewText.ToString().ToLower().Contains(word))
                {
                    return "Positif";
                }
            }

            foreach (string word in negativeWords)
            {
                if (reviewText.ToString().ToLower().Contains(word))
                {
                    return "Negatif";
                }
            }

            return "Netral";
        }
    }
}
