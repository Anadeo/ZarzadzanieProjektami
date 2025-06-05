namespace ProjektProgramowanieObiektowe
{
    partial class Pracownik
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            dataGridView_d = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            dataGridView_u = new DataGridView();
            projektyBindingSource = new BindingSource(components);
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            przypisaniaBindingSource = new BindingSource(components);
            pracownicyBindingSource = new BindingSource(components);
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_d).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_u).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projektyBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(981, 379);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView_d, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(493, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(485, 373);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(206, 17);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Do zrobienia";
            // 
            // dataGridView_d
            // 
            dataGridView_d.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_d.Dock = DockStyle.Fill;
            dataGridView_d.Location = new Point(20, 70);
            dataGridView_d.Margin = new Padding(20);
            dataGridView_d.Name = "dataGridView_d";
            dataGridView_d.Size = new Size(445, 283);
            dataGridView_d.TabIndex = 1;
            dataGridView_d.CellContentClick += dataGridView_d_CellContentClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(dataGridView_u, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(484, 373);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(209, 17);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Ukończone";
            // 
            // dataGridView_u
            // 
            dataGridView_u.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_u.Dock = DockStyle.Fill;
            dataGridView_u.Location = new Point(20, 70);
            dataGridView_u.Margin = new Padding(20);
            dataGridView_u.Name = "dataGridView_u";
            dataGridView_u.Size = new Size(444, 283);
            dataGridView_u.TabIndex = 1;
            dataGridView_u.CellContentClick += dataGridView_u_CellContentClick;
            // 
            // projektyBindingSource
            // 
            projektyBindingSource.DataSource = typeof(Models.Projekty);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(331, 7);
            label1.Name = "label1";
            label1.Size = new Size(324, 65);
            label1.TabIndex = 0;
            label1.Text = "Twoje zadania";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(987, 515);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // przypisaniaBindingSource
            // 
            przypisaniaBindingSource.DataMember = "Przypisania";
            przypisaniaBindingSource.DataSource = projektyBindingSource;
            // 
            // pracownicyBindingSource
            // 
            pracownicyBindingSource.DataSource = typeof(Models.Pracownicy);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(456, 478);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pracownik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 515);
            Controls.Add(tableLayoutPanel1);
            Name = "Pracownik";
            Text = "Pracownik";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_d).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_u).EndInit();
            ((System.ComponentModel.ISupportInitialize)projektyBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private BindingSource projektyBindingSource;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private BindingSource pracownicyBindingSource;
        private BindingSource przypisaniaBindingSource;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private DataGridView dataGridView_d;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn czygotowyDataGridViewCheckBoxColumn1;
        private DataGridView dataGridView_u;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn czygotowyDataGridViewCheckBoxColumn;
        private Button button1;
    }
}