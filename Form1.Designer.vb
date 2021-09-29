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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.start = New Guna.UI2.WinForms.Guna2Button()
        Me.logopanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.penghitungwaktu = New System.Windows.Forms.Label()
        Me.waktuanda = New System.Windows.Forms.Label()
        Me.playagain = New Guna.UI2.WinForms.Guna2Button()
        Me.label0 = New System.Windows.Forms.Label()
        Me.bar1 = New Guna.UI2.WinForms.Guna2Button()
        Me.bar2 = New Guna.UI2.WinForms.Guna2Button()
        Me.bar3 = New Guna.UI2.WinForms.Guna2Button()
        Me.bar4 = New Guna.UI2.WinForms.Guna2Button()
        Me.bar6 = New Guna.UI2.WinForms.Guna2Button()
        Me.bar5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.sidepanel.SuspendLayout()
        Me.logopanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.label0)
        Me.sidepanel.Controls.Add(Me.playagain)
        Me.sidepanel.Controls.Add(Me.Guna2Button1)
        Me.sidepanel.Controls.Add(Me.start)
        Me.sidepanel.Controls.Add(Me.logopanel)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(348, 695)
        Me.sidepanel.TabIndex = 7
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 623)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 9
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2Button1.Size = New System.Drawing.Size(321, 45)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "EXIT"
        '
        'start
        '
        Me.start.CheckedState.Parent = Me.start
        Me.start.CustomImages.Parent = Me.start
        Me.start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.start.DisabledState.Parent = Me.start
        Me.start.FillColor = System.Drawing.Color.Gainsboro
        Me.start.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.start.HoverState.Parent = Me.start
        Me.start.Location = New System.Drawing.Point(12, 570)
        Me.start.Name = "start"
        Me.start.ShadowDecoration.BorderRadius = 9
        Me.start.ShadowDecoration.Parent = Me.start
        Me.start.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.start.Size = New System.Drawing.Size(321, 45)
        Me.start.TabIndex = 4
        Me.start.Text = "START"
        '
        'logopanel
        '
        Me.logopanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.logopanel.Controls.Add(Me.logo)
        Me.logopanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logopanel.Location = New System.Drawing.Point(0, 0)
        Me.logopanel.Name = "logopanel"
        Me.logopanel.Size = New System.Drawing.Size(348, 61)
        Me.logopanel.TabIndex = 2
        '
        'logo
        '
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(348, 61)
        Me.logo.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.penghitungwaktu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(348, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 61)
        Me.Panel1.TabIndex = 14
        '
        'penghitungwaktu
        '
        Me.penghitungwaktu.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penghitungwaktu.Location = New System.Drawing.Point(6, 10)
        Me.penghitungwaktu.Name = "penghitungwaktu"
        Me.penghitungwaktu.Size = New System.Drawing.Size(847, 41)
        Me.penghitungwaktu.TabIndex = 1
        Me.penghitungwaktu.Text = "0"
        Me.penghitungwaktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'waktuanda
        '
        Me.waktuanda.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktuanda.Location = New System.Drawing.Point(348, 64)
        Me.waktuanda.Name = "waktuanda"
        Me.waktuanda.Size = New System.Drawing.Size(856, 39)
        Me.waktuanda.TabIndex = 17
        Me.waktuanda.Text = "Waktu Anda"
        Me.waktuanda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'playagain
        '
        Me.playagain.CheckedState.Parent = Me.playagain
        Me.playagain.CustomImages.Parent = Me.playagain
        Me.playagain.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.playagain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.playagain.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.playagain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.playagain.DisabledState.Parent = Me.playagain
        Me.playagain.FillColor = System.Drawing.Color.Gainsboro
        Me.playagain.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playagain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.playagain.HoverState.Parent = Me.playagain
        Me.playagain.Location = New System.Drawing.Point(12, 570)
        Me.playagain.Name = "playagain"
        Me.playagain.ShadowDecoration.BorderRadius = 9
        Me.playagain.ShadowDecoration.Parent = Me.playagain
        Me.playagain.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.playagain.Size = New System.Drawing.Size(321, 45)
        Me.playagain.TabIndex = 6
        Me.playagain.Text = "PLAY AGAIN"
        '
        'label0
        '
        Me.label0.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label0.ForeColor = System.Drawing.Color.White
        Me.label0.Location = New System.Drawing.Point(0, 265)
        Me.label0.Name = "label0"
        Me.label0.Size = New System.Drawing.Size(348, 98)
        Me.label0.TabIndex = 7
        Me.label0.Text = "Klik START untuk memulai."
        Me.label0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bar1
        '
        Me.bar1.CheckedState.Parent = Me.bar1
        Me.bar1.CustomImages.Parent = Me.bar1
        Me.bar1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar1.DisabledState.Parent = Me.bar1
        Me.bar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar1.ForeColor = System.Drawing.Color.White
        Me.bar1.HoverState.Parent = Me.bar1
        Me.bar1.Location = New System.Drawing.Point(420, 230)
        Me.bar1.Name = "bar1"
        Me.bar1.ShadowDecoration.Parent = Me.bar1
        Me.bar1.Size = New System.Drawing.Size(180, 45)
        Me.bar1.TabIndex = 18
        '
        'bar2
        '
        Me.bar2.CheckedState.Parent = Me.bar2
        Me.bar2.CustomImages.Parent = Me.bar2
        Me.bar2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar2.DisabledState.Parent = Me.bar2
        Me.bar2.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar2.ForeColor = System.Drawing.Color.White
        Me.bar2.HoverState.Parent = Me.bar2
        Me.bar2.Location = New System.Drawing.Point(687, 230)
        Me.bar2.Name = "bar2"
        Me.bar2.ShadowDecoration.Parent = Me.bar2
        Me.bar2.Size = New System.Drawing.Size(180, 45)
        Me.bar2.TabIndex = 19
        '
        'bar3
        '
        Me.bar3.CheckedState.Parent = Me.bar3
        Me.bar3.CustomImages.Parent = Me.bar3
        Me.bar3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar3.DisabledState.Parent = Me.bar3
        Me.bar3.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar3.ForeColor = System.Drawing.Color.White
        Me.bar3.HoverState.Parent = Me.bar3
        Me.bar3.Location = New System.Drawing.Point(951, 230)
        Me.bar3.Name = "bar3"
        Me.bar3.ShadowDecoration.Parent = Me.bar3
        Me.bar3.Size = New System.Drawing.Size(180, 45)
        Me.bar3.TabIndex = 20
        '
        'bar4
        '
        Me.bar4.CheckedState.Parent = Me.bar4
        Me.bar4.CustomImages.Parent = Me.bar4
        Me.bar4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar4.DisabledState.Parent = Me.bar4
        Me.bar4.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar4.ForeColor = System.Drawing.Color.White
        Me.bar4.HoverState.Parent = Me.bar4
        Me.bar4.Location = New System.Drawing.Point(552, 320)
        Me.bar4.Name = "bar4"
        Me.bar4.ShadowDecoration.Parent = Me.bar4
        Me.bar4.Size = New System.Drawing.Size(180, 45)
        Me.bar4.TabIndex = 21
        '
        'bar6
        '
        Me.bar6.CheckedState.Parent = Me.bar6
        Me.bar6.CustomImages.Parent = Me.bar6
        Me.bar6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar6.DisabledState.Parent = Me.bar6
        Me.bar6.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar6.ForeColor = System.Drawing.Color.White
        Me.bar6.HoverState.Parent = Me.bar6
        Me.bar6.Location = New System.Drawing.Point(687, 412)
        Me.bar6.Name = "bar6"
        Me.bar6.ShadowDecoration.Parent = Me.bar6
        Me.bar6.Size = New System.Drawing.Size(180, 45)
        Me.bar6.TabIndex = 22
        '
        'bar5
        '
        Me.bar5.CheckedState.Parent = Me.bar5
        Me.bar5.CustomImages.Parent = Me.bar5
        Me.bar5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bar5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bar5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bar5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bar5.DisabledState.Parent = Me.bar5
        Me.bar5.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.bar5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar5.ForeColor = System.Drawing.Color.White
        Me.bar5.HoverState.Parent = Me.bar5
        Me.bar5.Location = New System.Drawing.Point(818, 320)
        Me.bar5.Name = "bar5"
        Me.bar5.ShadowDecoration.Parent = Me.bar5
        Me.bar5.Size = New System.Drawing.Size(180, 45)
        Me.bar5.TabIndex = 23
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Timer6
        '
        Me.Timer6.Interval = 1000
        '
        'Timer7
        '
        Me.Timer7.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 695)
        Me.Controls.Add(Me.bar5)
        Me.Controls.Add(Me.bar6)
        Me.Controls.Add(Me.bar4)
        Me.Controls.Add(Me.bar3)
        Me.Controls.Add(Me.bar2)
        Me.Controls.Add(Me.bar1)
        Me.Controls.Add(Me.waktuanda)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sidepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.sidepanel.ResumeLayout(False)
        Me.logopanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents sidepanel As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logopanel As Panel
    Friend WithEvents logo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents penghitungwaktu As Label
    Friend WithEvents waktuanda As Label
    Friend WithEvents playagain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents label0 As Label
    Friend WithEvents bar1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bar2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bar3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bar4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bar6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bar5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
End Class
