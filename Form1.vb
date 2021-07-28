Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtPassword.Text = "Admin" And txtUsername.Text = "Wisdom" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("Invalid login details", "Closing Exams", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHOP2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOP2DataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOP2DataSet.CUSTOMER_DETAILS)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CUSTOMER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CUSTOMER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.CUSTOMER_DETAILSTableAdapter.Update(Me.SHOP2DataSet)
Feedback:
        MsgBox("Check your Record", vbInformation)
        Exit Sub
    End Sub
End Class
