using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (cb1Biola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cb2Gitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cb3Saxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cb4Konduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cb5Piano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cb6Drum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cb7Vokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (cb8Komposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            /*
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            var again = true;

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                again = false;
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            while (again)
            {
                if (cb1Biola.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb2Gitar.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb3Saxophone.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb4Konduktor.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb5Piano.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb6Drum.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb7Vokal.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cb8Komposer.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtpTL.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else
                {
                    MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    again = false;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
