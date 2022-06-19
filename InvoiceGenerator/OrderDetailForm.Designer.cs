namespace InvoiceGenerator
{
    partial class OrderDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrderID = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIntitule = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbQuantity = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intiltule";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoLabel2.Location = new System.Drawing.Point(25, 63);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(396, 25);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "________________________________________________";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoLabel1.Location = new System.Drawing.Point(43, 54);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(178, 24);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "New ITEM      For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // lbOrderID
            // 
            this.lbOrderID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.Location = new System.Drawing.Point(264, 54);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(108, 24);
            this.lbOrderID.TabIndex = 3;
            this.lbOrderID.Text = "New ITEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // tbIntitule
            // 
            this.tbIntitule.Location = new System.Drawing.Point(119, 91);
            this.tbIntitule.Multiline = true;
            this.tbIntitule.Name = "tbIntitule";
            this.tbIntitule.Size = new System.Drawing.Size(291, 94);
            this.tbIntitule.TabIndex = 6;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(119, 201);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(291, 26);
            this.tbAmount.TabIndex = 6;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // tbQuantity
            // 
            this.tbQuantity.BeforeTouchSize = new System.Drawing.Size(291, 26);
            this.tbQuantity.Location = new System.Drawing.Point(119, 261);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(10);
            this.tbQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(291, 26);
            this.tbQuantity.TabIndex = 7;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbQuantity.ValueChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(119, 312);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(291, 26);
            this.tbTotal.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 58);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 431);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbIntitule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderDetailForm";
            this.Text = "OrderDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Label label2;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbOrderID;
        private Label label4;
        private TextBox tbIntitule;
        private TextBox tbAmount;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt tbQuantity;
        private TextBox tbTotal;
        private Button btnAdd;
        private Button btnCancel;
    }
}