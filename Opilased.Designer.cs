
namespace Kooli_andmbaas
{
    partial class FormOpilased
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpilased));
            this.dataGridViewOp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPerenimi = new System.Windows.Forms.TextBox();
            this.textBoxEesnimi = new System.Windows.Forms.TextBox();
            this.textBoxKlass = new System.Windows.Forms.TextBox();
            this.textBoxSynnikoht = new System.Windows.Forms.TextBox();
            this.textBoxSynniaeg = new System.Windows.Forms.TextBox();
            this.labelPN = new System.Windows.Forms.Label();
            this.labelEN = new System.Windows.Forms.Label();
            this.labelKL = new System.Windows.Forms.Label();
            this.labelSA = new System.Windows.Forms.Label();
            this.labelSK = new System.Windows.Forms.Label();
            this.textBoxEKoht = new System.Windows.Forms.TextBox();
            this.textBoxSkirjutus = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxKNr = new System.Windows.Forms.TextBox();
            this.textBoxSNr = new System.Windows.Forms.TextBox();
            this.textBoxKLKordamine = new System.Windows.Forms.TextBox();
            this.textBoxORaamat = new System.Windows.Forms.TextBox();
            this.checkBoxPoiss = new System.Windows.Forms.CheckBox();
            this.comboBoxOValitsus = new System.Windows.Forms.ComboBox();
            this.checkBoxKaart = new System.Windows.Forms.CheckBox();
            this.textBoxIKood = new System.Windows.Forms.TextBox();
            this.labelSissekirjutus = new System.Windows.Forms.Label();
            this.labelElukoht = new System.Windows.Forms.Label();
            this.labelOmavalitsus = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelKlKordamine = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxVanemad = new System.Windows.Forms.GroupBox();
            this.labelIMail = new System.Windows.Forms.Label();
            this.labelIsa = new System.Windows.Forms.Label();
            this.labelEma = new System.Windows.Forms.Label();
            this.labelITelefon = new System.Windows.Forms.Label();
            this.labelETelefon = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.textBoxETelefon = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxIMail = new System.Windows.Forms.TextBox();
            this.textBoxITelefon = new System.Windows.Forms.TextBox();
            this.textBoxINimi = new System.Windows.Forms.TextBox();
            this.textBoxENimi = new System.Windows.Forms.TextBox();
            this.buttonSulge = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelKSNr = new System.Windows.Forms.Label();
            this.labelKNr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOp)).BeginInit();
            this.groupBoxVanemad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOp
            // 
            this.dataGridViewOp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewOp.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewOp.Name = "dataGridViewOp";
            this.dataGridViewOp.ReadOnly = true;
            this.dataGridViewOp.RowHeadersWidth = 51;
            this.dataGridViewOp.RowTemplate.Height = 24;
            this.dataGridViewOp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOp.Size = new System.Drawing.Size(450, 650);
            this.dataGridViewOp.TabIndex = 0;
            this.dataGridViewOp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOp_RowEnter);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 129.9465F;
            this.Column1.HeaderText = "Perenimi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 129.9465F;
            this.Column2.HeaderText = "Eesnimi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40.10695F;
            this.Column3.HeaderText = "Klass";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Isikukood";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // textBoxPerenimi
            // 
            this.textBoxPerenimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxPerenimi.Location = new System.Drawing.Point(510, 57);
            this.textBoxPerenimi.Name = "textBoxPerenimi";
            this.textBoxPerenimi.Size = new System.Drawing.Size(163, 27);
            this.textBoxPerenimi.TabIndex = 1;
            this.textBoxPerenimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEesnimi
            // 
            this.textBoxEesnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxEesnimi.Location = new System.Drawing.Point(690, 57);
            this.textBoxEesnimi.Name = "textBoxEesnimi";
            this.textBoxEesnimi.Size = new System.Drawing.Size(178, 27);
            this.textBoxEesnimi.TabIndex = 2;
            // 
            // textBoxKlass
            // 
            this.textBoxKlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxKlass.Location = new System.Drawing.Point(883, 57);
            this.textBoxKlass.Name = "textBoxKlass";
            this.textBoxKlass.Size = new System.Drawing.Size(100, 27);
            this.textBoxKlass.TabIndex = 3;
            // 
            // textBoxSynnikoht
            // 
            this.textBoxSynnikoht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxSynnikoht.Location = new System.Drawing.Point(690, 128);
            this.textBoxSynnikoht.Name = "textBoxSynnikoht";
            this.textBoxSynnikoht.Size = new System.Drawing.Size(293, 27);
            this.textBoxSynnikoht.TabIndex = 4;
            // 
            // textBoxSynniaeg
            // 
            this.textBoxSynniaeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxSynniaeg.Location = new System.Drawing.Point(518, 128);
            this.textBoxSynniaeg.Name = "textBoxSynniaeg";
            this.textBoxSynniaeg.Size = new System.Drawing.Size(123, 27);
            this.textBoxSynniaeg.TabIndex = 5;
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelPN.ForeColor = System.Drawing.Color.Maroon;
            this.labelPN.Location = new System.Drawing.Point(558, 26);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(74, 18);
            this.labelPN.TabIndex = 7;
            this.labelPN.Text = "Perenimi";
            // 
            // labelEN
            // 
            this.labelEN.AutoSize = true;
            this.labelEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelEN.ForeColor = System.Drawing.Color.Maroon;
            this.labelEN.Location = new System.Drawing.Point(744, 26);
            this.labelEN.Name = "labelEN";
            this.labelEN.Size = new System.Drawing.Size(68, 18);
            this.labelEN.TabIndex = 8;
            this.labelEN.Text = "Eesnimi";
            // 
            // labelKL
            // 
            this.labelKL.AutoSize = true;
            this.labelKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelKL.ForeColor = System.Drawing.Color.Maroon;
            this.labelKL.Location = new System.Drawing.Point(911, 26);
            this.labelKL.Name = "labelKL";
            this.labelKL.Size = new System.Drawing.Size(50, 18);
            this.labelKL.TabIndex = 9;
            this.labelKL.Text = "Klass";
            // 
            // labelSA
            // 
            this.labelSA.AutoSize = true;
            this.labelSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSA.ForeColor = System.Drawing.Color.Maroon;
            this.labelSA.Location = new System.Drawing.Point(540, 97);
            this.labelSA.Name = "labelSA";
            this.labelSA.Size = new System.Drawing.Size(77, 18);
            this.labelSA.TabIndex = 10;
            this.labelSA.Text = "Sünniaeg";
            // 
            // labelSK
            // 
            this.labelSK.AutoSize = true;
            this.labelSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSK.ForeColor = System.Drawing.Color.Maroon;
            this.labelSK.Location = new System.Drawing.Point(806, 97);
            this.labelSK.Name = "labelSK";
            this.labelSK.Size = new System.Drawing.Size(83, 18);
            this.labelSK.TabIndex = 11;
            this.labelSK.Text = "Sünnikoht";
            // 
            // textBoxEKoht
            // 
            this.textBoxEKoht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxEKoht.Location = new System.Drawing.Point(690, 198);
            this.textBoxEKoht.Name = "textBoxEKoht";
            this.textBoxEKoht.Size = new System.Drawing.Size(293, 27);
            this.textBoxEKoht.TabIndex = 14;
            this.textBoxEKoht.Text = "Elukoht";
            // 
            // textBoxSkirjutus
            // 
            this.textBoxSkirjutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxSkirjutus.Location = new System.Drawing.Point(690, 269);
            this.textBoxSkirjutus.Name = "textBoxSkirjutus";
            this.textBoxSkirjutus.Size = new System.Drawing.Size(293, 27);
            this.textBoxSkirjutus.TabIndex = 15;
            this.textBoxSkirjutus.Text = "Sissekirjutis";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxTelefon.Location = new System.Drawing.Point(518, 269);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(123, 27);
            this.textBoxTelefon.TabIndex = 17;
            this.textBoxTelefon.Text = "Telefon";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxMail.Location = new System.Drawing.Point(518, 342);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(123, 27);
            this.textBoxMail.TabIndex = 18;
            this.textBoxMail.Text = "Mail";
            // 
            // textBoxKNr
            // 
            this.textBoxKNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxKNr.Location = new System.Drawing.Point(1044, 403);
            this.textBoxKNr.Name = "textBoxKNr";
            this.textBoxKNr.Size = new System.Drawing.Size(155, 27);
            this.textBoxKNr.TabIndex = 23;
            this.textBoxKNr.Text = "Kaardi nr";
            // 
            // textBoxSNr
            // 
            this.textBoxSNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxSNr.Location = new System.Drawing.Point(1044, 325);
            this.textBoxSNr.Name = "textBoxSNr";
            this.textBoxSNr.Size = new System.Drawing.Size(155, 27);
            this.textBoxSNr.TabIndex = 24;
            this.textBoxSNr.Text = "Seeria nr";
            // 
            // textBoxKLKordamine
            // 
            this.textBoxKLKordamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxKLKordamine.Location = new System.Drawing.Point(690, 342);
            this.textBoxKLKordamine.Name = "textBoxKLKordamine";
            this.textBoxKLKordamine.Size = new System.Drawing.Size(138, 27);
            this.textBoxKLKordamine.TabIndex = 26;
            this.textBoxKLKordamine.Text = "Klassi kordamine";
            // 
            // textBoxORaamat
            // 
            this.textBoxORaamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxORaamat.Location = new System.Drawing.Point(1119, 125);
            this.textBoxORaamat.Name = "textBoxORaamat";
            this.textBoxORaamat.Size = new System.Drawing.Size(100, 27);
            this.textBoxORaamat.TabIndex = 30;
            this.textBoxORaamat.Text = "Operaamat";
            // 
            // checkBoxPoiss
            // 
            this.checkBoxPoiss.AutoSize = true;
            this.checkBoxPoiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBoxPoiss.Location = new System.Drawing.Point(1015, 128);
            this.checkBoxPoiss.Name = "checkBoxPoiss";
            this.checkBoxPoiss.Size = new System.Drawing.Size(73, 24);
            this.checkBoxPoiss.TabIndex = 31;
            this.checkBoxPoiss.Text = "Poiss";
            this.checkBoxPoiss.UseVisualStyleBackColor = true;
            // 
            // comboBoxOValitsus
            // 
            this.comboBoxOValitsus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.comboBoxOValitsus.FormattingEnabled = true;
            this.comboBoxOValitsus.Location = new System.Drawing.Point(518, 198);
            this.comboBoxOValitsus.Name = "comboBoxOValitsus";
            this.comboBoxOValitsus.Size = new System.Drawing.Size(123, 28);
            this.comboBoxOValitsus.TabIndex = 32;
            this.comboBoxOValitsus.Text = "Omavalitsus";
            // 
            // checkBoxKaart
            // 
            this.checkBoxKaart.AutoSize = true;
            this.checkBoxKaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBoxKaart.Location = new System.Drawing.Point(1044, 248);
            this.checkBoxKaart.Name = "checkBoxKaart";
            this.checkBoxKaart.Size = new System.Drawing.Size(71, 24);
            this.checkBoxKaart.TabIndex = 33;
            this.checkBoxKaart.Text = "Kaart";
            this.checkBoxKaart.UseVisualStyleBackColor = true;
            // 
            // textBoxIKood
            // 
            this.textBoxIKood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxIKood.Location = new System.Drawing.Point(992, 57);
            this.textBoxIKood.Name = "textBoxIKood";
            this.textBoxIKood.Size = new System.Drawing.Size(123, 27);
            this.textBoxIKood.TabIndex = 34;
            this.textBoxIKood.Text = "Isikukood";
            // 
            // labelSissekirjutus
            // 
            this.labelSissekirjutus.AutoSize = true;
            this.labelSissekirjutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSissekirjutus.ForeColor = System.Drawing.Color.Maroon;
            this.labelSissekirjutus.Location = new System.Drawing.Point(806, 238);
            this.labelSissekirjutus.Name = "labelSissekirjutus";
            this.labelSissekirjutus.Size = new System.Drawing.Size(105, 18);
            this.labelSissekirjutus.TabIndex = 35;
            this.labelSissekirjutus.Text = "Sissekirjutus";
            // 
            // labelElukoht
            // 
            this.labelElukoht.AutoSize = true;
            this.labelElukoht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelElukoht.ForeColor = System.Drawing.Color.Maroon;
            this.labelElukoht.Location = new System.Drawing.Point(806, 168);
            this.labelElukoht.Name = "labelElukoht";
            this.labelElukoht.Size = new System.Drawing.Size(65, 18);
            this.labelElukoht.TabIndex = 36;
            this.labelElukoht.Text = "Elukoht";
            // 
            // labelOmavalitsus
            // 
            this.labelOmavalitsus.AutoSize = true;
            this.labelOmavalitsus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelOmavalitsus.ForeColor = System.Drawing.Color.Maroon;
            this.labelOmavalitsus.Location = new System.Drawing.Point(540, 168);
            this.labelOmavalitsus.Name = "labelOmavalitsus";
            this.labelOmavalitsus.Size = new System.Drawing.Size(101, 18);
            this.labelOmavalitsus.TabIndex = 37;
            this.labelOmavalitsus.Text = "Omavalitsus";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelTelefon.ForeColor = System.Drawing.Color.Maroon;
            this.labelTelefon.Location = new System.Drawing.Point(540, 238);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(64, 18);
            this.labelTelefon.TabIndex = 38;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelKlKordamine
            // 
            this.labelKlKordamine.AutoSize = true;
            this.labelKlKordamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelKlKordamine.ForeColor = System.Drawing.Color.Maroon;
            this.labelKlKordamine.Location = new System.Drawing.Point(690, 309);
            this.labelKlKordamine.Name = "labelKlKordamine";
            this.labelKlKordamine.Size = new System.Drawing.Size(138, 18);
            this.labelKlKordamine.TabIndex = 39;
            this.labelKlKordamine.Text = "Klassi kordamine";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMail.ForeColor = System.Drawing.Color.Maroon;
            this.labelMail.Location = new System.Drawing.Point(540, 313);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(39, 18);
            this.labelMail.TabIndex = 40;
            this.labelMail.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Sünniaeg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(1011, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Isikukood";
            // 
            // groupBoxVanemad
            // 
            this.groupBoxVanemad.Controls.Add(this.labelIMail);
            this.groupBoxVanemad.Controls.Add(this.labelIsa);
            this.groupBoxVanemad.Controls.Add(this.labelEma);
            this.groupBoxVanemad.Controls.Add(this.labelITelefon);
            this.groupBoxVanemad.Controls.Add(this.labelETelefon);
            this.groupBoxVanemad.Controls.Add(this.labelEMail);
            this.groupBoxVanemad.Controls.Add(this.textBoxETelefon);
            this.groupBoxVanemad.Controls.Add(this.textBoxEMail);
            this.groupBoxVanemad.Controls.Add(this.textBoxIMail);
            this.groupBoxVanemad.Controls.Add(this.textBoxITelefon);
            this.groupBoxVanemad.Controls.Add(this.textBoxINimi);
            this.groupBoxVanemad.Controls.Add(this.textBoxENimi);
            this.groupBoxVanemad.Location = new System.Drawing.Point(489, 439);
            this.groupBoxVanemad.Name = "groupBoxVanemad";
            this.groupBoxVanemad.Size = new System.Drawing.Size(534, 287);
            this.groupBoxVanemad.TabIndex = 43;
            this.groupBoxVanemad.TabStop = false;
            this.groupBoxVanemad.Text = "Vanemad";
            // 
            // labelIMail
            // 
            this.labelIMail.AutoSize = true;
            this.labelIMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelIMail.ForeColor = System.Drawing.Color.Maroon;
            this.labelIMail.Location = new System.Drawing.Point(89, 183);
            this.labelIMail.Name = "labelIMail";
            this.labelIMail.Size = new System.Drawing.Size(39, 18);
            this.labelIMail.TabIndex = 46;
            this.labelIMail.Text = "Mail";
            // 
            // labelIsa
            // 
            this.labelIsa.AutoSize = true;
            this.labelIsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelIsa.ForeColor = System.Drawing.Color.Maroon;
            this.labelIsa.Location = new System.Drawing.Point(89, 36);
            this.labelIsa.Name = "labelIsa";
            this.labelIsa.Size = new System.Drawing.Size(30, 18);
            this.labelIsa.TabIndex = 45;
            this.labelIsa.Text = "Isa";
            // 
            // labelEma
            // 
            this.labelEma.AutoSize = true;
            this.labelEma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelEma.ForeColor = System.Drawing.Color.Maroon;
            this.labelEma.Location = new System.Drawing.Point(340, 36);
            this.labelEma.Name = "labelEma";
            this.labelEma.Size = new System.Drawing.Size(42, 18);
            this.labelEma.TabIndex = 44;
            this.labelEma.Text = "Ema";
            // 
            // labelITelefon
            // 
            this.labelITelefon.AutoSize = true;
            this.labelITelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelITelefon.ForeColor = System.Drawing.Color.Maroon;
            this.labelITelefon.Location = new System.Drawing.Point(89, 113);
            this.labelITelefon.Name = "labelITelefon";
            this.labelITelefon.Size = new System.Drawing.Size(64, 18);
            this.labelITelefon.TabIndex = 43;
            this.labelITelefon.Text = "Telefon";
            // 
            // labelETelefon
            // 
            this.labelETelefon.AutoSize = true;
            this.labelETelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelETelefon.ForeColor = System.Drawing.Color.Maroon;
            this.labelETelefon.Location = new System.Drawing.Point(340, 113);
            this.labelETelefon.Name = "labelETelefon";
            this.labelETelefon.Size = new System.Drawing.Size(64, 18);
            this.labelETelefon.TabIndex = 42;
            this.labelETelefon.Text = "Telefon";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelEMail.ForeColor = System.Drawing.Color.Maroon;
            this.labelEMail.Location = new System.Drawing.Point(340, 183);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(39, 18);
            this.labelEMail.TabIndex = 41;
            this.labelEMail.Text = "Mail";
            // 
            // textBoxETelefon
            // 
            this.textBoxETelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxETelefon.Location = new System.Drawing.Point(283, 144);
            this.textBoxETelefon.Name = "textBoxETelefon";
            this.textBoxETelefon.Size = new System.Drawing.Size(150, 27);
            this.textBoxETelefon.TabIndex = 35;
            this.textBoxETelefon.Text = "Ema telefon";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxEMail.Location = new System.Drawing.Point(283, 217);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(215, 27);
            this.textBoxEMail.TabIndex = 34;
            this.textBoxEMail.Text = "Ema mail";
            // 
            // textBoxIMail
            // 
            this.textBoxIMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxIMail.Location = new System.Drawing.Point(34, 217);
            this.textBoxIMail.Name = "textBoxIMail";
            this.textBoxIMail.Size = new System.Drawing.Size(224, 27);
            this.textBoxIMail.TabIndex = 33;
            this.textBoxIMail.Text = "Isa mail";
            // 
            // textBoxITelefon
            // 
            this.textBoxITelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxITelefon.Location = new System.Drawing.Point(34, 144);
            this.textBoxITelefon.Name = "textBoxITelefon";
            this.textBoxITelefon.Size = new System.Drawing.Size(154, 27);
            this.textBoxITelefon.TabIndex = 32;
            this.textBoxITelefon.Text = "Isa telefon";
            // 
            // textBoxINimi
            // 
            this.textBoxINimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxINimi.Location = new System.Drawing.Point(34, 72);
            this.textBoxINimi.Name = "textBoxINimi";
            this.textBoxINimi.Size = new System.Drawing.Size(154, 27);
            this.textBoxINimi.TabIndex = 31;
            this.textBoxINimi.Text = "Isa nimi";
            // 
            // textBoxENimi
            // 
            this.textBoxENimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxENimi.Location = new System.Drawing.Point(283, 72);
            this.textBoxENimi.Name = "textBoxENimi";
            this.textBoxENimi.Size = new System.Drawing.Size(150, 27);
            this.textBoxENimi.TabIndex = 30;
            this.textBoxENimi.Text = "Ema nimi";
            // 
            // buttonSulge
            // 
            this.buttonSulge.BackgroundImage = global::Kooli_andmbaas.Properties.Resources.sulge;
            this.buttonSulge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSulge.Image = global::Kooli_andmbaas.Properties.Resources.sulge;
            this.buttonSulge.Location = new System.Drawing.Point(1467, 11);
            this.buttonSulge.Name = "buttonSulge";
            this.buttonSulge.Size = new System.Drawing.Size(54, 50);
            this.buttonSulge.TabIndex = 44;
            this.buttonSulge.UseVisualStyleBackColor = true;
            this.buttonSulge.Click += new System.EventHandler(this.buttonSulge_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxFoto.Location = new System.Drawing.Point(1238, 81);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(283, 399);
            this.pictureBoxFoto.TabIndex = 6;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelKSNr
            // 
            this.labelKSNr.AutoSize = true;
            this.labelKSNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelKSNr.ForeColor = System.Drawing.Color.Maroon;
            this.labelKSNr.Location = new System.Drawing.Point(1061, 286);
            this.labelKSNr.Name = "labelKSNr";
            this.labelKSNr.Size = new System.Drawing.Size(109, 18);
            this.labelKSNr.TabIndex = 45;
            this.labelKSNr.Text = "Kaardi Seeria";
            // 
            // labelKNr
            // 
            this.labelKNr.AutoSize = true;
            this.labelKNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelKNr.ForeColor = System.Drawing.Color.Maroon;
            this.labelKNr.Location = new System.Drawing.Point(1061, 364);
            this.labelKNr.Name = "labelKNr";
            this.labelKNr.Size = new System.Drawing.Size(84, 18);
            this.labelKNr.TabIndex = 46;
            this.labelKNr.Text = "Kaardi Nr.";
            // 
            // FormOpilased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1538, 753);
            this.Controls.Add(this.labelKNr);
            this.Controls.Add(this.labelKSNr);
            this.Controls.Add(this.buttonSulge);
            this.Controls.Add(this.groupBoxVanemad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelKlKordamine);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelOmavalitsus);
            this.Controls.Add(this.labelElukoht);
            this.Controls.Add(this.labelSissekirjutus);
            this.Controls.Add(this.textBoxIKood);
            this.Controls.Add(this.checkBoxKaart);
            this.Controls.Add(this.comboBoxOValitsus);
            this.Controls.Add(this.checkBoxPoiss);
            this.Controls.Add(this.textBoxORaamat);
            this.Controls.Add(this.textBoxKLKordamine);
            this.Controls.Add(this.textBoxSNr);
            this.Controls.Add(this.textBoxKNr);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxSkirjutus);
            this.Controls.Add(this.textBoxEKoht);
            this.Controls.Add(this.labelSK);
            this.Controls.Add(this.labelSA);
            this.Controls.Add(this.labelKL);
            this.Controls.Add(this.labelEN);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBoxSynniaeg);
            this.Controls.Add(this.textBoxSynnikoht);
            this.Controls.Add(this.textBoxKlass);
            this.Controls.Add(this.textBoxEesnimi);
            this.Controls.Add(this.textBoxPerenimi);
            this.Controls.Add(this.dataGridViewOp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOpilased";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuressaare Hariduse Kooli Õpilased";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOp)).EndInit();
            this.groupBoxVanemad.ResumeLayout(false);
            this.groupBoxVanemad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOp;
        private System.Windows.Forms.TextBox textBoxPerenimi;
        private System.Windows.Forms.TextBox textBoxEesnimi;
        private System.Windows.Forms.TextBox textBoxKlass;
        private System.Windows.Forms.TextBox textBoxSynnikoht;
        private System.Windows.Forms.TextBox textBoxSynniaeg;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.Label labelEN;
        private System.Windows.Forms.Label labelKL;
        private System.Windows.Forms.Label labelSA;
        private System.Windows.Forms.Label labelSK;
        private System.Windows.Forms.TextBox textBoxEKoht;
        private System.Windows.Forms.TextBox textBoxSkirjutus;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxKNr;
        private System.Windows.Forms.TextBox textBoxSNr;
        private System.Windows.Forms.TextBox textBoxKLKordamine;
        private System.Windows.Forms.TextBox textBoxORaamat;
        private System.Windows.Forms.CheckBox checkBoxPoiss;
        private System.Windows.Forms.ComboBox comboBoxOValitsus;
        private System.Windows.Forms.CheckBox checkBoxKaart;
        private System.Windows.Forms.TextBox textBoxIKood;
        private System.Windows.Forms.Label labelSissekirjutus;
        private System.Windows.Forms.Label labelElukoht;
        private System.Windows.Forms.Label labelOmavalitsus;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelKlKordamine;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxVanemad;
        private System.Windows.Forms.TextBox textBoxETelefon;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxIMail;
        private System.Windows.Forms.TextBox textBoxITelefon;
        private System.Windows.Forms.TextBox textBoxINimi;
        private System.Windows.Forms.TextBox textBoxENimi;
        private System.Windows.Forms.Button buttonSulge;
        private System.Windows.Forms.Label labelIMail;
        private System.Windows.Forms.Label labelIsa;
        private System.Windows.Forms.Label labelEma;
        private System.Windows.Forms.Label labelITelefon;
        private System.Windows.Forms.Label labelETelefon;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelKSNr;
        private System.Windows.Forms.Label labelKNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}