using CartAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class itemCartController : Controller
    {
        private static List<itemCart> item = new List<itemCart>();
        private static readonly HttpClient client = new HttpClient();
        public itemCartController()
        {
            client.BaseAddress = new Uri("http://localhost:5230/");
            string jsonFilePath = "D:\\1.Programming\\BOSSAPP\\CartAPI\\Data\\itemCart.json";
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            item = JsonConvert.DeserializeObject<List<itemCart>>(jsonData);
        }

        [HttpGet]
        public IEnumerable<itemCart> Get(int userId)
        {
            // Retrieve cart items for the specified userId
            var userCartItems = item.Where(c => c.userId == userId).ToList();
            return userCartItems;
        }

        [HttpPost] 
        public async Task<IActionResult> Post([FromBody] itemCart newItem)
        {
            try
            {
                if (newItem == null || string.IsNullOrEmpty(newItem.Name) || newItem.qty <= 0)
                {
                    return BadRequest("Error: Invalid item data.");
                }

                item.Add(newItem);
                SaveCartToJson();

                return Ok(new { Message = "Item added to cart successfully!", Item = newItem });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding an item to the cart: {ex}");
                return StatusCode(500, "An error occurred while adding an item to the cart.");
            }
        }

        [HttpDelete("{userId}/{id}")]
        public IActionResult Delete(int userId, int id)
        {
            try
            {
                var itemToRemove = item.FirstOrDefault(i => i.Id == id && i.userId == userId);
                if (itemToRemove == null)
                {
                    return NotFound($"Item with ID {id} for User ID {userId} not found in the cart.");
                }

                item.Remove(itemToRemove);
                SaveCartToJson();

                return Ok($"Item with ID {id} for User ID {userId} removed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting an item from the cart: {ex}");
                return StatusCode(500, "An error occurred while deleting an item from the cart.");
            }
        }

        [HttpDelete("{userId}")]
        public IActionResult DeleteByUserId(int userId)
        {
            try
            {
                var itemsToRemove = item.Where(i => i.userId == userId).ToList();
                foreach (var itemToRemove in itemsToRemove)
                {
                    item.Remove(itemToRemove);
                }

                SaveCartToJson();

                return Ok($"All items for user with ID {userId} removed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting items for user with ID {userId} from the cart: {ex}");
                return StatusCode(500, $"An error occurred while deleting items for user with ID {userId} from the cart.");
            }
        }

        private void SaveCartToJson()
        {
            try
            {
                string jsonFilePath = "D:\\1.Programming\\BOSSAPP\\CartAPI\\Data\\itemCart.json";
                string jsonData = JsonConvert.SerializeObject(item, Formatting.Indented);
                System.IO.File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving cart items to JSON: {ex}");
            }
        }

    }
}
