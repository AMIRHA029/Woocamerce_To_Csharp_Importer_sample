using Newtonsoft.Json;
using static Importer.Models.WoocammerceProduct;

string Response = System.IO.File.ReadAllText("Recources\\response.json");

var products = JsonConvert.DeserializeObject<List<Root>>(Response);

products[0].Images[0].DownloadImage(Directory.GetCurrentDirectory() + "\\Recources\\");

Console.WriteLine(products.Count);

Console.ReadKey();