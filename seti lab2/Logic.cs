using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seti_lab2
{
    internal class IpAdress
    {
        private string ip;
        private int prefix;

        private static string ConvertToDecimal(string binary)
        {
            double decimalD = 0;
            for(int i = 0; i < binary.Length; i++)
                if (binary[i] == '1')
                    decimalD += Math.Pow(2, binary.Length - 1 - i);
            return decimalD.ToString();
        }

        private static string ConvertToBinary(string byteS)
        {
            string binary = ""; 
            Stack<int> stackByte = new Stack<int>();
            int byteI = int.Parse(byteS);
            while (byteI > 0)
            {
                stackByte.Push(byteI % 2);
                byteI = byteI / 2;
            }
            while (stackByte.Count < 8)
                stackByte.Push(0);
            while(stackByte.Count > 0)
                binary += stackByte.Pop();
            return binary;
        }

        public IpAdress()
        {
            ip = "";
            prefix = 0;
        }
        public void SetPrefix(int newPrefix)
        {
            if (newPrefix >= 0 && newPrefix <= 31)
            {
                prefix = newPrefix;
            }
            else throw new ArgumentException("prefix shoud be <= 31 and => 0");
        }

        public void setIp(string newIp)
        {
            if(newIp != null)
            {
                string[] str = newIp.Split(".");

                if (str.Length != 4)
                    throw new ArgumentException("Adress shoud contain 4 words!");
                else
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (int.Parse(str[i]) < 0 || int.Parse(str[i]) > 256)
                        {
                            throw new ArgumentException("Bite of ip adress shoud be >= 0 or > 256!");
                        }
                    }
                    ip = newIp;
                }
            }
        }

        public IpAdress(string newIp, int newPrefix)
        {
            SetPrefix(newPrefix);
            setIp(newIp);
        }

        public string getIp()
        {
            return ip;
        }
        public int getPrefix()
        {
            return prefix;
        }
        private string byteAnd(string byte1, string byte2, int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
                if (byte1[i] == '1' && byte2[i] == '1')
                    str += "1";
                else
                    str += "0";
           return str;

        }
        public string getWideNetworkAdress()
        {
            string[] str = ip.Split(".");
            string wideNetworkAdress = "";
            string mask = "";
            string byteAdress = "";
            string byteBinAdress = "";
            string networkBinAdress = "";

            for (int i = 0; i < 32; i++)
                    mask += "1";

            for (int i = 0; i < str.Length; i++)
                byteBinAdress += ConvertToBinary(str[i]);

            networkBinAdress = byteAnd(byteBinAdress, mask, prefix);
            for (int i = 32 - prefix; i < 32; i++)
                networkBinAdress += "1";
            while(networkBinAdress.Length < 32)
                networkBinAdress+= "1";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                    byteAdress += networkBinAdress[i * 8 + j];
                    if (i == 3)
                        wideNetworkAdress += ConvertToDecimal(byteAdress);
                    else
                        wideNetworkAdress += ConvertToDecimal(byteAdress) + ".";
                    byteAdress = "";
            }
            return wideNetworkAdress;
        }

        public string getNetworkAdress()
        {
            string[] str = ip.Split(".");
            string networkAdress = "";
            string mask = "";
            string byteAdress = "";
            string byteBinAdress = "";
            string networkBinAdress = "";
            for (int i = 0; i < 32; i++)
                if (i < prefix)
                    mask += "1";
                else 
                    mask += "0";


            for (int i = 0; i < str.Length; i++)
                byteBinAdress += ConvertToBinary(str[i]);
            networkBinAdress = byteAnd(byteBinAdress, mask, 32);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                    byteAdress += networkBinAdress[i * 8 + j];
                if (i == 3)
                    networkAdress += ConvertToDecimal(byteAdress);
                else
                    networkAdress += ConvertToDecimal(byteAdress) + ".";
                byteAdress = "";
            }
            return networkAdress;
        }

        public string getAdressMask()
        {
            int n = 4 - prefix / 8;
            string mask = "";
            double lb = 0;
            Queue<string> queue = new Queue<string>();
            for(int i = 1; i <= prefix % 8; i++)
            {
                lb += Math.Pow(2, 8 - i);
            }

            for(int i = 0; i <= 3 - n; i++)
            {
                queue.Enqueue("255");
            }
            queue.Enqueue(lb.ToString());

            for (int i = 0; i < n - 1; i++)
            {
                queue.Enqueue("0");
            }
            while(queue.Count > 1)
            mask += queue.Dequeue() + ".";
            mask += queue.Dequeue();
            mask += " ";
            for(int i = 0; i < 32; i++)
            {
                if (i < prefix)
                    mask += "1";
                else
                    mask += "0";
            }
            return mask;
        }
        public double getNumberOfNodes()
        {
            return Math.Pow(2, 32 - prefix) - 2;
        }
    }
}
