namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProfession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(134, 22);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profession ";
            // 
            // cbProfession
            // 
            this.cbProfession.FormattingEnabled = true;
            this.cbProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue ",
            "Wizard"});
            this.cbProfession.Location = new System.Drawing.Point(113, 65);
            this.cbProfession.Name = "cbProfession";
            this.cbProfession.Size = new System.Drawing.Size(121, 21);
            this.cbProfession.TabIndex = 3;
            this.cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProfession);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // cbRace
            // 
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.cbRace.Location = new System.Drawing.Point(113, 133);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(121, 21);
            this.cbRace.TabIndex = 5;
            this.cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRace);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agility";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name";
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(134, 189);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(100, 20);
            this._txtStrength.TabIndex = 14;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributes);
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(134, 232);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(100, 20);
            this._txtIntelligence.TabIndex = 15;
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributes);
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(134, 273);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(100, 20);
            this._txtAgility.TabIndex = 16;
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributes);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(134, 321);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(100, 20);
            this._txtConstitution.TabIndex = 17;
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributes);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(413, 104);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(173, 105);
            this.txtDescription.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(437, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(579, 396);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Charisma";
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(134, 371);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(100, 20);
            this._txtCharisma.TabIndex = 23;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttributes);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProfession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProfession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}