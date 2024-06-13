using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Come334_Project
{
    public partial class Form2 : Form
    {
        private Timer timer;

        public Form2()
        {
            InitializeComponent();
            InitializeListView();
            InitializeTimer();

            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void InitializeListView()
        {
            videoListView.View = View.Details;
            videoListView.FullRowSelect = true;
            videoListView.Columns.Add("ID", 100);
            videoListView.Columns.Add("Link", 250);
            videoListView.Columns.Add("Description", 300);
            videoListView.Columns.Add("Date Added", 150);
            LoadVideos();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 15000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadVideos();
            UpdateInfoLabel();
        }

        private void LoadVideos()
        {
            string filePath = "video.csv";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Video file not found!");
                return;
            }

            videoListView.Items.Clear();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length >= 5 && parts[4] == "0")
                {
                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    item.SubItems.Add(parts[2]);
                    item.SubItems.Add(parts[3]);
                    videoListView.Items.Add(item);
                }
            }
        }

        private void UpdateInfoLabel()
        {
            string filePath = "video.csv";
            var lines = File.ReadAllLines(filePath);
            int totalVideos = lines.Length;
            int deletedVideos = lines.Count(line =>
            {
                var parts = line.Split('|');
                return parts.Length >= 5 && parts[4] == "1";
            });
            int savedVideos = totalVideos - deletedVideos;

            lblVideoInfo.Text = $"There are {savedVideos} saved videos. There are also {deletedVideos} deleted videos. Last update date is {DateTime.Now.ToString("yyyy.MM.dd HH:mm")}";
        }

        private void videoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                string videoId = selectedItem.SubItems[0].Text;
                string videoLink = selectedItem.SubItems[1].Text;
                string videoDescription = selectedItem.SubItems[2].Text;

                string imageUrl = $"https://img.youtube.com/vi/{videoId}/default.jpg";

                try
                {
                    pictureBox1.Load(imageUrl);
                    pictureBox1.Tag = videoLink;
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("Thumbnail image could not be loaded. The video might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblVideoInfo.Text = $"ID: {videoId}\nLink: {videoLink}\nDescription: {videoDescription}";
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                string videoLink = selectedItem.SubItems[1].Text;
                System.Diagnostics.Process.Start(videoLink);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                string videoId = selectedItem.SubItems[0].Text;
                string videoLink = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;

                Form4 form4 = new Form4(videoId, videoLink, description);
                form4.ShowDialog();
                LoadVideos();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                string videoId = selectedItem.SubItems[0].Text;

                
                DialogResult result = MessageBox.Show("Are you sure you want to remove this video?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        
                        string filePath = "video.csv";
                        var lines = File.ReadAllLines(filePath).ToList();
                        bool videoFound = false;

                        for (int i = 0; i < lines.Count; i++)
                        {
                            var parts = lines[i].Split('|');
                            if (parts[0] == videoId)
                            {
                                parts[4] = "1";
                                lines[i] = string.Join("|", parts);
                                videoFound = true;
                                break;
                            }
                        }

                        if (videoFound)
                        {
                            File.WriteAllLines(filePath, lines);
                            MessageBox.Show("Video deleted successfully.");
                            LoadVideos(); 
                        }
                        else
                        {
                            MessageBox.Show("Video not found in the file.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the video: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a video to delete.");
            }
        }


        private void btnAddNewVideo_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            LoadVideos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag != null)
            {
                string videoUrl = pictureBox1.Tag.ToString();
                System.Diagnostics.Process.Start(videoUrl);
            }
        }

    }
}

