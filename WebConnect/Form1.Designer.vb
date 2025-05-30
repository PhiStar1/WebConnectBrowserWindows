<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Toolbar = New MenuStrip()
        WebConnectToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        RebootToolStripMenuItem = New ToolStripMenuItem()
        AppInfoToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        NavigationToolStripMenuItem = New ToolStripMenuItem()
        ForwardToolStripMenuItem = New ToolStripMenuItem()
        BackToolStripMenuItem = New ToolStripMenuItem()
        ReloadToolStripMenuItem = New ToolStripMenuItem()
        HomepageToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        NewTabToolStripMenuItem = New ToolStripMenuItem()
        CloseTabToolStripMenuItem = New ToolStripMenuItem()
        MoveTabToToolStripMenuItem = New ToolStripMenuItem()
        LeftToolStripMenuItem = New ToolStripMenuItem()
        RightToolStripMenuItem = New ToolStripMenuItem()
        Back = New Button()
        Forward = New Button()
        TextBox1 = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CloseTabContextMenuToolStripMenuItem = New ToolStripMenuItem()
        NewTabContextMenuToolStripMenuItem = New ToolStripMenuItem()
        MoveTabToContextMenuToolStripMenuItem = New ToolStripMenuItem()
        LeftContextMenuToolStripMenuItem = New ToolStripMenuItem()
        RightContextMenuToolStripMenuItem1 = New ToolStripMenuItem()
        AddTab = New Button()
        Search = New Button()
        Refresh = New Button()
        Cancel = New Button()
        Shortcuts = New Button()
        TabControl1 = New TabControl()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Timeraltd = New Timer(components)
        Home = New Button()
        Cantgoback = New Timer(components)
        MagicAILink = New Button()
        QuickInfo = New ToolTip(components)
        Toolbar.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Toolbar
        ' 
        Toolbar.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Toolbar.Dock = DockStyle.None
        Toolbar.GripStyle = ToolStripGripStyle.Visible
        Toolbar.ImageScalingSize = New Size(32, 32)
        Toolbar.Items.AddRange(New ToolStripItem() {WebConnectToolStripMenuItem, NavigationToolStripMenuItem})
        Toolbar.Location = New Point(4, 0)
        Toolbar.Name = "Toolbar"
        Toolbar.Padding = New Padding(5, 2, 0, 2)
        Toolbar.RenderMode = ToolStripRenderMode.Professional
        Toolbar.Size = New Size(1032, 32)
        Toolbar.TabIndex = 0
        Toolbar.Text = "MenuStrip1"
        ' 
        ' WebConnectToolStripMenuItem
        ' 
        WebConnectToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WebConnectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, RebootToolStripMenuItem, AppInfoToolStripMenuItem, SettingsToolStripMenuItem})
        WebConnectToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        WebConnectToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WebConnectToolStripMenuItem.Name = "WebConnectToolStripMenuItem"
        WebConnectToolStripMenuItem.Size = New Size(427, 28)
        WebConnectToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ExitToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        ExitToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(757, 34)
        ExitToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.ExitToolStripMenuItem"
        ' 
        ' RebootToolStripMenuItem
        ' 
        RebootToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RebootToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        RebootToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        RebootToolStripMenuItem.Size = New Size(757, 34)
        RebootToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.RebootToolStripMenuItem"
        ' 
        ' AppInfoToolStripMenuItem
        ' 
        AppInfoToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AppInfoToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        AppInfoToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem"
        AppInfoToolStripMenuItem.Size = New Size(757, 34)
        AppInfoToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.AppInfoToolStripMenuItem"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SettingsToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        SettingsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(757, 34)
        SettingsToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.SettingsToolStripMenuItem"
        ' 
        ' NavigationToolStripMenuItem
        ' 
        NavigationToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NavigationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ForwardToolStripMenuItem, BackToolStripMenuItem, ReloadToolStripMenuItem, HomepageToolStripMenuItem, ToolStripSeparator1, NewTabToolStripMenuItem, CloseTabToolStripMenuItem, MoveTabToToolStripMenuItem})
        NavigationToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        NavigationToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        NavigationToolStripMenuItem.Size = New Size(408, 28)
        NavigationToolStripMenuItem.Text = "WebConnect.NavigationToolStripMenuItem"
        ' 
        ' ForwardToolStripMenuItem
        ' 
        ForwardToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ForwardToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        ForwardToolStripMenuItem.Size = New Size(503, 34)
        ForwardToolStripMenuItem.Text = "WebConnect.ForwardToolStripMenuItem"
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(503, 34)
        BackToolStripMenuItem.Text = "WebConnect.BackToolStripMenuItem"
        ' 
        ' ReloadToolStripMenuItem
        ' 
        ReloadToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ReloadToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        ReloadToolStripMenuItem.Size = New Size(503, 34)
        ReloadToolStripMenuItem.Text = "WebConnect.ReloadToolStripMenuItem"
        ' 
        ' HomepageToolStripMenuItem
        ' 
        HomepageToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        HomepageToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomepageToolStripMenuItem.Name = "HomepageToolStripMenuItem"
        HomepageToolStripMenuItem.Size = New Size(503, 34)
        HomepageToolStripMenuItem.Text = "WebConnect.HomepageToolStripMenuItem"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.BackColor = SystemColors.ActiveCaptionText
        ToolStripSeparator1.ForeColor = SystemColors.ActiveCaptionText
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(500, 6)
        ' 
        ' NewTabToolStripMenuItem
        ' 
        NewTabToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewTabToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        NewTabToolStripMenuItem.Size = New Size(503, 34)
        NewTabToolStripMenuItem.Text = "WebConnect.NewTabToolStripMenuItem"
        ' 
        ' CloseTabToolStripMenuItem
        ' 
        CloseTabToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloseTabToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        CloseTabToolStripMenuItem.Size = New Size(503, 34)
        CloseTabToolStripMenuItem.Text = "WebConnect.CloseTabToolStripMenuItem"
        ' 
        ' MoveTabToToolStripMenuItem
        ' 
        MoveTabToToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MoveTabToToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeftToolStripMenuItem, RightToolStripMenuItem})
        MoveTabToToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MoveTabToToolStripMenuItem.Name = "MoveTabToToolStripMenuItem"
        MoveTabToToolStripMenuItem.Size = New Size(503, 34)
        MoveTabToToolStripMenuItem.Text = "WebConnect.MoveTabToToolStripMenuItem"
        ' 
        ' LeftToolStripMenuItem
        ' 
        LeftToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LeftToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        LeftToolStripMenuItem.Size = New Size(723, 34)
        LeftToolStripMenuItem.Text = "WebConnect.MoveTabToToolStripMenuItem.LeftToolStripMenuItem"
        ' 
        ' RightToolStripMenuItem
        ' 
        RightToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RightToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        RightToolStripMenuItem.Size = New Size(723, 34)
        RightToolStripMenuItem.Text = "WebConnect.MoveTabToToolStripMenuItem.RightToolStripMenuItem"
        ' 
        ' Back
        ' 
        Back.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Back.Cursor = Cursors.Hand
        Back.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Back.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Back.Location = New Point(4, 36)
        Back.Name = "Back"
        Back.Size = New Size(26, 34)
        Back.TabIndex = 1
        Back.Text = "<"
        Back.UseVisualStyleBackColor = False
        ' 
        ' Forward
        ' 
        Forward.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Forward.Cursor = Cursors.Hand
        Forward.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Forward.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Forward.Location = New Point(36, 36)
        Forward.Name = "Forward"
        Forward.Size = New Size(26, 34)
        Forward.TabIndex = 2
        Forward.Text = ">"
        Forward.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.AllowDrop = True
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.ImeMode = ImeMode.On
        TextBox1.Location = New Point(68, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "WebConnect.TextBox1.PlaceholderText"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1278, 30)
        TextBox1.TabIndex = 3
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {CloseTabContextMenuToolStripMenuItem, NewTabContextMenuToolStripMenuItem, MoveTabToContextMenuToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(264, 100)
        ContextMenuStrip1.Text = "Tab schließen"
        ' 
        ' CloseTabContextMenuToolStripMenuItem
        ' 
        CloseTabContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloseTabContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloseTabContextMenuToolStripMenuItem.Name = "CloseTabContextMenuToolStripMenuItem"
        CloseTabContextMenuToolStripMenuItem.Size = New Size(263, 32)
        CloseTabContextMenuToolStripMenuItem.Text = "Tab schließen"
        ' 
        ' NewTabContextMenuToolStripMenuItem
        ' 
        NewTabContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewTabContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NewTabContextMenuToolStripMenuItem.Name = "NewTabContextMenuToolStripMenuItem"
        NewTabContextMenuToolStripMenuItem.Size = New Size(263, 32)
        NewTabContextMenuToolStripMenuItem.Text = "Neuer Tab"
        ' 
        ' MoveTabToContextMenuToolStripMenuItem
        ' 
        MoveTabToContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MoveTabToContextMenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeftContextMenuToolStripMenuItem, RightContextMenuToolStripMenuItem1})
        MoveTabToContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MoveTabToContextMenuToolStripMenuItem.Name = "MoveTabToContextMenuToolStripMenuItem"
        MoveTabToContextMenuToolStripMenuItem.Size = New Size(263, 32)
        MoveTabToContextMenuToolStripMenuItem.Text = "Tab verschieben nach..."
        ' 
        ' LeftContextMenuToolStripMenuItem
        ' 
        LeftContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LeftContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LeftContextMenuToolStripMenuItem.Name = "LeftContextMenuToolStripMenuItem"
        LeftContextMenuToolStripMenuItem.Size = New Size(173, 34)
        LeftContextMenuToolStripMenuItem.Text = "...links"
        ' 
        ' RightContextMenuToolStripMenuItem1
        ' 
        RightContextMenuToolStripMenuItem1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RightContextMenuToolStripMenuItem1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RightContextMenuToolStripMenuItem1.Name = "RightContextMenuToolStripMenuItem1"
        RightContextMenuToolStripMenuItem1.Size = New Size(173, 34)
        RightContextMenuToolStripMenuItem1.Text = "...rechts"
        ' 
        ' AddTab
        ' 
        AddTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddTab.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AddTab.Cursor = Cursors.Hand
        AddTab.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        AddTab.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AddTab.Location = New Point(1352, 36)
        AddTab.Name = "AddTab"
        AddTab.Size = New Size(24, 34)
        AddTab.TabIndex = 4
        AddTab.Text = "+"
        AddTab.UseVisualStyleBackColor = False
        ' 
        ' Search
        ' 
        Search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Search.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Search.Cursor = Cursors.Hand
        Search.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Search.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Search.Location = New Point(1382, 36)
        Search.Name = "Search"
        Search.Size = New Size(26, 34)
        Search.TabIndex = 5
        Search.Text = "🔎"
        Search.UseVisualStyleBackColor = False
        ' 
        ' Refresh
        ' 
        Refresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Refresh.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Refresh.Cursor = Cursors.Hand
        Refresh.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Refresh.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Refresh.Location = New Point(1417, 36)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(25, 34)
        Refresh.TabIndex = 6
        Refresh.Text = "🔁"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.Cursor = Cursors.Hand
        Cancel.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(1448, 36)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(26, 36)
        Cancel.TabIndex = 7
        Cancel.Text = "X"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Shortcuts
        ' 
        Shortcuts.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Shortcuts.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Shortcuts.Cursor = Cursors.Hand
        Shortcuts.Font = New Font("Microsoft Sans Serif", 5F, FontStyle.Bold)
        Shortcuts.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Shortcuts.Location = New Point(1480, 36)
        Shortcuts.Name = "Shortcuts"
        Shortcuts.Size = New Size(47, 36)
        Shortcuts.TabIndex = 9
        Shortcuts.Text = "-->"
        Shortcuts.UseCompatibleTextRendering = True
        Shortcuts.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.AllowDrop = True
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.ContextMenuStrip = ContextMenuStrip1
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Location = New Point(0, 78)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1631, 760)
        TabControl1.TabIndex = 10
        ' 
        ' Home
        ' 
        Home.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Home.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Home.Cursor = Cursors.Hand
        Home.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Home.Location = New Point(1576, 36)
        Home.Name = "Home"
        Home.Size = New Size(43, 36)
        Home.TabIndex = 11
        Home.Text = "🏠"
        Home.UseVisualStyleBackColor = False
        ' 
        ' Cantgoback
        ' 
        Cantgoback.Interval = 5000
        ' 
        ' MagicAILink
        ' 
        MagicAILink.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MagicAILink.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MagicAILink.Cursor = Cursors.Hand
        MagicAILink.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MagicAILink.Location = New Point(1533, 36)
        MagicAILink.Name = "MagicAILink"
        MagicAILink.Size = New Size(37, 36)
        MagicAILink.TabIndex = 12
        MagicAILink.Text = ChrW(55358) & ChrW(56964)
        MagicAILink.UseVisualStyleBackColor = False
        ' 
        ' QuickInfo
        ' 
        QuickInfo.IsBalloon = True
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1631, 839)
        Controls.Add(Toolbar)
        Controls.Add(TabControl1)
        Controls.Add(AddTab)
        Controls.Add(Search)
        Controls.Add(MagicAILink)
        Controls.Add(Home)
        Controls.Add(TextBox1)
        Controls.Add(Forward)
        Controls.Add(Cancel)
        Controls.Add(Refresh)
        Controls.Add(Back)
        Controls.Add(Shortcuts)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = Toolbar
        Name = "Form1"
        Text = "WebConnect.MainWindow"
        Toolbar.ResumeLayout(False)
        Toolbar.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Toolbar As MenuStrip
    Friend WithEvents WebConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomepageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Back As Button
    Friend WithEvents Forward As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AddTab As Button
    Friend WithEvents Search As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Shortcuts As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timeraltd As Timer
    Friend WithEvents Home As Button
    Friend WithEvents AppInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CloseTabContextMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cantgoback As Timer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MagicAILink As Button
    Friend WithEvents MoveTabToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTabContextMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveTabToContextMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftContextMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightContextMenuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuickInfo As ToolTip

End Class
