using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DateTimeIntervelControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sStart = "2014-7-5 1:0:1";
            DateTime gstart = Convert.ToDateTime(sStart);
            //MessageBox.Show(gstart.ToLongDateString() + " " + gstart.ToLongTimeString());
        }

        public static DateTime TransStrToDateTime(string strDateTime)
        {
            DateTime now;
            string[] format = new string[]   
            {   
                "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss", "yyyy年MM月dd日 HH时mm分ss秒",  
                "yyyyMdHHmmss","yyyy年M月d日 H时mm分ss秒", "yyyy.M.d HH:mm:ss", "yyyy.MM.dd HH:mm:ss","yyyy-MM-dd","yyyyMMdd"  
                ,"yyyy/MM/dd","yyyy/M/d"  
            };
            if (DateTime.TryParseExact(strDateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out now))
            {
                return now;
            }
            return DateTime.MinValue;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimeIntervelPicker.StartTime.ToShortDateString() + " " +
                dateTimeIntervelPicker.StartTime.ToShortTimeString() + " " +
                dateTimeIntervelPicker.EndTime.ToShortDateString() + " " +
                dateTimeIntervelPicker.EndTime.ToShortTimeString());
        }

    }
}
