using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        ClassData classData = new ClassData();

        public Form1()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (tNIM.Text != "" &&
                TNama.Text != "" &&
                TProdi.Text != "" &&
                TAngkatan.Text != "")
            {
                if (tNIM.Text.Length <= 12 &&
                TAngkatan.Text.Length <= 4 &&
                TProdi.Text.Length <= 30 &&
                TNama.Text.Length <= 20)
                {
                    try
                    {
                        string nim = tNIM.Text;
                        string nama = TNama.Text;
                        string prodi = TProdi.Text;
                        string angkatan = TAngkatan.Text;
                        classData.insertMahasiswa(nim, nama, prodi, angkatan);
                        dataGridView1.DataSource = classData.getAllData();
                        MessageBox.Show("Data successfuly inserted");
                    }
                    catch (Exception ex)
                    {
                        //label7.Text = "Server Error";
                    }
                }
                else
                {
                    MessageBox.Show("Please check your data");
                }
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }

        private void blihat_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = classData.getAllData();
            }
            catch
            {
               // label7.Text = "Server error";
            }
        }

        private void bSearchnim_Click(object sender, EventArgs e)
        {
            if (tNIM.Text != "")
            {
                string nim = tNIM.Text;
                List<Mahasiswa> mhs = new List<Mahasiswa>();
                mhs.Add(classData.search(nim));
                dataGridView1.DataSource = mhs;
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (tNIM.Text != "" &&
                TNama.Text != "" &&
                TProdi.Text != "" &&
                TAngkatan.Text != "")
            {
                if (tNIM.Text.Length <= 12 &&
                TAngkatan.Text.Length <= 4 &&
                TProdi.Text.Length <= 30 &&
                TNama.Text.Length <= 20)
                {
                    try
                    {
                        Mahasiswa mhs = new Mahasiswa();
                        mhs.nim = tNIM.Text;
                        mhs.nama = TNama.Text;
                        mhs.prodi = TProdi.Text;
                        mhs.angkatan = TAngkatan.Text;

                        ClassData classData = new ClassData();
                        classData.updateDatabase(mhs);
                        MessageBox.Show("Data successfuly updated");
  
                        dataGridView1.DataSource = classData.getAllData();
                    }
                    catch
                    {
                       // label7.Text = "Server Error";
                    }
                }
                else
                {
                    MessageBox.Show("Please check your data");
                }
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ClassData classData = new ClassData();
                    classData.deleteMahasiswa(tNIM.Text);
                    dataGridView1.DataSource = classData.getAllData();
                    MessageBox.Show("Data successfuly deleted");
                }
                catch (Exception ex)
                {
                  //  label7.Text = "Server Error";
                }
            }
        }

        private void bTotal_Click(object sender, EventArgs e)
        {
            try
            {
                string data = classData.sumData();
                label5.Enabled = true;
                label5.Text = data.ToString();
            }
            catch (Exception ex)
            {
                label6.Text = "Server Error";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            TNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            TProdi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            TAngkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}
