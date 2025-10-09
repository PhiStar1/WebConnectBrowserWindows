<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullScreenModeNotificationWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Header = New Label()
        FullScreenSource = New Label()
        CloseMessage = New Button()
        AutoCloseTimerIndicator = New ProgressBar()
        AutoCloseFullscreenNotification = New Timer(components)
        CloseDelayOnIndicatorEnding = New Timer(components)
        BlendoutAnimation = New Timer(components)
        Description = New Label()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Location = New Point(12, 9)
        Header.Name = "Header"
        Header.Size = New Size(357, 25)
        Header.TabIndex = 0
        Header.Text = "FullScreenModeNotificationWindow.Header"
        ' 
        ' FullScreenSource
        ' 
        FullScreenSource.AutoSize = True
        FullScreenSource.Location = New Point(12, 43)
        FullScreenSource.Name = "FullScreenSource"
        FullScreenSource.Size = New Size(433, 25)
        FullScreenSource.TabIndex = 1
        FullScreenSource.Text = "FullScreenModeNotificationWindow.FullScreenSource"
        ' 
        ' CloseMessage
        ' 
        CloseMessage.Location = New Point(525, 139)
        CloseMessage.Name = "CloseMessage"
        CloseMessage.Size = New Size(112, 34)
        CloseMessage.TabIndex = 2
        CloseMessage.Text = "FullScreenModeNotificationWindow.CloseMessage"
        CloseMessage.UseVisualStyleBackColor = True
        ' 
        ' AutoCloseTimerIndicator
        ' 
        AutoCloseTimerIndicator.Location = New Point(526, 166)
        AutoCloseTimerIndicator.Name = "AutoCloseTimerIndicator"
        AutoCloseTimerIndicator.Size = New Size(110, 10)
        AutoCloseTimerIndicator.TabIndex = 3
        ' 
        ' AutoCloseFullscreenNotification
        ' 
        AutoCloseFullscreenNotification.Interval = 250
        ' 
        ' CloseDelayOnIndicatorEnding
        ' 
        CloseDelayOnIndicatorEnding.Interval = 1000
        ' 
        ' BlendoutAnimation
        ' 
        BlendoutAnimation.Interval = 10
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.Location = New Point(12, 78)
        Description.Name = "Description"
        Description.Size = New Size(390, 25)
        Description.TabIndex = 4
        Description.Text = "FullScreenModeNotificationWindow.Description"
        ' 
        ' FullScreenModeNotificationWindow
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 188)
        Controls.Add(CloseMessage)
        Controls.Add(Description)
        Controls.Add(AutoCloseTimerIndicator)
        Controls.Add(FullScreenSource)
        Controls.Add(Header)
        FormBorderStyle = FormBorderStyle.None
        Name = "FullScreenModeNotificationWindow"
        StartPosition = FormStartPosition.Manual
        Text = "FullScreenModeNotificationWindow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents FullScreenSource As Label
    Friend WithEvents CloseMessage As Button
    Friend WithEvents AutoCloseTimerIndicator As ProgressBar
    Friend WithEvents AutoCloseFullscreenNotification As Timer
    Friend WithEvents CloseDelayOnIndicatorEnding As Timer
    Friend WithEvents BlendoutAnimation As Timer
    Friend WithEvents Description As Label
End Class
