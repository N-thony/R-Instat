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

Imports instat.Translations

Public Class dlgRank
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRankFunction, clsSortFunction As New RFunction
    Private Sub dlgRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ' TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 25

        ucrPnlOptions.AddRadioButton(rdoNumeric)
        ucrPnlOptions.AddRadioButton(rdoNonNegative)
        ucrPnlOptions.AddRadioButton(rdoSort)
        ucrPnlOptions.AddRadioButton(rdoRank)

        ucrPnlOptions.AddFunctionNamesCondition(rdoNumeric, "")
        ucrPnlOptions.AddFunctionNamesCondition(rdoNonNegative, "")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSort, "sort")
        ucrPnlOptions.AddFunctionNamesCondition(rdoRank, "rank")

        'Setting Parameters and Data types allowed
        ucrReceiverRank.SetParameter(New RParameter("x", 0))
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.SetMeAsReceiver()
        ucrReceiverRank.bUseFilteredData = False
        ucrReceiverRank.SetParameterIsRFunction()

        ucrPnlMissingValues.SetParameter(New RParameter("na.last", 1))
        ucrPnlMissingValues.AddRadioButton(rdoKeptAsMissing, Chr(34) & "keep" & Chr(34))
        ucrPnlMissingValues.AddRadioButton(rdoFirstMissingValues, "FALSE")
        ucrPnlMissingValues.AddRadioButton(rdoLast, "TRUE")
        ucrPnlMissingValues.SetRDefault("TRUE")

        'Setting Parameters for the respective radio buttons
        ucrPnlTies.SetParameter(New RParameter("ties.method", 2))
        ucrPnlTies.AddRadioButton(rdoAverage, Chr(34) & "average" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMinimum, Chr(34) & "min" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMaximum, Chr(34) & "max" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoFirst, Chr(34) & "first" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoRandom, Chr(34) & "random" & Chr(34))
        ucrPnlTies.SetRDefault(Chr(34) & "average" & Chr(34))

        ucrChkDecreasing.SetText("Decreasing")
        ucrChkDecreasing.SetParameter(New RParameter("decreasing", 1))
        ucrChkDecreasing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkMissingLast.SetText("Missing Last")
        ucrChkMissingLast.SetParameter(New RParameter("na.last", 2))
        ucrChkMissingLast.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrPnlOptions.AddToLinkedControls({ucrPnlMissingValues, ucrPnlTies}, {rdoRank}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkDecreasing, ucrChkMissingLast}, {rdoSort}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMissingValues.SetLinkedDisplayControl(grpMissingValues)
        ucrPnlTies.SetLinkedDisplayControl(grpTies)

        ucrSaveRank.SetPrefix("new_column")
        ucrSaveRank.SetSaveTypeAsColumn()
        ucrSaveRank.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSaveRank.SetLabelText("New Column Name:")
        ucrSaveRank.SetIsComboBox()
        ucrSaveRank.setLinkedReceiver(ucrReceiverRank)
    End Sub

    ' Sub that runs only the first time the dialog loads it sets default RFunction as the base function
    Private Sub SetDefaults()
        clsRankFunction = New RFunction
        clsSortFunction = New RFunction

        ucrSelectorForRank.Reset()
        ucrSaveRank.Reset()

        clsSortFunction.SetRCommand("sort")
        clsSortFunction.AddParameter("decreasing", "TRUE", iPosition:=1)
        clsSortFunction.AddParameter("na.last", "TRUE", iPosition:=2)

        'Setting default parameters for the base function
        clsRankFunction.SetRCommand("rank")
        clsRankFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34))
        clsRankFunction.SetAssignTo(ucrSaveRank.GetText, strTempDataframe:=ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRank.GetText, bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.ClearCodes()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRankFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSortFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=1)
        ucrSaveRank.AddAdditionalRCode(clsSortFunction, iAdditionalPairNo:=1)
        ucrReceiverRank.SetRCode(clsRankFunction, bReset)
        ucrReceiverRank.SetRCode(clsRankFunction, bReset)
        ucrPnlMissingValues.SetRCode(clsRankFunction, bReset)
        ucrPnlTies.SetRCode(clsRankFunction, bReset)
        ucrSaveRank.SetRCode(clsRankFunction, bReset)
        ucrChkDecreasing.SetRCode(clsSortFunction, bReset)
        ucrChkMissingLast.SetRCode(clsSortFunction, bReset)
    End Sub

    'Testing when to Enable the OK button
    Private Sub TestOKEnabled()
        If Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveRank.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoRank.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRankFunction)
        ElseIf rdoSort.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSortFunction)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlContentsChanged, ucrSaveRank.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
