using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mNotepad_GitHub.mainEvents;
using mNotepad_GitHub;
using Timer = System.Windows.Forms.Timer;

namespace mNotepad_GitHub
{
    public partial class mainForm : Form
    {
        operationEdit operationEdit;
        Timer timer;

        public mainForm()
        {
            InitializeComponent();
            operationEdit = new operationEdit();
            timer = new Timer();
            timer.Tick += MyTimer_Tick;
            timer.Interval = 500;

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            operationEdit.Add_UndoRedo(textLayout.Text);
            UpdateView();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string language = "default";
        public static int test;

        private void mainForm_Load(object sender, EventArgs e)
        {
            textLayout.ScrollBars = ScrollBars.Both;
            textLayout.ScrollBars = ScrollBars.Vertical;

            if (textLayout.Text == "")
            {
                if (fileName == null)
                {
                    this.Text = "Unlited - mNotepad";
                    titleRequire = 0;
                }
                if (fileName != null)
                {
                    this.Text = fileName + " - mNotepad";
                    titleRequire = 0;
                }
            }

            if (titleRequire == 0)
            {
                if (textLayout.Text != "")
                {
                    if (fileName == null)
                    {
                        this.Text = "Unlited - mNotepad";
                        titleRequire = 0;
                    }
                    if (fileName != null)
                    {
                        this.Text = "*" + fileName + " - mNotepad";
                        titleRequire = 0;
                    }
                }
            }

            if (!File.Exists(@"./bin/settings/languageSettings.txt"))
            {
                using (StreamWriter fle = new StreamWriter(@"./bin/settings/languageSettings.txt"))
                {
                    fle.Write("Varsayılan (Windows Warsayılanı)");
                }
            }

            CultureInfo currentLanguage = Thread.CurrentThread.CurrentUICulture;

            using (StreamReader fileReader = new StreamReader(@"./bin/settings/languageSettings.txt"))
            {
                language = fileReader.ReadLine();

                if (language == "Türkçe (tr_TR)")
                {
                    
                }
                if (language == "İngilizce (en_US)")
                {
                    textLineC.Text = "Text Character Size : 0 character";

                    fileToolStripMenuItem.Text = "File";
                    ayarlarToolStripMenuItem.Text = "Edit";
                    ayarlarToolStripMenuItem1.Text = "Settings";
                    hakkındaToolStripMenuItem.Text = "Help";

                    yeniToolStripMenuItem.Text = "New File";
                    dosyaAçCtrlOToolStripMenuItem.Text = "Open File";
                    kaydetCtrlSToolStripMenuItem.Text = "Save";
                    yazdırCtrlPToolStripMenuItem.Text = "Print";

                    geriAlCtrlZToolStripMenuItem.Text = "Undo";
                    ileriAlMenuItem.Text = "Redo";
                    kesCtrlXToolStripMenuItem.Text = "Cut";
                    kopyalaCtrlCToolStripMenuItem.Text = "Copy";
                    yapıştırCtrlVToolStripMenuItem.Text = "Paste";
                    silDekToolStripMenuItem.Text = "Delete";
                    hepsiniSeçCtrlAToolStripMenuItem.Text = "Search";
                    zamanTarihF5ToolStripMenuItem.Text = "Time / Date";
                }
                if (language == "Varsayılan (Windows Warsayılanı)")
                {
                    language = currentLanguage.ToString();

                    if (language == "tr-TR")
                    {
                        fileToolStripMenuItem.Text = "tr-TR";
                        language = "tr-TR";
                    }
                    if (language == "en-US")
                    {
                        language = "en-US";

                        fileToolStripMenuItem.Text = "File";
                        ayarlarToolStripMenuItem.Text = "Edit";
                        ayarlarToolStripMenuItem1.Text = "Settings";
                        hakkındaToolStripMenuItem.Text = "Help";

                        yeniToolStripMenuItem.Text = "New File";
                        dosyaAçCtrlOToolStripMenuItem.Text = "Open File";
                        kaydetCtrlSToolStripMenuItem.Text = "Save";
                        yazdırCtrlPToolStripMenuItem.Text = "Print";

                        geriAlCtrlZToolStripMenuItem.Text = "Undo";
                        ileriAlMenuItem.Text = "Redo";
                        kesCtrlXToolStripMenuItem.Text = "Cut";
                        kopyalaCtrlCToolStripMenuItem.Text = "Copy";
                        yapıştırCtrlVToolStripMenuItem.Text = "Paste";
                        silDekToolStripMenuItem.Text = "Delete";
                        hepsiniSeçCtrlAToolStripMenuItem.Text = "Search";
                        zamanTarihF5ToolStripMenuItem.Text = "Time / Date";

                        güncellemeleriKontrolEtToolStripMenuItem.Text = "Check from Updates!";
                        dilAyarlarıToolStripMenuItem.Text = "Language Settings";
                    }
                    else if (language != "tr-TR" && language != "en-US")
                    {
                        fileToolStripMenuItem.Text = ("Diğer Dil");
                    }
                }
                else if (language != "Varsayılan (Windows Warsayılanı)" && language == "Türkçe (tr_TR)" && language == "İngilizce (en_US)") {
                    MessageBox.Show("dil belli deil be aga");
                }
            }
        }

        public static int titleRequire = 0;

        private void textLayout_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textLayout.Text == "")
            {
                if (fileName == null)
                {
                    this.Text = "Unlited - mNotepad";
                    titleRequire = 0;
                }
                if (fileName != null)
                {
                    this.Text = "*" + fileName + " - mNotepad";
                    titleRequire = 0;
                }
            }

