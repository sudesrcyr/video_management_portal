using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Come334_Project
{
    public partial class Form4 : Form
    {
        private string editVideoId;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string videoId, string videoLink, string description) : this()
        {
            editVideoId = videoId;
            txtVideoId.Text = videoId;
            txtVideoLink.Text = videoLink;
            txtVideoDescription.Text = description;
            txtVideoId.ReadOnly = true; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string videoLink = txtVideoLink.Text;
            string description = txtVideoDescription.Text;

            
            if (string.IsNullOrWhiteSpace(videoLink) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            
            if (videoLink.Contains("|") || description.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the '|' character.");
                return;
            }

            string filePath = "video.csv";
            var lines = File.Exists(filePath) ? File.ReadAllLines(filePath).ToList() : new List<string>();

           
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split('|');
                if (parts[0] == editVideoId)
                {
                    parts[1] = videoLink;
                    parts[2] = description;
                    parts[3] = DateTime.Now.ToString("yyyy.MM.dd HH:mm");
                    parts[4] = "0"; 
                    lines[i] = string.Join("|", parts);
                    break;
                }
            }

            try
            {
                
                if (File.Exists(filePath))
                {
                    FileAttributes attributes = File.GetAttributes(filePath);
                    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        MessageBox.Show("File is read-only.");
                        return;
                    }
                }

                
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Video updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating video: {ex.Message}");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
