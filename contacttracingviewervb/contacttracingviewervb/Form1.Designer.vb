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
        Dim Readfile As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.namebox1 = New System.Windows.Forms.TextBox()
        Title = New System.Windows.Forms.Label()
        Readfile = New System.Windows.Forms.Label()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(491, 487)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(36, 164)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(530, 301)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Readfile
        '
        Readfile.AutoSize = True
        Readfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Readfile.Location = New System.Drawing.Point(31, 132)
        Readfile.Name = "Readfile"
        Readfile.Size = New System.Drawing.Size(196, 29)
        Readfile.TabIndex = 10
        Readfile.Text = "Insert File Name:"
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
        Me.Controls.Add(Readfile)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents namebox1 As TextBox
End Class
