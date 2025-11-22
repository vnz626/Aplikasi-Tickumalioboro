
Partial Class Beli1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beli1))
        Label1 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label12 = New Label()
        Label13 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        jumlah = New RichTextBox()
        PictureBox7 = New PictureBox()
        Label3 = New Label()
        tanggal = New DateTimePicker()
        Panel1 = New Panel()
        beli = New Button()
        total = New Label()
        wisata = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nexa Bold", 24.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(476, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 39)
        Label1.TabIndex = 30
        Label1.Text = "Tiket"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Nexa Bold", 24.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(476, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 39)
        Label2.TabIndex = 29
        Label2.Text = "Beli"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(330, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 134)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-6, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(924, 298)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.LightGray
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(165, 254)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(32, 33)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 53
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.LightGray
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(165, 193)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(32, 33)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 52
        PictureBox6.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Nexa Light", 10.0F, FontStyle.Italic)
        Label12.ForeColor = Color.Goldenrod
        Label12.Location = New Point(202, 234)
        Label12.Name = "Label12"
        Label12.Size = New Size(62, 17)
        Label12.TabIndex = 51
        Label12.Text = "No. Telp"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Nexa Light", 10.0F, FontStyle.Italic)
        Label13.ForeColor = Color.Goldenrod
        Label13.Location = New Point(202, 173)
        Label13.Name = "Label13"
        Label13.Size = New Size(49, 17)
        Label13.TabIndex = 50
        Label13.Text = "Nama"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.LightGray
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(166, 451)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(32, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 47
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.LightGray
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(166, 317)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(32, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 46
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Nexa Light", 10.0F, FontStyle.Italic)
        Label9.ForeColor = Color.Goldenrod
        Label9.Location = New Point(203, 431)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 17)
        Label9.TabIndex = 45
        Label9.Text = "Jumlah Tiket"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Nexa Light", 10.0F, FontStyle.Italic)
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(203, 297)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 17)
        Label8.TabIndex = 44
        Label8.Text = "Wisata"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(356, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 43
        ' 
        ' jumlah
        ' 
        jumlah.BackColor = SystemColors.ControlLight
        jumlah.Location = New Point(204, 451)
        jumlah.Name = "jumlah"
        jumlah.Size = New Size(211, 33)
        jumlah.TabIndex = 42
        jumlah.Text = ""
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.LightGray
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(166, 383)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(32, 33)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 55
        PictureBox7.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Nexa Light", 10.0F, FontStyle.Italic)
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(203, 363)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 17)
        Label3.TabIndex = 54
        Label3.Text = "Tanggal"
        ' 
        ' tanggal
        ' 
        tanggal.CalendarMonthBackground = SystemColors.ControlLight
        tanggal.CalendarTitleBackColor = SystemColors.AppWorkspace
        tanggal.Location = New Point(205, 387)
        tanggal.Name = "tanggal"
        tanggal.Size = New Size(212, 23)
        tanggal.TabIndex = 56
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(beli)
        Panel1.Controls.Add(total)
        Panel1.Location = New Point(514, 387)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(246, 97)
        Panel1.TabIndex = 57
        ' 
        ' beli
        ' 
        beli.BackColor = Color.PeachPuff
        beli.Font = New Font("Nexa Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        beli.Location = New Point(20, 53)
        beli.Name = "beli"
        beli.Size = New Size(64, 29)
        beli.TabIndex = 1
        beli.Text = "Beli"
        beli.UseVisualStyleBackColor = False
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Nexa Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total.ForeColor = Color.Goldenrod
        total.Location = New Point(20, 14)
        total.Name = "total"
        total.Size = New Size(76, 20)
        total.TabIndex = 0
        total.Text = "Total: Rp"
        ' 
        ' wisata
        ' 
        wisata.FormattingEnabled = True
        wisata.Location = New Point(204, 322)
        wisata.Name = "wisata"
        wisata.Size = New Size(210, 23)
        wisata.TabIndex = 58
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Nexa Bold", 12.9999981F, FontStyle.Bold)
        Label4.ForeColor = Color.Goldenrod
        Label4.Location = New Point(205, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 22)
        Label4.TabIndex = 2
        Label4.Text = "Nama"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Nexa Bold", 12.9999981F, FontStyle.Bold)
        Label5.ForeColor = Color.Goldenrod
        Label5.Location = New Point(205, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 22)
        Label5.TabIndex = 59
        Label5.Text = "No Telp"
        ' 
        ' Beli1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(917, 525)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(wisata)
        Controls.Add(Panel1)
        Controls.Add(tanggal)
        Controls.Add(PictureBox7)
        Controls.Add(Label3)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(jumlah)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Name = "Beli1"
        Text = "Beli1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents jumlah As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents total As Label
    Friend WithEvents beli As Button
    Friend WithEvents wisata As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
