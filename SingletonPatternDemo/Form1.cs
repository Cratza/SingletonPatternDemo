using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingletonPatternDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 普通模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommon frmCommon = new FrmCommon();
            frmCommon.MdiParent = this;
            frmCommon.Show();
        }

        private void 单例模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSingleton frmSingleton = FrmSingleton.CreateForm();
            frmSingleton.MdiParent = this;
            frmSingleton.Show();
        }
    }
}
