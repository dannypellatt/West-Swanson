using Newtonsoft.Json.Linq;

var client = new HttpClient();
var kanyeURL = "https://api.kanye.rest";



var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";



for (int i = 0; i < 5; i++)
{


    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

    Console.WriteLine($"Kanye: \"{ kanyeQuote}\"");
    Console.WriteLine();

    var ronResponse = client.GetStringAsync(ronURL).Result;
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

    Console.WriteLine("Ron: " + ronQuote);
    Console.WriteLine();
}


//Console.WriteLine(kanyeQuote);

