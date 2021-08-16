using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kooli_andmbaas
{
    public partial class FormOpilased : Form
    {
        public static string klass;
        public static bool admin;
         public FormOpilased()
        {
            InitializeComponent();
            admin = FormAvaaken.admin; //

            if (admin)
            {
                //MessageBox.Show("Sa oled administraator");
                loadDataAd();
            }
            else
            {
                //MessageBox.Show("Sa  oled klassijuhataja"); 
                klass = FormAvaaken.klass;
                loadDataKl();
            }
                
        }
        //***************************************************************************************************************************************
        private void loadDataAd()
        {
            if (FormAvaaken.msserver)
            {
                DBms db = new DBms();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Opilased]  ORDER BY Perenimi", db.getconnection());
                db.openconnection();

                SqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewOp.Rows.Add(s);
            }
            else
            {
                DBmy db = new DBmy();
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.opilased order by Perenimi", db.GetConnection());
                db.openconnection();

                MySqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewOp.Rows.Add(s);
            }

        }
        //********************************************************************************************************************************************

        private void loadDataKl()
        {
            if (FormAvaaken.msserver)
            {
                DBms db = new DBms();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Opilased] WHERE Klass = '" + klass + "' ORDER BY Perenimi", db.getconnection());
                db.openconnection();

                SqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewOp.Rows.Add(s);
            }
            else
            {
                DBmy db = new DBmy();
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.opilased WHERE Klass = @kl order by Perenimi", db.GetConnection());
                command.Parameters.Add("@kl", MySqlDbType.VarChar).Value = klass;
                db.openconnection();

                MySqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewOp.Rows.Add(s);
            }
        }
        //********************************************************************************************************************************************

        private void dataGridViewOp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewOp.Rows[e.RowIndex];
            string isikukood = row.Cells[3].Value.ToString(); 

            if (FormAvaaken.msserver)
            {
                DBms db = new DBms();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Opilased] WHERE Isikukood = '" + isikukood + "'", db.getconnection());
                db.openconnection();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBoxPerenimi.Text = (reader[0].ToString());
                    textBoxEesnimi.Text = (reader[1].ToString());
                    textBoxKlass.Text = (reader[2].ToString());
                    textBoxIKood.Text = (reader[3].ToString());
                    textBoxSynniaeg.Text = (reader[4].ToString());  //võib ka nii ["Sünniaeg"] ehk siis tabeli välja nimi
                    textBoxORaamat.Text = (reader[6].ToString()); 
                    textBoxSynnikoht.Text = (reader[8].ToString());
                    textBoxEKoht.Text = (reader[9].ToString());
                    textBoxSkirjutus.Text = (reader[10].ToString());
                    comboBoxOValitsus.Text = (reader[11].ToString());
                    textBoxTelefon.Text = (reader[12].ToString());
                    textBoxMail.Text = (reader[13].ToString());
                    textBoxINimi.Text = (reader[15].ToString());
                    textBoxITelefon.Text = (reader[16].ToString());
                    textBoxIMail.Text = (reader[17].ToString());
                    textBoxENimi.Text = (reader[18].ToString());
                    textBoxETelefon.Text = (reader[19].ToString());
                    textBoxEMail.Text = (reader[20].ToString());
                    textBoxKLKordamine.Text = (reader[21].ToString());
                    textBoxSNr.Text = (reader[23].ToString());
                    textBoxKNr.Text = (reader[24].ToString());
                    string poiss = reader[7].ToString();
                    bool sugu = bool.Parse(poiss);
                    checkBoxPoiss.Checked = sugu;
                    if ((byte[])(reader["Foto"]) == null) //no ei  tööta raibe
                    {
                        MessageBox.Show("Pilt puudub!");
                    }
                    else
                    {
                        byte[] pilt = (byte[])reader["Foto"];
                        MemoryStream mstream = new MemoryStream(pilt);
                        pictureBoxFoto.Image = System.Drawing.Image.FromStream(mstream);
                    }

                }

            }
            else
            {
                DBmy db = new DBmy();
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.opilased WHERE Isikukood = @ik", db.GetConnection());
                command.Parameters.Add("@ik", MySqlDbType.VarChar).Value = isikukood;
                db.openconnection();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBoxPerenimi.Text = (reader[0].ToString());
                    textBoxEesnimi.Text = (reader[1].ToString());
                    textBoxKlass.Text = (reader[2].ToString());
                    textBoxIKood.Text = (reader[3].ToString());
                    textBoxSynniaeg.Text = (reader[4].ToString());
                    textBoxORaamat.Text = (reader[6].ToString());
                    textBoxSynnikoht.Text = (reader[8].ToString());
                    textBoxEKoht.Text = (reader[9].ToString());
                    textBoxSkirjutus.Text = (reader[10].ToString());
                    comboBoxOValitsus.Text = (reader[11].ToString());
                    textBoxTelefon.Text = (reader[12].ToString());
                    textBoxMail.Text = (reader[13].ToString());
                    textBoxINimi.Text = (reader[15].ToString());
                    textBoxITelefon.Text = (reader[16].ToString());
                    textBoxIMail.Text = (reader[17].ToString());
                    textBoxENimi.Text = (reader[18].ToString());
                    textBoxETelefon.Text = (reader[19].ToString());
                    textBoxEMail.Text = (reader[20].ToString());
                    textBoxKLKordamine.Text = (reader[21].ToString());
                    textBoxSNr.Text = (reader[23].ToString());
                    textBoxKNr.Text = (reader[24].ToString());
                    string poiss = reader[7].ToString(); // stringi muundamine bool-ks
                    bool sugu = bool.Parse(poiss);
                    checkBoxPoiss.Checked = sugu;
                    if ((byte[])(reader["Foto"]) == null) //no ei  tööta raibe
                    {
                        MessageBox.Show("Pilt puudub!");
                    }
                    else
                    {
                        byte[] pilt = (byte[])reader["Foto"];
                        MemoryStream mstream = new MemoryStream(pilt);
                        pictureBoxFoto.Image = System.Drawing.Image.FromStream(mstream);
                    }

                }
            }
        }

        private void buttonSulge_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
