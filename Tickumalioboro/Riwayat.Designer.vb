<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Nexa Bold", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(446, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 39)
        Label2.TabIndex = 22
        Label2.Text = "Riwayat"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(300, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 134)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nexa Bold", 24F, FontStyle.Bold)
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(446, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 39)
        Label1.TabIndex = 24
        Label1.Text = "Pembelian"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(55, 161)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(799, 323)
        DataGridView1.TabIndex = 25
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-5, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(924, 298)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Riwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 525)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Name = "Riwayat"
        Text = "Riwayat"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
