namespace InvoiceGenerator
{
    public partial class MainForm : Form
    {
        //field
        private Button currentButton;
        private Random rand;
        private int tempIndex;
        private Form aciveForm;
        
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
        
        private void ActivateButton (object btnSender)
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

        private void OpenChildFrom(Form childForm,object btnSender)
        {
            if (aciveForm != null)
            {
                aciveForm.Close();
            }
            ActivateButton(btnSender);
            aciveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContaint.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTiltle.Text = childForm.Text;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}