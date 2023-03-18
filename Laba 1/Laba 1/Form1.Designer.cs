namespace Laba_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.математическиеРасчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСоСпискамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСМассивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.использованиеПроцедурИФункцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическиеРасчетыToolStripMenuItem,
            this.работаСоСпискамиToolStripMenuItem,
            this.работаСМассивамиToolStripMenuItem,
            this.использованиеПроцедурИФункцийToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // математическиеРасчетыToolStripMenuItem
            // 
            this.математическиеРасчетыToolStripMenuItem.Name = "математическиеРасчетыToolStripMenuItem";
            this.математическиеРасчетыToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.математическиеРасчетыToolStripMenuItem.Text = "Математические расчеты";
            this.математическиеРасчетыToolStripMenuItem.Click += new System.EventHandler(this.математическиеРасчетыToolStripMenuItem_Click);
            // 
            // работаСоСпискамиToolStripMenuItem
            // 
            this.работаСоСпискамиToolStripMenuItem.Name = "работаСоСпискамиToolStripMenuItem";
            this.работаСоСпискамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСоСпискамиToolStripMenuItem.Text = "Работа со списками";
            // 
            // работаСМассивамиToolStripMenuItem
            // 
            this.работаСМассивамиToolStripMenuItem.Name = "работаСМассивамиToolStripMenuItem";
            this.работаСМассивамиToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.работаСМассивамиToolStripMenuItem.Text = "Работа с массивами";
            // 
            // использованиеПроцедурИФункцийToolStripMenuItem
            // 
            this.использованиеПроцедурИФункцийToolStripMenuItem.Name = "использованиеПроцедурИФункцийToolStripMenuItem";
            this.использованиеПроцедурИФункцийToolStripMenuItem.Size = new System.Drawing.Size(223, 20);
            this.использованиеПроцедурИФункцийToolStripMenuItem.Text = "Использование процедур и функций";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem математическиеРасчетыToolStripMenuItem;
        private ToolStripMenuItem работаСоСпискамиToolStripMenuItem;
        private ToolStripMenuItem работаСМассивамиToolStripMenuItem;
        private ToolStripMenuItem использованиеПроцедурИФункцийToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}