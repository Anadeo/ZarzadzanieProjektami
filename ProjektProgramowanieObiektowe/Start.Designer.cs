namespace ProjektProgramowanieObiektowe
{
    partial class Start
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            kim_pracownikiem = new Button();
            podaj_id_text = new TextBox();
            podaj_id_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(222, 74);
            label1.Name = "label1";
            label1.Size = new Size(350, 86);
            label1.TabIndex = 0;
            label1.Text = "Kim jesteś?";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(794, 469);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 237);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(788, 229);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(147, 94);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 0;
            button1.Text = "Menadżerem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += menadzer_click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(kim_pracownikiem, 0, 2);
            tableLayoutPanel3.Controls.Add(podaj_id_text, 0, 1);
            tableLayoutPanel3.Controls.Add(podaj_id_label, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(397, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(388, 223);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // kim_pracownikiem
            // 
            kim_pracownikiem.Anchor = AnchorStyles.None;
            kim_pracownikiem.Location = new Point(144, 146);
            kim_pracownikiem.Name = "kim_pracownikiem";
            kim_pracownikiem.Size = new Size(100, 40);
            kim_pracownikiem.TabIndex = 1;
            kim_pracownikiem.Text = "Pracownikiem";
            kim_pracownikiem.UseVisualStyleBackColor = true;
            kim_pracownikiem.Click += pracownik_click;
            // 
            // podaj_id_text
            // 
            podaj_id_text.Anchor = AnchorStyles.None;
            podaj_id_text.Location = new Point(144, 71);
            podaj_id_text.Name = "podaj_id_text";
            podaj_id_text.Size = new Size(100, 23);
            podaj_id_text.TabIndex = 2;
            // 
            // podaj_id_label
            // 
            podaj_id_label.Anchor = AnchorStyles.None;
            podaj_id_label.AutoSize = true;
            podaj_id_label.Location = new Point(152, 20);
            podaj_id_label.Name = "podaj_id_label";
            podaj_id_label.Size = new Size(83, 15);
            podaj_id_label.TabIndex = 3;
            podaj_id_label.Text = "Podaj swoje id";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 469);
            Controls.Add(tableLayoutPanel1);
            Name = "Start";
            Text = "Projekty";
            Load += Start_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button kim_pracownikiem;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox podaj_id_text;
        private Label podaj_id_label;
    }
}