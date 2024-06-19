using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Payment_API.Model;
using System.Xml;

namespace Payment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private static List<Payment> DataPayment = new List<Payment>();
        public PaymentController()
        {
            string jsonFilePath = "D:\\1.Programming\\Payment\\Payment\\Payment-API\\Data\\dataPayment.json";
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            DataPayment = JsonConvert.DeserializeObject<List<Payment>>(jsonData);
        }

        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            return DataPayment;
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Payment dataPayment)
        {
            try
            {
                if (dataPayment == null || string.IsNullOrEmpty(dataPayment.Nama_Pembeli))
                {
                    return BadRequest("Error: Data is not valid");
                }

                DataPayment.Add(dataPayment);
                SaveJson();

                return Ok(new { Message = "Data added successfully", DataPayment = dataPayment });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding an data: {ex}");
                return StatusCode(500, "An error occurred while adding an data.");
            }
        }

        // GET Payment By ID User 
        [HttpGet("{ID_User}")]
        public List<Payment> GETPaymentByIDUser(int ID_User)
        {
            List<Payment> dataPaymentByIDUser = new List<Payment>();
            for (int i = 0; i < DataPayment.Count; i++)
            {
                if (DataPayment[i].ID_User == ID_User)
                {
                    dataPaymentByIDUser.Add(DataPayment[i]);
                }
            }
            return dataPaymentByIDUser;
        }

        private void SaveJson()
        {
            try
            {
                string jsonFilePath = "D:\\1.Programming\\Payment\\Payment\\Payment-API\\Data\\dataPayment.json";
                string jsonData = JsonConvert.SerializeObject(DataPayment, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving data to JSON: {ex}");
            }
        }
    }
}

