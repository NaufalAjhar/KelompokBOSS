using Payment_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Payment_Main.Controller
{
    public class PaymentController
    {
        private List<Payment> payments;

        public PaymentController()
        {
            payments = ReadJsonFile("C:\\Users\\Haikal\\OneDrive\\Documents\\Konstruksi Perangkat Lunak\\Payment\\Payment-API\\Data\\dataPayment.json");
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

                daftarHistoryPayment = JsonSerializer.Deserialize<List<Payment>>(json);
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
            for (int i = 0; i < payments.Count; i++)
            {
                if (payments[i].ID_User.Equals(ID_User))
                {
                    historyByIDUser.Add(payments[i]);
                }
            }
            return historyByIDUser;
        }


    }
}

