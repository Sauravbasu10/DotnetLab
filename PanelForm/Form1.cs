namespace PanelForm
{
    public partial class Form1 : Form
    {
        private Form2 reg;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Clear(); // optional: clears existing controls
            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (reg == null || reg.IsDisposed)
            {
                reg = new Form2();
                reg.TopLevel = false;
                reg.FormBorderStyle = FormBorderStyle.None;
                reg.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(reg);
            reg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm LoginPage = new LoginForm();
            LoadFormIntoPanel(LoginPage);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calculatorPage = new Calculator();
            LoadFormIntoPanel(calculatorPage);

        }
    }
}
