using dio_net_nuget.Models;
using Newtonsoft.Json;

Venda venda1 = new Venda(1, "Notebook", 3500.00m);

string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);

File.WriteAllText("Arquivos/venda.json", serializado);

//Console.WriteLine(serializado);