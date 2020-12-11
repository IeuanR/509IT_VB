Public Class Contact

    Private mysqlConn As ContactDBconn

    Public Sub New()
        InitializeComponent()
        mysqlConn = New ContactDBconn()
        mysqlConn.connect()

        If mysqlConn.connOpen() = True Then
            dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
        End If

        mysqlConn.connClose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        If mysqlConn.connOpen() = True Then
            mysqlConn.insertContact(Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text)
            dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
        End If

        mysqlConn.connClose()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataGridView1.SelectionChanged

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If mysqlConn.connOpen() = True Then
            mysqlConn.updateContact(ID.Text, Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text)
            dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
        End If

        mysqlConn.connClose()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If DialogResult.Yes = MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then

            If mysqlConn.connOpen() = True Then
                mysqlConn.deleteContact(ID.Text)
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
            End If

            mysqlConn.connClose()
        End If
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
        Form1.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.[Exit]()
    End Sub
End Class