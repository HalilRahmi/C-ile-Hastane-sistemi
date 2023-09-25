namespace WindowsFormsApp1
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet1 = new WindowsFormsApp1.kayitDataSet();
            this.servisTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.servisTableAdapter();
            this.hastaTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.hastaTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet = new WindowsFormsApp1.kayitDataSet();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(530, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 84;
            this.button4.Text = "Kayıt Sayısı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALGOLOJİ",
            "BESLENME VE DİYET",
            "BEYİN VE SİNİR CERRAHİSİ",
            "ÇOCUK ALERJİSİ",
            "ÇOCUK CERRAHİSİ",
            "ÇOCUK ENDOKRİNOLOJİSİ",
            "ÇOCUK ENFEKSİYON",
            "ÇOCUK GÖĞÜS HASTALIKLARI",
            "ÇOCUK HEMATOLOJİSİ",
            "ÇOCUK KARDİYOLOJİSİ",
            "ÇOCUK METABOLİZMA",
            "ÇOCUK NEFROLOJİSİ",
            "ÇOCUK NÖROLOJİSİ",
            "ÇOCUK PSİKİYATRİSİ",
            "ÇOCUK SAĞLIĞI VE HASTALIKLARI",
            "ÇOCUK ÜROLOJİSİ",
            "DERMATOLOJİ (CİLDİYE)",
            "ENDOKRİNOLOJİ VE METABOLİZMA",
            "ENFEKSİYON HASTALIKLARI",
            "FİZİKSEL TIP VE REHABİLİTASYON",
            "GASTROENTEROLOJİ",
            "GELENEKSEL VE TAMAMLAYICI TIP(GETAMER)",
            "GENEL CERRAHİ",
            "GERİATRİ",
            "GÖĞÜS CERRAHİSİ",
            "GÖĞÜS HASTALIKLARI",
            "GÖZ HASTALIKLARI",
            "HEMATOLOJİ",
            "İÇ HASTALIKLARI",
            "KADIN HASTALIKLARI VE DOĞUM",
            "KALP VE DAMAR CERRAHİSİ",
            "KARDİYOLOJİ",
            "KEMİK YOĞUNLUĞU ÖLÇÜMÜ",
            "KULAK-BURUN-BOĞAZ HASTALIKLARI",
            "NEFROLOJİ",
            "NÖROLOJİ",
            "ORTOPEDİ VE TRAVMATOLOJİ",
            "PLASTİK REKONSTRÜKTİF VE ESTETİK CERRAHİ",
            "PSİKİYATRİ",
            "RADYASYON ONKOLOJİSİ",
            "TIBBİ GENETİK",
            "TIBBİ PATOLOJİ",
            "ÜROLOJİ"});
            this.comboBox1.Location = new System.Drawing.Point(233, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(129, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Saat";
            // 
            // hastaBindingSource1
            // 
            this.hastaBindingSource1.DataMember = "hasta";
            this.hastaBindingSource1.DataSource = this.kayitDataSet1;
            // 
            // kayitDataSet1
            // 
            this.kayitDataSet1.DataSetName = "kayitDataSet";
            this.kayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(403, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "SERVİS SEÇİM EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hnoDataGridViewTextBoxColumn,
            this.servis,
            this.dr,
            this.tarih,
            this.saat});
            this.dataGridView1.DataSource = this.servisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(132, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 192);
            this.dataGridView1.TabIndex = 79;
            // 
            // hnoDataGridViewTextBoxColumn
            // 
            this.hnoDataGridViewTextBoxColumn.DataPropertyName = "h_no";
            this.hnoDataGridViewTextBoxColumn.HeaderText = "Hasta no";
            this.hnoDataGridViewTextBoxColumn.Name = "hnoDataGridViewTextBoxColumn";
            // 
            // servis
            // 
            this.servis.DataPropertyName = "servis";
            this.servis.HeaderText = "servis";
            this.servis.Name = "servis";
            // 
            // dr
            // 
            this.dr.DataPropertyName = "dr";
            this.dr.HeaderText = "Doktor";
            this.dr.Name = "dr";
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "tarih";
            this.tarih.Name = "tarih";
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "saat";
            this.saat.Name = "saat";
            // 
            // servisBindingSource1
            // 
            this.servisBindingSource1.DataMember = "servis";
            this.servisBindingSource1.DataSource = this.kayitDataSet;
            // 
            // kayitDataSet
            // 
            this.kayitDataSet.DataSetName = "kayitDataSet";
            this.kayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "servis";
            this.servisBindingSource.DataSource = this.kayitDataSet1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(474, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 78;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(474, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(474, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(233, 169);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 77;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(233, 106);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 76;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(233, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(129, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Doktor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Hasta No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(129, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Servis :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource hastaBindingSource1;
        private kayitDataSet kayitDataSet1;
        private kayitDataSetTableAdapters.servisTableAdapter servisTableAdapter;
        private kayitDataSetTableAdapters.hastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dr;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource servisBindingSource1;
        private kayitDataSet kayitDataSet;
    }
}