namespace ProjektProgramowanieObiektowe
{
    partial class DodajProjekt
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
            dodaj_projekt = new Button();
            projekt_textbox = new TextBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dodaj_projekt, 0, 3);
            tableLayoutPanel1.Controls.Add(projekt_textbox, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(863, 494);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(368, 12);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Dodaj projekt";
            // 
            // dodaj_projekt
            // 
            dodaj_projekt.Anchor = AnchorStyles.None;
            dodaj_projekt.Location = new Point(374, 426);
            dodaj_projekt.Name = "dodaj_projekt";
            dodaj_projekt.Size = new Size(115, 35);
            dodaj_projekt.TabIndex = 2;
            dodaj_projekt.Text = "Dodaj";
            dodaj_projekt.UseVisualStyleBackColor = true;
            dodaj_projekt.Click += dodaj_projekt_Click;
            // 
            // projekt_textbox
            // 
            projekt_textbox.Anchor = AnchorStyles.Top;
            projekt_textbox.Location = new Point(375, 225);
            projekt_textbox.Name = "projekt_textbox";
            projekt_textbox.Size = new Size(113, 23);
            projekt_textbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(385, 197);
            label2.Margin = new Padding(3, 0, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwa projektu:";
            // 
            // DodajProjekt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 494);
            Controls.Add(tableLayoutPanel1);
            Name = "DodajProjekt";
            Text = "DodajProjekt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox projekt_textbox;
        private Button dodaj_projekt;
        private Label label2;
    }
}