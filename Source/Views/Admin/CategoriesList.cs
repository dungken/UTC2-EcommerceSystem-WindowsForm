using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views.Admin
{
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
            CustomizeDataGridView();
        }
        private void CustomizeDataGridView()
        {
            gridView.BorderStyle = BorderStyle.None;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.GridColor = Color.Silver;
            gridView.Columns[0].Width = 150;
            gridView.Columns[1].Width = 300;
            gridView.Columns[2].Width = 200;
            gridView.Columns[3].Width = 150;
            gridView.Columns[4].Width = 150;
        }
    }
}
