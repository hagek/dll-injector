namespace dll_injector
{
    public partial class Form1 : Form
    {

        private readonly ProcessManager processManager = new();
        private readonly DllListManager dllListManager = new();

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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.LoadProcesses();
            this.UpdateProcessList(p => p.Name.Contains(this.filterTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void ReferButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new()
            {
                Filter = "DLL Files (*.dll)|*.dll|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in fileDialog.FileNames)
                {
                    this.dllListManager.AddDll(file);
                }
                this.UpdateDllList();
            }
        }

        private void DllListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = this.dllListBox.IndexFromPoint(e.Location);
                if (item != ListBox.NoMatches)
                {
                    if (!this.dllListBox.SelectedIndices.Contains(item))
                    {
                        this.dllListBox.ClearSelected();
                        this.dllListBox.SelectedIndex = item;
                    }
                    this.dllContextMenu.Show(this.dllListBox, e.Location);
                }
            }
        }

        private void DeleteDllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in this.dllListBox.SelectedItems.Cast<string>().ToList())
            {
                this.dllListManager.RemoveDll(selectedItem);
            }
            this.UpdateDllList();
        }

        private void UpdateDllList()
        {
            this.dllListBox.Items.Clear();
            foreach (var dll in this.dllListManager.GetDlls())
            {
                this.dllListBox.Items.Add(dll);
            }
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
