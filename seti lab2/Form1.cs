using Microsoft.VisualBasic;
namespace seti_lab2
{
    struct subnet
    {
        public int size;
        public int prefix;
        public subnet(int size, int prefix) { this.size = size; this.prefix = prefix; }
    }
    public partial class Form1 : Form
    {
        private IpAdress adress1 = new IpAdress();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string adress = textBoxInputAdress.Text;
            int prefix = int.Parse(textBoxInputPrefix.Text);
            
            try {
                adress1.setIp(adress); 
                adress1.SetPrefix(prefix); 
             }
            catch (Exception ex)
            {  
                MessageBox.Show(ex.Message);
            }
            labelAdress.Text = adress1.getNetworkAdress();
            labelNetworkMask.Text = adress1.getAdressMask();
            labelNumberOfNodes.Text = adress1.getNumberOfNodes().ToString();
            labelWideAdress.Text = adress1.getWideNetworkAdress();
        }
    }
}