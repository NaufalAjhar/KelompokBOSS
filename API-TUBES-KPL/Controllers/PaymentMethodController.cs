using API_TUBES_KPL.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_TUBES_KPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : Controller
    {
        private static List<PaymentMethod> DataPayment = new List<PaymentMethod>();
        public PaymentMethodController() {
            string jsonFilePath = "C:\\Users\\Haikal\\OneDrive\\Documents\\Konstruksi Perangkat Lunak\\API-TUBES-KPL\\API-TUBES-KPL\\Data\\DataPaymentMethod.JSON";
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            DataPayment = JsonConvert.DeserializeObject<List<PaymentMethod>>(jsonData);
        }

        [HttpGet]
        public IEnumerable<PaymentMethod> Get()
        {
            return DataPayment;
        }

    }
}
