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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        WebConnectToolStripMenuItem = New ToolStripMenuItem()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        NeustartenToolStripMenuItem = New ToolStripMenuItem()
        AppInfoToolStripMenuItem = New ToolStripMenuItem()
        NavigatiToolStripMenuItem = New ToolStripMenuItem()
        VorToolStripMenuItem = New ToolStripMenuItem()
        ZurückToolStripMenuItem = New ToolStripMenuItem()
        AktualisierenToolStripMenuItem = New ToolStripMenuItem()
        StartseiteToolStripMenuItem = New ToolStripMenuItem()
        Forward = New Button()
        Back = New Button()
        ToolTip1 = New ToolTip(components)
        Refresh = New Button()
        Cancel = New Button()
        Home = New Button()
        Search = New Button()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        TextBox1 = New TextBox()
        MenuStrip1.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {WebConnectToolStripMenuItem, NavigatiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(2237, 40)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' WebConnectToolStripMenuItem
        ' 
        WebConnectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BeendenToolStripMenuItem, NeustartenToolStripMenuItem, AppInfoToolStripMenuItem})
        WebConnectToolStripMenuItem.Name = "WebConnectToolStripMenuItem"
        WebConnectToolStripMenuItem.Size = New Size(171, 36)
        WebConnectToolStripMenuItem.Text = "WebConnect"
        WebConnectToolStripMenuItem.ToolTipText = "App beenden, neustarten oder Infos einsehen"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        BeendenToolStripMenuItem.Size = New Size(359, 44)
        BeendenToolStripMenuItem.Text = "Beenden"
        ' 
        ' NeustartenToolStripMenuItem
        ' 
        NeustartenToolStripMenuItem.Name = "NeustartenToolStripMenuItem"
        NeustartenToolStripMenuItem.Size = New Size(359, 44)
        NeustartenToolStripMenuItem.Text = "Neustarten"
        ' 
        ' AppInfoToolStripMenuItem
        ' 
        AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem"
        AppInfoToolStripMenuItem.Size = New Size(359, 44)
        AppInfoToolStripMenuItem.Text = "App-Info"
        ' 
        ' NavigatiToolStripMenuItem
        ' 
        NavigatiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VorToolStripMenuItem, ZurückToolStripMenuItem, AktualisierenToolStripMenuItem, StartseiteToolStripMenuItem})
        NavigatiToolStripMenuItem.Name = "NavigatiToolStripMenuItem"
        NavigatiToolStripMenuItem.Size = New Size(150, 36)
        NavigatiToolStripMenuItem.Text = "Navigation"
        ' 
        ' VorToolStripMenuItem
        ' 
        VorToolStripMenuItem.Name = "VorToolStripMenuItem"
        VorToolStripMenuItem.Size = New Size(284, 44)
        VorToolStripMenuItem.Text = "Vor"
        ' 
        ' ZurückToolStripMenuItem
        ' 
        ZurückToolStripMenuItem.Name = "ZurückToolStripMenuItem"
        ZurückToolStripMenuItem.Size = New Size(284, 44)
        ZurückToolStripMenuItem.Text = "Zurück"
        ' 
        ' AktualisierenToolStripMenuItem
        ' 
        AktualisierenToolStripMenuItem.Name = "AktualisierenToolStripMenuItem"
        AktualisierenToolStripMenuItem.Size = New Size(284, 44)
        AktualisierenToolStripMenuItem.Text = "Aktualisieren"
        ' 
        ' StartseiteToolStripMenuItem
        ' 
        StartseiteToolStripMenuItem.Name = "StartseiteToolStripMenuItem"
        StartseiteToolStripMenuItem.Size = New Size(284, 44)
        StartseiteToolStripMenuItem.Text = "Startseite"
        ' 
        ' Forward
        ' 
        Forward.Location = New Point(52, 43)
        Forward.Name = "Forward"
        Forward.Size = New Size(34, 46)
        Forward.TabIndex = 1
        Forward.Text = ">"
        ToolTip1.SetToolTip(Forward, "Navigiert auf der Internetseite vor" & vbCrLf & "bzw. navigiert zur nächsten geöffneten Internetseite" & vbCrLf)
        Forward.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.Location = New Point(12, 43)
        Back.Name = "Back"
        Back.Size = New Size(34, 46)
        Back.TabIndex = 2
        Back.Text = "<"
        ToolTip1.SetToolTip(Back, "Navigiert auf der Internetseite zurück" & vbCrLf & "bzw. navigiert zur vorherigen Internetseite")
        Back.UseVisualStyleBackColor = True
        ' 
        ' Refresh
        ' 
        Refresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Refresh.Location = New Point(2070, 43)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(34, 46)
        Refresh.TabIndex = 5
        Refresh.Text = "🔁"
        ToolTip1.SetToolTip(Refresh, "Lädt eine Internetseite neu")
        Refresh.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Cancel.Location = New Point(2110, 43)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(34, 46)
        Cancel.TabIndex = 6
        Cancel.Text = "X"
        ToolTip1.SetToolTip(Cancel, "Bricht das Laden einer Internetseite ab")
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        Home.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Home.Location = New Point(2150, 43)
        Home.Name = "Home"
        Home.Size = New Size(75, 46)
        Home.TabIndex = 7
        Home.Text = "🏠"
        ToolTip1.SetToolTip(Home, "Navigiert zu Startseite")
        Home.UseVisualStyleBackColor = True
        ' 
        ' Search
        ' 
        Search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Search.Location = New Point(2030, 47)
        Search.Name = "Search"
        Search.Size = New Size(34, 46)
        Search.TabIndex = 8
        Search.Text = "🔎"
        ToolTip1.SetToolTip(Search, "Sucht nach der URL, was in die Textbox eingegeben worden ist")
        Search.UseVisualStyleBackColor = True
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(12, 95)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(2213, 1111)
        WebView21.Source = New Uri("https://www.google.de", UriKind.Absolute)
        WebView21.TabIndex = 3
        WebView21.ZoomFactor = 1R
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(92, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1916, 39)
        TextBox1.TabIndex = 4
        TextBox1.Text = "Hier URL eingeben"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2237, 1218)
        Controls.Add(Search)
        Controls.Add(Home)
        Controls.Add(Cancel)
        Controls.Add(Refresh)
        Controls.Add(TextBox1)
        Controls.Add(WebView21)
        Controls.Add(Back)
        Controls.Add(Forward)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WebConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeustartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZurückToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AktualisierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartseiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Forward As Button
    Friend WithEvents Back As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Home As Button
    Friend WithEvents Search As Button
End Class
