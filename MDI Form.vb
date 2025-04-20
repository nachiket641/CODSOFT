Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class MDI_Form

    Private Sub ANIMALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANIMALToolStripMenuItem.Click

    End Sub

    Private Sub SEARCHCATSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWANIMALSDOGToolStripMenuItem.Click
        Cat.Show()
    End Sub

    Private Sub VIEWANIMALSCATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWANIMALSCATToolStripMenuItem.Click
        View_Animal_Cats.Show()
    End Sub

    Private Sub SEARCHDOGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWANIMALDOGSToolStripMenuItem.Click
        Dog.Show()
    End Sub

    Private Sub VIEWANIMALDOGSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWANIMALDOGSToolStripMenuItem1.Click
        View_Animal_Dogs.Show()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        About_Us.Show()
    End Sub

    Private Sub CONTACTUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTACTUSToolStripMenuItem.Click
        Contact_Us.Show()
    End Sub

    Private Sub ADDANIMALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDANIMALToolStripMenuItem.Click
        Animal_add.Show()
    End Sub

    Private Sub VIEWUSERSMESSAGEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWUSERSMESSAGEToolStripMenuItem.Click
        View_Uers_Manager.Show()
    End Sub

    Private Sub VIEWADOPTONHISTORYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWADOPTONHISTORYToolStripMenuItem.Click
        History.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem1.Click
        Login.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub SENDMESSAGEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SENDMESSAGEToolStripMenuItem.Click
        Send_message.Show()
    End Sub

   

    Private Sub VIEWSURVEYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWSURVEYToolStripMenuItem.Click
        Request.Show()
    End Sub


    Private Sub DOGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub ANIMALToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub HISTORYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HISTORYToolStripMenuItem.Click
        rpt_History.Show()
    End Sub

    Private Sub CATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATToolStripMenuItem.Click
        rpt_Cat.Show()
    End Sub

    Private Sub DOGToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOGToolStripMenuItem.Click
        rpt_Dog.Show()
    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rpt_Signup.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGNUPToolStripMenuItem.Click
        rpt_Signup.Show()
    End Sub
    
    Private Sub GALLERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GALLERYToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GALLERYToolStripMenuItem.Click
        Pet_Gallery.Show()
    End Sub

    
    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        i = MsgBox("Do u want to logout? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If i = 6 Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class