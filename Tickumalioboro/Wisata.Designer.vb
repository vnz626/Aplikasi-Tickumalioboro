<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wisata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wisata))
        Label1 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox7 = New PictureBox()
        DataGridView1 = New DataGridView()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nexa Bold", 24F, FontStyle.Bold)
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(442, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 39)
        Label1.TabIndex = 27
        Label1.Text = "Wisata"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Nexa Bold", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(442, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 39)
        Label2.TabIndex = 26
        Label2.Text = "Informasi"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(296, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 134)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(-7, 231)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(924, 298)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 41
        PictureBox7.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 170)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(870, 332)
        DataGridView1.TabIndex = 44
        ' 
        ' Wisata
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(917, 525)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Name = "Wisata"
        Text = "Wisata"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
