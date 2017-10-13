namespace MyGPW
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lv_formula = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_bg = new System.Windows.Forms.Button();
            this.btn_sm = new System.Windows.Forms.Button();
            this.btn_sm_or_eq = new System.Windows.Forms.Button();
            this.btn_bg_or_eq = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_and = new System.Windows.Forms.Button();
            this.btn_or = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_brout = new System.Windows.Forms.Button();
            this.btn_brin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_lv_add = new System.Windows.Forms.Button();
            this.btn_lv_remove = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_update = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_progres = new System.Windows.Forms.ToolStripProgressBar();
            this.txt_webpage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.walorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zmianaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zmianaProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbaTranakcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otwarcieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_formula
            // 
            this.lv_formula.Location = new System.Drawing.Point(12, 124);
            this.lv_formula.Name = "lv_formula";
            this.lv_formula.Size = new System.Drawing.Size(453, 106);
            this.lv_formula.TabIndex = 0;
            this.lv_formula.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(240, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btn_bg
            // 
            this.btn_bg.Location = new System.Drawing.Point(3, 3);
            this.btn_bg.Name = "btn_bg";
            this.btn_bg.Size = new System.Drawing.Size(28, 23);
            this.btn_bg.TabIndex = 4;
            this.btn_bg.Text = ">";
            this.btn_bg.UseVisualStyleBackColor = true;
            // 
            // btn_sm
            // 
            this.btn_sm.Location = new System.Drawing.Point(3, 32);
            this.btn_sm.Name = "btn_sm";
            this.btn_sm.Size = new System.Drawing.Size(28, 23);
            this.btn_sm.TabIndex = 5;
            this.btn_sm.Text = "<";
            this.btn_sm.UseVisualStyleBackColor = true;
            // 
            // btn_sm_or_eq
            // 
            this.btn_sm_or_eq.Location = new System.Drawing.Point(37, 32);
            this.btn_sm_or_eq.Name = "btn_sm_or_eq";
            this.btn_sm_or_eq.Size = new System.Drawing.Size(28, 23);
            this.btn_sm_or_eq.TabIndex = 7;
            this.btn_sm_or_eq.Text = "<=";
            this.btn_sm_or_eq.UseVisualStyleBackColor = true;
            // 
            // btn_bg_or_eq
            // 
            this.btn_bg_or_eq.Location = new System.Drawing.Point(37, 3);
            this.btn_bg_or_eq.Name = "btn_bg_or_eq";
            this.btn_bg_or_eq.Size = new System.Drawing.Size(28, 23);
            this.btn_bg_or_eq.TabIndex = 6;
            this.btn_bg_or_eq.Text = ">=";
            this.btn_bg_or_eq.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_bg);
            this.panel1.Controls.Add(this.btn_sm_or_eq);
            this.panel1.Controls.Add(this.btn_bg_or_eq);
            this.panel1.Controls.Add(this.btn_sm);
            this.panel1.Location = new System.Drawing.Point(162, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 58);
            this.panel1.TabIndex = 8;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(388, 41);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(23, 23);
            this.btn_plus.TabIndex = 9;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(388, 67);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(23, 23);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // btn_and
            // 
            this.btn_and.Location = new System.Drawing.Point(430, 38);
            this.btn_and.Name = "btn_and";
            this.btn_and.Size = new System.Drawing.Size(37, 23);
            this.btn_and.TabIndex = 11;
            this.btn_and.Text = "and";
            this.btn_and.UseVisualStyleBackColor = true;
            // 
            // btn_or
            // 
            this.btn_or.Location = new System.Drawing.Point(473, 38);
            this.btn_or.Name = "btn_or";
            this.btn_or.Size = new System.Drawing.Size(38, 23);
            this.btn_or.TabIndex = 12;
            this.btn_or.Text = "or";
            this.btn_or.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_brout);
            this.panel2.Controls.Add(this.btn_brin);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btn_minus);
            this.panel2.Controls.Add(this.btn_or);
            this.panel2.Controls.Add(this.btn_plus);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_and);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 106);
            this.panel2.TabIndex = 13;
            // 
            // btn_brout
            // 
            this.btn_brout.Location = new System.Drawing.Point(473, 67);
            this.btn_brout.Name = "btn_brout";
            this.btn_brout.Size = new System.Drawing.Size(38, 23);
            this.btn_brout.TabIndex = 15;
            this.btn_brout.Text = ")";
            this.btn_brout.UseVisualStyleBackColor = true;
            // 
            // btn_brin
            // 
            this.btn_brin.Location = new System.Drawing.Point(430, 67);
            this.btn_brin.Name = "btn_brin";
            this.btn_brin.Size = new System.Drawing.Size(37, 23);
            this.btn_brin.TabIndex = 14;
            this.btn_brin.Text = "(";
            this.btn_brin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btn_lv_add
            // 
            this.btn_lv_add.Location = new System.Drawing.Point(471, 126);
            this.btn_lv_add.Name = "btn_lv_add";
            this.btn_lv_add.Size = new System.Drawing.Size(75, 23);
            this.btn_lv_add.TabIndex = 14;
            this.btn_lv_add.Text = "+";
            this.btn_lv_add.UseVisualStyleBackColor = true;
            // 
            // btn_lv_remove
            // 
            this.btn_lv_remove.Location = new System.Drawing.Point(471, 155);
            this.btn_lv_remove.Name = "btn_lv_remove";
            this.btn_lv_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_lv_remove.TabIndex = 15;
            this.btn_lv_remove.Text = "-";
            this.btn_lv_remove.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_date,
            this.ts_update,
            this.ts_progres});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_date
            // 
            this.ts_date.Name = "ts_date";
            this.ts_date.Size = new System.Drawing.Size(0, 17);
            // 
            // ts_update
            // 
            this.ts_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_update.Image = ((System.Drawing.Image)(resources.GetObject("ts_update.Image")));
            this.ts_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_update.Name = "ts_update";
            this.ts_update.ShowDropDownArrow = false;
            this.ts_update.Size = new System.Drawing.Size(20, 20);
            this.ts_update.Text = "toolStripDropDownButton1";
            this.ts_update.Click += new System.EventHandler(this.ts_update_Click);
            // 
            // ts_progres
            // 
            this.ts_progres.Name = "ts_progres";
            this.ts_progres.Size = new System.Drawing.Size(100, 16);
            this.ts_progres.Step = 1;
            // 
            // txt_webpage
            // 
            this.txt_webpage.Location = new System.Drawing.Point(12, 380);
            this.txt_webpage.Multiline = true;
            this.txt_webpage.Name = "txt_webpage";
            this.txt_webpage.Size = new System.Drawing.Size(625, 185);
            this.txt_webpage.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.walorDataGridViewTextBoxColumn,
            this.kursDataGridViewTextBoxColumn,
            this.zmianaDataGridViewTextBoxColumn,
            this.zmianaProcDataGridViewTextBoxColumn,
            this.liczbaTranakcjiDataGridViewTextBoxColumn,
            this.obrotDataGridViewTextBoxColumn,
            this.otwarcieDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.czasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // walorDataGridViewTextBoxColumn
            // 
            this.walorDataGridViewTextBoxColumn.DataPropertyName = "Walor";
            this.walorDataGridViewTextBoxColumn.HeaderText = "Walor";
            this.walorDataGridViewTextBoxColumn.Name = "walorDataGridViewTextBoxColumn";
            // 
            // kursDataGridViewTextBoxColumn
            // 
            this.kursDataGridViewTextBoxColumn.DataPropertyName = "Kurs";
            this.kursDataGridViewTextBoxColumn.HeaderText = "Kurs";
            this.kursDataGridViewTextBoxColumn.Name = "kursDataGridViewTextBoxColumn";
            // 
            // zmianaDataGridViewTextBoxColumn
            // 
            this.zmianaDataGridViewTextBoxColumn.DataPropertyName = "Zmiana";
            this.zmianaDataGridViewTextBoxColumn.HeaderText = "Zmiana";
            this.zmianaDataGridViewTextBoxColumn.Name = "zmianaDataGridViewTextBoxColumn";
            // 
            // zmianaProcDataGridViewTextBoxColumn
            // 
            this.zmianaProcDataGridViewTextBoxColumn.DataPropertyName = "ZmianaProc";
            this.zmianaProcDataGridViewTextBoxColumn.HeaderText = "ZmianaProc";
            this.zmianaProcDataGridViewTextBoxColumn.Name = "zmianaProcDataGridViewTextBoxColumn";
            // 
            // liczbaTranakcjiDataGridViewTextBoxColumn
            // 
            this.liczbaTranakcjiDataGridViewTextBoxColumn.DataPropertyName = "LiczbaTranakcji";
            this.liczbaTranakcjiDataGridViewTextBoxColumn.HeaderText = "LiczbaTranakcji";
            this.liczbaTranakcjiDataGridViewTextBoxColumn.Name = "liczbaTranakcjiDataGridViewTextBoxColumn";
            // 
            // obrotDataGridViewTextBoxColumn
            // 
            this.obrotDataGridViewTextBoxColumn.DataPropertyName = "Obrot";
            this.obrotDataGridViewTextBoxColumn.HeaderText = "Obrot";
            this.obrotDataGridViewTextBoxColumn.Name = "obrotDataGridViewTextBoxColumn";
            // 
            // otwarcieDataGridViewTextBoxColumn
            // 
            this.otwarcieDataGridViewTextBoxColumn.DataPropertyName = "Otwarcie";
            this.otwarcieDataGridViewTextBoxColumn.HeaderText = "Otwarcie";
            this.otwarcieDataGridViewTextBoxColumn.Name = "otwarcieDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // czasDataGridViewTextBoxColumn
            // 
            this.czasDataGridViewTextBoxColumn.DataPropertyName = "Czas";
            this.czasDataGridViewTextBoxColumn.HeaderText = "Czas";
            this.czasDataGridViewTextBoxColumn.Name = "czasDataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(MyGPW.Company);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_webpage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_lv_remove);
            this.Controls.Add(this.btn_lv_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lv_formula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_formula;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_bg;
        private System.Windows.Forms.Button btn_sm;
        private System.Windows.Forms.Button btn_sm_or_eq;
        private System.Windows.Forms.Button btn_bg_or_eq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_and;
        private System.Windows.Forms.Button btn_or;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_brout;
        private System.Windows.Forms.Button btn_brin;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_lv_add;
        private System.Windows.Forms.Button btn_lv_remove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ts_progres;
        private System.Windows.Forms.ToolStripStatusLabel ts_date;
        private System.Windows.Forms.ToolStripDropDownButton ts_update;
        private System.Windows.Forms.TextBox txt_webpage;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn walorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zmianaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zmianaProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbaTranakcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otwarcieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasDataGridViewTextBoxColumn;
    }
}

