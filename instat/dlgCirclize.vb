' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgCirclize
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCircosPar As RFunction
    Private clsCircosInitialise As RFunction
    Private clsCircosTrackPlotRegion As RFunction
    Private clsCircosAxis As RFunction
    Private clsCircosTrackPoints As RFunction
    Private clsCircosTrackHist As RFunction
    Private clsCircosTrackBar As RFunction
    Private clsCircosTrackBox As RFunction
    Private clsCircosTrackVline As RFunction
    Private clsCircosTrackViolin As RFunction
    Private clsCircosTrackLine As RFunction
    Private Sub dlgCirclize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()

    End Sub

    Private Sub InitialiseDialog()
        Dim dctComboType As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorCircosPlots.SetParameter(New RParameter("data_name", 0, bNewIncludeArgumentName:=False))
        ucrSelectorCircosPlots.SetParameterIsrfunction()

        ucrPnlOptions.AddRadioButton(rdoStation)
        ucrPnlOptions.AddRadioButton(rdoElement)

        ucrReceiverSectors.SetParameter(New RParameter("sectors", 0))
        ucrReceiverSectors.Selector = ucrSelectorCircosPlots
        ucrReceiverSectors.SetIncludedDataTypes({"factor"})
        ucrReceiverSectors.strSelectorHeading = "Factors"
        ucrReceiverSectors.bWithQuotes = False
        ucrReceiverSectors.SetParameterIsRFunction()

        ucrReceiverY.SetParameter(New RParameter("y", 1))
        ucrReceiverY.SetParameterIsRFunction()
        ucrReceiverY.Selector = ucrSelectorCircosPlots
        ucrReceiverY.SetDataType("numeric", bStrict:=True)
        ucrReceiverY.strSelectorHeading = "Numerics"

        ucrReceiverX.SetParameter(New RParameter("x", 1))
        ucrReceiverX.SetParameterIsRFunction()
        ucrReceiverX.Selector = ucrSelectorCircosPlots
        ucrReceiverX.SetDataType("numeric", bStrict:=True)
        ucrReceiverX.strSelectorHeading = "Numerics"

        ucrPnlOptions.AddFunctionNamesCondition(rdoStation, "")
        ucrPnlOptions.AddFunctionNamesCondition(rdoElement, "")

        ucrInputComboType.SetItems({"Bar", "Box", "Hist", "Line", "Point", "Vline", "Violin"})
        ucrInputComboType.SetDropDownStyleAsNonEditable()

        ucrReceiverFacet.SetParameter(New RParameter(""))
        ucrReceiverFacet.Selector = ucrSelectorCircosPlots
        ucrReceiverFacet.SetIncludedDataTypes({"factor"})
        ucrReceiverFacet.strSelectorHeading = "Factors"
        ucrReceiverFacet.bWithQuotes = False
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.SetValuesToIgnore({"."})

        ucrSavePlot.SetPrefix("circos")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorCircosPlots.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsCircosPar = New RFunction
        clsCircosInitialise = New RFunction
        clsCircosAxis = New RFunction
        clsCircosTrackPlotRegion = New RFunction
        clsCircosTrackBar = New RFunction
        clsCircosTrackBox = New RFunction
        clsCircosTrackHist = New RFunction
        clsCircosTrackLine = New RFunction
        clsCircosTrackViolin = New RFunction
        clsCircosTrackVline = New RFunction
        clsCircosTrackPoints = New RFunction

        ucrSelectorCircosPlots.Reset()
        ucrSavePlot.Reset()
        ucrReceiverSectors.SetMeAsReceiver()

        ucrInputComboType.SetText("Bar")

        clsCircosPar.SetPackageName("circlize")
        clsCircosPar.SetRCommand("circos.par")
        clsCircosPar.AddParameter("track.height", "0.3", iPosition:=0)

        clsCircosAxis.SetPackageName("circlize")
        clsCircosAxis.SetRCommand("circos.axis")

        clsCircosInitialise.SetPackageName("circlize")
        clsCircosInitialise.SetRCommand("circos.initialize")

        clsCircosTrackPlotRegion.SetPackageName("circlize")
        clsCircosTrackPlotRegion.SetRCommand("circos.trackPlotRegion")
        clsCircosTrackPlotRegion.AddParameter("panel.fun", "function(x,y){circlize::circos.axis()}", iPosition:=0)


        clsCircosTrackPoints.SetPackageName("circlize")
        clsCircosTrackPoints.SetRCommand("circos.trackPoints")
        clsCircosTrackPoints.AddParameter("col", Chr(34) & "blue" & Chr(34), iPosition:=0)

        clsCircosTrackHist.SetPackageName("circlize")
        clsCircosTrackHist.SetRCommand("circos.trackHist")
        clsCircosTrackHist.AddParameter("bg.col", Chr(34) & "white" & Chr(34), iPosition:=0)
        clsCircosTrackHist.AddParameter("col", Chr(34) & "blue" & Chr(34), iPosition:=1)

        ' clsCircosTrackHist.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorCircosPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosPar, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosInitialise, iPosition:=1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosTrackPlotRegion, iPosition:=2)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosTrackHist, iPosition:=3)
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True

    End Sub

    Private Sub SetRcodeforControls(breset As Boolean)
        ucrReceiverSectors.AddAdditionalCodeParameterPair(clsCircosTrackPlotRegion, New RParameter("sectors", 0), iAdditionalPairNo:=1)
        ucrReceiverSectors.AddAdditionalCodeParameterPair(clsCircosTrackHist, New RParameter("sectors", 0), iAdditionalPairNo:=2)
        ucrReceiverSectors.AddAdditionalCodeParameterPair(clsCircosTrackPoints, New RParameter("sectors", 0), iAdditionalPairNo:=3)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsCircosTrackHist, New RParameter("x", 1), iAdditionalPairNo:=1)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsCircosTrackPlotRegion, New RParameter("x", 1), iAdditionalPairNo:=2)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsCircosTrackPoints, New RParameter("x", 1), iAdditionalPairNo:=3)
        ucrReceiverY.AddAdditionalCodeParameterPair(clsCircosTrackPoints, New RParameter("y", 2), iAdditionalPairNo:=1)

        ucrReceiverSectors.SetRCode(clsCircosInitialise, breset)
        ucrReceiverX.SetRCode(clsCircosInitialise, breset)
        ucrReceiverY.SetRCode(clsCircosTrackPlotRegion, breset)
        ' ucrSavePlot.SetRCode(clsCircosTrackHist, breset)
        ' ucrPnlOptions.SetRCode(clsCircosInitialise, breset)
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverSectors.IsEmpty AndAlso Not ucrReceiverX.IsEmpty AndAlso Not ucrReceiverY.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeforControls(True)
        TestOkEnabled()
    End Sub
    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSectors.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrReceiverY.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputComboType_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputComboType.ControlValueChanged
        Dim strChangedText As String = ""
        strChangedText = ucrChangedControl.GetText
        'If strChangedText = "Hist" Then
        '    ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosTrackHist, iPosition:=3)
        '    ucrBase.clsRsyntax.iCallType = 3
        'ElseIf strChangedText = "Point" Then
        '    ucrBase.clsRsyntax.AddToBeforeCodes(clsCircosTrackPoints, iPosition:=3)
        '    ucrBase.clsRsyntax.iCallType = 3
        'End If
    End Sub
End Class