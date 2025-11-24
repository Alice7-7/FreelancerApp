using Freelance.Class;
using Freelance.Controllers;
using MySql.Data.MySqlClient;
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
    public partial class create_project : Form
    {


        public create_project(string username)
        {
            InitializeComponent();
          
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void project_submit_Click(object sender, EventArgs e)
        {
            Project newProject = new Project
            {
                Title = pj_title.Text,
                OrgName = org_name.Text,
                Description = pj_desc.Text,
                Deadline = pj_deadline.Text,
                Budget = decimal.Parse(pj_budget.Text),
                Prerequisites = pre_req.Text,
                ImageUrl = image_path.Text, 
                CreatedBy = Session_manage.Username
            };

            
            Project_control.UploadAndSaveProject(newProject,image_path.Text); 


            MessageBox.Show("Project posted!");
            this.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pj_image_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image_path.Text = ofd.FileName;
                pj_image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void create_project_Load(object sender, EventArgs e)
        {

        }
    }
}
