<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserirPet
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDChip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEspecieRaca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbNifDono = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inserir Pet"
        '
        'txtIDChip
        '
        Me.txtIDChip.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtIDChip.Location = New System.Drawing.Point(103, 83)
        Me.txtIDChip.Name = "txtIDChip"
        Me.txtIDChip.Size = New System.Drawing.Size(268, 20)
        Me.txtIDChip.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID_Chip:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(103, 123)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(268, 20)
        Me.txtNome.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NIF Dono:"
        '
        'txtEspecieRaca
        '
        Me.txtEspecieRaca.Location = New System.Drawing.Point(103, 210)
        Me.txtEspecieRaca.Name = "txtEspecieRaca"
        Me.txtEspecieRaca.Size = New System.Drawing.Size(268, 20)
        Me.txtEspecieRaca.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Espécie/Raça:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbNifDono
        '
        Me.cbNifDono.FormattingEnabled = True
        Me.cbNifDono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbNifDono.ItemHeight = 13
        Me.cbNifDono.Location = New System.Drawing.Point(103, 165)
        Me.cbNifDono.MaxDropDownItems = 10
        Me.cbNifDono.MaxLength = 1000
        Me.cbNifDono.Name = "cbNifDono"
        Me.cbNifDono.Size = New System.Drawing.Size(268, 21)
        Me.cbNifDono.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbNifDono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEspecieRaca)
        Me.GroupBox1.Controls.Add(Me.txtIDChip)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 321)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'InserirPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.backgroundAnimalPrint5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(472, 389)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "InserirPet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InserirPet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDChip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEspecieRaca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbNifDono As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
