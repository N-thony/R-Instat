<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCirclize
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
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.rdoElement = New System.Windows.Forms.RadioButton()
        Me.cmdCircosOptions = New System.Windows.Forms.Button()
        Me.lblSectors = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblByFacet = New System.Windows.Forms.Label()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrInputComboType = New instat.ucrInputComboBox()
        Me.ucrReceiverSectors = New instat.ucrReceiverSingle()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSelectorCircosPlots = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStation.Location = New System.Drawing.Point(68, 7)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(135, 27)
        Me.rdoStation.TabIndex = 1
        Me.rdoStation.Text = "Station"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'rdoElement
        '
        Me.rdoElement.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoElement.Enabled = False
        Me.rdoElement.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoElement.FlatAppearance.BorderSize = 2
        Me.rdoElement.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoElement.Location = New System.Drawing.Point(201, 7)
        Me.rdoElement.Name = "rdoElement"
        Me.rdoElement.Size = New System.Drawing.Size(135, 27)
        Me.rdoElement.TabIndex = 2
        Me.rdoElement.Text = "Element"
        Me.rdoElement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoElement.UseVisualStyleBackColor = True
        '
        'cmdCircosOptions
        '
        Me.cmdCircosOptions.Enabled = False
        Me.cmdCircosOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircosOptions.Location = New System.Drawing.Point(7, 237)
        Me.cmdCircosOptions.Name = "cmdCircosOptions"
        Me.cmdCircosOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdCircosOptions.TabIndex = 14
        Me.cmdCircosOptions.Text = "Circos Options"
        Me.cmdCircosOptions.UseVisualStyleBackColor = True
        '
        'lblSectors
        '
        Me.lblSectors.AutoSize = True
        Me.lblSectors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSectors.Location = New System.Drawing.Point(262, 54)
        Me.lblSectors.Name = "lblSectors"
        Me.lblSectors.Size = New System.Drawing.Size(46, 13)
        Me.lblSectors.TabIndex = 4
        Me.lblSectors.Text = "Sectors:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(262, 101)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 6
        Me.lblType.Text = "Type:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYVariable.Location = New System.Drawing.Point(262, 154)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYVariable.TabIndex = 8
        Me.lblYVariable.Tag = "Y_Variable:"
        Me.lblYVariable.Text = "Y Variable:"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(262, 205)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 10
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblByFacet
        '
        Me.lblByFacet.AutoSize = True
        Me.lblByFacet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblByFacet.Location = New System.Drawing.Point(262, 255)
        Me.lblByFacet.Name = "lblByFacet"
        Me.lblByFacet.Size = New System.Drawing.Size(37, 13)
        Me.lblByFacet.TabIndex = 12
        Me.lblByFacet.Tag = "By_Factor:"
        Me.lblByFacet.Text = "Facet:"
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(262, 270)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 13
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(262, 220)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 11
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(262, 169)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 9
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ucrInputComboType
        '
        Me.ucrInputComboType.AddQuotesIfUnrecognised = True
        Me.ucrInputComboType.GetSetSelectedIndex = -1
        Me.ucrInputComboType.IsReadOnly = False
        Me.ucrInputComboType.Location = New System.Drawing.Point(262, 117)
        Me.ucrInputComboType.Name = "ucrInputComboType"
        Me.ucrInputComboType.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboType.TabIndex = 7
        '
        'ucrReceiverSectors
        '
        Me.ucrReceiverSectors.frmParent = Me
        Me.ucrReceiverSectors.Location = New System.Drawing.Point(262, 69)
        Me.ucrReceiverSectors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSectors.Name = "ucrReceiverSectors"
        Me.ucrReceiverSectors.Selector = Nothing
        Me.ucrReceiverSectors.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSectors.strNcFilePath = ""
        Me.ucrReceiverSectors.TabIndex = 5
        Me.ucrReceiverSectors.ucrSelector = Nothing
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(7, 339)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(254, 24)
        Me.ucrSavePlot.TabIndex = 15
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(63, 5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 26
        '
        'ucrSelectorCircosPlots
        '
        Me.ucrSelectorCircosPlots.bDropUnusedFilterLevels = False
        Me.ucrSelectorCircosPlots.bShowHiddenColumns = False
        Me.ucrSelectorCircosPlots.bUseCurrentFilter = True
        Me.ucrSelectorCircosPlots.Location = New System.Drawing.Point(7, 54)
        Me.ucrSelectorCircosPlots.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCircosPlots.Name = "ucrSelectorCircosPlots"
        Me.ucrSelectorCircosPlots.Size = New System.Drawing.Size(221, 180)
        Me.ucrSelectorCircosPlots.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 370)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 52)
        Me.ucrBase.TabIndex = 16
        '
        'dlgCirclize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 421)
        Me.Controls.Add(Me.lblByFacet)
        Me.Controls.Add(Me.ucrReceiverFacet)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrInputComboType)
        Me.Controls.Add(Me.ucrReceiverSectors)
        Me.Controls.Add(Me.lblSectors)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.cmdCircosOptions)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.rdoElement)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSelectorCircosPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCirclize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circos Plots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCircosPlots As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoStation As RadioButton
    Friend WithEvents rdoElement As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents cmdCircosOptions As Button
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrReceiverSectors As ucrReceiverSingle
    Friend WithEvents lblSectors As Label
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputComboType As ucrInputComboBox
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblByFacet As Label
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
End Class
