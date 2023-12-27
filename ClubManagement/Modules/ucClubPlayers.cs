using ClubManagement.Helpers;
using ClubManagement.SubForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClubManagement.MainForm;

namespace ClubManagement.Modules
{
    public partial class ucClubPlayers : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        public ucClubPlayers()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            var playersDataTable = DBHelper.SQL_dt("select * from dbo.vPlayers");
            gridControl1.DataSource = playersDataTable;
        }

        private void btn_addPlayer_Click(object sender, EventArgs e)
        {
            var addEditForm = new PlayerAddEdit();
            DialogResult dialogResult = addEditForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedRowId = gridView1.GetFocusedRowCellValue("Id");
            var addEditForm = new PlayerAddEdit(Convert.ToInt32(selectedRowId));
            DialogResult dialogResult = addEditForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RefreshData();
            }

        }
    }
}
