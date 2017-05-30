Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim mySqlConn As MySqlConnection
    Dim sqlConnectString As String = "server=localhost;userid=root;password=;database=kardikeskus"
    'Dim sqlConnectString As String = "server=localhost;userid=root;password=npUka91cCDwM5OjR;database=kardikeskus"
    Dim COMMAND As MySqlCommand

	Private Sub otsiKlient(kood As String)
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader
		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM kardikeskus.kliendid WHERE kood='" & kood & "'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While
			If count > 0 Then
				'laeTabel(READER.GetString("kood"))
				TextBox_Kood.Enabled = False
				TextBox_Kood.Text = READER.GetString("kood")
				TextBox_Enimi.Text = READER.GetString("enimi")
				TextBox_Pnimi.Text = READER.GetString("pnimi")
				TextBox_Epost.Text = READER.GetString("epost")
				TextBox_Telefon.Text = READER.GetString("telefon")
				TextBox_Isik.Text = READER.GetString("isikukood")
				If READER.GetInt32("uudiskiri") = 1 Then
					CheckBox_Uudis.Checked = True
				Else
					CheckBox_Uudis.Checked = False
				End If
			Else
				MessageBox.Show("Klienti ei leitud andmebaasist!")
				clearBoxes()
			End If
			mySqlConn.Close()
			TextBox_Otsi.Text = ""
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "otsiKlient", "", "", "")
		Finally
			mySqlConn.Dispose()
			updateInfo()
		End Try
	End Sub

	Private Sub clearBoxes()
		EDButtons(False)
		TextBox_Kood.Enabled = True
		TextBox_Kood.Text = ""
		TextBox_Enimi.Text = ""
		TextBox_Pnimi.Text = ""
		TextBox_Epost.Text = ""
		TextBox_Telefon.Text = ""
		TextBox_Isik.Text = ""
		CheckBox_Uudis.Checked = False
		Label_Kood.Text = "-"
		Label_Klient.Text = "-"
		Label_ID.Text = "-"
		Label_Soidud.Text = "-"
		Label_Boonus.Text = "-"
		TextBox_Otsi.Select()
	End Sub

	Private Sub EDButtons(state As Boolean)
		Dim buttons As Button() = {Button_LisaS, Button_LisaPS, Button_EemaldaS, Button_EemaldaPS, Button_B10, Button_B5}

		For Each b As Button In buttons
			If state = True Then
				b.Enabled = True
			Else
				b.Enabled = False
			End If
		Next
	End Sub

	Private Sub updateInfo()
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader

		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM kardikeskus.kliendid WHERE kood='" & TextBox_Kood.Text & "'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While
			If count > 0 Then
				EDButtons(True)
				Label_Kood.Text = READER.GetString("kood")
				Label_Klient.Text = READER.GetString("enimi") & " " & READER.GetString("pnimi")
				Label_ID.Text = READER.GetString("isikukood")
				Label_Soidud.Text = READER.GetString("soidud")
				Label_Boonus.Text = READER.GetString("boonus")
			Else
				'clearBoxes()
				'MessageBox.Show("Klienti ei leitud andmebaasist!")
			End If
			mySqlConn.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "updateInfo", "", "", "")
		Finally
			mySqlConn.Close()
			mySqlConn.Dispose()
		End Try
		TextBox_Otsi.Select()
	End Sub

	Private Sub eemaldaBoonus(kogus As Double)
        mySqlConn = New MySqlConnection With {
                .ConnectionString = sqlConnectString
            }
        Dim READER As MySqlDataReader

		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT soidud,boonus FROM kardikeskus.kliendid WHERE kood='" & Label_Kood.Text & "'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While
			Dim boonus As Double
			boonus = READER.GetDouble("boonus")
			mySqlConn.Close()
			If count > 0 Then
				If boonus < kogus Then
					MessageBox.Show("Kliendil on liiga vähe boonuspunkte")
				Else
					boonus = boonus - kogus
					If boonus <= 0 Then
						boonus = 0
					End If
					Dim boonusText As String = boonus.ToString()
					boonusText = boonusText.Replace(",", ".")
					mySqlConn.Open()
					Query = "UPDATE kardikeskus.kliendid SET boonus='" & boonusText & "' WHERE kood='" & Label_Kood.Text & "'"
					COMMAND = New MySqlCommand(Query, mySqlConn)
					READER = COMMAND.ExecuteReader
					Logi("Message", "", "Eemaldatud", Label_Kood.Text, "", kogus.ToString())
					mySqlConn.Close()
				End If
			Else
				MessageBox.Show("Error (E)")
			End If
			mySqlConn.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "eemaldaBoonus", "", "", "")
		Finally
			mySqlConn.Close()
			mySqlConn.Dispose()
			updateInfo()
			laeTabel("", "")
		End Try
	End Sub

	Private Sub lisaSoit(soidudArv As Integer, boonusArv As Double)
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader

		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT soidud,boonus FROM kardikeskus.kliendid WHERE kood='" & Label_Kood.Text & "'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While
			Dim soidud As Integer
			Dim boonus As Double
			soidud = READER.GetInt32("soidud")
			boonus = READER.GetDouble("boonus")
			mySqlConn.Close()
			If count > 0 Then
				soidud = soidud + soidudArv
				boonus = boonus + boonusArv
				Dim boonusText As String = boonus.ToString()
				boonusText = boonusText.Replace(",", ".")
				mySqlConn.Open()
				Query = "UPDATE kardikeskus.kliendid SET soidud='" & soidud & "',boonus='" & boonusText & "' WHERE kood='" & Label_Kood.Text & "'"
				COMMAND = New MySqlCommand(Query, mySqlConn)
				READER = COMMAND.ExecuteReader
				Logi("Message", "", "Lisatud", Label_Kood.Text, soidudArv, boonusArv)
				mySqlConn.Close()
			Else
				MessageBox.Show("Error (L)")
			End If
			mySqlConn.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "lisaSoit", "", "", "")
		Finally
			mySqlConn.Close()
			mySqlConn.Dispose()
			updateInfo()
			laeTabel("", "")
		End Try
	End Sub

	Private Sub eemaldaSoit(soidudArv As Integer, boonusArv As Double)
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader

		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT soidud,boonus FROM kardikeskus.kliendid WHERE kood='" & Label_Kood.Text & "'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While
			Dim soidud As Integer
			Dim boonus As Double
			soidud = READER.GetInt32("soidud")
			boonus = READER.GetDouble("boonus")
			mySqlConn.Close()
			If count > 0 Then

				If boonus < boonusArv Then
					MessageBox.Show("Kliendil on liiga vähe boonuspunkte")
				Else
					soidud = soidud - soidudArv
					boonus = boonus - boonusArv
					If soidud <= 0 Then
						soidud = 0
					End If
					If boonus <= 0 Then
						boonus = 0
					End If
					Dim boonusText As String = boonus.ToString()
					boonusText = boonusText.Replace(",", ".")
					mySqlConn.Open()
					Query = "UPDATE kardikeskus.kliendid SET soidud='" & soidud & "',boonus='" & boonusText & "' WHERE kood='" & Label_Kood.Text & "'"
					COMMAND = New MySqlCommand(Query, mySqlConn)
					READER = COMMAND.ExecuteReader
					Logi("Message", "", "Eemaldatud", Label_Kood.Text, soidudArv, boonusArv)
					mySqlConn.Close()
				End If
			Else
				MessageBox.Show("Error (E)")
			End If
			mySqlConn.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "eemaldaSoit", "", "", "")
		Finally
			mySqlConn.Close()
			mySqlConn.Dispose()
			updateInfo()
			laeTabel("", "")
		End Try
	End Sub

	Private Sub laeTabel(kood As String, filter As String)
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			mySqlConn.Open()
			Dim Query As String
			If (kood = "") Then
                Query = "SELECT id as 'Nr',kood as 'Kood',enimi as 'Eesnimi',pnimi as 'Perenimi',epost as 'E-post',telefon as 'Telefon',isikukood as 'Isikukood',uudiskiri as 'Uudiskiri',soidud as 'S6idud kokku',boonus as 'Boonuspunkte' FROM kardikeskus.kliendid"
            Else
                Query = "SELECT id,kood,enimi,pnimi,epost,telefon,isikukood,uudiskiri,soidud,boonus FROM kardikeskus.kliendid WHERE kood='" & kood & "'"
            End If
			'Query = "SELECT kood,enimi,pnimi,epost,telefon,isikukood,uudiskiri,soidud,boonus FROM kardikeskus.kliendid"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			SDA.SelectCommand = COMMAND
			SDA.Fill(dbDataSet)
			bSource.DataSource = dbDataSet
			DataGridView1.DataSource = bSource
			SDA.Update(dbDataSet)
			If filter = "" Then
			Else
				Dim DV As New DataView(dbDataSet)
				DV.RowFilter = String.Format("Eesnimi Like '%" & filter & "%'")
				DataGridView1.DataSource = DV
			End If
			mySqlConn.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
            mySqlConn.Close()
            'DataGridView Tulpade Laiused
            '0 = id, 1 = kood, 2 = enimi, 3 = pnimi, 4 = epost, 5 = telefon, 6 = isikukood, 7 = uudiskiri, 8 = soidud, 9 = boonus
            DataGridView1.Columns(0).Width = 40
            DataGridView1.Columns(1).Width = 60
            DataGridView1.Columns(4).Width = 120
            DataGridView1.Columns(7).Width = 80
            DataGridView1.Columns(8).Width = 80
            DataGridView1.Columns(9).Width = 80
        End Try
	End Sub

	Private Sub Logi(type As String, message As String, action As String, kood As String, soidud As String, boonus As String)
		Try
			Dim aeg As String = DateTime.Now.ToString()
			Dim LogMessage As String

			If type = "Error" Then
				LogMessage = aeg & " - Action:" & action & " - Message:" & message
			ElseIf type = "Message" Then
				LogMessage = aeg & " - " & "(" & kood & ") - " & action & " - S:" & soidud & " B:" & boonus
			ElseIf type = "Open" Then
				LogMessage = aeg & " - Kliendikaartiprogramm avatud"
			ElseIf type = "Client" Then
				LogMessage = aeg & " - " & "(" & kood & ") - " & action
			Else

			End If

			Using outputFile As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\kardikeskus_log.txt", True)
				outputFile.WriteLine(LogMessage)
			End Using

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Label_Version.Text = "Version: " & Application.ProductVersion.ToArray()
        EDButtons(False)
		laeTabel("", "")
        Logi("Open", "", "", "", "", "")
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Logi("Error", ex.Message, "Load", "", "", "")
        Finally
            mySqlConn.Dispose()
		End Try

	End Sub

	Private Sub Button_Lisa_Click(sender As Object, e As EventArgs) Handles Button_Lisa.Click
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader
		If TextBox_Kood.Text = "" Or TextBox_Enimi.Text = "" Or TextBox_Pnimi.Text = "" Then
			MessageBox.Show("Kood, Eesnimi ja Perenimi peavad olemas sisestatud", "Error", MessageBoxButtons.OK)
		Else
			Try
				mySqlConn.Open()
				Dim Query As String
				If TextBox_Isik.Text = "" Then
					Query = "SELECT * FROM kardikeskus.kliendid WHERE kood='" & TextBox_Kood.Text & "' OR epost='" & TextBox_Epost.Text & "'"
				Else
					Query = "SELECT * FROM kardikeskus.kliendid WHERE isikukood='" & TextBox_Isik.Text & "' OR epost='" & TextBox_Epost.Text & "' OR kood='" & TextBox_Kood.Text & "'"
				End If
				COMMAND = New MySqlCommand(Query, mySqlConn)
				READER = COMMAND.ExecuteReader
				Dim count As Integer
				count = 0
				While READER.Read
					count = count + 1
				End While
				mySqlConn.Close()
				If count > 0 Then
					MessageBox.Show("Klient on juba andmebaasis")
					mySqlConn.Close()
				Else
                    mySqlConn.Open()
                    Dim uudiskiri As Integer
                    If CheckBox_Uudis.Checked = True Then
                        uudiskiri = 1
                    Else
                        uudiskiri = 0
                    End If
                    Query = "INSERT INTO kardikeskus.kliendid (kood,enimi,pnimi,epost,telefon,isikukood,uudiskiri) VALUES 
