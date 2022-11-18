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

        private string convertToDecimal(string binary)
        {
            double decimalD = 0;
            for(int i = 0; i < binary.Length; i++)
                if (binary[i] == '1')
                    decimalD += Math.Pow(2, binary.Length - 1 - i);
            return decimalD.ToString();
        }

        private string convertToBinary(string byteS)
        {
            string binary = ""; 
            Stack<int> queueByte = new Stack<int>();
            int byteI = int.Parse(byteS);
            while (byteI > 0)
            {
                queueByte.Push(byteI % 2);
                byteI = byteI / 2;
            }  
            while(queueByte.Count > 0)
                binary = binary + queueByte.Pop();
            return binary;
        }

        public IpAdress()
        {
            ip = "";
            prefix = 0;
        }
        public void setPrefix(int newPrefix)
        {
            if (newPrefix >= 0 && newPrefix <= 31)
            {
                prefix = newPrefix;
            }
            else throw new ArgumentException("prefix shoud be <= 31 and => 0");
        }

        public void setIp(string newIp)
        {
            if(newIp!= null)
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
            setPrefix(newPrefix);
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

        public string getWideNetworkAdress()
        {
            string[] str = ip.Split(".");
            string lastbyte = "255";
            string mask = "";
            string wideNetworkAdress = "";
            string byteS2;
            string byteS = "";
            for (int i = 0; i < 32; i++)
            {
                if (i < prefix)
                    mask += "1";
                else
                    mask += "0";
            }
            for (int i = 0; i < 3; i++)
            {
                byteS2 = convertToBinary(str[i]);
                for (int j = 0; j < 8; j++)
                {
                    if (j + i * 8 <= prefix - 1)
                        byteS += byteS2[j];
                    else
                        byteS += "1";
                }
                wideNetworkAdress += convertToDecimal(byteS) + ".";
                byteS = "";
            }
            return wideNetworkAdress += lastbyte;
        }

        public string getNetworkAdress()
        {
            string[] str = ip.Split(".");
            string lastbyte = "0";
            string mask = "";
            string wideNetworkAdress = "";
            string byteS2;
            string byteS = "";
            for (int i = 0; i < 32; i++)
            {
                if (i < prefix)
                    mask += "1";
                else
                    mask += "0";
            }
            for (int i = 0; i < 3; i++)
            {
                byteS2 = convertToBinary(str[i]);
                for (int j = 0; j < 8; j++)
                {
                    if (byteS2[j] == '1' && mask[j + i * 8] == '1')
                        byteS += "1";
                    else
                        byteS += "0";
                }
                wideNetworkAdress += convertToDecimal(byteS) + ".";
                byteS = "";
            }
            return wideNetworkAdress += lastbyte;
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
