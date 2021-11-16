using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public class Target
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public Label LabelObject { get; set; } 
        public bool isDead { get; set; }

        public Target(string _word, string _meaning)
        {
            this.Word = _word;
            this.Meaning = _meaning;
            this.LabelObject = new Label();
            this.isDead = true;
        }

        public void KillMe()
        {
            this.isDead = true;
            this.LabelObject.Visible = false;
        }

    }
}
