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
public partial class FUser : Form, IUserForm
{
    public FUser()
    {
        InitializeComponent();
    }

    public void ShowForm() => (new FUser()).Show();

    private void FUser_Load(object sender, EventArgs e)
    {

    }
}
