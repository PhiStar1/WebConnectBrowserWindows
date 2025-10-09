

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetachedTabWindow
    Inherits System.Windows.Forms.Form
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
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetachedTabWindow))
        tooltip1 = New MenuStrip()
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
        TextBox1 = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CloseTabContextMenuToolStripMenuItem = New ToolStripMenuItem()
        NewTabContextMenuToolStripMenuItem = New ToolStripMenuItem()
        MoveTabToContextMenuToolStripMenuItem = New ToolStripMenuItem()
        LeftContextMenuToolStripMenuItem = New ToolStripMenuItem()
        RightContextMenuToolStripMenuItem1 = New ToolStripMenuItem()
        Search = New Button()
        Refresh = New Button()
        TabControl1 = New TabControl()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Timeraltd = New Timer(components)
        Home = New Button()
        Cantgoback = New Timer(components)
        MagicAILink = New Button()
        QuickInfo = New ToolTip(components)
        BackButton = New PictureBox()
        ForwardButton = New PictureBox()
        AddTabButton = New PictureBox()
        SearchButton = New PictureBox()
        ShortcutsButton = New PictureBox()
        MagicAILinkButton = New PictureBox()
        HomeButton = New PictureBox()
        tooltip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        CType(BackButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(ForwardButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(AddTabButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(SearchButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(ShortcutsButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(MagicAILinkButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(HomeButton, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tooltip1
        ' 
        tooltip1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        tooltip1.Dock = DockStyle.None
        tooltip1.GripStyle = ToolStripGripStyle.Visible
        tooltip1.ImageScalingSize = New Size(32, 32)
        tooltip1.Items.AddRange(New ToolStripItem() {WebConnectToolStripMenuItem, NavigationToolStripMenuItem})
        tooltip1.Location = New Point(4, 0)
        tooltip1.Name = "tooltip1"
        tooltip1.Padding = New Padding(5, 2, 0, 2)
        tooltip1.RenderMode = ToolStripRenderMode.Professional
        tooltip1.Size = New Size(1032, 32)
        tooltip1.TabIndex = 0
        tooltip1.Text = "MenuStrip1"
        ' 
        ' WebConnectToolStripMenuItem
        ' 
        WebConnectToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WebConnectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, RebootToolStripMenuItem, AppInfoToolStripMenuItem, SettingsToolStripMenuItem})
        WebConnectToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        WebConnectToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WebConnectToolStripMenuItem.Name = "WebConnectToolStripMenuItem"
        WebConnectToolStripMenuItem.Size = New Size(427, 28)
        WebConnectToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ExitToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        ExitToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(757, 34)
        ExitToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.ExitToolStripMenuItem"
        ' 
        ' RebootToolStripMenuItem
        ' 
        RebootToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RebootToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        RebootToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        RebootToolStripMenuItem.Size = New Size(757, 34)
        RebootToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.RebootToolStripMenuItem"
        ' 
        ' AppInfoToolStripMenuItem
        ' 
        AppInfoToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AppInfoToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        AppInfoToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem"
        AppInfoToolStripMenuItem.Size = New Size(757, 34)
        AppInfoToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.AppInfoToolStripMenuItem"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SettingsToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        SettingsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(757, 34)
        SettingsToolStripMenuItem.Text = "WebConnect.WebConnectToolStripMenuItem.SettingsToolStripMenuItem"
        ' 
        ' NavigationToolStripMenuItem
        ' 
        NavigationToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NavigationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ForwardToolStripMenuItem, BackToolStripMenuItem, ReloadToolStripMenuItem, HomepageToolStripMenuItem, ToolStripSeparator1, NewTabToolStripMenuItem, CloseTabToolStripMenuItem, MoveTabToToolStripMenuItem})
        NavigationToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
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
        ' TextBox1
        ' 
        TextBox1.AllowDrop = True
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold)
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.ImeMode = ImeMode.On
        TextBox1.Location = New Point(68, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "WebConnect.TextBox1.PlaceholderText"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1342, 30)
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
        ' Search
        ' 
        Search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Search.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Search.Cursor = Cursors.Hand
        Search.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold)
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
        Refresh.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold)
        Refresh.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Refresh.Location = New Point(1417, 36)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(25, 34)
        Refresh.TabIndex = 6
        Refresh.Text = "🔁"
        Refresh.UseVisualStyleBackColor = False
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
        ' BackButton
        ' 
        BackButton.Image = CType(resources.GetObject("BackButton.Image"), Image)
        BackButton.Location = New Point(4, 33)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(26, 39)
        BackButton.TabIndex = 11
        BackButton.TabStop = False
        ' 
        ' ForwardButton
        ' 
        ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), Image)
        ForwardButton.Location = New Point(33, 33)
        ForwardButton.Name = "ForwardButton"
        ForwardButton.Size = New Size(29, 39)
        ForwardButton.TabIndex = 12
        ForwardButton.TabStop = False
        ' 
        ' AddTabButton
        ' 
        AddTabButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddTabButton.Image = CType(resources.GetObject("AddTabButton.Image"), Image)
        AddTabButton.Location = New Point(1416, 35)
        AddTabButton.Name = "AddTabButton"
        AddTabButton.Size = New Size(27, 33)
        AddTabButton.TabIndex = 13
        AddTabButton.TabStop = False
        ' 
        ' SearchButton
        ' 
        SearchButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), Image)
        SearchButton.Location = New Point(1449, 36)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(41, 37)
        SearchButton.TabIndex = 14
        SearchButton.TabStop = False
        ' 
        ' ShortcutsButton
        ' 
        ShortcutsButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ShortcutsButton.Image = CType(resources.GetObject("ShortcutsButton.Image"), Image)
        ShortcutsButton.Location = New Point(1496, 35)
        ShortcutsButton.Name = "ShortcutsButton"
        ShortcutsButton.Size = New Size(41, 36)
        ShortcutsButton.TabIndex = 15
        ShortcutsButton.TabStop = False
        ' 
        ' MagicAILinkButton
        ' 
        MagicAILinkButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MagicAILinkButton.Image = CType(resources.GetObject("MagicAILinkButton.Image"), Image)
        MagicAILinkButton.Location = New Point(1543, 35)
        MagicAILinkButton.Name = "MagicAILinkButton"
        MagicAILinkButton.Size = New Size(38, 36)
        MagicAILinkButton.TabIndex = 16
        MagicAILinkButton.TabStop = False
        ' 
        ' HomeButton
        ' 
        HomeButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.Location = New Point(1587, 36)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(44, 37)
        HomeButton.TabIndex = 17
        HomeButton.TabStop = False
        ' 
        ' DetachedTabWindow
        ' 
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1631, 839)
        Controls.Add(HomeButton)
        Controls.Add(MagicAILinkButton)
        Controls.Add(ShortcutsButton)
        Controls.Add(SearchButton)
        Controls.Add(AddTabButton)
        Controls.Add(ForwardButton)
        Controls.Add(BackButton)
        Controls.Add(tooltip1)
        Controls.Add(TabControl1)
        Controls.Add(TextBox1)
        Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        KeyPreview = True
        MainMenuStrip = tooltip1
        Name = "DetachedTabWindow"
        Text = "WebConnect.DetachedTab"
        tooltip1.ResumeLayout(False)
        tooltip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        CType(BackButton, ComponentModel.ISupportInitialize).EndInit()
        CType(ForwardButton, ComponentModel.ISupportInitialize).EndInit()
        CType(AddTabButton, ComponentModel.ISupportInitialize).EndInit()
        CType(SearchButton, ComponentModel.ISupportInitialize).EndInit()
        CType(ShortcutsButton, ComponentModel.ISupportInitialize).EndInit()
        CType(MagicAILinkButton, ComponentModel.ISupportInitialize).EndInit()
        CType(HomeButton, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private components As System.ComponentModel.IContainer
    Friend WithEvents tooltip1 As MenuStrip
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
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
    Friend WithEvents BackButton As PictureBox
    Friend WithEvents ForwardButton As PictureBox
    Friend WithEvents AddTabButton As PictureBox
    Friend WithEvents SearchButton As PictureBox
    Friend WithEvents ShortcutsButton As PictureBox
    Friend WithEvents MagicAILinkButton As PictureBox
    Friend WithEvents HomeButton As PictureBox
End Class
