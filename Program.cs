using dio_net_nuget.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda venda1 = new Venda(1, "Notebook", 3500.00m, dataAtual);
listaVendas.Add(venda1);

Venda venda2 = new Venda(2, "Smartphone", 2500.00m, dataAtual);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // não é obrigatório o Formatting.Indented
File.WriteAllText("Arquivos/venda.json", serializado);
