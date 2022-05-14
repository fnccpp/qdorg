using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace org
{
    public partial class MainForm : Form
    {
        List<TextBox> tasks08 = new List<TextBox>(); //lista dei task delle 8
        
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // click sul bottone
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox task = new TextBox();
            this.Controls.Add(task);
            task.BringToFront();
            task.Select();
            task.Width = 20;
            
            if (tasks08.Count == 0)//primo textbox
            {
                task.Location = new Point(button1.Location.X, button1.Location.Y);                
                task.TextChanged += new EventHandler(textBox_TextChanged);
            }

            else //textbox seguenti
            {
                int x = tasks08.Last().Location.X + tasks08.Last().Width + 2;
                task.Location = new Point(x, button1.Location.Y);                
                task.TextChanged += new EventHandler(textBox_TextChanged);
            }
            tasks08.Add(task);//aggiungi a lista, serve a vedere dov'è l'ultimo task

        }

        // Handler TextChanged: resize delle textbox quando cambia il testo
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox task = (TextBox)sender;

            Size size = TextRenderer.MeasureText(task.Text, task.Font);
            task.Width = size.Width + 5;
            //task.Height = size.Height;
            if (task.Text == "") //in teoria elimina task
            {
                //task.Dispose();
            }

            //sposta i task che sono a destra di quello che sta cambiando dimensione
            List<TextBox> temp = new List<TextBox>();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb.Location.X > task.Location.X)
                    {
                        temp.Add(tb);
                        //int x = tb.Location.X + task.Width;
                        //tb.Location = new Point(x+1, tb.Location.Y); 
                    }

                    List<TextBox> SortedList = temp.OrderBy(o => o.Location.X).ToList();
                    SortedList[0].Location = new Point(task.Location.X + task.Width, task.Location.Y);
                    for (int i=1; i < temp.Count(); i++)
                    {
                        SortedList[i].Location = new Point(SortedList[i - 1].Location.X + SortedList[i - 1].Width, task.Location.Y);
                    }
                }
            }
            
        }
    }
}
