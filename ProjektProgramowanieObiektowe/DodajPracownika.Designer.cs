namespace ProjektProgramowanieObiektowe
{
    partial class DodajPracownika
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            Data = new DateTimePicker();
            label4 = new Label();
            Nazwisko = new TextBox();
            Imie = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pracownik_anuluj = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(755, 433);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(288, 39);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 0;
            label1.Text = "Dodaj pracownika";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(Data, 2, 1);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(Nazwisko, 1, 1);
            tableLayoutPanel2.Controls.Add(Imie, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(749, 210);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(226, 90);
            label2.Margin = new Padding(3, 0, 40, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Imie:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(343, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Nazwisko:";
            // 
            // Data
            // 
            Data.Location = new Point(451, 108);
            Data.Name = "Data";
            Data.Size = new Size(200, 23);
            Data.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(451, 90);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Data zatrudnienia:";
            // 
            // Nazwisko
            // 
            Nazwisko.Anchor = AnchorStyles.Top;
            Nazwisko.Location = new Point(323, 108);
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Size = new Size(100, 23);
            Nazwisko.TabIndex = 4;
            // 
            // Imie
            // 
            Imie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Imie.Location = new Point(196, 108);
            Imie.Name = "Imie";
            Imie.Size = new Size(100, 23);
            Imie.TabIndex = 5;
            Imie.TextChanged += imie_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pracownik_anuluj, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 327);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(749, 103);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // pracownik_anuluj
            // 
            pracownik_anuluj.Anchor = AnchorStyles.Right;
            pracownik_anuluj.Location = new Point(271, 31);
            pracownik_anuluj.Name = "pracownik_anuluj";
            pracownik_anuluj.Size = new Size(100, 40);
            pracownik_anuluj.TabIndex = 0;
            pracownik_anuluj.Text = "Anuluj";
            pracownik_anuluj.UseVisualStyleBackColor = true;
            pracownik_anuluj.Click += pracownik_anuluj_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Location = new Point(377, 31);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 1;
            button2.Text = "Dodaj pracownika";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DodajPracownika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 433);
            Controls.Add(tableLayoutPanel1);
            Name = "DodajPracownika";
            Text = "DodajPracownika";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private DateTimePicker Data;
        private Label label4;
        private TextBox Nazwisko;
        private TextBox Imie;
        private TableLayoutPanel tableLayoutPanel3;
        private Button pracownik_anuluj;
        private Button button2;
    }
}