            if (titleRequire == 0)
            {
                if (textLayout.Text != "")
                {
                    if (fileName == null)
                    {
                        this.Text = "*" + "Unlited - mNotepad";
                        titleRequire = 0;
                    }
                    if (fileName != null)
                    {
                        this.Text = "*" + fileName + " - mNotepad";
                        titleRequire = 0;
                    }
                }
            }
        }

        private void textLayout_KeyDown(object sender, KeyEventArgs e)
        {
            if (textLayout.Text == "")
            {
                if (fileName == null)
                {
                    this.Text = "Unlited - mNotepad";
                    titleRequire = 0;
                }
                if (fileName != null)
                {
                    this.Text = "*" + fileName + " - mNotepad";
                    titleRequire = 0;
                }
            }

            if (titleRequire == 0)
            {
                if (textLayout.Text != "")
                {
                    if (fileName == null)
                    {
                        this.Text = "*" + "Unlited - mNotepad";
                        titleRequire = 0;
                    }
                    if (fileName != null)
                    {
                        this.Text = "*" + fileName + " - mNotepad";
                        titleRequire = 0;
                    }
                }
            }

            if (e.KeyCode == Keys.Z && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (textLayout.CanUndo == true)
                {
                    textLayout.Undo();
                }
            }
        }

