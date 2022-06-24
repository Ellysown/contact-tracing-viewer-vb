<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim insert As System.Windows.Forms.Label
        Dim Title As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.richtxtbx1 = New System.Windows.Forms.RichTextBox()
        Me.namebox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        insert = New System.Windows.Forms.Label()
        Title = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'insert
        '
        insert.AutoSize = True
        insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        insert.Location = New System.Drawing.Point(3, -2)
        insert.Name = "insert"
        insert.Size = New System.Drawing.Size(152, 24)
        insert.TabIndex = 10
        insert.Text = "Insert File Name:"
        '
        'viewbtn
        '
        Me.viewbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.viewbtn.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.viewbtn.Location = New System.Drawing.Point(357, 261)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(75, 23)
        Me.viewbtn.TabIndex = 7
        Me.viewbtn.Text = "View"
        Me.viewbtn.UseVisualStyleBackColor = False
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.closebtn.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closebtn.Location = New System.Drawing.Point(460, 261)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 8
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = False
        '
        'richtxtbx1
        '
        Me.richtxtbx1.Font = New System.Drawing.Font("MS PGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richtxtbx1.Location = New System.Drawing.Point(31, 109)
        Me.richtxtbx1.Name = "richtxtbx1"
        Me.richtxtbx1.Size = New System.Drawing.Size(504, 146)
        Me.richtxtbx1.TabIndex = 9
        Me.richtxtbx1.Text = ""
        '
        'namebox1
        '
        Me.namebox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namebox1.Location = New System.Drawing.Point(192, 74)
        Me.namebox1.Name = "namebox1"
        Me.namebox1.Size = New System.Drawing.Size(188, 29)
        Me.namebox1.TabIndex = 11
        '
        'Title
        '
        Title.AutoSize = True
        Title.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title.Location = New System.Drawing.Point(38, 0)
        Title.Name = "Title"
        Title.Size = New System.Drawing.Size(455, 50)
        Title.TabIndex = 0
        Title.Text = "Contact Tracing Viewer"
        AddHandler Title.Click, AddressOf Me.Title_Click
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Title)
        Me.Panel1.Location = New System.Drawing.Point(31, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 52)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(insert)
        Me.Panel2.Location = New System.Drawing.Point(31, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 26)
        Me.Panel2.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(567, 293)
        Me.Controls.Add(Me.namebox1)
        Me.Controls.Add(Me.richtxtbx1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.viewbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DOH Contact Tracing Viewer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents viewbtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents richtxtbx1 As RichTextBox
    Friend WithEvents namebox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
