Imports System.IO
Imports System.Runtime.Serialization
Imports System.Text.RegularExpressions
Imports System.Windows
Imports IronXL
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Form1


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = DataGridView1.RowCount.ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.Rows.Add((DataGridView1.RowCount).ToString, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, PasswordCheck(TextBox4.Text), TextBox8.Text)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Text = DataGridView1.RowCount.ToString
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Filepath As String
        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx"
            .ShowDialog()
            Filepath = .FileName
        End With

        Dim wb As WorkBook = WorkBook.Load(Filepath)
        Dim ws As WorkSheet = wb.WorkSheets.FirstOrDefault()
        Dim running As Integer
        running = 1
        Dim col As Integer
        col = 0
        Dim id As String
        Dim application As String
        Dim username As String
        Dim email As String
        Dim password As String
        Dim phone As String
        Dim linkedemail As String
        Dim extrainfo As String
        Dim security

        For Each cell In ws

            'Ignore Header
            If running > 8 Then
                col += 1

                Dim idauto As Integer
                'Add Columns
                If col < 9 Then
                    If col = 1 Then
                        id = DataGridView1.RowCount
                    ElseIf col = 2 Then
                        application = cell.Text
                    ElseIf col = 3 Then
                        username = cell.Text
                    ElseIf col = 4 Then
                        email = cell.Text
                    ElseIf col = 5 Then
                        password = cell.Text
                        security = PasswordCheck(password)
                    ElseIf col = 6 Then
                        phone = cell.Text
                    ElseIf col = 7 Then
                        linkedemail = cell.Text
                    ElseIf col = 8 Then
                        extrainfo = cell.Text
                        DataGridView1.Rows.Add(id, application, username, email, password, phone, linkedemail, security, extrainfo)
                        col = 0
                    End If

                End If





            End If
            running += 1



        Next

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        Dim cellvalue As String = ""
        Dim i As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                cellvalue = cell.FormattedValue
                pdfTable.AddCell(Convert.ToString(cellvalue))
            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = "E:\Visual Studio Projects\PasswordManager\PasswordManager\Files\"
        Using frm = New OpenFolderDialog()
            If frm.ShowDialog(Me) = DialogResult.OK Then
                folderPath = frm.Folder + "\"
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                'Add Duplicate Identifier
                Dim foldername As String = folderPath & "PasswordList.pdf"
                Dim duplicatemark As Integer = 0
                While System.IO.File.Exists(foldername)
                    duplicatemark += 1
                    foldername = folderPath & "PasswordList (" & duplicatemark.ToString & ").pdf"
                End While


                Using stream As New FileStream(foldername, FileMode.Create)
                    Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                    PdfWriter.GetInstance(pdfDoc, stream)
                    pdfDoc.Open()
                    pdfDoc.Add(pdfTable)
                    pdfDoc.Close()
                    stream.Close()
                End Using
            End If
        End Using

        'Dim folderPath As String = "E:\Visual Studio Projects\PasswordManager\PasswordManager\Files\"

    End Sub

    Function PasswordCheck(Password As String)

        Dim safety As Integer = 0
        Dim length As Integer = Password.Length
        Dim safetyinfo As String

        If length > 7 And length < 10 Then
            safety += 1

        ElseIf length > 10 And length < 15 Then
            safety += 2

        ElseIf length > 15 Then
            safety += 3

        End If
        If Password.Any(Function(c) Char.IsLower(c)) Then
            safety += 1
        End If
        If Password.Any(Function(c) Char.IsUpper(c)) Then
            safety += 1
        End If
        If Password.Any(Function(c) Char.IsDigit(c)) Then
            safety += 1
        End If
        If Regex.IsMatch(Password, "[~`!@#$%^&*()-+=|{}':;.,<>/?]") Then
            safety += 1
        End If

        If length < 8 Then
            safety = 1
        End If

        If safety > 1 And safety <= 3 Then
            safetyinfo = "Medium Risk"
        ElseIf safety >= 4 And safety < 7 Then
            safetyinfo = "Low Risk"
        ElseIf safety >= 7 Then
            safetyinfo = "Secure"
        Else
            safetyinfo = "High Risk"
        End If

        Return safetyinfo
    End Function

End Class
