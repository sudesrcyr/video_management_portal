
namespace Come334_Project
{
    partial class Form2
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
            this.videoListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewVideo = new System.Windows.Forms.Button();
            this.panelVideoInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVideoInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelVideoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoListView
            // 
            this.videoListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.videoListView.HideSelection = false;
            this.videoListView.Location = new System.Drawing.Point(0, 0);
            this.videoListView.Name = "videoListView";
            this.videoListView.Size = new System.Drawing.Size(812, 716);
            this.videoListView.TabIndex = 0;
            this.videoListView.UseCompatibleStateImageBehavior = false;
            this.videoListView.SelectedIndexChanged += new System.EventHandler(this.videoListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(818, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 302);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAddNewVideo
            // 
            this.btnAddNewVideo.Location = new System.Drawing.Point(1410, 16);
            this.btnAddNewVideo.Name = "btnAddNewVideo";
            this.btnAddNewVideo.Size = new System.Drawing.Size(157, 32);
            this.btnAddNewVideo.TabIndex = 3;
            this.btnAddNewVideo.Text = "Add New Video";
            this.btnAddNewVideo.UseVisualStyleBackColor = true;
            this.btnAddNewVideo.Click += new System.EventHandler(this.btnAddNewVideo_Click);
            // 
            // panelVideoInfo
            // 
            this.panelVideoInfo.Controls.Add(this.label2);
            this.panelVideoInfo.Controls.Add(this.lblVideoInfo);
            this.panelVideoInfo.Controls.Add(this.btnDelete);
            this.panelVideoInfo.Controls.Add(this.pictureBox1);
            this.panelVideoInfo.Controls.Add(this.btnOpen);
            this.panelVideoInfo.Controls.Add(this.btnUpdate);
            this.panelVideoInfo.Location = new System.Drawing.Point(875, 78);
            this.panelVideoInfo.Name = "panelVideoInfo";
            this.panelVideoInfo.Size = new System.Drawing.Size(692, 584);
            this.panelVideoInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(62, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 63);
            this.label2.TabIndex = 9;
            // 
            // lblVideoInfo
            // 
            this.lblVideoInfo.AutoSize = true;
            this.lblVideoInfo.Location = new System.Drawing.Point(276, 270);
            this.lblVideoInfo.Name = "lblVideoInfo";
            this.lblVideoInfo.Size = new System.Drawing.Size(0, 17);
            this.lblVideoInfo.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(68, 527);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 36);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(279, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 716);
            this.Controls.Add(this.panelVideoInfo);
            this.Controls.Add(this.btnAddNewVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoListView);
            this.Name = "Form2";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelVideoInfo.ResumeLayout(false);
            this.panelVideoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView videoListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNewVideo;
        private System.Windows.Forms.Panel panelVideoInfo;
        private System.Windows.Forms.Label lblVideoInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}