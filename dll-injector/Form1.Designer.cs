namespace dll_injector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rootPanel = new TableLayoutPanel();
            leftPanel = new TableLayoutPanel();
            processListView = new ListView();
            processName = new ColumnHeader();
            processId = new ColumnHeader();
            executablePath = new ColumnHeader();
            commandLine = new ColumnHeader();
            topLeftPanel = new TableLayoutPanel();
            refreshButton = new Button();
            filterTextBox = new TextBox();
            rightPanel = new TableLayoutPanel();
            referButton = new Button();
            dllListBox = new ListBox();
            injectButton = new Button();
            dllContextMenu = new ContextMenuStrip(components);
            deleteDllMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            rootPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            dllContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // rootPanel
            // 
            rootPanel.ColumnCount = 2;
            rootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.375F));
            rootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.625F));
            rootPanel.Controls.Add(leftPanel, 0, 0);
            rootPanel.Controls.Add(rightPanel, 1, 0);
            rootPanel.Dock = DockStyle.Fill;
            rootPanel.Location = new Point(0, 0);
            rootPanel.Name = "rootPanel";
            rootPanel.RowCount = 1;
            rootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rootPanel.Size = new Size(800, 450);
            rootPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            leftPanel.Controls.Add(processListView, 0, 1);
            leftPanel.Controls.Add(topLeftPanel, 0, 0);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(0);
            leftPanel.Name = "leftPanel";
            leftPanel.RowCount = 2;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.98198175F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 93.01802F));
            leftPanel.Size = new Size(611, 450);
            leftPanel.TabIndex = 0;
            // 
            // processListView
            // 
            processListView.BackgroundImageTiled = true;
            processListView.Columns.AddRange(new ColumnHeader[] { processName, processId, executablePath, commandLine });
            processListView.Dock = DockStyle.Fill;
            processListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            processListView.Location = new Point(3, 34);
            processListView.Name = "processListView";
            processListView.ShowItemToolTips = true;
            processListView.Size = new Size(605, 413);
            processListView.TabIndex = 10;
            processListView.UseCompatibleStateImageBehavior = false;
            processListView.View = View.Details;
            // 
            // processName
            // 
            processName.Text = "Process Name";
            processName.Width = 120;
            // 
            // processId
            // 
            processId.Text = "PID";
            // 
            // executablePath
            // 
            executablePath.Text = "Exe Path";
            executablePath.Width = 120;
            // 
            // commandLine
            // 
            commandLine.Text = "Command Line";
            commandLine.Width = 271;
            // 
            // topLeftPanel
            // 
            topLeftPanel.ColumnCount = 2;
            topLeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7355375F));
            topLeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.2644653F));
            topLeftPanel.Controls.Add(refreshButton, 0, 0);
            topLeftPanel.Controls.Add(filterTextBox, 1, 0);
            topLeftPanel.Dock = DockStyle.Fill;
            topLeftPanel.Location = new Point(0, 0);
            topLeftPanel.Margin = new Padding(0);
            topLeftPanel.Name = "topLeftPanel";
            topLeftPanel.RowCount = 1;
            topLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            topLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            topLeftPanel.Size = new Size(611, 31);
            topLeftPanel.TabIndex = 11;
            // 
            // refreshButton
            // 
            refreshButton.Dock = DockStyle.Fill;
            refreshButton.Location = new Point(3, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(65, 25);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "更新";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // filterTextBox
            // 
            filterTextBox.Dock = DockStyle.Fill;
            filterTextBox.Location = new Point(74, 3);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "プロセスを絞り込む";
            filterTextBox.Size = new Size(534, 23);
            filterTextBox.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightPanel.Controls.Add(referButton, 0, 1);
            rightPanel.Controls.Add(dllListBox, 0, 0);
            rightPanel.Controls.Add(injectButton, 0, 3);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(611, 0);
            rightPanel.Margin = new Padding(0);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 4;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 91.62011F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.379889F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            rightPanel.Size = new Size(189, 450);
            rightPanel.TabIndex = 1;
            // 
            // referButton
            // 
            referButton.Dock = DockStyle.Top;
            referButton.Location = new Point(3, 331);
            referButton.Name = "referButton";
            referButton.Size = new Size(183, 22);
            referButton.TabIndex = 0;
            referButton.Text = "参照";
            referButton.UseVisualStyleBackColor = true;
            referButton.Click += ReferButton_Click;
            // 
            // dllListBox
            // 
            dllListBox.Dock = DockStyle.Fill;
            dllListBox.FormattingEnabled = true;
            dllListBox.ItemHeight = 15;
            dllListBox.Location = new Point(3, 3);
            dllListBox.Name = "dllListBox";
            dllListBox.SelectionMode = SelectionMode.MultiExtended;
            dllListBox.Size = new Size(183, 322);
            dllListBox.TabIndex = 0;
            dllListBox.MouseDown += DllListBox_MouseDown;
            // 
            // injectButton
            // 
            injectButton.Dock = DockStyle.Fill;
            injectButton.Location = new Point(3, 390);
            injectButton.Name = "injectButton";
            injectButton.Size = new Size(183, 57);
            injectButton.TabIndex = 1;
            injectButton.Text = "Inject";
            injectButton.UseVisualStyleBackColor = true;
            // 
            // dllContextMenu
            // 
            dllContextMenu.Items.AddRange(new ToolStripItem[] { deleteDllMenuItem, 設定ToolStripMenuItem });
            dllContextMenu.Name = "contextMenuStrip1";
            dllContextMenu.Size = new Size(99, 48);
            // 
            // deleteDllMenuItem
            // 
            deleteDllMenuItem.Name = "deleteDllMenuItem";
            deleteDllMenuItem.Size = new Size(98, 22);
            deleteDllMenuItem.Text = "削除";
            deleteDllMenuItem.Click += DeleteDllMenuItem_Click;
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(98, 22);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rootPanel);
            Name = "Form1";
            Text = "DLL Injector";
            rootPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            topLeftPanel.ResumeLayout(false);
            topLeftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            dllContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel rootPanel;
        private TableLayoutPanel leftPanel;
        private ListView processListView;
        private ColumnHeader processName;
        private ColumnHeader processId;
        private ColumnHeader executablePath;
        private ColumnHeader commandLine;
        private TableLayoutPanel topLeftPanel;
        private Button refreshButton;
        private TextBox filterTextBox;
        private TableLayoutPanel rightPanel;
        private ListBox dllListBox;
        private Button injectButton;
        private Button referButton;
        private ContextMenuStrip dllContextMenu;
        private ToolStripMenuItem deleteDllMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
    }
}
