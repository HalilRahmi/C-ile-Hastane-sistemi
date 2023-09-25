namespace WindowsFormsApp1
{
    partial class Form6
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.poliBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet1 = new WindowsFormsApp1.kayitDataSet();
            this.sonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hormonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hormon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poliTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.poliTableAdapter();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.hastaTableAdapter();
            this.servisTableAdapter = new WindowsFormsApp1.kayitDataSetTableAdapters.servisTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(233, 140);
            this.textBox4.MaxLength = 20;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 99;
            // 
            // poliBindingSource
            // 
            this.poliBindingSource.DataMember = "poli";
            this.poliBindingSource.DataSource = this.kayitDataSet;
            // 
            // kayitDataSet
            // 
            this.kayitDataSet.DataSetName = "kayitDataSet";
            this.kayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(474, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 95;
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
            this.button2.TabIndex = 87;
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
            this.button1.TabIndex = 86;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(233, 106);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Hormon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(129, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "İdrar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Hasta No :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(233, 75);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 93;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(233, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 92;
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "servis";
            this.servisBindingSource.DataSource = this.kayitDataSet1;
            // 
            // kayitDataSet1
            // 
            this.kayitDataSet1.DataSetName = "kayitDataSet";
            this.kayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sonBindingSource
            // 
            this.sonBindingSource.DataMember = "son";
            this.sonBindingSource.DataSource = this.kayitDataSet;
            // 
            // hormonDataGridViewTextBoxColumn
            // 
            this.hormonDataGridViewTextBoxColumn.DataPropertyName = "hormon";
            this.hormonDataGridViewTextBoxColumn.HeaderText = "hormon";
            this.hormonDataGridViewTextBoxColumn.Name = "hormonDataGridViewTextBoxColumn";
            // 
            // idrarDataGridViewTextBoxColumn
            // 
            this.idrarDataGridViewTextBoxColumn.DataPropertyName = "idrar";
            this.idrarDataGridViewTextBoxColumn.HeaderText = "idrar";
            this.idrarDataGridViewTextBoxColumn.Name = "idrarDataGridViewTextBoxColumn";
            // 
            // kanDataGridViewTextBoxColumn
            // 
            this.kanDataGridViewTextBoxColumn.DataPropertyName = "kan";
            this.kanDataGridViewTextBoxColumn.HeaderText = "kan";
            this.kanDataGridViewTextBoxColumn.Name = "kanDataGridViewTextBoxColumn";
            // 
            // hnoDataGridViewTextBoxColumn
            // 
            this.hnoDataGridViewTextBoxColumn.DataPropertyName = "h_no";
            this.hnoDataGridViewTextBoxColumn.HeaderText = "h_no";
            this.hnoDataGridViewTextBoxColumn.Name = "hnoDataGridViewTextBoxColumn";
            // 
            // hormon
            // 
            this.hormon.DataPropertyName = "hormon";
            this.hormon.HeaderText = "HORMON";
            this.hormon.Name = "hormon";
            // 
            // idrar
            // 
            this.idrar.DataPropertyName = "idrar";
            this.idrar.HeaderText = "İDRAR";
            this.idrar.Name = "idrar";
            // 
            // kan
            // 
            this.kan.DataPropertyName = "kan";
            this.kan.HeaderText = "KAN";
            this.kan.Name = "kan";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "h_no";
            this.Column1.HeaderText = "Hasta No";
            this.Column1.Name = "Column1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(403, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "SONUÇ EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.kan,
            this.idrar,
            this.hormon,
            this.hnoDataGridViewTextBoxColumn,
            this.kanDataGridViewTextBoxColumn,
            this.idrarDataGridViewTextBoxColumn,
            this.hormonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 192);
            this.dataGridView1.TabIndex = 96;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // hastaBindingSource1
            // 
            this.hastaBindingSource1.DataMember = "hasta";
            this.hastaBindingSource1.DataSource = this.kayitDataSet1;
            // 
            // poliTableAdapter
            // 
            this.poliTableAdapter.ClearBeforeFill = true;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "hasta";
            this.hastaBindingSource.DataSource = this.kayitDataSet;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(453, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 23);
            this.button4.TabIndex = 98;
            this.button4.Text = "Kayıt Sayısı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(129, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Kan :";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource poliBindingSource;
        private kayitDataSet kayitDataSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private kayitDataSet kayitDataSet1;
        private System.Windows.Forms.BindingSource sonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hormonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hormon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaBindingSource1;
        private kayitDataSetTableAdapters.poliTableAdapter poliTableAdapter;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private kayitDataSetTableAdapters.hastaTableAdapter hastaTableAdapter;
        private kayitDataSetTableAdapters.servisTableAdapter servisTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}