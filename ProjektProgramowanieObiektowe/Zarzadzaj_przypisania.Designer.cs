namespace ProjektProgramowanieObiektowe
{
    partial class Zarzadzaj_przypisania
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button_dodaj_pracownika = new Button();
            dataGridView_pracownicy = new DataGridView();
            dataGridView_projekty = new DataGridView();
            nazwa = new DataGridViewTextBoxColumn();
            czygotowy = new DataGridViewCheckBoxColumn();
            datarozpoczecia = new DataGridViewTextBoxColumn();
            Przydziel = new DataGridViewButtonColumn();
            projektyBindingSource = new BindingSource(components);
            button1 = new Button();
            pracownicyBindingSource = new BindingSource(components);
            przypisaniaBindingSource = new BindingSource(components);
            pracownicyBindingSource1 = new BindingSource(components);
            przypisaniaBindingSource1 = new BindingSource(components);
            pracownicyBindingSource2 = new BindingSource(components);
            pracownicyBindingSource3 = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pracownicy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_projekty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projektyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource3).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1267, 507);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(483, 6);
            label1.Name = "label1";
            label1.Size = new Size(301, 37);
            label1.TabIndex = 0;
            label1.Text = "Zarządzaj przypisaniami";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6994438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3005562F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(dataGridView_projekty, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1261, 401);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(dataGridView_pracownicy, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(491, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(767, 395);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(button_dodaj_pracownika, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 348);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(761, 44);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button_dodaj_pracownika
            // 
            button_dodaj_pracownika.Anchor = AnchorStyles.None;
            button_dodaj_pracownika.Location = new Point(317, 10);
            button_dodaj_pracownika.Name = "button_dodaj_pracownika";
            button_dodaj_pracownika.Size = new Size(127, 23);
            button_dodaj_pracownika.TabIndex = 0;
            button_dodaj_pracownika.Text = "dodaj pracownika";
            button_dodaj_pracownika.UseVisualStyleBackColor = true;
            button_dodaj_pracownika.Click += button_dodaj_pracownika_Click;
            // 
            // dataGridView_pracownicy
            // 
            dataGridView_pracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_pracownicy.Location = new Point(20, 20);
            dataGridView_pracownicy.Margin = new Padding(20);
            dataGridView_pracownicy.Name = "dataGridView_pracownicy";
            dataGridView_pracownicy.Size = new Size(724, 305);
            dataGridView_pracownicy.TabIndex = 1;
            dataGridView_pracownicy.CellContentClick += CellContentClick_pracownicy;
            // 
            // dataGridView_projekty
            // 
            dataGridView_projekty.AutoGenerateColumns = false;
            dataGridView_projekty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_projekty.Columns.AddRange(new DataGridViewColumn[] { nazwa, czygotowy, datarozpoczecia, Przydziel });
            dataGridView_projekty.DataSource = projektyBindingSource;
            dataGridView_projekty.Dock = DockStyle.Fill;
            dataGridView_projekty.Location = new Point(20, 20);
            dataGridView_projekty.Margin = new Padding(20);
            dataGridView_projekty.Name = "dataGridView_projekty";
            dataGridView_projekty.Size = new Size(448, 361);
            dataGridView_projekty.TabIndex = 1;
            dataGridView_projekty.CellContentClick += dataGridView1_CellContentClick;
            dataGridView_projekty.CellValueChanged += checkboxChanged;
            dataGridView_projekty.CurrentCellDirtyStateChanged += CurrentCellDirtyStateChanged_;
            // 
            // nazwa
            // 
            nazwa.DataPropertyName = "Nazwa";
            nazwa.HeaderText = "Nazwa";
            nazwa.Name = "nazwa";
            nazwa.ReadOnly = true;
            // 
            // czygotowy
            // 
            czygotowy.DataPropertyName = "Czy_gotowy";
            czygotowy.HeaderText = "Czy_gotowy";
            czygotowy.Name = "czygotowy";
            // 
            // datarozpoczecia
            // 
            datarozpoczecia.DataPropertyName = "Data_rozpoczecia";
            datarozpoczecia.HeaderText = "Data_rozpoczecia";
            datarozpoczecia.Name = "datarozpoczecia";
            datarozpoczecia.ReadOnly = true;
            // 
            // Przydziel
            // 
            Przydziel.DataPropertyName = "(name)";
            Przydziel.HeaderText = "Przydziel";
            Przydziel.Name = "Przydziel";
            Przydziel.ReadOnly = true;
            Przydziel.Text = "przydzel";
            Przydziel.UseColumnTextForButtonValue = true;
            // 
            // projektyBindingSource
            // 
            projektyBindingSource.DataSource = typeof(Models.Projekty);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(596, 470);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pracownicyBindingSource
            // 
            pracownicyBindingSource.DataSource = typeof(Models.Pracownicy);
            // 
            // przypisaniaBindingSource
            // 
            przypisaniaBindingSource.DataSource = typeof(Models.Przypisania);
            // 
            // pracownicyBindingSource1
            // 
            pracownicyBindingSource1.DataSource = typeof(Models.Pracownicy);
            // 
            // przypisaniaBindingSource1
            // 
            przypisaniaBindingSource1.DataMember = "Przypisania";
            przypisaniaBindingSource1.DataSource = projektyBindingSource;
            // 
            // pracownicyBindingSource2
            // 
            pracownicyBindingSource2.DataSource = typeof(Models.Pracownicy);
            // 
            // pracownicyBindingSource3
            // 
            pracownicyBindingSource3.DataSource = typeof(Models.Pracownicy);
            // 
            // Zarzadzaj_przypisania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 507);
            Controls.Add(tableLayoutPanel1);
            Name = "Zarzadzaj_przypisania";
            Text = "Przypisania";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_pracownicy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_projekty).EndInit();
            ((System.ComponentModel.ISupportInitialize)projektyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)przypisaniaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pracownicyBindingSource3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView_projekty;
        private DataGridView dataGridView_pracownicy;
        private BindingSource pracownicyBindingSource;
        private BindingSource projektyBindingSource;
        private DataGridViewTextBoxColumn nazwa;
        private DataGridViewCheckBoxColumn czygotowy;
        private DataGridViewTextBoxColumn datarozpoczecia;
        private DataGridViewButtonColumn Przydziel;
        private Button button_dodaj_pracownika;
        private BindingSource przypisaniaBindingSource1;
        private BindingSource przypisaniaBindingSource;
        private BindingSource pracownicyBindingSource1;
        private BindingSource pracownicyBindingSource2;
        private BindingSource pracownicyBindingSource3;
    }
}