namespace CorelLASERBot
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMouse2 = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonMouse1 = new System.Windows.Forms.RadioButton();
            this.buttonMore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.panelIndicator1 = new System.Windows.Forms.Panel();
            this.panelIndicator2 = new System.Windows.Forms.Panel();
            this.checkBoxDoubleAction = new System.Windows.Forms.CheckBox();
            this.pictureBoxTriqadafi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriqadafi)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(23, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(139, 18);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Idle...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            this.labelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(168, 12);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMPort.TabIndex = 5;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(295, 10);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "RUN!";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelRefresh.Location = new System.Drawing.Point(229, 15);
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size(44, 13);
            this.linkLabelRefresh.TabIndex = 7;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            this.linkLabelRefresh.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelRefresh.Click += new System.EventHandler(this.linkLabelRefresh_Click);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownX.Location = new System.Drawing.Point(9, 19);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.ReadOnly = true;
            this.numericUpDownX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownX.TabIndex = 8;
            this.numericUpDownX.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownY.Location = new System.Drawing.Point(72, 19);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.ReadOnly = true;
            this.numericUpDownY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownY.TabIndex = 9;
            this.numericUpDownY.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(9, 45);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(57, 23);
            this.buttonGet.TabIndex = 10;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(9, 74);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(120, 23);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMouse2);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.radioButtonMouse1);
            this.groupBox1.Controls.Add(this.buttonTest);
            this.groupBox1.Controls.Add(this.numericUpDownY);
            this.groupBox1.Controls.Add(this.numericUpDownX);
            this.groupBox1.Controls.Add(this.buttonGet);
            this.groupBox1.Location = new System.Drawing.Point(271, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 105);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse";
            // 
            // radioButtonMouse2
            // 
            this.radioButtonMouse2.AutoSize = true;
            this.radioButtonMouse2.Location = new System.Drawing.Point(94, -1);
            this.radioButtonMouse2.Name = "radioButtonMouse2";
            this.radioButtonMouse2.Size = new System.Drawing.Size(38, 17);
            this.radioButtonMouse2.TabIndex = 18;
            this.radioButtonMouse2.Text = "#2";
            this.radioButtonMouse2.UseVisualStyleBackColor = true;
            this.radioButtonMouse2.CheckedChanged += new System.EventHandler(this.radioButtonMouse2_CheckedChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(72, 45);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(57, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // radioButtonMouse1
            // 
            this.radioButtonMouse1.AutoSize = true;
            this.radioButtonMouse1.Checked = true;
            this.radioButtonMouse1.Location = new System.Drawing.Point(56, -1);
            this.radioButtonMouse1.Name = "radioButtonMouse1";
            this.radioButtonMouse1.Size = new System.Drawing.Size(38, 17);
            this.radioButtonMouse1.TabIndex = 17;
            this.radioButtonMouse1.TabStop = true;
            this.radioButtonMouse1.Text = "#1";
            this.radioButtonMouse1.UseVisualStyleBackColor = true;
            this.radioButtonMouse1.CheckedChanged += new System.EventHandler(this.radioButtonMouse1_CheckedChanged);
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(376, 10);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(33, 23);
            this.buttonMore.TabIndex = 13;
            this.buttonMore.Text = "...";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 155);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Help";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 131);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "v1.4";
            // 
            // serialPortMain
            // 
            this.serialPortMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortMain_DataReceived);
            // 
            // panelIndicator1
            // 
            this.panelIndicator1.BackColor = System.Drawing.Color.Red;
            this.panelIndicator1.Location = new System.Drawing.Point(12, 14);
            this.panelIndicator1.Name = "panelIndicator1";
            this.panelIndicator1.Size = new System.Drawing.Size(5, 5);
            this.panelIndicator1.TabIndex = 1;
            // 
            // panelIndicator2
            // 
            this.panelIndicator2.BackColor = System.Drawing.Color.Red;
            this.panelIndicator2.Location = new System.Drawing.Point(12, 23);
            this.panelIndicator2.Name = "panelIndicator2";
            this.panelIndicator2.Size = new System.Drawing.Size(5, 5);
            this.panelIndicator2.TabIndex = 2;
            // 
            // checkBoxDoubleAction
            // 
            this.checkBoxDoubleAction.AutoSize = true;
            this.checkBoxDoubleAction.Checked = true;
            this.checkBoxDoubleAction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDoubleAction.Location = new System.Drawing.Point(280, 45);
            this.checkBoxDoubleAction.Name = "checkBoxDoubleAction";
            this.checkBoxDoubleAction.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDoubleAction.TabIndex = 17;
            this.checkBoxDoubleAction.Text = "Double Action";
            this.checkBoxDoubleAction.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTriqadafi
            // 
            this.pictureBoxTriqadafi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTriqadafi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTriqadafi.Image = global::CorelLASERBot.Properties.Resources.logo_small;
            this.pictureBoxTriqadafi.Location = new System.Drawing.Point(349, 177);
            this.pictureBoxTriqadafi.Name = "pictureBoxTriqadafi";
            this.pictureBoxTriqadafi.Size = new System.Drawing.Size(60, 20);
            this.pictureBoxTriqadafi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTriqadafi.TabIndex = 50;
            this.pictureBoxTriqadafi.TabStop = false;
            this.pictureBoxTriqadafi.Click += new System.EventHandler(this.pictureBoxTriqadafi_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 205);
            this.Controls.Add(this.pictureBoxTriqadafi);
            this.Controls.Add(this.checkBoxDoubleAction);
            this.Controls.Add(this.panelIndicator2);
            this.Controls.Add(this.panelIndicator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabelRefresh);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.comboBoxCOMPort);
            this.Controls.Add(this.labelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriqadafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.Panel panelIndicator1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panelIndicator2;
        private System.Windows.Forms.RadioButton radioButtonMouse2;
        private System.Windows.Forms.RadioButton radioButtonMouse1;
        private System.Windows.Forms.CheckBox checkBoxDoubleAction;
        private System.Windows.Forms.PictureBox pictureBoxTriqadafi;
    }
}

