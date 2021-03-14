using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _FootballServiceClient.FootballServiceReference;

namespace _FootballServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InfoSoapTypeClient _client = new InfoSoapTypeClient("InfoSoap12");

        private void button1_Click(object sender, EventArgs e)
        {
            tStadiumInfo[] stadiums = _client.AllStadiumInfo();

            foreach (var s in stadiums)
            {
                listBox1.Items.Add(s.sName);
            }

        }
    }
}
