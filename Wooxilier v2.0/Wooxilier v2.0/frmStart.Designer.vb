<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTotalFolios = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblCerosIzq = New System.Windows.Forms.Label()
        Me.txtTotalFolios = New System.Windows.Forms.TextBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.cboxCerosIzq = New System.Windows.Forms.ComboBox()
        Me.dialogoGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.picboxHeader = New System.Windows.Forms.PictureBox()
        Me.txtFolioInicio = New System.Windows.Forms.TextBox()
        Me.lblFolioInicio = New System.Windows.Forms.Label()
        CType(Me.picboxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Lime
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(371, 374)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 50)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Salir"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.ForeColor = System.Drawing.Color.Lime
        Me.lblDescription.Location = New System.Drawing.Point(22, 69)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(207, 17)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Herramienta para realizar folios"
        '
        'lblTotalFolios
        '
        Me.lblTotalFolios.AutoSize = True
        Me.lblTotalFolios.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFolios.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalFolios.Location = New System.Drawing.Point(149, 181)
        Me.lblTotalFolios.Name = "lblTotalFolios"
        Me.lblTotalFolios.Size = New System.Drawing.Size(171, 29)
        Me.lblTotalFolios.TabIndex = 3
        Me.lblTotalFolios.Text = "Número de fin:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactor.ForeColor = System.Drawing.Color.Lime
        Me.lblFactor.Location = New System.Drawing.Point(22, 240)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(298, 29)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Text = "Número de folios por hoja:"
        '
        'lblCerosIzq
        '
        Me.lblCerosIzq.AutoSize = True
        Me.lblCerosIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerosIzq.ForeColor = System.Drawing.Color.Lime
        Me.lblCerosIzq.Location = New System.Drawing.Point(87, 299)
        Me.lblCerosIzq.Name = "lblCerosIzq"
        Me.lblCerosIzq.Size = New System.Drawing.Size(233, 29)
        Me.lblCerosIzq.TabIndex = 5
        Me.lblCerosIzq.Text = "Ceros a la izquierda:"
        '
        'txtTotalFolios
        '
        Me.txtTotalFolios.BackColor = System.Drawing.Color.Black
        Me.txtTotalFolios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalFolios.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFolios.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalFolios.Location = New System.Drawing.Point(356, 176)
        Me.txtTotalFolios.Name = "txtTotalFolios"
        Me.txtTotalFolios.Size = New System.Drawing.Size(178, 38)
        Me.txtTotalFolios.TabIndex = 1
        '
        'txtFactor
        '
        Me.txtFactor.BackColor = System.Drawing.Color.Black
        Me.txtFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactor.ForeColor = System.Drawing.Color.Lime
        Me.txtFactor.Location = New System.Drawing.Point(356, 235)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(178, 38)
        Me.txtFactor.TabIndex = 2
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Lime
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.Black
        Me.btnGenerar.Location = New System.Drawing.Point(199, 374)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(160, 50)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Lime
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Black
        Me.btnHelp.Location = New System.Drawing.Point(131, 375)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 48)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "(?)"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'cboxCerosIzq
        '
        Me.cboxCerosIzq.BackColor = System.Drawing.Color.Black
        Me.cboxCerosIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.cboxCerosIzq.ForeColor = System.Drawing.Color.Lime
        Me.cboxCerosIzq.FormattingEnabled = True
        Me.cboxCerosIzq.Items.AddRange(New Object() {"0X", "00X", "000X", "0000X", "00000X"})
        Me.cboxCerosIzq.Location = New System.Drawing.Point(356, 293)
        Me.cboxCerosIzq.Margin = New System.Windows.Forms.Padding(0)
        Me.cboxCerosIzq.Name = "cboxCerosIzq"
        Me.cboxCerosIzq.Size = New System.Drawing.Size(178, 39)
        Me.cboxCerosIzq.TabIndex = 3
        '
        'picboxHeader
        '
        Me.picboxHeader.Image = Global.Wooxilier_v2._0.My.Resources.Resources.wooxilier_header
        Me.picboxHeader.Location = New System.Drawing.Point(22, 24)
        Me.picboxHeader.Name = "picboxHeader"
        Me.picboxHeader.Size = New System.Drawing.Size(184, 32)
        Me.picboxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picboxHeader.TabIndex = 1
        Me.picboxHeader.TabStop = False
        '
        'txtFolioInicio
        '
        Me.txtFolioInicio.BackColor = System.Drawing.Color.Black
        Me.txtFolioInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFolioInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioInicio.ForeColor = System.Drawing.Color.Lime
        Me.txtFolioInicio.Location = New System.Drawing.Point(356, 116)
        Me.txtFolioInicio.Name = "txtFolioInicio"
        Me.txtFolioInicio.Size = New System.Drawing.Size(178, 38)
        Me.txtFolioInicio.TabIndex = 0
        Me.txtFolioInicio.Text = "1"
        '
        'lblFolioInicio
        '
        Me.lblFolioInicio.AutoSize = True
        Me.lblFolioInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolioInicio.ForeColor = System.Drawing.Color.Lime
        Me.lblFolioInicio.Location = New System.Drawing.Point(117, 121)
        Me.lblFolioInicio.Name = "lblFolioInicio"
        Me.lblFolioInicio.Size = New System.Drawing.Size(203, 29)
        Me.lblFolioInicio.TabIndex = 8
        Me.lblFolioInicio.Text = "Número de inicio:"
        '
        'frmStart
        '
        Me.AcceptButton = Me.btnGenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(550, 444)
        Me.Controls.Add(Me.lblFolioInicio)
        Me.Controls.Add(Me.txtFolioInicio)
        Me.Controls.Add(Me.cboxCerosIzq)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtTotalFolios)
        Me.Controls.Add(Me.lblCerosIzq)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblTotalFolios)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.picboxHeader)
        Me.Controls.Add(Me.btnClose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "frmStart"
        Me.Opacity = 0.85R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wooxilier for CorelDraw"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.picboxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents picboxHeader As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTotalFolios As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblCerosIzq As Label
    Friend WithEvents txtTotalFolios As TextBox
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents cboxCerosIzq As ComboBox
    Friend WithEvents dialogoGuardar As SaveFileDialog
    Friend WithEvents txtFolioInicio As TextBox
    Friend WithEvents lblFolioInicio As Label
End Class
