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

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        If mysqlConn.connOpen() = True Then
            mysqlConn.insertContact(Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text)
            dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
        End If

        mysqlConn.connClose()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If dataGridView1.SelectedRows.Count > 0 Then
            ID.Text = dataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Firstname.Text = dataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            Lastname.Text = dataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            Phone.Text = dataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            Mail.Text = dataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            Address.Text = dataGridView1.SelectedRows(0).Cells(5).Value.ToString()
            Postcode.Text = dataGridView1.SelectedRows(0).Cells(6).Value.ToString()
            contType.Text = dataGridView1.SelectedRows(0).Cells(7).Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
        If mysqlConn.connOpen() = True Then
            mysqlConn.updateContact(ID.Text, Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text)
            dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables(0)
        End If

        mysqlConn.connClose()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
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