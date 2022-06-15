namespace InvoiceGenerator.UserForms
{
    partial class Invoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvOrder = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OrderiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compagny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 137);
            this.panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBar.BackSegments = false;
            this.progressBar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBar.BorderColor = System.Drawing.Color.LightGray;
            this.progressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar.CustomText = null;
            this.progressBar.CustomWaitingRender = false;
            this.progressBar.ForegroundImage = null;
            this.progressBar.ForeSegments = false;
            this.progressBar.Location = new System.Drawing.Point(760, 12);
            this.progressBar.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Green,
        System.Drawing.Color.Pink,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red};
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
            this.progressBar.SegmentWidth = 2;
            this.progressBar.ShowProgressImage = true;
            this.progressBar.Size = new System.Drawing.Size(377, 23);
            this.progressBar.StretchMultGrad = false;
            this.progressBar.TabIndex = 6;
            this.progressBar.Text = "progressBarAdv1";
            this.progressBar.ThemeName = "MultipleGradient";
            this.progressBar.Value = 0;
            this.progressBar.WaitingGradientWidth = 400;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(807, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1447, 717);
            this.panel2.TabIndex = 1;
            // 
            // dtgvOrder
            // 
            this.dtgvOrder.AllowUserToAddRows = false;
            this.dtgvOrder.AllowUserToDeleteRows = false;
            this.dtgvOrder.AllowUserToResizeColumns = false;
            this.dtgvOrder.AllowUserToResizeRows = false;
            this.dtgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderiD,
            this.Compagny,
            this.Order_Date,
            this.DueDate,
            this.PrixTotal,
            this.CustomerID});
            this.dtgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dtgvOrder.MultiSelect = false;
            this.dtgvOrder.Name = "dtgvOrder";
            this.dtgvOrder.ReadOnly = true;
            this.dtgvOrder.RowTemplate.Height = 25;
            this.dtgvOrder.Size = new System.Drawing.Size(1447, 717);
            this.dtgvOrder.TabIndex = 0;
            this.dtgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrder_CellClick);
            this.dtgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrder_CellClick);
            this.dtgvOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrder_CellContentDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // OrderiD
            // 
            this.OrderiD.HeaderText = "Identifiant";
            this.OrderiD.Name = "OrderiD";
            this.OrderiD.ReadOnly = true;
            // 
            // Compagny
            // 
            this.Compagny.HeaderText = "Compagny";
            this.Compagny.Name = "Compagny";
            this.Compagny.ReadOnly = true;
            // 
            // Order_Date
            // 
            this.Order_Date.HeaderText = "Date de Commande";
            this.Order_Date.Name = "Order_Date";
            this.Order_Date.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Date de Livraison";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // PrixTotal
            // 
            this.PrixTotal.HeaderText = "Prix Total";
            this.PrixTotal.Name = "PrixTotal";
            this.PrixTotal.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Invoice";
            this.Size = new System.Drawing.Size(1447, 854);
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
        private Panel panel2;
        private DataGridView dtgvOrder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBar;
        private DataGridViewTextBoxColumn OrderiD;
        private DataGridViewTextBoxColumn Compagny;
        private DataGridViewTextBoxColumn Order_Date;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn PrixTotal;
        private DataGridViewTextBoxColumn CustomerID;
    }
}
