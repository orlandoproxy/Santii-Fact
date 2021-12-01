<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim bsPeriodos As System.Windows.Forms.BindingSource
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvCalculo = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.tbImpresion = New System.Windows.Forms.TextBox()
        Me.lbImpresion = New System.Windows.Forms.Label()
        Me.tbCorte = New System.Windows.Forms.TextBox()
        Me.lbCorte = New System.Windows.Forms.Label()
        Me.lbPeriodo = New System.Windows.Forms.Label()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaFinal = New System.Windows.Forms.Label()
        Me.lbFechaInicial = New System.Windows.Forms.Label()
        bsPeriodos = New System.Windows.Forms.BindingSource(Me.components)
        CType(bsPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvCalculo)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.tbImpresion)
        Me.Panel1.Controls.Add(Me.lbImpresion)
        Me.Panel1.Controls.Add(Me.tbCorte)
        Me.Panel1.Controls.Add(Me.lbCorte)
        Me.Panel1.Controls.Add(Me.lbPeriodo)
        Me.Panel1.Controls.Add(Me.cbPeriodo)
        Me.Panel1.Controls.Add(Me.dtpFechaFinal)
        Me.Panel1.Controls.Add(Me.dtpFechaInicial)
        Me.Panel1.Controls.Add(Me.lbFechaFinal)
        Me.Panel1.Controls.Add(Me.lbFechaInicial)
        Me.Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 349)
        Me.Panel1.TabIndex = 0
        '
        'dgvCalculo
        '
        Me.dgvCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalculo.Location = New System.Drawing.Point(229, 11)
        Me.dgvCalculo.Name = "dgvCalculo"
        Me.dgvCalculo.RowTemplate.Height = 25
        Me.dgvCalculo.Size = New System.Drawing.Size(562, 317)
        Me.dgvCalculo.TabIndex = 12
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 349)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(134, 273)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'tbImpresion
        '
        Me.tbImpresion.Location = New System.Drawing.Point(109, 207)
        Me.tbImpresion.Name = "tbImpresion"
        Me.tbImpresion.Size = New System.Drawing.Size(100, 23)
        Me.tbImpresion.TabIndex = 9
        '
        'lbImpresion
        '
        Me.lbImpresion.AutoSize = True
        Me.lbImpresion.Location = New System.Drawing.Point(3, 210)
        Me.lbImpresion.Name = "lbImpresion"
        Me.lbImpresion.Size = New System.Drawing.Size(89, 15)
        Me.lbImpresion.TabIndex = 8
        Me.lbImpresion.Text = "Dia Impresion:  "
        '
        'tbCorte
        '
        Me.tbCorte.Location = New System.Drawing.Point(109, 164)
        Me.tbCorte.Name = "tbCorte"
        Me.tbCorte.Size = New System.Drawing.Size(100, 23)
        Me.tbCorte.TabIndex = 7
        '
        'lbCorte
        '
        Me.lbCorte.AutoSize = True
        Me.lbCorte.Location = New System.Drawing.Point(30, 167)
        Me.lbCorte.Name = "lbCorte"
        Me.lbCorte.Size = New System.Drawing.Size(62, 15)
        Me.lbCorte.TabIndex = 6
        Me.lbCorte.Text = "Dia Corte: "
        '
        'lbPeriodo
        '
        Me.lbPeriodo.AutoSize = True
        Me.lbPeriodo.Location = New System.Drawing.Point(34, 128)
        Me.lbPeriodo.Name = "lbPeriodo"
        Me.lbPeriodo.Size = New System.Drawing.Size(54, 15)
        Me.lbPeriodo.TabIndex = 5
        Me.lbPeriodo.Text = "Periodo: "
        '
        'cbPeriodo
        '
        Me.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Location = New System.Drawing.Point(109, 120)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(100, 23)
        Me.cbPeriodo.TabIndex = 4
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(109, 74)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(109, 24)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaInicial.TabIndex = 2
        '
        'lbFechaFinal
        '
        Me.lbFechaFinal.AutoSize = True
        Me.lbFechaFinal.Location = New System.Drawing.Point(20, 80)
        Me.lbFechaFinal.Name = "lbFechaFinal"
        Me.lbFechaFinal.Size = New System.Drawing.Size(72, 15)
        Me.lbFechaFinal.TabIndex = 1
        Me.lbFechaFinal.Text = "Fecha Final: "
        '
        'lbFechaInicial
        '
        Me.lbFechaInicial.AutoSize = True
        Me.lbFechaInicial.Location = New System.Drawing.Point(10, 30)
        Me.lbFechaInicial.Name = "lbFechaInicial"
        Me.lbFechaInicial.Size = New System.Drawing.Size(78, 15)
        Me.lbFechaInicial.TabIndex = 0
        Me.lbFechaInicial.Text = "Fecha Inicial: "
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 351)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Main"
        Me.Text = "Periodos Nomina"
        CType(bsPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbPeriodo As Label
    Friend WithEvents cbPeriodo As ComboBox
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lbFechaFinal As Label
    Friend WithEvents lbFechaInicial As Label
    Friend WithEvents lbCorte As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents tbImpresion As TextBox
    Friend WithEvents lbImpresion As Label
    Friend WithEvents tbCorte As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents bsPeriodos As BindingSource
    Friend WithEvents AccessibleDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessibleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessibleRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllowDropDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AnchorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents BackgroundImageLayoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CausesValidationDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContextMenuStripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CursorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataBindingsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnabledDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FontDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForeColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimumSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RightToLeftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabIndexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabStopDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseWaitCursorDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents VisibleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PaddingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImeModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents dgvCalculo As DataGridView
End Class
