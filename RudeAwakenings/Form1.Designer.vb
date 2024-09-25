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
        ContextMenuStrip1 = New ContextMenuStrip(components)
        KeepRDPActiveToolStripMenuItem = New ToolStripMenuItem()
        PreventAutolockToolStripMenuItem = New ToolStripMenuItem()
        HandleMouseToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ShowFormToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {KeepRDPActiveToolStripMenuItem, PreventAutolockToolStripMenuItem, HandleMouseToolStripMenuItem, ToolStripSeparator1, ShowFormToolStripMenuItem, QuitToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(257, 120)
        ' 
        ' KeepRDPActiveToolStripMenuItem
        ' 
        KeepRDPActiveToolStripMenuItem.Checked = True
        KeepRDPActiveToolStripMenuItem.CheckOnClick = True
        KeepRDPActiveToolStripMenuItem.CheckState = CheckState.Checked
        KeepRDPActiveToolStripMenuItem.Name = "KeepRDPActiveToolStripMenuItem"
        KeepRDPActiveToolStripMenuItem.Size = New Size(256, 22)
        KeepRDPActiveToolStripMenuItem.Text = "Keep RDP active"
        KeepRDPActiveToolStripMenuItem.ToolTipText = "Prevent being disconnected for being idle in RDP session"
        ' 
        ' PreventAutolockToolStripMenuItem
        ' 
        PreventAutolockToolStripMenuItem.Checked = True
        PreventAutolockToolStripMenuItem.CheckOnClick = True
        PreventAutolockToolStripMenuItem.CheckState = CheckState.Checked
        PreventAutolockToolStripMenuItem.Name = "PreventAutolockToolStripMenuItem"
        PreventAutolockToolStripMenuItem.Size = New Size(256, 22)
        PreventAutolockToolStripMenuItem.Text = "Prevent autolock"
        PreventAutolockToolStripMenuItem.ToolTipText = "Prevent the system from going into lock state by itself"
        ' 
        ' HandleMouseToolStripMenuItem
        ' 
        HandleMouseToolStripMenuItem.Checked = True
        HandleMouseToolStripMenuItem.CheckOnClick = True
        HandleMouseToolStripMenuItem.CheckState = CheckState.Checked
        HandleMouseToolStripMenuItem.Name = "HandleMouseToolStripMenuItem"
        HandleMouseToolStripMenuItem.Size = New Size(256, 22)
        HandleMouseToolStripMenuItem.Text = "Prevent workspace banner popups"
        HandleMouseToolStripMenuItem.ToolTipText = "Prevent the AWS Workspace popup menu bar from showing each time the mouse goes to the top of the screen"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(253, 6)
        ' 
        ' ShowFormToolStripMenuItem
        ' 
        ShowFormToolStripMenuItem.Name = "ShowFormToolStripMenuItem"
        ShowFormToolStripMenuItem.Size = New Size(256, 22)
        ShowFormToolStripMenuItem.Text = "Options..."
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(256, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "RudeAwakenings"
        NotifyIcon1.Visible = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(249, 216)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Minimized
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents KeepRDPActiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreventAutolockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HandleMouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowFormToolStripMenuItem As ToolStripMenuItem

End Class
