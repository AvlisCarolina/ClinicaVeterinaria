<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserirFatura
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbTratamento = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbChipPet = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Snow
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.rtbTratamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbChipPet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(33, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 320)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'rtbTratamento
        '
        Me.rtbTratamento.Location = New System.Drawing.Point(84, 109)
        Me.rtbTratamento.Name = "rtbTratamento"
        Me.rtbTratamento.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbTratamento.Size = New System.Drawing.Size(268, 96)
        Me.rtbTratamento.TabIndex = 24
        Me.rtbTratamento.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Inserir Fatura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Descrição:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID_Consulta:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Valor:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(85, 228)
        Me.MaskedTextBox1.Mask = "000000.00 €"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaskedTextBox1.Size = New System.Drawing.Size(88, 20)
        Me.MaskedTextBox1.TabIndex = 25
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InserirFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.backgroundAnimalPrint5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(442, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InserirFatura"
        Me.Text = "InserirFatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtbTratamento As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbChipPet As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
