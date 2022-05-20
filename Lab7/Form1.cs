using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7{
    public partial class Form1 : Form{
        
        private int _countPicture;

        public Form1(){
            InitializeComponent();
            
            menuGeneral.MdiWindowListItem = windowMenu;
        }

        private void SetTool(int tool, string toolName){
            FormPicture picture = (FormPicture) ActiveMdiChild;
            if(picture != null){
                picture.Tool = tool;
                picture.ToolName = toolName;
                UpdateStatusBar();
            }
        }

        private void SetColor(Color color){
            FormPicture picture = (FormPicture) ActiveMdiChild;
            if(picture != null){
                picture.Pen.Color = color;
                UpdateStatusBar();
            }
        }

        public void UpdateStatusBar(){
            FormPicture picture = (FormPicture) ActiveMdiChild;
            if(picture != null){
                statusBarTool.Text = "Инструмент: " + picture.ToolName;
                statusBarColor.BackColor = picture.Pen.Color;
                statusBarSize.Text = picture.Buffer.Width + "x" + picture.Buffer.Height;
            }
        }
        
        private void FileNewPicture_Click(object sender, EventArgs e){
            _countPicture++;
            
            FormPicture picture = new FormPicture{
                MdiParent = this,
                Text = "Рисунок #" + _countPicture,
                Buffer = new Bitmap(1280, 720)
            };
            
            picture.Show();
        }
        
        private void FileOpenPicture_Click(object sender, EventArgs e){
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            Image pic = Image.FromFile(openFileDialog1.FileName);
            
            float k = 1;
            if(pic.Width >= pic.Height && pic.Width > 1280){
                k = 1280f / pic.Width;
            } else if(pic.Width < pic.Height && pic.Height > 720){
                k = 720f / pic.Height;
            }
            
            FormPicture picture = new FormPicture{
                MdiParent = this,
                Text = openFileDialog1.FileName,
                Buffer = new Bitmap(pic, (int)(pic.Width * k), (int)(pic.Height * k))
            };
            picture.Show();
        }
        
        private void FileSavePicture_Click(object sender, EventArgs e){
            FormPicture picture = (FormPicture) ActiveMdiChild;
            if(picture != null){
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = picture.Text;
                saveDialog.Filter = "PNG (*.png)|*.png";
                
                if(saveDialog.ShowDialog() == DialogResult.OK){
                    picture.Buffer.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    picture.Text = saveDialog.FileName;
                }
            }
        }
        
        private void colorMenu_Click(object sender, EventArgs e){
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK){
                SetColor(colorDialog.Color);
            }
        }

        private void orderCascade_Click(object sender, EventArgs e){
            LayoutMdi(MdiLayout.Cascade);
        }

        private void orderVertical_Click(object sender, EventArgs e){
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void orderHorizontal_Click(object sender, EventArgs e){
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void orderIcons_Click(object sender, EventArgs e){
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        
        private void viewToolBar_Click(object sender, EventArgs e){
            
        }
        
        private void viewStatusBar_Click(object sender, EventArgs e){
            statusBar.Visible = viewStatusBar.Checked = !viewStatusBar.Checked;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e){
            SetTool(1, "Линии в центр");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e){
            SetTool(2, "Квадратики");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e){
            SetTool(3, "Диагональный отрезок /");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e){
            SetTool(4, "Диагональный отрезок \\");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e){
            SetTool(5, "Перекрестье +");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e){
            SetTool(6, "Перекрестье ×");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e){
            SetTool(7, "Окружность");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e){
            SetTool(8, "Круги");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e){
            SetTool(9, "Треугольники");
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e){
            SetTool(10, "Распылитель");
        }
    }
}