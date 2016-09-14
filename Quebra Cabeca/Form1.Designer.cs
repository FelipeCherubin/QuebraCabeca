namespace Quebra_Cabeca
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.quebra1 = new System.Windows.Forms.TabPage();
            this.quebra2 = new System.Windows.Forms.TabPage();
            this.quebra3 = new System.Windows.Forms.TabPage();
            this.quebra4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.quebra1);
            this.tabControl1.Controls.Add(this.quebra2);
            this.tabControl1.Controls.Add(this.quebra3);
            this.tabControl1.Controls.Add(this.quebra4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // quebra1
            // 
            this.quebra1.Location = new System.Drawing.Point(4, 22);
            this.quebra1.Name = "quebra1";
            this.quebra1.Padding = new System.Windows.Forms.Padding(3);
            this.quebra1.Size = new System.Drawing.Size(690, 350);
            this.quebra1.TabIndex = 0;
            this.quebra1.Text = "Quebra Cabeca 1";
            this.quebra1.UseVisualStyleBackColor = true;
            // 
            // quebra2
            // 
            this.quebra2.Location = new System.Drawing.Point(4, 22);
            this.quebra2.Name = "quebra2";
            this.quebra2.Padding = new System.Windows.Forms.Padding(3);
            this.quebra2.Size = new System.Drawing.Size(690, 350);
            this.quebra2.TabIndex = 1;
            this.quebra2.Text = "Quebra Cabeca 2";
            this.quebra2.UseVisualStyleBackColor = true;
            // 
            // quebra3
            // 
            this.quebra3.Location = new System.Drawing.Point(4, 22);
            this.quebra3.Name = "quebra3";
            this.quebra3.Size = new System.Drawing.Size(690, 350);
            this.quebra3.TabIndex = 2;
            this.quebra3.Text = "Quebra Cabeca 3";
            this.quebra3.UseVisualStyleBackColor = true;
            // 
            // quebra4
            // 
            this.quebra4.Location = new System.Drawing.Point(4, 22);
            this.quebra4.Name = "quebra4";
            this.quebra4.Size = new System.Drawing.Size(690, 350);
            this.quebra4.TabIndex = 3;
            this.quebra4.Text = "Quebra Cabeca 4";
            this.quebra4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage quebra1;
        private System.Windows.Forms.TabPage quebra2;
        private System.Windows.Forms.TabPage quebra3;
        private System.Windows.Forms.TabPage quebra4;
    }
}

