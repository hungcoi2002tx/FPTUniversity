namespace WinFormsApp2
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
            
        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You cliked me", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(dr == DialogResult.OK) {
                MessageBox.Show("Bạn đã đồng ý hi");
            }
            else
            {
                MessageBox.Show("Bạn đã không đồng ý");
            }
            MessageBox.Show(dr.ToString());
        }
    }
}