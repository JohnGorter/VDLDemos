﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubaUserControls
{
    public partial class MyUserControl : UserControl
    {
        [Browsable(true)]
        public String MyTitle
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public MyUserControl()
        {
            InitializeComponent();

            
        }
    }
}
