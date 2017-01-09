namespace Secure_Password_Generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.LinkLabel();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.helpSymbols = new System.Windows.Forms.LinkLabel();
            this.checkIncLetters = new System.Windows.Forms.CheckBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.radioMix = new System.Windows.Forms.RadioButton();
            this.passwordLength = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radioLower = new System.Windows.Forms.RadioButton();
            this.radioUpper = new System.Windows.Forms.RadioButton();
            this.checkIncSyms = new System.Windows.Forms.CheckBox();
            this.checkIncNums = new System.Windows.Forms.CheckBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.middleBox = new System.Windows.Forms.GroupBox();
            this.upperBox = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.middleBox.SuspendLayout();
            this.upperBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Secure_Password_Generator.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 122);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLinkedIn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblGitHub);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(449, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "If you wish to contribute to this project, please feel free to clone its GitHub r" +
    "epository.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkedIn.Location = new System.Drawing.Point(54, 201);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(56, 13);
            this.lblLinkedIn.TabIndex = 15;
            this.lblLinkedIn.TabStop = true;
            this.lblLinkedIn.Text = "LinkedIn";
            this.lblLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkedIn_LinkClicked);
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitHub.Location = new System.Drawing.Point(34, 181);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(97, 13);
            this.lblGitHub.TabIndex = 14;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "GitHub/README";
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Code by Yazin Yousif\r\nStudent at UC San Diego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpSymbols
            // 
            this.helpSymbols.AutoSize = true;
            this.helpSymbols.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSymbols.Location = new System.Drawing.Point(242, 210);
            this.helpSymbols.Name = "helpSymbols";
            this.helpSymbols.Size = new System.Drawing.Size(20, 13);
            this.helpSymbols.TabIndex = 9;
            this.helpSymbols.TabStop = true;
            this.helpSymbols.Text = "(?)";
            this.helpSymbols.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpSymbols_LinkClicked);
            // 
            // checkIncLetters
            // 
            this.checkIncLetters.AutoSize = true;
            this.checkIncLetters.Checked = true;
            this.checkIncLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncLetters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIncLetters.Location = new System.Drawing.Point(144, 95);
            this.checkIncLetters.Name = "checkIncLetters";
            this.checkIncLetters.Size = new System.Drawing.Size(98, 17);
            this.checkIncLetters.TabIndex = 3;
            this.checkIncLetters.Text = "Include Letters";
            this.checkIncLetters.UseVisualStyleBackColor = true;
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHint.Location = new System.Drawing.Point(6, 25);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(414, 44);
            this.lblHint.TabIndex = 12;
            this.lblHint.Text = resources.GetString("lblHint.Text");
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioMix
            // 
            this.radioMix.AutoSize = true;
            this.radioMix.Checked = true;
            this.radioMix.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMix.Location = new System.Drawing.Point(144, 164);
            this.radioMix.Name = "radioMix";
            this.radioMix.Size = new System.Drawing.Size(139, 17);
            this.radioMix.TabIndex = 6;
            this.radioMix.TabStop = true;
            this.radioMix.Text = "Mix of Upper and Lower";
            this.radioMix.UseVisualStyleBackColor = true;
            // 
            // passwordLength
            // 
            this.passwordLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLength.FormattingEnabled = true;
            this.passwordLength.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.passwordLength.Location = new System.Drawing.Point(9, 92);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(129, 134);
            this.passwordLength.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(6, 25);
            this.txtPassword.MaxLength = 40;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(487, 26);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioLower
            // 
            this.radioLower.AutoSize = true;
            this.radioLower.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLower.Location = new System.Drawing.Point(144, 141);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(68, 17);
            this.radioLower.TabIndex = 5;
            this.radioLower.Text = "All Lower";
            this.radioLower.UseVisualStyleBackColor = true;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUpper.Location = new System.Drawing.Point(144, 118);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(68, 17);
            this.radioUpper.TabIndex = 4;
            this.radioUpper.Text = "All Upper";
            this.radioUpper.UseVisualStyleBackColor = true;
            // 
            // checkIncSyms
            // 
            this.checkIncSyms.AutoSize = true;
            this.checkIncSyms.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIncSyms.Location = new System.Drawing.Point(144, 209);
            this.checkIncSyms.Name = "checkIncSyms";
            this.checkIncSyms.Size = new System.Drawing.Size(103, 17);
            this.checkIncSyms.TabIndex = 8;
            this.checkIncSyms.Text = "Include Symbols";
            this.checkIncSyms.UseVisualStyleBackColor = true;
            // 
            // checkIncNums
            // 
            this.checkIncNums.AutoSize = true;
            this.checkIncNums.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIncNums.Location = new System.Drawing.Point(144, 186);
            this.checkIncNums.Name = "checkIncNums";
            this.checkIncNums.Size = new System.Drawing.Size(106, 17);
            this.checkIncNums.TabIndex = 7;
            this.checkIncNums.Text = "Include Numbers";
            this.checkIncNums.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(6, 76);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(44, 13);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "Length:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(499, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // middleBox
            // 
            this.middleBox.Controls.Add(this.helpSymbols);
            this.middleBox.Controls.Add(this.checkIncLetters);
            this.middleBox.Controls.Add(this.lblHint);
            this.middleBox.Controls.Add(this.radioMix);
            this.middleBox.Controls.Add(this.radioLower);
            this.middleBox.Controls.Add(this.radioUpper);
            this.middleBox.Controls.Add(this.checkIncSyms);
            this.middleBox.Controls.Add(this.checkIncNums);
            this.middleBox.Controls.Add(this.lblLength);
            this.middleBox.Controls.Add(this.passwordLength);
            this.middleBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleBox.Location = new System.Drawing.Point(11, 82);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(426, 239);
            this.middleBox.TabIndex = 3;
            this.middleBox.TabStop = false;
            this.middleBox.Text = "Password Criteria";
            // 
            // upperBox
            // 
            this.upperBox.Controls.Add(this.btnClear);
            this.upperBox.Controls.Add(this.txtPassword);
            this.upperBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperBox.Location = new System.Drawing.Point(11, 12);
            this.upperBox.Name = "upperBox";
            this.upperBox.Size = new System.Drawing.Size(602, 62);
            this.upperBox.TabIndex = 0;
            this.upperBox.TabStop = false;
            this.upperBox.Text = "Generated Password";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(299, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 31);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(11, 327);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 31);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "&Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(155, 327);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(138, 31);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "&Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(625, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.upperBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Password Generator.NET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.middleBox.ResumeLayout(false);
            this.middleBox.PerformLayout();
            this.upperBox.ResumeLayout(false);
            this.upperBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblLinkedIn;
        private System.Windows.Forms.LinkLabel lblGitHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel helpSymbols;
        private System.Windows.Forms.CheckBox checkIncLetters;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.RadioButton radioMix;
        private System.Windows.Forms.ListBox passwordLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.CheckBox checkIncSyms;
        private System.Windows.Forms.CheckBox checkIncNums;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox middleBox;
        private System.Windows.Forms.GroupBox upperBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
    }
}

