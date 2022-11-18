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
                adress1.setPrefix(prefix); 
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

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<subnet> subnetList = new Stack<subnet>();
            int prefix = adress1.getPrefix();
            int[] massOfNodes = new int[10];
            int i = 0;
            string inputNodes;
            string dialogInfo = "";
            while ((inputNodes = Interaction.InputBox("input Nodes" + "\ninputed nodes: " + dialogInfo, "title", "50")) != "")
            {
                dialogInfo += inputNodes + " ";
                massOfNodes[i++] = int.Parse(inputNodes);
                if (massOfNodes.Sum() > Math.Pow(2, 32 - prefix))
                    return;
            }
            for (i = 0; i < massOfNodes.Length; i++)
            {
            }
            subnet temp = subnetList.Pop();
            listBox1.Text = "Количество узлов подсети: " + temp.size.ToString() + " Префикс:" + temp.prefix.ToString();
        }
    }
}