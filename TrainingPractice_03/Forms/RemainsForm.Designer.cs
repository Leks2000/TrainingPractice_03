namespace TrainingPractice_03.Forms
{
    partial class RemainsForm
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startVolumeTxt = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeSaleTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.MaskedTextBox();
            this.expBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.id_fuelTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.SystemColors.Info;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(139, 26);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(216, 62);
            this.sortBtn.TabIndex = 44;
            this.sortBtn.Text = "Сортировка";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Объём на начало дня (л)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Код вида топлива";
            // 
            // startVolumeTxt
            // 
            this.startVolumeTxt.Location = new System.Drawing.Point(270, 367);
            this.startVolumeTxt.Name = "startVolumeTxt";
            this.startVolumeTxt.Size = new System.Drawing.Size(185, 20);
            this.startVolumeTxt.TabIndex = 33;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(570, 80);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(216, 62);
            this.del_btn.TabIndex = 32;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Info;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(570, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(216, 62);
            this.add_btn.TabIndex = 30;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 266);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Объём продажи (л)";
            // 
            // volumeSaleTxt
            // 
            this.volumeSaleTxt.Location = new System.Drawing.Point(220, 408);
            this.volumeSaleTxt.Name = "volumeSaleTxt";
            this.volumeSaleTxt.Size = new System.Drawing.Size(237, 20);
            this.volumeSaleTxt.TabIndex = 45;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(230, 328);
            this.dateTxt.Mask = "00-00-0000";
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(227, 20);
            this.dateTxt.TabIndex = 47;
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.SystemColors.Info;
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBtn.Location = new System.Drawing.Point(570, 148);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(216, 62);
            this.expBtn.TabIndex = 48;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Location = new System.Drawing.Point(570, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 201);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по:";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb5.Location = new System.Drawing.Point(6, 97);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(193, 28);
            this.rb5.TabIndex = 49;
            this.rb5.TabStop = true;
            this.rb5.Text = "объёму продажи";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb4.Location = new System.Drawing.Point(6, 165);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(245, 28);
            this.rb4.TabIndex = 48;
            this.rb4.TabStop = true;
            this.rb4.Text = "объёму на начало дня";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb3.Location = new System.Drawing.Point(6, 23);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(75, 28);
            this.rb3.TabIndex = 47;
            this.rb3.TabStop = true;
            this.rb3.Text = "дате";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2.Location = new System.Drawing.Point(6, 131);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(225, 28);
            this.rb2.TabIndex = 46;
            this.rb2.TabStop = true;
            this.rb2.Text = "коду вида толплива";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1.Location = new System.Drawing.Point(6, 60);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(134, 28);
            this.rb1.TabIndex = 45;
            this.rb1.TabStop = true;
            this.rb1.Text = "коду учёта";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(792, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(187, 58);
            this.backBtn.TabIndex = 50;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // id_fuelTxt
            // 
            this.id_fuelTxt.FormattingEnabled = true;
            this.id_fuelTxt.Location = new System.Drawing.Point(230, 284);
            this.id_fuelTxt.Name = "id_fuelTxt";
            this.id_fuelTxt.Size = new System.Drawing.Size(227, 21);
            this.id_fuelTxt.TabIndex = 43;
            // 
            // RemainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 436);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeSaleTxt);
            this.Controls.Add(this.id_fuelTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startVolumeTxt);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RemainsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemainsForm";
            this.Load += new System.EventHandler(this.RemainsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startVolumeTxt;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox volumeSaleTxt;
        private System.Windows.Forms.MaskedTextBox dateTxt;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox id_fuelTxt;
    }
}