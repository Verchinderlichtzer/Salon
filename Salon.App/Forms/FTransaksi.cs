﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.App.Forms;
public partial class FTransaksi : Form, ITransaksiForm
{
    public FTransaksi()
    {
        InitializeComponent();
    }

    public void ShowForm() => (new FTransaksi()).Show();

    private void FTransaksi_Load(object sender, EventArgs e)
    {

    }
}