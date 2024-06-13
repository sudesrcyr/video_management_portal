
namespace Come334_Project
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVideoDescription = new System.Windows.Forms.TextBox();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.txtVideoId = new System.Windows.Forms.TextBox();
            this.lblVideoDescription = new System.Windows.Forms.Label();
            this.lblVideoLink = new System.Windows.Forms.Label();
            this.lblVideoId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Video";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(712, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtVideoDescription);
            this.groupBox1.Controls.Add(this.txtVideoLink);
            this.groupBox1.Controls.Add(this.txtVideoId);
            this.groupBox1.Controls.Add(this.lblVideoDescription);
            this.groupBox1.Controls.Add(this.lblVideoLink);
            this.groupBox1.Controls.Add(this.lblVideoId);
            this.groupBox1.Location = new System.Drawing.Point(30, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 379);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Video";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVideoDescription
            // 
            this.txtVideoDescription.Location = new System.Drawing.Point(141, 226);
            this.txtVideoDescription.Multiline = true;
            this.txtVideoDescription.Name = "txtVideoDescription";
            this.txtVideoDescription.Size = new System.Drawing.Size(635, 33);
            this.txtVideoDescription.TabIndex = 5;
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(141, 150);
            this.txtVideoLink.Multiline = true;
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(635, 33);
            this.txtVideoLink.TabIndex = 4;
            // 
            // txtVideoId
            // 
            this.txtVideoId.Location = new System.Drawing.Point(141, 66);
            this.txtVideoId.Multiline = true;
            this.txtVideoId.Name = "txtVideoId";
            this.txtVideoId.Size = new System.Drawing.Size(635, 33);
            this.txtVideoId.TabIndex = 3;
            // 
            // lblVideoDescription
            // 
            this.lblVideoDescription.Location = new System.Drawing.Point(8, 236);
            this.lblVideoDescription.Name = "lblVideoDescription";
            this.lblVideoDescription.Size = new System.Drawing.Size(127, 23);
            this.lblVideoDescription.TabIndex = 2;
            this.lblVideoDescription.Text = "Video Description:";
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.Location = new System.Drawing.Point(8, 153);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(100, 23);
            this.lblVideoLink.TabIndex = 1;
            this.lblVideoLink.Text = "Youtube Link:";
            // 
            // lblVideoId
            // 
            this.lblVideoId.Location = new System.Drawing.Point(8, 66);
            this.lblVideoId.Name = "lblVideoId";
            this.lblVideoId.Size = new System.Drawing.Size(100, 23);
            this.lblVideoId.TabIndex = 0;
            this.lblVideoId.Text = "Youtube ID:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Video Update";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVideoDescription;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.TextBox txtVideoId;
        private System.Windows.Forms.Label lblVideoDescription;
        private System.Windows.Forms.Label lblVideoLink;
        private System.Windows.Forms.Label lblVideoId;
    }
}