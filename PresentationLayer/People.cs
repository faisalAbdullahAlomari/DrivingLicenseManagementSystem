using BusinessLayer;
using System.Data;

namespace PresentationLayer
{
    public partial class People : Form
    {
        DataTable _dt = new DataTable();
        public People()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void People_Load(object sender, EventArgs e)
        {
            _LoadPeopleData();
            LoadFilterByComboBox();
        }

        private void LoadFilterByComboBox()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Insert(0, "Select Filter");
            cbFilterBy.SelectedIndex = 0;
            foreach (DataColumn col in _dt.Columns)
            {
                cbFilterBy.Items.Add(col.ColumnName);
            }
        }

        private void _FillListView(DataTable dt)
        {
            lvPeople.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvPeople.Items.Add(item);
            }
        }

        private void _LoadPeopleData()
        {

            _dt = clsPeople.GetPeopleData();

            lvPeople.Items.Clear();
            lvPeople.Columns.Clear();

            foreach (DataColumn col in _dt.Columns)
            {
                lvPeople.Columns.Add(col.ColumnName, 120);
            }

            lvPeople.View = View.Details;

            _FillListView(_dt);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem == null || cbFilterBy.SelectedIndex == 0) return;

            string column = cbFilterBy.SelectedItem.ToString()!;

            DataView dv = new DataView(_dt);

            dv.Sort = $"{column} ASC";

            _FillListView(dv.ToTable());
        }
    }
}
