Public Class frmNumeros
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim negro(37), rojo(37) As Integer

        If IsNumeric(txtGiros.Text) Then
            If dgvNumeros.Rows.Count > 0 And CInt(txtGiros.Text) > 0 Then
                'Si hay algo que contar, contamos
                For i As Integer = 0 To dgvNumeros.Rows.Count - 1
                    'Si llegamos a la cantidad de giros para el calculo sale del for
                    If i + 1 = ConvEnte(txtGiros.Text) Then
                        Exit For : End If

                    'Cuenta 1 para los negros
                    If Not dgvNumeros.Rows(i).Cells(0).Value Is Nothing Then
                        negro(dgvNumeros.Rows(i).Cells(0).Value) += 1
                    End If

                    'Cuenta 1 para los rojos
                    If Not dgvNumeros.Rows(i).Cells(1).Value Is Nothing Then
                        rojo(dgvNumeros.Rows(i).Cells(1).Value) += 1
                    End If

                Next
            End If
        End If

        Dim tblNegro As New DataTable
        Dim tblRojo As New DataTable

        Dim colNegro As New DataColumn
        colNegro.DataType = Type.GetType("System.Int32")
        colNegro.ColumnName = "Negro"
        tblNegro.Columns.Add(colNegro)

        Dim colRojo As New DataColumn
        colRojo.DataType = Type.GetType("System.Int32")
        colRojo.ColumnName = "Rojo"
        tblRojo.Columns.Add(colRojo)

        Dim colContador As New DataColumn
        colContador.DataType = Type.GetType("System.Int32")
        colContador.ColumnName = "Cant"
        tblNegro.Columns.Add(colContador)
        'tblRojo.Columns.Add(colContador)

        dgvNegros.DataSource = tblNegro
        dgvNegros.Columns(0).Width = 50

        dgvRojos.DataSource = tblRojo
        dgvRojos.Columns(0).Width = 50
    End Sub

    Private Sub txtNumeroNegro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroNegro.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            InserFila()
        ElseIf (Asc(e.KeyChar) < 48 Or 57 < Asc(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumeroRojo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroRojo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            InserFila()
        ElseIf (Asc(e.KeyChar) < 48 Or 57 < Asc(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

#Region "Métodos propios"
    Private Sub InserFila()
        Dim num_negr As Object = ConvEnte(txtNumeroNegro.Text)
        Dim num_rojo As Object = ConvEnte(txtNumeroRojo.Text)

        Dim num_negr_vaci_inde As Object = Nothing
        Dim num_rojo_vaci_inde As Object = Nothing

        'Si cargué un número negro
        If num_negr IsNot Nothing Then
            'Busco el índice de la última fila de número negro vacia para llenar
            For Each row As DataGridViewRow In dgvNumeros.Rows
                If row.Cells(0).Value Is Nothing Then
                    num_negr_vaci_inde = ConvEnte(row.Index)
                Else
                    Exit For
                End If
            Next

            'Si hay alguna fila vacia donde guardar el número
            If num_negr_vaci_inde IsNot Nothing Then
                dgvNumeros.Rows(num_negr_vaci_inde).Cells(0).Value = num_negr
            Else
                'Sino, inserto una nueva fila
                dgvNumeros.Rows.Insert(0, num_negr, Nothing)
            End If
        End If

        'Si cargué un número rojo
        If num_rojo IsNot Nothing Then
            'Busco el índice de la última fila de número rojo vacia para llenar
            For Each row As DataGridViewRow In dgvNumeros.Rows
                If row.Cells(1).Value Is Nothing Then
                    num_rojo_vaci_inde = row.Index
                Else
                    Exit For
                End If
            Next

            'Si hay alguna fila vacia donde guardar el número
            If num_rojo_vaci_inde IsNot Nothing Then
                dgvNumeros.Rows(num_rojo_vaci_inde).Cells(1).Value = num_rojo
            Else
                'Sino, inserto una nueva fila
                dgvNumeros.Rows.Insert(0, Nothing, num_rojo)
            End If

        End If

        txtNumeroNegro.Text = Nothing
        txtNumeroRojo.Text = Nothing
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
#End Region

End Class
