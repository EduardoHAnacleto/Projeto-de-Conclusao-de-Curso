namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_People
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_address = new System.Windows.Forms.GroupBox();
            this.edt_homeType = new System.Windows.Forms.TextBox();
            this.edt_StateFU = new System.Windows.Forms.TextBox();
            this.edt_countryAcronym = new System.Windows.Forms.TextBox();
            this.edt_city = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_homeType = new System.Windows.Forms.Label();
            this.btn_findCity = new System.Windows.Forms.Button();
            this.lbl_city = new System.Windows.Forms.Label();
            this.edt_complement = new System.Windows.Forms.TextBox();
            this.Complement = new System.Windows.Forms.Label();
            this.edt_district = new System.Windows.Forms.TextBox();
            this.lbl_district = new System.Windows.Forms.Label();
            this.edt_houseNumber = new System.Windows.Forms.TextBox();
            this.lbl_houseNumber = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.edt_street = new System.Windows.Forms.TextBox();
            this.lbl_zipCode = new System.Windows.Forms.Label();
            this.medt_zipCode = new System.Windows.Forms.MaskedTextBox();
            this.gbox_phones = new System.Windows.Forms.GroupBox();
            this.lbl_requiredPhone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cbox_phone3 = new System.Windows.Forms.ComboBox();
            this.edt_email = new System.Windows.Forms.TextBox();
            this.cbox_phone2 = new System.Windows.Forms.ComboBox();
            this.medt_phone3 = new System.Windows.Forms.MaskedTextBox();
            this.medt_phone2 = new System.Windows.Forms.MaskedTextBox();
            this.cbox_phone1 = new System.Windows.Forms.ComboBox();
            this.medt_phone1 = new System.Windows.Forms.MaskedTextBox();
            this.medt_regNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.edt_age = new System.Windows.Forms.TextBox();
            this.gbox_gender = new System.Windows.Forms.GroupBox();
            this.check_otherGender = new System.Windows.Forms.RadioButton();
            this.check_female = new System.Windows.Forms.RadioButton();
            this.check_male = new System.Windows.Forms.RadioButton();
            this.edt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.medt_dob = new System.Windows.Forms.DateTimePicker();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_address.SuspendLayout();
            this.gbox_phones.SuspendLayout();
            this.gbox_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_LastUpdate
            // 
            this.lbl_LastUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            // 
            // gbox_address
            // 
            this.gbox_address.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbox_address.Controls.Add(this.edt_homeType);
            this.gbox_address.Controls.Add(this.edt_StateFU);
            this.gbox_address.Controls.Add(this.edt_countryAcronym);
            this.gbox_address.Controls.Add(this.edt_city);
            this.gbox_address.Controls.Add(this.lbl_country);
            this.gbox_address.Controls.Add(this.lbl_state);
            this.gbox_address.Controls.Add(this.lbl_homeType);
            this.gbox_address.Controls.Add(this.btn_findCity);
            this.gbox_address.Controls.Add(this.lbl_city);
            this.gbox_address.Controls.Add(this.edt_complement);
            this.gbox_address.Controls.Add(this.Complement);
            this.gbox_address.Controls.Add(this.edt_district);
            this.gbox_address.Controls.Add(this.lbl_district);
            this.gbox_address.Controls.Add(this.edt_houseNumber);
            this.gbox_address.Controls.Add(this.lbl_houseNumber);
            this.gbox_address.Controls.Add(this.lbl_street);
            this.gbox_address.Controls.Add(this.edt_street);
            this.gbox_address.Controls.Add(this.lbl_zipCode);
            this.gbox_address.Controls.Add(this.medt_zipCode);
            this.gbox_address.Location = new System.Drawing.Point(251, 133);
            this.gbox_address.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_address.Name = "gbox_address";
            this.gbox_address.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_address.Size = new System.Drawing.Size(401, 214);
            this.gbox_address.TabIndex = 32;
            this.gbox_address.TabStop = false;
            this.gbox_address.Text = "Endereço";
            // 
            // edt_homeType
            // 
            this.edt_homeType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_homeType.Location = new System.Drawing.Point(7, 129);
            this.edt_homeType.MaxLength = 15;
            this.edt_homeType.Name = "edt_homeType";
            this.edt_homeType.Size = new System.Drawing.Size(82, 20);
            this.edt_homeType.TabIndex = 29;
            // 
            // edt_StateFU
            // 
            this.edt_StateFU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_StateFU.Enabled = false;
            this.edt_StateFU.Location = new System.Drawing.Point(68, 178);
            this.edt_StateFU.Name = "edt_StateFU";
            this.edt_StateFU.Size = new System.Drawing.Size(49, 20);
            this.edt_StateFU.TabIndex = 28;
            // 
            // edt_countryAcronym
            // 
            this.edt_countryAcronym.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_countryAcronym.Enabled = false;
            this.edt_countryAcronym.Location = new System.Drawing.Point(7, 179);
            this.edt_countryAcronym.Name = "edt_countryAcronym";
            this.edt_countryAcronym.Size = new System.Drawing.Size(55, 20);
            this.edt_countryAcronym.TabIndex = 27;
            // 
            // edt_city
            // 
            this.edt_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_city.Enabled = false;
            this.edt_city.Location = new System.Drawing.Point(95, 130);
            this.edt_city.MaxLength = 50;
            this.edt_city.Name = "edt_city";
            this.edt_city.Size = new System.Drawing.Size(227, 20);
            this.edt_city.TabIndex = 26;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(4, 162);
            this.lbl_country.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(36, 13);
            this.lbl_country.TabIndex = 25;
            this.lbl_country.Text = "* País";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(65, 162);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(47, 13);
            this.lbl_state.TabIndex = 15;
            this.lbl_state.Text = "* Estado";
            // 
            // lbl_homeType
            // 
            this.lbl_homeType.AutoSize = true;
            this.lbl_homeType.Location = new System.Drawing.Point(4, 114);
            this.lbl_homeType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_homeType.Name = "lbl_homeType";
            this.lbl_homeType.Size = new System.Drawing.Size(35, 13);
            this.lbl_homeType.TabIndex = 14;
            this.lbl_homeType.Text = "* Tipo";
            // 
            // btn_findCity
            // 
            this.btn_findCity.Location = new System.Drawing.Point(327, 130);
            this.btn_findCity.Margin = new System.Windows.Forms.Padding(2);
            this.btn_findCity.Name = "btn_findCity";
            this.btn_findCity.Size = new System.Drawing.Size(58, 20);
            this.btn_findCity.TabIndex = 12;
            this.btn_findCity.Text = "Bu&scar";
            this.btn_findCity.UseVisualStyleBackColor = true;
            this.btn_findCity.Click += new System.EventHandler(this.btn_findCity_Click);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(92, 113);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(47, 13);
            this.lbl_city.TabIndex = 11;
            this.lbl_city.Text = "* Cidade";
            // 
            // edt_complement
            // 
            this.edt_complement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_complement.Location = new System.Drawing.Point(194, 89);
            this.edt_complement.Margin = new System.Windows.Forms.Padding(2);
            this.edt_complement.MaxLength = 30;
            this.edt_complement.Name = "edt_complement";
            this.edt_complement.Size = new System.Drawing.Size(169, 20);
            this.edt_complement.TabIndex = 9;
            // 
            // Complement
            // 
            this.Complement.AutoSize = true;
            this.Complement.Location = new System.Drawing.Point(192, 73);
            this.Complement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Complement.Name = "Complement";
            this.Complement.Size = new System.Drawing.Size(71, 13);
            this.Complement.TabIndex = 8;
            this.Complement.Text = "Complemento";
            // 
            // edt_district
            // 
            this.edt_district.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_district.Location = new System.Drawing.Point(66, 89);
            this.edt_district.Margin = new System.Windows.Forms.Padding(2);
            this.edt_district.MaxLength = 50;
            this.edt_district.Name = "edt_district";
            this.edt_district.Size = new System.Drawing.Size(120, 20);
            this.edt_district.TabIndex = 7;
            // 
            // lbl_district
            // 
            this.lbl_district.AutoSize = true;
            this.lbl_district.Location = new System.Drawing.Point(64, 73);
            this.lbl_district.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_district.Name = "lbl_district";
            this.lbl_district.Size = new System.Drawing.Size(41, 13);
            this.lbl_district.TabIndex = 6;
            this.lbl_district.Text = "* Bairro";
            // 
            // edt_houseNumber
            // 
            this.edt_houseNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_houseNumber.Location = new System.Drawing.Point(7, 89);
            this.edt_houseNumber.Margin = new System.Windows.Forms.Padding(2);
            this.edt_houseNumber.MaxLength = 10;
            this.edt_houseNumber.Name = "edt_houseNumber";
            this.edt_houseNumber.Size = new System.Drawing.Size(44, 20);
            this.edt_houseNumber.TabIndex = 5;
            this.edt_houseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_houseNumber
            // 
            this.lbl_houseNumber.AutoSize = true;
            this.lbl_houseNumber.Location = new System.Drawing.Point(4, 73);
            this.lbl_houseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_houseNumber.Name = "lbl_houseNumber";
            this.lbl_houseNumber.Size = new System.Drawing.Size(51, 13);
            this.lbl_houseNumber.TabIndex = 4;
            this.lbl_houseNumber.Text = "* Número";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(110, 20);
            this.lbl_street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(68, 13);
            this.lbl_street.TabIndex = 3;
            this.lbl_street.Text = "* Logradouro";
            // 
            // edt_street
            // 
            this.edt_street.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_street.Location = new System.Drawing.Point(112, 36);
            this.edt_street.Margin = new System.Windows.Forms.Padding(2);
            this.edt_street.MaxLength = 50;
            this.edt_street.Name = "edt_street";
            this.edt_street.Size = new System.Drawing.Size(252, 20);
            this.edt_street.TabIndex = 2;
            // 
            // lbl_zipCode
            // 
            this.lbl_zipCode.AutoSize = true;
            this.lbl_zipCode.Location = new System.Drawing.Point(4, 20);
            this.lbl_zipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_zipCode.Name = "lbl_zipCode";
            this.lbl_zipCode.Size = new System.Drawing.Size(35, 13);
            this.lbl_zipCode.TabIndex = 1;
            this.lbl_zipCode.Text = "* CEP";
            // 
            // medt_zipCode
            // 
            this.medt_zipCode.Location = new System.Drawing.Point(7, 36);
            this.medt_zipCode.Margin = new System.Windows.Forms.Padding(2);
            this.medt_zipCode.Mask = "0000000000";
            this.medt_zipCode.Name = "medt_zipCode";
            this.medt_zipCode.Size = new System.Drawing.Size(76, 20);
            this.medt_zipCode.TabIndex = 0;
            this.medt_zipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.medt_zipCode.ValidatingType = typeof(int);
            // 
            // gbox_phones
            // 
            this.gbox_phones.Controls.Add(this.lbl_requiredPhone);
            this.gbox_phones.Controls.Add(this.lbl_email);
            this.gbox_phones.Controls.Add(this.cbox_phone3);
            this.gbox_phones.Controls.Add(this.edt_email);
            this.gbox_phones.Controls.Add(this.cbox_phone2);
            this.gbox_phones.Controls.Add(this.medt_phone3);
            this.gbox_phones.Controls.Add(this.medt_phone2);
            this.gbox_phones.Controls.Add(this.cbox_phone1);
            this.gbox_phones.Controls.Add(this.medt_phone1);
            this.gbox_phones.Location = new System.Drawing.Point(11, 110);
            this.gbox_phones.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_phones.Name = "gbox_phones";
            this.gbox_phones.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_phones.Size = new System.Drawing.Size(185, 198);
            this.gbox_phones.TabIndex = 31;
            this.gbox_phones.TabStop = false;
            this.gbox_phones.Text = "Informação de Contato";
            // 
            // lbl_requiredPhone
            // 
            this.lbl_requiredPhone.AutoSize = true;
            this.lbl_requiredPhone.Location = new System.Drawing.Point(1, 112);
            this.lbl_requiredPhone.Name = "lbl_requiredPhone";
            this.lbl_requiredPhone.Size = new System.Drawing.Size(181, 13);
            this.lbl_requiredPhone.TabIndex = 24;
            this.lbl_requiredPhone.Text = "* Ao menos um contato é obrigatório.";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(4, 138);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(39, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "*E-mail";
            // 
            // cbox_phone3
            // 
            this.cbox_phone3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_phone3.FormattingEnabled = true;
            this.cbox_phone3.Location = new System.Drawing.Point(100, 89);
            this.cbox_phone3.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_phone3.Name = "cbox_phone3";
            this.cbox_phone3.Size = new System.Drawing.Size(61, 21);
            this.cbox_phone3.TabIndex = 5;
            // 
            // edt_email
            // 
            this.edt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_email.Location = new System.Drawing.Point(4, 152);
            this.edt_email.Margin = new System.Windows.Forms.Padding(2);
            this.edt_email.MaxLength = 30;
            this.edt_email.Name = "edt_email";
            this.edt_email.Size = new System.Drawing.Size(160, 20);
            this.edt_email.TabIndex = 22;
            // 
            // cbox_phone2
            // 
            this.cbox_phone2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_phone2.FormattingEnabled = true;
            this.cbox_phone2.Location = new System.Drawing.Point(100, 58);
            this.cbox_phone2.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_phone2.Name = "cbox_phone2";
            this.cbox_phone2.Size = new System.Drawing.Size(61, 21);
            this.cbox_phone2.TabIndex = 4;
            // 
            // medt_phone3
            // 
            this.medt_phone3.Location = new System.Drawing.Point(4, 90);
            this.medt_phone3.Margin = new System.Windows.Forms.Padding(2);
            this.medt_phone3.Mask = "(000) 00000-0000";
            this.medt_phone3.Name = "medt_phone3";
            this.medt_phone3.Size = new System.Drawing.Size(92, 20);
            this.medt_phone3.TabIndex = 3;
            // 
            // medt_phone2
            // 
            this.medt_phone2.Location = new System.Drawing.Point(4, 58);
            this.medt_phone2.Margin = new System.Windows.Forms.Padding(2);
            this.medt_phone2.Mask = "(000) 00000-0000";
            this.medt_phone2.Name = "medt_phone2";
            this.medt_phone2.Size = new System.Drawing.Size(92, 20);
            this.medt_phone2.TabIndex = 2;
            // 
            // cbox_phone1
            // 
            this.cbox_phone1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_phone1.FormattingEnabled = true;
            this.cbox_phone1.Location = new System.Drawing.Point(100, 27);
            this.cbox_phone1.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_phone1.Name = "cbox_phone1";
            this.cbox_phone1.Size = new System.Drawing.Size(61, 21);
            this.cbox_phone1.TabIndex = 1;
            // 
            // medt_phone1
            // 
            this.medt_phone1.Location = new System.Drawing.Point(4, 27);
            this.medt_phone1.Margin = new System.Windows.Forms.Padding(2);
            this.medt_phone1.Mask = "(000) 00000-0000";
            this.medt_phone1.Name = "medt_phone1";
            this.medt_phone1.Size = new System.Drawing.Size(92, 20);
            this.medt_phone1.TabIndex = 0;
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Location = new System.Drawing.Point(11, 75);
            this.medt_regNumber.Margin = new System.Windows.Forms.Padding(2);
            this.medt_regNumber.Mask = "000.000.000-00";
            this.medt_regNumber.Name = "medt_regNumber";
            this.medt_regNumber.Size = new System.Drawing.Size(116, 20);
            this.medt_regNumber.TabIndex = 30;
            this.medt_regNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.medt_regNumber.ValidatingType = typeof(int);
            this.medt_regNumber.Leave += new System.EventHandler(this.medt_regNumber_Leave);
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Location = new System.Drawing.Point(8, 60);
            this.lbl_regNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(108, 13);
            this.lbl_regNumber.TabIndex = 29;
            this.lbl_regNumber.Text = "* Número de Registro";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(126, 60);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(109, 13);
            this.lbl_dob.TabIndex = 27;
            this.lbl_dob.Text = "* Data de nascimento";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(234, 60);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(41, 13);
            this.lbl_age.TabIndex = 26;
            this.lbl_age.Text = "* Idade";
            // 
            // edt_age
            // 
            this.edt_age.Location = new System.Drawing.Point(237, 75);
            this.edt_age.Margin = new System.Windows.Forms.Padding(2);
            this.edt_age.MaxLength = 3;
            this.edt_age.Name = "edt_age";
            this.edt_age.Size = new System.Drawing.Size(31, 20);
            this.edt_age.TabIndex = 25;
            this.edt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_age.TextChanged += new System.EventHandler(this.edt_age_TextChanged);
            // 
            // gbox_gender
            // 
            this.gbox_gender.Controls.Add(this.check_otherGender);
            this.gbox_gender.Controls.Add(this.check_female);
            this.gbox_gender.Controls.Add(this.check_male);
            this.gbox_gender.Location = new System.Drawing.Point(537, 11);
            this.gbox_gender.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_gender.Name = "gbox_gender";
            this.gbox_gender.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_gender.Size = new System.Drawing.Size(124, 58);
            this.gbox_gender.TabIndex = 24;
            this.gbox_gender.TabStop = false;
            this.gbox_gender.Text = "* Gênero";
            // 
            // check_otherGender
            // 
            this.check_otherGender.AutoSize = true;
            this.check_otherGender.Location = new System.Drawing.Point(72, 38);
            this.check_otherGender.Margin = new System.Windows.Forms.Padding(2);
            this.check_otherGender.Name = "check_otherGender";
            this.check_otherGender.Size = new System.Drawing.Size(51, 17);
            this.check_otherGender.TabIndex = 2;
            this.check_otherGender.TabStop = true;
            this.check_otherGender.Text = "Outro";
            this.check_otherGender.UseVisualStyleBackColor = true;
            this.check_otherGender.CheckedChanged += new System.EventHandler(this.check_otherGender_CheckedChanged);
            // 
            // check_female
            // 
            this.check_female.AutoSize = true;
            this.check_female.Location = new System.Drawing.Point(4, 37);
            this.check_female.Margin = new System.Windows.Forms.Padding(2);
            this.check_female.Name = "check_female";
            this.check_female.Size = new System.Drawing.Size(67, 17);
            this.check_female.TabIndex = 1;
            this.check_female.TabStop = true;
            this.check_female.Text = "Feminino";
            this.check_female.UseVisualStyleBackColor = true;
            this.check_female.CheckedChanged += new System.EventHandler(this.check_female_CheckedChanged);
            // 
            // check_male
            // 
            this.check_male.AutoSize = true;
            this.check_male.Location = new System.Drawing.Point(5, 17);
            this.check_male.Margin = new System.Windows.Forms.Padding(2);
            this.check_male.Name = "check_male";
            this.check_male.Size = new System.Drawing.Size(73, 17);
            this.check_male.TabIndex = 0;
            this.check_male.TabStop = true;
            this.check_male.Text = "Masculino";
            this.check_male.UseVisualStyleBackColor = true;
            this.check_male.CheckedChanged += new System.EventHandler(this.check_male_CheckedChanged);
            // 
            // edt_Name
            // 
            this.edt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_Name.Location = new System.Drawing.Point(65, 24);
            this.edt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.edt_Name.MaxLength = 50;
            this.edt_Name.Name = "edt_Name";
            this.edt_Name.Size = new System.Drawing.Size(303, 20);
            this.edt_Name.TabIndex = 23;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(62, 8);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(42, 13);
            this.lbl_Name.TabIndex = 22;
            this.lbl_Name.Text = "* Nome";
            // 
            // medt_dob
            // 
            this.medt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.medt_dob.Location = new System.Drawing.Point(129, 75);
            this.medt_dob.MaxDate = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            this.medt_dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.medt_dob.Name = "medt_dob";
            this.medt_dob.Size = new System.Drawing.Size(83, 20);
            this.medt_dob.TabIndex = 33;
            this.medt_dob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.medt_dob.Leave += new System.EventHandler(this.medt_dob_Leave_1);
            // 
            // Frm_Create_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.medt_dob);
            this.Controls.Add(this.gbox_address);
            this.Controls.Add(this.gbox_phones);
            this.Controls.Add(this.medt_regNumber);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.edt_age);
            this.Controls.Add(this.gbox_gender);
            this.Controls.Add(this.edt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_People";
            this.Text = "Criar Pessoa";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.edt_Name, 0);
            this.Controls.SetChildIndex(this.gbox_gender, 0);
            this.Controls.SetChildIndex(this.edt_age, 0);
            this.Controls.SetChildIndex(this.lbl_age, 0);
            this.Controls.SetChildIndex(this.lbl_dob, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.Controls.SetChildIndex(this.gbox_phones, 0);
            this.Controls.SetChildIndex(this.gbox_address, 0);
            this.Controls.SetChildIndex(this.medt_dob, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_address.ResumeLayout(false);
            this.gbox_address.PerformLayout();
            this.gbox_phones.ResumeLayout(false);
            this.gbox_phones.PerformLayout();
            this.gbox_gender.ResumeLayout(false);
            this.gbox_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_homeType;
        private System.Windows.Forms.Button btn_findCity;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label Complement;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.Label lbl_houseNumber;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_zipCode;
        private System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.MaskedTextBox medt_regNumber;
        public System.Windows.Forms.Label lbl_regNumber;
        public System.Windows.Forms.Label lbl_dob;
        public System.Windows.Forms.Label lbl_age;
        public System.Windows.Forms.TextBox edt_age;
        public System.Windows.Forms.GroupBox gbox_gender;
        public System.Windows.Forms.RadioButton check_otherGender;
        public System.Windows.Forms.RadioButton check_female;
        public System.Windows.Forms.RadioButton check_male;
        public System.Windows.Forms.GroupBox gbox_address;
        public System.Windows.Forms.GroupBox gbox_phones;
        public System.Windows.Forms.TextBox edt_Name;
        public System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.TextBox edt_complement;
        public System.Windows.Forms.TextBox edt_district;
        public System.Windows.Forms.TextBox edt_houseNumber;
        public System.Windows.Forms.TextBox edt_street;
        public System.Windows.Forms.MaskedTextBox medt_zipCode;
        public System.Windows.Forms.ComboBox cbox_phone3;
        public System.Windows.Forms.TextBox edt_email;
        public System.Windows.Forms.ComboBox cbox_phone2;
        public System.Windows.Forms.MaskedTextBox medt_phone3;
        public System.Windows.Forms.MaskedTextBox medt_phone2;
        public System.Windows.Forms.ComboBox cbox_phone1;
        public System.Windows.Forms.MaskedTextBox medt_phone1;
        public System.Windows.Forms.TextBox edt_StateFU;
        public System.Windows.Forms.TextBox edt_countryAcronym;
        public System.Windows.Forms.TextBox edt_city;
        public System.Windows.Forms.TextBox edt_homeType;
        public System.Windows.Forms.DateTimePicker medt_dob;
        private System.Windows.Forms.Label lbl_requiredPhone;
    }
}
