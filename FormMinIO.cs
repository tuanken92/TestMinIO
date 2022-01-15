using Minio;
using Minio.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMinIO
{
    public partial class FormMinIO : Form
    {

        MinioClient minio = null;
        string url = "192.168.3.11:9000";
        string user = "admin";
        string pass = "tanhungha";
        bool is_connected = false;

        public FormMinIO()
        {
            InitializeComponent();
            GetInfor();
        }

        


        string file_name = "";
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                file_name = openFileDialog.FileName;
                lb_path.Text = file_name;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

            GetInfor();
            minio = new MinioClient(url, user, pass);
            // Set app Info 
            minio.SetAppInfo("app-name", "app-version");

            // Create an async task for listing buckets.
            var getListBucketsTask = minio.ListBucketsAsync();

            try
            {
                // Iterate over the list of buckets.
                if (getListBucketsTask.Status == TaskStatus.RanToCompletion)
                {
                    foreach (Bucket bucket in getListBucketsTask.Result.Buckets)
                    {
                        Console.WriteLine(bucket.Name + " " + bucket.CreationDateDateTime);
                    }
                }
                is_connected = true;
                MessageBox.Show("Connected!");
            }
            catch (Exception ex)
            {
                is_connected = false;
                Console.WriteLine(ex.Message);
                MessageBox.Show("Can't connect!");
            }
        }


        void GetInfor()
        {
            url = txt_url.Text;
            user = txt_user.Text;
            pass = txt_password.Text;
        }

        private void btn_check_exist_Click(object sender, EventArgs e)
        {
            var bucket_name = txt_bucket_name.Text;
            

            try
            {
                var getBucketExistTask = minio.BucketExistsAsync(bucket_name);
                if (getBucketExistTask.Status != TaskStatus.RanToCompletion)
                    return;

                bool found = getBucketExistTask.Result;
                MessageBox.Show((found ? "Found" : "Couldn't find ") + "bucket " + bucket_name);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_create_bucket_Click(object sender, EventArgs e)
        {
            var bucket_name = txt_bucket_name.Text;
            

            //try
            //{
            //    var getBucketCreateTask = minio.MakeBucketAsync(bucket_name);
            //    if (getBucketCreateTask.Status != TaskStatus.RanToCompletion)
            //        return;

            //    bool found = getBucketCreateTask.Res;
            //    MessageBox.Show((found ? "Found" : "Couldn't find ") + "bucket " + bucket_name);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
