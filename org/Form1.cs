using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

namespace org
{
    public partial class MainForm : Form
    {
        private string XMLpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Organik";
        private string XMLfilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Organik\\tasks.xml";
        private XmlDocument doc = null;
        private XmlNodeList listaNodi = null; 

        public MainForm()
        {
            InitializeComponent();
            // crea file xml se non esiste gia, se c'è carica i valori
            doc = new XmlDocument();
            if (!File.Exists(XMLfilename))
            {
                System.IO.Directory.CreateDirectory(XMLpath);
                XDocument doc2 = new XDocument(
                    new XElement("tasks",
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", ""),
                        new XElement("task", "")
                        )
                    );
                doc2.Save(XMLfilename);
            }

                doc.Load(XMLfilename);
            XmlNode root = doc.DocumentElement;
            listaNodi = doc.SelectNodes("tasks/task");
            loadTasks();            
        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOra.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void loadTasks()
        {
            
            //fai con ciclo for
            rtb08.Text = listaNodi[0].InnerText;
            rtb09.Text = listaNodi[1].InnerText;
            rtb10.Text = listaNodi[2].InnerText;
            rtb11.Text = listaNodi[3].InnerText;
            rtb12.Text = listaNodi[4].InnerText;
            rtb13.Text = listaNodi[5].InnerText;
            rtb14.Text = listaNodi[6].InnerText;
            rtb15.Text = listaNodi[7].InnerText;
            rtb16.Text = listaNodi[8].InnerText;
            rtb17.Text = listaNodi[9].InnerText;
            rtb18.Text = listaNodi[10].InnerText;
            rtb19.Text = listaNodi[11].InnerText;
            rtb20.Text = listaNodi[12].InnerText;
            rtb21.Text = listaNodi[13].InnerText;
        }

        private void rtb08_TextChanged(object sender, EventArgs e)
        {
            listaNodi[0].InnerText = rtb08.Text;
            doc.Save(XMLfilename);
        }

        private void rtb09_TextChanged(object sender, EventArgs e)
        {
            listaNodi[1].InnerText = rtb09.Text;
            doc.Save(XMLfilename);
        }

        private void rtb10_TextChanged(object sender, EventArgs e)
        {
            listaNodi[2].InnerText = rtb10.Text;
            doc.Save(XMLfilename);
        }

        private void rtb11_TextChanged(object sender, EventArgs e)
        {
            listaNodi[3].InnerText = rtb11.Text;
            doc.Save(XMLfilename);
        }

        private void rtb12_TextChanged(object sender, EventArgs e)
        {
            listaNodi[4].InnerText = rtb12.Text;
            doc.Save(XMLfilename);
        }

        private void rtb13_TextChanged(object sender, EventArgs e)
        {
            listaNodi[5].InnerText = rtb13.Text;
            doc.Save(XMLfilename);
        }

        private void rtb14_TextChanged(object sender, EventArgs e)
        {
            listaNodi[6].InnerText = rtb14.Text;
            doc.Save(XMLfilename);
        }

        private void rtb15_TextChanged(object sender, EventArgs e)
        {
            listaNodi[7].InnerText = rtb15.Text;
            doc.Save(XMLfilename);
        }

        private void rtb16_TextChanged(object sender, EventArgs e)
        {
            listaNodi[8].InnerText = rtb16.Text;
            doc.Save(XMLfilename);
        }

        private void rtb17_TextChanged(object sender, EventArgs e)
        {
            listaNodi[9].InnerText = rtb17.Text;
            doc.Save(XMLfilename);
        }

        private void rtb18_TextChanged(object sender, EventArgs e)
        {
            listaNodi[10].InnerText = rtb18.Text;
            doc.Save(XMLfilename);
        }

        private void rtb19_TextChanged(object sender, EventArgs e)
        {
            listaNodi[11].InnerText = rtb19.Text;
            doc.Save(XMLfilename);
        }

        private void rtb20_TextChanged(object sender, EventArgs e)
        {
            listaNodi[12].InnerText = rtb20.Text;
            doc.Save(XMLfilename);
        }

        private void rtb21_TextChanged(object sender, EventArgs e)
        {
            listaNodi[13].InnerText = rtb21.Text;
            doc.Save(XMLfilename);
        }

        //Bottoni Delete
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
    }
}
