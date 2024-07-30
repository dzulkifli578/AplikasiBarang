namespace AplikasiBarang
{
    partial class BarangView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewBarang = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxHarga = new TextBox();
            textBoxID = new TextBox();
            textBoxNama = new TextBox();
            buttonTambah = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBarang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 19);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 0;
            label1.Text = "Daftar Barang";
            // 
            // dataGridViewBarang
            // 
            dataGridViewBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBarang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBarang.Location = new Point(12, 231);
            dataGridViewBarang.Name = "dataGridViewBarang";
            dataGridViewBarang.Size = new Size(776, 207);
            dataGridViewBarang.TabIndex = 1;
            dataGridViewBarang.CellDoubleClick += dataGridViewBarang_CellDoubleClick;
            dataGridViewBarang.CellFormatting += dataGridViewBarang_CellFormatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 72);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(34, 112);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 152);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Harga";
            // 
            // textBoxHarga
            // 
            textBoxHarga.Font = new Font("Segoe UI", 12F);
            textBoxHarga.Location = new Point(125, 149);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(293, 29);
            textBoxHarga.TabIndex = 5;
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Font = new Font("Segoe UI", 12F);
            textBoxID.Location = new Point(125, 69);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(293, 29);
            textBoxID.TabIndex = 6;
            // 
            // textBoxNama
            // 
            textBoxNama.Font = new Font("Segoe UI", 12F);
            textBoxNama.Location = new Point(125, 109);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(293, 29);
            textBoxNama.TabIndex = 7;
            // 
            // buttonTambah
            // 
            buttonTambah.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTambah.Location = new Point(455, 123);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(90, 40);
            buttonTambah.TabIndex = 8;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(566, 123);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(90, 40);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHapus.Location = new Point(677, 123);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(90, 40);
            buttonHapus.TabIndex = 10;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(34, 192);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Tidak Tersedia", "Tersedia" });
            comboBoxStatus.Location = new Point(125, 189);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(293, 29);
            comboBoxStatus.TabIndex = 12;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // BarangView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStatus);
            Controls.Add(label5);
            Controls.Add(buttonHapus);
            Controls.Add(buttonEdit);
            Controls.Add(buttonTambah);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxID);
            Controls.Add(textBoxHarga);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewBarang);
            Controls.Add(label1);
            Name = "BarangView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barang";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewBarang;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxHarga;
        private TextBox textBoxID;
        private TextBox textBoxNama;
        private Button buttonTambah;
        private Button buttonEdit;
        private Button buttonHapus;
        private Label label5;
        private ComboBox comboBoxStatus;
    }
}
