using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOT_PROCESS
{
    public partial class LotForm_Detail : Form
    {

        public LotForm_Detail(List<string> lotDetail)
        {
            InitializeComponent();
            string[] splitData = lotDetail[0].Split(',');
            LOT_ID_VALUE.Text = splitData[0].Trim();
            LOT_NO_VALUE.Text = splitData[1].Trim();
            WORK_NAME_VALUE.Text = splitData[2].Trim();
            WORK_TICKET_VALUE.Text = splitData[3].Trim();
            PROC_NAME_VALUE.Text = splitData[4].Trim();
            EQUIP_NAME_VALUE.Text = splitData[5].Trim();
            PART_NAME_VALUE.Text = splitData[6].Trim();
            QTY_NAME_VALUE.Text = splitData[7].Trim();
            EMP_NAME_VALUE.Text = splitData[8].Trim();
            EMP_DTTM_VALUE.Text = splitData[9].Trim();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void LOT_ID_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void LOT_NO_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void WORK_TICKET_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void PROC_NAME_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void EQUIP_NAME_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void PART_NAME_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void QTY_NAME_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void EMP_NAME_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void EMP_DTTM_VALUE_Click(object sender, EventArgs e)
        {

        }

        private void LotForm_Detail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
