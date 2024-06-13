
namespace Come334_Project
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVideoDescription = new System.Windows.Forms.TextBox();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.txtVideoId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVideoLink = new System.Windows.Forms.Label();
            this.lblVideoId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVideoDescription);
            this.groupBox1.Controls.Add(this.txtVideoLink);
            this.groupBox1.Controls.Add(this.txtVideoId);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblVideoLink);
            this.groupBox1.Controls.Add(this.lblVideoId);
            this.groupBox1.Location = new System.Drawing.Point(31, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Video";
            // 
            // txtVideoDescription
            // 
            this.txtVideoDescription.Location = new System.Drawing.Point(156, 179);
            this.txtVideoDescription.Multiline = true;
            this.txtVideoDescription.Name = "txtVideoDescription";
            this.txtVideoDescription.Size = new System.Drawing.Size(553, 41);
            this.txtVideoDescription.TabIndex = 6;
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(156, 124);
            this.txtVideoLink.Multiline = true;
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(553, 36);
            this.txtVideoLink.TabIndex = 5;
            // 
            // txtVideoId
            // 
            this.txtVideoId.Location = new System.Drawing.Point(156, 62);
            this.txtVideoId.Multiline = true;
            this.txtVideoId.Name = "txtVideoId";
            this.txtVideoId.Size = new System.Drawing.Size(553, 39);
            this.txtVideoId.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(351, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 23);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Video Description:";
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.Location = new System.Drawing.Point(12, 137);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(100, 23);
            this.lblVideoLink.TabIndex = 1;
            this.lblVideoLink.Text = "Youtube Link:";
            // 
            // lblVideoId
            // 
            this.lblVideoId.Location = new System.Drawing.Point(12, 78);
            this.lblVideoId.Name = "lblVideoId";
            this.lblVideoId.Size = new System.Drawing.Size(100, 23);
            this.lblVideoId.TabIndex = 0;
            this.lblVideoId.Text = "Youtube ID:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Video";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(614, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Add New Video";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVideoLink;
        private System.Windows.Forms.Label lblVideoId;
        private System.Windows.Forms.TextBox txtVideoDescription;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.TextBox txtVideoId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}