        private void textLayout_KeyUp(object sender, KeyEventArgs e)
        {
            if (!File.Exists(@"./bin/settings/languageSettings.txt"))
            {
                using (StreamWriter fle = new StreamWriter(@"./bin/settings/languageSettings.txt"))
                {
                    fle.Write("Varsayılan (Windows Warsayılanı)");
                }
            }

            CultureInfo currentLanguage = Thread.CurrentThread.CurrentUICulture;

            using (StreamReader fileReader = new StreamReader(@"./bin/settings/languageSettings.txt"))
            {
                language = fileReader.ReadLine();

                if (language == "Türkçe (tr_TR)")
                {
                    language = "tr-TR";
                }
                if (language == "İngilizce (en_US)")
                {
                    language = "en-US";
                }
                if (language == "Varsayılan (Windows Warsayılanı)")
                {
                    language = currentLanguage.ToString();

                    if (language == "tr-TR")
                    {
                        language = "tr-TR";
                    }
                    if (language == "en-US")
                    {
                        language = "en-US";
                    }
                    else if (language != "tr-TR" && language != "en-US")
                    {
                        fileToolStripMenuItem.Text = ("Diğer Dil");
                    }
                }
                else if (language != "Varsayılan (Windows Warsayılanı)" && language == "Türkçe (tr_TR)" && language == "İngilizce (en_US)")
                {
                    MessageBox.Show("dil belli deil be aga");
                }
            }

            if (language.ToString() == "tr-TR")
            {
                textLineC.Text = "Yazı Karakter Sayısı : " + textLayout.Text.Length.ToString() + " karakter";
            }
            if (language.ToString() == "en-US")
            {
                textLineC.Text = "Text Character Lenght : " + textLayout.Text.Length.ToString() + " character";
            }

            if (textLayout.Text == "")
            {
                if (fileName == null)
                {
                    this.Text = "Unlited - mNotepad";
                    titleRequire = 0;
                }
                if (fileName != null)
                {
                    this.Text = "*" + fileName + " - mNotepad";
                    titleRequire = 0;
                }
            }

            if (titleRequire == 0)
            {
                if (textLayout.Text != "")
                {
                    if (fileName == null)
                    {
                        this.Text = "*" + "Unlited - mNotepad";
                        titleRequire = 0;
                    }
                    if (fileName != null)
                    {
                        this.Text = "*" + fileName + " - mNotepad";
                        titleRequire = 0;
                    }
                }
            }
        }        

        private void dilAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            languageSettings lng = new languageSettings();
            lng.Show();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        string savedFile = "default";
        string filePath;

        private void kaydetCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (!File.Exists(@"./bin/settings/languageSettings.txt"))
            {
                using (StreamWriter fle = new StreamWriter(@"./bin/settings/languageSettings.txt"))
                {
                    fle.Write("Varsayılan (Windows Warsayılanı)");
                }
            }
            using (StreamReader fileReader = new StreamReader(@"./bin/settings/languageSettings.txt"))
            {
                CultureInfo currentLanguage = Thread.CurrentThread.CurrentUICulture;

                language = fileReader.ReadLine();

                if (language == "Türkçe (tr_TR)")
                {
                    language = "tr-TR";
                }
                if (language == "İngilizce (en_US)")
                {
                    language = "en-US";
                }
                if (language == "Varsayılan (Windows Warsayılanı)")
                {
                    language = currentLanguage.ToString();

                    if (language == "tr-TR")
                    {
                        language = "tr-TR";
                    }
                    if (language == "en-US")
                    {
                        language = "en-US";
                    }
                    else if (language != "tr-TR" && language != "en-US")
                    {
                        fileToolStripMenuItem.Text = ("Diğer Dil");
                    }
                }
                else if (language != "Varsayılan (Windows Warsayılanı)" && language == "Türkçe (tr_TR)" && language == "İngilizce (en_US)")
                {
                    MessageBox.Show("dil belli deil be aga");
                }
            }
            
            if (fileSaved == true)
            {
                if (File.Exists(filePath2))
                {
                    // skip
                }
                else
                {
                    File.Delete(filePath2);
                    Console.WriteLine(filePath2);
                }

                StreamWriter SW = File.AppendText(filePath2);
                string text1 = textLayout.Text;
                SW.WriteLine(text1);
                SW.Close();
            }

            if (language == "tr-TR")
            {
                Console.WriteLine(filePath2);

                if (savedFile != "saved.file")
                {
                    sfd.Title = "Dosyayı buraya kaydet;";
                    sfd.InitialDirectory = @"C:\";
                    sfd.DefaultExt = "txt";
                    sfd.Filter = "txt files|*.txt|All files|*.*";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter SW = File.AppendText(sfd.FileName);
                        string text1 = textLayout.Text;
                        SW.WriteLine(text1);
                        SW.Close();

                        filePath = sfd.FileName;

                        FileInfo fi = new FileInfo(sfd.FileName);
                        fileName = fi.Name;

                        savedFile = "saved.file";

                        this.Text = "*" + fileName + " - mNotepad";

                    }
                }

