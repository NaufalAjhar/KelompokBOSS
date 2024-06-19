using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAPP.Payment
{
    public class PaymentController
    {
        private List<Payment> payments;

        public PaymentController()
        {
            payments = ReadJsonFile("D:\\1.Programming\\Payment\\Payment\\Payment-API\\Data\\dataPayment.json");
        }

        private List<Payment> ReadJsonFile(string filePath)
        {
            List<Payment> daftarHistoryPayment = new List<Payment>();
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                daftarHistoryPayment = JsonConvert.DeserializeObject<List<Payment>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON file: " + ex.Message);
            }
            return daftarHistoryPayment;
        }

        public List<Payment> GetAllPayments()
        {
            return payments;
        }

        public List<Payment> GetPaymentByIDUser(int ID_User)
        {
            List<Payment> historyByIDUser = new List<Payment>();
            foreach (var payment in payments)
            {
                if (payment.ID_User.Equals(ID_User))
                {
                    historyByIDUser.Add(payment);
                }
            }
            return historyByIDUser;
        }
    }
}
