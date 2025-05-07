namespace ProjektProgramowanieObiektowe
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            fgfggToolStripMenuItem = new ToolStripMenuItem();
            fgToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            contextMenuStrip2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { fgfggToolStripMenuItem, fgToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(104, 48);
            // 
            // fgfggToolStripMenuItem
            // 
            fgfggToolStripMenuItem.Name = "fgfggToolStripMenuItem";
            fgfggToolStripMenuItem.Size = new Size(103, 22);
            fgfggToolStripMenuItem.Text = "fgfgg";
            // 
            // fgToolStripMenuItem
            // 
            fgToolStripMenuItem.Name = "fgToolStripMenuItem";
            fgToolStripMenuItem.Size = new Size(103, 22);
            fgToolStripMenuItem.Text = "fg";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(90, 204);
            button1.Name = "button1";
            button1.Size = new Size(183, 35);
            button1.TabIndex = 2;
            button1.Text = "Dodaj zadanie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(455, 204);
            button2.Name = "button2";
            button2.Size = new Size(183, 35);
            button2.TabIndex = 3;
            button2.Text = "Dodaj osoby do zadania";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(729, 444);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 444);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fgfggToolStripMenuItem;
        private ToolStripMenuItem fgToolStripMenuItem;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
