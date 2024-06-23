using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.App.Forms;
public partial class FLaporan : Form, ILaporanForm
{
    public FLaporan()
    {
        InitializeComponent();
    }

    public void ShowForm() => (new FLaporan()).Show();

    private void FLaporan_Load(object sender, EventArgs e)
    {

    }
}
