using System.Globalization;
using CsvHelper;
using System.Xml.Linq;

namespace AC3
{
    public static class Helper
    {

        // Crea una llista d'objectes consumAigua des de l'arxiu CSV
        public static List<ConsumAigua> GetCSV(string path)
        {

            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<ConsumAigua>().ToList();
                    return records;
                }
            }
        }

        // Agafa els objectes del csv i converteix a xml el codi comarca y comarca
        public static void ConvertToXML(List<ConsumAigua> consumAigua)
        {
            var xml = new XElement("Comarques",
                from consum in consumAigua
                select new XElement("Comarca",
                new XElement("CodiComarca", consum.CodiComarca),
                new XElement("Comarca", consum.Comarca)));

            xml.Save("../../../comarques.xml");
        }

        // Retorna el màxim consum per càpita
        public static float GetMaxConsum(List<ConsumAigua> consumAigua)
        {
            return consumAigua.Max(c => c.ConsDomPerCapita);
        }

        // Retorna el mínim consum per càpita
        public static float GetMinConsum(List<ConsumAigua> consumAigua)
        {
            return consumAigua.Min(c => c.ConsDomPerCapita);
        }

        // Retorna el codi de comarca depenent del nom
        public static int GetCodiComarca(List<ConsumAigua> consumAigua, string comarca)
        {
            return consumAigua.Where(c => c.Comarca == comarca).Select(c => c.CodiComarca).FirstOrDefault();
        }

        // Afegeix el consum al csv
        public static void AddToCsv(string path, ConsumAigua consum)
        {
            using (var writer = new StreamWriter(path, append: true))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord(consum);
                    csv.NextRecord();
                }
            }
        }
    }
}
