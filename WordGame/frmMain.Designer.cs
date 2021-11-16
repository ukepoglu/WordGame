
namespace WordGame
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unmuteBTN = new System.Windows.Forms.Button();
            this.muteBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.okBTN = new System.Windows.Forms.Button();
            this.keywordTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.wordCountLBL = new System.Windows.Forms.Label();
            this.unsuccessScore = new System.Windows.Forms.Label();
            this.successScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseADictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nounsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sentencesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adverbsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adjectivesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dictLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unmuteBTN);
            this.panel1.Controls.Add(this.muteBTN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.okBTN);
            this.panel1.Controls.Add(this.keywordTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 100);
            this.panel1.TabIndex = 0;
            // 
            // unmuteBTN
            // 
            this.unmuteBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unmuteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unmuteBTN.Location = new System.Drawing.Point(576, 64);
            this.unmuteBTN.Name = "unmuteBTN";
            this.unmuteBTN.Size = new System.Drawing.Size(60, 24);
            this.unmuteBTN.TabIndex = 7;
            this.unmuteBTN.Text = "Unmute";
            this.unmuteBTN.UseVisualStyleBackColor = true;
            this.unmuteBTN.Click += new System.EventHandler(this.unmuteBTN_Click);
            // 
            // muteBTN
            // 
            this.muteBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.muteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muteBTN.Location = new System.Drawing.Point(513, 64);
            this.muteBTN.Name = "muteBTN";
            this.muteBTN.Size = new System.Drawing.Size(58, 24);
            this.muteBTN.TabIndex = 6;
            this.muteBTN.Text = "Mute";
            this.muteBTN.UseVisualStyleBackColor = true;
            this.muteBTN.Click += new System.EventHandler(this.muteBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type the meaning of the falling word and press ENTER";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pauseBtn.Location = new System.Drawing.Point(704, 64);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(58, 24);
            this.pauseBtn.TabIndex = 4;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBtn.Location = new System.Drawing.Point(768, 64);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(58, 24);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBtn.Location = new System.Drawing.Point(640, 64);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(58, 24);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // okBTN
            // 
            this.okBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okBTN.Location = new System.Drawing.Point(832, 34);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 24);
            this.okBTN.TabIndex = 1;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // keywordTB
            // 
            this.keywordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.keywordTB.Location = new System.Drawing.Point(27, 34);
            this.keywordTB.Name = "keywordTB";
            this.keywordTB.Size = new System.Drawing.Size(799, 24);
            this.keywordTB.TabIndex = 0;
            this.keywordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keywordTB_KeyDown);
            this.keywordTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keywordTB_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Crimson;
            this.headerPanel.Controls.Add(this.dictLBL);
            this.headerPanel.Controls.Add(this.wordCountLBL);
            this.headerPanel.Controls.Add(this.unsuccessScore);
            this.headerPanel.Controls.Add(this.successScore);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.menuStrip1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(951, 105);
            this.headerPanel.TabIndex = 1;
            // 
            // wordCountLBL
            // 
            this.wordCountLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordCountLBL.AutoSize = true;
            this.wordCountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordCountLBL.Location = new System.Drawing.Point(824, 73);
            this.wordCountLBL.Name = "wordCountLBL";
            this.wordCountLBL.Size = new System.Drawing.Size(115, 18);
            this.wordCountLBL.TabIndex = 4;
            this.wordCountLBL.Text = "[wordCountLBL]";
            // 
            // unsuccessScore
            // 
            this.unsuccessScore.AutoSize = true;
            this.unsuccessScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unsuccessScore.Location = new System.Drawing.Point(141, 73);
            this.unsuccessScore.Name = "unsuccessScore";
            this.unsuccessScore.Size = new System.Drawing.Size(16, 18);
            this.unsuccessScore.TabIndex = 3;
            this.unsuccessScore.Text = "0";
            // 
            // successScore
            // 
            this.successScore.AutoSize = true;
            this.successScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.successScore.Location = new System.Drawing.Point(141, 43);
            this.successScore.Name = "successScore";
            this.successScore.Size = new System.Drawing.Size(16, 18);
            this.successScore.TabIndex = 2;
            this.successScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unsuccess:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Success:";
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.Black;
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPanel.Location = new System.Drawing.Point(0, 105);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(951, 513);
            this.boardPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseADictionaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseADictionaryToolStripMenuItem
            // 
            this.chooseADictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nounsMenu,
            this.sentencesMenu,
            this.adverbsMenu,
            this.adjectivesMenu});
            this.chooseADictionaryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.chooseADictionaryToolStripMenuItem.Name = "chooseADictionaryToolStripMenuItem";
            this.chooseADictionaryToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.chooseADictionaryToolStripMenuItem.Text = "Change the Dictionary";
            this.chooseADictionaryToolStripMenuItem.Click += new System.EventHandler(this.chooseADictionaryToolStripMenuItem_Click);
            // 
            // nounsMenu
            // 
            this.nounsMenu.Name = "nounsMenu";
            this.nounsMenu.Size = new System.Drawing.Size(180, 22);
            this.nounsMenu.Text = "Nouns";
            this.nounsMenu.Click += new System.EventHandler(this.nounsMenu_Click);
            // 
            // sentencesMenu
            // 
            this.sentencesMenu.Name = "sentencesMenu";
            this.sentencesMenu.Size = new System.Drawing.Size(180, 22);
            this.sentencesMenu.Text = "Sentences";
            this.sentencesMenu.Click += new System.EventHandler(this.sentencesMenu_Click);
            // 
            // adverbsMenu
            // 
            this.adverbsMenu.Name = "adverbsMenu";
            this.adverbsMenu.Size = new System.Drawing.Size(180, 22);
            this.adverbsMenu.Text = "Adverbs";
            this.adverbsMenu.Click += new System.EventHandler(this.adverbsMenu_Click);
            // 
            // adjectivesMenu
            // 
            this.adjectivesMenu.Name = "adjectivesMenu";
            this.adjectivesMenu.Size = new System.Drawing.Size(180, 22);
            this.adjectivesMenu.Text = "Adjectives";
            this.adjectivesMenu.Click += new System.EventHandler(this.adjectivesMenu_Click);
            // 
            // dictLBL
            // 
            this.dictLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dictLBL.AutoSize = true;
            this.dictLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dictLBL.Location = new System.Drawing.Point(824, 43);
            this.dictLBL.Name = "dictLBL";
            this.dictLBL.Size = new System.Drawing.Size(65, 18);
            this.dictLBL.TabIndex = 6;
            this.dictLBL.Text = "[dictLBL]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 718);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.TextBox keywordTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label unsuccessScore;
        private System.Windows.Forms.Label successScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label wordCountLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unmuteBTN;
        private System.Windows.Forms.Button muteBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseADictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nounsMenu;
        private System.Windows.Forms.ToolStripMenuItem sentencesMenu;
        private System.Windows.Forms.ToolStripMenuItem adverbsMenu;
        private System.Windows.Forms.ToolStripMenuItem adjectivesMenu;
        private System.Windows.Forms.Label dictLBL;
    }
}

