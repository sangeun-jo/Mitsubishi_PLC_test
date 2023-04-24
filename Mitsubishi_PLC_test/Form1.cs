using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILib;

namespace Mitsubishi_PLC_test
{
    public partial class Form1 : Form
    {

        ActEasyIF PLC1 = new ActEasyIF();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            PLC1.ActLogicalStationNumber = 1;
            int conErr = 0;
            conErr = PLC1.Open();

            if (conErr == 0)
            {
                lblState.Text = "Connected";
                tmrUpdate.Start();
            }
            else lblState.Text = "Connection error: " + conErr;
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            PLC1.Close();
            lblState.Text = "Disconnected";
            tmrUpdate.Stop();
        }


        private void btnOn_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 1);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 0);
        }

        private void lamp1_Click(object sender, EventArgs e)
        {

        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            PLC1.GetDevice("Y20", out int Y20);

            if (Y20 == 1) lamp1.BackColor = Color.Red;
            else lamp1.BackColor = Color.LightGray;

            PLC1.GetDevice("D0", out int D0);

            tbData1.Text = D0.ToString(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbData1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbData2_TextChanged(object sender, EventArgs e)
        {

        }

        //D10에 두번째 텍스트 박스의 내용을 집어 놓겠다
        private void btnWrite_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("D10", int.Parse(tbData2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
