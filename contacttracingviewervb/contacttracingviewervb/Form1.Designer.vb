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
        Dim Title As System.Windows.Forms.Label
        Dim insert As System.Windows.Forms.Label
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.richtxtbx1 = New System.Windows.Forms.RichTextBox()
        Me.namebox1 = New System.Windows.Forms.TextBox()
        Title = New System.Windows.Forms.Label()
        insert = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Title.AutoSize = True
        Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title.Location = New System.Drawing.Point(26, 21)
        Title.Name = "Title"
        Title.Size = New System.Drawing.Size(545, 55)
        Title.TabIndex = 0
        Title.Text = "Contact Tracing Viewer"
        AddHandler Title.Click, AddressOf Me.Title_Click
        '
        'insert
        '
        insert.AutoSize = True
        insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        insert.Location = New System.Drawing.Point(31, 132)
        insert.Name = "insert"
        insert.Size = New System.Drawing.Size(196, 29)
        insert.TabIndex = 10
        insert.Text = "Insert File Name:"
        '
        'viewbtn
        '
        Me.viewbtn.Location = New System.Drawing.Point(388, 487)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(75, 23)
        Me.viewbtn.TabIndex = 7
        Me.viewbtn.Text = "View"
        Me.viewbtn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(491, 487)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 8
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'richtxtbx1
        '
        Me.richtxtbx1.Location = New System.Drawing.Point(36, 164)
        Me.richtxtbx1.Name = "richtxtbx1"
        Me.richtxtbx1.Size = New System.Drawing.Size(530, 301)
        Me.richtxtbx1.TabIndex = 9
        Me.richtxtbx1.Text = ""
        '
        'namebox1
        '
        Me.namebox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.namebox1.Location = New System.Drawing.Point(233, 138)
        Me.namebox1.Name = "namebox1"
        Me.namebox1.Size = New System.Drawing.Size(128, 20)
        Me.namebox1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 559)
        Me.Controls.Add(Me.namebox1)
        Me.Controls.Add(insert)
        Me.Controls.Add(Me.richtxtbx1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.viewbtn)
        Me.Controls.Add(Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents viewbtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents richtxtbx1 As RichTextBox
    Friend WithEvents namebox1 As TextBox
End Class
