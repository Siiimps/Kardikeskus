<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Kood = New System.Windows.Forms.TextBox()
        Me.TextBox_Enimi = New System.Windows.Forms.TextBox()
        Me.TextBox_Pnimi = New System.Windows.Forms.TextBox()
        Me.TextBox_Epost = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_Lisa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Uudis = New System.Windows.Forms.CheckBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.TextBox_Isik = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.TextBox_Otsi = New System.Windows.Forms.TextBox()
        Me.Button_Otsi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_B10 = New System.Windows.Forms.Button()
        Me.Button_B5 = New System.Windows.Forms.Button()
        Me.Label_Boonus = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_EemaldaPS = New System.Windows.Forms.Button()
        Me.Button_LisaPS = New System.Windows.Forms.Button()
        Me.Button_EemaldaS = New System.Windows.Forms.Button()
        Me.Button_LisaS = New System.Windows.Forms.Button()
        Me.Label_Kood = New System.Windows.Forms.Label()
        Me.Label_Soidud = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label_Klient = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SulgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EksportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpostNimekiriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox_OtsiTabel = New System.Windows.Forms.TextBox()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kood"
        '
        'TextBox_Kood
        '
        Me.TextBox_Kood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Kood.Location = New System.Drawing.Point(78, 20)
        Me.TextBox_Kood.Name = "TextBox_Kood"
        Me.TextBox_Kood.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Kood.TabIndex = 2
        '
        'TextBox_Enimi
        '
        Me.TextBox_Enimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Enimi.Location = New System.Drawing.Point(78, 48)
        Me.TextBox_Enimi.Name = "TextBox_Enimi"
        Me.TextBox_Enimi.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Enimi.TabIndex = 3
        '
        'TextBox_Pnimi
        '
        Me.TextBox_Pnimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Pnimi.Location = New System.Drawing.Point(78, 76)
        Me.TextBox_Pnimi.Name = "TextBox_Pnimi"
        Me.TextBox_Pnimi.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Pnimi.TabIndex = 4
        '
        'TextBox_Epost
        '
        Me.TextBox_Epost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Epost.Location = New System.Drawing.Point(78, 104)
        Me.TextBox_Epost.Name = "TextBox_Epost"
        Me.TextBox_Epost.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Epost.TabIndex = 5
        '
        'TextBox_Telefon
        '
        Me.TextBox_Telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Telefon.Location = New System.Drawing.Point(78, 132)
        Me.TextBox_Telefon.Name = "TextBox_Telefon"
        Me.TextBox_Telefon.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Telefon.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Eesnimi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Perenimi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "E-post"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefon"
        '
        'Button_Lisa
        '
        Me.Button_Lisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_Lisa.Location = New System.Drawing.Point(13, 214)
        Me.Button_Lisa.Name = "Button_Lisa"
        Me.Button_Lisa.Size = New System.Drawing.Size(104, 23)
        Me.Button_Lisa.TabIndex = 8
        Me.Button_Lisa.Text = "Lisa"
        Me.Button_Lisa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_Uudis)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.Button_Delete)
        Me.GroupBox1.Controls.Add(Me.TextBox_Isik)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button_Update)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Pnimi)
        Me.GroupBox1.Controls.Add(Me.Button_Lisa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Kood)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_Telefon)
        Me.GroupBox1.Controls.Add(Me.TextBox_Epost)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_Enimi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(243, 279)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lisamine / Muutmine"
        '
        'CheckBox_Uudis
        '
        Me.CheckBox_Uudis.AutoSize = True
        Me.CheckBox_Uudis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.CheckBox_Uudis.Location = New System.Drawing.Point(13, 188)
        Me.CheckBox_Uudis.Name = "CheckBox_Uudis"
        Me.CheckBox_Uudis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_Uudis.Size = New System.Drawing.Size(79, 20)
        Me.CheckBox_Uudis.TabIndex = 13
        Me.CheckBox_Uudis.Text = "Uudiskiri"
        Me.CheckBox_Uudis.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_Clear.Location = New System.Drawing.Point(13, 243)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(104, 23)
        Me.Button_Clear.TabIndex = 12
        Me.Button_Clear.Text = "Tühjenda"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(123, 243)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(104, 23)
        Me.Button_Delete.TabIndex = 10
        Me.Button_Delete.Text = "Kustuta"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'TextBox_Isik
        '
        Me.TextBox_Isik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Isik.Location = New System.Drawing.Point(78, 160)
        Me.TextBox_Isik.Name = "TextBox_Isik"
        Me.TextBox_Isik.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_Isik.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Isikukood"
        '
        'Button_Update
        '
        Me.Button_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_Update.Location = New System.Drawing.Point(123, 214)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(104, 23)
        Me.Button_Update.TabIndex = 9
        Me.Button_Update.Text = "Uuenda"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'TextBox_Otsi
        '
        Me.TextBox_Otsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox_Otsi.Location = New System.Drawing.Point(12, 27)
        Me.TextBox_Otsi.Name = "TextBox_Otsi"
        Me.TextBox_Otsi.Size = New System.Drawing.Size(166, 31)
        Me.TextBox_Otsi.TabIndex = 1
        '
        'Button_Otsi
        '
        Me.Button_Otsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_Otsi.Location = New System.Drawing.Point(184, 26)
        Me.Button_Otsi.Name = "Button_Otsi"
        Me.Button_Otsi.Size = New System.Drawing.Size(71, 31)
        Me.Button_Otsi.TabIndex = 12
        Me.Button_Otsi.Text = "Otsi"
        Me.Button_Otsi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label_Boonus)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label_Kood)
        Me.GroupBox2.Controls.Add(Me.Label_Soidud)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label_ID)
        Me.GroupBox2.Controls.Add(Me.Label_Klient)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 26)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 317)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Klient"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_B10)
        Me.GroupBox4.Controls.Add(Me.Button_B5)
        Me.GroupBox4.Location = New System.Drawing.Point(153, 252)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(141, 57)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Boonuspunktid"
        '
        'Button_B10
        '
        Me.Button_B10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_B10.Location = New System.Drawing.Point(73, 19)
        Me.Button_B10.Name = "Button_B10"
        Me.Button_B10.Size = New System.Drawing.Size(61, 33)
        Me.Button_B10.TabIndex = 4
        Me.Button_B10.Text = "- 10"
        Me.Button_B10.UseVisualStyleBackColor = True
        '
        'Button_B5
        '
        Me.Button_B5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_B5.Location = New System.Drawing.Point(6, 19)
        Me.Button_B5.Name = "Button_B5"
        Me.Button_B5.Size = New System.Drawing.Size(61, 33)
        Me.Button_B5.TabIndex = 8
        Me.Button_B5.Text = "- 5"
        Me.Button_B5.UseVisualStyleBackColor = True
        '
        'Label_Boonus
        '
        Me.Label_Boonus.AutoSize = True
        Me.Label_Boonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_Boonus.Location = New System.Drawing.Point(164, 117)
        Me.Label_Boonus.Name = "Label_Boonus"
        Me.Label_Boonus.Size = New System.Drawing.Size(19, 25)
        Me.Label_Boonus.TabIndex = 13
        Me.Label_Boonus.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Boonuspunktid:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Kood:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Isikukood:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_EemaldaPS)
        Me.GroupBox3.Controls.Add(Me.Button_LisaPS)
        Me.GroupBox3.Controls.Add(Me.Button_EemaldaS)
        Me.GroupBox3.Controls.Add(Me.Button_LisaS)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(141, 96)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sõidud"
        '
        'Button_EemaldaPS
        '
        Me.Button_EemaldaPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_EemaldaPS.Location = New System.Drawing.Point(6, 58)
        Me.Button_EemaldaPS.Name = "Button_EemaldaPS"
        Me.Button_EemaldaPS.Size = New System.Drawing.Size(61, 33)
        Me.Button_EemaldaPS.TabIndex = 10
        Me.Button_EemaldaPS.Text = "- 0.5"
        Me.Button_EemaldaPS.UseVisualStyleBackColor = True
        '
        'Button_LisaPS
        '
        Me.Button_LisaPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_LisaPS.Location = New System.Drawing.Point(7, 19)
        Me.Button_LisaPS.Name = "Button_LisaPS"
        Me.Button_LisaPS.Size = New System.Drawing.Size(61, 33)
        Me.Button_LisaPS.TabIndex = 9
        Me.Button_LisaPS.Text = "+ 0.5"
        Me.Button_LisaPS.UseVisualStyleBackColor = True
        '
        'Button_EemaldaS
        '
        Me.Button_EemaldaS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_EemaldaS.Location = New System.Drawing.Point(74, 58)
        Me.Button_EemaldaS.Name = "Button_EemaldaS"
        Me.Button_EemaldaS.Size = New System.Drawing.Size(61, 33)
        Me.Button_EemaldaS.TabIndex = 8
        Me.Button_EemaldaS.Text = "- 1"
        Me.Button_EemaldaS.UseVisualStyleBackColor = True
        '
        'Button_LisaS
        '
        Me.Button_LisaS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button_LisaS.Location = New System.Drawing.Point(74, 19)
        Me.Button_LisaS.Name = "Button_LisaS"
        Me.Button_LisaS.Size = New System.Drawing.Size(61, 33)
        Me.Button_LisaS.TabIndex = 4
        Me.Button_LisaS.Text = "+ 1"
        Me.Button_LisaS.UseVisualStyleBackColor = True
        '
        'Label_Kood
        '
        Me.Label_Kood.AutoSize = True
        Me.Label_Kood.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_Kood.Location = New System.Drawing.Point(164, 16)
        Me.Label_Kood.Name = "Label_Kood"
        Me.Label_Kood.Size = New System.Drawing.Size(19, 25)
        Me.Label_Kood.TabIndex = 7
        Me.Label_Kood.Text = "-"
        '
        'Label_Soidud
        '
        Me.Label_Soidud.AutoSize = True
        Me.Label_Soidud.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_Soidud.Location = New System.Drawing.Point(164, 91)
        Me.Label_Soidud.Name = "Label_Soidud"
        Me.Label_Soidud.Size = New System.Drawing.Size(19, 25)
        Me.Label_Soidud.TabIndex = 6
        Me.Label_Soidud.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sõite kokku:"
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_ID.Location = New System.Drawing.Point(164, 66)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(19, 25)
        Me.Label_ID.TabIndex = 3
        Me.Label_ID.Text = "-"
        '
        'Label_Klient
        '
        Me.Label_Klient.AutoSize = True
        Me.Label_Klient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_Klient.Location = New System.Drawing.Point(164, 41)
        Me.Label_Klient.Name = "Label_Klient"
        Me.Label_Klient.Size = New System.Drawing.Size(19, 25)
        Me.Label_Klient.TabIndex = 1
        Me.Label_Klient.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Klient:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(684, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FailToolStripMenuItem
        '
        Me.FailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SulgeToolStripMenuItem, Me.EksportToolStripMenuItem, Me.LogidToolStripMenuItem})
        Me.FailToolStripMenuItem.Name = "FailToolStripMenuItem"
        Me.FailToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FailToolStripMenuItem.Text = "Fail"
        '
        'SulgeToolStripMenuItem
        '
        Me.SulgeToolStripMenuItem.Name = "SulgeToolStripMenuItem"
        Me.SulgeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SulgeToolStripMenuItem.Text = "Sulge"
        '
        'EksportToolStripMenuItem
        '
        Me.EksportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EpostNimekiriToolStripMenuItem})
        Me.EksportToolStripMenuItem.Name = "EksportToolStripMenuItem"
        Me.EksportToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EksportToolStripMenuItem.Text = "Eksport"
        '
        'EpostNimekiriToolStripMenuItem
        '
        Me.EpostNimekiriToolStripMenuItem.Name = "EpostNimekiriToolStripMenuItem"
        Me.EpostNimekiriToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EpostNimekiriToolStripMenuItem.Text = "Eposti nimekiri"
        '
        'LogidToolStripMenuItem
        '
        Me.LogidToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvaToolStripMenuItem})
        Me.LogidToolStripMenuItem.Name = "LogidToolStripMenuItem"
        Me.LogidToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LogidToolStripMenuItem.Text = "Logid"
        '
        'AvaToolStripMenuItem
        '
        Me.AvaToolStripMenuItem.Name = "AvaToolStripMenuItem"
        Me.AvaToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.AvaToolStripMenuItem.Text = "Ava"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(960, 185)
        Me.DataGridView1.TabIndex = 15
        '
        'TextBox_OtsiTabel
        '
        Me.TextBox_OtsiTabel.Location = New System.Drawing.Point(101, 551)
        Me.TextBox_OtsiTabel.Name = "TextBox_OtsiTabel"
        Me.TextBox_OtsiTabel.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_OtsiTabel.TabIndex = 17
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label_Version.Location = New System.Drawing.Point(891, 554)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(81, 13)
        Me.Label_Version.TabIndex = 18
        Me.Label_Version.Text = "Version: 0.0.0.0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 554)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Otsi eesnime"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label14.Location = New System.Drawing.Point(778, 554)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Autor: Siim Lehismets"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 582)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.TextBox_OtsiTabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_Otsi)
        Me.Controls.Add(Me.TextBox_Otsi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 620)
        Me.MinimumSize = New System.Drawing.Size(1000, 620)
        Me.Name = "Form1"
        Me.Text = "Kardikeskus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents TextBox_Kood As TextBox
	Friend WithEvents TextBox_Enimi As TextBox
	Friend WithEvents TextBox_Pnimi As TextBox
	Friend WithEvents TextBox_Epost As TextBox
	Friend WithEvents TextBox_Telefon As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button_Lisa As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TextBox_Otsi As TextBox
	Friend WithEvents Button_Otsi As Button
	Friend WithEvents TextBox_Isik As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Button_Delete As Button
	Friend WithEvents Button_Update As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label_Klient As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label_ID As Label
	Friend WithEvents Label_Soidud As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Button_LisaS As Button
	Friend WithEvents Label_Kood As Label
	Friend WithEvents Button_EemaldaS As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Button_Clear As Button
	Friend WithEvents CheckBox_Uudis As CheckBox
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FailToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SulgeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EksportToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EpostNimekiriToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label_Boonus As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents Button_B5 As Button
	Friend WithEvents Button_B10 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button_LisaPS As Button
	Friend WithEvents Button_EemaldaPS As Button
	Friend WithEvents TextBox_OtsiTabel As TextBox
	Friend WithEvents LogidToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AvaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label_Version As Label
	Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
