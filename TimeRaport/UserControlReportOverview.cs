using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
    public partial class UserControlReportOverview : UserControl
    {
        public UserControlReportOverview()
        {
            InitializeComponent();
            TimeLogBindingSource.DataSource = TimeLogFactory.Instance;            
            m_ReportViewer.RefreshReport();
        }
       
    }
}
