using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.UI;
using System.Diagnostics;




namespace Konvertor_BIN_LOG
{
    
    public partial class Form1 : Form
    {
        bool Estop = false;
        string sSelectedPath = null;
        string csSelectedPath = null;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPath = fbd.SelectedPath;
                tbx_cesta.Text = sSelectedPath;
                checkBoxA.Enabled = false;
                checkBoxA.Visible = false;
                checkBoxF.Enabled = false;
                checkBoxF.Visible = false;
                checkBoxL.Enabled = false;
                checkBoxL.Visible = false;
                checkBoxP.Enabled = false;
                checkBoxP.Visible = false;
                checkBoxS.Visible = false;
                checkBoxS.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                tlac_preklad.Enabled = false;
                tlac_preklad.Visible = false;
                tlac_otevrislozku.Visible = false;
                tlac_otevrislozku.Enabled = false;

            }
            
        }

        private void but_analyzuj_Click(object sender, EventArgs e)
        {
            int count = 0;
            int completecount = 0;
            
                if (Directory.Exists(sSelectedPath)==true)
                {
                    var logFiles = Directory.EnumerateFiles(sSelectedPath, "*.log");

                    foreach (string currentFile in logFiles)
                    {
                        completecount++;
                    }

                    label1.Text = Convert.ToString("Celkem zpracovatelných souborů: " + completecount);
                    label1.Visible = true;

                    logFiles = Directory.EnumerateFiles(sSelectedPath, "*_P.log");
                    count = 0;
                    foreach (string currentFile in logFiles)
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        checkBoxP.Enabled = true;
                        checkBoxP.Visible = true;
                        checkBoxP.Checked = true;
                    }
                    else
                    {
                        checkBoxP.Enabled = false;
                        checkBoxP.Visible = true;
                        checkBoxP.Checked = false;
                    }
                    label2.Text = Convert.ToString("Celkem Produkčních souborů: " + count);
                    label2.Visible = true;

                    logFiles = Directory.EnumerateFiles(sSelectedPath, "*_A.log");
                    count = 0;
                    foreach (string currentFile in logFiles)
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        checkBoxA.Enabled = true;
                        checkBoxA.Visible = true;
                        checkBoxA.Checked = true;
                    }
                    else
                    {
                        checkBoxA.Enabled = false;
                        checkBoxA.Visible = true;
                        checkBoxA.Checked = false;
                    }
                    label3.Text = Convert.ToString("Celkem Alarmových souborů: " + count);
                    label3.Visible = true;

                    logFiles = Directory.EnumerateFiles(sSelectedPath, "*_S.log");
                    count = 0;
                    foreach (string currentFile in logFiles)
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        checkBoxS.Enabled = true;
                        checkBoxS.Visible = true;
                        checkBoxS.Checked = true;
                    }
                    else
                    {
                        checkBoxS.Enabled = false;
                        checkBoxS.Visible = true;
                        checkBoxS.Checked = false;
                    }
                    label4.Text = Convert.ToString("Celkem Zapínacích souborů: " + count);
                    label4.Visible = true;

                    logFiles = Directory.EnumerateFiles(sSelectedPath, "*_F.log");
                    count = 0;
                    foreach (string currentFile in logFiles)
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        checkBoxF.Enabled = true;
                        checkBoxF.Visible = true;
                        checkBoxF.Checked = true;
                    }
                    else
                    {
                        checkBoxF.Enabled = false;
                        checkBoxF.Visible = true;
                        checkBoxF.Checked = false;
                    }
                    label5.Text = Convert.ToString("Celkem Vypínacích souborů: " + count);
                    label5.Visible = true;

                    logFiles = Directory.EnumerateFiles(sSelectedPath, "*_L.log");
                    count = 0;
                    foreach (string currentFile in logFiles)
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        checkBoxL.Enabled = true;
                        checkBoxL.Visible = true;
                        checkBoxL.Checked = true;


                    }
                    else
                    {

                        checkBoxL.Enabled = false;
                        checkBoxL.Visible = true;
                        checkBoxL.Checked = false;
                    }
                    label6.Text = Convert.ToString("Celkem Login souborů: " + count);
                    label6.Visible = true;

                    if (completecount != 0)
                    {
                        tbx_cestavystup.Text = sSelectedPath;
                        tbx_cestavystup.Visible = true;
                        tlac_preklad.Visible = true;
                        tlac_preklad.Enabled = true;
                    }
                    else
                    {
                        tbx_cestavystup.Visible = false;
                        tlac_preklad.Visible = false;
                        tlac_preklad.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Asi chyba");
                }
                
            




        }

        private void tlac_preklad_Click(object sender, EventArgs e)
        {
            tlac_preklad.Visible = false;
            tlac_otevrislozku.Visible = false;
            tlac_otevrislozku.Enabled = false;
            tlac_stop.Visible = true;
            tlac_stop.Enabled = true;
            if (checkBoxP.Checked == true)
            {               
                var logFiles = Directory.EnumerateFiles(sSelectedPath, "*_P.log");
                foreach (string currentFile in logFiles)
                {
                    byte[] databin = new byte[8000];
                    short[] x = new short[4000];
                    using (BinaryReader b = new BinaryReader(File.Open(currentFile, FileMode.Open)))
                    {
                        // 2.
                        // Position and length variables.
                        int pos = 0;
                        // 2A.
                        // Use BaseStream.
                        int length = (int)b.BaseStream.Length;
                        int i = 0;
                        while (pos < length)
                        {
                            // 3.
                            // Read integer.
                            byte v = b.ReadByte();
                            databin[i] = v;

                            // 4.
                            // Advance our position variable.
                            pos += 1;
                            i++;
                        }
                    }

                    for (int i = 0; i < 8000; i += 2)
                    {
                        x[i / 2] = BitConverter.ToInt16(databin, i);
                    }

                    StringWriter stringwriter = new StringWriter();
                    HtmlTextWriter writer = new HtmlTextWriter(stringwriter);
                    writer.WriteBeginTag("p");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.Write("Vypis Zakazky");
                    writer.WriteLine();
                    writer.WriteLine("Zadání programu");
                    writer.WriteEndTag("p");
                    writer.WriteBeginTag("table border='2'");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.WriteBeginTag("tr");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("REL");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("ABS");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    for (int i = 1; i < 21; i++)
                    {
                        writer.WriteBeginTag("td");

                        writer.Write(HtmlTextWriter.TagRightChar);
                        writer.Write("TOOL" + i);
                        writer.WriteEndTag("td");

                    }


                    writer.WriteEndTag("tr");




                    for (int i = 0; i < 99; i++)
                    {
                        writer.WriteBeginTag("tr");
                        writer.Write(HtmlTextWriter.TagRightChar);
                        for (int j = 0; j < 32; j++)
                        {
                            if ((j + (i * 32)) >= 2249)
                            {
                                break;
                            }
                            else
                            {
                                writer.WriteBeginTag("td");
                                writer.Write(HtmlTextWriter.TagRightChar);
                                writer.Write(x[j + (i * 32)].ToString());
                                writer.WriteEndTag("td");
                            }
                        }
                        writer.WriteEndTag("tr");

                    }
                    writer.WriteEndTag("table");


                    //writer.WriteEndTag("table");

                    writer.WriteLine();
                    writer.WriteLine("Korekce");

                    string novacesta = tbx_cestavystup.Text + @"\prelozeno\";
                    string vystup = currentFile;
                    int delkacesty = vystup.Length - 20;
                    for (int i = 0; i < delkacesty; i++)
                    {
                        vystup = vystup.Remove(0, 1);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        vystup = vystup.Remove(vystup.Length - 1);
                    }
                    if (Directory.Exists(tbx_cestavystup + "prelozeno") == false)
                    {

                        Directory.CreateDirectory(novacesta);
                    }

                    using (StreamWriter sw = new StreamWriter(novacesta + vystup + ".html"))
                    {
                        sw.Write(stringwriter.ToString());
                    }

                }
                
            }
            if (checkBoxA.Checked == true)
            {
                var logFiles = Directory.EnumerateFiles(sSelectedPath, "*_A.log");

                foreach (string currentFile in logFiles)
                {
                    byte[] databin = new byte[10000];
                    short[] x = new short[5000];
                    using (BinaryReader b = new BinaryReader(File.Open(currentFile, FileMode.Open)))
                    {
                        // 2.
                        // Position and length variables.
                        int pos = 0;
                        // 2A.
                        // Use BaseStream.
                        int length = (int)b.BaseStream.Length;
                        int i = 0;
                        while (pos < length)
                        {
                            // 3.
                            // Read integer.
                            byte v = b.ReadByte();
                            databin[i] = v;

                            // 4.
                            // Advance our position variable.
                            pos += 1;
                            i++;
                        }
                    }

                    for (int i = 0; i < 10000; i += 2)
                    {
                        x[i / 2] = BitConverter.ToInt16(databin, i);
                    }

                    StringWriter stringwriter = new StringWriter();
                    HtmlTextWriter writer = new HtmlTextWriter(stringwriter);
                    writer.WriteBeginTag("p");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.Write("Vypis Zakazky");
                    writer.WriteLine();
                    writer.WriteLine("Zadání programu");
                    writer.WriteEndTag("p");
                    writer.WriteBeginTag("table border='2'");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.WriteBeginTag("tr");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("REL");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("ABS");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    for (int i = 1; i < 21; i++)
                    {
                        writer.WriteBeginTag("td");

                        writer.Write(HtmlTextWriter.TagRightChar);
                        writer.Write("TOOL" + i);
                        writer.WriteEndTag("td");

                    }


                    writer.WriteEndTag("tr");
                    for (int i = 0; i < 99; i++)
                    {
                        writer.WriteBeginTag("tr");
                        writer.Write(HtmlTextWriter.TagRightChar);
                        for (int j = 0; j < 32; j++)
                        {
                            if ((j + (i * 32)) >= 2249)
                            {
                                break;
                            }
                            else
                            {
                                writer.WriteBeginTag("td");
                                writer.Write(HtmlTextWriter.TagRightChar);
                                writer.Write(x[j + (i * 32)].ToString());
                                writer.WriteEndTag("td");
                            }
                        }
                        writer.WriteEndTag("tr");

                    }
                    writer.WriteEndTag("table");


                    //writer.WriteEndTag("table");

                    writer.WriteLine();
                    writer.WriteLine("Korekce");

                    string novacesta = tbx_cestavystup.Text + @"\prelozeno\";
                    string vystup = currentFile;
                    int delkacesty = vystup.Length - 20;
                    for (int i = 0; i < delkacesty; i++)
                    {
                        vystup = vystup.Remove(0, 1);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        vystup = vystup.Remove(vystup.Length - 1);
                    }
                    if (Directory.Exists(tbx_cestavystup + "prelozeno") == false)
                    {

                        Directory.CreateDirectory(novacesta);
                    }

                    using (StreamWriter sw = new StreamWriter(novacesta + vystup + ".html"))
                    {
                        sw.Write(stringwriter.ToString());
                    }
                }
            }
            if (checkBoxL.Checked == true)
            {
                var logFiles = Directory.EnumerateFiles(sSelectedPath, "*_L.log");

                foreach (string currentFile in logFiles)
                {
                    byte[] databin = new byte[50];
                    short[] x = new short[12];
                    
                    char[] name = new char[20];
                    
                    using (BinaryReader b = new BinaryReader(File.Open(currentFile, FileMode.Open)))
                    {
                        // 2.
                        // Position and length variables.
                        int pos = 0;
                        // 2A.
                        // Use BaseStream.
                        int length = (int)b.BaseStream.Length;
                        int i = 0;
                        while (pos < length)
                        {
                            // 3.
                            // Read integer.
                            byte v = b.ReadByte();
                            databin[i] = v;

                            // 4.
                            // Advance our position variable.
                            pos += 1;
                            i++;
                        }
                    }
                    for (int i = 0; i < 24; i += 2)
                    {
                        x[i / 2] = Convert.ToInt16(databin[i]);
                    }
                    for (int i = 24; i < 44; i++)
                    {
                        name[i - 24] = Convert.ToChar(databin[i]);
                    }
                    

                    StringWriter stringwriter = new StringWriter();
                    HtmlTextWriter writer = new HtmlTextWriter(stringwriter);

                    writer.WriteBeginTag("p");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.Write("Výpis Login");
                    writer.WriteLine();
                    writer.WriteLine("Login Uživatelé");
                    writer.WriteEndTag("p");
                    writer.WriteBeginTag("table border='2'");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.WriteBeginTag("tr");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("REL");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("ABS");
                    writer.WriteEndTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);






                }
            }
            if (checkBoxF.Checked == true)
            {
                var logFiles = Directory.EnumerateFiles(sSelectedPath, "*_F.log");

                foreach (string currentFile in logFiles)
                {
                    byte[] databin = new byte[10];
                    UInt32 serialnumber = 0;



                    using (BinaryReader b = new BinaryReader(File.Open(currentFile, FileMode.Open)))
                    {
                        // 2.
                        // Position and length variables.
                        int pos = 0;
                        // 2A.
                        // Use BaseStream.
                        int length = (int)b.BaseStream.Length;
                        int i = 0;
                        while (pos < length)
                        {
                            // 3.
                            // Read integer.
                            byte v = b.ReadByte();
                            databin[i] = v;

                            // 4.
                            // Advance our position variable.
                            pos += 1;
                            i++;
                        }
                    }
                    serialnumber = BitConverter.ToUInt32(databin, 0);
                    StringWriter stringwriter = new StringWriter();
                    HtmlTextWriter writer = new HtmlTextWriter(stringwriter);

                    writer.WriteBeginTag("p");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.Write("Výpis Vypnutí");
                    writer.WriteLine();
                    writer.WriteLine();
                    writer.Write(serialnumber.ToString());
                    writer.WriteEndTag("p");
                    string novacesta = tbx_cestavystup.Text + @"\prelozeno\";
                    string vystup = currentFile;
                    int delkacesty = vystup.Length - 20;
                    for (int i = 0; i < delkacesty; i++)
                    {
                        vystup = vystup.Remove(0, 1);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        vystup = vystup.Remove(vystup.Length - 1);
                    }
                    if (Directory.Exists(tbx_cestavystup + "prelozeno") == false)
                    {

                        Directory.CreateDirectory(novacesta);
                    }

                    using (StreamWriter sw = new StreamWriter(novacesta + vystup + ".html"))
                    {
                        sw.Write(stringwriter.ToString());
                    }

                }
            }
            if (checkBoxS.Checked == true)
            {
                var logFiles = Directory.EnumerateFiles(sSelectedPath, "*_S.log");
                    byte[] databin = new byte[10];
                    UInt32 serialnumber = 0;

                foreach (string currentFile in logFiles)
                {
                    if (Estop==true)
                    {
                       
                        return;
                    }
                    for (int i = 0; i ==10; i++)
                    {
                        databin[i] = 0;
                    }
                    serialnumber = 0;



                    using (BinaryReader b = new BinaryReader(File.Open(currentFile, FileMode.Open)))
                    {
                        // 2.
                        // Position and length variables.
                        int pos = 0;
                        // 2A.
                        // Use BaseStream.
                        int length = (int)b.BaseStream.Length;
                        int i = 0;
                        while (pos < length)
                        {
                            // 3.
                            // Read integer.
                            byte v = b.ReadByte();
                            databin[i] = v;

                            // 4.
                            // Advance our position variable.
                            pos += 1;
                            i++;
                        }
                    }
                    serialnumber = BitConverter.ToUInt32(databin, 0);
                    StringWriter stringwriter = new StringWriter();
                    HtmlTextWriter writer = new HtmlTextWriter(stringwriter);

                    writer.WriteBeginTag("p");
                    writer.Write(HtmlTextWriter.TagRightChar);

                    writer.Write("Výpis Zapnutí");
                    writer.WriteLine();
                    writer.WriteLine();
                    writer.Write(serialnumber.ToString());
                    writer.WriteEndTag("p");
                    string novacesta = tbx_cestavystup.Text + @"\prelozeno\";
                    string vystup = currentFile;
                    int delkacesty = vystup.Length - 20;
                    for (int i = 0; i < delkacesty; i++)
                    {
                        vystup = vystup.Remove(0, 1);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        vystup = vystup.Remove(vystup.Length - 1);
                    }
                    if (Directory.Exists(tbx_cestavystup + "prelozeno") == false)
                    {

                        Directory.CreateDirectory(novacesta);
                    }

                    using (StreamWriter sw = new StreamWriter(novacesta + vystup + ".html"))
                    {
                        sw.Write(stringwriter.ToString());
                    }

                }
            }
            tlac_preklad.Visible = true;
            tlac_otevrislozku.Visible = true;
            tlac_otevrislozku.Enabled = true;
            tlac_stop.Visible = false;
            tlac_stop.Enabled = false;
        }

        private void checkBoxP_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxP.Checked == false) && (checkBoxL.Checked == false) && (checkBoxS.Checked == false) && (checkBoxF.Checked == false) && (checkBoxA.Checked == false))
            {
                
                tlac_preklad.BackColor = Color.Red;
                tlac_preklad.Enabled = false;
            }
            else
            {
                tlac_preklad.Enabled = true;
                tlac_preklad.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(tbx_cestavystup.Text+@"\prelozeno\");
        }

        private void tbx_cestavystup_MouseDown(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                csSelectedPath = fbd.SelectedPath;
                tbx_cestavystup.Text = csSelectedPath;
            }

        }

        private void tlac_Estop_Click(object sender, EventArgs e)
        {
            Estop = true;
        }
    }
}
