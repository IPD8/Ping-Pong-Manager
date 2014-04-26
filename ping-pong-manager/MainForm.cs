using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ping_pong_control
{
    public partial class MainForm : Form
    {
        const int TABLE_NUMBER = 11;

        private List<Table> tables;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.tables = new List<Table>(TABLE_NUMBER);

            for (int i = 0; i < TABLE_NUMBER; i++) {
                Table table = new Table((i+1).ToString());
                this.tables.Add(table);

                table.start(new TimeSpan(0, 0, (i + 1) * 5));
            }

            this.create_tables_view_structure();
            this.refresh_tables_view();
        }

        private void create_tables_view_structure() {
            this.TablesView.Columns.Clear();
            
            this.TablesView.Columns.Add("name", "Name", 100);
            this.TablesView.Columns.Add("status", "Status", 100);
            this.TablesView.Columns.Add("start_time", "Start time", 100);
            this.TablesView.Columns.Add("duration", "Duration", 100);
            this.TablesView.Columns.Add("left", "Left", 100);

            this.TablesView.Items.Clear();

            foreach (Table table in this.tables) {
                ListViewItem item = new ListViewItem();
                item.Tag = table;

                for (int i = 0; i < this.TablesView.Columns.Count; i++) {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                }

                this.TablesView.Items.Add(item);
            }
        }

        private void refresh_tables_view() {
            foreach (ListViewItem item in this.TablesView.Items) {
                Table table = (Table)item.Tag;

                switch (table.check_status()) {
                    case Table.Status.Busy:
                        item.BackColor = Color.FromArgb(255, 255, 200);
                        item.ForeColor = Color.FromArgb(64, 64, 0);
                        break;
                    case Table.Status.Free:
                        item.BackColor = Color.FromArgb(200, 255, 200);
                        item.ForeColor = Color.FromArgb(0, 64, 0);
                        break;
                    case Table.Status.TimesUp:
                        item.BackColor = Color.FromArgb(255, 150, 150);
                        item.ForeColor = Color.FromArgb(64, 0, 0);
                        break;
                }

                item.ImageKey = "table";
                item.SubItems[0].Text = table.name;
                item.SubItems[1].Text = table.status.ToString();
                item.SubItems[2].Text = table.start_time.ToString("hh\\:mm\\:ss");
                item.SubItems[3].Text = table.duration.ToString("hh\\:mm\\:ss");
                item.SubItems[4].Text = table.time_left.ToString("hh\\:mm\\:ss");
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e) {
            this.refresh_tables_view();
        }
    }
}