                if (savedFile == "saved.file")
                {
                    if (File.Exists(filePath))
                    {
                        // skip
                    }
                    else
                    {
                        File.Delete(filePath);
                        Console.WriteLine(filePath);
                    }
                    File.Delete(filePath);

                    StreamWriter SW = File.AppendText(filePath);
                    string txtText = textLayout.Text;
                    SW.WriteLine(txtText);
                    SW.Close();


                    Console.Write(filePath + " dosya uzantisi budur lo");
                    Console.Write(fileName + " dosya adi budur lo");

                    this.Text = fileName + " - mNotepad";
                }
            }

            if (language == "en-US")
            {
                if (fileSaved == true)
                {
                    if (File.Exists(filePath2))
                    {
                        File.Delete(filePath2);

                        File.Delete(filePath2);
                        Console.WriteLine(filePath2);

                        StreamWriter SW = File.AppendText(filePath2);
                        string text1 = textLayout.Text;
                        SW.WriteLine(text1);
                        SW.Close();

                        savedFile = "saved.file";
                    }
                }

                if (savedFile != "saved.file")
                {
                    sfd.Title = "Save file to;";
                    sfd.InitialDirectory = @"C:\";
                    sfd.DefaultExt = "txt";
                    sfd.Filter = "txt files|*.txt|All files|*.*";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter SW = File.AppendText(sfd.FileName);
                        string text1 = textLayout.Text;
                        SW.WriteLine(text1);
                        SW.Close();

                        filePath = sfd.FileName;

                        FileInfo fi = new FileInfo(sfd.FileName);
                        fileName = fi.Name;

                        savedFile = "saved.file";

                        this.Text = "*" + fileName + " - mNotepad";

                    }
                }

                if (savedFile == "saved.file")
                {
                    if (fileSaved != true)
                    {
                        if (File.Exists(filePath))
                        {
                            // skip
                        }
                        else
                        {
                            File.Delete(filePath);
                            Console.WriteLine(filePath);

                            StreamWriter SW = File.AppendText(filePath);
                            string txtText = textLayout.Text;
                            SW.WriteLine(txtText);
                            SW.Close();


                            Console.Write(filePath + " dosya uzantisi budur lo");
                            Console.Write(fileName + " dosya adi budur lo");

                            this.Text = fileName + " - mNotepad";
                        }
                        File.Delete(filePath);
                    }
                }
            }
        }

        public static string text;
        public static string fileName;
        public string filePath2;
        public bool fileSaved;

        private void dosyaAçCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo currentLanguage = Thread.CurrentThread.CurrentUICulture;

            OpenFileDialog opf = new OpenFileDialog();

            if (currentLanguage.ToString() == "tr-TR")
            {
                opf.Title = "Lütfen Dosyayı Seçiniz!";
                opf.Filter = "All Files(*.*) | *.*";
                opf.FilterIndex = 1;
                opf.InitialDirectory = @"C:\";
            }
            if (currentLanguage.ToString() == "en-US")
            {
                opf.Title = "Please Select a File!";
                opf.Filter = "All Files (*.*) | *.*";
                opf.FilterIndex = 1;
                opf.InitialDirectory = @"C:\";
            }

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.Text = opf.SafeFileName + " - mNotepad";

                String filePath = opf.FileName;
                textLayout.Text = File.ReadAllText(filePath);

                fileName = opf.SafeFileName;

                if (!File.Exists(@"./bin/settings/languageSettings.txt"))
                {
                    using (StreamWriter fle = new StreamWriter(@"./bin/settings/languageSettings.txt"))
                    {
                        fle.Write("Varsayılan (Windows Warsayılanı)");
                    }
                }

                using (StreamReader fileReader = new StreamReader(@"./bin/settings/languageSettings.txt"))
                {

                    language = fileReader.ReadLine();

                    if (language == "Türkçe (tr_TR)")
                    {
                        language = "tr-TR";
                    }
                    if (language == "İngilizce (en_US)")
                    {
                        language = "en-US";
                    }
                    if (language == "Varsayılan (Windows Warsayılanı)")
                    {
                        language = currentLanguage.ToString();

                        if (language == "tr-TR")
                        {
                            language = "tr-TR";
                        }
                        if (language == "en-US")
                        {
                            language = "en-US";
                        }
                        else if (language != "tr-TR" && language != "en-US")
                        {
                            fileToolStripMenuItem.Text = ("Diğer Dil");
                        }
                    }
                    else if (language != "Varsayılan (Windows Warsayılanı)" && language == "Türkçe (tr_TR)" && language == "İngilizce (en_US)")
                    {
                        MessageBox.Show("dil belli deil be aga");
                    }
                }

                if (language.ToString() == "tr-TR")
                {
                    textLineC.Text = "Yazı Karakter Sayısı : " + textLayout.Text.Length.ToString() + " karakter";
                }
                if (language.ToString() == "en-US")
                {
                    textLineC.Text = "Text Character Lenght : " + textLayout.Text.Length.ToString() + " character";
                }

                if (textLayout.Text == "")
                {
                    if (fileName == null)
                    {
                        this.Text = "Unlited - mNotepad";
                        titleRequire = 0;
                    }
                    if (fileName != null)
                    {
                        this.Text = "*" + fileName + " - mNotepad";
                        titleRequire = 0;
                    }
                }

                if (titleRequire == 0)
                {
                    if (textLayout.Text != "")
                    {
                        if (fileName == null)
                        {
                            this.Text = "*" + "Unlited - mNotepad";
                            titleRequire = 0;
                        }
                        if (fileName != null)
                        {
                            this.Text = "*" + fileName + " - mNotepad";
                            titleRequire = 0;
                        }
                    }
                }

                filePath2 = opf.FileName;
                fileSaved = false;
                fileSaved = true;
                Console.WriteLine(opf.FileName);
            }
        }

        public void UpdateView()
        {
            geriAlCtrlZToolStripMenuItem.Enabled = operationEdit.CanUndo() ? true : false;
            ileriAlMenuItem.Enabled = operationEdit.CanRedo() ? true : false;
        }

        private void geriAlCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textLayout.Text = operationEdit.UndoClicked();
            UpdateView();
        }

        private void textLayout_TextChanged(object sender, EventArgs e)
        {
            if (operationEdit.TxtAreaTextChangeRequired)
            {
                timer.Start();
            }
            else
            {
                operationEdit.TxtAreaTextChangeRequired = false;
            }
            UpdateView();
        }

        private void ileriAlMenuItem_Click(object sender, EventArgs e)
        {
            textLayout.Text = operationEdit.RedoClicked();
            UpdateView();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                savedFile = "saved.file";

                DialogResult dialogResult = MessageBox.Show("Dosyanızı kaydetmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    if (language == "en-US")
                    {
                        filePath = filePath2;

                        if (savedFile == "saved.file")
                        {
                            if (File.Exists(filePath))
                            {
                                // skip
                            }
                            else
                            {
                                File.Delete(filePath);
                                Console.WriteLine(filePath);
                            }
                            File.Delete(filePath);

                            StreamWriter SW = File.AppendText(filePath);
                            string txtText = textLayout.Text;
                            SW.WriteLine(txtText);
                            SW.Close();

                            Console.Write(filePath + " dosya uzantisi budur lo");
                            Console.Write(fileName + " dosya adi budur lo");

                            this.Text = "Untitled- mNotepad";

                            fileName = null;
                            savedFile = null;
                            filePath = null;

                            textLayout.Text = "";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

                this.Text = "Untitled - mNotepad";
            }
        }
    }
}
