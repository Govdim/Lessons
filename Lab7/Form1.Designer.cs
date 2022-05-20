namespace Lab7{
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
            this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNewPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSavePicture = new System.Windows.Forms.ToolStripMenuItem();
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
            this.windowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.orderWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.orderVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.orderIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarColorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuGeneral.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileStripMenu
            // 
            this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.FileNewPicture, this.FileOpenPicture, this.FileSavePicture});
            this.FileStripMenu.Name = "FileStripMenu";
            this.FileStripMenu.Size = new System.Drawing.Size(48, 20);
            this.FileStripMenu.Text = "Файл";
            // 
            // FileNewPicture
            // 
            this.FileNewPicture.Name = "FileNewPicture";
            this.FileNewPicture.Size = new System.Drawing.Size(210, 22);
            this.FileNewPicture.Text = "Новое полотно";
            this.FileNewPicture.Click += new System.EventHandler(this.FileNewPicture_Click);
            // 
            // FileOpenPicture
            // 
            this.FileOpenPicture.Name = "FileOpenPicture";
            this.FileOpenPicture.Size = new System.Drawing.Size(210, 22);
            this.FileOpenPicture.Text = "Открыть изображение";
            this.FileOpenPicture.Click += new System.EventHandler(this.FileOpenPicture_Click);
            // 
            // FileSavePicture
            // 
            this.FileSavePicture.Name = "FileSavePicture";
            this.FileSavePicture.Size = new System.Drawing.Size(210, 22);
            this.FileSavePicture.Text = "Сохранить изображение";
            this.FileSavePicture.Click += new System.EventHandler(this.FileSavePicture_Click);
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.toolStripMenuItem1, this.toolStripMenuItem2, this.toolStripMenuItem3, this.toolStripMenuItem4, this.toolStripMenuItem5, this.toolStripMenuItem6, this.toolStripMenuItem7, this.toolStripMenuItem8, this.toolStripMenuItem9, this.toolStripMenuItem10});
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(95, 20);
            this.ToolStripMenu.Text = "Инструменты";
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
            // windowMenu
            // 
            this.windowMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.orderWindows});
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.Size = new System.Drawing.Size(48, 20);
            this.windowMenu.Text = "Окно";
            // 
            // orderWindows
            // 
            this.orderWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.orderCascade, this.orderVertical, this.orderHorizontal, this.orderIcons});
            this.orderWindows.Name = "orderWindows";
            this.orderWindows.Size = new System.Drawing.Size(146, 22);
            this.orderWindows.Text = "Упорядочить";
            // 
            // orderCascade
            // 
            this.orderCascade.Name = "orderCascade";
            this.orderCascade.Size = new System.Drawing.Size(158, 22);
            this.orderCascade.Text = "Каскад";
            this.orderCascade.Click += new System.EventHandler(this.orderCascade_Click);
            // 
            // orderVertical
            // 
            this.orderVertical.Name = "orderVertical";
            this.orderVertical.Size = new System.Drawing.Size(158, 22);
            this.orderVertical.Text = "Вертикально";
            this.orderVertical.Click += new System.EventHandler(this.orderVertical_Click);
            // 
            // orderHorizontal
            // 
            this.orderHorizontal.Name = "orderHorizontal";
            this.orderHorizontal.Size = new System.Drawing.Size(158, 22);
            this.orderHorizontal.Text = "Горизонтально";
            this.orderHorizontal.Click += new System.EventHandler(this.orderHorizontal_Click);
            // 
            // orderIcons
            // 
            this.orderIcons.Name = "orderIcons";
            this.orderIcons.Size = new System.Drawing.Size(158, 22);
            this.orderIcons.Text = "Иконки";
            this.orderIcons.Click += new System.EventHandler(this.orderIcons_Click);
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.FileStripMenu, this.ToolStripMenu, this.colorMenu, this.windowMenu, this.viewMenu});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(800, 24);
            this.menuGeneral.TabIndex = 1;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.viewToolBar, this.viewStatusBar});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(39, 20);
            this.viewMenu.Text = "Вид";
            // 
            // viewToolBar
            // 
            this.viewToolBar.Checked = true;
            this.viewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolBar.Name = "viewToolBar";
            this.viewToolBar.Size = new System.Drawing.Size(196, 22);
            this.viewToolBar.Text = "Панель инструментов";
            this.viewToolBar.Click += new System.EventHandler(this.viewToolBar_Click);
            // 
            // viewStatusBar
            // 
            this.viewStatusBar.Checked = true;
            this.viewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewStatusBar.Name = "viewStatusBar";
            this.viewStatusBar.Size = new System.Drawing.Size(196, 22);
            this.viewStatusBar.Text = "Строка состояния";
            this.viewStatusBar.Click += new System.EventHandler(this.viewStatusBar_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.statusBarTool, this.statusBarColorLabel, this.statusBarColor, this.statusBarSize});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 3;
            // 
            // statusBarTool
            // 
            this.statusBarTool.Name = "statusBarTool";
            this.statusBarTool.Size = new System.Drawing.Size(160, 17);
            this.statusBarTool.Text = "Инструмент: Линии в центр";
            // 
            // statusBarColorLabel
            // 
            this.statusBarColorLabel.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.statusBarColorLabel.Name = "statusBarColorLabel";
            this.statusBarColorLabel.Size = new System.Drawing.Size(39, 17);
            this.statusBarColorLabel.Text = "Цвет: ";
            // 
            // statusBarColor
            // 
            this.statusBarColor.BackColor = System.Drawing.Color.Black;
            this.statusBarColor.Name = "statusBarColor";
            this.statusBarColor.Size = new System.Drawing.Size(19, 17);
            this.statusBarColor.Text = "    ";
            // 
            // statusBarSize
            // 
            this.statusBarSize.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.statusBarSize.Name = "statusBarSize";
            this.statusBarSize.Size = new System.Drawing.Size(36, 17);
            this.statusBarSize.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "Form1";
            this.Text = "Графический редактор 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripStatusLabel statusBarSize;

        private System.Windows.Forms.ToolStripStatusLabel statusBarColor;

        private System.Windows.Forms.ToolStripStatusLabel statusBarColorLabel;

        private System.Windows.Forms.ToolStripStatusLabel statusBarTool;
        
        private System.Windows.Forms.StatusStrip statusBar;

        private System.Windows.Forms.ToolStripMenuItem viewStatusBar;

        private System.Windows.Forms.ToolStripMenuItem viewToolBar;
        
        private System.Windows.Forms.ToolStripMenuItem viewMenu;

        private System.Windows.Forms.ToolStripMenuItem orderIcons;

        private System.Windows.Forms.ToolStripMenuItem orderHorizontal;

        private System.Windows.Forms.ToolStripMenuItem orderVertical;

        private System.Windows.Forms.ToolStripMenuItem orderCascade;

        private System.Windows.Forms.ToolStripMenuItem orderWindows;

        private System.Windows.Forms.MenuStrip menuGeneral;

        private System.Windows.Forms.ToolStripMenuItem FileSavePicture;

        private System.Windows.Forms.ToolStripMenuItem FileOpenPicture;

        private System.Windows.Forms.ToolStripMenuItem FileNewPicture;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem windowMenu;

        private System.Windows.Forms.ToolStripMenuItem colorMenu;

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu;

        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        
        #endregion
    }
}