using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace CSharp_PLC_Demo
{
    public partial class FormMain : Form
    {

        private Plc plc = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                cboxCPUType.DataSource = Enum.GetNames(typeof(CpuType));
                cboxCPUType.SelectedIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CpuType cputype = (CpuType)Enum.Parse(typeof(CpuType), cboxCPUType.SelectedValue.ToString());
                string ipAddress = txtIPAddress.Text;
                short rack = short.Parse(txtRack.Text);
                short slot = short.Parse(txtSlot.Text);
                plc = new Plc(cputype, ipAddress, rack, slot);
                plc.Open();
                btnConnect.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Close();
                    btnConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    string address = txtMAddress.Text;
                    object result = plc.Read(address);
                    txtPV.Text = string.Format("{0}", result.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    string variable = txtMAddress.Text;
                    object value = txtSP.Text;
                    plc.Write(variable, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCustomWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {



                    plc.Write("DB1.DBX0.0", cBoxdbx00.Checked);

                    plc.Write("DB1.DBX0.1", cBoxdbx01.Checked);

                    short db1IntVariable = short.Parse(txtdb1dbw2.Text);
                    plc.Write("DB1.DBW2", db1IntVariable.ConvertToUshort());

                    int db1DintVariable = int.Parse(txtdb1dbw8.Text);
                    plc.Write("DB1.DBD8", db1DintVariable.ConvertToUInt());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    var temp = plc.ReadBytes(DataType.Memory, 1, 0, 10);
                    //txtread.Text =  temp[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
