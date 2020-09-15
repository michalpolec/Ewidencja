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
            var maszynisci = new EwidencjaMaszynistow();
            maszynisci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kierownicy = new EwidencjaKierownikow();
            kierownicy.ShowDialog();

        }
    }
}
