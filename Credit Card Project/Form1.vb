Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Variables

        Dim CurrentBalance As Decimal
        Dim SixtyDays As Decimal
        Dim NinetyDays As Decimal
        Dim Penalty As Decimal
        Dim Interest As Decimal
        Dim NewBalance As Decimal


        Decimal.TryParse(txtCurrentBal.Text, CurrentBalance)
        Decimal.TryParse(txt60Days.Text, SixtyDays)
        Decimal.TryParse(txt90Days.Text, NinetyDays)
        txtCurrentBal.Text = CurrentBalance.ToString("N2")
        txt60Days.Text = SixtyDays.ToString("N2")
        txt90Days.Text = NinetyDays.ToString("N2")


        ' Calculations

        Penalty = (SixtyDays * 0.01) + (NinetyDays * 0.02)
        Interest = (SixtyDays * 0.04) + (NinetyDays * 0.08) + ((CurrentBalance - (SixtyDays + NinetyDays)) * 0.02)
        NewBalance = CurrentBalance + Penalty + Interest

        If NinetyDays >= (CurrentBalance * 0.8) Then
            Penalty = (SixtyDays * 0.01) + (NinetyDays * 0.05)
            Interest = (SixtyDays * 0.04) + (NinetyDays * 0.08) + ((CurrentBalance - (SixtyDays + NinetyDays)) * 0.02)
            NewBalance = CurrentBalance + Penalty + Interest
            Dim count As Integer = 1
            Do While count <= 30
                If lblDeadbeat.Visible = True Then
                    lblDeadbeat.Visible = False
                Else
                    lblDeadbeat.Visible = True
                End If
                Me.Refresh()
                System.Threading.Thread.Sleep(100)
                count = count + 1
            Loop
            lblDeadbeat.Visible = True
        End If

        'OutPut

        txtPenalty.Text = Convert.ToString(Penalty)
        txtInterest.Text = Convert.ToString(Interest)
        txtNewBal.Text = Convert.ToString(NewBalance)
        txtPenalty.Text = Penalty.ToString("N2")
        txtInterest.Text = Interest.ToString("N2")
        txtNewBal.Text = NewBalance.ToString("N2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt60Days.Text = String.Empty
        txt90Days.Text = String.Empty
        txtCurrentBal.Text = String.Empty
        txtPenalty.Text = String.Empty
        txtInterest.Text = String.Empty
        txtNewBal.Text = String.Empty
        lblDeadbeat.Visible = False


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
