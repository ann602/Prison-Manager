namespace Prison_Manager
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheck_1 = new System.Windows.Forms.Button();
            this.tbPrisonerCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck_2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvPrisoner = new System.Windows.Forms.DataGridView();
            this.bindSrcPrisoners = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.checkBoxTrueFamily = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericImprisonmentTo = new System.Windows.Forms.NumericUpDown();
            this.numericImprisonmentFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericAgeTo = new System.Windows.Forms.NumericUpDown();
            this.numericAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxFalseFamily = new System.Windows.Forms.CheckBox();
            this.btnReset_2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrisoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPrisoners)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImprisonmentTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImprisonmentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(1411, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальне";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(54, 81);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 31);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheck_1);
            this.groupBox2.Controls.Add(this.tbPrisonerCheck);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1411, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук";
            // 
            // btnCheck_1
            // 
            this.btnCheck_1.Location = new System.Drawing.Point(7, 50);
            this.btnCheck_1.Name = "btnCheck_1";
            this.btnCheck_1.Size = new System.Drawing.Size(75, 23);
            this.btnCheck_1.TabIndex = 2;
            this.btnCheck_1.Text = "Check";
            this.btnCheck_1.UseVisualStyleBackColor = true;
            this.btnCheck_1.Click += new System.EventHandler(this.btnCheck_1_Click);
            // 
            // tbPrisonerCheck
            // 
            this.tbPrisonerCheck.Location = new System.Drawing.Point(72, 22);
            this.tbPrisonerCheck.Name = "tbPrisonerCheck";
            this.tbPrisonerCheck.Size = new System.Drawing.Size(100, 22);
            this.tbPrisonerCheck.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "В\'язень";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCheck_2);
            this.groupBox3.Location = new System.Drawing.Point(1411, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Впорядкування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "За віком";
            // 
            // btnCheck_2
            // 
            this.btnCheck_2.Location = new System.Drawing.Point(6, 37);
            this.btnCheck_2.Name = "btnCheck_2";
            this.btnCheck_2.Size = new System.Drawing.Size(165, 23);
            this.btnCheck_2.TabIndex = 0;
            this.btnCheck_2.Text = "Check";
            this.btnCheck_2.UseVisualStyleBackColor = true;
            this.btnCheck_2.Click += new System.EventHandler(this.btnCheck_2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvPrisoner);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1398, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ув\'язнені";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvPrisoner
            // 
            this.gvPrisoner.AllowUserToAddRows = false;
            this.gvPrisoner.AllowUserToDeleteRows = false;
            this.gvPrisoner.AutoGenerateColumns = false;
            this.gvPrisoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPrisoner.DataSource = this.bindSrcPrisoners;
            this.gvPrisoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPrisoner.Location = new System.Drawing.Point(3, 3);
            this.gvPrisoner.Name = "gvPrisoner";
            this.gvPrisoner.ReadOnly = true;
            this.gvPrisoner.RowHeadersWidth = 51;
            this.gvPrisoner.RowTemplate.Height = 24;
            this.gvPrisoner.Size = new System.Drawing.Size(1392, 413);
            this.gvPrisoner.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1406, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReset_2);
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.checkBoxFalseFamily);
            this.groupBox5.Controls.Add(this.checkBoxTrueFamily);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.numericImprisonmentTo);
            this.groupBox5.Controls.Add(this.numericImprisonmentFrom);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBoxArticle);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.comboBoxSex);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.numericAgeTo);
            this.groupBox5.Controls.Add(this.numericAgeFrom);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(1597, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 316);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фільтрація";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(6, 274);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 36);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Apply";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // checkBoxTrueFamily
            // 
            this.checkBoxTrueFamily.AutoSize = true;
            this.checkBoxTrueFamily.Location = new System.Drawing.Point(6, 222);
            this.checkBoxTrueFamily.Name = "checkBoxTrueFamily";
            this.checkBoxTrueFamily.Size = new System.Drawing.Size(74, 20);
            this.checkBoxTrueFamily.TabIndex = 11;
            this.checkBoxTrueFamily.Text = "Є сім\'я.";
            this.checkBoxTrueFamily.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Family";
            // 
            // numericImprisonmentTo
            // 
            this.numericImprisonmentTo.Location = new System.Drawing.Point(94, 177);
            this.numericImprisonmentTo.Name = "numericImprisonmentTo";
            this.numericImprisonmentTo.Size = new System.Drawing.Size(58, 22);
            this.numericImprisonmentTo.TabIndex = 9;
            // 
            // numericImprisonmentFrom
            // 
            this.numericImprisonmentFrom.Location = new System.Drawing.Point(6, 178);
            this.numericImprisonmentFrom.Name = "numericImprisonmentFrom";
            this.numericImprisonmentFrom.Size = new System.Drawing.Size(56, 22);
            this.numericImprisonmentFrom.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Imprisonment";
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(30, 127);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(100, 22);
            this.textBoxArticle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Article";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(20, 81);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSex.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sex";
            // 
            // numericAgeTo
            // 
            this.numericAgeTo.Location = new System.Drawing.Point(94, 37);
            this.numericAgeTo.Name = "numericAgeTo";
            this.numericAgeTo.Size = new System.Drawing.Size(58, 22);
            this.numericAgeTo.TabIndex = 2;
            // 
            // numericAgeFrom
            // 
            this.numericAgeFrom.Location = new System.Drawing.Point(6, 37);
            this.numericAgeFrom.Name = "numericAgeFrom";
            this.numericAgeFrom.Size = new System.Drawing.Size(56, 22);
            this.numericAgeFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age";
            // 
            // checkBoxFalseFamily
            // 
            this.checkBoxFalseFamily.AutoSize = true;
            this.checkBoxFalseFamily.Location = new System.Drawing.Point(5, 248);
            this.checkBoxFalseFamily.Name = "checkBoxFalseFamily";
            this.checkBoxFalseFamily.Size = new System.Drawing.Size(103, 20);
            this.checkBoxFalseFamily.TabIndex = 13;
            this.checkBoxFalseFamily.Text = "Немає сім\'ї.";
            this.checkBoxFalseFamily.UseVisualStyleBackColor = true;
            // 
            // btnReset_2
            // 
            this.btnReset_2.Location = new System.Drawing.Point(84, 274);
            this.btnReset_2.Name = "btnReset_2";
            this.btnReset_2.Size = new System.Drawing.Size(75, 36);
            this.btnReset_2.TabIndex = 14;
            this.btnReset_2.Text = "Reset";
            this.btnReset_2.UseVisualStyleBackColor = true;
            this.btnReset_2.Click += new System.EventHandler(this.btnReset_2_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 453);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "fMain";
            this.Text = " Prison Manager";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPrisoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPrisoners)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImprisonmentTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImprisonmentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindSrcPrisoners;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheck_1;
        private System.Windows.Forms.TextBox tbPrisonerCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCheck_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvPrisoner;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericImprisonmentTo;
        private System.Windows.Forms.NumericUpDown numericImprisonmentFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericAgeTo;
        private System.Windows.Forms.NumericUpDown numericAgeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTrueFamily;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox checkBoxFalseFamily;
        private System.Windows.Forms.Button btnReset_2;
    }
}

