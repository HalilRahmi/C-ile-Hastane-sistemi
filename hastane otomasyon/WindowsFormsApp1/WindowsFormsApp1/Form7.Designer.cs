namespace WindowsFormsApp1
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eczBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet = new WindowsFormsApp1.kayitDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servisTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.servisTableAdapter();
            this.hastaTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.hastaTableAdapter();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.poliTableAdapter();
            this.hastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet1 = new WindowsFormsApp1.kayitDataSet();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.eczTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilac1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilac2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilac3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "İlaç1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(329, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "SONUÇ EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ilac1,
            this.ilac2,
            this.ilac3,
            this.kod});
            this.dataGridView1.DataSource = this.eczBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 192);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // eczBindingSource
            // 
            this.eczBindingSource.DataMember = "ecz";
            this.eczBindingSource.DataSource = this.kayitDataSet;
            // 
            // kayitDataSet
            // 
            this.kayitDataSet.DataSetName = "kayitDataSet";
            this.kayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(400, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 109;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(400, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 101;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(400, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(159, 112);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "İlaç3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "İlaç 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "Hasta No :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(159, 81);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 107;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(159, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 106;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(159, 146);
            this.textBox4.MaxLength = 20;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 113;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(379, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 23);
            this.button4.TabIndex = 112;
            this.button4.Text = "Kayıt Sayısı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sonBindingSource
            // 
            this.sonBindingSource.DataMember = "son";
            this.sonBindingSource.DataSource = this.kayitDataSet;
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "hasta";
            this.hastaBindingSource.DataSource = this.kayitDataSet;
            // 
            // poliTableAdapter
            // 
            this.poliTableAdapter.ClearBeforeFill = true;
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
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "servis";
            this.servisBindingSource.DataSource = this.kayitDataSet1;
            // 
            // poliBindingSource
            // 
            this.poliBindingSource.DataMember = "poli";
            this.poliBindingSource.DataSource = this.kayitDataSet;
            // 
            // eczTableAdapter
            // 
            this.eczTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(820, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 70);
            this.button5.TabIndex = 114;
            this.button5.Text = "Nöbetçi Eczane Öğren";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "h_no";
            this.Column1.HeaderText = "Hasta No";
            this.Column1.Name = "Column1";
            // 
            // ilac1
            // 
            this.ilac1.DataPropertyName = "ilac1";
            this.ilac1.HeaderText = "ilac1";
            this.ilac1.Name = "ilac1";
            // 
            // ilac2
            // 
            this.ilac2.DataPropertyName = "ilac2";
            this.ilac2.HeaderText = "ilac2";
            this.ilac2.Name = "ilac2";
            // 
            // ilac3
            // 
            this.ilac3.DataPropertyName = "ilac3";
            this.ilac3.HeaderText = "ilac3";
            this.ilac3.Name = "ilac3";
            // 
            // kod
            // 
            this.kod.DataPropertyName = "kod";
            this.kod.HeaderText = "İlaç Kodu";
            this.kod.Name = "kod";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 491);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kayitDataSetTableAdapters.servisTableAdapter servisTableAdapter;
        private kayitDataSetTableAdapters.hastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private kayitDataSet kayitDataSet;
        private kayitDataSetTableAdapters.poliTableAdapter poliTableAdapter;
        private System.Windows.Forms.BindingSource hastaBindingSource1;
        private kayitDataSet kayitDataSet1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sonBindingSource;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource poliBindingSource;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource eczBindingSource;
        private kayitDataSetTableAdapters.eczTableAdapter eczTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilac1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilac2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilac3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
    }
}