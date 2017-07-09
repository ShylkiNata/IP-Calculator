using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator
{
    [WebService(Namespace = "ipcalculator")]
    public class Calculator : System.Web.Services.WebService
    {
        // Service method. It requires data structure, consisting of 4 address bytes, and integer mask value in the range [1;30] 
        [WebMethod]
        public List<string> Calculate(List<int> bits, int mask) 
        {
            int addToByte = 0;
            string temp = "";

            List<string> buffer = new List<string>();

            for (int i = 0; i < 4; i++)
                buffer.Add(Convert.ToString(bits[i], 2)); // convert integer bytes value into binary format

            // add the resulting binary representation of each byte to 8 bits
            for (int i = 0; i < 4; i++) 
            {
                temp = "";
                addToByte = 8 - buffer[i].Length; // calculate the number of zeros that should be used to complete the sequence
                for (int j=0; j < addToByte; j++)
                    temp += "0"; 
                buffer[i] = temp + buffer[i];              
            }

            temp = buffer[0] + buffer[1] + buffer[2] + buffer[3]; 
            temp = temp.Substring(0, mask);
            for (int i = mask; i < 32; i++)
                temp += "0"; // calculate network address

            string netAddr="", firstAddr="", lastAddr="", bcastAddr="", netAmount="", substr = "";

            for (int i = 0; i < 32; i += 8)
            {
                substr = temp.Substring(i, 8);
                netAddr += Convert.ToInt32(substr,2) + "."; // convert network address bytes from binary format into integer; save bytes as string 

                if(i==24) firstAddr += Convert.ToInt32(substr,2) + 1 + "."; // address of the first node of the network
                else firstAddr += Convert.ToInt32(substr,2) + ".";
            }

            temp = temp.Substring(0, mask); 
            for (int i = mask; i < 32; i++)
                temp += "1"; // broadcast address

            for (int i = 0; i < 32; i += 8)
            {
                substr = temp.Substring(i, 8);
                bcastAddr += Convert.ToInt32(substr,2) + "."; // convert broadcast address bytes from binary format into integer; save bytes as string 

                if (i == 24) lastAddr += Convert.ToInt32(substr,2) - 1 + ".";
                else lastAddr += Convert.ToInt32(substr,2) + "."; // address of the last node of the network
            }

            netAmount = (Math.Pow(2, 32 - mask) - 2).ToString(); // amount of nodes in the network

            List<string> result = new List<string>(); // prepare answer for client
            result.Add(netAddr.Substring(0, netAddr.Length - 1));
            result.Add(firstAddr.Substring(0, firstAddr.Length - 1));
            result.Add(lastAddr.Substring(0, lastAddr.Length - 1));
            result.Add(bcastAddr.Substring(0, bcastAddr.Length - 1));
            result.Add(netAmount);

            return result; 
        }
    }
}
