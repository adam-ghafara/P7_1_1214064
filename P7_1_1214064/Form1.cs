using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;

namespace P7_1_1214064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(760, 270);
        }

        private void btPilihkuliah_Click(object sender, EventArgs e)
        {
            if ((tbNIM.Text) != "")
            {
                if ((tbNama.Text) != "")
                {
                    if (rbLaki.Checked || rbPerempuan.Checked)
                    {
                        if ((rtbAlamat.Text) != "")
                        {
                            if ((cboxProdi.Text) != "")
                            {
                                if (Regex.IsMatch(tbAkademik.Text, @"^\d{4}/\d{4}$"))
                                {
                                    if ((tbSemester.Text.All(Char.IsLetter)))
                                    {
                                        SystemSounds.Exclamation.Play();
                                        MessageBox.Show("Format Semester Salah", "Peringatan",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else if ((tbSemester.Text) != "")
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("Sudah Lengkap! Lanjutkan dengan mengisi Kurikulum dan Mata Kuliah", "Peringatan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        this.Size = new Size(760, 559);
                                    }
                                    else
                                    {
                                        SystemSounds.Exclamation.Play();
                                        MessageBox.Show("Semester Belum Di isi.", "Peringatan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else if (Regex.IsMatch(tbAkademik.Text, @""))
                                {
                                    SystemSounds.Exclamation.Play();
                                    MessageBox.Show("Format Tahun Akademik Salah", "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                if ((tbAkademik.Text) != "")
                                {

                                }
                                else
                                {
                                    SystemSounds.Exclamation.Play();
                                    MessageBox.Show("Tahun Akademik Belum Di isi.", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                SystemSounds.Exclamation.Play();
                                MessageBox.Show("Program Studi Belum Di isi.", "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            SystemSounds.Exclamation.Play();
                            MessageBox.Show("Alamat Belum Di isi.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Kelamin Belum di pilih.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Nama Belum Di isi.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("NIM Belum Di isi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbAkademik_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                errorProvider.SetError(tbAkademik, "");
            }
            else
            {
                errorProvider.SetError(tbAkademik, "Format Tahun Akademik Salah");
                
            }
        }
        string gender = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked)
            {
                gender = "Laki-Laki";
                rbPerempuan.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked)
            {
                gender = "Perempuan";
                rbLaki.Checked = false;
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if ((tbSemester.Text).All(Char.IsNumber))
            {
                errorProvider.SetError(tbSemester, "");

            }
            else
            {
                errorProvider.SetError(tbSemester, "Input Hanya Boleh Angka");

            }
        }

        string kurikulum = "";
        private void rbK2006_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK2006.Checked)
            {
                kurikulum = "Kurikulum 2006";
                rbK2010.Checked = false;
                rbK2014.Checked = false;
                cbLogistik.Enabled = false; cbLogistik.Checked = false;
                cbMrp.Enabled = false; cbMrp.Checked = false;
                cbMatematika.Enabled = true;

            }
        }

        private void rbK2010_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK2010.Checked)
            {
                kurikulum = "Kurikulum 2010";
                rbK2006.Checked = false;
                rbK2014.Checked = false;
                cbLogistik.Enabled = false; cbLogistik.Checked = false;
                cbMatematika.Enabled = false; cbMatematika.Checked = false;
                cbMrp.Enabled = true;
            }
        }

        private void rbK2014_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK2014.Checked)
            {
                kurikulum = "Kurikulum 2014";
                rbK2006.Checked = false;
                rbK2010.Checked = false;
                cbMatematika.Enabled = false; cbMatematika.Checked = false;
                cbMrp.Enabled = false; cbMrp.Checked = false;
                cbLogistik.Enabled = true;
            }
        }
        string matkulMTK = "";
        string matkulPem1 = "";
        string matkulPem2 = "";
        string matkulPem3 = "";
        string matkulPem4 = "";
        string matkulPem5 = "";
        string matkulPem6 = "";
        string matkulPem7 = "";
        string matkulLog = "";
        string matkulJar = "";
        string matkulSys = "";
        string matkulMrp = "";
        private void cbMatematika_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMatematika.Checked)
            {
                matkulMTK = "Matematika, ";
            }
            else
            {
                matkulMTK = "";
            }
        }

        private void cbPem1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem1.Checked)
            {
                matkulPem1 = "Pemrograman 1, ";
            }
            else
            {
                matkulPem1 = "";
            }
        }

        private void cbPem2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem2.Checked)
            {
                matkulPem2 = "Pemrograman 2, ";
            }
            else
            {
                matkulPem2 = "";
            }
        }

        private void cbPem3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem3.Checked)
            {
                matkulPem3 = "Pemrograman 3, ";
            }
            else
            {
                matkulPem3 = "";
            }
        }

        private void cbPem4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem4.Checked)
            {
                matkulPem4 = "Pemrograman 4, ";
            }
            else
            {
                matkulPem4 = "";
            }
        }

        private void cbPem5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem5.Checked)
            {
                matkulPem5 = "Pemrograman 5, ";
            }
            else
            {
                matkulPem5 = "";
            }
        }

        private void cbPem6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem6.Checked)
            {
                matkulPem6 = "Pemrograman 6, ";
            }
            else
            {
                matkulPem6 = "";
            }
        }

        private void cbPem7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPem7.Checked)
            {
                matkulPem7 = "Pemrograman 7, ";
            }
            else
            {
                matkulPem7 = "";
            }
        }

        private void cbLogistik_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLogistik.Checked)
            {
                matkulLog = "Pengantar Logistik, ";
            }
            else
            {
                matkulLog = "";
            }
        }

        private void cbJaringan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJaringan.Checked)
            {
                matkulJar = "Jaringan Komputer, ";
            }
            else
            {
                matkulJar = "";
            }
        }

        private void cbSysop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSysop.Checked)
            {
                matkulSys = "Sistem Operasi, ";
            }
            else
            {
                matkulSys = "";
            }
        }

        private void cbMrp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMrp.Checked)
            {
                matkulMrp = "Manajemen Rantai Pasok";
            }
            else
            {
                matkulMrp = "";
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
                MessageBox.Show("\nNIM: " + tbNIM.Text
                    + "\nNama: " + tbNama.Text
                    + "\nJenis Kelamin: " + gender
                    + "\nAlamat: " + rtbAlamat.Text
                    + "\nProgram Studi: " + cboxProdi.Text
                    + "\nTahun Akademik: " + tbAkademik.Text
                    + "\nSemester: " + tbSemester.Text
                    + "\n==========================================="
                    + "\nKurikulum: " + kurikulum
                    + "\nMata Kuliah: " + matkulMTK + matkulPem1 + matkulPem2 + matkulPem3 
                    + matkulPem4 + matkulPem5 + matkulPem6 + matkulPem7 + matkulLog 
                    + matkulJar + matkulSys + matkulMrp, "Informasi Data Submit", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Form telah di reset.", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            foreach (Control clear in Controls)
            {
                if (clear is TextBox)
                {
                    clear.Text = "";
                    if (clear is CheckBox)
                    {
                        ((CheckBox)clear).Checked = false;
                        if (clear is ComboBox)
                        {
                            clear.Text = string.Empty;
                            if (clear is RichTextBox)
                            {
                                clear.Text = string.Empty;
                                if (clear is RadioButton)
                                {
                                    ((RadioButton)clear).Checked = false;
                                }
                            }
                        }
                    }
                }
            }
            this.Size = new Size(760, 270);
        }
    }
}
