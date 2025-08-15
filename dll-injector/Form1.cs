namespace DllInjector
{
    public partial class Form1 : Form
    {

        private readonly ProcessManager processManager = new();
        private readonly DllListManager dllListManager = new();

        public Form1()
        {
            InitializeComponent();
            LoadProcesses();
            UpdateProcessList();
        }

        private void OnFilterTextChange(object sender, EventArgs e)
        {
            UpdateProcessList(p => p.Name.Contains(filterTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadProcesses();
            UpdateProcessList(p => p.Name.Contains(filterTextBox.Text, StringComparison.OrdinalIgnoreCase));
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
                    dllListManager.AddDll(file);
                }
                UpdateDllList();
            }
        }

        private void DllListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = dllListBox.IndexFromPoint(e.Location);
                if (item != ListBox.NoMatches)
                {
                    if (!dllListBox.SelectedIndices.Contains(item))
                    {
                        dllListBox.ClearSelected();
                        dllListBox.SelectedIndex = item;
                    }
                    dllContextMenu.Show(dllListBox, e.Location);
                }
            }
        }

        private void DeleteDllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in dllListBox.SelectedItems.Cast<string>().ToList())
            {
                dllListManager.RemoveDll(selectedItem);
            }
            UpdateDllList();
        }

        private void UpdateDllList()
        {
            dllListBox.Items.Clear();
            foreach (var dll in dllListManager.GetDlls())
            {
                dllListBox.Items.Add(dll);
            }
        }

        private void LoadProcesses()
        {
            refreshButton.Enabled = false;
            processManager.LoadProcesses();
            refreshButton.Enabled = true;
        }

        private void UpdateProcessList(Predicate<ProcItem>? filter = null)
        {
            processListView.Items.Clear();
            processListView.SmallImageList = new();
            var list = processManager.GetProcItems();
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
                processListView.Items.Add(item);
                var icon = p.Icon ?? Properties.Resources.TrollSageIcon;
                processListView.SmallImageList.Images.Add(icon);
                ++index;
            }
        }
    }
}
