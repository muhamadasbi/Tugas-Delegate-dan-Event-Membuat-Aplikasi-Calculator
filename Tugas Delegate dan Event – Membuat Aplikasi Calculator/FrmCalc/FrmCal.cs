using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalc
{
    public partial class FrmCal : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public FrmCal()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FrmEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            listBox1.Items.Add(cal.Hasil);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntryCal frmEntry = new FrmEntryCal("Calculator");
            frmEntry.OnCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }

        private void FrmCal_Load(object sender, EventArgs e)
        {

        }
    }
}
