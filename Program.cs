using RestSharp;

var cep = 15370496; //CEP Avenida Paulista
var client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
var response = await client.ExecuteGetAsync(new RestRequest());
Console.WriteLine(response.Content);