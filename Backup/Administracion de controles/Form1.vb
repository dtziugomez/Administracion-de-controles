Public Class Form1
    'mostrar
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If (ctrl.GetType().ToString() = "System.Windows.Forms." & Me.ComboBox3.SelectedItem) Then
                Me.GroupBox1.Controls(Me.GroupBox1.Controls.IndexOf(ctrl)).Visible = True

            End If
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If (ctrl.GetType().ToString() = "System.Windows.Forms." & Me.ComboBox3.SelectedItem) Then
                Me.GroupBox1.Controls(Me.GroupBox1.Controls.IndexOf(ctrl)).Visible = False

            End If
        Next

    End Sub
End Class
