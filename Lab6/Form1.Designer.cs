using System.Windows.Forms;

namespace Lab6{
    partial class Form1{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if(disposing && (components != null)){
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.depthMenu5 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 45);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 393);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.ToolStripMenu, this.colorMenu, this.depthMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Инструмент";
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.toolStripMenuItem1, this.toolStripMenuItem2, this.toolStripMenuItem3, this.toolStripMenuItem4, this.toolStripMenuItem5, this.toolStripMenuItem6, this.toolStripMenuItem7, this.toolStripMenuItem8, this.toolStripMenuItem9, this.toolStripMenuItem10});
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(86, 20);
            this.ToolStripMenu.Text = "Инструмент";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem1.Text = "Линии в центр";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem2.Text = "Квадратики";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem3.Text = "Диагональный отрезок /";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem4.Text = "Диагональный отрезок \\";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem5.Text = "Перекрестье +";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem6.Text = "Перекрестье ×";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem7.Text = "Окружность";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem8.Text = "Круги";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem9.Text = "Треугольники";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem10.Text = "Распылитель";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(45, 20);
            this.colorMenu.Text = "Цвет";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // depthMenu
            // 
            this.depthMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.depthMenu1, this.depthMenu2, this.depthMenu3, this.depthMenu4, this.depthMenu5});
            this.depthMenu.Name = "depthMenu";
            this.depthMenu.Size = new System.Drawing.Size(70, 20);
            this.depthMenu.Text = "Толщина";
            this.depthMenu.Click += new System.EventHandler(this.depthMenu_Click);
            // 
            // depthMenu1
            // 
            this.depthMenu1.Name = "depthMenu1";
            this.depthMenu1.Size = new System.Drawing.Size(152, 22);
            this.depthMenu1.Text = "1";
            this.depthMenu1.Click += new System.EventHandler(this.depthMenu1_Click);
            // 
            // depthMenu2
            // 
            this.depthMenu2.Name = "depthMenu2";
            this.depthMenu2.Size = new System.Drawing.Size(152, 22);
            this.depthMenu2.Text = "2";
            this.depthMenu2.Click += new System.EventHandler(this.depthMenu2_Click);
            // 
            // depthMenu3
            // 
            this.depthMenu3.Name = "depthMenu3";
            this.depthMenu3.Size = new System.Drawing.Size(152, 22);
            this.depthMenu3.Text = "3";
            this.depthMenu3.Click += new System.EventHandler(this.depthMenu3_Click);
            // 
            // depthMenu4
            // 
            this.depthMenu4.Name = "depthMenu4";
            this.depthMenu4.Size = new System.Drawing.Size(152, 22);
            this.depthMenu4.Text = "4";
            this.depthMenu4.Click += new System.EventHandler(this.depthMenu4_Click);
            // 
            // depthMenu5
            // 
            this.depthMenu5.Name = "depthMenu5";
            this.depthMenu5.Size = new System.Drawing.Size(152, 22);
            this.depthMenu5.Text = "5";
            this.depthMenu5.Click += new System.EventHandler(this.depthMenu5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem depthMenu2;
        private System.Windows.Forms.ToolStripMenuItem depthMenu3;
        private System.Windows.Forms.ToolStripMenuItem depthMenu4;
        private System.Windows.Forms.ToolStripMenuItem depthMenu5;

        private System.Windows.Forms.ToolStripMenuItem depthMenu1;

        private System.Windows.Forms.ToolStripMenuItem depthMenu;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem colorMenu;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        
        private System.Windows.Forms.MenuStrip menuStrip;
        
        private System.Windows.Forms.PictureBox pictureBox;

        #endregion
    }
}
