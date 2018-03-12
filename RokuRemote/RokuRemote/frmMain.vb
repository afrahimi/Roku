Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
'Imports System.Drawing.Imaging


Public Class frmMain

    Dim AppsXML As String = ""

    Private Sub LoadIPAddress()

        tbxGETURL.Text = "http://" + tbxIPAddr.Text + ":8060/query/apps"
        tbxPOSTURL.Text = "http://" + tbxIPAddr.Text + ":8060/keypress/home"
        tbxCommand.Text = ""

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPOST.Click
        ' WebRequestPOST.Main("http://www.contoso.com/PostAccepter.aspx", "This is a test that posts this string to a Web server.")
        WebRequestPOST.Main(tbxPOSTURL.Text, tbxCommand.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxIPAddr.Text = "192.168.0.16"
        Me.LoadIPAddress()

        btnApps_Click(sender, e)
        ni1.Visible = True
        ni1.BalloonTipTitle = "Roku Remote"
        ni1.BalloonTipText = "Roku remote is now active an running in the background. double click here to see the panel"
        'ni1.ShowBalloonTip(1000)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnGET_Click(sender As Object, e As EventArgs) Handles btnGET.Click
        WebRequestGET.Main(tbxGETURL.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUpdateIP.Click
        Me.LoadIPAddress()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/home", tbxCommand.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/back", tbxCommand.Text)
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/up", tbxCommand.Text)
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/left", tbxCommand.Text)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Select", tbxCommand.Text)
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/right", tbxCommand.Text)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/down", tbxCommand.Text)
    End Sub

    Private Sub btnRev_Click(sender As Object, e As EventArgs) Handles btnRev.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Rev", tbxCommand.Text)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Play", tbxCommand.Text)
    End Sub

    Private Sub btnFwd_Click(sender As Object, e As EventArgs) Handles btnFwd.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Fwd", tbxCommand.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://sdkdocs.roku.com/display/sdkdoc/External+Control+API")
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/poweron", tbxCommand.Text)
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/poweroff", tbxCommand.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dayofweek As String = Now.DayOfWeek.ToString.ToLower
        Dim timeofday As String = "05:30"
        lblTime.Text = Now.DayOfWeek.ToString & ", " & Now.ToLocalTime

        Dim daysstr As String = ""
        If chkMon.Checked Then daysstr &= ".monday"
        If chkTue.Checked Then daysstr &= ".tuesday"
        If chkWed.Checked Then daysstr &= ".wednesday"
        If chkThu.Checked Then daysstr &= ".thursday"
        If chkFri.Checked Then daysstr &= ".friday"
        If chkSat.Checked Then daysstr &= ".saturday"
        If chkSun.Checked Then daysstr &= ".sunday"


        If daysstr.Contains(dayofweek) Then
            lblTime.Text &= ", Alarm is on"
            'lblTime.Text &= ", " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            If Now.Hour = CInt(txtOn.Text.Split(":")(0)) And Now.Minute = CInt(txtOn.Text.Split(":")(1)) And Now.Second > 0 And Now.Second < 2 Then
                btnOn.PerformClick()
            End If

            If Now.Hour = CInt(txtOff.Text.Split(":")(0)) And Now.Minute = CInt(txtOff.Text.Split(":")(1)) And Now.Second > 0 And Now.Second < 2 Then
                btnOff.PerformClick()
            End If
        Else
            lblTime.Text &= ", Alarm is off"
        End If



    End Sub

    Private Sub btnApps_Click(sender As Object, e As EventArgs) Handles btnApps.Click
        WebRequestGET.Main("http://" + tbxIPAddr.Text + ":8060/query/apps")

        Dim doc As New XmlDocument()
        AppsXML = tbxResponse.Text
        doc.LoadXml(AppsXML)

        For Each node As XmlNode In doc
            If (node.NodeType = XmlNodeType.XmlDeclaration) Then
                doc.RemoveChild(node) 'removing the declaration child 
            End If
        Next

        Dim root As XmlNode = doc.FirstChild
        'Display the contents of the child nodes.
        lv1.Items.Clear()
        If root.HasChildNodes Then
            Dim i As Integer
            For i = 0 To root.ChildNodes.Count - 1
                il1.Images.Add(root.ChildNodes(i).InnerText, WebRequestGET.MainImg("http://" + tbxIPAddr.Text + ":8060/query/icon/" + root.ChildNodes(i).Attributes(0).InnerText))
                lv1.Items.Add(root.ChildNodes(i).InnerText, root.ChildNodes(i).InnerText)
            Next i
        End If

    End Sub

    Private Sub lv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged

    End Sub

    Private Sub lv1_DoubleClick(sender As Object, e As EventArgs) Handles lv1.DoubleClick
        Dim doc As New XmlDocument()
        doc.LoadXml(AppsXML)

        For Each node As XmlNode In doc
            If (node.NodeType = XmlNodeType.XmlDeclaration) Then
                doc.RemoveChild(node) 'removing the declaration child 
            End If
        Next

        Dim root As XmlNode = doc.FirstChild
        If root.HasChildNodes Then
            WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/launch/" + root.ChildNodes(lv1.SelectedIndices(0)).Attributes(0).InnerText, tbxCommand.Text)
            'lb1.Items.Add(root.ChildNodes(i).Attributes(0).InnerText & " - " & root.ChildNodes(i).InnerText)
        End If
    End Sub

    Private Sub btnVolumeup_Click(sender As Object, e As EventArgs) Handles btnVolumeup.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/volumeup", tbxCommand.Text)
    End Sub

    Private Sub btnVolumedown_Click(sender As Object, e As EventArgs) Handles btnVolumedown.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/volumedown", tbxCommand.Text)
    End Sub

    Private Sub btnVolumemute_Click(sender As Object, e As EventArgs) Handles btnVolumemute.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/volumemute", tbxCommand.Text)
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
        ni1.ShowBalloonTip(1000)
    End Sub

    Private Sub ni1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ni1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ni1.Visible = False
        End
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ni1.Visible = False
    End Sub
