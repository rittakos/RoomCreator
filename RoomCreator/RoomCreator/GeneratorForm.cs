using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCreator
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        public GeneratorForm(ref Generator generator)
        {
            InitializeComponent();
        }
    }
}
