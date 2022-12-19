<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SkidClick
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
        Me.Start = New System.Windows.Forms.Button()
        Me.Stop2 = New System.Windows.Forms.Button()
        Me.MinValBar = New System.Windows.Forms.TrackBar()
        Me.MaxValBar = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MinValBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxValBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(202, 95)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Stop2
        '
        Me.Stop2.Location = New System.Drawing.Point(202, 124)
        Me.Stop2.Name = "Stop2"
        Me.Stop2.Size = New System.Drawing.Size(75, 23)
        Me.Stop2.TabIndex = 1
        Me.Stop2.Text = "Stop"
        Me.Stop2.UseVisualStyleBackColor = True
        '
        'MinValBar
        '
        Me.MinValBar.Location = New System.Drawing.Point(126, 257)
        Me.MinValBar.Maximum = 18
        Me.MinValBar.Minimum = 5
        Me.MinValBar.Name = "MinValBar"
        Me.MinValBar.Size = New System.Drawing.Size(232, 45)
        Me.MinValBar.TabIndex = 2
        Me.MinValBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.MinValBar.Value = 5
        '
        'MaxValBar
        '
        Me.MaxValBar.Location = New System.Drawing.Point(126, 281)
        Me.MaxValBar.Maximum = 20
        Me.MaxValBar.Minimum = 6
        Me.MaxValBar.Name = "MaxValBar"
        Me.MaxValBar.Size = New System.Drawing.Size(232, 45)
        Me.MaxValBar.TabIndex = 4
        Me.MaxValBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.MaxValBar.Value = 6
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "6"
        '
        'SkidClick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 406)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaxValBar)
        Me.Controls.Add(Me.MinValBar)
        Me.Controls.Add(Me.Stop2)
        Me.Controls.Add(Me.Start)
        Me.Name = "SkidClick"
        Me.Text = "SkidClick"
        CType(Me.MinValBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxValBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start As Button
    Friend WithEvents Stop2 As Button
    Friend WithEvents MinValBar As TrackBar
    Friend WithEvents MaxValBar As TrackBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
