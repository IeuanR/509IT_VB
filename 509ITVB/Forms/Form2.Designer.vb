<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Postcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.contType = New System.Windows.Forms.ComboBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(170, 93)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(100, 20)
        Me.Phone.TabIndex = 23
        '
        'Lastname
        '
        Me.Lastname.Location = New System.Drawing.Point(170, 64)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(100, 20)
        Me.Lastname.TabIndex = 22
        '
        'Firstname
        '
        Me.Firstname.Location = New System.Drawing.Point(170, 38)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(100, 20)
        Me.Firstname.TabIndex = 21
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(170, 9)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(100, 20)
        Me.ID.TabIndex = 20
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(66, 93)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(98, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Telephone Number"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(66, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(58, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Last Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(66, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "First Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(66, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Customer ID"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(487, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(487, 73)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(487, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(69, 192)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(665, 229)
        Me.dataGridView1.TabIndex = 12
        '
        'Mail
        '
        Me.Mail.Location = New System.Drawing.Point(170, 124)
        Me.Mail.Name = "Mail"
        Me.Mail.Size = New System.Drawing.Size(100, 20)
        Me.Mail.TabIndex = 25
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(66, 127)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(32, 13)
        Me.lblMail.TabIndex = 24
        Me.lblMail.Text = "Email"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(170, 155)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 20)
        Me.Address.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Address"
        '
        'Postcode
        '
        Me.Postcode.Location = New System.Drawing.Point(364, 9)
        Me.Postcode.Name = "Postcode"
        Me.Postcode.Size = New System.Drawing.Size(100, 20)
        Me.Postcode.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Postcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(580, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contact Type"
        '
        'contType
        '
        Me.contType.FormattingEnabled = True
        Me.contType.Items.AddRange(New Object() {"Business", "Personal"})
        Me.contType.Location = New System.Drawing.Point(667, 13)
        Me.contType.Name = "contType"
        Me.contType.Size = New System.Drawing.Size(121, 21)
        Me.contType.TabIndex = 32
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.contType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Postcode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Mail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Contact"
        Me.Text = "Business"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Phone As TextBox
    Private WithEvents Lastname As TextBox
    Private WithEvents Firstname As TextBox
    Private WithEvents ID As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Mail As TextBox
    Private WithEvents lblMail As Label
    Private WithEvents Address As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents Postcode As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents contType As ComboBox
End Class
