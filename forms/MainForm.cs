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
        ContractManagementForm? contractManagementForm;
        PaymentManagementForm? paymentManagementForm;
        ShortTermRentalManagementForm? shortTermRentalManagementForm;
        SendNotificationForm? sendNotificationForm;
        UtilityBillManagementForm? utilityBillManagementForm;
        SystemSettingForm? systemSettingForm;
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
            if (contractManagementForm == null)
            {
                contractManagementForm = new ContractManagementForm();
                contractManagementForm.FormClosed += onContractManagementFormClosed;
                contractManagementForm.MdiParent = this;
                contractManagementForm.Dock = DockStyle.Fill;
                contractManagementForm.Show();
            }
            else
            {
                contractManagementForm.Activate();
            }
        }

        private void onContractManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            contractManagementForm = null!;
        }

        private void paymentManagementButton_Click(object sender, EventArgs e)
        {
            if (paymentManagementForm == null)
            {
                paymentManagementForm = new PaymentManagementForm();
                paymentManagementForm.FormClosed += onPaymentManagementFormClosed;
                paymentManagementForm.MdiParent = this;
                paymentManagementForm.Dock = DockStyle.Fill;
                paymentManagementForm.Show();
            }
            else
            {
                paymentManagementForm.Activate();
            }
        }

        private void onPaymentManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            paymentManagementForm = null!;
        }

        private void shortTermRentalManagementButton_Click(object sender, EventArgs e)
        {
            if (shortTermRentalManagementForm == null)
            {
                shortTermRentalManagementForm = new ShortTermRentalManagementForm();
                shortTermRentalManagementForm.FormClosed += onShortTermRentalManagementFormClosed;
                shortTermRentalManagementForm.MdiParent = this;
                shortTermRentalManagementForm.Dock = DockStyle.Fill;
                shortTermRentalManagementForm.Show();
            }
            else
            {
                shortTermRentalManagementForm.Activate();
            }
        }

        private void onShortTermRentalManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            shortTermRentalManagementForm = null!;
        }

        private void utilityBillManagementButton_Click(object sender, EventArgs e)
        {
            if (utilityBillManagementForm == null)
            {
                utilityBillManagementForm = new UtilityBillManagementForm();
                utilityBillManagementForm.FormClosed += onUtilityBillManagementFormClosed;
                utilityBillManagementForm.MdiParent = this;
                utilityBillManagementForm.Dock = DockStyle.Fill;
                utilityBillManagementForm.Show();
            }
            else
            {
                utilityBillManagementForm.Activate();
            }
        }

        private void onUtilityBillManagementFormClosed(object? sender, FormClosedEventArgs e)
        {
            utilityBillManagementForm = null!;
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
            if (systemSettingForm == null)
            {
                systemSettingForm = new SystemSettingForm();
                systemSettingForm.FormClosed += onSystemSettingFormClosed;
                systemSettingForm.MdiParent = this;
                systemSettingForm.Dock = DockStyle.Fill;
                systemSettingForm.Show();
            }
            else
            {
                systemSettingForm.Activate();
            }
        }

        private void onSystemSettingFormClosed(object? sender, FormClosedEventArgs e)
        {
            systemSettingForm = null!;
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
