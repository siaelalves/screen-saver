Public Class SRV
    '
    Shared tm As String = DateAndTime.Now.ToString("hh:mm:ss")
    Shared dt As String = DateAndTime.Now.ToString("d' de 'MMMM' de 'yyyy")
    Shared pics As New Collection()
    Shared cript As New Segurança.Criptografia()
    '
    Private Sub SRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim d() As String = IO.File.ReadAllLines("data.ini", System.Text.Encoding.Default)
        '
        For i = 0 To UBound(d)
            pics.Add(cript.Descriptografar(d(i)))
        Next
        '
        lblTm.Text = dt & Chr(13) & tm
        '
        tmHr.Start()
        tmPic.Start()
        tmMs.Start()
        '
        lblTm.Location = New Drawing.Point(Int(Me.Size.Width / 2) - (lblTm.Width / 2), _
                                            Me.Size.Height - (lblTm.Height * 1))
        '
        Dim rn As New Random()
        On Error Resume Next
        Me.BackgroundImage = Bitmap.FromFile(pics(rn.Next(0, pics.Count - 1)))
        '
    End Sub

    Private Sub tmHr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmHr.Tick
        '
        tm = DateAndTime.Now.ToString("hh:mm:ss")
        lblTm.Text = dt & Chr(13) & tm
        '
    End Sub

    Private Sub tmPic_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmPic.Tick
        '
        Dim rn As New Random()
        '
        If pics.Count > 0 Then
            On Error Resume Next
            Me.BackgroundImage = Bitmap.FromFile(pics(rn.Next(0, pics.Count + 1)))
        ElseIf pics.Count = 0 Then
            Me.BackgroundImage = Nothing
        End If
        '
    End Sub

    Private Sub SRV_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Click
        '
        Me.Close()
        '
    End Sub

    Private Sub SRV_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        '
        If e.KeyData = Keys.F2 Then
            '
            dlgOp.Filter = "Fotos (*.jpg, *jpeg, *.bmp, *.gif, *.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"
            '
            If dlgOp.ShowDialog() = Windows.Forms.DialogResult.OK Then
                On Error Resume Next
                FileOpen(1, "data.ini", OpenMode.Append)
                For Each f In dlgOp.FileNames
                    PrintLine(1, cript.Criptografar(f))
                    pics.Add(f)
                Next
                FileClose(1)
            End If
        '
        ElseIf e.KeyData = Keys.F3 Then
            '
            If MsgBox("Tem certeza que deseja excluir todas as fotos do Slide Show?", _
                      MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Exclusão") = MsgBoxResult.Yes Then
                On Error Resume Next
                IO.File.Delete("data.ini")
                pics.Clear()
                MsgBox("Todas as fotos foram excluídas!", MsgBoxStyle.Information, "Confirmação")
            End If
            '
        Else
            '
            Me.Close()
            '
        End If
        '
    End Sub

    Private Sub SRV_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        '
        Me.Update()
        '
    End Sub
End Class
