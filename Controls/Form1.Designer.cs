namespace Controls
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
            tabPages = new TabControl();
            tab1 = new TabPage();
            tab2 = new TabPage();
            tab3 = new TabPage();
            tabPages.SuspendLayout();
            SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Controls.Add(tab1);
            tabPages.Controls.Add(tab2);
            tabPages.Controls.Add(tab3);
            tabPages.Location = new Point(0, -1);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new Size(801, 484);
            tabPages.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Location = new Point(4, 34);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(793, 446);
            tab1.TabIndex = 0;
            tab1.Text = "Namnlista";
            tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            tab2.Location = new Point(4, 34);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(793, 446);
            tab2.TabIndex = 1;
            tab2.Text = "Formatera Text";
            tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            tab3.Location = new Point(4, 34);
            tab3.Name = "tab3";
            tab3.Padding = new Padding(3);
            tab3.Size = new Size(793, 446);
            tab3.TabIndex = 2;
            tab3.Text = "Loopa Controls";
            tab3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 482);
            Controls.Add(tabPages);
            Name = "Form1";
            Text = "Form1";
            tabPages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPages;
        private TabPage tab1;
        private TabPage tab2;
        private TabPage tab3;
    }
}