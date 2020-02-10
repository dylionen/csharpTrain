namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ValueSQL = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.openExcel = new System.Windows.Forms.Button();
            this.getFile = new System.Windows.Forms.Button();
            this.excelLocalization = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.getFromExcel = new System.Windows.Forms.Button();
            this.sqlValue = new System.Windows.Forms.TextBox();
            this.inserValuestoDB = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknij ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(76, 126);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(169, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Połącz z bazą";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rozłącz z bazą";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ValueSQL
            // 
            this.ValueSQL.Location = new System.Drawing.Point(201, 156);
            this.ValueSQL.Name = "ValueSQL";
            this.ValueSQL.Size = new System.Drawing.Size(311, 22);
            this.ValueSQL.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "DodajDoBazy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(76, 184);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(497, 22);
            this.ErrorBox.TabIndex = 6;
            this.ErrorBox.Text = "Error box";
            // 
            // Tabela
            // 
            this.Tabela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(35, 212);
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            this.Tabela.RowHeadersWidth = 51;
            this.Tabela.RowTemplate.Height = 24;
            this.Tabela.Size = new System.Drawing.Size(606, 154);
            this.Tabela.TabIndex = 7;
            // 
            // openExcel
            // 
            this.openExcel.Location = new System.Drawing.Point(76, 372);
            this.openExcel.Name = "openExcel";
            this.openExcel.Size = new System.Drawing.Size(169, 23);
            this.openExcel.TabIndex = 8;
            this.openExcel.Text = "Otwórz arkusz Excel";
            this.openExcel.UseVisualStyleBackColor = true;
            this.openExcel.Click += new System.EventHandler(this.openExcel_Click);
            // 
            // getFile
            // 
            this.getFile.Location = new System.Drawing.Point(251, 372);
            this.getFile.Name = "getFile";
            this.getFile.Size = new System.Drawing.Size(75, 23);
            this.getFile.TabIndex = 9;
            this.getFile.Text = "Wybierz plik";
            this.getFile.UseVisualStyleBackColor = true;
            this.getFile.Click += new System.EventHandler(this.getFile_Click);
            // 
            // excelLocalization
            // 
            this.excelLocalization.Enabled = false;
            this.excelLocalization.Location = new System.Drawing.Point(332, 372);
            this.excelLocalization.Name = "excelLocalization";
            this.excelLocalization.Size = new System.Drawing.Size(241, 22);
            this.excelLocalization.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(497, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Wprowadź wartość";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // getFromExcel
            // 
            this.getFromExcel.Location = new System.Drawing.Point(76, 466);
            this.getFromExcel.Name = "getFromExcel";
            this.getFromExcel.Size = new System.Drawing.Size(497, 23);
            this.getFromExcel.TabIndex = 12;
            this.getFromExcel.Text = "Pobierz wartości";
            this.getFromExcel.UseVisualStyleBackColor = true;
            this.getFromExcel.Click += new System.EventHandler(this.button6_Click);
            // 
            // sqlValue
            // 
            this.sqlValue.Location = new System.Drawing.Point(76, 509);
            this.sqlValue.Name = "sqlValue";
            this.sqlValue.Size = new System.Drawing.Size(497, 22);
            this.sqlValue.TabIndex = 13;
            this.sqlValue.Text = "Generowane zapytanie";
            // 
            // inserValuestoDB
            // 
            this.inserValuestoDB.Location = new System.Drawing.Point(76, 509);
            this.inserValuestoDB.Name = "inserValuestoDB";
            this.inserValuestoDB.Size = new System.Drawing.Size(497, 23);
            this.inserValuestoDB.TabIndex = 14;
            this.inserValuestoDB.Text = "Wprowdź wartości do bazy";
            this.inserValuestoDB.UseVisualStyleBackColor = true;
            this.inserValuestoDB.Click += new System.EventHandler(this.inserValuestoDB_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wybierz arkusz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inserValuestoDB);
            this.Controls.Add(this.sqlValue);
            this.Controls.Add(this.getFromExcel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.excelLocalization);
            this.Controls.Add(this.getFile);
            this.Controls.Add(this.openExcel);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ValueSQL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Programik";
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ValueSQL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Button openExcel;
        private System.Windows.Forms.Button getFile;
        private System.Windows.Forms.TextBox excelLocalization;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button getFromExcel;
        private System.Windows.Forms.TextBox sqlValue;
        private System.Windows.Forms.Button inserValuestoDB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

