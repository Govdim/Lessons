using System;
using System.IO;
using System.Windows.Forms;

namespace Lab8{
    
    public partial class Form1 : Form{
        
        string dirKitchen = Directory.GetCurrentDirectory() + "\\Кухня";
        string fileKitchen;

        private bool _changes;

        public Form1(){
            InitializeComponent();
        }
        
        void MenuLoad(){
            if(!Directory.Exists(dirKitchen)){
                MessageBox.Show("Каталог «Кухня» отсутствует!",

                    "Ресторан «Студент»", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            
            string[] files = Directory.GetFiles(dirKitchen, "*.khn");
            menuKitchen.DropDownItems.Clear();
            foreach(string file in files){
                string name = new FileInfo(file).Name;
                name = name.Remove(name.Length - 4);
                menuKitchen.DropDownItems.Add(name);
            }
        }
        
        void SaveKitchen(){
            _changes = false;
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Ресторан «Студент»",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No){
                return;
            }
            
            StreamWriter writer = new StreamWriter(fileKitchen, false);
            for(int i = 0; i < listMenu.Items.Count; i++){
                writer.WriteLine(listMenu.Items[i]);
            }
            writer.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e){
            MenuLoad();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            if(_changes){
                SaveKitchen();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e){
            if(listMenu.SelectedIndex >= 0){
                listOrder.Items.Add(listMenu.SelectedItem);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e){
            if(listOrder.SelectedIndex >= 0){
                listOrder.Items.RemoveAt(listOrder.SelectedIndex);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e){
            if(listOrder.Items.Count > 0){
                MessageBox.Show("Приятного аппетита!", "Ресторан «Студент»", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }
        
        private void listMenu_SelectedIndexChanged(object sender, EventArgs e){
            toolStripMenuItem2.Enabled = listMenu.SelectedIndex >= 0;
            toolStripMenuItem3.Enabled = listMenu.SelectedIndex >= 0;
            toolStripMenuItem4.Enabled = listMenu.SelectedIndex >= 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e){
            string str = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда",
                "Ресторан «Студент»", "<Новое блюдо>");
            if(str != ""){
                listMenu.Items.Add(str);
                _changes = true;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e){
            listMenu.Items.RemoveAt(listMenu.SelectedIndex);
            _changes = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e){
            
            string str = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название для блюда",
                "Ресторан «Студент»", (string) listMenu.SelectedItem);
            if(str != "" && str != (string) listMenu.SelectedItem){
                listMenu.Items.Insert(listMenu.SelectedIndex, str);
                listMenu.Items.RemoveAt(listMenu.SelectedIndex);

                _changes = true;
            }
        }

        private void menuKitchen_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e){
            if(_changes){
                SaveKitchen();
            }
            
            fileKitchen = dirKitchen + "\\" + e.ClickedItem.Text + ".khn";
            if(new FileInfo(fileKitchen).Exists == false){
                MessageBox.Show("Данных об этой кухне нет!",
                    "Ресторан «Студент»", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            StreamReader reader = new StreamReader(fileKitchen);
            listMenu.Items.Clear();
            while(!reader.EndOfStream){
                listMenu.Items.Add(reader.ReadLine());
            }
            reader.Close();
            toolStripMenuItem1.Enabled = true;
            statusKitchen.Text = e.ClickedItem.Text + " кухня";
        }

        private void openKitchen_Click(object sender, EventArgs e){
            if(_changes){
                SaveKitchen();
            }
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Кухня (*.khn)|*.khn";
            if(openFileDialog.ShowDialog() == DialogResult.OK){
                fileKitchen = openFileDialog.FileName;
                
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                listMenu.Items.Clear();
                while(!reader.EndOfStream){
                    listMenu.Items.Add(reader.ReadLine());
                }
                reader.Close();
                
                string name = new FileInfo(openFileDialog.FileName).Name;
                name = name.Remove(name.Length - 4);
                statusKitchen.Text = name + " кухня";
                toolStripMenuItem1.Enabled = true;
            }
        }
    }
}
