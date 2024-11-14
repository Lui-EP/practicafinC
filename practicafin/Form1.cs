using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicafin
{
    public partial class Form1 : Form
    {
        delegate void setTextDelegate(string val);

        public SerialPort ardPort { get; }
        public Form1()
        {
            InitializeComponent();
            ardPort = new SerialPort();
            ardPort.PortName = "COM8";
            ardPort.BaudRate = 9600;
            ardPort.DataBits = 8;
            ardPort.ReadTimeout = 500;
            ardPort.WriteTimeout = 500;
            ardPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = ardPort.ReadLine();
            typeTxt(data);
        }

        void typeTxt(string val)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new setTextDelegate(typeTxt), val);
                }
                catch { }
            }
            else temp.Text = val;
        }



        private void btncon_Click_1(object sender, EventArgs e)
        {
            btndes.Enabled = true;
            try
            {
                if (!ardPort.IsOpen) ardPort.Open();

                if (int.TryParse(Temlim.Text, out int temperatureLimit))
                {
                    string limitString = temperatureLimit.ToString();
                    ardPort.Write(limitString);

                    con.Text = "conectado";
                    con.ForeColor = Color.Lime;
                }
                else
                {
                    MessageBox.Show("Check your numeric value added to the limit text box");
                }
            }
            catch
            {
                MessageBox.Show("Check your communication port");
            }
        }

        private void btndes_Click(object sender, EventArgs e)
        {
            btncon.Enabled = true;

            if (ardPort.IsOpen)
            {
                ardPort.Close();
            }

            con.Text = "Desconectado";
            con.ForeColor = Color.Red;
            temp.Text = "0.0";
        }
    }
}