End Class

Public Class WebRequestPOST

    Public Shared Sub Main(URL As String, Optional strCmdData As String = "")
        Try
            ' Create a request using a URL that can receive a post. 
            Dim request As WebRequest = WebRequest.Create(URL)
            ' Set the Method property of the request to POST.
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.
            Dim postData As String = strCmdData
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length
            ' Get the request stream.
            Dim dataStream As Stream = request.GetRequestStream()
            ' Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.
            dataStream.Close()
            ' Get the response.
            Dim response As WebResponse = request.GetResponse()
            ' Display the status.
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            ' Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.
            Dim reader As New StreamReader(dataStream)
            ' Read the content.
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.
            Console.WriteLine(responseFromServer)
            frmMain.tbxResponse.Text = responseFromServer

            ' Clean up the streams.
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
End Class

Public Class WebRequestGET

    Public Shared Function Main(URL As String) As String
        ' Create a request for the URL. 
        Dim request As WebRequest =
          WebRequest.Create(URL)
        ' If required by the server, set the credentials.
        ' request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()

        ' Display the content.
        Console.WriteLine(responseFromServer)
        frmMain.tbxResponse.Text = responseFromServer

        Dim doc As New XmlDocument()
        doc.LoadXml(responseFromServer)

        For Each node As XmlNode In doc
            If (node.NodeType = XmlNodeType.XmlDeclaration) Then
                doc.RemoveChild(node) 'removing the declaration child 
            End If
        Next

        Dim root As XmlNode = doc.FirstChild
        'Display the contents of the child nodes.
        frmMain.lb1.Items.Clear()
        If root.HasChildNodes Then
            Dim i As Integer
            For i = 0 To root.ChildNodes.Count - 1
                frmMain.lb1.Items.Add(root.ChildNodes(i).Attributes(0).InnerText & " - " & root.ChildNodes(i).InnerText)
            Next i
        End If

        'Form1.WebBrowser1.Document = responseFromServer
        'Form1.pbxIcon.Image = responseFromServer
        ' Clean up the streams and the response.
        reader.Close()
        response.Close()

        Return responseFromServer

    End Function

    Public Shared Function MainImg(URL As String) As Image
        ' Create a request for the URL. 
        Dim request As WebRequest =
          WebRequest.Create(URL)
        ' If required by the server, set the credentials.
        ' request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim img As Image = Image.FromStream(dataStream)
        'frmMain.pbxIcon.Image = img

        reader.Close()
        response.Close()

        Return img

    End Function



End Class
