namespace Lab8{
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
            this.components = new System.ComponentModel.Container();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusKitchen = new System.Windows.Forms.ToolStripStatusLabel();
            this.openKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.ContextMenuStrip = this.contextMenu;
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Items.AddRange(new object[]{"Глазунья", "Гусь жаренный", "Зелёный горошек", "Кильки в том. соусе", "Компот", "Мундиры", "Омар. не Хайам", "Сахар для чая", "Сухари сушённые", "Цветная капуста", "Чёрно-белая капуста"});
            this.listMenu.Location = new System.Drawing.Point(123, 133);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(168, 160);
            this.listMenu.TabIndex = 0;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.toolStripMenuItem1, this.toolStripMenuItem2, this.toolStripMenuItem3, this.toolStripMenuItem4});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(221, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem1.Text = "Добавить новое блюдо";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem2.Text = "Заказать блюдо";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem3.Text = "Удалить блюдо";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem4.Text = "Изменить название блюда";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(471, 133);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(168, 160);
            this.listOrder.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(342, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить ->";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(342, 199);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(82, 32);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "<- Убрать";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(342, 247);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(82, 32);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelMenu.Location = new System.Drawing.Point(152, 95);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(114, 35);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "МЕНЮ";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrder
            // 
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelOrder.Location = new System.Drawing.Point(502, 95);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(111, 35);
            this.labelOrder.TabIndex = 6;
            this.labelOrder.Text = "ЗАКАЗ";
            this.labelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.menuFile, this.menuKitchen});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.openKitchen});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuKitchen
            // 
            this.menuKitchen.Name = "menuKitchen";
            this.menuKitchen.Size = new System.Drawing.Size(91, 20);
            this.menuKitchen.Text = "Выбор кухни";
            this.menuKitchen.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuKitchen_DropDownItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.statusKitchen});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusKitchen
            // 
            this.statusKitchen.Name = "statusKitchen";
            this.statusKitchen.Size = new System.Drawing.Size(10, 17);
            this.statusKitchen.Text = " ";
            // 
            // openKitchen
            // 
            this.openKitchen.Name = "openKitchen";
            this.openKitchen.Size = new System.Drawing.Size(159, 22);
            this.openKitchen.Text = "Открыть кухню";
            this.openKitchen.Click += new System.EventHandler(this.openKitchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listMenu);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Ресторан \"Студент\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem openKitchen;

        private System.Windows.Forms.ToolStripStatusLabel statusKitchen;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.ToolStripMenuItem menuKitchen;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;

        private System.Windows.Forms.Label labelOrder;

        private System.Windows.Forms.Label labelMenu;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.ContextMenuStrip contextMenu;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOrder;

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.ListBox listOrder;

        #endregion
    }
}
