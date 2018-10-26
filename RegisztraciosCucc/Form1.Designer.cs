namespace RegisztraciosCucc
{
    partial class Form1
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
            this.NevLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.NemLabel = new System.Windows.Forms.Label();
            this.HobbiLobbi = new System.Windows.Forms.Label();
            this.ujhobbiLabel = new System.Windows.Forms.Label();
            this.FERFI = new System.Windows.Forms.RadioButton();
            this.NO = new System.Windows.Forms.RadioButton();
            this.DatumTextBox = new System.Windows.Forms.TextBox();
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.UjHobbiTextBox = new System.Windows.Forms.TextBox();
            this.HobbiListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // NevLabel
            // 
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(24, 13);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(27, 13);
            this.NevLabel.TabIndex = 1;
            this.NevLabel.Text = "Név";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(24, 40);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(62, 13);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "Szül. dátum";
            // 
            // NemLabel
            // 
            this.NemLabel.AutoSize = true;
            this.NemLabel.Location = new System.Drawing.Point(54, 89);
            this.NemLabel.Name = "NemLabel";
            this.NemLabel.Size = new System.Drawing.Size(32, 13);
            this.NemLabel.TabIndex = 3;
            this.NemLabel.Text = "Nem:";
            // 
            // HobbiLobbi
            // 
            this.HobbiLobbi.AutoSize = true;
            this.HobbiLobbi.Location = new System.Drawing.Point(265, 23);
            this.HobbiLobbi.Name = "HobbiLobbi";
            this.HobbiLobbi.Size = new System.Drawing.Size(82, 13);
            this.HobbiLobbi.TabIndex = 4;
            this.HobbiLobbi.Text = "Kedvenc hobbi:";
            // 
            // ujhobbiLabel
            // 
            this.ujhobbiLabel.AutoSize = true;
            this.ujhobbiLabel.Location = new System.Drawing.Point(213, 166);
            this.ujhobbiLabel.Name = "ujhobbiLabel";
            this.ujhobbiLabel.Size = new System.Drawing.Size(49, 13);
            this.ujhobbiLabel.TabIndex = 5;
            this.ujhobbiLabel.Text = "Új hobbi:";
            // 
            // FERFI
            // 
            this.FERFI.AutoSize = true;
            this.FERFI.Location = new System.Drawing.Point(103, 87);
            this.FERFI.Name = "FERFI";
            this.FERFI.Size = new System.Drawing.Size(31, 17);
            this.FERFI.TabIndex = 6;
            this.FERFI.TabStop = true;
            this.FERFI.Text = "F";
            this.FERFI.UseVisualStyleBackColor = true;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(149, 87);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(33, 17);
            this.NO.TabIndex = 7;
            this.NO.TabStop = true;
            this.NO.Text = "N";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // DatumTextBox
            // 
            this.DatumTextBox.Location = new System.Drawing.Point(92, 37);
            this.DatumTextBox.Name = "DatumTextBox";
            this.DatumTextBox.Size = new System.Drawing.Size(100, 20);
            this.DatumTextBox.TabIndex = 8;
            // 
            // NevTextBox
            // 
            this.NevTextBox.Location = new System.Drawing.Point(92, 11);
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(100, 20);
            this.NevTextBox.TabIndex = 9;
            // 
            // UjHobbiTextBox
            // 
            this.UjHobbiTextBox.Location = new System.Drawing.Point(268, 163);
            this.UjHobbiTextBox.Name = "UjHobbiTextBox";
            this.UjHobbiTextBox.Size = new System.Drawing.Size(100, 20);
            this.UjHobbiTextBox.TabIndex = 10;
            // 
            // HobbiListBox
            // 
            this.HobbiListBox.FormattingEnabled = true;
            this.HobbiListBox.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.HobbiListBox.Location = new System.Drawing.Point(248, 39);
            this.HobbiListBox.Name = "HobbiListBox";
            this.HobbiListBox.Size = new System.Drawing.Size(120, 95);
            this.HobbiListBox.TabIndex = 12;
            this.HobbiListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(293, 189);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Hozzáadás";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(212, 246);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(293, 246);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 15;
            this.OpenButton.Text = "Megnyitás";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Filter = "Szöveges fájlok |*.txt|Többi fájl|*.*\".";
            // 
            // Save
            // 
            this.Save.Filter = "Szöveges fájlok |*.txt|Többi fájl|*.*\".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 281);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HobbiListBox);
            this.Controls.Add(this.UjHobbiTextBox);
            this.Controls.Add(this.NevTextBox);
            this.Controls.Add(this.DatumTextBox);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.FERFI);
            this.Controls.Add(this.ujhobbiLabel);
            this.Controls.Add(this.HobbiLobbi);
            this.Controls.Add(this.NemLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.NevLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label NemLabel;
        private System.Windows.Forms.Label HobbiLobbi;
        private System.Windows.Forms.Label ujhobbiLabel;
        private System.Windows.Forms.RadioButton FERFI;
        private System.Windows.Forms.RadioButton NO;
        private System.Windows.Forms.TextBox DatumTextBox;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.TextBox UjHobbiTextBox;
        private System.Windows.Forms.ListBox HobbiListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.SaveFileDialog Save;
    }
}

