using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Report : Form
    {
        public Form form;
        public Report(WorkCondorsetAlternative workCondorsetAlternative)
        {
            form = workCondorsetAlternative;
           
            InitializeComponent();
        }
    }
}
