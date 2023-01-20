Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Public Class Form2
    Private names As List(Of String)
    Private comboBoxes As ComboBox()
    Private nameBoxes As TextBox()
    Private items As String()
    Private updateList As List(Of Gamer)
    'Private scores As List(Of String)
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS; Database = EthansDB; Integrated Security=true")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidecomps()

        Form1.PlayerDBTableAdapter.Fill(Form1.EthansDBDataSet.PlayerDB)
        names = New List(Of String)
        ' scores = New List(Of String)
        updateList = New List(Of Gamer)

        For Each element As String In Form1.ListBox2.Items
            names.Add(element.ToString)
        Next
        items = names.ToArray
        'Put all the ComboBox controls on the form into an array.
        Me.comboBoxes = Me.Controls.OfType(Of ComboBox)().ToArray()

        Array.ForEach(Me.comboBoxes,
                      Sub(cb)
                          'Populate all ComboBoxes with the entire list to start with.
                          cb.Items.AddRange(Me.items)

                          'Handle the SelectedIndexChanged events of all ComboBoxes with the same method.
                          AddHandler cb.SelectionChangeCommitted, AddressOf comboBoxes_SelectionChangeCommitted
                      End Sub)
    End Sub
    Public Sub filledOut1() 'checks to make sure the boxes for the first round are filled out before displaying the compoents to fill out information of the next round 
        For Each cb As ComboBox In comboBoxes
            If cb.SelectedItem Is Nothing Then
                'do nothing :)
            Else
                showSecondRound() 'display the next components for round 2 of contest 
            End If
        Next
    End Sub
    Public Sub filledOut2()
        If (TextBox2.Text.Length = 0) Or (TextBox3.Text.Length = 0) Or (TextBox4.Text.Length = 0) Or (TextBox5.Text.Length = 0) Then
            'its not filled out so do nothing
        Else
            showThirdRound()
        End If
    End Sub
    Public Sub filledOut3()
        If (TextBox6.Text.Length = 0) Or (TextBox7.Text.Length = 0) Then
            'its not filled out so do nothing
        Else
            showFinal()
        End If
    End Sub
    Public Sub hidecomps()
        Button1.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        GroupBox5.Hide()
        GroupBox7.Hide()
        GroupBox6.Hide()
    End Sub


    Public Sub showSecondRound()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()



    End Sub
    Public Sub showThirdRound()
        TextBox6.Show()
        TextBox7.Show()
        GroupBox5.Show()
        GroupBox7.Show()
        'trying to limit ability for user to create an invalid bracket representation.
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()


    End Sub
    Public Sub showFinal()
        TextBox1.Show()
        GroupBox6.Show()
        ' Button1.Show()
        GroupBox5.Hide()
        GroupBox7.Hide()


    End Sub


    Private Sub comboBoxes_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Array.ForEach(Me.comboBoxes, AddressOf UpdateDropDownList)
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub




    Private Sub UpdateDropDownList(current As ComboBox)
        Dim selectedItem = current.SelectedItem

        Dim otherComboBoxes = Me.comboBoxes.Except({current})
        Dim otherSelectedItems = otherComboBoxes.Select(Function(cb) cb.SelectedItem).Cast(Of String)()

        current.Items.Clear()
        current.Items.AddRange(Me.items.Except(otherSelectedItems).ToArray())

        current.SelectedItem = selectedItem
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox5.Text = ComboBox8.Text
        '   End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        ' If (RadioButton11.Checked Or RadioButton12.Checked) And (RadioButton13.Checked Or RadioButton14.Checked) Then
        TextBox7.Text = TextBox4.Text
        ' End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        filledOut2()

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs)
        '   If (RadioButton11.Checked Or RadioButton12.Checked) And (RadioButton13.Checked Or RadioButton14.Checked) Then
        '   End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        '  If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox3.Text = ComboBox3.Text
        '  End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox3.Text = ComboBox4.Text
        '  End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        '  If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox5.Text = ComboBox7.Text

        '  End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        ' If (RadioButton11.Checked Or RadioButton12.Checked) And (RadioButton13.Checked Or RadioButton14.Checked) Then
        TextBox7.Text = TextBox5.Text
        ' End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        ' If (RadioButton11.Checked Or RadioButton12.Checked) And (RadioButton13.Checked Or RadioButton14.Checked) Then
        TextBox6.Text = TextBox2.Text
        '  End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        ' If (RadioButton10.Checked Or RadioButton9.Checked) Then
        TextBox1.Text = TextBox6.Text
        Button1.Show()
        ' End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        ' If (RadioButton10.Checked Or RadioButton9.Checked) Then
        TextBox1.Text = TextBox7.Text
        Button1.Show()

        ' End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        ' If (RadioButton11.Checked Or RadioButton12.Checked) And (RadioButton13.Checked Or RadioButton14.Checked) Then
        TextBox6.Text = TextBox3.Text
        '  End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        filledOut2()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged


        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox2.Text = ComboBox1.Text
        ' End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox2.Text = ComboBox2.Text
        ' End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox4.Text = ComboBox5.Text
        ' End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ' If (RadioButton7.Checked Or RadioButton8.Checked) And (RadioButton6.Checked Or RadioButton5.Checked) And (RadioButton4.Checked Or RadioButton3.Checked) And (RadioButton2.Checked Or RadioButton1.Checked) Then
        TextBox4.Text = ComboBox6.Text
        ' End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        ' Dim row As DataRow = dt.Rows(0)
        ' Dim val As String = row("Playername")

        '  Dim txtBList As New List(Of String)



        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS; Database = EthansDB; Integrated Security=true")
        '  For Each ctrl0 As ComboBox In comboBoxes

        '    Dim value As String = ctrl0.Text
        '    scores.Add(value)
        'Next


        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is ComboBox) Then

                Dim value As String = DirectCast(ctrl, ComboBox).Text

                Dim dt = QueryDatabaseServer(value)
                Dim row As DataRow = dt.Rows(0)

                Dim pn As String = row("Playername")
                Dim tag As String = row("GamerTag")
                Dim wins As Integer = row("Wins")
                Dim losses As Integer = row("Losses")
                Dim g As New Gamer(pn, tag, wins, losses)
                updateList.Add(g)
                'scores.Add(pn)
            End If
        Next


        For Each gamr As Gamer In updateList
            Dim result = helper(gamr.name)
            If result = 3 Then
                gamr.updateWins(3)
                gamr.updatedb()

            End If
            If result = 2 Then
                gamr.updateWins(2)
                gamr.updateLosses(1)
                gamr.updatedb()
            End If
            If result = 1 Then
                gamr.updateWins(1)
                gamr.updateLosses(1)
                gamr.updatedb()

            End If
            If result = 0 Then
                gamr.updateLosses(1)
                gamr.updatedb()

            End If
        Next


        connection.Close()



    End Sub
    Public Function helper(s As String) As Integer
        Dim count = 0
        ' Me.comboBoxes = Me.Controls.OfType(Of ComboBox)().ToArray()

        Dim listoftextbox = Me.Controls.OfType(Of TextBox).ToList
        Dim listofvalues As New List(Of String)
        For Each e In listoftextbox
            listofvalues.Add(e.Text)
        Next



        For Each str As String In listofvalues
            If s = str Then
                count += 1
            End If
        Next
        Return count


    End Function


    Public Class Gamer
        Public name As String
        Public gamertag As String
        Public wins As Integer
        Public losses As Integer

        Public Sub New(name As String, gamertag As String, wins As Integer, losses As Integer)
            Me.name = name
            Me.gamertag = gamertag
            Me.wins = wins
            Me.losses = losses
        End Sub

        Public Sub updateWins(winz As Integer)
            wins += winz
        End Sub
        Public Sub updateLosses(lossez As Integer)
            losses += lossez
        End Sub
        Public Sub updatedb()
            Using con As New SqlConnection("Server=localhost\SQLEXPRESS; Database = EthansDB; Integrated Security=true")
                Dim rowsAffected As Integer

                Using cmd As New SqlCommand("UPDATE PlayerDB Set  Playername=@name , GamerTag=@tag, Wins=@wins, Losses=@losses WHERE Playername = @name", con)

                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                    cmd.Parameters.Add("@tag", SqlDbType.VarChar).Value = gamertag
                    cmd.Parameters.Add("@wins", SqlDbType.Int).Value = wins
                    cmd.Parameters.Add("@losses", SqlDbType.Int).Value = losses

                    con.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                    MessageBox.Show(rowsAffected.ToString + "DEBUG ")
                    con.Close()
                End Using
            End Using
        End Sub
    End Class







    Public Function QueryDatabaseServer(name As String) As DataTable
        Dim connectionString As String = "Server=localhost\SQLEXPRESS; Database = EthansDB; Integrated Security=true"
        Dim queryString As String = "SELECT [Playername]
          ,[GamerTag]
          ,[Wins]
          ,[Losses]
      FROM [dbo].[PlayerDB]WHERE Playername=" + "'" + name + "'"


        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(queryString, conn)
                cmd.Parameters.AddWithValue(name, name)

                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                Return dataTable
            End Using
        End Using
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        filledOut2()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Threading.Thread.Sleep(5000)
        Form1.Dispose()
        Me.Dispose()
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        filledOut2()

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        filledOut1()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        filledOut1()

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        filledOut3()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        filledOut3()

    End Sub
End Class