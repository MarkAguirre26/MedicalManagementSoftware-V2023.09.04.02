namespace MedicalManagement
{
    partial class frm_patientInfo
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
            this.p_info_panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_employer = new System.Windows.Forms.TextBox();
            this.cmdLoadEmployer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dateUpdate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_datereg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtage = new System.Windows.Forms.MaskedTextBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.ComboBox();
            this.dtbday = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.overlayShadow1 = new MedicalManagement.Class.OverlayShadow();
            this.txt_papin = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgLabTestHistory = new System.Windows.Forms.DataGridView();
            this.RecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.p_info_panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLabTestHistory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_info_panel
            // 
            this.p_info_panel.Controls.Add(this.groupBox3);
            this.p_info_panel.Controls.Add(this.groupBox1);
            this.p_info_panel.Controls.Add(this.overlayShadow1);
            this.p_info_panel.ForeColor = System.Drawing.Color.DarkBlue;
            this.p_info_panel.Location = new System.Drawing.Point(-4, 52);
            this.p_info_panel.Name = "p_info_panel";
            this.p_info_panel.Size = new System.Drawing.Size(691, 236);
            this.p_info_panel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_employer);
            this.groupBox3.Controls.Add(this.cmdLoadEmployer);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.txt_Contact);
            this.groupBox3.Controls.Add(this.txtcity);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_dateUpdate);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_datereg);
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 167);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cbo_employer
            // 
            this.cbo_employer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo_employer.Location = new System.Drawing.Point(100, 137);
            this.cbo_employer.Name = "cbo_employer";
            this.cbo_employer.Size = new System.Drawing.Size(524, 20);
            this.cbo_employer.TabIndex = 36;
            // 
            // cmdLoadEmployer
            // 
            this.cmdLoadEmployer.ForeColor = System.Drawing.Color.Black;
            this.cmdLoadEmployer.Location = new System.Drawing.Point(630, 136);
            this.cmdLoadEmployer.Name = "cmdLoadEmployer";
            this.cmdLoadEmployer.Size = new System.Drawing.Size(28, 22);
            this.cmdLoadEmployer.TabIndex = 35;
            this.cmdLoadEmployer.Text = "...";
            this.cmdLoadEmployer.UseVisualStyleBackColor = true;
            this.cmdLoadEmployer.Click += new System.EventHandler(this.cmdLoadEmployer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_lastname);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_mname);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_firstName);
            this.panel3.Controls.Add(this.txtaddress1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 68);
            this.panel3.TabIndex = 4;
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lastname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Location = new System.Drawing.Point(87, 2);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(178, 21);
            this.txt_lastname.TabIndex = 5;
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_lastname_TextChanged);
            this.txt_lastname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_lastname_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(526, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "*Middlename";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(339, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "*Firstname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(149, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "*Lastname";
            // 
            // txt_mname
            // 
            this.txt_mname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(470, 2);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(175, 21);
            this.txt_mname.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_firstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(269, 2);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(197, 21);
            this.txt_firstName.TabIndex = 6;
            // 
            // txtaddress1
            // 
            this.txtaddress1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtaddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress1.Location = new System.Drawing.Point(87, 45);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(558, 21);
            this.txtaddress1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Patient Name:";
            // 
            // txt_Contact
            // 
            this.txt_Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contact.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.Location = new System.Drawing.Point(403, 111);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(255, 21);
            this.txt_Contact.TabIndex = 10;
            // 
            // txtcity
            // 
            this.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(100, 111);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(211, 21);
            this.txtcity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contact No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "City:";
            // 
            // txt_dateUpdate
            // 
            this.txt_dateUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_dateUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dateUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateUpdate.Location = new System.Drawing.Point(504, 12);
            this.txt_dateUpdate.Name = "txt_dateUpdate";
            this.txt_dateUpdate.ReadOnly = true;
            this.txt_dateUpdate.Size = new System.Drawing.Size(154, 21);
            this.txt_dateUpdate.TabIndex = 3;
            this.txt_dateUpdate.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(35, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 15);
            this.label18.TabIndex = 34;
            this.label18.Text = "Employer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date Registered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Last Updated:";
            // 
            // txt_datereg
            // 
            this.txt_datereg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_datereg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_datereg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datereg.Location = new System.Drawing.Point(227, 12);
            this.txt_datereg.Name = "txt_datereg";
            this.txt_datereg.ReadOnly = true;
            this.txt_datereg.Size = new System.Drawing.Size(154, 21);
            this.txt_datereg.TabIndex = 2;
            this.txt_datereg.TabStop = false;
            this.txt_datereg.TextChanged += new System.EventHandler(this.txtpapin_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.cbo_status);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.dtbday);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbo_gender);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Enabled = false;
            this.txtage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(278, 11);
            this.txtage.Mask = "###";
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(33, 21);
            this.txtage.TabIndex = 14;
            this.txtage.TabStop = false;
            this.txtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_status
            // 
            this.cbo_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Single",
            "Married",
            "Separated",
            "Devorce",
            "Widowed",
            "Widower"});
            this.cbo_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_status.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbo_status.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Devorce",
            "Widowed",
            "Widower"});
            this.cbo_status.Location = new System.Drawing.Point(417, 13);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(137, 23);
            this.cbo_status.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "M. Status:";
            // 
            // txtNationality
            // 
            this.txtNationality.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghan",
            "Albanian",
            "Algerian",
            "American",
            "Andorran",
            "Angolan",
            "Argentine",
            "Armenian",
            "Aromanian",
            "Aruban",
            "Australian",
            "Austrian",
            "Azeri",
            "Bahamian",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "Belarusian",
            "Belgian",
            "Belizean",
            "Bermudian",
            "Boer",
            "Bosniak",
            "Brazilian",
            "Breton",
            "British",
            "British Virgin Islander",
            "Bulgarian",
            "Burmese",
            "Macedonian Bulgarian",
            "Burkinabè",
            "Burundian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Catalan",
            "Cape Verdean",
            "Chadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Comorian",
            "Congolese",
            "Croatian",
            "Cuban",
            "Cypriot",
            "Turkish Cypriot",
            "Czech",
            "Dane",
            "Dominicans (Republic)",
            "Dominicans (Commonwealth)",
            "Dutch",
            "East Timorese",
            "Ecuadorian",
            "Egyptian",
            "Emirati",
            "English",
            "Eritrean",
            "Estonian",
            "Ethiopian",
            "Faroese",
            "Finn",
            "Finnish Swedish",
            "Fijian",
            "Filipino",
            "French citizen",
            "Georgian",
            "German",
            "Baltic German",
            "Ghanaian",
            "Gibraltar",
            "Greek",
            "Greek Macedonian",
            "Grenadian",
            "Guatemalan",
            "Guianese (French)",
            "Guinean",
            "Guinea-Bissau national",
            "Guyanese",
            "Haitian",
            "Honduran",
            "Hong Kong",
            "Hungarian",
            "Icelander",
            "Indian",
            "Indonesian",
            "Iranians (Persians)",
            "Iraqi",
            "Irish",
            "Israeli",
            "Italian",
            "Ivoirian",
            "Jamaican",
            "Japanese",
            "Jordanian",
            "Kazakh",
            "Kenyan",
            "Korean",
            "Kosovo Albanian",
            "Kurd",
            "Kuwaiti",
            "Lao",
            "Latvian",
            "Lebanese",
            "Liberian",
            "Libyan",
            "Liechtensteiner",
            "Lithuanian",
            "Luxembourger",
            "Macedonian",
            "Malagasy",
            "Malaysian",
            "Malawian",
            "Maldivian",
            "Malian",
            "Maltese",
            "Manx",
            "Mauritian",
            "Mexican",
            "Moldovan",
            "Moroccan",
            "Mongolian",
            "Montenegrin",
            "Namibian",
            "Nepalese",
            "New Zealander",
            "Nicaraguan",
            "Nigerien",
            "Nigerian",
            "Norwegian",
            "Pakistani",
            "Palauan",
            "Palestinian",
            "Panamanian",
            "Papua New Guinean",
            "Paraguayan",
            "Peruvian",
            "Pole",
            "Portuguese",
            "Puerto Rican",
            "Quebecer",
            "Réunionnai",
            "Romanian",
            "Russian",
            "Baltic Russian",
            "Rwandan",
            "Salvadoran",
            "São Tomé and Príncipe",
            "Saudi",
            "Scot",
            "Senegalese",
            "Serb",
            "Sierra Leonean",
            "Singaporean",
            "Sindhian",
            "Slovak",
            "Slovene",
            "Somali",
            "South African",
            "Spaniard",
            "Sri Lankan",
            "St Lucian",
            "Sudanese",
            "Surinamese",
            "Swede",
            "Swiss",
            "Syrian",
            "Taiwanese",
            "Tanzanian",
            "Tha",
            "Tibetan",
            "Tobagonians",
            "Trinidadia",
            "Tunisian",
            "Turk",
            "Tuvaluan",
            "Ugandan",
            "Ukrainian",
            "Uruguayan",
            "Uzbek",
            "Vanuatuan",
            "Venezuelan",
            "Vietnamese",
            "Welsh",
            "Yemenis",
            "Zambian",
            "Zimbabwean"});
            this.txtNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNationality.BackColor = System.Drawing.Color.White;
            this.txtNationality.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.FormattingEnabled = true;
            this.txtNationality.Items.AddRange(new object[] {
            "Afghan",
            "Albanian",
            "Algerian",
            "American",
            "Andorran",
            "Angolan",
            "Argentine",
            "Armenian",
            "Aromanian",
            "Aruban",
            "Australian",
            "Austrian",
            "Azeri",
            "Bahamian",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "Belarusian",
            "Belgian",
            "Belizean",
            "Bermudian",
            "Boer",
            "Bosniak",
            "Brazilian",
            "Breton",
            "British",
            "British Virgin Islander",
            "Bulgarian",
            "Burmese",
            "Macedonian Bulgarian",
            "Burkinabè",
            "Burundian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Catalan",
            "Cape Verdean",
            "Chadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Comorian",
            "Congolese",
            "Croatian",
            "Cuban",
            "Cypriot",
            "Turkish Cypriot",
            "Czech",
            "Dane",
            "Dominicans (Republic)",
            "Dominicans (Commonwealth)",
            "Dutch",
            "East Timorese",
            "Ecuadorian",
            "Egyptian",
            "Emirati",
            "English",
            "Eritrean",
            "Estonian",
            "Ethiopian",
            "Faroese",
            "Finn",
            "Finnish Swedish",
            "Fijian",
            "Filipino",
            "French citizen",
            "Georgian",
            "German",
            "Baltic German",
            "Ghanaian",
            "Gibraltar",
            "Greek",
            "Greek Macedonian",
            "Grenadian",
            "Guatemalan",
            "Guianese (French)",
            "Guinean",
            "Guinea-Bissau national",
            "Guyanese",
            "Haitian",
            "Honduran",
            "Hong Kong",
            "Hungarian",
            "Icelander",
            "Indian",
            "Indonesian",
            "Iranians (Persians)",
            "Iraqi",
            "Irish",
            "Israeli",
            "Italian",
            "Ivoirian",
            "Jamaican",
            "Japanese",
            "Jordanian",
            "Kazakh",
            "Kenyan",
            "Korean",
            "Kosovo Albanian",
            "Kurd",
            "Kuwaiti",
            "Lao",
            "Latvian",
            "Lebanese",
            "Liberian",
            "Libyan",
            "Liechtensteiner",
            "Lithuanian",
            "Luxembourger",
            "Macedonian",
            "Malagasy",
            "Malaysian",
            "Malawian",
            "Maldivian",
            "Malian",
            "Maltese",
            "Manx",
            "Mauritian",
            "Mexican",
            "Moldovan",
            "Moroccan",
            "Mongolian",
            "Montenegrin",
            "Namibian",
            "Nepalese",
            "New Zealander",
            "Nicaraguan",
            "Nigerien",
            "Nigerian",
            "Norwegian",
            "Pakistani",
            "Palauan",
            "Palestinian",
            "Panamanian",
            "Papua New Guinean",
            "Paraguayan",
            "Peruvian",
            "Pole",
            "Portuguese",
            "Puerto Rican",
            "Quebecer",
            "Réunionnai",
            "Romanian",
            "Russian",
            "Baltic Russian",
            "Rwandan",
            "Salvadoran",
            "São Tomé and Príncipe",
            "Saudi",
            "Scot",
            "Senegalese",
            "Serb",
            "Sierra Leonean",
            "Singaporean",
            "Sindhian",
            "Slovak",
            "Slovene",
            "Somali",
            "South African",
            "Spaniard",
            "Sri Lankan",
            "St Lucian",
            "Sudanese",
            "Surinamese",
            "Swede",
            "Swiss",
            "Syrian",
            "Taiwanese",
            "Tanzanian",
            "Tha",
            "Tibetan",
            "Tobagonians",
            "Trinidadia",
            "Tunisian",
            "Turk",
            "Tuvaluan",
            "Ugandan",
            "Ukrainian",
            "Uruguayan",
            "Uzbek",
            "Vanuatuan",
            "Venezuelan",
            "Vietnamese",
            "Welsh",
            "Yemenis",
            "Zambian",
            "Zimbabwean"});
            this.txtNationality.Location = new System.Drawing.Point(417, 37);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(137, 23);
            this.txtNationality.TabIndex = 17;
            // 
            // dtbday
            // 
            this.dtbday.CalendarFont = new System.Drawing.Font("Arial", 9F);
            this.dtbday.CustomFormat = "MM/dd/yyyy";
            this.dtbday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbday.Location = new System.Drawing.Point(102, 14);
            this.dtbday.Name = "dtbday";
            this.dtbday.ShowUpDown = true;
            this.dtbday.Size = new System.Drawing.Size(114, 20);
            this.dtbday.TabIndex = 11;
            this.dtbday.ValueChanged += new System.EventHandler(this.dtbday_ValueChanged);
            this.dtbday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtbday_KeyDown);
            this.dtbday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtbday_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(32, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "*Birthdate:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(45, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Gender:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(347, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Nationality:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "Age:";
            // 
            // cbo_gender
            // 
            this.cbo_gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.cbo_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_gender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbo_gender.Location = new System.Drawing.Point(102, 37);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(209, 23);
            this.cbo_gender.TabIndex = 14;
            // 
            // overlayShadow1
            // 
            this.overlayShadow1.Location = new System.Drawing.Point(0, 1);
            this.overlayShadow1.Name = "overlayShadow1";
            this.overlayShadow1.Size = new System.Drawing.Size(688, 237);
            this.overlayShadow1.TabIndex = 295;
            this.overlayShadow1.Click += new System.EventHandler(this.overlayShadow1_Click);
            // 
            // txt_papin
            // 
            this.txt_papin.BackColor = System.Drawing.SystemColors.Control;
            this.txt_papin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_papin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_papin.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_papin.Location = new System.Drawing.Point(189, 14);
            this.txt_papin.Name = "txt_papin";
            this.txt_papin.ReadOnly = true;
            this.txt_papin.Size = new System.Drawing.Size(492, 19);
            this.txt_papin.TabIndex = 294;
            this.txt_papin.TabStop = false;
            this.txt_papin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_papin.Visible = false;
            this.txt_papin.TextChanged += new System.EventHandler(this.txt_papin_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Control;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(278, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(108, 14);
            this.txt_id.TabIndex = 17;
            this.txt_id.TabStop = false;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.Visible = false;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label46.Location = new System.Drawing.Point(12, 15);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(150, 24);
            this.label46.TabIndex = 16;
            this.label46.Text = "Patient Profile";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgLabTestHistory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 179);
            this.panel1.TabIndex = 295;
            // 
            // dgLabTestHistory
            // 
            this.dgLabTestHistory.AllowUserToAddRows = false;
            this.dgLabTestHistory.AllowUserToDeleteRows = false;
            this.dgLabTestHistory.AllowUserToResizeColumns = false;
            this.dgLabTestHistory.AllowUserToResizeRows = false;
            this.dgLabTestHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgLabTestHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLabTestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLabTestHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecId,
            this.Column1});
            this.dgLabTestHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLabTestHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLabTestHistory.Location = new System.Drawing.Point(0, 21);
            this.dgLabTestHistory.Name = "dgLabTestHistory";
            this.dgLabTestHistory.ReadOnly = true;
            this.dgLabTestHistory.RowHeadersVisible = false;
            this.dgLabTestHistory.Size = new System.Drawing.Size(679, 158);
            this.dgLabTestHistory.TabIndex = 39;
            // 
            // RecId
            // 
            this.RecId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecId.HeaderText = "Test";
            this.RecId.Name = "RecId";
            this.RecId.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 21);
            this.panel2.TabIndex = 38;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(304, 21);
            this.label27.TabIndex = 35;
            this.label27.Text = "LABORATORY  TEST HISTORY";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_patientInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(693, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_papin);
            this.Controls.Add(this.p_info_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(863, 524);
            this.MinimizeBox = false;
            this.Name = "frm_patientInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Profile Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_patientInfo_FormClosing);
            this.Load += new System.EventHandler(this.frm_patientInfo_Load);
            this.Shown += new System.EventHandler(this.frm_patientInfo_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_patientInfo_KeyDown);
            this.p_info_panel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLabTestHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_dateUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtage;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.ComboBox cbo_status;
        public System.Windows.Forms.TextBox txt_datereg;
        private System.Windows.Forms.Label label46;
        public System.Windows.Forms.Panel p_info_panel;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_papin;
        private Class.OverlayShadow overlayShadow1;
        private System.Windows.Forms.DateTimePicker dtbday;
        private System.Windows.Forms.ComboBox txtNationality;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button cmdLoadEmployer;
        public System.Windows.Forms.TextBox cbo_employer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dgLabTestHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}