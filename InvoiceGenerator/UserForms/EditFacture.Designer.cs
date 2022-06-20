namespace InvoiceGenerator.UserForms
{
    partial class EditFacture
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvOD = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCompagnyName = new System.Windows.Forms.ComboBox();
            this.lbFax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbContactTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCodePostal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbContactName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.rdAccompte = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rdSolde = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel5Footer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdAccompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSolde)).BeginInit();
            this.panel5Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1608, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 56);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvOD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 568);
            this.panel2.TabIndex = 1;
            // 
            // dtgvOD
            // 
            this.dtgvOD.AllowUserToAddRows = false;
            this.dtgvOD.AllowUserToDeleteRows = false;
            this.dtgvOD.AllowUserToResizeColumns = false;
            this.dtgvOD.AllowUserToResizeRows = false;
            this.dtgvOD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvOD.CausesValidation = false;
            this.dtgvOD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvOD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOD.ColumnHeadersHeight = 37;
            this.dtgvOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOD.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvOD.Location = new System.Drawing.Point(0, 0);
            this.dtgvOD.Margin = new System.Windows.Forms.Padding(0);
            this.dtgvOD.MultiSelect = false;
            this.dtgvOD.Name = "dtgvOD";
            this.dtgvOD.ReadOnly = true;
            this.dtgvOD.RowHeadersVisible = false;
            this.dtgvOD.RowTemplate.Height = 35;
            this.dtgvOD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOD.ShowEditingIcon = false;
            this.dtgvOD.Size = new System.Drawing.Size(764, 568);
            this.dtgvOD.TabIndex = 24;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5Footer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1608, 888);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbCompagnyName);
            this.panel4.Controls.Add(this.lbFax);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbPhone);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbCountry);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbRegion);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbCity);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbAdresse);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbContactTitle);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lbCodePostal);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbContactName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(761, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 568);
            this.panel4.TabIndex = 0;
            // 
            // cbCompagnyName
            // 
            this.cbCompagnyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCompagnyName.FormattingEnabled = true;
            this.cbCompagnyName.Location = new System.Drawing.Point(355, 105);
            this.cbCompagnyName.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompagnyName.Name = "cbCompagnyName";
            this.cbCompagnyName.Size = new System.Drawing.Size(437, 38);
            this.cbCompagnyName.TabIndex = 42;
            // 
            // lbFax
            // 
            this.lbFax.AutoSize = true;
            this.lbFax.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFax.Location = new System.Drawing.Point(355, 490);
            this.lbFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(43, 30);
            this.lbFax.TabIndex = 41;
            this.lbFax.Text = "Fax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(185, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "Customer Informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(129, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Compagny Name";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPhone.Location = new System.Drawing.Point(355, 444);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(72, 30);
            this.lbPhone.TabIndex = 40;
            this.lbPhone.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(129, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contact Name";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCountry.Location = new System.Drawing.Point(355, 406);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(86, 30);
            this.lbCountry.TabIndex = 39;
            this.lbCountry.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(129, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Code Postal";
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRegion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRegion.Location = new System.Drawing.Point(355, 328);
            this.lbRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(77, 30);
            this.lbRegion.TabIndex = 38;
            this.lbRegion.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(129, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact Title";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCity.Location = new System.Drawing.Point(355, 282);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(48, 30);
            this.lbCity.TabIndex = 37;
            this.lbCity.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(129, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adresse";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdresse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAdresse.Location = new System.Drawing.Point(355, 244);
            this.lbAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(86, 30);
            this.lbAdresse.TabIndex = 36;
            this.lbAdresse.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(129, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "City";
            // 
            // lbContactTitle
            // 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContactTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContactTitle.Location = new System.Drawing.Point(355, 194);
            this.lbContactTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(130, 30);
            this.lbContactTitle.TabIndex = 35;
            this.lbContactTitle.Text = "Contact Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(129, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Region";
            // 
            // lbCodePostal
            // 
            this.lbCodePostal.AutoSize = true;
            this.lbCodePostal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodePostal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCodePostal.Location = new System.Drawing.Point(355, 372);
            this.lbCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodePostal.Name = "lbCodePostal";
            this.lbCodePostal.Size = new System.Drawing.Size(122, 30);
            this.lbCodePostal.TabIndex = 34;
            this.lbCodePostal.Text = "Code Postal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(129, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Country";
            // 
            // lbContactName
            // 
            this.lbContactName.AutoSize = true;
            this.lbContactName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContactName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContactName.Location = new System.Drawing.Point(355, 149);
            this.lbContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContactName.Name = "lbContactName";
            this.lbContactName.Size = new System.Drawing.Size(147, 30);
            this.lbContactName.TabIndex = 33;
            this.lbContactName.Text = "Contact Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(129, 444);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(129, 490);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Fax";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(202, 215);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(226, 91);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = " Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(446, 215);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 91);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Bill";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(315, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 36);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total à Payer";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPrice.Location = new System.Drawing.Point(668, 12);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(31, 36);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "0";
            // 
            // rdAccompte
            // 
            this.rdAccompte.BeforeTouchSize = new System.Drawing.Size(150, 39);
            this.rdAccompte.Location = new System.Drawing.Point(93, 32);
            this.rdAccompte.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rdAccompte.Name = "rdAccompte";
            this.rdAccompte.Size = new System.Drawing.Size(150, 39);
            this.rdAccompte.TabIndex = 24;
            this.rdAccompte.Text = "Payer l\'Accompte";
            // 
            // rdSolde
            // 
            this.rdSolde.Location = new System.Drawing.Point(93, 97);
            this.rdSolde.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rdSolde.Name = "rdSolde";
            this.rdSolde.Size = new System.Drawing.Size(150, 21);
            this.rdSolde.TabIndex = 25;
            this.rdSolde.Text = "Solder";
            // 
            // panel5Footer
            // 
            this.panel5Footer.Controls.Add(this.rdAccompte);
            this.panel5Footer.Controls.Add(this.rdSolde);
            this.panel5Footer.Controls.Add(this.btnPrint);
            this.panel5Footer.Controls.Add(this.btnAdd);
            this.panel5Footer.Controls.Add(this.lbTotalPrice);
            this.panel5Footer.Controls.Add(this.label12);
            this.panel5Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5Footer.Location = new System.Drawing.Point(0, 568);
            this.panel5Footer.Name = "panel5Footer";
            this.panel5Footer.Size = new System.Drawing.Size(1608, 320);
            this.panel5Footer.TabIndex = 26;
            // 
            // EditFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditFacture";
            this.Size = new System.Drawing.Size(1608, 944);
            this.Load += new System.EventHandler(this.EditInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdAccompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSolde)).EndInit();
            this.panel5Footer.ResumeLayout(false);
            this.panel5Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnBack;
        private DataGridView dtgvOD;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private Panel panel3;
        private Panel panel4;
        private Label lbFax;
        private Label label11;
        private Label label1;
        private Label lbPhone;
        private Label label2;
        private Label lbCountry;
        private Label label3;
        private Label lbRegion;
        private Label label4;
        private Label lbCity;
        private Label label5;
        private Label lbAdresse;
        private Label label6;
        private Label lbContactTitle;
        private Label label7;
        private Label lbCodePostal;
        private Label label10;
        private Label lbContactName;
        private Label label9;
        private Label label8;
        private ComboBox cbCompagnyName;
        private Panel panel5Footer;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdAccompte;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdSolde;
        private Button btnPrint;
        private Button btnAdd;
        private Label lbTotalPrice;
        private Label label12;
    }
}
