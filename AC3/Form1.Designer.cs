namespace AC3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblYear = new Label();
            lblRegion = new Label();
            lblPoblation = new Label();
            lblDomXarx = new Label();
            lblActEco = new Label();
            lblCons = new Label();
            lblTotal = new Label();
            cmbYear = new ComboBox();
            cmbComarca = new ComboBox();
            txtPob = new TextBox();
            txtConsDomPerCap = new TextBox();
            txtTotal = new TextBox();
            txtDomXarx = new TextBox();
            txtActEcon = new TextBox();
            lblPobGreater = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblConsCapLow = new Label();
            lblConsCapMax = new Label();
            lblConsMitj = new Label();
            lblPoblationGreater = new Label();
            btnClear = new Button();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            Any = new DataGridViewTextBoxColumn();
            CodiComarca = new DataGridViewTextBoxColumn();
            Comarca = new DataGridViewTextBoxColumn();
            Poblacio = new DataGridViewTextBoxColumn();
            DomXar = new DataGridViewTextBoxColumn();
            ActEcon = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ConsDomPerCap = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(20, 62);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(28, 15);
            lblYear.TabIndex = 1;
            lblYear.Text = "Any";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblRegion.Location = new Point(160, 58);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(58, 15);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Comarca";
            // 
            // lblPoblation
            // 
            lblPoblation.AutoSize = true;
            lblPoblation.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblPoblation.Location = new Point(352, 58);
            lblPoblation.Name = "lblPoblation";
            lblPoblation.Size = new Size(55, 15);
            lblPoblation.TabIndex = 3;
            lblPoblation.Text = "Població";
            lblPoblation.Click += lblPoblation_Click;
            // 
            // lblDomXarx
            // 
            lblDomXarx.AutoSize = true;
            lblDomXarx.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblDomXarx.Location = new Point(20, 176);
            lblDomXarx.Name = "lblDomXarx";
            lblDomXarx.Size = new Size(96, 15);
            lblDomXarx.TabIndex = 4;
            lblDomXarx.Text = "Domèstic xarxa";
            // 
            // lblActEco
            // 
            lblActEco.AutoSize = true;
            lblActEco.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblActEco.Location = new Point(160, 163);
            lblActEco.MaximumSize = new Size(160, 0);
            lblActEco.Name = "lblActEco";
            lblActEco.Size = new Size(152, 30);
            lblActEco.TabIndex = 5;
            lblActEco.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // lblCons
            // 
            lblCons.AutoSize = true;
            lblCons.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblCons.Location = new Point(352, 163);
            lblCons.MaximumSize = new Size(130, 0);
            lblCons.Name = "lblCons";
            lblCons.Size = new Size(114, 30);
            lblCons.TabIndex = 6;
            lblCons.Text = "Consum domèstic per càpita";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(512, 176);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(20, 91);
            cmbYear.MaximumSize = new Size(80, 0);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(80, 33);
            cmbYear.TabIndex = 8;
            // 
            // cmbComarca
            // 
            cmbComarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComarca.FormattingEnabled = true;
            cmbComarca.Location = new Point(160, 91);
            cmbComarca.Name = "cmbComarca";
            cmbComarca.Size = new Size(145, 33);
            cmbComarca.TabIndex = 9;
            // 
            // txtPob
            // 
            txtPob.Location = new Point(352, 91);
            txtPob.Name = "txtPob";
            txtPob.Size = new Size(124, 32);
            txtPob.TabIndex = 10;
            // 
            // txtConsDomPerCap
            // 
            txtConsDomPerCap.Location = new Point(352, 217);
            txtConsDomPerCap.Name = "txtConsDomPerCap";
            txtConsDomPerCap.Size = new Size(124, 32);
            txtConsDomPerCap.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(512, 217);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(124, 32);
            txtTotal.TabIndex = 12;
            // 
            // txtDomXarx
            // 
            txtDomXarx.Location = new Point(20, 217);
            txtDomXarx.Name = "txtDomXarx";
            txtDomXarx.Size = new Size(124, 32);
            txtDomXarx.TabIndex = 13;
            // 
            // txtActEcon
            // 
            txtActEcon.Location = new Point(160, 217);
            txtActEcon.Name = "txtActEcon";
            txtActEcon.Size = new Size(145, 32);
            txtActEcon.TabIndex = 14;
            // 
            // lblPobGreater
            // 
            lblPobGreater.AutoSize = true;
            lblPobGreater.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            lblPobGreater.Location = new Point(16, 49);
            lblPobGreater.Name = "lblPobGreater";
            lblPobGreater.Size = new Size(139, 15);
            lblPobGreater.TabIndex = 16;
            lblPobGreater.Text = "Població > 20000 hab.:";
            lblPobGreater.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 97);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 17;
            label2.Text = "Consum domèstic mitjà:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            label3.Location = new Point(16, 142);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 18;
            label3.Text = "Consum domèstic per càpita més alt:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 186);
            label4.Name = "label4";
            label4.Size = new Size(237, 15);
            label4.TabIndex = 19;
            label4.Text = "Consum doméstic per càpita més baix: ";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(lblPoblation);
            groupBox1.Controls.Add(lblDomXarx);
            groupBox1.Controls.Add(lblActEco);
            groupBox1.Controls.Add(lblCons);
            groupBox1.Controls.Add(txtActEcon);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(txtDomXarx);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(cmbComarca);
            groupBox1.Controls.Add(txtConsDomPerCap);
            groupBox1.Controls.Add(txtPob);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 299);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblConsCapLow);
            groupBox2.Controls.Add(lblConsCapMax);
            groupBox2.Controls.Add(lblConsMitj);
            groupBox2.Controls.Add(lblPoblationGreater);
            groupBox2.Controls.Add(lblPobGreater);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(681, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 234);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // lblConsCapLow
            // 
            lblConsCapLow.AutoSize = true;
            lblConsCapLow.Location = new Point(266, 178);
            lblConsCapLow.Name = "lblConsCapLow";
            lblConsCapLow.Size = new Size(0, 25);
            lblConsCapLow.TabIndex = 23;
            // 
            // lblConsCapMax
            // 
            lblConsCapMax.AutoSize = true;
            lblConsCapMax.Location = new Point(260, 134);
            lblConsCapMax.Name = "lblConsCapMax";
            lblConsCapMax.Size = new Size(0, 25);
            lblConsCapMax.TabIndex = 22;
            // 
            // lblConsMitj
            // 
            lblConsMitj.AutoSize = true;
            lblConsMitj.Location = new Point(180, 91);
            lblConsMitj.Name = "lblConsMitj";
            lblConsMitj.Size = new Size(0, 25);
            lblConsMitj.TabIndex = 21;
            // 
            // lblPoblationGreater
            // 
            lblPoblationGreater.AutoSize = true;
            lblPoblationGreater.Location = new Point(180, 41);
            lblPoblationGreater.Name = "lblPoblationGreater";
            lblPoblationGreater.Size = new Size(0, 25);
            lblPoblationGreater.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(681, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 59);
            btnClear.TabIndex = 22;
            btnClear.Text = "Netejar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(851, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 59);
            btnSave.TabIndex = 23;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Any, CodiComarca, Comarca, Poblacio, DomXar, ActEcon, Total, ConsDomPerCap });
            dataGridView1.Location = new Point(12, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(1004, 127);
            dataGridView1.TabIndex = 24;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Any
            // 
            Any.HeaderText = "Any";
            Any.Name = "Any";
            Any.Width = 90;
            // 
            // CodiComarca
            // 
            CodiComarca.HeaderText = "Codi Comarca";
            CodiComarca.Name = "CodiComarca";
            // 
            // Comarca
            // 
            Comarca.HeaderText = "Comarca";
            Comarca.Name = "Comarca";
            Comarca.Width = 150;
            // 
            // Poblacio
            // 
            Poblacio.HeaderText = "Població";
            Poblacio.Name = "Poblacio";
            Poblacio.Width = 150;
            // 
            // DomXar
            // 
            DomXar.HeaderText = "Domèstic Xarxa";
            DomXar.Name = "DomXar";
            // 
            // ActEcon
            // 
            ActEcon.HeaderText = "Activitats econòmiques";
            ActEcon.Name = "ActEcon";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // ConsDomPerCap
            // 
            ConsDomPerCap.HeaderText = "Consum domèstic per càpita";
            ConsDomPerCap.Name = "ConsDomPerCap";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 476);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1050, 515);
            MinimumSize = new Size(1050, 515);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblYear;
        private Label lblRegion;
        private Label lblPoblation;
        private Label lblDomXarx;
        private Label lblActEco;
        private Label lblCons;
        private Label lblTotal;
        private ComboBox cmbYear;
        private ComboBox cmbComarca;
        private TextBox txtPob;
        private TextBox txtConsDomPerCap;
        private TextBox txtTotal;
        private TextBox txtDomXarx;
        private TextBox txtActEcon;
        private Label lblPobGreater;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Label lblConsCapLow;
        private Label lblConsCapMax;
        private Label lblConsMitj;
        private Label lblPoblationGreater;
        private DataGridViewTextBoxColumn Any;
        private DataGridViewTextBoxColumn CodiComarca;
        private DataGridViewTextBoxColumn Comarca;
        private DataGridViewTextBoxColumn Poblacio;
        private DataGridViewTextBoxColumn DomXar;
        private DataGridViewTextBoxColumn ActEcon;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn ConsDomPerCap;
        private ErrorProvider errorProvider1;
    }
}
