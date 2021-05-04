<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwoPlayerForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayerTurnLabel = New System.Windows.Forms.Label()
        Me.RedWinCounter = New System.Windows.Forms.TextBox()
        Me.BlueWinCounter = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape18 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape17 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape16 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape15 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape9 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape8 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kırmızı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mavi"
        '
        'PlayerTurnLabel
        '
        Me.PlayerTurnLabel.AutoSize = True
        Me.PlayerTurnLabel.Location = New System.Drawing.Point(181, 21)
        Me.PlayerTurnLabel.Name = "PlayerTurnLabel"
        Me.PlayerTurnLabel.Size = New System.Drawing.Size(33, 17)
        Me.PlayerTurnLabel.TabIndex = 2
        Me.PlayerTurnLabel.Text = "Sıra"
        '
        'RedWinCounter
        '
        Me.RedWinCounter.Location = New System.Drawing.Point(25, 50)
        Me.RedWinCounter.Name = "RedWinCounter"
        Me.RedWinCounter.Size = New System.Drawing.Size(79, 22)
        Me.RedWinCounter.TabIndex = 3
        '
        'BlueWinCounter
        '
        Me.BlueWinCounter.Location = New System.Drawing.Point(324, 50)
        Me.BlueWinCounter.Name = "BlueWinCounter"
        Me.BlueWinCounter.Size = New System.Drawing.Size(79, 22)
        Me.BlueWinCounter.TabIndex = 4
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape18, Me.LineShape17, Me.LineShape16, Me.LineShape15, Me.LineShape14, Me.LineShape13, Me.LineShape12, Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.OvalShape9, Me.OvalShape8, Me.OvalShape7, Me.OvalShape6, Me.OvalShape5, Me.OvalShape4, Me.OvalShape3, Me.OvalShape2, Me.OvalShape1, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(428, 333)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape18
        '
        Me.LineShape18.BorderColor = System.Drawing.Color.Red
        Me.LineShape18.BorderWidth = 9
        Me.LineShape18.Name = "LineShape18"
        Me.LineShape18.X1 = 291
        Me.LineShape18.X2 = 266
        Me.LineShape18.Y1 = 242
        Me.LineShape18.Y2 = 277
        '
        'LineShape17
        '
        Me.LineShape17.BorderColor = System.Drawing.Color.Red
        Me.LineShape17.BorderWidth = 9
        Me.LineShape17.Name = "LineShape17"
        Me.LineShape17.X1 = 265
        Me.LineShape17.X2 = 293
        Me.LineShape17.Y1 = 243
        Me.LineShape17.Y2 = 273
        '
        'LineShape16
        '
        Me.LineShape16.BorderColor = System.Drawing.Color.Red
        Me.LineShape16.BorderWidth = 9
        Me.LineShape16.Name = "LineShape16"
        Me.LineShape16.X1 = 219
        Me.LineShape16.X2 = 194
        Me.LineShape16.Y1 = 241
        Me.LineShape16.Y2 = 276
        '
        'LineShape15
        '
        Me.LineShape15.BorderColor = System.Drawing.Color.Red
        Me.LineShape15.BorderWidth = 9
        Me.LineShape15.Name = "LineShape15"
        Me.LineShape15.X1 = 194
        Me.LineShape15.X2 = 225
        Me.LineShape15.Y1 = 243
        Me.LineShape15.Y2 = 276
        '
        'LineShape14
        '
        Me.LineShape14.BorderColor = System.Drawing.Color.Red
        Me.LineShape14.BorderWidth = 9
        Me.LineShape14.Name = "LineShape14"
        Me.LineShape14.X1 = 150
        Me.LineShape14.X2 = 126
        Me.LineShape14.Y1 = 240
        Me.LineShape14.Y2 = 274
        '
        'LineShape13
        '
        Me.LineShape13.BorderColor = System.Drawing.Color.Red
        Me.LineShape13.BorderWidth = 9
        Me.LineShape13.Name = "LineShape13"
        Me.LineShape13.X1 = 126
        Me.LineShape13.X2 = 152
        Me.LineShape13.Y1 = 241
        Me.LineShape13.Y2 = 274
        '
        'LineShape12
        '
        Me.LineShape12.BorderColor = System.Drawing.Color.Red
        Me.LineShape12.BorderWidth = 9
        Me.LineShape12.Name = "LineShape12"
        Me.LineShape12.X1 = 290
        Me.LineShape12.X2 = 266
        Me.LineShape12.Y1 = 184
        Me.LineShape12.Y2 = 217
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.Color.Red
        Me.LineShape11.BorderWidth = 9
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 265
        Me.LineShape11.X2 = 291
        Me.LineShape11.Y1 = 185
        Me.LineShape11.Y2 = 218
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Red
        Me.LineShape10.BorderWidth = 9
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 194
        Me.LineShape10.X2 = 221
        Me.LineShape10.Y1 = 216
        Me.LineShape10.Y2 = 187
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Red
        Me.LineShape9.BorderWidth = 9
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 196
        Me.LineShape9.X2 = 222
        Me.LineShape9.Y1 = 185
        Me.LineShape9.Y2 = 218
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Red
        Me.LineShape8.BorderWidth = 9
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 149
        Me.LineShape8.X2 = 124
        Me.LineShape8.Y1 = 190
        Me.LineShape8.Y2 = 222
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Red
        Me.LineShape7.BorderWidth = 9
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 124
        Me.LineShape7.X2 = 150
        Me.LineShape7.Y1 = 187
        Me.LineShape7.Y2 = 220
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Red
        Me.LineShape6.BorderWidth = 9
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 294
        Me.LineShape6.X2 = 264
        Me.LineShape6.Y1 = 132
        Me.LineShape6.Y2 = 164
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Red
        Me.LineShape5.BorderWidth = 9
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 267
        Me.LineShape5.X2 = 293
        Me.LineShape5.Y1 = 132
        Me.LineShape5.Y2 = 165
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Red
        Me.LineShape4.BorderWidth = 9
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 222
        Me.LineShape4.X2 = 193
        Me.LineShape4.Y1 = 131
        Me.LineShape4.Y2 = 162
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Red
        Me.LineShape3.BorderWidth = 9
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 195
        Me.LineShape3.X2 = 221
        Me.LineShape3.Y1 = 131
        Me.LineShape3.Y2 = 164
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Red
        Me.LineShape2.BorderWidth = 9
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 153
        Me.LineShape2.X2 = 127
        Me.LineShape2.Y1 = 130
        Me.LineShape2.Y2 = 162
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Red
        Me.LineShape1.BorderWidth = 9
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 127
        Me.LineShape1.X2 = 153
        Me.LineShape1.Y1 = 130
        Me.LineShape1.Y2 = 163
        '
        'OvalShape9
        '
        Me.OvalShape9.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape9.BorderWidth = 9
        Me.OvalShape9.Location = New System.Drawing.Point(256, 243)
        Me.OvalShape9.Name = "OvalShape9"
        Me.OvalShape9.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape8
        '
        Me.OvalShape8.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape8.BorderWidth = 9
        Me.OvalShape8.Location = New System.Drawing.Point(184, 242)
        Me.OvalShape8.Name = "OvalShape8"
        Me.OvalShape8.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape7
        '
        Me.OvalShape7.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape7.BorderWidth = 9
        Me.OvalShape7.Location = New System.Drawing.Point(114, 241)
        Me.OvalShape7.Name = "OvalShape7"
        Me.OvalShape7.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape6
        '
        Me.OvalShape6.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape6.BorderWidth = 9
        Me.OvalShape6.Location = New System.Drawing.Point(254, 185)
        Me.OvalShape6.Name = "OvalShape6"
        Me.OvalShape6.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape5
        '
        Me.OvalShape5.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape5.BorderWidth = 9
        Me.OvalShape5.Location = New System.Drawing.Point(184, 185)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape4
        '
        Me.OvalShape4.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape4.BorderWidth = 9
        Me.OvalShape4.Location = New System.Drawing.Point(114, 187)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape3
        '
        Me.OvalShape3.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape3.BorderWidth = 9
        Me.OvalShape3.Location = New System.Drawing.Point(254, 130)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape2
        '
        Me.OvalShape2.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape2.BorderWidth = 9
        Me.OvalShape2.Location = New System.Drawing.Point(184, 130)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(49, 35)
        '
        'OvalShape1
        '
        Me.OvalShape1.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape1.BorderWidth = 9
        Me.OvalShape1.Location = New System.Drawing.Point(115, 129)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(49, 35)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.Location = New System.Drawing.Point(244, 230)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.Location = New System.Drawing.Point(174, 230)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.Location = New System.Drawing.Point(104, 230)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.Location = New System.Drawing.Point(244, 174)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(174, 174)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Location = New System.Drawing.Point(104, 174)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(244, 118)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(174, 118)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(70, 56)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(104, 118)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(70, 56)
        '
        'TwoPlayerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 333)
        Me.Controls.Add(Me.BlueWinCounter)
        Me.Controls.Add(Me.RedWinCounter)
        Me.Controls.Add(Me.PlayerTurnLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "TwoPlayerForm"
        Me.Text = "TicTacToe Berkay ERAYDIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PlayerTurnLabel As Label
    Friend WithEvents RedWinCounter As TextBox
    Friend WithEvents BlueWinCounter As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents OvalShape9 As PowerPacks.OvalShape
    Friend WithEvents OvalShape8 As PowerPacks.OvalShape
    Friend WithEvents OvalShape7 As PowerPacks.OvalShape
    Friend WithEvents OvalShape6 As PowerPacks.OvalShape
    Friend WithEvents OvalShape5 As PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents LineShape18 As PowerPacks.LineShape
    Friend WithEvents LineShape17 As PowerPacks.LineShape
    Friend WithEvents LineShape16 As PowerPacks.LineShape
    Friend WithEvents LineShape15 As PowerPacks.LineShape
    Friend WithEvents LineShape14 As PowerPacks.LineShape
    Friend WithEvents LineShape13 As PowerPacks.LineShape
    Friend WithEvents LineShape12 As PowerPacks.LineShape
    Friend WithEvents LineShape11 As PowerPacks.LineShape
    Friend WithEvents LineShape10 As PowerPacks.LineShape
    Friend WithEvents LineShape9 As PowerPacks.LineShape
    Friend WithEvents LineShape8 As PowerPacks.LineShape
    Friend WithEvents LineShape7 As PowerPacks.LineShape
    Friend WithEvents LineShape6 As PowerPacks.LineShape
End Class
