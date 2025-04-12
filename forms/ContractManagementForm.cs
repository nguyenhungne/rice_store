using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using rice_store.services;
using System.Diagnostics;
using rice_store.models;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class ContractManagementForm : Form
    {
        public ContractManagementForm()
        {
            InitializeComponent();
        }

        private void InitializeDataGridView()
        {
        }

        private async void ContractManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }



    }
}
