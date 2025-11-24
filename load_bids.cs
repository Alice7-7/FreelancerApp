using Freelance.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance
{
    public partial class load_bids : Form
    {
        public load_bids()
        {
            InitializeComponent();

        }


        private void LoadMyBids()
        {
            load_bids_flow.Controls.Clear();

            var myBids = Project_control.GetBidProjectsByFreelancer(Session_manage.Username);

            foreach (var bid in myBids)
            {
                int projectId = (int)bid["ProjectId"];
                string title = bid["Title"].ToString();
                string description = bid["Description"].ToString();
                decimal budget = (decimal)bid["Budget"];
                string imageUrl = bid["ImageUrl"].ToString();
                string status = bid["Status"].ToString();
               
                bool isCompleted = (bool)bid["IsCompleted"];

                Panel card = new Panel
                {
                    Width = 800,
                    Height = 370,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                PictureBox icon = new PictureBox
                {
                    Width = 110,
                    Height = 110,
                    Location = new Point(10, 10),
                    ImageLocation = imageUrl,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                card.Controls.Add(icon);

                card.Controls.Add(new Label
                {
                    Text = title,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Location = new Point(150, 10),
                    AutoSize = true
                });

                card.Controls.Add(new Label
                {
                    Text = $"Description: {description}",
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(150, 90),
                    Size = new Size(600, 50),
                    AutoEllipsis = true
                });

                card.Controls.Add(new Label
                {
                    Text = $"💰 Budget: ${budget:0.00}",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Location = new Point(150, 140),
                    AutoSize = true
                });

               

                card.Controls.Add(new Label
                {
                    Text = $"📌 Status: {status}",
                    Font = new Font("Bell MT", 10, FontStyle.Bold),
                    ForeColor = status == "accepted" ? Color.Green : Color.Gray,
                    Location = new Point(150, 220),
                    AutoSize = true
                });

                if (status == "accepted" && !isCompleted)
                {
                    Button completeBtn = new Button
                    {
                        Text = "Mark as Complete",
                        Width = 250,
                        Height = 70,
                        Font = new Font("Bell MT", 10, FontStyle.Bold),
                        BackColor = Color.DarkCyan,
                        ForeColor = Color.White,
                        
                        Location = new Point(150, 260),
                        Tag = projectId
                    };

                    completeBtn.Click += (s, ev) =>
                    {
                        int projId = (int)((Button)s).Tag;

                        if (Project_control.MarkAsComplete(projId))
                        {
                            MessageBox.Show("Project marked as complete! 🎉");
                            LoadMyBids();
                        }
                        else
                        {
                            MessageBox.Show("Failed to mark project as complete.");
                        }
                    };

                    card.Controls.Add(completeBtn);
                }

                load_bids_flow.Controls.Add(card);
            }
        }


        private void load_bids_Load(object sender, EventArgs e)
        {
            LoadMyBids();
        }
    }
}
