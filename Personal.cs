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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            loadData();
            
        }
        private void loadData()
        {
            if (FormAvaaken.msserver)
            {
                DBms db = new DBms();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Personal] ORDER BY Perenimi", db.getconnection());
                db.openconnection();

                SqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();

                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewPe.Rows.Add(s);
            }
            else
            {
                DBmy db = new DBmy();
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.Personal order by Perenimi", db.GetConnection());
                db.openconnection();

                MySqlDataReader reader = command.ExecuteReader();
                List<String[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    
                }
                reader.Close();
                db.closeconnection();

                foreach (string[] s in data)
                    dataGridViewPe.Rows.Add(s);
            }

        }

        private void dataGridViewPe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewPe.Rows[e.RowIndex];
            string isikukood = row.Cells[2].Value.ToString();

            if (FormAvaaken.msserver)
            {
                DBms db = new DBms();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Personal] WHERE Isikukood = '" + isikukood + "'", db.getconnection());
                db.openconnection();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBoxPerenimi.Text = (reader[0].ToString());
                    textBoxEesnimi.Text = (reader[1].ToString());
                    textBoxIKood.Text = (reader[2].ToString());
                    textBoxSynniaeg.Text = (reader[3].ToString());
                    textBoxTelefon.Text = (reader[4].ToString());
                    textBoxMobiil.Text = (reader[5].ToString());
                    textBoxElukoht.Text = (reader[6].ToString());
                    textBoxSissekirjutis.Text = (reader[7].ToString());
                    comboBoxOmavalitsus.Text = (reader[8].ToString());
                    textBoxMail.Text = (reader[10].ToString());
                    textBoxTLepinguKP.Text = (reader[11].ToString());
                    textBoxAllyksus.Text = (reader[12].ToString());
                    textBoxAmetikoht.Text = (reader[13].ToString());
                    textBoxHaridus.Text = (reader[14].ToString());
                    textBoxEriala.Text = (reader[15].ToString());
                    textBoxDiplomNr.Text = (reader[16].ToString());
                    textBoxLopetamiseKp.Text = (reader[17].ToString());
                    textBoxAmetijark.Text = (reader[18].ToString());
                    textBoxAmetiJarkKeht.Text = (reader[19].ToString());
                    textBoxTervisetoend.Text = (reader[20].ToString());
                    textBoxTerviToendKeht.Text = (reader[21].ToString());
                    textBoxPangakood.Text = (reader[22].ToString());
                    textBoxSeeriaNr.Text = (reader[23].ToString());
                    textBoxKaardiNr.Text = (reader[24].ToString());
                    textBoxKooliAmet.Text = (reader[25].ToString());
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.personal WHERE Isikukood = @ik", db.GetConnection());
                command.Parameters.Add("@ik", MySqlDbType.VarChar).Value = isikukood;
                db.openconnection();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBoxPerenimi.Text = (reader[0].ToString());
                    textBoxEesnimi.Text = (reader[1].ToString());
                    textBoxIKood.Text = (reader[2].ToString());
                    textBoxSynniaeg.Text = (reader[3].ToString());
                    textBoxTelefon.Text = (reader[4].ToString());
                    textBoxMobiil.Text = (reader[5].ToString());
                    textBoxElukoht.Text = (reader[6].ToString());
                    textBoxSissekirjutis.Text = (reader[7].ToString());
                    comboBoxOmavalitsus.Text = (reader[8].ToString());
                    textBoxMail.Text = (reader[10].ToString());
                    textBoxTLepinguKP.Text = (reader[11].ToString());
                    textBoxAllyksus.Text = (reader[12].ToString());
                    textBoxAmetikoht.Text = (reader[13].ToString());
                    textBoxHaridus.Text = (reader[14].ToString());
                    textBoxEriala.Text = (reader[15].ToString());
                    textBoxDiplomNr.Text = (reader[16].ToString());
                    textBoxLopetamiseKp.Text = (reader[17].ToString());
                    textBoxAmetijark.Text = (reader[18].ToString());
                    textBoxAmetiJarkKeht.Text = (reader[19].ToString());
                    textBoxTervisetoend.Text = (reader[20].ToString());
                    textBoxTerviToendKeht.Text = (reader[21].ToString());
                    textBoxPangakood.Text = (reader[22].ToString());
                    textBoxSeeriaNr.Text = (reader[23].ToString());
                    textBoxKaardiNr.Text = (reader[24].ToString());
                    textBoxKooliAmet.Text = (reader[25].ToString());
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
