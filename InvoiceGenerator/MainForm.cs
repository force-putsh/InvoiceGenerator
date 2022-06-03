using InvoiceGenerator.UserForms;

namespace InvoiceGenerator
{
    public partial class MainForm : Form
    {
        //field
        private Button currentButton;
        private Random rand;
        private int tempIndex;
        private UserControl aciveForm;
        
        //constuctor
        public MainForm()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method

        private Color SelectThemeColor()
        {
            int index = rand.Next(ThemeColor.ColorList.Count);
            while (index == tempIndex)
            {
                index = rand.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string colorName = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(colorName);
        }
        
        private void ActivateButton (object btnSender,Label lb)
        {
            if(btnSender !=null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb.Text = currentButton.Text.ToUpper();
                }
            }
        }
        
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(12, 143, 188);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbTiltle);
            aciveForm = new Invoice(panelContaint);
            aciveForm.Dock = DockStyle.Fill;
            panelContaint.Controls.Clear();
            panelContaint.Controls.Add(aciveForm);
            aciveForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbTiltle);
            aciveForm = new CustomerUF();
            aciveForm.Dock = DockStyle.Fill;
            panelContaint.Controls.Clear();
            panelContaint.Controls.Add(aciveForm);
            aciveForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbTiltle);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbTiltle);
        }
    }
}