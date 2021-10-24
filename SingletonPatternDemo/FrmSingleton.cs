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
    public partial class FrmSingleton : Form
    {
        private static FrmSingleton _frmSingleton;

        public static FrmSingleton CreateForm()
        {
            if (_frmSingleton == null || _frmSingleton.IsDisposed == true)
            {
                _frmSingleton = new FrmSingleton();
            }
            return _frmSingleton;
        }

        private FrmSingleton()
        {
            InitializeComponent();
        }
    }
}
