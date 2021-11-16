using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class frmMain : Form
    {
        private List<Target> targets = new List<Target>();
        private List<Target> ActiveTargets = new List<Target>();

        private readonly Random _random = new Random();

        private int boardX = 0;
        private int boardY = 0;
        private int boardWidth = 0;
        private int boardHeight = 0;
        private int finishLine = 20;

        private int success = 0;
        private int unsuccess = 0;

        private int score = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void populateTargets(string dictName)
        {
            var fn = string.Empty;
            if (dictName == "nouns") fn = Application.StartupPath + "/Dictionaries/nouns.xls";

            var conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fn + ";Extended Properties='Excel 8.0;HDR=No;IMEX=1';"; //for above excel 2007  
            
            DataTable dtexcel = new DataTable();

            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Nouns$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }

            targets.Clear();

            foreach (DataRow dr in dtexcel.Rows)
            {
                targets.Add(new Target(dr[0].ToString(), dr[1].ToString()));
            }

            wordCountLBL.Text = targets.Count.ToString();
        }

        private void getBoardCoordinates()
        {
            boardX = boardPanel.Location.X;
            boardY = boardPanel.Location.Y;
            boardWidth = boardPanel.Width;//Screen.GetWorkingArea(this).Width;//boardPanel.Width;
            boardHeight = boardPanel.Height;//Screen.GetWorkingArea(this).Height;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion;

            getBoardCoordinates();
            populateTargets("nouns");
        }

        private void drawFinish()
        {
            using (Graphics g = boardPanel.CreateGraphics())
            {
                g.DrawLine(new Pen(Color.Yellow, 3), new Point(0, boardHeight - finishLine), new Point(boardWidth, boardHeight - finishLine));
            }
        }

        private void addNewActiveTarget()
        {
            var targetIndex = _random.Next(targets.Count);
            var t = targets[targetIndex];

            t.LabelObject.ForeColor = Color.White;
            t.LabelObject.Font = new Font("Arial", 11, FontStyle.Bold);
            t.LabelObject.Size = new Size(118,18);
            t.LabelObject.Text = t.Word;
            t.LabelObject.Location = new Point(_random.Next(boardWidth-100), 1);
            t.LabelObject.Parent = boardPanel;
            t.LabelObject.Visible = true;
            t.isDead = false;

            ActiveTargets.Add(t);
        }

        void incSuccess()
        {
            success++;
        }

        void incUnsuccess()
        {
            unsuccess++;
        }

        void writeScore()
        {
            successScore.Text = success.ToString();
            unsuccessScore.Text = unsuccess.ToString();
        }

        void makeSound()
        {
            SoundPlayer fire = new SoundPlayer(Application.StartupPath + "/sounds/fire.wav");
            fire.Play();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void TargetFalls()
        {
            var activeCount = ActiveTargets.Count(n => n.isDead == false);

            if (activeCount == 0) addNewActiveTarget();

            foreach (Target t in ActiveTargets)
            {
                if (t.isDead) continue;

                var p = t.LabelObject.Location;
                p.Y += 10;
                if (p.Y > (boardHeight - finishLine))
                {
                    t.KillMe();
                    incUnsuccess();
                    drawFinish();
                }
                else
                {
                    t.LabelObject.Location = p;
                }
            }

            Application.DoEvents();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TargetFalls();
            writeScore();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            addNewActiveTarget();
            drawFinish();
            keywordTB.Focus(); 
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keywordTB_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void wordProcess()
        {
            var keyword = keywordTB.Text.Trim();
            var targetFound = false;

            foreach (Target t in ActiveTargets)
            {
                if (t.isDead) continue;
                if (t.Meaning.Equals(keyword))
                {
                    t.KillMe();
                    makeSound();
                    keywordTB.Text = "";
                    incSuccess();
                    targetFound = true;
                }
            }

            if (targetFound) addNewActiveTarget();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            getBoardCoordinates();
        }

        private void keywordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wordProcess();

                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
