using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WuQiang.Advaned.Lottery.Common;

namespace WuQiang.Advaned.Lottery
{
    public partial class Form1 : Form
    {
        public static object frmSSQ_LOCK = new object();


        private string[] RedNums = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32","33" };


        private string[] BlueNums = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.btnStart.Text = "运行ing";
            this.btnStart.Enabled = false;
            this.labelBlue.Text = "00";
            this.labelRed1.Text = "00";
            this.labelRed2.Text = "00";
            this.labelRed3.Text = "00";
            this.labelRed4.Text = "00";
            this.labelRed5.Text = "00";
            this.labelRed6.Text = "00";

            Thread.Sleep(1000);
            TaskFactory taskFactory = new TaskFactory();
            foreach (Control control in this.groupBoxSSQ.Controls)
            {
                if (control is Label)
                {
                    Label label = control as Label;

                    if (label.Name.Contains("Blue"))
                    {
                        taskFactory.StartNew(()=> {
                            while (true)
                            {
                                int indexNum = new RandomHelper().GetNumber(0, BlueNums.Length);
                                string strNumber = this.BlueNums[indexNum];
                                UpdateLabel(label, strNumber);
                               // label.Text = strNumber; 
                            }
                        });
                    }
                    else
                    {
                        taskFactory.StartNew(() =>
                        {
                            while (true)
                            {
                                int indexNum = new RandomHelper().GetNumber(0, RedNums.Length);
                                string strNumber = this.RedNums[indexNum];

                                lock (frmSSQ_LOCK)
                                {
                                    if (IsExsit(strNumber))
                                    {
                                        continue;
                                    }

                                    UpdateLabel(label, strNumber); 
                                }
                                // label.Text = strNumber; 
                            }
                        });
                    }

                }
            }

            while (true)
            {
                Thread.Sleep(100);
            }


            this.btnStop.Enabled = true;
        }

        /// <summary>
        /// 更新控件
        /// </summary>
        /// <param name="label"></param>
        /// <param name="strNumber"></param>
        private void UpdateLabel(Label label, string strNumber)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke(new Action<string>(s => label.Text = s), strNumber);
            }
            else
            {
                label.Text = strNumber;
            }
        }

        private bool IsExsit(string strNumber)
        {
            foreach (Control control in this.groupBoxSSQ.Controls)
            {
                if (control is Label)
                {
                    Label label = control as Label;
                    if (!label.Name.Contains("Red"))
                    {
                        continue;
                    }
                    if (label.Text.Equals(strNumber))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
