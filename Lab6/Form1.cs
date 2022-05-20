using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6{
    public partial class Form1 : Form{
        
        Pen pen;
        Bitmap buffer;
        Graphics graphics;

        private int _tool = 1;

        public Form1(){
            InitializeComponent();
            
            pen = new Pen(Color.Black, 1);
            buffer = new Bitmap(pictureBox.Width, pictureBox.Height);
            
            graphics = Graphics.FromImage(buffer);
            graphics.Clear(Color.White);
            pictureBox.Image = buffer;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e){
            if(e.Button != MouseButtons.Left){
                return;
            }
            
            if(_tool == 1){
                graphics.DrawLine(pen, e.X, e.Y, pictureBox.Width / 2, pictureBox.Height / 2);
            } else if(_tool == 2){
                graphics.DrawRectangle(pen, new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(_tool == 3){
                graphics.DrawLine(pen, e.X - 10, e.Y + 20, e.X + 10, e.Y - 20);
            } else if(_tool == 4){
                graphics.DrawLine(pen, e.X - 10, e.Y - 20, e.X + 10, e.Y + 20);
            } else if(_tool == 5){
                graphics.DrawLine(pen, e.X, e.Y - 20, e.X, e.Y + 20);
                graphics.DrawLine(pen, e.X - 20, e.Y, e.X + 20, e.Y);
            } else if(_tool == 6){
                graphics.DrawLine(pen, e.X - 20, e.Y - 20, e.X + 20, e.Y + 20);
                graphics.DrawLine(pen, e.X + 20, e.Y - 20, e.X - 20, e.Y + 20);
            } else if(_tool == 7){
                graphics.DrawEllipse(pen, new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(_tool == 8){
                graphics.FillEllipse(new SolidBrush(pen.Color), new Rectangle(e.X - 20, e.Y - 20, 40, 40));
            } else if(_tool == 9){
                graphics.DrawPolygon(pen, new[]{new Point(e.X, e.Y - 20), new Point(e.X - 20, e.Y + 20), new Point(e.X + 20, e.Y + 20)});
            } else {
                Random random = new Random();
                for(int i = 1; i <= 50; i++){

                    double randX = 20 * Math.Sqrt(random.NextDouble());
                    double randY = 2 * Math.PI * random.NextDouble();
                    int x = e.X + (int) Math.Floor(randX * Math.Cos(randY));
                    int y = e.Y + (int) Math.Floor(randX * Math.Sin(randY));

                    if(x >= 0 && x < buffer.Width && y >= 0 && y < buffer.Height){
                        buffer.SetPixel(x, y, pen.Color);
                    }
                }
            }

            pictureBox.Image = buffer;
        }
        
        private void pictureBox_MouseClick(object sender, MouseEventArgs e){
            if(e.Button == MouseButtons.Right){
                graphics.Clear(Color.White);
                pictureBox.Image = buffer;
            }
            
            pictureBox_MouseMove(sender, e);
        }

        private void colorMenu_Click(object sender, EventArgs e){
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK){
                pen.Color = colorDialog.Color;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e){
            _tool = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e){
            _tool = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e){
            _tool = 3;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e){
            _tool = 4;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e){
            _tool = 5;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e){
            _tool = 6;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e){
            _tool = 7;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e){
            _tool = 8;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e){
            _tool = 9;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e){
            _tool = 10;
        }

        private void depthMenu1_Click(object sender, EventArgs e){
            pen.Width = 1;
        }

        private void depthMenu2_Click(object sender, EventArgs e){
            pen.Width = 2;
        }

        private void depthMenu3_Click(object sender, EventArgs e){
            pen.Width = 3;
        }

        private void depthMenu4_Click(object sender, EventArgs e){
            pen.Width = 4;
        }

        private void depthMenu5_Click(object sender, EventArgs e){
            pen.Width = 5;
        }
    }
}
