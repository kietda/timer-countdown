namespace PhanMemAutoShutdown2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbthaotac = new System.Windows.Forms.ComboBox();
            this.lbLuuy = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chbRepeat = new System.Windows.Forms.CheckBox();
            this.nudNumberOfRings = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfRings = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(189, 146);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Start";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Countdown Timer:";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(37, 151);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(59, 13);
            this.lbComment.TabIndex = 3;
            this.lbComment.Text = "lbComment";
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(87, 50);
            this.nudHour.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(41, 20);
            this.nudHour.TabIndex = 4;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(168, 50);
            this.nudMinute.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 20);
            this.nudMinute.TabIndex = 5;
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(253, 50);
            this.nudSecond.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(41, 20);
            this.nudSecond.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "minute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "second";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Command:";
            // 
            // cbthaotac
            // 
            this.cbthaotac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbthaotac.FormattingEnabled = true;
            this.cbthaotac.Location = new System.Drawing.Point(87, 110);
            this.cbthaotac.Name = "cbthaotac";
            this.cbthaotac.Size = new System.Drawing.Size(207, 21);
            this.cbthaotac.TabIndex = 11;
            this.cbthaotac.SelectedIndexChanged += new System.EventHandler(this.cbthaotac_SelectedIndexChanged);
            // 
            // lbLuuy
            // 
            this.lbLuuy.AutoSize = true;
            this.lbLuuy.ForeColor = System.Drawing.Color.Olive;
            this.lbLuuy.Location = new System.Drawing.Point(37, 151);
            this.lbLuuy.Name = "lbLuuy";
            this.lbLuuy.Size = new System.Drawing.Size(33, 13);
            this.lbLuuy.TabIndex = 12;
            this.lbLuuy.Text = "Note:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.toolStripMenuItem1.Text = "Chức năng mở";
            this.toolStripMenuItem1.Visible = false;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem2.Text = "Chức năng tắt";
            this.toolStripMenuItem2.Visible = false;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chbRepeat
            // 
            this.chbRepeat.AutoSize = true;
            this.chbRepeat.Location = new System.Drawing.Point(300, 112);
            this.chbRepeat.Name = "chbRepeat";
            this.chbRepeat.Size = new System.Drawing.Size(79, 17);
            this.chbRepeat.TabIndex = 14;
            this.chbRepeat.Text = "Repeated?";
            this.chbRepeat.UseVisualStyleBackColor = true;
            this.chbRepeat.Visible = false;
            // 
            // nudNumberOfRings
            // 
            this.nudNumberOfRings.Location = new System.Drawing.Point(304, 84);
            this.nudNumberOfRings.Name = "nudNumberOfRings";
            this.nudNumberOfRings.Size = new System.Drawing.Size(41, 20);
            this.nudNumberOfRings.TabIndex = 15;
            this.nudNumberOfRings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfRings
            // 
            this.lblNumberOfRings.AutoSize = true;
            this.lblNumberOfRings.Location = new System.Drawing.Point(220, 86);
            this.lblNumberOfRings.Name = "lblNumberOfRings";
            this.lblNumberOfRings.Size = new System.Drawing.Size(84, 13);
            this.lblNumberOfRings.TabIndex = 16;
            this.lblNumberOfRings.Text = "Number of rings:";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.Location = new System.Drawing.Point(113, 84);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(107, 21);
            this.txtPurpose.TabIndex = 17;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(215, 20);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(34, 13);
            this.lblDelay.TabIndex = 18;
            this.lblDelay.Text = "Delay";
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(253, 18);
            this.nudDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(43, 20);
            this.nudDelay.TabIndex = 19;
            // 
            // lblDelay2
            // 
            this.lblDelay2.AutoSize = true;
            this.lblDelay2.Location = new System.Drawing.Point(302, 20);
            this.lblDelay2.Name = "lblDelay2";
            this.lblDelay2.Size = new System.Drawing.Size(42, 13);
            this.lblDelay2.TabIndex = 20;
            this.lblDelay2.Text = "second";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 181);
            this.Controls.Add(this.lblDelay2);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.lblNumberOfRings);
            this.Controls.Add(this.nudNumberOfRings);
            this.Controls.Add(this.chbRepeat);
            this.Controls.Add(this.lbLuuy);
            this.Controls.Add(this.cbthaotac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Countdown Timer App - Danny D.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbthaotac;
        private System.Windows.Forms.Label lbLuuy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chbRepeat;
        private System.Windows.Forms.NumericUpDown nudNumberOfRings;
        private System.Windows.Forms.Label lblNumberOfRings;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Label lblDelay2;
    }
}

