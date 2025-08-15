namespace dll_injector
{
    public partial class Form1 : Form
    {

        private readonly ProcessManager processManager = new();

        public Form1()
        {
            this.InitializeComponent();
            this.LoadProcesses();
            this.UpdateProcessList();
        }

        private void OnFilterTextChange(object sender, EventArgs e)
        {
            this.UpdateProcessList(p => p.Name.Contains(this.filterTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }
        
        private void OnRefreshButtonClick(object sender, EventArgs e)
        {
            this.LoadProcesses();
            this.UpdateProcessList(p => p.Name.Contains(this.filterTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void LoadProcesses()
        {
            this.refreshButton.Enabled = false;
            this.processManager.LoadProcesses();
            this.refreshButton.Enabled = true;
        }

        private void UpdateProcessList(Predicate<ProcItem>? filter = null)
        {
            this.processListView.Items.Clear();
            this.processListView.SmallImageList = new();
            var list = this.processManager.GetProcItems();
            var index = 0;
            foreach (var p in list)
            {
                if (filter != null && !filter(p))
                {
                    continue;
                }
                ListViewItem item = new(p.Name, index)
                {
                    Tag = p
                };
                item.SubItems.Add(p.ProcessId.ToString());
                item.SubItems.Add(p.ExecutablePath);
                item.SubItems.Add(p.CommandLine);
                this.processListView.Items.Add(item);
                var icon = p.Icon ?? Properties.Resources.TrollSageIcon;
                this.processListView.SmallImageList.Images.Add(icon);
                ++index;
            }
        }

    }
}
