using System;
using CsvHelper.Configuration.Attributes;

namespace AC3
{
    public class ConsumAigua
    {

        public int Any { get; set; }

        [Name("Codi comarca")]
        public int CodiComarca { get; set; }
        [Name("Comarca")]
        public string? Comarca { get; set; }
        [Name("Població")]
        public int Poblacio { get; set; }
        [Name("Domèstic xarxa")]
        public int DomXarxa { get; set; }
        [Name("Activitats econòmiques i fonts pròpies")]
        public int ActEcon { get; set; }
        [Name("Total")]
        public int Total { get; set; }
        [Name("Consum domèstic per càpita")]
        public float ConsDomPerCapita { get; set; }

    }
}
