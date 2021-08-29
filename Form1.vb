Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblIdade2.Click

    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        'Criando as variáveis que serão utilizadas no processo
        Dim idade1, idade2 As Integer
        'Inserindo valores nas variáveis, recuperando objetos TextBox
        'Convertendo o conteúdo do TextBox que é uma string para números inteiros com a função CInt
        idade1 = CInt(tbtIdade1.Text)
        idade2 = CInt(tbtIdade2.Text)

        'Vamos comparar os valores das variáveis usando a estrutura de decisão
        If idade1 > idade2 Then
            MessageBox.Show("A idade de " & idade1 & " anos, é maior que a de " & idade2 & " anos")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade de " & idade2 & " anos, é maior que a de " & idade1 & " anos")
        Else
            MessageBox.Show("A idade de " & idade1 & " anos, é igual a idade de " & idade2 & " anos")
        End If
        LimparCampos()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        tbtIdade1.Clear()
        tbtIdade2.Clear()
    End Sub
End Class
