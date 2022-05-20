using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7{
    
    public partial class FormPicture : Form{
        
        Graphics graphics;
        public Bitmap Buffer;

        public Pen Pen;
        public int Tool = 1;
        public string ToolName = "Линии в центр";
        
        public FormPicture(){
            InitializeComponent();
        }
        
        private void FormPicture_Load(object sender, EventArgs e){
            graphics = Graphics.FromImage(Buffer);
            pictureBox.Image = Buffer;
            Pen = new Pen(Color.Black, 1);
        }
        
        private void FormPicture_Activated(object sender, EventArgs e){
            Form1 main = (Form1) MdiParent;
            main.UpdateStatusBar();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e){
            if(e.Button != MouseButtons.Left){
                return;
            }
            
            if(Tool == 1){
                graphics.DrawLine(Pen, e.X, e.Y, pictureBox.Width / 2, pictureBox.Height / 2);
            } else if(Tool == 2){
                graphics.DrawRectangle(Pen, new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(Tool == 3){
                graphics.DrawLine(Pen, e.X - 10, e.Y + 20, e.X + 10, e.Y - 20);
            } else if(Tool == 4){
                graphics.DrawLine(Pen, e.X - 10, e.Y - 20, e.X + 10, e.Y + 20);
            } else if(Tool == 5){
                graphics.DrawLine(Pen, e.X, e.Y - 20, e.X, e.Y + 20);
                graphics.DrawLine(Pen, e.X - 20, e.Y, e.X + 20, e.Y);
            } else if(Tool == 6){
                graphics.DrawLine(Pen, e.X - 20, e.Y - 20, e.X + 20, e.Y + 20);
                graphics.DrawLine(Pen, e.X + 20, e.Y - 20, e.X - 20, e.Y + 20);
            } else if(Tool == 7){
                graphics.DrawEllipse(Pen, new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(Tool == 8){
                graphics.FillEllipse(new SolidBrush(Pen.Color), new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(Tool == 9){
                graphics.DrawPolygon(Pen, new[]{new Point(e.X, e.Y - 20), new Point(e.X - 20, e.Y + 20), new Point(e.X + 20, e.Y + 20)});
            } else {
                Random random = new Random();
                for(int i = 1; i <= 50; i++){

                    double randX = 20 * Math.Sqrt(random.NextDouble());
                    double randY = 2 * Math.PI * random.NextDouble();
                    int x = e.X + (int) Math.Floor(randX * Math.Cos(randY));
                    int y = e.Y + (int) Math.Floor(randX * Math.Sin(randY));

                    if(x >= 0 && x < Buffer.Width && y >= 0 && y < Buffer.Height){
                        Buffer.SetPixel(x, y, Pen.Color);
                    }
                }
            }

            pictureBox.Image = Buffer;
        }
        
        private void pictureBox_MouseClick(object sender, MouseEventArgs e){
            if(e.Button == MouseButtons.Right){
                graphics.Clear(Color.White);
                pictureBox.Image = Buffer;
            }
            
            pictureBox_MouseMove(sender, e);
        }
    }
}