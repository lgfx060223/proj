namespace Cshp_1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.radioButtonMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonMilitary = new System.Windows.Forms.RadioButton();
            this.radioButtonUpgrade = new System.Windows.Forms.RadioButton();
            this.radioButtonInvasion = new System.Windows.Forms.RadioButton();
            this.toolTipmoney = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarMoney = new System.Windows.Forms.ProgressBar();
            this.progressBarFootman = new System.Windows.Forms.ProgressBar();
            this.progressBarUpgrade = new System.Windows.Forms.ProgressBar();
            this.progressBarInvasion = new System.Windows.Forms.ProgressBar();
            this.timerMoney = new System.Windows.Forms.Timer(this.components);
            this.progressBarHiFootman = new System.Windows.Forms.ProgressBar();
            this.progressBarKnight = new System.Windows.Forms.ProgressBar();
            this.progressBarHiKnight = new System.Windows.Forms.ProgressBar();
            this.progressBarBuild = new System.Windows.Forms.ProgressBar();
            this.timerFootman = new System.Windows.Forms.Timer(this.components);
            this.timerHiFootman = new System.Windows.Forms.Timer(this.components);
            this.toolTipFootman = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipKnight = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHiKnight = new System.Windows.Forms.ToolTip(this.components);
            this.timerBuild = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.Honeydew;
            this.buttonMoney.ForeColor = System.Drawing.Color.Gray;
            this.buttonMoney.Location = new System.Drawing.Point(101, 12);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(109, 38);
            this.buttonMoney.TabIndex = 0;
            this.buttonMoney.Text = "点击增长金钱";
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.AutoSize = true;
            this.radioButtonMoney.Location = new System.Drawing.Point(12, 70);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(47, 16);
            this.radioButtonMoney.TabIndex = 1;
            this.radioButtonMoney.TabStop = true;
            this.radioButtonMoney.Text = "经济";
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            this.radioButtonMoney.CheckedChanged += new System.EventHandler(this.radioButtonEco_CheckedChanged);
            // 
            // radioButtonMilitary
            // 
            this.radioButtonMilitary.AutoSize = true;
            this.radioButtonMilitary.Location = new System.Drawing.Point(12, 154);
            this.radioButtonMilitary.Name = "radioButtonMilitary";
            this.radioButtonMilitary.Size = new System.Drawing.Size(47, 16);
            this.radioButtonMilitary.TabIndex = 2;
            this.radioButtonMilitary.TabStop = true;
            this.radioButtonMilitary.Text = "军事";
            this.radioButtonMilitary.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpgrade
            // 
            this.radioButtonUpgrade.AutoSize = true;
            this.radioButtonUpgrade.Location = new System.Drawing.Point(12, 242);
            this.radioButtonUpgrade.Name = "radioButtonUpgrade";
            this.radioButtonUpgrade.Size = new System.Drawing.Size(47, 16);
            this.radioButtonUpgrade.TabIndex = 4;
            this.radioButtonUpgrade.TabStop = true;
            this.radioButtonUpgrade.Text = "升级";
            this.radioButtonUpgrade.UseVisualStyleBackColor = true;
            this.radioButtonUpgrade.CheckedChanged += new System.EventHandler(this.radioButtonUpgrade_CheckedChanged);
            // 
            // radioButtonInvasion
            // 
            this.radioButtonInvasion.AutoSize = true;
            this.radioButtonInvasion.Location = new System.Drawing.Point(12, 333);
            this.radioButtonInvasion.Name = "radioButtonInvasion";
            this.radioButtonInvasion.Size = new System.Drawing.Size(47, 16);
            this.radioButtonInvasion.TabIndex = 3;
            this.radioButtonInvasion.TabStop = true;
            this.radioButtonInvasion.Text = "入侵";
            this.radioButtonInvasion.UseVisualStyleBackColor = true;
            this.radioButtonInvasion.CheckedChanged += new System.EventHandler(this.radioButtonInv_CheckedChanged);
            // 
            // toolTipmoney
            // 
            this.toolTipmoney.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // progressBarMoney
            // 
            this.progressBarMoney.Location = new System.Drawing.Point(65, 63);
            this.progressBarMoney.Maximum = 30;
            this.progressBarMoney.Minimum = 3;
            this.progressBarMoney.Name = "progressBarMoney";
            this.progressBarMoney.Size = new System.Drawing.Size(100, 23);
            this.progressBarMoney.TabIndex = 6;
            this.progressBarMoney.Value = 3;
            this.progressBarMoney.Click += new System.EventHandler(this.progressBarMoney_Click);
            // 
            // progressBarFootman
            // 
            this.progressBarFootman.Location = new System.Drawing.Point(65, 147);
            this.progressBarFootman.Name = "progressBarFootman";
            this.progressBarFootman.Size = new System.Drawing.Size(100, 23);
            this.progressBarFootman.TabIndex = 6;
            this.progressBarFootman.Click += new System.EventHandler(this.progressBarFootman_Click);
            // 
            // progressBarUpgrade
            // 
            this.progressBarUpgrade.Location = new System.Drawing.Point(65, 235);
            this.progressBarUpgrade.Maximum = 500;
            this.progressBarUpgrade.Minimum = 3;
            this.progressBarUpgrade.Name = "progressBarUpgrade";
            this.progressBarUpgrade.Size = new System.Drawing.Size(100, 23);
            this.progressBarUpgrade.TabIndex = 6;
            this.progressBarUpgrade.Value = 3;
            this.progressBarUpgrade.Click += new System.EventHandler(this.progressBarUpgrade_Click);
            // 
            // progressBarInvasion
            // 
            this.progressBarInvasion.Location = new System.Drawing.Point(65, 326);
            this.progressBarInvasion.Name = "progressBarInvasion";
            this.progressBarInvasion.Size = new System.Drawing.Size(100, 23);
            this.progressBarInvasion.TabIndex = 6;
            this.progressBarInvasion.Click += new System.EventHandler(this.progressBarInvasion_Click);
            // 
            // timerMoney
            // 
            this.timerMoney.Enabled = true;
            this.timerMoney.Tick += new System.EventHandler(this.timerMoney_Tick);
            // 
            // progressBarHiFootman
            // 
            this.progressBarHiFootman.Location = new System.Drawing.Point(171, 147);
            this.progressBarHiFootman.Name = "progressBarHiFootman";
            this.progressBarHiFootman.Size = new System.Drawing.Size(100, 23);
            this.progressBarHiFootman.TabIndex = 6;
            this.progressBarHiFootman.Click += new System.EventHandler(this.progressBarHiFootman_Click);
            // 
            // progressBarKnight
            // 
            this.progressBarKnight.Location = new System.Drawing.Point(277, 147);
            this.progressBarKnight.Name = "progressBarKnight";
            this.progressBarKnight.Size = new System.Drawing.Size(100, 23);
            this.progressBarKnight.TabIndex = 6;
            this.progressBarKnight.Click += new System.EventHandler(this.progressBarKnight_Click);
            // 
            // progressBarHiKnight
            // 
            this.progressBarHiKnight.Location = new System.Drawing.Point(383, 147);
            this.progressBarHiKnight.Name = "progressBarHiKnight";
            this.progressBarHiKnight.Size = new System.Drawing.Size(100, 23);
            this.progressBarHiKnight.TabIndex = 6;
            this.progressBarHiKnight.Click += new System.EventHandler(this.progressBarHiKnight_Click);
            // 
            // progressBarBuild
            // 
            this.progressBarBuild.Location = new System.Drawing.Point(171, 63);
            this.progressBarBuild.Maximum = 30;
            this.progressBarBuild.Minimum = 3;
            this.progressBarBuild.Name = "progressBarBuild";
            this.progressBarBuild.Size = new System.Drawing.Size(100, 23);
            this.progressBarBuild.TabIndex = 6;
            this.progressBarBuild.Value = 3;
            this.progressBarBuild.Click += new System.EventHandler(this.progressBarBuild_Click);
            // 
            // timerFootman
            // 
            this.timerFootman.Tick += new System.EventHandler(this.timerFootman_Tick);
            // 
            // timerHiFootman
            // 
            this.timerHiFootman.Tick += new System.EventHandler(this.timerHiFootman_Tick);
            // 
            // timerBuild
            // 
            this.timerBuild.Enabled = true;
            this.timerBuild.Tick += new System.EventHandler(this.timerUpgrade_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 733);
            this.Controls.Add(this.progressBarInvasion);
            this.Controls.Add(this.progressBarUpgrade);
            this.Controls.Add(this.progressBarHiKnight);
            this.Controls.Add(this.progressBarKnight);
            this.Controls.Add(this.progressBarHiFootman);
            this.Controls.Add(this.progressBarFootman);
            this.Controls.Add(this.progressBarBuild);
            this.Controls.Add(this.progressBarMoney);
            this.Controls.Add(this.radioButtonUpgrade);
            this.Controls.Add(this.radioButtonInvasion);
            this.Controls.Add(this.radioButtonMilitary);
            this.Controls.Add(this.radioButtonMoney);
            this.Controls.Add(this.buttonMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.RadioButton radioButtonMoney;
        private System.Windows.Forms.RadioButton radioButtonMilitary;
        private System.Windows.Forms.RadioButton radioButtonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonInvasion;
        private System.Windows.Forms.ToolTip toolTipmoney;
        private System.Windows.Forms.ProgressBar progressBarMoney;
        private System.Windows.Forms.ProgressBar progressBarFootman;
        private System.Windows.Forms.ProgressBar progressBarUpgrade;
        private System.Windows.Forms.ProgressBar progressBarInvasion;
        private System.Windows.Forms.ProgressBar progressBarHiFootman;
        private System.Windows.Forms.ProgressBar progressBarKnight;
        private System.Windows.Forms.ProgressBar progressBarHiKnight;
        private System.Windows.Forms.ProgressBar progressBarBuild;
        private System.Windows.Forms.Timer timerMoney;
        private System.Windows.Forms.Timer timerFootman;
        private System.Windows.Forms.Timer timerHiFootman;
        private System.Windows.Forms.ToolTip toolTipFootman;
        private System.Windows.Forms.ToolTip toolTipKnight;
        private System.Windows.Forms.ToolTip toolTipHiKnight;
        private System.Windows.Forms.Timer timerBuild;
    }
}

