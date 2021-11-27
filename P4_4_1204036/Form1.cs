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

namespace P4_4_1204036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int txtUmurLength = 2;

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Textbox Huruf tidak boleh kosong!"); //Char TextBox, Required Validator
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if(txtNama.Text != txtNama.Text.ToUpper()) //Upper Case Validator
                {
                    epWrong.SetError(txtNama, "Harus Menggunakan Huruf Kapital!");
                    epWarning.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");

                }
                else if ((txtNama.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul!");
                }
                 else 
                {
                    epWrong.SetError(txtNama, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");

                }
            }
        }
        


        private void txtUmur_TextChanged(object sender, EventArgs e)
        {
            if(txtUmur.Text.Length > 2)
            {
                epWarning.SetError(txtUmur, "Kolom umur hanya boleh 2 digit angka!");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "");
            }
            else if ((txtUmur.Text).All(Char.IsNumber)) //Numeric TextBox
            {
                epWarning.SetError(txtUmur, "");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "Betul!");
            }
            else
            {
                epWrong.SetError(txtUmur, "Inputan hanya boleh huruf!");
                epWarning.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "");
            }

            if (txtUmur.Text == "")
            {
                epWarning.SetError(txtUmur, "Kolom angka tidak boleh kosong!");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "");
            }
            if (txtUmur.Text != "") //Comparison
            {
                if ((int.Parse(txtUmur.Text) <= 6 ))
                {
                    epWarning.SetError(txtUmur, "");
                    epWrong.SetError(txtUmur, "Umur harus lebih dari 6 tahun!!");
                    epCorrect.SetError(txtUmur, "");
                }
                else { }
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$")) //Regex Validator
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email Salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");
            }
            else
            {
                if ((txtAlamat.Text != txtAlamat.Text.ToLower())) //Lower Case
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "Harus menggunakan huruf kecil!");
                    epCorrect.SetError(txtAlamat, "");
                }
                else if ((txtAlamat.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAlamat, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "Nama : " + txtNama.Text +
           "\nEmail : " + txtEmail.Text +
           "\nUmur : " + txtUmur.Text +
           "\nAlamat : " + txtAlamat.Text,
           "Informasi Pendataan Siswa Baru", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
