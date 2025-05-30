<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectToNAS
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Cancel = New Label()
        ManualConnection = New Label()
        Header = New Label()
        Synology = New Button()
        WesternDigital = New Button()
        Buffalo = New Button()
        QNAP = New Button()
        FRITZNAS = New Button()
        Asustor = New Button()
        SuspendLayout()
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(741, 241)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(192, 20)
        Cancel.TabIndex = 30
        Cancel.Text = "ConnectToNAS.Cancel"
        ' 
        ' ManualConnection
        ' 
        ManualConnection.AutoSize = True
        ManualConnection.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        ManualConnection.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ManualConnection.Location = New Point(12, 236)
        ManualConnection.Name = "ManualConnection"
        ManualConnection.Size = New Size(286, 20)
        ManualConnection.TabIndex = 29
        ManualConnection.Text = "ConnectToNAS.ManualConnection"
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(12, 9)
        Header.Name = "Header"
        Header.Size = New Size(460, 46)
        Header.TabIndex = 18
        Header.Text = "ConnectToNAS.Header"
        ' 
        ' Synology
        ' 
        Synology.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Synology.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Synology.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Synology.Location = New Point(12, 147)
        Synology.Name = "Synology"
        Synology.Size = New Size(222, 33)
        Synology.TabIndex = 31
        Synology.Text = "ConnectToNAS.Synology"
        Synology.UseVisualStyleBackColor = False
        ' 
        ' WesternDigital
        ' 
        WesternDigital.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WesternDigital.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        WesternDigital.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WesternDigital.Location = New Point(663, 147)
        WesternDigital.Name = "WesternDigital"
        WesternDigital.Size = New Size(270, 33)
        WesternDigital.TabIndex = 32
        WesternDigital.Text = "ConnectToNAS.WesternDigital"
        WesternDigital.UseVisualStyleBackColor = False
        ' 
        ' Buffalo
        ' 
        Buffalo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Buffalo.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Buffalo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Buffalo.Location = New Point(452, 147)
        Buffalo.Name = "Buffalo"
        Buffalo.Size = New Size(205, 33)
        Buffalo.TabIndex = 33
        Buffalo.Text = "ConnectToNAS.Buffalo"
        Buffalo.UseVisualStyleBackColor = False
        ' 
        ' QNAP
        ' 
        QNAP.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QNAP.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        QNAP.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        QNAP.Location = New Point(240, 147)
        QNAP.Name = "QNAP"
        QNAP.Size = New Size(206, 33)
        QNAP.TabIndex = 34
        QNAP.Text = "ConnectToNAS.QNAP"
        QNAP.UseVisualStyleBackColor = False
        ' 
        ' FRITZNAS
        ' 
        FRITZNAS.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FRITZNAS.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        FRITZNAS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FRITZNAS.Location = New Point(226, 186)
        FRITZNAS.Name = "FRITZNAS"
        FRITZNAS.Size = New Size(238, 33)
        FRITZNAS.TabIndex = 35
        FRITZNAS.Text = "ConnectToNAS.FRITZNAS"
        FRITZNAS.UseVisualStyleBackColor = False
        ' 
        ' Asustor
        ' 
        Asustor.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Asustor.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Asustor.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Asustor.Location = New Point(12, 186)
        Asustor.Name = "Asustor"
        Asustor.Size = New Size(208, 33)
        Asustor.TabIndex = 36
        Asustor.Text = "ConnectToNAS.Asustor"
        Asustor.UseVisualStyleBackColor = False
        ' 
        ' ConnectToNAS
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(943, 270)
        Controls.Add(Asustor)
        Controls.Add(FRITZNAS)
        Controls.Add(QNAP)
        Controls.Add(Buffalo)
        Controls.Add(WesternDigital)
        Controls.Add(Synology)
        Controls.Add(Cancel)
        Controls.Add(ManualConnection)
        Controls.Add(Header)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Name = "ConnectToNAS"
        Text = "WebConnect.ConnectToNAS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cancel As Label
    Friend WithEvents ManualConnection As Label
    Friend WithEvents Header As Label
    Friend WithEvents Synology As Button
    Friend WithEvents WesternDigital As Button
    Friend WithEvents Buffalo As Button
    Friend WithEvents QNAP As Button
    Friend WithEvents FRITZNAS As Button
    Friend WithEvents Asustor As Button
End Class
