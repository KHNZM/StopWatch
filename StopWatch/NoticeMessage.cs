﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class NoticeMessage : Form
    {
        public NoticeMessage()
        {
            InitializeComponent();
        }

        private void NoticeTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
