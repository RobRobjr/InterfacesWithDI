using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesWithDI
{
    public partial class FrmMain : Form
    {
        private ILogger _logger;

        public FrmMain(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _logger.Log("The main form is loading.....");
        }
    }
}
