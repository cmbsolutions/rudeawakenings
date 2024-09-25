Imports System.ComponentModel

Public Class Form1
    Private PreventClose As Boolean = True
    Private PreventAwsMenuPopup As Boolean = True
    Private PreventAutoLock As Boolean = True

    Private PreventAwsWorkspacePopupMenuHandler As New PreventAwsWorkspacePopupMenu
    Private PreventAutoLockHandler As New PreventLocking

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Minimized
        Visible = False
        ShowInTaskbar = False

        HandlePreventors()
    End Sub

    Private Sub ShowFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFormToolStripMenuItem.Click
        Visible = True
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.CenterScreen
        ShowInTaskbar = True
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Visible Then
            WindowState = FormWindowState.Minimized
            Visible = False
            ShowInTaskbar = False
        End If
        e.Cancel = PreventClose
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        PreventClose = False
        Close()
    End Sub

    Private Sub HandleMouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HandleMouseToolStripMenuItem.Click
        PreventAwsMenuPopup = HandleMouseToolStripMenuItem.Checked
        HandlePreventors()
    End Sub

    Private Sub HandlePreventors()
        If PreventAwsMenuPopup Then
            PreventAwsWorkspacePopupMenuHandler.StartListeningToMouse()
        Else
            PreventAwsWorkspacePopupMenuHandler.StopListeningToMouse()
        End If

        If PreventAutoLock Then
            PreventAutoLockHandler.StartPreventWindowsLocking()
        Else
            PreventAutoLockHandler.StopPreventingWindowsLocking()
        End If
    End Sub

    Private Sub PreventAutolockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreventAutolockToolStripMenuItem.Click
        PreventAutoLock = PreventAutolockToolStripMenuItem.Checked
        HandlePreventors()
    End Sub
End Class
