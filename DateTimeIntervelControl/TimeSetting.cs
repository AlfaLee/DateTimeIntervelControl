using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimeIntervelControl
{
    public partial class TimeSetting : UserControl
    {

        public TimeSetting()
        {
            InitializeComponent();
        }

        public String MyTime
        {
            get
            {
                return numHour.Text + ":" + numMin.Text + ":" + numSecond.Text;
            }
        }
    }
}
