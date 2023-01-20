Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form1
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS; Database = EthansDB; Integrated Security=true")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EthansDBDataSet.PlayerDB' table. You can move, or remove it, as needed.
        Me.PlayerDBTableAdapter.Fill(Me.EthansDBDataSet.PlayerDB)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (TextBox2.Text = TextBox1.Text) Then
            Me.PlayerDBTableAdapter.Insert(TextBox1.Text, TextBox2.Text, 0, 0)
            Me.PlayerDBTableAdapter.Fill(Me.EthansDBDataSet.PlayerDB)
            MessageBox.Show("Player was (probably) added")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox2.Items.Count < 8) And (Not ListBox2.Items.Contains(ContestantPool.Text.Trim)) Then

            ListBox2.Items.Add(ContestantPool.Text.Trim)
            If (ListBox2.Items.Count = 8) Then
                MessageBox.Show("ready to finalize")
            End If
        Else
            If ListBox2.Items.Count = 8 Then
                MessageBox.Show("Size default 8 currently")
            Else

                MessageBox.Show("You already added them")

            End If

        End If

        'MessageBox.Show(ListBox1.Text.ToString)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (ListBox2.Items.Count = 8) Then
            Form2.Show()
            Me.Hide()
            Me.Refresh()
        End If

    End Sub
End Class
