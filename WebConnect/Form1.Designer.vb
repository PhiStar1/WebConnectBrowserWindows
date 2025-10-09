

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        TimerFullscreenToggle = New Timer(components)
        CheckForScreenChanges = New Timer(components)
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
        resources.ApplyResources(tooltip1, "tooltip1")
        tooltip1.GripStyle = ToolStripGripStyle.Visible
        tooltip1.ImageScalingSize = New Size(32, 32)
        tooltip1.Items.AddRange(New ToolStripItem() {WebConnectToolStripMenuItem, NavigationToolStripMenuItem})
        tooltip1.Name = "tooltip1"
        tooltip1.RenderMode = ToolStripRenderMode.Professional
        ' 
        ' WebConnectToolStripMenuItem
        ' 
        WebConnectToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WebConnectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, RebootToolStripMenuItem, AppInfoToolStripMenuItem, SettingsToolStripMenuItem})
        resources.ApplyResources(WebConnectToolStripMenuItem, "WebConnectToolStripMenuItem")
        WebConnectToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WebConnectToolStripMenuItem.Name = "WebConnectToolStripMenuItem"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem")
        ExitToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ' 
        ' RebootToolStripMenuItem
        ' 
        RebootToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        resources.ApplyResources(RebootToolStripMenuItem, "RebootToolStripMenuItem")
        RebootToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        ' 
        ' AppInfoToolStripMenuItem
        ' 
        AppInfoToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        resources.ApplyResources(AppInfoToolStripMenuItem, "AppInfoToolStripMenuItem")
        AppInfoToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        resources.ApplyResources(SettingsToolStripMenuItem, "SettingsToolStripMenuItem")
        SettingsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        ' 
        ' NavigationToolStripMenuItem
        ' 
        NavigationToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NavigationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ForwardToolStripMenuItem, BackToolStripMenuItem, ReloadToolStripMenuItem, HomepageToolStripMenuItem, ToolStripSeparator1, NewTabToolStripMenuItem, CloseTabToolStripMenuItem, MoveTabToToolStripMenuItem})
        resources.ApplyResources(NavigationToolStripMenuItem, "NavigationToolStripMenuItem")
        NavigationToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        ' 
        ' ForwardToolStripMenuItem
        ' 
        ForwardToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ForwardToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        resources.ApplyResources(ForwardToolStripMenuItem, "ForwardToolStripMenuItem")
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        resources.ApplyResources(BackToolStripMenuItem, "BackToolStripMenuItem")
        ' 
        ' ReloadToolStripMenuItem
        ' 
        ReloadToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ReloadToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        resources.ApplyResources(ReloadToolStripMenuItem, "ReloadToolStripMenuItem")
        ' 
        ' HomepageToolStripMenuItem
        ' 
        HomepageToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        HomepageToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomepageToolStripMenuItem.Name = "HomepageToolStripMenuItem"
        resources.ApplyResources(HomepageToolStripMenuItem, "HomepageToolStripMenuItem")
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.BackColor = SystemColors.ActiveCaptionText
        ToolStripSeparator1.ForeColor = SystemColors.ActiveCaptionText
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(ToolStripSeparator1, "ToolStripSeparator1")
        ' 
        ' NewTabToolStripMenuItem
        ' 
        NewTabToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewTabToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        resources.ApplyResources(NewTabToolStripMenuItem, "NewTabToolStripMenuItem")
        ' 
        ' CloseTabToolStripMenuItem
        ' 
        CloseTabToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloseTabToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        resources.ApplyResources(CloseTabToolStripMenuItem, "CloseTabToolStripMenuItem")
        ' 
        ' MoveTabToToolStripMenuItem
        ' 
        MoveTabToToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MoveTabToToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeftToolStripMenuItem, RightToolStripMenuItem})
        MoveTabToToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MoveTabToToolStripMenuItem.Name = "MoveTabToToolStripMenuItem"
        resources.ApplyResources(MoveTabToToolStripMenuItem, "MoveTabToToolStripMenuItem")
        ' 
        ' LeftToolStripMenuItem
        ' 
        LeftToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LeftToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        resources.ApplyResources(LeftToolStripMenuItem, "LeftToolStripMenuItem")
        ' 
        ' RightToolStripMenuItem
        ' 
        RightToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RightToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        resources.ApplyResources(RightToolStripMenuItem, "RightToolStripMenuItem")
        ' 
        ' TextBox1
        ' 
        TextBox1.AllowDrop = True
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.Name = "TextBox1"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {CloseTabContextMenuToolStripMenuItem, NewTabContextMenuToolStripMenuItem, MoveTabToContextMenuToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(ContextMenuStrip1, "ContextMenuStrip1")
        ' 
        ' CloseTabContextMenuToolStripMenuItem
        ' 
        CloseTabContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloseTabContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloseTabContextMenuToolStripMenuItem.Name = "CloseTabContextMenuToolStripMenuItem"
        resources.ApplyResources(CloseTabContextMenuToolStripMenuItem, "CloseTabContextMenuToolStripMenuItem")
        ' 
        ' NewTabContextMenuToolStripMenuItem
        ' 
        NewTabContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewTabContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NewTabContextMenuToolStripMenuItem.Name = "NewTabContextMenuToolStripMenuItem"
        resources.ApplyResources(NewTabContextMenuToolStripMenuItem, "NewTabContextMenuToolStripMenuItem")
        ' 
        ' MoveTabToContextMenuToolStripMenuItem
        ' 
        MoveTabToContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MoveTabToContextMenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeftContextMenuToolStripMenuItem, RightContextMenuToolStripMenuItem1})
        MoveTabToContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MoveTabToContextMenuToolStripMenuItem.Name = "MoveTabToContextMenuToolStripMenuItem"
        resources.ApplyResources(MoveTabToContextMenuToolStripMenuItem, "MoveTabToContextMenuToolStripMenuItem")
        ' 
        ' LeftContextMenuToolStripMenuItem
        ' 
        LeftContextMenuToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LeftContextMenuToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LeftContextMenuToolStripMenuItem.Name = "LeftContextMenuToolStripMenuItem"
        resources.ApplyResources(LeftContextMenuToolStripMenuItem, "LeftContextMenuToolStripMenuItem")
        ' 
        ' RightContextMenuToolStripMenuItem1
        ' 
        RightContextMenuToolStripMenuItem1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RightContextMenuToolStripMenuItem1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RightContextMenuToolStripMenuItem1.Name = "RightContextMenuToolStripMenuItem1"
        resources.ApplyResources(RightContextMenuToolStripMenuItem1, "RightContextMenuToolStripMenuItem1")
        ' 
        ' Search
        ' 
        resources.ApplyResources(Search, "Search")
        Search.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Search.Cursor = Cursors.Hand
        Search.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Search.Name = "Search"
        Search.UseVisualStyleBackColor = False
        ' 
        ' Refresh
        ' 
        resources.ApplyResources(Refresh, "Refresh")
        Refresh.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Refresh.Cursor = Cursors.Hand
        Refresh.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Refresh.Name = "Refresh"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.AllowDrop = True
        resources.ApplyResources(TabControl1, "TabControl1")
        TabControl1.ContextMenuStrip = ContextMenuStrip1
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        ' 
        ' Timeraltd
        ' 
        Timeraltd.Interval = 1000
        ' 
        ' Home
        ' 
        resources.ApplyResources(Home, "Home")
        Home.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Home.Cursor = Cursors.Hand
        Home.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Home.Name = "Home"
        Home.UseVisualStyleBackColor = False
        ' 
        ' Cantgoback
        ' 
        Cantgoback.Interval = 5000
        ' 
        ' MagicAILink
        ' 
        resources.ApplyResources(MagicAILink, "MagicAILink")
        MagicAILink.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MagicAILink.Cursor = Cursors.Hand
        MagicAILink.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MagicAILink.Name = "MagicAILink"
        MagicAILink.UseVisualStyleBackColor = False
        ' 
        ' QuickInfo
        ' 
        QuickInfo.IsBalloon = True
        ' 
        ' BackButton
        ' 
        resources.ApplyResources(BackButton, "BackButton")
        BackButton.Name = "BackButton"
        BackButton.TabStop = False
        ' 
        ' ForwardButton
        ' 
        resources.ApplyResources(ForwardButton, "ForwardButton")
        ForwardButton.Name = "ForwardButton"
        ForwardButton.TabStop = False
        ' 
        ' AddTabButton
        ' 
        resources.ApplyResources(AddTabButton, "AddTabButton")
        AddTabButton.Name = "AddTabButton"
        AddTabButton.TabStop = False
        ' 
        ' SearchButton
        ' 
        resources.ApplyResources(SearchButton, "SearchButton")
        SearchButton.Name = "SearchButton"
        SearchButton.TabStop = False
        ' 
        ' ShortcutsButton
        ' 
        resources.ApplyResources(ShortcutsButton, "ShortcutsButton")
        ShortcutsButton.Name = "ShortcutsButton"
        ShortcutsButton.TabStop = False
        ' 
        ' MagicAILinkButton
        ' 
        resources.ApplyResources(MagicAILinkButton, "MagicAILinkButton")
        MagicAILinkButton.Name = "MagicAILinkButton"
        MagicAILinkButton.TabStop = False
        ' 
        ' HomeButton
        ' 
        resources.ApplyResources(HomeButton, "HomeButton")
        HomeButton.Name = "HomeButton"
        HomeButton.TabStop = False
        ' 
        ' TimerFullscreenToggle
        ' 
        TimerFullscreenToggle.Interval = 1000
        ' 
        ' CheckForScreenChanges
        ' 
        ' 
        ' Form1
        ' 
        AllowDrop = True
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
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
        KeyPreview = True
        MainMenuStrip = tooltip1
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        WindowState = FormWindowState.Minimized
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
    Friend WithEvents TimerFullscreenToggle As Timer
    Friend WithEvents CheckForScreenChanges As Timer
End Class
