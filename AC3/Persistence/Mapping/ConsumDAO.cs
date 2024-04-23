using Npgsql;

namespace AC3
{
    public class ConsumDAO : IConsumDAO
    {

        private readonly string connectionString;

        public ConsumDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ConsumAigua GetConsumById(int id)
        {
            ConsumAigua consum = null;
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM consums WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            consum = NpgsqlUtils.GetConsum(reader);
                        }
                    }
                }
            }
            return consum;
        }

        public void AddConsum(ConsumAigua consum) {             
            
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO ConsumAigua (anyo, codicomarca, comarca, poblacio, domxarxa, actecon, total, consdompercapita) VALUES (@anyo, @codicomarca, @comarca, @poblacio, @domxarxa, @actecon, @total, @consdompercapita)", conn))
                {
                    cmd.Parameters.AddWithValue("anyo", consum.Any);
                    cmd.Parameters.AddWithValue("codicomarca", consum.CodiComarca);
                    cmd.Parameters.AddWithValue("comarca", consum.Comarca);
                    cmd.Parameters.AddWithValue("poblacio", consum.Poblacio);
                    cmd.Parameters.AddWithValue("domxarxa", consum.DomXarxa);
                    cmd.Parameters.AddWithValue("actecon", consum.ActEcon);
                    cmd.Parameters.AddWithValue("total", consum.Total);
                    cmd.Parameters.AddWithValue("consdompercapita", consum.ConsDomPerCapita);
                    cmd.ExecuteNonQuery();
                }
            }
        }   

        public void UpdateConsum(ConsumAigua consum)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE ConsumAigua SET any = @any, codi_comarca = @codi_comarca, comarca = @comarca, poblacio = @poblacio, dom_xarxa = @dom_xarxa, act_econ = @act_econ, total = @total, cons_dom_per_capita = @cons_dom_per_capita WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("any", consum.Any);
                    cmd.Parameters.AddWithValue("codi_comarca", consum.CodiComarca);
                    cmd.Parameters.AddWithValue("comarca", consum.Comarca);
                    cmd.Parameters.AddWithValue("poblacio", consum.Poblacio);
                    cmd.Parameters.AddWithValue("dom_xarxa", consum.DomXarxa);
                    cmd.Parameters.AddWithValue("act_econ", consum.ActEcon);
                    cmd.Parameters.AddWithValue("total", consum.Total);
                    cmd.Parameters.AddWithValue("cons_dom_per_capita", consum.ConsDomPerCapita);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteConsum(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM consums WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ConsumAigua> GetAllConsums()
        {
            List<ConsumAigua> consums = new List<ConsumAigua>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM ConsumAigua", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            consums.Add(NpgsqlUtils.GetConsum(reader));
                        }
                    }
                }
            }
            return consums;
        }

    }
}
