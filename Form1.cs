// extending: when it rings (timer goes to 0), call another thread, so we can stop ringing immediately
// reference:
// https://www.geeksforgeeks.org/how-to-terminate-a-thread-in-c-sharp/
//https://stackoverflow.com/questions/11873378/adding-placeholder-text-to-textbox
//http://coderzen.blogspot.com/2013/09/c-net-textbox-gotfocus-event.html
//https://docs.microsoft.com/en-us/visualstudio/ide/how-to-specify-an-application-icon-visual-basic-csharp?view=vs-2019
//https://icoconvert.com/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Media;
using System.Threading;


namespace PhanMemAutoShutdown2
{
    public partial class Form1 : Form
    {
        int thoigian;
        string mPurpose = "Purpose...";
        // Creating instance for mythread() method 
        FirstThread obj = new FirstThread();
        // Creating threads 
        Thread thr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbComment.Text= "";
            lbLuuy.Text = "";
            cbthaotac.Items.Add("Shutdown");
            cbthaotac.Items.Add("Hibernate");
            cbthaotac.Items.Add("Turn off screen");
            cbthaotac.Items.Add("Turn off screen by hotkey");
            cbthaotac.Items.Add("Timer Notice");
            cbthaotac.SelectedIndex = 4;
            txtPurpose.Text = mPurpose;
            txtPurpose.GotFocus += new System.EventHandler(this.RemoveText);
            txtPurpose.LostFocus += new System.EventHandler(this.AddText);

        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (txtPurpose.Text == mPurpose)
            {
                txtPurpose.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
                txtPurpose.Text = mPurpose;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            thoigian = ((int)nudHour.Value * 3600 + (int)nudMinute.Value * 60 + (int)nudSecond.Value + (int)nudDelay.Value) * 10;
            btnOK.Enabled = false;
            nudSecond.Enabled = false;
            nudMinute.Enabled = false;
            nudHour.Enabled = false;           
            timer1.Enabled = true; //let timer begin
            btnCancel.Enabled = true;
            cbthaotac.Enabled = false;
            //chbRepeat.Enabled = false;
            //txtPurpose.Enabled = false;
            nudDelay.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (thoigian > 0)
                {
                    thoigian--;
                    if (thoigian % 10 == 0)
                    {
                        int tThoiGianSecond = thoigian / 10;
                        int tHour = tThoiGianSecond / 3600;
                        int tMinute = tThoiGianSecond / 60 - tHour * 60;
                        int tSecond = tThoiGianSecond - tHour * 3600 - tMinute * 60;

                        lbComment.Text = "Remaining: " + tHour + ":" + tMinute + ":" + tSecond ;
                    }
                }
                else
                {
                    switch (cbthaotac.SelectedIndex)
                    {
                        case 0:
                            btnCancel_Click(sender, e);
                            System.Diagnostics.Process.Start("shutdown", "/s");
                            MessageBox.Show("Timer is over. Shutting down...");
                            break;
                        case 1:
                            btnCancel_Click(sender, e);
                            Application.SetSuspendState(PowerState.Hibernate, true, true);
                            MessageBox.Show("Timer is over. Hibernating....");
                            break;
                        case 2:
                            btnCancel_Click(sender, e);
                            PowerBoard.TurnOffLCD();
                            break;
                        case 3:
                            lbComment.Text = "";
                            btnCancel.Enabled = false;
                            btnOK.Enabled = false;
                            toolStripMenuItem2_Click(sender, e);
                            break;
                        case 4:        
                            if (chbRepeat.Checked == true)
                            {
                                thoigian = ((int)nudHour.Value * 3600 + (int)nudMinute.Value * 60 + (int)nudSecond.Value) * 10;
                            }
                            else
                                btnCancel_Click(sender, e);

                            //initializing thread which already created before
                            if (thr == null || obj.mParameter == 0)    // if we dont' check it & thoigan < #rings, it will point to another thread, and old threads can't stop
                            {                                
                                obj.mParameter = (int)nudNumberOfRings.Value;
                                thr = new Thread(new ThreadStart(obj.thread));
                                thr.Start();
                            }
                            if (((int)nudHour.Value * 3600 + (int)nudMinute.Value * 60 + (int)nudSecond.Value) > 5)                                
                                MessageBox.Show(new Form { TopMost = true }, "Time is over: " + txtPurpose.Text, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                           
                            break;                            
                    }
                
                 }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnOK.Enabled = true;
            nudHour.Enabled = true;
            nudMinute.Enabled = true;
            nudSecond.Enabled = true;
            lbComment.Text = "";
            timer1.Enabled = false;
            cbthaotac.Enabled = true;
            chbRepeat.Enabled = true;
            txtPurpose.Enabled = true;
            nudDelay.Enabled = true;
            if (thr != null)
            {
                thr.Abort();
                thr = null;

            }
        }

        private void cbthaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbthaotac.SelectedIndex == 3)
            {
                lbLuuy.Text = "Importance: Press \"Ctrl + O\" to turn on, \"Ctrl + H\" to turn off screen ";
                if (btnOK.Location.Y == 146)
                {
                for (int y = 146; y <= 184; y += 2)
                {
                    btnOK.Location = new Point(189, y);
                    btnCancel.Location = new Point(270, y);
                    lbComment.Location = new Point(37, y);
                    this.Size = new Size(410, y + 73);
                }
                }

            }
            else
            {
                lbLuuy.Text = "";
                if (btnOK.Location.Y == 184)
                {
                    for (int y = 184; y >= 146; y -= 2)
                    {
                        btnOK.Location = new Point(189, y);
                        btnCancel.Location = new Point(270, y);
                        lbComment.Location = new Point(37, y);
                        this.Size = new Size(410, y + 73);
                    }
                }
            }
            if (cbthaotac.SelectedIndex == 4)
            {
                chbRepeat.Visible = true;
                lblNumberOfRings.Visible = true;
                nudNumberOfRings.Visible = true;
                txtPurpose.Visible = true;
                nudDelay.Visible = true;
                lblDelay.Visible = true;
                lblDelay2.Visible = true;
                
            }
            else
            {
                chbRepeat.Visible = false;
                lblNumberOfRings.Visible = false;
                nudNumberOfRings.Visible = false;
                txtPurpose.Visible = false;
                nudDelay.Visible = false;
                lblDelay.Visible = false;
                lblDelay2.Visible = false;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cbthaotac.SelectedIndex == 3)
            {
                btnCancel_Click(sender, e);
                int w = 386;
                int h = 257;
                this.Location = new Point(200, 200);
                this.Size = new Size(w, h);
                FormBorderStyle = FormBorderStyle.Sizable;
                btnOK.Visible = true;
                btnCancel.Visible = true;
                label1.Visible = true;
                lbComment.Visible = true;
                nudHour.Visible = true;
                nudMinute.Visible = true;
                nudSecond.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;               
                label2.Visible = true;
                cbthaotac.Visible = true;
                lbLuuy.Visible = true;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cbthaotac.SelectedIndex = 3;
            PowerBoard.TurnOffLCD();
            if (thoigian > 0)
                thoigian = 0;
            if (timer1.Enabled == false)
            {
            timer1.Enabled = true;
            }
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
           // this.ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            btnOK.Visible =false;
            btnCancel.Visible = false;
            label1.Visible = false;
            lbComment.Visible = false;
            nudHour.Visible = false;
            nudMinute.Visible = false;
            nudSecond.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;           
            label2.Visible = false;
            cbthaotac.Visible = false;
            lbLuuy.Visible = false;
      

        }


    }
}
