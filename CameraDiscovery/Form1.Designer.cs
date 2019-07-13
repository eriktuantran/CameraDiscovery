namespace Parking
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
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.txtRtspUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(13, 66);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(741, 715);
            this.videoViewerWF1.TabIndex = 0;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1512, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(1042, 61);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(152, 82);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(810, 218);
            this.tb_cameraUrl.Multiline = true;
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.Size = new System.Drawing.Size(610, 87);
            this.tb_cameraUrl.TabIndex = 9;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(1268, 61);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(152, 82);
            this.btn_Disconnect.TabIndex = 10;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // txtRtspUrl
            // 
            this.txtRtspUrl.Location = new System.Drawing.Point(810, 389);
            this.txtRtspUrl.Multiline = true;
            this.txtRtspUrl.Name = "txtRtspUrl";
            this.txtRtspUrl.Size = new System.Drawing.Size(610, 121);
            this.txtRtspUrl.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Camera info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "RTSP link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 815);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoViewerWF1);
            this.Controls.Add(this.txtRtspUrl);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.tb_cameraUrl);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Dicsovery";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tb_cameraUrl;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox txtRtspUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

