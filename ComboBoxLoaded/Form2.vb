Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblItems.Text = lstN.Items.Count.ToString()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim N As String
        N = txtN.Text.Trim()

        'What happens when user doesn't enter a name
        If N = String.Empty Then
            MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lstN.Items.Add(N)
        End If
        txtN.Clear()
        txtN.Focus()
        lblItems.Text = lstN.Items.Count.ToString()

    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        'Anticipate error when item not selected

        If lstN.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lstN.Items.RemoveAt(lstN.SelectedIndex)
        End If
        lblItems.Text = lstN.Items.Count.ToString()

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lstN.Items.Clear()
        lblItems.Text = lstN.Items.Count.ToString()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        'Me.close
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class