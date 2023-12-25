using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement.Helpers
{
    public partial class MessageBoxForm : DevExpress.XtraEditors.XtraForm
    {
        public MessageBoxForm(int type, string header, string message)
        {
            //Type: 0=Info, 1=Warning, 2=Error
            InitializeComponent();
            lbl_header.Text = header;
            lbl_message.Text = message;
            if (type == 0)
            {
                svg_info.Visible = true;
                svg_warning.Visible = false;
                svg_error.Visible = false;
            }
            else if (type == 1)
            {
                svg_info.Visible = false;
                svg_warning.Visible = true;
                svg_error.Visible = false;
            }
            else if (type == 2)
            {
                svg_info.Visible = false;
                svg_warning.Visible = false;
                svg_error.Visible = true;
            }

            Activated += MeseczBox_Activated;
        }

        private async void MeseczBox_Activated(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(2000));
            this.Close();
        }
    }
}