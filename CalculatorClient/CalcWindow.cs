using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorClient
{
    public partial class CalcWindow : Form
    {
        public CalcWindow()
        {
            InitializeComponent();
        }

        private void ipField_GotFocus(object sender, EventArgs e)
        {
            // clear placeholder value after clicking on the IP address input field
            if (ipField.Text.Equals("IP address")) ipField.Text = String.Empty; 
        }
        private void maskField_GotFocus(object sender, EventArgs e)
        {
            if (maskField.Text.Equals("mask")) maskField.Text = String.Empty;
        }

        // "Calculate" button handler
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // clear all output fields 
            network.Text = "";
            firstIP.Text = "";
            lastIP.Text = "";
            bcastIP.Text = "";
            nodesNumber.Text = "";

            try
            {
                ServiceReference.CalculatorSoapClient client = new ServiceReference.CalculatorSoapClient(); 
                int errorFlag = 0; // error occurrence flag

                string ip = ipField.Text; // read IP address value
                string m = maskField.Text; // read mask value

                int mask = Int32.Parse(m); // convert mask type from string to int

                if (mask > 30 || mask < 0) // mask range validation
                    MessageBox.Show("Incorrect value of the mask!\nPlease, enter the mask value in the range [1; 30]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // object with client data designed for the server-side processing
                    ServiceReference.ArrayOfInt bits = new ServiceReference.ArrayOfInt();

                    // splitting the IP address string into substrings with dot as delimiter
                    int index = ip.IndexOf("."), i = 0;
                    while (index != -1)
                    {
                        i++;
                        bits.Add(Int32.Parse(ip.Substring(0, index)));
                        index++;
                        ip = ip.Substring(index, ip.Length - index);
                        index = ip.IndexOf(".");
                    }
                    if (i == 3) // number of dots is equal to 3
                    {
                        if (ip.Length > 0)  
                            bits.Add(Int32.Parse(ip.Substring(0, ip.Length)));

                        for (i = 0; i < 4; i++)
                            if (bits[i] > 255 || bits[i] < 0) // IP address bytes validation
                            {
                                MessageBox.Show("Incorrect value of the " + i + "byte of the IP address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                errorFlag = 1;
                            }
                        if (errorFlag == 0) // there are no errors
                        {
                            // send data to server and save answer
                            List<string> result = new List<string>(client.Calculate(bits, mask));

                            // set answer into the output fields
                            network.Text = result[0];
                            firstIP.Text = result[1];
                            lastIP.Text = result[2];
                            bcastIP.Text = result[3];
                            nodesNumber.Text = result[4];
                        }
                    }
                    else MessageBox.Show("Incorrect format of the IP address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
