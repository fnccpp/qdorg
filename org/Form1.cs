using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.IO;
using System.Collections;
//using Newtonsoft.Json;


namespace org
{
    public partial class MainForm : Form
    {
        private string JSONpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Organik";
        private string JSONfilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Organik\\tasks.json";
        string stringaJSON = "";
        tasksClass tasksObject = new tasksClass();
        //tasksClass tasksObject;

        public MainForm()
        {
            InitializeComponent();
            // crea file JSON se non esiste già
            if (!File.Exists(JSONfilename))
            {
                System.IO.Directory.CreateDirectory(JSONpath);
                stringaJSON += "{";
                for (int i = 0; i<13; i++)
                {
                    int ora = i + 8;
                    stringaJSON += ("\n\t\"task" + ora + "\":\"\",");
                }
                stringaJSON += "\n\t\"task21\":\"\"\n}";
                File.WriteAllText(JSONfilename, stringaJSON); 
            }
            //carica i valori dal JSON alla classe
            loadTasks();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        // JSON -> classe
        private void loadTasks()
        {
            stringaJSON = File.ReadAllText(JSONfilename);
            Console.WriteLine(stringaJSON);
            tasksObject = JsonSerializer.Deserialize<tasksClass>(stringaJSON);
            rtb08.Text = tasksObject.task8;
            rtb09.Text = tasksObject.task9;
            rtb10.Text = tasksObject.task10;
            rtb11.Text = tasksObject.task11;
            rtb12.Text = tasksObject.task12;
            rtb13.Text = tasksObject.task13;
            rtb14.Text = tasksObject.task14;
            rtb15.Text = tasksObject.task15;
            rtb16.Text = tasksObject.task16;
            rtb17.Text = tasksObject.task17;
            rtb18.Text = tasksObject.task18;
            rtb19.Text = tasksObject.task19;
            rtb20.Text = tasksObject.task20;
            rtb21.Text = tasksObject.task21;
        }

        // text changed
        private void rtb08_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task8 = rtb08.Text;
            stringaJSON = System.Text.Json.JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb09_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task9 = rtb09.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb10_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task10 = rtb10.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb11_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task11 = rtb11.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb12_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task12 = rtb12.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb13_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task13 = rtb13.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb14_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task14 = rtb14.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb15_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task15 = rtb15.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb16_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task16 = rtb16.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb17_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task17 = rtb17.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb18_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task18 = rtb18.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb19_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task19 = rtb19.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb20_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task20 = rtb20.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }
        private void rtb21_TextChanged(object sender, EventArgs e)
        {
            tasksObject.task21 = rtb21.Text;
            stringaJSON = JsonSerializer.Serialize(tasksObject);
            File.WriteAllText(JSONfilename, stringaJSON);
        }

        // Visibilità bottoni Delete 
        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb08_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = true;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb09_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = true;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb10_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = true;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb11_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = true;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb12_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = true;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb13_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = true;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb14_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = true;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb15_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = true;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb16_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = true;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb17_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = true;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb18_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = true;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb19_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = true;
            btnDel20.Visible = false;
            btnDel21.Visible = false;
        }
        private void rtb20_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = true;
            btnDel21.Visible = false;
        }
        private void rtb21_MouseEnter(object sender, EventArgs e)
        {
            btnDel08.Visible = false;
            btnDel09.Visible = false;
            btnDel10.Visible = false;
            btnDel11.Visible = false;
            btnDel12.Visible = false;
            btnDel13.Visible = false;
            btnDel14.Visible = false;
            btnDel15.Visible = false;
            btnDel16.Visible = false;
            btnDel17.Visible = false;
            btnDel18.Visible = false;
            btnDel19.Visible = false;
            btnDel20.Visible = false;
            btnDel21.Visible = true;
        }

        // Click bottoni Delete
        private void btnDel08_Click(object sender, EventArgs e)
        {
            rtb08.Text = "";
            rtb08.Focus();
        }
        private void btnDel09_Click(object sender, EventArgs e)
        {
            rtb09.Text = "";
            rtb09.Focus();
        }
        private void btnDel10_Click(object sender, EventArgs e)
        {
            rtb10.Text = "";
            rtb10.Focus();
        }
        private void btnDel11_Click(object sender, EventArgs e)
        {
            rtb11.Text = "";
            rtb11.Focus();
        }
        private void btnDel12_Click(object sender, EventArgs e)
        {
            rtb12.Text = "";
            rtb12.Focus();
        }
        private void btnDel13_Click(object sender, EventArgs e)
        {
            rtb13.Text = "";
            rtb13.Focus();
        }
        private void btnDel14_Click(object sender, EventArgs e)
        {
            rtb14.Text = "";
            rtb14.Focus();
        }
        private void btnDel15_Click(object sender, EventArgs e)
        {
            rtb15.Text = "";
            rtb15.Focus();
        }
        private void btnDel16_Click(object sender, EventArgs e)
        {
            rtb16.Text = "";
            rtb16.Focus();
        }
        private void btnDel17_Click(object sender, EventArgs e)
        {
            rtb17.Text = "";
            rtb17.Focus();
        }
        private void btnDel18_Click(object sender, EventArgs e)
        {
            rtb18.Text = "";
            rtb18.Focus();
        }
        private void btnDel19_Click(object sender, EventArgs e)
        {
            rtb19.Text = "";
            rtb19.Focus();
        }
        private void btnDel20_Click(object sender, EventArgs e)
        {
            rtb20.Text = "";
            rtb20.Focus();
        }
        private void btnDel21_Click(object sender, EventArgs e)
        {
            rtb21.Text = "";
            rtb21.Focus();
        }

        // handler dell'invio di google search
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && tbSearch.Text != "")
            {
                // Enter key pressed
                Process.Start("https://www.google.com/search?q=" + tbSearch.Text);
                tbSearch.Text = "";
            }
        }

        // ora e data
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOra.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

    }

    // classe tasks
    public class tasksClass
    {
        //tasksClass(string task8, string task9, string task10, string task11, string task12, string task13, string task14, string task15, string task16, string task17, string task18, string task19, string task20, string task21)
        //{
        //    this.task8 = task8;
        //    this.task9 = task9;
        //    this.task10 = task10;
        //    this.task11 = task11;
        //    this.task12 = task12;
        //    this.task13 = task13;
        //    this.task14 = task14;
        //    this.task15 = task15;
        //    this.task16 = task16;
        //    this.task17 = task17;
        //    this.task18 = task18;
        //    this.task19 = task19;
        //    this.task20 = task20;
        //    this.task21 = task21;
        //}

        public string task8 { get; set; }
        public string task9 { get; set; }
        public string task10 { get; set; }
        public string task11 { get; set; }
        public string task12 { get; set; }
        public string task13 { get; set; }
        public string task14 { get; set; }
        public string task15 { get; set; }
        public string task16 { get; set; }
        public string task17 { get; set; }
        public string task18 { get; set; }
        public string task19 { get; set; }
        public string task20 { get; set; }
        public string task21 { get; set; }

    }
}
    
