using static System.Net.Mime.MediaTypeNames;

namespace HardwareShopManagement1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Input_Data id1 = new Input_Data();
            id1.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Categories ctg = new Categories();
            ctg.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Entry_tab et = new Entry_tab();
            et.ShowDialog();
            Close();
        }
    }
}
