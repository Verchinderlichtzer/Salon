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
public partial class FProduk : Form, IProdukForm
{
    public FProduk()
    {
        InitializeComponent();
    }

    public void ShowForm() => (new FProduk()).Show();

    private void FProduk_Load(object sender, EventArgs e)
    {

    }
}
