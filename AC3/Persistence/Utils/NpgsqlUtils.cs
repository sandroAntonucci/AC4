using Microsoft.Extensions.Configuration;
using Npgsql;

namespace AC3
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json")
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static ConsumAigua GetConsum(NpgsqlDataReader reader)
        {
            ConsumAigua c = new ConsumAigua
            {
                Id = reader.GetInt32(0),
                Any = reader.GetInt32(1),
                CodiComarca = reader.GetInt32(2),
                Comarca = reader.GetString(3),
                Poblacio = reader.GetInt32(4),
                DomXarxa = reader.GetInt32(5),
                ActEcon = reader.GetInt32(6),
                Total = reader.GetInt32(7),
                ConsDomPerCapita = reader.GetFloat(8) 
            };
            return c;
        }

    }
}