('" & TextBox_Kood.Text & "','" & TextBox_Enimi.Text & "','" & TextBox_Pnimi.Text & "','" & TextBox_Epost.Text & "','" & TextBox_Telefon.Text & "','" & TextBox_Isik.Text & "','" & uudiskiri & "')"
                    COMMAND = New MySqlCommand(Query, mySqlConn)
					READER = COMMAND.ExecuteReader
					MessageBox.Show("Klient lisatud andmebaasi")
					Logi("Client", "", "Klient lisatud", TextBox_Kood.Text, "", "")
					mySqlConn.Close()

				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Logi("Error", ex.Message, "Button_Lisa", "", "", "")
			Finally
				mySqlConn.Dispose()

			End Try
		End If
		TextBox_Kood.Enabled = False
		updateInfo()
		laeTabel("", "")
	End Sub

	Private Sub TextBox_Otsi_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Otsi.KeyDown
		If e.KeyCode = Keys.Enter Then
			otsiKlient(TextBox_Otsi.Text)
		End If
	End Sub

	Private Sub Button_Otsi_Click(sender As Object, e As EventArgs) Handles Button_Otsi.Click
		otsiKlient(TextBox_Otsi.Text)
	End Sub

	Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader
		If TextBox_Kood.Text = "" Or TextBox_Enimi.Text = "" Or TextBox_Pnimi.Text = "" Then
			MessageBox.Show("Kood, Eesnimi ja Perenimi peavad olemas sisestatud", "Error", MessageBoxButtons.OK)
		Else
			Try
				mySqlConn.Open()
				Dim Query As String
				Query = "SELECT * FROM kardikeskus.kliendid WHERE kood='" & TextBox_Kood.Text & "'"
				COMMAND = New MySqlCommand(Query, mySqlConn)
				READER = COMMAND.ExecuteReader
				Dim count As Integer
				count = 0
				While READER.Read
					count = count + 1
				End While
				mySqlConn.Close()
				If count > 0 Then
					mySqlConn.Open()
					Query = "SELECT * FROM kardikeskus.kliendid WHERE isikukood='" & TextBox_Isik.Text & "' OR epost='" & TextBox_Epost.Text & "' OR telefon='" & TextBox_Telefon.Text & "'"
					COMMAND = New MySqlCommand(Query, mySqlConn)
					READER = COMMAND.ExecuteReader
					count = 0
					While READER.Read
						If READER.GetString("kood") = TextBox_Kood.Text Then

						Else
							count = count + 1
						End If
					End While
					mySqlConn.Close()
					If count > 0 Then
						MessageBox.Show("Epost, Isikukood või Telefon on juba andmebaasis")
					Else
						mySqlConn.Open()
						If CheckBox_Uudis.Checked = True Then
							Query = "UPDATE kardikeskus.kliendid SET enimi='" & TextBox_Enimi.Text & "',pnimi='" & TextBox_Pnimi.Text & "',epost='" & TextBox_Epost.Text & "',telefon='" & TextBox_Telefon.Text & "',isikukood='" & TextBox_Isik.Text & "',uudiskiri='1' WHERE kood='" & TextBox_Kood.Text & "'"
						Else
							Query = "UPDATE kardikeskus.kliendid SET enimi='" & TextBox_Enimi.Text & "',pnimi='" & TextBox_Pnimi.Text & "',epost='" & TextBox_Epost.Text & "',telefon='" & TextBox_Telefon.Text & "',isikukood='" & TextBox_Isik.Text & "',uudiskiri='0' WHERE kood='" & TextBox_Kood.Text & "'"
						End If
						'Query = "UPDATE kardikeskus.kliendid SET enimi='" & TextBox_Enimi.Text & "',pnimi='" & TextBox_Pnimi.Text & "',epost='" & TextBox_Epost.Text & "',telefon='" & TextBox_Telefon.Text & "',isikukood='" & TextBox_Isik.Text & "' WHERE kood='" & TextBox_Kood.Text & "'"
						COMMAND = New MySqlCommand(Query, mySqlConn)
						READER = COMMAND.ExecuteReader
						MessageBox.Show("Kliendi (" & TextBox_Kood.Text & ") andmed muudetud")
						Logi("Client", "", "Kliendi andmed uuendatud", TextBox_Kood.Text, "", "")
						mySqlConn.Close()

					End If
				Else
					MessageBox.Show("Koodi (" & TextBox_Kood.Text & ") ei leitud andmebaasist")
					mySqlConn.Close()
				End If
				mySqlConn.Close()

			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Logi("Error", ex.Message, "Button_Update", "", "", "")
			Finally
				mySqlConn.Dispose()
				updateInfo()
				laeTabel("", "")
			End Try
		End If
	End Sub

	Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
		Dim result As Integer = MessageBox.Show("Kas soovite kasutaja (" & TextBox_Kood.Text & ") kustutada?", "Kustuta", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
            mySqlConn = New MySqlConnection With {
                .ConnectionString = sqlConnectString
            }
            Dim READER As MySqlDataReader

			Try
				mySqlConn.Open()
				Dim Query As String
				Query = "SELECT * FROM kardikeskus.kliendid WHERE kood='" & TextBox_Kood.Text & "'"
				COMMAND = New MySqlCommand(Query, mySqlConn)
				READER = COMMAND.ExecuteReader
				Dim count As Integer
				count = 0
				While READER.Read
					count = count + 1
				End While
				mySqlConn.Close()
				If count > 0 Then
					mySqlConn.Open()
					Query = "DELETE FROM kardikeskus.kliendid WHERE kood='" & TextBox_Kood.Text & "'"
					COMMAND = New MySqlCommand(Query, mySqlConn)
					READER = COMMAND.ExecuteReader
					MessageBox.Show("Klient (" & TextBox_Kood.Text & ") kustutatud")
					Logi("Client", "", "Klient kustutatud", TextBox_Kood.Text, "", "")
					clearBoxes()
					mySqlConn.Close()
				Else
					MessageBox.Show("Koodi (" & TextBox_Kood.Text & ") ei leitud andmebaasist")
					mySqlConn.Close()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Logi("Error", ex.Message, "Button_Delete", "", "", "")
			Finally
				mySqlConn.Dispose()
				laeTabel("", "")
			End Try
		End If
	End Sub

	Private Sub Button_LisaS_Click(sender As Object, e As EventArgs) Handles Button_LisaS.Click
		lisaSoit(1, 1)
	End Sub

	Private Sub Button_LisaPS_Click(sender As Object, e As EventArgs) Handles Button_LisaPS.Click
		lisaSoit(1, 0.5)
	End Sub

	Private Sub Button_EemaldaS_Click(sender As Object, e As EventArgs) Handles Button_EemaldaS.Click
		Dim result As Integer = MessageBox.Show("Kas soovite eemaldada ühe sõidu ja boonuspunktid?", "Eemalda sõit", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			eemaldaSoit(1, 1)
		End If
	End Sub

	Private Sub Button_EemaldaPS_Click(sender As Object, e As EventArgs) Handles Button_EemaldaPS.Click
		Dim result As Integer = MessageBox.Show("Kas soovite eemaldada ühe sõidu ja boonuspunktid?", "Eemalda sõit", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			eemaldaSoit(1, 0.5)
		End If
	End Sub

	Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
		clearBoxes()
	End Sub

	Private Sub EpostNimekiriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EpostNimekiriToolStripMenuItem.Click
        mySqlConn = New MySqlConnection With {
            .ConnectionString = sqlConnectString
        }
        Dim READER As MySqlDataReader
		Dim epost As New List(Of String)()
		Dim epostString As String

		Try
			mySqlConn.Open()
			Dim Query As String
			Query = "SELECT epost FROM kardikeskus.kliendid WHERE uudiskiri='1'"
			COMMAND = New MySqlCommand(Query, mySqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				epost.Add(READER.GetString("epost"))
				count = count + 1
			End While
			Try
				epostString = String.Join(";", epost)
				Using outputFile As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\epost_list.txt")
					outputFile.Write(epostString)
				End Using

			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

			mySqlConn.Close()

		Catch ex As Exception
			MessageBox.Show(ex.Message)
			Logi("Error", ex.Message, "Epost", "", "", "")
		Finally
			mySqlConn.Dispose()
		End Try
		Dim epost_file As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString() & "\epost_list.txt"
		If System.IO.File.Exists(epost_file) = True Then
			Process.Start(epost_file)
		Else
			MessageBox.Show("Eposti faili ei leitud")
		End If
	End Sub

	Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
		Dim result As Integer = MessageBox.Show("Kas soovite programmi sulgeda?", "Sulge", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub Button_B5_Click(sender As Object, e As EventArgs) Handles Button_B5.Click
		Dim result As Integer = MessageBox.Show("Kas soovite eemaldada 5 boonuspunkti?", "Eemalda boonuspunkte", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			eemaldaBoonus(5)
		End If
	End Sub

	Private Sub Button_B10_Click(sender As Object, e As EventArgs) Handles Button_B10.Click
		Dim result As Integer = MessageBox.Show("Kas soovite eemaldada 10 boonuspunkti?", "Eemalda boonuspunkte", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			eemaldaBoonus(10)
		End If
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex = 1 Then
            Try
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                otsiKlient(row.Cells("kood").Value.ToString)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        TextBox_Otsi.Select()
	End Sub

	Private Sub TextBox_OtsiTabel_TextChanged(sender As Object, e As EventArgs) Handles TextBox_OtsiTabel.TextChanged
		laeTabel("", TextBox_OtsiTabel.Text)
	End Sub

	Private Sub AvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvaToolStripMenuItem.Click
		Dim Logifail As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString() & "\kardikeskus_log.txt"

		If System.IO.File.Exists(Logifail) = True Then
			Process.Start(Logifail)
		Else
			MessageBox.Show("Logifaili ei leitud")
		End If
	End Sub
End Class