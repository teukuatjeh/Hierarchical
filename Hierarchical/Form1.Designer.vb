﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pbCanvas = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbLeft = New System.Windows.Forms.CheckBox()
        Me.rbRight = New System.Windows.Forms.CheckBox()
        Me.rbRobot2 = New System.Windows.Forms.CheckBox()
        Me.rbRobot1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTweeze = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbClaw = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUnderArm = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUpperArm = New System.Windows.Forms.TrackBar()
        Me.tbTorsoL = New System.Windows.Forms.TrackBar()
        Me.Geser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTorsoR = New System.Windows.Forms.TrackBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tbTweeze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbClaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUnderArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUpperArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTorsoL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTorsoR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbCanvas
        '
        Me.pbCanvas.Location = New System.Drawing.Point(13, 13)
        Me.pbCanvas.Name = "pbCanvas"
        Me.pbCanvas.Size = New System.Drawing.Size(580, 425)
        Me.pbCanvas.TabIndex = 0
        Me.pbCanvas.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.rbLeft)
        Me.Panel1.Controls.Add(Me.rbRight)
        Me.Panel1.Controls.Add(Me.rbRobot2)
        Me.Panel1.Controls.Add(Me.rbRobot1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(593, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 160)
        Me.Panel1.TabIndex = 23
        '
        'rbLeft
        '
        Me.rbLeft.AutoSize = True
        Me.rbLeft.Location = New System.Drawing.Point(256, 95)
        Me.rbLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.rbLeft.Name = "rbLeft"
        Me.rbLeft.Size = New System.Drawing.Size(44, 17)
        Me.rbLeft.TabIndex = 29
        Me.rbLeft.Text = "Left"
        Me.rbLeft.UseVisualStyleBackColor = True
        '
        'rbRight
        '
        Me.rbRight.AutoSize = True
        Me.rbRight.Location = New System.Drawing.Point(256, 64)
        Me.rbRight.Margin = New System.Windows.Forms.Padding(2)
        Me.rbRight.Name = "rbRight"
        Me.rbRight.Size = New System.Drawing.Size(51, 17)
        Me.rbRight.TabIndex = 28
        Me.rbRight.Text = "Right"
        Me.rbRight.UseVisualStyleBackColor = True
        '
        'rbRobot2
        '
        Me.rbRobot2.AutoSize = True
        Me.rbRobot2.Location = New System.Drawing.Point(64, 95)
        Me.rbRobot2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbRobot2.Name = "rbRobot2"
        Me.rbRobot2.Size = New System.Drawing.Size(61, 17)
        Me.rbRobot2.TabIndex = 27
        Me.rbRobot2.Text = "Robot2"
        Me.rbRobot2.UseVisualStyleBackColor = True
        '
        'rbRobot1
        '
        Me.rbRobot1.AutoSize = True
        Me.rbRobot1.Location = New System.Drawing.Point(64, 64)
        Me.rbRobot1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbRobot1.Name = "rbRobot1"
        Me.rbRobot1.Size = New System.Drawing.Size(61, 17)
        Me.rbRobot1.TabIndex = 26
        Me.rbRobot1.Text = "Robot1"
        Me.rbRobot1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(280, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Side"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(86, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Robot"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tbTweeze)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tbClaw)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbUnderArm)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbUpperArm)
        Me.Panel2.Controls.Add(Me.tbTorsoL)
        Me.Panel2.Controls.Add(Me.Geser)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbTorsoR)
        Me.Panel2.Location = New System.Drawing.Point(593, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 169)
        Me.Panel2.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(209, 107)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tweeze Claws"
        '
        'tbTweeze
        '
        Me.tbTweeze.Location = New System.Drawing.Point(209, 122)
        Me.tbTweeze.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTweeze.Maximum = 5
        Me.tbTweeze.Name = "tbTweeze"
        Me.tbTweeze.Size = New System.Drawing.Size(157, 45)
        Me.tbTweeze.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(23, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Rotate Claws"
        '
        'tbClaw
        '
        Me.tbClaw.Location = New System.Drawing.Point(23, 122)
        Me.tbClaw.Margin = New System.Windows.Forms.Padding(2)
        Me.tbClaw.Maximum = 360
        Me.tbClaw.Name = "tbClaw"
        Me.tbClaw.Size = New System.Drawing.Size(157, 45)
        Me.tbClaw.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(209, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Rotate Lower Arm"
        '
        'tbUnderArm
        '
        Me.tbUnderArm.Location = New System.Drawing.Point(209, 73)
        Me.tbUnderArm.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUnderArm.Maximum = 90
        Me.tbUnderArm.Name = "tbUnderArm"
        Me.tbUnderArm.Size = New System.Drawing.Size(157, 45)
        Me.tbUnderArm.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Rotate Upper Arm"
        '
        'tbUpperArm
        '
        Me.tbUpperArm.Location = New System.Drawing.Point(23, 73)
        Me.tbUpperArm.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUpperArm.Maximum = 90
        Me.tbUpperArm.Name = "tbUpperArm"
        Me.tbUpperArm.Size = New System.Drawing.Size(157, 45)
        Me.tbUpperArm.TabIndex = 21
        '
        'tbTorsoL
        '
        Me.tbTorsoL.Location = New System.Drawing.Point(209, 24)
        Me.tbTorsoL.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTorsoL.Maximum = 100
        Me.tbTorsoL.Name = "tbTorsoL"
        Me.tbTorsoL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTorsoL.Size = New System.Drawing.Size(156, 45)
        Me.tbTorsoL.TabIndex = 20
        '
        'Geser
        '
        Me.Geser.AutoSize = True
        Me.Geser.ForeColor = System.Drawing.Color.Aqua
        Me.Geser.Location = New System.Drawing.Point(209, 9)
        Me.Geser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Geser.Name = "Geser"
        Me.Geser.Size = New System.Drawing.Size(102, 13)
        Me.Geser.TabIndex = 19
        Me.Geser.Text = "Rotate Torso to Left"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rotate Torso to Right"
        '
        'tbTorsoR
        '
        Me.tbTorsoR.Location = New System.Drawing.Point(23, 24)
        Me.tbTorsoR.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTorsoR.Maximum = 100
        Me.tbTorsoR.Name = "tbTorsoR"
        Me.tbTorsoR.Size = New System.Drawing.Size(157, 45)
        Me.tbTorsoR.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.btnBackward)
        Me.Panel3.Controls.Add(Me.btnForward)
        Me.Panel3.Location = New System.Drawing.Point(593, 355)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 100)
        Me.Panel3.TabIndex = 25
        '
        'btnBackward
        '
        Me.btnBackward.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBackward.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBackward.Location = New System.Drawing.Point(212, 40)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(75, 23)
        Me.btnBackward.TabIndex = 10
        Me.btnBackward.Text = "Backward"
        Me.btnBackward.UseVisualStyleBackColor = False
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnForward.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnForward.Location = New System.Drawing.Point(84, 40)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 9
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(968, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbCanvas)
        Me.Name = "Form1"
        Me.Text = "Hierarchical Model"
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tbTweeze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbClaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUnderArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUpperArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTorsoL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTorsoR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbCanvas As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTweeze As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents tbClaw As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUnderArm As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUpperArm As TrackBar
    Friend WithEvents tbTorsoL As TrackBar
    Friend WithEvents Geser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTorsoR As TrackBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBackward As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents rbRobot1 As CheckBox
    Friend WithEvents rbLeft As CheckBox
    Friend WithEvents rbRight As CheckBox
    Friend WithEvents rbRobot2 As CheckBox
End Class
