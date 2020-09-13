using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ewidencja
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EwidencjaMaszynistow maszynisci = new EwidencjaMaszynistow();
            maszynisci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EwidencjaKierownikow kierownicy = new EwidencjaKierownikow();
            kierownicy.Show();
        }
    }
}
