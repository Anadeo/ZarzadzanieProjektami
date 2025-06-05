namespace ProjektProgramowanieObiektowe
{
    partial class Dodaj_przypisanie
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            dateTimePicker_termin = new DateTimePicker();
            label3 = new Label();
            textBox_opis_zadania = new TextBox();
            label2 = new Label();
            textBox_id_pracownika = new TextBox();
            Label_podaj_id_pracownika = new Label();
            label_nazwa_projektu = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(718, 436);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(dateTimePicker_termin, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox_opis_zadania, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox_id_pracownika, 0, 2);
            tableLayoutPanel1.Controls.Add(Label_podaj_id_pracownika, 0, 1);
            tableLayoutPanel1.Controls.Add(label_nazwa_projektu, 0, 0);
            tableLayoutPanel1.Location = new Point(127, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28531F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881641F));
            tableLayoutPanel1.Size = new Size(464, 391);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(194, 353);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "przypisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker_termin
            // 
            dateTimePicker_termin.Anchor = AnchorStyles.Top;
            dateTimePicker_termin.Location = new Point(132, 291);
            dateTimePicker_termin.Name = "dateTimePicker_termin";
            dateTimePicker_termin.Size = new Size(200, 23);
            dateTimePicker_termin.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(141, 273);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 4;
            label3.Text = "Podaj termin wykonania zadania:";
            // 
            // textBox_opis_zadania
            // 
            textBox_opis_zadania.Anchor = AnchorStyles.Top;
            textBox_opis_zadania.Location = new Point(131, 195);
            textBox_opis_zadania.Multiline = true;
            textBox_opis_zadania.Name = "textBox_opis_zadania";
            textBox_opis_zadania.ScrollBars = ScrollBars.Vertical;
            textBox_opis_zadania.Size = new Size(202, 42);
            textBox_opis_zadania.TabIndex = 3;
            textBox_opis_zadania.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(178, 177);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Podaj opis zadania:";
            // 
            // textBox_id_pracownika
            // 
            textBox_id_pracownika.Anchor = AnchorStyles.Top;
            textBox_id_pracownika.Location = new Point(182, 99);
            textBox_id_pracownika.Name = "textBox_id_pracownika";
            textBox_id_pracownika.Size = new Size(100, 23);
            textBox_id_pracownika.TabIndex = 1;
            // 
            // Label_podaj_id_pracownika
            // 
            Label_podaj_id_pracownika.Anchor = AnchorStyles.Bottom;
            Label_podaj_id_pracownika.AutoSize = true;
            Label_podaj_id_pracownika.Location = new Point(173, 81);
            Label_podaj_id_pracownika.Name = "Label_podaj_id_pracownika";
            Label_podaj_id_pracownika.Size = new Size(117, 15);
            Label_podaj_id_pracownika.TabIndex = 0;
            Label_podaj_id_pracownika.Text = "Podaj id pracownika:";
            // 
            // label_nazwa_projektu
            // 
            label_nazwa_projektu.Anchor = AnchorStyles.None;
            label_nazwa_projektu.AutoSize = true;
            label_nazwa_projektu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_nazwa_projektu.Location = new Point(120, 11);
            label_nazwa_projektu.Name = "label_nazwa_projektu";
            label_nazwa_projektu.Size = new Size(224, 25);
            label_nazwa_projektu.TabIndex = 7;
            label_nazwa_projektu.Text = "Tu wstaw nazwe projektu";
            // 
            // Dodaj_przypisanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 436);
            Controls.Add(tableLayoutPanel2);
            Name = "Dodaj_przypisanie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj_przypisanie";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Label_podaj_id_pracownika;
        private TextBox textBox_id_pracownika;
        private Label label2;
        private TextBox textBox_opis_zadania;
        private Label label3;
        private DateTimePicker dateTimePicker_termin;
        private Button button1;
        private Label label_nazwa_projektu;
    }
}