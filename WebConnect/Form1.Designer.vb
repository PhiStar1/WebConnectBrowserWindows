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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Toolbar = New MenuStrip()
        WebConnectToolStripMenuItem = New ToolStripMenuItem()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        NeustartenToolStripMenuItem = New ToolStripMenuItem()
        AppInfoToolStripMenuItem = New ToolStripMenuItem()
        EinstellungenToolStripMenuItem = New ToolStripMenuItem()
        NavigatiToolStripMenuItem = New ToolStripMenuItem()
        VorToolStripMenuItem = New ToolStripMenuItem()
        ZurückToolStripMenuItem = New ToolStripMenuItem()
        AktualisierenToolStripMenuItem = New ToolStripMenuItem()
        StartseiteToolStripMenuItem = New ToolStripMenuItem()
        NeuerTabToolStripMenuItem = New ToolStripMenuItem()
        Back = New Button()
        Forward = New Button()
        TextBox1 = New TextBox()
        AddTab = New Button()
        Search = New Button()
        Refresh = New Button()
        Cancel = New Button()
        Home = New Button()
        Shortcuts = New Button()
        TabControl1 = New TabControl()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Toolbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Toolbar
        ' 
        Toolbar.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Toolbar.GripStyle = ToolStripGripStyle.Visible
        Toolbar.ImageScalingSize = New Size(32, 32)
        Toolbar.Items.AddRange(New ToolStripItem() {WebConnectToolStripMenuItem, NavigatiToolStripMenuItem})
        Toolbar.Location = New Point(0, 0)
        Toolbar.Name = "Toolbar"
        Toolbar.Padding = New Padding(5, 2, 0, 2)
        Toolbar.RenderMode = ToolStripRenderMode.Professional
        Toolbar.Size = New Size(1772, 33)
        Toolbar.TabIndex = 0
        Toolbar.Text = "MenuStrip1"
        ' 
        ' WebConnectToolStripMenuItem
        ' 
        WebConnectToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WebConnectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BeendenToolStripMenuItem, NeustartenToolStripMenuItem, AppInfoToolStripMenuItem, EinstellungenToolStripMenuItem})
        WebConnectToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        WebConnectToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WebConnectToolStripMenuItem.Name = "WebConnectToolStripMenuItem"
        WebConnectToolStripMenuItem.Size = New Size(129, 29)
        WebConnectToolStripMenuItem.Text = "WebConnect"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        BeendenToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BeendenToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BeendenToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        BeendenToolStripMenuItem.Size = New Size(235, 34)
        BeendenToolStripMenuItem.Text = "Beenden"
        ' 
        ' NeustartenToolStripMenuItem
        ' 
        NeustartenToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NeustartenToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NeustartenToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NeustartenToolStripMenuItem.Name = "NeustartenToolStripMenuItem"
        NeustartenToolStripMenuItem.Size = New Size(235, 34)
        NeustartenToolStripMenuItem.Text = "Neustarten"
        ' 
        ' AppInfoToolStripMenuItem
        ' 
        AppInfoToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AppInfoToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AppInfoToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem"
        AppInfoToolStripMenuItem.Size = New Size(235, 34)
        AppInfoToolStripMenuItem.Text = "App-Info"
        ' 
        ' EinstellungenToolStripMenuItem
        ' 
        EinstellungenToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EinstellungenToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        EinstellungenToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        EinstellungenToolStripMenuItem.Size = New Size(235, 34)
        EinstellungenToolStripMenuItem.Text = "Einstellungen"
        ' 
        ' NavigatiToolStripMenuItem
        ' 
        NavigatiToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NavigatiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VorToolStripMenuItem, ZurückToolStripMenuItem, AktualisierenToolStripMenuItem, StartseiteToolStripMenuItem, NeuerTabToolStripMenuItem})
        NavigatiToolStripMenuItem.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NavigatiToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NavigatiToolStripMenuItem.Name = "NavigatiToolStripMenuItem"
        NavigatiToolStripMenuItem.Size = New Size(115, 29)
        NavigatiToolStripMenuItem.Text = "Navigation"
        ' 
        ' VorToolStripMenuItem
        ' 
        VorToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        VorToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        VorToolStripMenuItem.Name = "VorToolStripMenuItem"
        VorToolStripMenuItem.Size = New Size(232, 34)
        VorToolStripMenuItem.Text = "Vor"
        ' 
        ' ZurückToolStripMenuItem
        ' 
        ZurückToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ZurückToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ZurückToolStripMenuItem.Name = "ZurückToolStripMenuItem"
        ZurückToolStripMenuItem.Size = New Size(232, 34)
        ZurückToolStripMenuItem.Text = "Zurück"
        ' 
        ' AktualisierenToolStripMenuItem
        ' 
        AktualisierenToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AktualisierenToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AktualisierenToolStripMenuItem.Name = "AktualisierenToolStripMenuItem"
        AktualisierenToolStripMenuItem.Size = New Size(232, 34)
        AktualisierenToolStripMenuItem.Text = "Aktualisieren"
        ' 
        ' StartseiteToolStripMenuItem
        ' 
        StartseiteToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        StartseiteToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        StartseiteToolStripMenuItem.Name = "StartseiteToolStripMenuItem"
        StartseiteToolStripMenuItem.Size = New Size(232, 34)
        StartseiteToolStripMenuItem.Text = "Startseite"
        ' 
        ' NeuerTabToolStripMenuItem
        ' 
        NeuerTabToolStripMenuItem.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NeuerTabToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NeuerTabToolStripMenuItem.Name = "NeuerTabToolStripMenuItem"
        NeuerTabToolStripMenuItem.Size = New Size(232, 34)
        NeuerTabToolStripMenuItem.Text = "Neuer Tab"
        ' 
        ' Back
        ' 
        Back.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Back.Cursor = Cursors.Hand
        Back.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        Forward.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        TextBox1.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.ImeMode = ImeMode.On
        TextBox1.Location = New Point(68, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1483, 34)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Hier URL eingeben"
        ' 
        ' AddTab
        ' 
        AddTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddTab.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AddTab.Cursor = Cursors.Hand
        AddTab.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        AddTab.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AddTab.Location = New Point(1557, 36)
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
        Search.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Search.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Search.Location = New Point(1587, 36)
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
        Refresh.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Refresh.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Refresh.Location = New Point(1619, 36)
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
        Cancel.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(1650, 36)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(26, 34)
        Cancel.TabIndex = 7
        Cancel.Text = "X"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        Home.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Home.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Home.Cursor = Cursors.Hand
        Home.Font = New Font("SamsungOneUILatin 700C", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Home.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Home.Location = New Point(1734, 36)
        Home.Name = "Home"
        Home.Size = New Size(26, 34)
        Home.TabIndex = 8
        Home.Text = "🏠"
        Home.UseVisualStyleBackColor = False
        ' 
        ' Shortcuts
        ' 
        Shortcuts.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Shortcuts.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Shortcuts.Cursor = Cursors.Hand
        Shortcuts.Font = New Font("SamsungOneUILatin 700C", 5F, FontStyle.Bold, GraphicsUnit.Point)
        Shortcuts.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Shortcuts.Location = New Point(1682, 36)
        Shortcuts.Name = "Shortcuts"
        Shortcuts.Size = New Size(47, 34)
        Shortcuts.TabIndex = 9
        Shortcuts.Text = "-->"
        Shortcuts.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Location = New Point(2, 76)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1770, 828)
        TabControl1.TabIndex = 10
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1772, 905)
        Controls.Add(Home)
        Controls.Add(TextBox1)
        Controls.Add(Forward)
        Controls.Add(AddTab)
        Controls.Add(Cancel)
        Controls.Add(TabControl1)
        Controls.Add(Search)
        Controls.Add(Toolbar)
        Controls.Add(Refresh)
        Controls.Add(Back)
        Controls.Add(Shortcuts)
        Font = New Font("SamsungOneUILatin 700C", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = Toolbar
        Name = "Form1"
        Text = "Form1"
        Toolbar.ResumeLayout(False)
        Toolbar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Toolbar As MenuStrip
    Friend WithEvents WebConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeustartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZurückToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AktualisierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartseiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuerTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Back As Button
    Friend WithEvents Forward As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AddTab As Button
    Friend WithEvents Search As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Home As Button
    Friend WithEvents Shortcuts As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
