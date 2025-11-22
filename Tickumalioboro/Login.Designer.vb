<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        Label10 = New Label()
        Button1 = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        RichTextBox2 = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.LightGray
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(557, 299)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(32, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 58
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.LightGray
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(557, 238)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(32, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 57
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(131, 161)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(167, 162)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 56
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Nexa Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Goldenrod
        Label11.Location = New Point(725, 432)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 20)
        Label11.TabIndex = 55
        Label11.Text = "Register"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Nexa Light", 12F)
        Label10.ForeColor = Color.Goldenrod
        Label10.Location = New Point(569, 432)
        Label10.Name = "Label10"
        Label10.Size = New Size(156, 20)
        Label10.TabIndex = 54
        Label10.Text = "Sudah punya akun?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.Font = New Font("Nexa Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(585, 373)
        Button1.Name = "Button1"
        Button1.Size = New Size(179, 37)
        Button1.TabIndex = 53
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Nexa Light", 10F, FontStyle.Italic)
        Label9.ForeColor = Color.Goldenrod
        Label9.Location = New Point(594, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 17)
        Label9.TabIndex = 52
        Label9.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Nexa Light", 10F, FontStyle.Italic)
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(594, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 17)
        Label8.TabIndex = 51
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(581, 205)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 50
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.ControlLight
        RichTextBox2.Font = New Font("Nexa Light", 11.2499981F)
        RichTextBox2.Location = New Point(595, 299)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(211, 33)
        RichTextBox2.TabIndex = 49
        RichTextBox2.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.ControlLight
        RichTextBox1.Font = New Font("Nexa Light", 11.2499981F)
        RichTextBox1.Location = New Point(595, 238)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(212, 33)
        RichTextBox1.TabIndex = 48
        RichTextBox1.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Goldenrod
        Label6.Font = New Font("Segoe UI", 0.5F)
        Label6.ForeColor = Color.Goldenrod
        Label6.Location = New Point(719, 162)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 3)
        Label6.TabIndex = 47
        Label6.Text = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Goldenrod
        Label5.Font = New Font("Segoe UI", 0.5F)
        Label5.ForeColor = Color.Goldenrod
        Label5.Location = New Point(539, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 3)
        Label5.TabIndex = 46
        Label5.Text = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.SandyBrown
        Label4.Font = New Font("Segoe UI", 0.5F)
        Label4.ForeColor = Color.SandyBrown
        Label4.Location = New Point(693, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 3)
        Label4.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Nexa Light", 10F)
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(660, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 17)
        Label3.TabIndex = 44
        Label3.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Nexa Bold", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(528, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(309, 39)
        Label2.TabIndex = 43
        Label2.Text = "TICKUMALIOBORO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nexa Light", 22F)
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(537, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 37)
        Label1.TabIndex = 42
        Label1.Text = "Selamat Datang Di"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-5, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(450, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(917, 525)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Login"
        Text = "Login"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
