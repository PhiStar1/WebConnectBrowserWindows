
Imports Microsoft.Win32
Imports System.Threading.Channels

Public Class WebConnectAdminSoftware
    Private Sub WebConnectDebugProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.OrganizationName = "" Then
            SetupOrganization.ShowDialog()
            Me.Close()

        End If

        If My.Settings.AdminPassword = "" Then
            SetupPassword.ShowDialog()
            Me.Close()
        Else
            EnterAdminPassword.ShowDialog()
        End If

        Dim WebConnectAdminDesignerValuesMainWindowWindowPath As String = "Software\WebConnect\Admin\Designer values\MainWindow\Window"
        Dim WebConnectAdminDesignerValuesMainWindowWindowValueName As String = "MainWindowWindowAcceptButton"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueNone As String = "(None)"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueBack As String = "Back"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueCancel As String = "Cancel"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueForward As String = "Forward"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueHome As String = "Home"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueRefresh As String = "Refresh"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueSearch As String = "Search"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueShortcuts As String = "Shortcuts"
        Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueMaigcAILink As String = "MagicAILink"
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing Then
                Select Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueNone
                        MainWindowWindowAcceptButtonNone.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueBack
                        MainWindowWindowAcceptButtonBack.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueCancel
                        MainWindowWindowAcceptButtonCancel.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueForward
                        MainWindowWindowAcceptButtonForward.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueHome
                        MainWindowWindowAcceptButtonHome.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueRefresh
                        MainWindowWindowAcceptButtonRefresh.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueSearch
                        MainWindowWindowAcceptButtonSearch.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueShortcuts
                        MainWindowWindowAcceptButtonShortcuts.Checked = True
                    Case WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueMaigcAILink
                        MainWindowWindowAcceptButtonMagicAILink.Checked = True


                End Select
            End If
        Catch ex As Exception

        End Try

        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueBack Then
                MainWindowWindowAcceptButtonBack.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueCancel Then
                MainWindowWindowAcceptButtonCancel.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueForward Then
                MainWindowWindowAcceptButtonForward.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueHome Then
                MainWindowWindowAcceptButtonHome.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueRefresh Then
                MainWindowWindowAcceptButtonRefresh.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueSearch Then
                MainWindowWindowAcceptButtonSearch.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueShortcuts Then
                MainWindowWindowAcceptButtonShortcuts.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
            If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueMaigcAILink Then
                MainWindowWindowAcceptButtonMagicAILink.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click



        Try
            'MainWindowWindowName
            Form1.Name = MainWindowWindowNameText.Text
            My.Settings.MainWindowWindowName = MainWindowWindowNameText.Text
            'MainWindowWindowAcceptButton
            If MainWindowWindowAcceptButtonNone.Checked Then
                Form1.AcceptButton = Nothing
                My.Settings.MainWindowWindowAcceptButton = "(None)"
                MDMSettingsReboot.ShowDialog()



            End If

            If MainWindowWindowAcceptButtonBack.Checked Then


                My.Settings.MainWindowWindowAcceptButton = "Back"
                MDMSettingsReboot.ShowDialog()

            End If
            If MainWindowWindowAcceptButtonCancel.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Cancel"
                MDMSettingsReboot.ShowDialog()
            End If
            If MainWindowWindowAcceptButtonForward.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Forward"
                MDMSettingsReboot.ShowDialog()
            End If
            If MainWindowWindowAcceptButtonHome.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Home"
                MDMSettingsReboot.ShowDialog()
            End If
            If MainWindowWindowAcceptButtonRefresh.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Refresh"
                MDMSettingsReboot.ShowDialog()
            End If
            If MainWindowWindowAcceptButtonSearch.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Search"
                MDMSettingsReboot.ShowDialog()
            End If
            If MainWindowWindowAcceptButtonShortcuts.Checked Then

                My.Settings.MainWindowWindowAcceptButton = "Shortcuts"
                MDMSettingsReboot.ShowDialog()
            End If
            'MainWindowWindowAccessibleDescription
            Form1.AccessibleDescription = MainWindowWindowAccessibleDescriptionText.Text
            My.Settings.MainWindowWindowAccessibleDescription = MainWindowWindowAccessibleDescriptionText.Text
            'MainWindowWindowAccessibleName
            Form1.AccessibleName = MainWindowWindowAccessibleNameText.Text
            My.Settings.MainWindowWindowAccessibleName = MainWindowWindowAccessibleNameText.Text
            'MainWindowWindowAccessibleRole
            If MainWindowWindowAccessibleRoleDefault.Checked Then
                Form1.AccessibleRole = AccessibleRole.Default
                My.Settings.MainWindowWindowAccessibleRole = "Default"
            End If
            If MainWindowWindowAccessibleRoleNone.Checked Then
                Form1.AccessibleRole = AccessibleRole.None
                My.Settings.MainWindowWindowAccessibleRole = "None"
            End If
            If MainWindowWindowAccessibleRoleTitleBar.Checked Then
                Form1.AccessibleRole = AccessibleRole.TitleBar
                My.Settings.MainWindowWindowAccessibleRole = "TitleBar"
            End If
            If MainWindowWindowAccessibleRoleMenuBar.Checked Then
                Form1.AccessibleRole = AccessibleRole.MenuBar
                My.Settings.MainWindowWindowAccessibleRole = "MenuBar"
            End If
            If MainWindowWindowAccessibleRoleScrollBar.Checked Then
                Form1.AccessibleRole = AccessibleRole.ScrollBar
                My.Settings.MainWindowWindowAccessibleRole = "ScrollBar"
            End If
            If MainWindowWindowAccessibleRoleGrip.Checked Then
                Form1.AccessibleRole = AccessibleRole.Grip
                My.Settings.MainWindowWindowAccessibleRole = "Grip"
            End If
            If MainWindowWindowAccessibleRoleSound.Checked Then
                Form1.AccessibleRole = AccessibleRole.Sound
                My.Settings.MainWindowWindowAccessibleRole = "Sound"
            End If
            If MainWindowWindowAccessibleRoleCursor.Checked Then
                Form1.AccessibleRole = AccessibleRole.Cursor
                My.Settings.MainWindowWindowAccessibleRole = "Cursor"
            End If
            If MainWindowWindowAccessibleRoleCaret.Checked Then
                Form1.AccessibleRole = AccessibleRole.Caret
                My.Settings.MainWindowWindowAccessibleRole = "Caret"
            End If
            If MainWindowWindowAccessibleRoleAlert.Checked Then
                Form1.AccessibleRole = AccessibleRole.Alert
                My.Settings.MainWindowWindowAccessibleRole = "Alert"
            End If
            If MainWindowWindowAccessibleRoleWindow.Checked Then
                Form1.AccessibleRole = AccessibleRole.Window
                My.Settings.MainWindowWindowAccessibleRole = "Window"
            End If
            If MainWindowWindowAccessibleRoleClient.Checked Then
                Form1.AccessibleRole = AccessibleRole.Client
                My.Settings.MainWindowWindowAccessibleRole = "Client"
            End If
            If MainWindowWindowAccessibleRoleMenuPopup.Checked Then
                Form1.AccessibleRole = AccessibleRole.MenuPopup
                My.Settings.MainWindowWindowAccessibleRole = "MenuPopup"
            End If
            If MainWindowWindowAccessibleRoleMenuItem.Checked Then
                Form1.AccessibleRole = AccessibleRole.MenuItem
                My.Settings.MainWindowWindowAccessibleRole = "MenuItem"
            End If
            If MainWindowWindowAccessibleRoleToolTip.Checked Then
                Form1.AccessibleRole = AccessibleRole.ToolTip
                My.Settings.MainWindowWindowAccessibleRole = "ToolTip"
            End If
            If MainWindowWindowAccessibleRoleApplication.Checked Then
                Form1.AccessibleRole = AccessibleRole.Application
                My.Settings.MainWindowWindowAccessibleRole = "Application"
            End If
            If MainWindowWindowAccessibleRoleDocument.Checked Then
                Form1.AccessibleRole = AccessibleRole.Document
                My.Settings.MainWindowWindowAccessibleRole = "Document"
            End If
            If MainWindowWindowAccessibleRolePane.Checked Then
                Form1.AccessibleRole = AccessibleRole.Pane
                My.Settings.MainWindowWindowAccessibleRole = "Pane"
            End If
            If MainWindowWindowAccessibleRoleChart.Checked Then
                Form1.AccessibleRole = AccessibleRole.Chart
                My.Settings.MainWindowWindowAccessibleRole = "Chart"
            End If
            If MainWindowWindowAccessibleRoleDialog.Checked Then
                Form1.AccessibleRole = AccessibleRole.Dialog
                My.Settings.MainWindowWindowAccessibleRole = "Dialog"
            End If
            If MainWindowWindowAccessibleRoleBorder.Checked Then
                Form1.AccessibleRole = AccessibleRole.Border
                My.Settings.MainWindowWindowAccessibleRole = "Border"
            End If
            If MainWindowWindowAccessibleRoleGrouping.Checked Then
                Form1.AccessibleRole = AccessibleRole.Grouping
                My.Settings.MainWindowWindowAccessibleRole = "Grouping"
            End If
            If MainWindowWindowAccessibleRoleSeparator.Checked Then
                Form1.AccessibleRole = AccessibleRole.Separator
                My.Settings.MainWindowWindowAccessibleRole = "Seperator"
            End If
            If MainWindowWindowAccessibleRoleToolBar.Checked Then
                Form1.AccessibleRole = AccessibleRole.ToolBar
                My.Settings.MainWindowWindowAccessibleRole = "ToolBar"
            End If
            If MainWindowWindowAccessibleRoleStatusBar.Checked Then
                Form1.AccessibleRole = AccessibleRole.StatusBar
                My.Settings.MainWindowWindowAccessibleRole = "StatusBar"
            End If
            If MainWindowWindowAccessibleRoleTable.Checked Then
                Form1.AccessibleRole = AccessibleRole.Table
                My.Settings.MainWindowWindowAccessibleRole = "Table"
            End If
            If MainWindowWindowAccessibleRoleColumnHeader.Checked Then
                Form1.AccessibleRole = AccessibleRole.ColumnHeader
                My.Settings.MainWindowWindowAccessibleRole = "ColumnHeader"
            End If
            If MainWindowWindowAccessibleRoleRowHeader.Checked Then
                Form1.AccessibleRole = AccessibleRole.RowHeader
                My.Settings.MainWindowWindowAccessibleRole = "RowHeader"
            End If
            If MainWindowWindowAccessibleRoleColumn.Checked Then
                Form1.AccessibleRole = AccessibleRole.Column
                My.Settings.MainWindowWindowAccessibleRole = "Column"
            End If
            If MainWindowWindowAccessibleRoleRow.Checked Then
                Form1.AccessibleRole = AccessibleRole.Row
                My.Settings.MainWindowWindowAccessibleRole = "Row"
            End If
            If MainWindowWindowAccessibleRoleCell.Checked Then
                Form1.AccessibleRole = AccessibleRole.Cell
                My.Settings.MainWindowWindowAccessibleRole = "Cell"
            End If
            If MainWindowWindowAccessibleRoleLink.Checked Then
                Form1.AccessibleRole = AccessibleRole.Link
                My.Settings.MainWindowWindowAccessibleRole = "Link"
            End If
            If MainWindowWindowAccessibleRoleHelpBalloon.Checked Then
                Form1.AccessibleRole = AccessibleRole.HelpBalloon
                My.Settings.MainWindowWindowAccessibleRole = "HelpBalloon"
            End If
            If MainWindowWindowAccessibleRoleCharacter.Checked Then
                Form1.AccessibleRole = AccessibleRole.Character
                My.Settings.MainWindowWindowAccessibleRole = "Character"
            End If
            If MainWindowWindowAccessibleRoleList.Checked Then
                Form1.AccessibleRole = AccessibleRole.List
                My.Settings.MainWindowWindowAccessibleRole = "List"
            End If
            If MainWindowWindowAccessibleRoleListItem.Checked Then
                Form1.AccessibleRole = AccessibleRole.ListItem
                My.Settings.MainWindowWindowAccessibleRole = "ListItem"
            End If
            If MainWindowWindowAccessibleRoleOutline.Checked Then
                Form1.AccessibleRole = AccessibleRole.Outline
                My.Settings.MainWindowWindowAccessibleRole = "Outline"
            End If
            If MainWindowWindowAccessibleRoleOutlineItem.Checked Then
                Form1.AccessibleRole = AccessibleRole.OutlineItem
                My.Settings.MainWindowWindowAccessibleRole = "OutlineItem"
            End If
            If MainWindowWindowAccessibleRolePageTab.Checked Then
                Form1.AccessibleRole = AccessibleRole.PageTab
                My.Settings.MainWindowWindowAccessibleRole = "PageTab"
            End If
            If MainWindowWindowAccessibleRolePropertyPage.Checked Then
                Form1.AccessibleRole = AccessibleRole.PropertyPage
                My.Settings.MainWindowWindowAccessibleRole = "PropertyPage"
            End If
            If MainWindowWindowAccessibleRoleIndicator.Checked Then
                Form1.AccessibleRole = AccessibleRole.Indicator
                My.Settings.MainWindowWindowAccessibleRole = "Indicator"
            End If
            If MainWindowWindowAccessibleRoleGraphic.Checked Then
                Form1.AccessibleRole = AccessibleRole.Graphic
                My.Settings.MainWindowWindowAccessibleRole = "Graphic"
            End If
            If MainWindowWindowAccessibleRoleStaticText.Checked Then
                Form1.AccessibleRole = AccessibleRole.StaticText
                My.Settings.MainWindowWindowAccessibleRole = "StaticText"
            End If
            If MainWindowWindowAccessibleRoleText.Checked Then
                Form1.AccessibleRole = AccessibleRole.Text
                My.Settings.MainWindowWindowAccessibleRole = "Text"
            End If
            If MainWindowWindowAccessibleRolePushButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.PushButton
                My.Settings.MainWindowWindowAccessibleRole = "PushButton"
            End If
            If MainWindowWindowAccessibleRoleCheckButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.CheckButton
                My.Settings.MainWindowWindowAccessibleRole = "CheckButton"
            End If
            If MainWindowWindowAccessibleRoleRadioButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.RadioButton
                My.Settings.MainWindowWindowAccessibleRole = "RadioButton"
            End If
            If MainWindowWindowAccessibleRoleComboBox.Checked Then
                Form1.AccessibleRole = AccessibleRole.ComboBox
                My.Settings.MainWindowWindowAccessibleRole = "ComboBox"
            End If
            If MainWindowWindowAccessibleRoleDropList.Checked Then
                Form1.AccessibleRole = AccessibleRole.DropList
                My.Settings.MainWindowWindowAccessibleRole = "DropList"
            End If
            If MainWindowWindowAccessibleRoleProgressbar.Checked Then
                Form1.AccessibleRole = AccessibleRole.ProgressBar
                My.Settings.MainWindowWindowAccessibleRole = "ProgressBar"
            End If
            If MainWindowWindowAccessibleRoleDial.Checked Then
                Form1.AccessibleRole = AccessibleRole.Dial
                My.Settings.MainWindowWindowAccessibleRole = "Dial"
            End If
            If MainWindowWindowAccessibleRoleHotkeyField.Checked Then
                Form1.AccessibleRole = AccessibleRole.HotkeyField
                My.Settings.MainWindowWindowAccessibleRole = "HotkeyField"
            End If
            If MainWindowWindowAccessibleRoleSlider.Checked Then
                Form1.AccessibleRole = AccessibleRole.Slider
                My.Settings.MainWindowWindowAccessibleRole = "Slider"
            End If
            If MainWindowWindowAccessibleRoleSpinButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.SpinButton
                My.Settings.MainWindowWindowAccessibleRole = "SpinButton"
            End If
            If MainWindowWindowAccessibleRoleDiagram.Checked Then
                Form1.AccessibleRole = AccessibleRole.Diagram
                My.Settings.MainWindowWindowAccessibleRole = "Diagram"
            End If
            If MainWindowWindowAccessibleRoleAnimation.Checked Then
                Form1.AccessibleRole = AccessibleRole.Animation
                My.Settings.MainWindowWindowAccessibleRole = "Animation"
            End If
            If MainWindowWindowAccessibleRoleEquation.Checked Then
                Form1.AccessibleRole = AccessibleRole.Equation
                My.Settings.MainWindowWindowAccessibleRole = "Equation"
            End If
            If MainWindowWindowAccessibleRoleButtonDropDown.Checked Then
                Form1.AccessibleRole = AccessibleRole.ButtonDropDown
                My.Settings.MainWindowWindowAccessibleRole = "ButtonDropDown"
            End If
            If MainWindowWindowAccessibleRoleButtonMenu.Checked Then
                Form1.AccessibleRole = AccessibleRole.ButtonMenu
                My.Settings.MainWindowWindowAccessibleRole = "ButtonMenu"
            End If
            If MainWindowWindowAccessibleRoleButtonDropDownGrid.Checked Then
                Form1.AccessibleRole = AccessibleRole.ButtonDropDownGrid
                My.Settings.MainWindowWindowAccessibleRole = "ButtonDropDownGrid"
            End If
            If MainWindowWindowAccessibleRoleWhiteSpace.Checked Then
                Form1.AccessibleRole = AccessibleRole.WhiteSpace
                My.Settings.MainWindowWindowAccessibleRole = "WhiteSpace"
            End If
            If MainWindowWindowAccessibleRolePageTabList.Checked Then
                Form1.AccessibleRole = AccessibleRole.PageTabList
                My.Settings.MainWindowWindowAccessibleRole = "PageTabList"
            End If
            If MainWindowWindowAccessibleRoleClock.Checked Then
                Form1.AccessibleRole = AccessibleRole.Clock
                My.Settings.MainWindowWindowAccessibleRole = "Clock"
            End If
            If MainWindowWindowAccessibleRoleSplitButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.SplitButton
                My.Settings.MainWindowWindowAccessibleRole = "SplitButton"
            End If
            If MainWindowWindowAccessibleRoleIpAddress.Checked Then
                Form1.AccessibleRole = AccessibleRole.IpAddress
                My.Settings.MainWindowWindowAccessibleRole = "IpAdress"
            End If
            If MainWindowWindowAccessibleRoleOutlineButton.Checked Then
                Form1.AccessibleRole = AccessibleRole.OutlineButton
                My.Settings.MainWindowWindowAccessibleRole = "OutlineButton"
            End If
            'MainWindowWindowAllowDrop
            If MainWindowWindowAllowDropTrue.Checked Then
                Form1.AllowDrop = True
                My.Settings.MainWindowWindowAllowDrop = True
            End If
            If MainWindowWindowAllowDropFalse.Checked Then
                Form1.AllowDrop = False
                My.Settings.MainWindowWindowAllowDrop = False
            End If
            'MainWindowWindowAutoScaleMode
            If MainWindowWindowAutoScaleModeNone.Checked Then
                Form1.AutoScaleMode = AutoScaleMode.None
                My.Settings.MainWindowWindowAutoScaleMode = "None"
            End If

            If MainWindowWindowAutoScaleModeFont.Checked Then
                Form1.AutoScaleMode = AutoScaleMode.Font
                My.Settings.MainWindowWindowAutoScaleMode = "Font"
            End If

            If MainWindowWindowAutoScaleModeDpi.Checked Then
                Form1.AutoScaleMode = AutoScaleMode.Dpi
                My.Settings.MainWindowWindowAutoScaleMode = "Dpi"
            End If

            If MainWindowWindowAutoScaleModeInherit.Checked Then
                Form1.AutoScaleMode = AutoScaleMode.Inherit
                My.Settings.MainWindowWindowAutoScaleMode = "Inherit"
            End If
            'MainWindowWindowAutoScroll
            If MainWindowWindowAutoScrollTrue.Checked Then
                Form1.AutoScroll = True
                My.Settings.MainWindowWindowAutoScrollMarginWidth = True
            End If
            If MainWindowWindowAutoScrollFalse.Checked Then
                Form1.AutoScroll = False
                My.Settings.MainWindowWindowAutoScrollMarginWidth = False
            End If
            'MainWindowWindowAutoScrollMargin
            'Width
            My.Settings.MainWindowWindowAutoScrollMarginWidth = MainWindowWindowAutoScrollMarginWidthText.Text

            'Height
            My.Settings.MainWindowWindowAutoScrollMarginHeight = MainWindowWindowAutoScrollMarginHeightText.Text
            'MainWindowWindowAutoSize
            If MainWindowWindowAutoSizeTrue.Checked Then

            End If
            'MainWindowWindowControlBox






        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles OrganizationNameText.TextChanged
        My.Settings.OrganizationName = OrganizationNameText.Text
    End Sub

    Private Sub ChangeOrganizationPasswordButton_Click(sender As Object, e As EventArgs) Handles ChangeOrganizationPasswordButton.Click
        ChangeOrganizationPassword.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeleteAdminSettings.Click
        DeleteAdminSettingsDialog.ShowDialog()
    End Sub


End Class