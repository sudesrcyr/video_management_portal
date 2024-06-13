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
    public partial class Form3 : Form
    {
        private bool isEditMode;
        private string editVideoId;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string videoId, string videoLink, string description) : this()
        {
            isEditMode = true;
            editVideoId = videoId;
            txtVideoId.Text = videoId;
            txtVideoLink.Text = videoLink;
            txtVideoDescription.Text = description;
            txtVideoId.ReadOnly = true; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string videoId = txtVideoId.Text;
            string videoLink = txtVideoLink.Text;
            string description = txtVideoDescription.Text;

            
            if (string.IsNullOrWhiteSpace(videoId) || string.IsNullOrWhiteSpace(videoLink) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            
            if (videoId.Contains("|") || videoLink.Contains("|") || description.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the '|' character.");
                return;
            }

            string filePath = "video.csv";
            var lines = File.Exists(filePath) ? File.ReadAllLines(filePath).ToList() : new List<string>();

            if (isEditMode)
            {
                
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
            }
            else
            {
                
                string newLine = $"{videoId}|{videoLink}|{description}|{DateTime.Now.ToString("yyyy.MM.dd HH:mm")}|0";
                lines.Add(newLine);
            }

            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Video saved successfully.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
