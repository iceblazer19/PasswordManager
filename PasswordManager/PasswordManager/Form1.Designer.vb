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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Button1 = New Button()
        TextBox7 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBox8 = New TextBox()
        Button2 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Button3 = New Button()
        ID = New DataGridViewTextBoxColumn()
        Application = New DataGridViewTextBoxColumn()
        Username = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Password = New DataGridViewTextBoxColumn()
        phoneNumber = New DataGridViewTextBoxColumn()
        linkedEmail = New DataGridViewTextBoxColumn()
        Security = New DataGridViewTextBoxColumn()
        extraInfo = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Application, Username, Email, Password, phoneNumber, linkedEmail, Security, extraInfo})
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1470, 474)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(156, 590)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(193, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(156, 635)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(193, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(156, 682)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(193, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(156, 730)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(193, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(156, 777)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(193, 23)
        TextBox5.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 598)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 6
        Label1.Text = "Application"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 643)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 694)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 8
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 738)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 785)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 10
        Label5.Text = "Phone Number"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(28, 553)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(72, 23)
        TextBox6.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(693, 813)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 39)
        Button1.TabIndex = 12
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(156, 824)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(193, 23)
        TextBox7.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 832)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 14
        Label6.Text = "Linked Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(453, 603)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 15
        Label7.Text = "Extra Info"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(453, 640)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(221, 212)
        TextBox8.TabIndex = 16
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(693, 640)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 39)
        Button2.TabIndex = 17
        Button2.Text = "Open File"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(693, 710)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 39)
        Button3.TabIndex = 18
        Button3.Text = "Export To PDF"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Resizable = DataGridViewTriState.False
        ' 
        ' Application
        ' 
        Application.HeaderText = "Application"
        Application.Name = "Application"
        Application.Resizable = DataGridViewTriState.True
        ' 
        ' Username
        ' 
        Username.HeaderText = "Username"
        Username.Name = "Username"
        ' 
        ' Email
        ' 
        Email.HeaderText = "Email"
        Email.Name = "Email"
        Email.Resizable = DataGridViewTriState.True
        ' 
        ' Password
        ' 
        Password.HeaderText = "Password"
        Password.Name = "Password"
        ' 
        ' phoneNumber
        ' 
        phoneNumber.HeaderText = "Phone Number"
        phoneNumber.Name = "phoneNumber"
        ' 
        ' linkedEmail
        ' 
        linkedEmail.HeaderText = "Linked Email"
        linkedEmail.Name = "linkedEmail"
        ' 
        ' Security
        ' 
        Security.HeaderText = "Security Info"
        Security.Name = "Security"
        Security.ReadOnly = True
        ' 
        ' extraInfo
        ' 
        extraInfo.HeaderText = "Extra Info"
        extraInfo.Name = "extraInfo"
        extraInfo.Width = 625
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1494, 880)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox7)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Application As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents phoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents linkedEmail As DataGridViewTextBoxColumn
    Friend WithEvents Security As DataGridViewTextBoxColumn
    Friend WithEvents extraInfo As DataGridViewTextBoxColumn

End Class
