using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DateTimeIntervelControl
{
    public partial class DateTimeIntervelPopup : UserControl
    {
        public DateTimeIntervelPopup()
        {
            InitializeComponent();
        }

        public delegate void BtnClickHandle(object sender, EventArgs e, DateTime start, DateTime end);

        public event BtnClickHandle SureClick;

        private void btnSure_Click(object sender, EventArgs e)
        {
            //String sStart = "2014-7-5 3:0:20";
            DateTime start = calendarStart.SelectionStart;
            String sStart = start.Year + "-" + start.Month + "-" + start.Day + " " + timeStart.MyTime;
            start = Convert.ToDateTime(sStart);

            DateTime end = calendarEnd.SelectionStart;
            String sEnd = end.Year + "-" + end.Month + "-" + end.Day + " " + timeEnd.MyTime;
            end = Convert.ToDateTime(sEnd);

            if (SureClick != null)
            {
                SureClick(sender, e, start, end);  //把日期时间传给DateTimeIntervelPicker
            }
        }
    }
}
