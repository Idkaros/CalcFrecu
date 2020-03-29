Public Class frmNumeros
    Private Enum Color
        SinColor
        Negro
        Rojo
        Verde
    End Enum

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim negro(37), rojo(37) As Integer
        Dim num(37) As Integer

        If IsNumeric(txtGiros.Text) Then
            If dgvNumerosColor.Rows.Count > 0 And CInt(txtGiros.Text) > 0 Then
                'Si hay algo que contar, contamos
                For i As Integer = 0 To dgvNumerosColor.Rows.Count - 1
                    'Si llegamos a la cantidad de giros para el calculo sale del for
                    If i + 1 = ConvEnte(txtGiros.Text) Then
                        Exit For : End If

                    'Cuenta 1 para los negros
                    If Not dgvNumerosColor.Rows(i).Cells(0).Value Is Nothing Then
                        num(dgvNumerosColor.Rows(i).Cells(0).Value) += 1
                    End If

                    'Cuenta 1 para los rojos
                    If Not dgvNumerosColor.Rows(i).Cells(1).Value Is Nothing Then
                        num(dgvNumerosColor.Rows(i).Cells(1).Value) += 1
                    End If

                Next
            End If
        End If

        'Tablas negra y roja
        Dim tblNegro As New DataTable
        Dim tblRojo As New DataTable

        'Columnas negras
        Dim colNegro As New DataColumn
        colNegro.DataType = Type.GetType("System.Int32")
        colNegro.ColumnName = "Negro"
        tblNegro.Columns.Add(colNegro)

        Dim colCantNegr As New DataColumn
        colCantNegr.DataType = Type.GetType("System.Int32")
        colCantNegr.ColumnName = "Cant"
        tblNegro.Columns.Add(colCantNegr)

        'Columnas rojas
        Dim colRojo As New DataColumn
        colRojo.DataType = Type.GetType("System.Int32")
        colRojo.ColumnName = "Rojo"
        tblRojo.Columns.Add(colRojo)

        Dim colCantRojo As New DataColumn
        colCantRojo.DataType = Type.GetType("System.Int32")
        colCantRojo.ColumnName = "Cant"
        tblRojo.Columns.Add(colCantRojo)

        dgvNegros.DataSource = tblNegro
        dgvNegros.Columns(0).Width = 50
        dgvNegros.Columns(1).Width = 50

        dgvRojos.DataSource = tblRojo
        dgvRojos.Columns(0).Width = 50
        dgvRojos.Columns(1).Width = 50
    End Sub

    Private Sub txtNumeroNegro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            InserFila()
        ElseIf (Asc(e.KeyChar) < 48 Or 57 < Asc(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

#Region "Métodos propios"
    Private Sub InserFila()
        Dim num As Object = ConvEnte(txtNumero.Text)

        Dim num_negr_vaci_inde As Object = Nothing
        Dim num_rojo_vaci_inde As Object = Nothing

        'Valida que no esté vacio
        If num IsNot Nothing Then
            'Si es negro
            If NumeColo(num) = Color.Negro Then
                'Busco el índice de la primera fila de número negro vacia para llenar
                For Each row As DataGridViewRow In dgvNumerosColor.Rows
                    If row.Cells(0).Value Is Nothing Then
                        num_negr_vaci_inde = ConvEnte(row.Index)
                        Exit For
                    End If
                Next

                'Si hay alguna fila vacia donde guardar el número
                If num_negr_vaci_inde IsNot Nothing Then
                    dgvNumerosColor.Rows(num_negr_vaci_inde).Cells(0).Value = num
                Else
                    'Sino, inserto una nueva fila
                    dgvNumerosColor.Rows.Insert(0, num, Nothing)
                End If
                dgvNumeros.Rows.Add(num)
                'Si es rojo
            ElseIf NumeColo(num) = Color.Rojo Then

                'Busco el índice de la primera fila de número rojo vacia para llenar
                For Each row As DataGridViewRow In dgvNumerosColor.Rows
                    If row.Cells(1).Value Is Nothing Then
                        num_rojo_vaci_inde = row.Index
                        Exit For
                    End If
                Next

                'Si hay alguna fila vacia donde guardar el número
                If num_rojo_vaci_inde IsNot Nothing Then
                    dgvNumerosColor.Rows(num_rojo_vaci_inde).Cells(1).Value = num
                Else
                    'Sino, inserto una nueva fila
                    dgvNumerosColor.Rows.Insert(0, Nothing, num)
                End If
                dgvNumeros.Rows.Add(num)
            End If
        End If
        txtNumero.Text = Nothing
    End Sub

    Private Function ConvEnte(ByVal val As String) As Object
        Dim obje As Object = Nothing
        If val = "" Or val = Nothing Then
            obje = Nothing
        Else
            obje = CInt(val)
        End If
        Return obje
    End Function

    Private Function NumeColo(ByVal num As Integer) As Color
        Dim color As Color = Nothing
        If num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 28 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
            color = Color.Negro
        ElseIf num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 19 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
            color = Color.Rojo
        ElseIf num = 0 Then
            color = Color.Verde
        End If
        Return color
    End Function

    Private Sub txtGiros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGiros.KeyPress
        If (Asc(e.KeyChar) < 48 Or 57 < Asc(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class
