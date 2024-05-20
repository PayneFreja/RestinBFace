using RestinBFace;
using RestSharp;
using System.Text.Json;
using System.IO;

int key = 1;
RestClient client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/search.php");
RestRequest request = new RestRequest("?s=margarita");
// request.AddParameter("apikey", key);
RestResponse response = client.GetAsync(request).Result;
System.Console.WriteLine(response.Content);
File.WriteAllText("recipe.json", response.Content);
Console.ReadLine();
// Cocktails c = JsonSerializer.Deserialize<Cocktails>(response.Content);
