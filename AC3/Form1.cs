using System.Xml.Linq;
using CsvHelper.Configuration.Attributes;

namespace AC3
{
    public partial class Form1 : Form
    {

        const int MaxPoblation = 20000, Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Seven = 7;

        const string CsvPath = "../../../consum.csv", XmlPath = "../../../comarques.xml", Yes = "Si", No = "No";

        const string ErrMsgPob = "Població no vàlida (buida o no correspon amb el tipus de dada)";
        const string ErrMsgDomXarx = "Domèstic xarxa no vàlid (buit o no correspon amb el tipus de dada)";
        const string ErrMsgActEcon = "Activitats econòmiques i fonts pròpies no vàlid (buit o no correspon amb el tipus de dada)";
        const string ErrMsgConsDomPerCap = "Consum domèstic per càpita no vàlid (buit o no correspon amb el tipus de dada)";
        const string ErrMsgTotal = "Total no vàlid (buit o no correspon amb el tipus de dada)";
        const string ErrMsgYear = "Any no seleccionat";
        const string ErrMsgComarca = "Comarca no seleccionada";
        const string InfoMsg = "Dades introduides correctament";
        

        public Form1()
        {
            InitializeComponent();
        }

        // S'executa al carregar el formulari
        private void Form1_Load(object sender, EventArgs e)
        {

            // S'obtenen les dades de la base de dades

            ConsumDAO consumDAO = new ConsumDAO(NpgsqlUtils.OpenConnection());
            List<ConsumAigua> consumAigua = consumDAO.GetAllConsums();
            
            // Es guarden les comarques en un fitxer xml
            Helper.ConvertToXML(consumAigua);

            // S'amplien les dades del datagridview amb consumAigua

            foreach (var item in consumAigua)
            {
                dataGridView1.Rows.Add(item.Any, item.CodiComarca, item.Comarca, item.Poblacio, item.DomXarxa, item.ActEcon, item.Total, item.ConsDomPerCapita);
            }

            // S'actualitza el combobox de comarques mitjançant el XML amb linq
            XDocument doc = XDocument.Load(XmlPath);

            var comarcas = doc.Descendants("Comarca")
                  .Select(c => new
                  {
                      CodiComarca = c.Element("CodiComarca")?.Value,
                      Comarca = c.Element("Comarca")?.Value
                  })
                  .Where(c => c.CodiComarca != null && c.Comarca != null);

            foreach (var comarca in comarcas)
            {
                cmbComarca.Items.Add(comarca.Comarca);
            }

            // S'actualitzen els anys des del menor del csv fins al 2050

            for (int i = consumAigua.Min(c => c.Any); i <= 2050; i++)
            {
                cmbYear.Items.Add(i);
            }

        }

        // S'actualitzen les estadístiques
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > Zero)
            {

                //Població més gran que 20000 si o no
                float poblacio = Convert.ToInt32(dataGridView1.SelectedRows[Zero].Cells[Three].Value);

                lblPoblationGreater.Text = poblacio > MaxPoblation ? Yes : No;

                //Consum mitjà per habitant
                float domXarxa = Convert.ToInt32(dataGridView1.SelectedRows[Zero].Cells[Four].Value);
                lblConsMitj.Text = Math.Round(domXarxa / poblacio, Two).ToString();

                //Cons dom per capita major de tots si o no
                float consDomPerCapita = Convert.ToSingle(dataGridView1.SelectedRows[Zero].Cells[Seven].Value);


                ConsumDAO consumDAO = new ConsumDAO(NpgsqlUtils.OpenConnection());

                // S'actualitza el consum màxim i mínim
                float maxConsCap = Helper.GetMaxConsum(consumDAO.GetAllConsums());
                float minConsCap = Helper.GetMinConsum(consumDAO.GetAllConsums());

                lblConsCapMax.Text = consDomPerCapita == maxConsCap ? Yes : No;
                lblConsCapLow.Text = consDomPerCapita == minConsCap ? Yes : No;

            }


        }

        // Es neteja la informació
        private void ClearInfo()
        {
            txtActEcon.Clear();
            cmbYear.SelectedIndex = -One;
            cmbComarca.SelectedIndex = -One;
            txtTotal.Clear();
            txtConsDomPerCap.Clear();
            txtDomXarx.Clear();
            txtPob.Clear();
            txtTotal.Clear();
        }

        // Neteja la informació al fer click en Netejar
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        // Es comproven que els valors siguin valids i s'introdueixen al csv
        private void btnSave_Click(object sender, EventArgs e)
        {

            // Es fa amb ifs ja que si no no es mostren els errors a cada camp específicament
            if (cmbYear.SelectedIndex == -One)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, ErrMsgYear);
            }

            else if (cmbComarca.SelectedIndex == -One)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbComarca, ErrMsgComarca);
            }

            else if (txtPob.Text == "" || !int.TryParse(txtPob.Text, out int pob))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPob, ErrMsgPob);
            }

            else if (txtDomXarx.Text == "" || !int.TryParse(txtDomXarx.Text, out int domXarx))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDomXarx, ErrMsgDomXarx);
            }

            else if (txtActEcon.Text == "" || !int.TryParse(txtActEcon.Text, out int actEcon))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtActEcon, ErrMsgActEcon);
            }

            else if (txtConsDomPerCap.Text == "" || !float.TryParse(txtConsDomPerCap.Text, out float consDomPerCap))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConsDomPerCap, ErrMsgConsDomPerCap);
            }

            else if (txtTotal.Text == "" || !int.TryParse(txtTotal.Text, out int total))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotal, ErrMsgTotal);
            }
            else
            {

                errorProvider1.Clear();

                ConsumDAO consumDAO = new ConsumDAO(NpgsqlUtils.OpenConnection());

                ConsumAigua consumAigua = new ConsumAigua
                {
                    Any = Convert.ToInt32(cmbYear.Text),
                    CodiComarca = Helper.GetCodiComarca(consumDAO.GetAllConsums(), cmbComarca.Text),
                    Comarca = cmbComarca.Text,
                    Poblacio = pob,
                    DomXarxa = domXarx,
                    ActEcon = actEcon,
                    Total = total,
                    ConsDomPerCapita = consDomPerCap
                };

                consumDAO.AddConsum(consumAigua);

                Helper.AddToCsv(CsvPath, consumAigua);

                dataGridView1.Rows.Add(consumAigua.Any, consumAigua.CodiComarca, consumAigua.Comarca, consumAigua.Poblacio, consumAigua.DomXarxa, consumAigua.ActEcon, consumAigua.Total, consumAigua.ConsDomPerCapita);

                cmbYear.Items.Add(consumAigua.Any);

                MessageBox.Show(InfoMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInfo();

            }

        }

        private void lblPoblation_Click(object sender, EventArgs e)
        {

        }
    }
}
