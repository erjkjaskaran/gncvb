﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btlogin = New System.Windows.Forms.Button()
		Me.un = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.up = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(124, 21)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(229, 73)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "LOGIN"
		'
		'btlogin
		'
		Me.btlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.btlogin.FlatAppearance.BorderSize = 0
		Me.btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
		Me.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btlogin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.btlogin.Location = New System.Drawing.Point(67, 329)
		Me.btlogin.Margin = New System.Windows.Forms.Padding(0)
		Me.btlogin.Name = "btlogin"
		Me.btlogin.Size = New System.Drawing.Size(333, 62)
		Me.btlogin.TabIndex = 3
		Me.btlogin.Text = "LOGIN"
		Me.btlogin.UseVisualStyleBackColor = False
		'
		'un
		'
		Me.un.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.un.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.un.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.un.ForeColor = System.Drawing.Color.Gray
		Me.un.Location = New System.Drawing.Point(27, 15)
		Me.un.Margin = New System.Windows.Forms.Padding(0)
		Me.un.Name = "un"
		Me.un.Size = New System.Drawing.Size(280, 32)
		Me.un.TabIndex = 1
		Me.un.Text = " USERNAME"
		Me.un.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(17, 15)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(280, 32)
		Me.TextBox1.TabIndex = 2
		Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.Panel1.Controls.Add(Me.un)
		Me.Panel1.Location = New System.Drawing.Point(67, 127)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(333, 62)
		Me.Panel1.TabIndex = 4
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.Panel2.Controls.Add(Me.up)
		Me.Panel2.Controls.Add(Me.TextBox1)
		Me.Panel2.Location = New System.Drawing.Point(67, 230)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(333, 62)
		Me.Panel2.TabIndex = 5
		'
		'up
		'
		Me.up.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.up.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.up.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.up.ForeColor = System.Drawing.Color.Gray
		Me.up.Location = New System.Drawing.Point(27, 15)
		Me.up.Margin = New System.Windows.Forms.Padding(0)
		Me.up.Name = "up"
		Me.up.Size = New System.Drawing.Size(280, 32)
		Me.up.TabIndex = 1
		Me.up.Text = "PASSWORD"
		Me.up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Gray
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.Button1.Location = New System.Drawing.Point(67, 415)
		Me.Button1.Margin = New System.Windows.Forms.Padding(0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(333, 62)
		Me.Button1.TabIndex = 6
		Me.Button1.Text = "CANCEL"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.GhostWhite
		Me.Label2.ForeColor = System.Drawing.Color.DimGray
		Me.Label2.Location = New System.Drawing.Point(437, 9)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(17, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "X"
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.GhostWhite
		Me.ClientSize = New System.Drawing.Size(467, 539)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btlogin)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Login"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "LOGIN"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents btlogin As Button
    Friend WithEvents un As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents up As TextBox
	Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
