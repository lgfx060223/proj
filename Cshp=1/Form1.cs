using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            toolTipmoney.AutoPopDelay=500;
            toolTipmoney.InitialDelay = 100;
            toolTipmoney.ReshowDelay = 20;
            toolTipmoney.ToolTipIcon = ToolTipIcon.Info;
            toolTipmoney.ToolTipTitle = null;
            toolTipmoney.Show(buttonMoney.Text, this.buttonMoney);
            toolTipmoney.SetToolTip(this.buttonMoney, "金钱是重要的资源");
        }
        private void radioButtonEco_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonInv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTipmoney.ToolTipTitle = "每次点击增长：";
            toolTipmoney.IsBalloon = false;
            toolTipmoney.UseFading = true;
            Show(); 
        }

        private void toolTip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerMoney_Tick(object sender, EventArgs e)
        {
            
            if (progressBarMoney.Value<progressBarMoney.Maximum)
                this.progressBarMoney.Value += 1;
            else
            {
                this.progressBarMoney.Value = progressBarMoney.Minimum;
                
            }
                
        }

        private void progressBarMoney_Click(object sender, EventArgs e)
        {

        }

        private void progressBarBuild_Click(object sender, EventArgs e)
        {

        }

        private void progressBarFootman_Click(object sender, EventArgs e)
        {

        }

        private void progressBarUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void progressBarInvasion_Click(object sender, EventArgs e)
        {

        }

        private void progressBarHiFootman_Click(object sender, EventArgs e)
        {

        }
        private void progressBarKnight_Click(object sender, EventArgs e)
        {

        }

        private void progressBarHiKnight_Click(object sender, EventArgs e)
        {

        }
        private void timerFootman_Tick(object sender, EventArgs e)
        {

        }

        private void timerHiFootman_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void timerUpgrade_Tick(object sender, EventArgs e)
        {    
               if (progressBarUpgrade.Value < progressBarUpgrade.Maximum){
                   this.progressBarUpgrade.Value += 1;
                   
                }
                else
                {
                    this.progressBarUpgrade.Value = progressBarUpgrade.Minimum;

                }

        }

        private void radioButtonUpgrade_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
