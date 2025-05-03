using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rice_store.forms
{
    public partial class MainForm : Form
    {

        ProductManagementForm? dashboardForm;
        SaleOrderManagementForm? contractManagementForm;
        PaymentManagementForm? paymentManagementForm;
        SendNotificationForm? sendNotificationForm;
        CustomerManagementForm? customerManagementForm;
        UserManagementForm? userManagementForm;
        ReportForm? reportForm;
        InventoryListForm? inventoryListForm;
        public MainForm()
        {
            InitializeComponent();
            mdiProp();
        }

        bool isSidebarExpanded = true;
        private void mdiProp()
        {
            this.SetBevel(false);
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                mdiClient.BackColor = Color.FromArgb(234, 234, 237);
            }
        }
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 65)
                {
                    isSidebarExpanded = false;
                    sidebarTransition.Stop();
                    dashboardButtonPanel.Width = sidebar.Width;
                    contractManagementPanel.Width = sidebar.Width;
                    paymentManagementPanel.Width = sidebar.Width;
                    shortTermRentalManagementPanel.Width = sidebar.Width;
                    utilityBillManagementPanel.Width = sidebar.Width;
                    sendNotificationPanel.Width = sidebar.Width;
                    systemSettingPanel.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 250)
                {
                    isSidebarExpanded = true;
                    sidebarTransition.Stop();
                    dashboardButtonPanel.Width = 250;
                    contractManagementPanel.Width = 250;
                    paymentManagementPanel.Width = 250;
                    shortTermRentalManagementPanel.Width = 250;
                    utilityBillManagementPanel.Width = 250;
                    sendNotificationPanel.Width = 250;
                    systemSettingPanel.Width = 250;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void handleDashboardButtonClick(object sender, EventArgs e)
        {
            if (dashboardForm == null)
            {
                dashboardForm = new ProductManagementForm();
                dashboardForm.FormClosed += onDashboardFormClosed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm.Activate();
            }
        }

        private void onDashboardFormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboardForm = null!;
        }

        private void hamburgerButton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void contractManagementButton_Click(object sender, EventArgs e)
        {
            sendNotificationForm = null;
            sendNotificationForm = new SendNotificationForm();
            sendNotificationForm.FormClosed += onContractManagementFormClosed;
            sendNotificationForm.MdiParent = this;
            sendNotificationForm.Dock = DockStyle.Fill;
            sendNotificationForm.Show();
        }

        private void onContractManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            contractManagementForm = null!;
        }

        private void paymentManagementButton_Click(object sender, EventArgs e)
        {
            if (customerManagementForm == null)
            {
                customerManagementForm = new CustomerManagementForm();
                customerManagementForm.FormClosed += onPaymentManagementFormClosed;
                customerManagementForm.MdiParent = this;
                customerManagementForm.Dock = DockStyle.Fill;
                customerManagementForm.Show();
            }
            else
            {
                customerManagementForm.Activate();
            }
        }

        private void onPaymentManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            customerManagementForm = null!;
        }

        private void utilityBillManagementButton_Click(object sender, EventArgs e)
        {
            if (inventoryListForm == null)
            {
                inventoryListForm = new InventoryListForm();
                inventoryListForm.FormClosed += onUtilityBillManagementFormClosed;
                inventoryListForm.MdiParent = this;
                inventoryListForm.Dock = DockStyle.Fill;
                inventoryListForm.Show();
            }
            else
            {
                inventoryListForm.Activate();
            }
        }

        private void onUtilityBillManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            inventoryListForm = null!;
        }

        private void sendNotificationButton_Click(object sender, EventArgs e)
        {
            if (sendNotificationForm == null)
            {
                sendNotificationForm = new SendNotificationForm();
                sendNotificationForm.FormClosed += onSendNotificationFormClosed;
                sendNotificationForm.MdiParent = this;
                sendNotificationForm.Dock = DockStyle.Fill;
                sendNotificationForm.Show();
            }
            else
            {
                sendNotificationForm.Activate();
            }
        }

        private void onSendNotificationFormClosed(object? sender, FormClosedEventArgs e)
        {
            sendNotificationForm = null!;
        }

        private void systemSettingButton_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new ReportForm();
                reportForm.FormClosed += onSystemSettingFormClosed;
                reportForm.MdiParent = this;
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }

        private void onSystemSettingFormClosed(object? sender, FormClosedEventArgs e)
        {
            reportForm = null!;
        }

        private void sendNotificationButton_Click_1(object sender, EventArgs e)
        {
            paymentManagementForm = new PaymentManagementForm();
            paymentManagementForm.FormClosed += onPaymentManagementFormClosed;
            paymentManagementForm.MdiParent = this;
            paymentManagementForm.Dock = DockStyle.Fill;
            paymentManagementForm.Show();
        }

        private void shortTermRentalManagementButton_Click(object sender, EventArgs e)
        {
            if (userManagementForm == null)
            {
                userManagementForm = new UserManagementForm();
                userManagementForm.FormClosed += onShortTermRentalManagementFormClosed;
                userManagementForm.MdiParent = this;
                userManagementForm.Dock = DockStyle.Fill;
                userManagementForm.Show();
            }
            else
            {
                userManagementForm.Activate();
            }
        }

        private void onShortTermRentalManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            userManagementForm = null!;
        }
    }
}
