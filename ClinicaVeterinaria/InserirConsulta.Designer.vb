<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InserirConsulta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbChipPet = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbSintomas = New System.Windows.Forms.RichTextBox()
        Me.rtbTratamento = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbChipPet
        '
        Me.cbChipPet.FormattingEnabled = True
        Me.cbChipPet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbChipPet.ItemHeight = 13
        Me.cbChipPet.Location = New System.Drawing.Point(85, 72)
        Me.cbChipPet.MaxDropDownItems = 10
        Me.cbChipPet.MaxLength = 1000
        Me.cbChipPet.Name = "cbChipPet"
        Me.cbChipPet.Size = New System.Drawing.Size(268, 21)
        Me.cbChipPet.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tratamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID_Chip Pet:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sintomas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Inserir Consulta"
        '
        'rtbSintomas
        '
        Me.rtbSintomas.Location = New System.Drawing.Point(85, 111)
        Me.rtbSintomas.Name = "rtbSintomas"
        Me.rtbSintomas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbSintomas.Size = New System.Drawing.Size(268, 96)
        Me.rtbSintomas.TabIndex = 23
        Me.rtbSintomas.Text = ""
        '
        'rtbTratamento
        '
        Me.rtbTratamento.Location = New System.Drawing.Point(85, 224)
        Me.rtbTratamento.Name = "rtbTratamento"
        Me.rtbTratamento.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbTratamento.Size = New System.Drawing.Size(268, 96)
        Me.rtbTratamento.TabIndex = 24
        Me.rtbTratamento.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbTratamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rtbSintomas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbChipPet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 375)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'InserirConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.backgroundAnimalPrint5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "InserirConsulta"
        Me.Text = "InserirConsulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbChipPet As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbSintomas As RichTextBox
    Friend WithEvents rtbTratamento As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
