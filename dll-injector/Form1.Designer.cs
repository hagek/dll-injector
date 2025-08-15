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
            injectMethodListBox = new ListBox();
            injectButton = new Button();
            rightRowPanel = new TableLayoutPanel();
            referButton = new Button();
            dllPathTextBox = new TextBox();
            rootPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            rightRowPanel.SuspendLayout();
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
            refreshButton.Click += OnRefreshButtonClick;
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
            rightPanel.Controls.Add(injectMethodListBox, 0, 0);
            rightPanel.Controls.Add(injectButton, 0, 3);
            rightPanel.Controls.Add(rightRowPanel, 0, 2);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(611, 0);
            rightPanel.Margin = new Padding(0);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 4;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.2471924F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.7528076F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            rightPanel.Size = new Size(189, 450);
            rightPanel.TabIndex = 1;
            // 
            // injectMethodListBox
            // 
            injectMethodListBox.Dock = DockStyle.Fill;
            injectMethodListBox.FormattingEnabled = true;
            injectMethodListBox.ItemHeight = 15;
            injectMethodListBox.Location = new Point(3, 3);
            injectMethodListBox.Name = "injectMethodListBox";
            injectMethodListBox.Size = new Size(183, 181);
            injectMethodListBox.TabIndex = 0;
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
            // rightRowPanel
            // 
            rightRowPanel.ColumnCount = 2;
            rightRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.95767F));
            rightRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0423279F));
            rightRowPanel.Controls.Add(referButton, 1, 0);
            rightRowPanel.Controls.Add(dllPathTextBox, 0, 0);
            rightRowPanel.Dock = DockStyle.Fill;
            rightRowPanel.Location = new Point(0, 358);
            rightRowPanel.Margin = new Padding(0);
            rightRowPanel.Name = "rightRowPanel";
            rightRowPanel.RowCount = 1;
            rightRowPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightRowPanel.Size = new Size(189, 29);
            rightRowPanel.TabIndex = 2;
            // 
            // referButton
            // 
            referButton.Dock = DockStyle.Fill;
            referButton.Location = new Point(139, 3);
            referButton.Name = "referButton";
            referButton.Size = new Size(47, 23);
            referButton.TabIndex = 0;
            referButton.Text = "参照";
            referButton.UseVisualStyleBackColor = true;
            // 
            // dllPathTextBox
            // 
            dllPathTextBox.Dock = DockStyle.Fill;
            dllPathTextBox.Location = new Point(3, 3);
            dllPathTextBox.Name = "dllPathTextBox";
            dllPathTextBox.Size = new Size(130, 23);
            dllPathTextBox.TabIndex = 1;
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
            rightRowPanel.ResumeLayout(false);
            rightRowPanel.PerformLayout();
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
        private ListBox injectMethodListBox;
        private Button injectButton;
        private TableLayoutPanel rightRowPanel;
        private Button referButton;
        private TextBox dllPathTextBox;
    }
}
