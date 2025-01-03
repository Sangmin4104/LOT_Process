using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LOT_PROCESS
{
    public partial class LotForm : Form
    {
        DBConnector dBConnector = new DBConnector();
        List<string> columnProcess;

        public LotForm()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(Form1_Paint1)
                        + new PaintEventHandler(Form1_Paint2)
                        + new PaintEventHandler(Form1_Paint2_1)
                        + new PaintEventHandler(Form1_Paint2_2)
                        + new PaintEventHandler(Form1_Paint3)
                        + new PaintEventHandler(Form1_Paint3_1)
                        + new PaintEventHandler(Form1_Paint3_2)
                        + new PaintEventHandler(Form1_Paint4)
                        + new PaintEventHandler(Form1_Paint5)
                        + new PaintEventHandler(Form1_Paint5_1)
                        + new PaintEventHandler(Form1_Paint6)
                        + new PaintEventHandler(Form1_Paint7);
        }
        private void LotForm_Load(object sender, EventArgs e)
        {
            columnProcess = dBConnector.GetLotProcessData();
            List<string> columnProcNames = dBConnector.GetProcNames();

            LOT_1.Text = columnProcess[0];
            LOT_2_1.Text = columnProcess[1];
            LOT_2_2.Text = columnProcess[2];
            LOT_2_3.Text = columnProcess[3];
            LOT_3.Text = columnProcess[4];
            LOT_4.Text = columnProcess[5];
            LOT_5.Text = columnProcess[6];
            LOT_6.Text = columnProcess[7];
            LOT_7.Text = columnProcess[8];

            LOT_1_NAME.Text = columnProcNames[0];
            LOT_2_1_NAME.Text = columnProcNames[1];
            LOT_2_2_NAME.Text = columnProcNames[2];
            LOT_2_3_NAME.Text = columnProcNames[3];
            LOT_3_NAME.Text = columnProcNames[4];
            LOT_4_NAME.Text = columnProcNames[5];
            LOT_5_NAME.Text = columnProcNames[6];
            LOT_6_NAME.Text = columnProcNames[7];
            LOT_7_NAME.Text = columnProcNames[8];
        }

        private void LOT_1_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[0].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }
        private void LOT_2_1_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[1].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_2_2_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[2].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_2_3_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[3].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_3_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[4].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_4_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[5].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_5_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[6].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_6_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[7].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }

        private void LOT_7_Click(object sender, EventArgs e)
        {
            string[] lotData = columnProcess[8].Split(',');
            string lotNo = lotData[0].Trim();

            List<string> lotDetail = dBConnector.GetLotDetailData(lotNo);

            LotForm_Detail showForm = new LotForm_Detail(lotDetail);
            showForm.ShowDialog();
        }


        private void Form1_Paint1(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(10, 160);
            Point endPoint = new Point(125, 160);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void Form1_Paint2(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(350, 160);
            Point endPoint = new Point(450, 160);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
        private void Form1_Paint2_1(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(400, 160);
            Point middlePoint = new Point(400, 290);
            Point endPoint = new Point(450, 290);

            Pen pen = new Pen(Color.Black, 7);


            e.Graphics.DrawLine(pen, startPoint, middlePoint);

            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, middlePoint, endPoint);
        }
        private void Form1_Paint2_2(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(400, 160);
            Point middlePoint = new Point(400, 410);
            Point endPoint = new Point(450, 410);

            Pen pen = new Pen(Color.Black, 7);

            e.Graphics.DrawLine(pen, startPoint, middlePoint);

            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, middlePoint, endPoint);
        }
        private void Form1_Paint3(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(660, 160);
            Point endPoint = new Point(780, 160);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
        private void Form1_Paint3_1(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(660, 290);
            Point middlePoint = new Point(720, 290);
            Point endPoint = new Point(720, 160);

            Pen pen = new Pen(Color.Black, 7);

            e.Graphics.DrawLine(pen, startPoint, middlePoint);

            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, middlePoint, endPoint);
        }
        private void Form1_Paint3_2(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(660, 410);
            Point middlePoint = new Point(720, 410);
            Point endPoint = new Point(720, 160);

            Pen pen = new Pen(Color.Black, 7);

            e.Graphics.DrawLine(pen, startPoint, middlePoint);

            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, middlePoint, endPoint);
        }

        private void Form1_Paint4(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(10, 635);
            Point endPoint = new Point(125, 635);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
        private void Form1_Paint5(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(350, 635);
            Point endPoint = new Point(450, 635);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
        private void Form1_Paint5_1(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(670, 635);
            Point middlePoint = new Point(1060, 635);
            Point endPoint = new Point(1060, 160);

            Pen pen = new Pen(Color.Black, 7);

            e.Graphics.DrawLine(pen, startPoint, middlePoint);

            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, middlePoint, endPoint);
        }
        private void Form1_Paint6(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(1000, 160);
            Point endPoint = new Point(1130, 160);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
        private void Form1_Paint7(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(1360, 160);
            Point endPoint = new Point(1460, 160);

            Pen pen = new Pen(Color.Black, 7);

            pen.EndCap = LineCap.ArrowAnchor;

            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void LOT_1_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_2_1_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_2_2_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_2_3_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_3_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_4_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_5_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_6_NAME_TEXT(object sender, EventArgs e)
        {

        }
        private void LOT_7_NAME_TEXT(object sender, EventArgs e)
        {

        }

        private void Lot_No_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string lotNoInput = Lot_No_Input.Text.Trim();

            List<string> lotProcessData = new List<string>();

            if (Forward.Checked)
            {
                lotProcessData = dBConnector.BOM_Procedure(lotNoInput, 1);
            }

            string[] lotNoValue = lotProcessData[1].Split(',');


            // LOT_NO와 일치하는 버튼을 찾아서 테두리를 빨간색으로 변경
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                    string buttonText = button.Text.Split(',')[0].Trim();

                    bool isMatch = false;
                    foreach (string lotNo in lotNoValue)
                    {
                        if (buttonText == lotNo.Trim())
                        {
                            isMatch = true;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = Color.Red;
                        button.FlatAppearance.BorderSize = 3;
                        button.BackColor = Color.White;
                        button.MouseEnter += Button_MouseEnter;
                        button.MouseLeave += Button_MouseLeave;
                    }
                    else
                    {
                        button.FlatStyle = FlatStyle.Standard;
                    }
                }
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                }
            }

            Lot_No_Input.Text = "";
        }
        private void btn_No_Search_Click(object sender, EventArgs e)
        {
            string lotNoInput = Lot_No_Input.Text.Trim();


            // LOT_NO와 일치하는 버튼을 찾아서 테두리를 빨간색으로 변경
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                    string buttonText = button.Text.Split(',')[0].Trim();

                    if (buttonText == lotNoInput)
                    {
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = Color.Red;
                        button.FlatAppearance.BorderSize = 3;
                        button.BackColor = Color.White;
                        button.MouseEnter += Button_MouseEnter;
                        button.MouseLeave += Button_MouseLeave;
                    }
                    else
                    {
                        button.FlatStyle = FlatStyle.Standard;
                    }
                }
            }
        }
        private void btn_No_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                }
            }

            Lot_No_Input.Text = "";
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderColor = Color.Red;
            button.FlatAppearance.BorderSize = 3;
            button.BackColor = Color.Red;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderColor = Color.Red;
            button.FlatAppearance.BorderSize = 3;
            button.BackColor = Color.White;
        }

        private void Backward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Forward_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
