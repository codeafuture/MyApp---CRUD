using Microsoft.Extensions.Logging.Abstractions;

namespace MyApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<ItemClient>? ItemClients { get; set; }

    }
}
