namespace WinFormsApp1
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            stuffPriceTB = new TextBox();
            subTotalTB = new TextBox();
            qtyTb = new TextBox();
            stuffNameTB = new TextBox();
            stuffIdCB = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            cancelButton = new Button();
            addButton = new Button();
            exitButton = new Button();
            saveButton = new Button();
            noFakturTB = new TextBox();
            dateTB = new TextBox();
            operatorTB = new TextBox();
            dataGridView1 = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            totalTB = new TextBox();
            moneyTB = new TextBox();
            chanceTB = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 0;
            label1.Text = "Aptek XYZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 59);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 1;
            label2.Text = "Drug Store and Supplier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(47, 92);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 2;
            label3.Text = "No Faktur";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(47, 128);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 3;
            label4.Text = "Tgl Faktur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(669, 92);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 4;
            label5.Text = "Operator";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stuffPriceTB);
            groupBox1.Controls.Add(subTotalTB);
            groupBox1.Controls.Add(qtyTb);
            groupBox1.Controls.Add(stuffNameTB);
            groupBox1.Controls.Add(stuffIdCB);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(41, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // stuffPriceTB
            // 
            stuffPriceTB.BackColor = SystemColors.Info;
            stuffPriceTB.Font = new Font("Segoe UI", 10F);
            stuffPriceTB.Location = new Point(437, 50);
            stuffPriceTB.Name = "stuffPriceTB";
            stuffPriceTB.ReadOnly = true;
            stuffPriceTB.Size = new Size(140, 30);
            stuffPriceTB.TabIndex = 19;
            // 
            // subTotalTB
            // 
            subTotalTB.BackColor = SystemColors.Info;
            subTotalTB.Font = new Font("Segoe UI", 10F);
            subTotalTB.Location = new Point(704, 50);
            subTotalTB.Name = "subTotalTB";
            subTotalTB.ReadOnly = true;
            subTotalTB.Size = new Size(174, 30);
            subTotalTB.TabIndex = 18;
            subTotalTB.TextAlign = HorizontalAlignment.Right;
            // 
            // qtyTb
            // 
            qtyTb.Font = new Font("Segoe UI", 10F);
            qtyTb.Location = new Point(597, 50);
            qtyTb.Name = "qtyTb";
            qtyTb.Size = new Size(94, 30);
            qtyTb.TabIndex = 17;
            qtyTb.TextAlign = HorizontalAlignment.Right;
            qtyTb.TextChanged += qtyTb_TextChanged;
            qtyTb.KeyPress += qtyTb_KeyPress;
            // 
            // stuffNameTB
            // 
            stuffNameTB.BackColor = SystemColors.Info;
            stuffNameTB.Font = new Font("Segoe UI", 10F);
            stuffNameTB.Location = new Point(205, 49);
            stuffNameTB.Name = "stuffNameTB";
            stuffNameTB.ReadOnly = true;
            stuffNameTB.Size = new Size(213, 30);
            stuffNameTB.TabIndex = 16;
            // 
            // stuffIdCB
            // 
            stuffIdCB.Font = new Font("Segoe UI", 10F);
            stuffIdCB.FormattingEnabled = true;
            stuffIdCB.Location = new Point(16, 49);
            stuffIdCB.Name = "stuffIdCB";
            stuffIdCB.Size = new Size(180, 31);
            stuffIdCB.TabIndex = 16;
            stuffIdCB.SelectedIndexChanged += stuffIdCB_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(597, 24);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 9;
            label10.Text = "Jml Beli";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(704, 24);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 9;
            label9.Text = "Sub Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(437, 23);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 8;
            label8.Text = "Harga Satuan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(205, 23);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 7;
            label7.Text = "Nama Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(16, 23);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 6;
            label6.Text = "Kode Barang";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(41, 552);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 7;
            label11.Text = "Perhatian !";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(41, 586);
            label12.Name = "label12";
            label12.Size = new Size(308, 46);
            label12.TabIndex = 8;
            label12.Text = "Barang Yang Sudah DIbeli, Tidak Dapat\r\nDitukar atau Dikembalikan";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(725, 281);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(825, 281);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(43, 676);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Location = new Point(838, 676);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // noFakturTB
            // 
            noFakturTB.BackColor = SystemColors.Info;
            noFakturTB.Font = new Font("Segoe UI", 10F);
            noFakturTB.Location = new Point(159, 89);
            noFakturTB.Name = "noFakturTB";
            noFakturTB.ReadOnly = true;
            noFakturTB.Size = new Size(144, 30);
            noFakturTB.TabIndex = 13;
            // 
            // dateTB
            // 
            dateTB.BackColor = SystemColors.Info;
            dateTB.Font = new Font("Segoe UI", 10F);
            dateTB.Location = new Point(159, 125);
            dateTB.Name = "dateTB";
            dateTB.ReadOnly = true;
            dateTB.Size = new Size(144, 30);
            dateTB.TabIndex = 14;
            dateTB.TextChanged += textBox2_TextChanged;
            // 
            // operatorTB
            // 
            operatorTB.BackColor = SystemColors.Info;
            operatorTB.Font = new Font("Segoe UI", 10F);
            operatorTB.Location = new Point(775, 89);
            operatorTB.Name = "operatorTB";
            operatorTB.ReadOnly = true;
            operatorTB.Size = new Size(144, 30);
            operatorTB.TabIndex = 15;
            operatorTB.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(43, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(889, 199);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(669, 552);
            label13.Name = "label13";
            label13.Size = new Size(49, 23);
            label13.TabIndex = 17;
            label13.Text = "Total";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(669, 592);
            label14.Name = "label14";
            label14.Size = new Size(86, 23);
            label14.TabIndex = 18;
            label14.Text = "Jml Uang";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label15.Location = new Point(669, 635);
            label15.Name = "label15";
            label15.Size = new Size(76, 23);
            label15.TabIndex = 19;
            label15.Text = "Kembali";
            // 
            // totalTB
            // 
            totalTB.BackColor = SystemColors.Info;
            totalTB.Font = new Font("Segoe UI", 10F);
            totalTB.Location = new Point(758, 549);
            totalTB.Name = "totalTB";
            totalTB.ReadOnly = true;
            totalTB.Size = new Size(174, 30);
            totalTB.TabIndex = 19;
            totalTB.TextAlign = HorizontalAlignment.Right;
            totalTB.TextChanged += totalTB_TextChanged;
            // 
            // moneyTB
            // 
            moneyTB.Font = new Font("Segoe UI", 10F);
            moneyTB.Location = new Point(758, 589);
            moneyTB.Name = "moneyTB";
            moneyTB.Size = new Size(174, 30);
            moneyTB.TabIndex = 20;
            moneyTB.TextAlign = HorizontalAlignment.Right;
            moneyTB.TextChanged += moneyTB_TextChanged;
            moneyTB.KeyPress += moneyTB_KeyPress;
            // 
            // chanceTB
            // 
            chanceTB.BackColor = SystemColors.Info;
            chanceTB.Font = new Font("Segoe UI", 10F);
            chanceTB.Location = new Point(758, 632);
            chanceTB.Name = "chanceTB";
            chanceTB.ReadOnly = true;
            chanceTB.Size = new Size(174, 30);
            chanceTB.TabIndex = 21;
            chanceTB.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 732);
            Controls.Add(chanceTB);
            Controls.Add(moneyTB);
            Controls.Add(totalTB);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dataGridView1);
            Controls.Add(operatorTB);
            Controls.Add(dateTB);
            Controls.Add(noFakturTB);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Data Transaksi";
            Load += Form1_Load;
            Click += saveButton_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label12;
        private Button cancelButton;
        private Button addButton;
        private Button exitButton;
        private Button saveButton;
        private TextBox noFakturTB;
        private TextBox dateTB;
        private TextBox operatorTB;
        private ComboBox stuffIdCB;
        private TextBox subTotalTB;
        private TextBox qtyTb;
        private TextBox stuffNameTB;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox totalTB;
        private TextBox moneyTB;
        private TextBox chanceTB;
        private TextBox stuffPriceTB;
    }
}
