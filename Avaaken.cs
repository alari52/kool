using Kooli_andmbaas.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kooli_andmbaas
{
    public partial class FormAvaaken : Form
    {
        public static bool msserver, admin;
        public static string klass, eesnimi, perenimi;

        public FormAvaaken()
        {
            InitializeComponent();
            pictureBoxMysql.BackColor = Color.AliceBlue;
            pictureBoxMssql.BackColor = Color.LightYellow;
            pictureBoxExit.BackColor = Color.PeachPuff;

        }

        private void pictureBoxMysql_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMysql.BackColor = Color.Azure;
            groupBoxInfo.Visible = true;
        }

        private void pictureBoxMysql_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMysql.BackColor = Color.AliceBlue;
            groupBoxInfo.Visible = false;
        }

        private void pictureBoxMssql_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMssql.BackColor = Color.LightGoldenrodYellow;
            groupBoxInfo.Visible = true;
        }

        private void pictureBoxMssql_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMssql.BackColor = Color.LightYellow;
            groupBoxInfo.Visible = false;
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = Color.LightSalmon;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = Color.PeachPuff;
        }

        private void pictureBoxExit_MouseClick(object sender, MouseEventArgs e)
        {            
            Application.Exit();
        }

        private void pictureBoxMssql_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            groupBoxMs.Visible = true;
            if (groupBoxValik.Visible)
                groupBoxValik.Visible = false;
        }

        private void pictureBoxMysql_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            groupBoxMy.Visible = true;
            if (groupBoxValik.Visible)
            groupBoxValik.Visible = false;

        }

        private void buttonLogiMy_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxMyUser.Text;
            string loginPsw = textBoxMyPsw.Text;           
            
            msserver = false;
            pictureBoxMsLukk.Image = Resources.lukk_kinni;

            DBmy db = new DBmy();

            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (radioButtonMyAdm.Checked == true)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.administraatorid where Eesnimi=@ul " +
                    "and Parool=@up", db.GetConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser; //andmete muutujate peitmiseks
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = loginPsw;

                adapter.SelectCommand = command;
                adapter.Fill(tabel);

                admin = true;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM kool.klassijuhatajad where Eesnimi=@ul " +
                    "and Parool=@up", db.GetConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser; //andmete muutujate peitmiseks
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = loginPsw;

                adapter.SelectCommand = command;
                adapter.Fill(tabel);

                db.openconnection();
                MySqlDataReader reader = command.ExecuteReader(); //lisasin, et teada saada klassi numbrit
                while (reader.Read())                             //*
                {                                                 //*
                    klass = (reader["Klass"].ToString());         //*
                    eesnimi = (reader["Eesnimi"].ToString());     //*
                    perenimi = (reader["Perenimi"].ToString());   //*
                                                                  //*
                }                                                 // kui vaid while tsüklis üks tegevus nagu siin, siis võib ka ilma looksulgudeta {}                
                admin = false; //klassijuhataja
            }

            if (tabel.Rows.Count > 0)
            {
                if (admin)
                {
                    groupBoxMy.Visible = false;
                    groupBoxValik.Visible = true;
                    pictureBoxMyLukk.Image = Resources.lukk_lahti;
                    
                }
                else
                {
                    pictureBoxMyLukk.Image = Resources.lukk_lahti;
                    groupBoxMy.Visible = false;
                    MessageBox.Show("Armas klassijuhataja " + eesnimi + " " + perenimi + " " + klass + " suunan Sind Sinu klassi! ");

                    // siia tuleb klassijuhataja klassi opilaste avamine
                    admin = false;
                    FormOpilased op = new FormOpilased();
                    op.ShowDialog();

                }

            }
             else
                MessageBox.Show("Vale kasutajanimi või parool!");

        }

        private void buttonLogiMs_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxMsUser.Text;
            string loginPsw = textBoxMsPsw.Text;
            
            msserver = true;
            pictureBoxMyLukk.Image = Resources.lukk_kinni;

            DBms db = new DBms();

            DataTable tabel = new DataTable();
     
            SqlDataAdapter adapter = new SqlDataAdapter();

            if (radioButtonMsAdm.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Administraatorid] WHERE Eesnimi = '" + loginUser + "' " +
                    "AND Parool = '" + loginPsw + "'", db.getconnection());
                //command.Parameters.Add("@ul", SqlDbType.VarChar).Value = loginUser; //andmete muutujate peitmiseks
                //command.Parameters.Add("@up", SqlDbType.VarChar).Value = loginPsw; //mssql-s ei tööta NB!

                adapter.SelectCommand = command;
                adapter.Fill(tabel);
                admin = true;

            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Klassijuhatajad] WHERE Eesnimi = '" + loginUser + "' " +
                    "AND Parool = '" + loginPsw + "'", db.getconnection());
                //command.Parameters.Add("@ul", SqlDbType.VarChar).Value = loginUser; //andmete muutujate peitmiseks
                //command.Parameters.Add("@up", SqlDbType.VarChar).Value = loginPsw; //mssql-s ei tööta NB!

                adapter.SelectCommand = command;
                adapter.Fill(tabel);

                db.openconnection();
                SqlDataReader reader = command.ExecuteReader(); //lisasin, et teada saada klassi numbrit
                while (reader.Read())                           //*
                {                                               //*
                    klass = (reader["Klass"].ToString());       //*
                    eesnimi = (reader["Eesnimi"].ToString());   //*
                    perenimi = (reader["Perenimi"].ToString()); //*
                                                                //*
                }                                               // kui vaid while tsüklis üks tegevus nagu siin, siis võib ka ilma looksulgudeta {} 
                admin = false; //klassijuhataja
            }

            if (tabel.Rows.Count > 0)
            {
                if (admin)
                {
                    groupBoxMs.Visible = false;
                    groupBoxValik.Visible = true;
                    pictureBoxMsLukk.Image = Resources.lukk_lahti;
                   
                }
                else
                {
                    pictureBoxMsLukk.Image = Resources.lukk_lahti;
                    groupBoxMs.Visible = false;
                    MessageBox.Show("Armas klassijuhataja " + eesnimi + " " + perenimi + " " + klass + " suunan Sind Sinu klassi! ");

                    // siia tuleb klassijuhataja klassi opilaste avamine
                    admin = false;
                    FormOpilased op = new FormOpilased();
                    op.ShowDialog();

                }

            }
            else
                MessageBox.Show("Vale kasutajanimi või parool!");
        }

        private void pictureBoxPunane_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPunane.Image = Resources.punane2;
            toolTipVali.Show("Tee klikk", pictureBoxPunane);
        }

        private void pictureBoxPunane_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPunane.Image = Resources.punane1;
        }

        private void pictureBoxSinine_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSinine.Image = Resources.sinine2;
            toolTipVali.Show("Tee klikk", pictureBoxSinine);
        }

        private void pictureBoxSinine_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSinine.Image = Resources.sinine1;
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.linkLabelSite.LinkVisited = true;           
            System.Diagnostics.Process.Start("https://hariduse.edu.ee/et");
        }

        private void pictureBoxPunane_Click(object sender, EventArgs e) //Opilaste tabel
        {
            admin = true;
            FormOpilased op = new FormOpilased();
            op.ShowDialog();
        }

        private void pictureBoxSinine_Click(object sender, EventArgs e)            
        {
            admin = true;
            FormPersonal pe = new FormPersonal();
            pe.ShowDialog();
        }
    }
}
