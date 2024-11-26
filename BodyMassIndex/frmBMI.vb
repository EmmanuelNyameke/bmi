' Program Name: Body Mass Index Calculator
' Date: November 24, 2024
' Author: K Bola
' Purpose: This application allows the users to enter the height and weight and computes the user's body mass index
Imports System.CodeDom.Compiler
Imports System.IO

Public Class frmBMI
    Private Sub frmBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            If IsNothing(lstSystem.SelectedIndex) Then
                MsgBox("Select a measurement system", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Selection")
            End If
            ' Getting user input
            Dim dblWeight As Double = Double.Parse(txtHeight.Text)
            Dim dblHeight As Double = Double.Parse(txtWeight.Text)
            Dim dblBMI As Double

            ' Calculating the BMI based on the system selected
            If (lstSystem.SelectedIndex = 0) Then
                dblBMI = CalculateImperialBMI(dblWeight, dblHeight)
                lblBMI.Visible = True
                lblStatus.Visible = True
            ElseIf (lstSystem.SelectedIndex = 1) Then
                dblBMI = CalculateMetricBMI(dblWeight, dblHeight)
                lblBMI.Visible = True
                lblStatus.Visible = True
            End If

            ' Displaying the BMI and Its interpretation
            lblBMI.Text = Math.Round(dblBMI, 2).ToString()
            lblStatus.Text = GetBMIInterpretation(dblBMI)
        Catch ex As Exception
            MsgBox("Error: Please enter a valid numeric values for weight and height.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End Try
    End Sub

    ' Function to calculate the bmi of the imperial system
    Private Function CalculateImperialBMI(dblWeight As Double, dblHeight As Double) As Double
        Return (dblWeight / (dblHeight * dblHeight)) * 703
    End Function

    ' Function to calculate the bmi of the metric system
    Private Function CalculateMetricBMI(dblWeight As Double, dblHeight As Double) As Double
        Return dblWeight / (dblHeight * dblHeight)
    End Function

    ' Function to interpret bmi based on cdc chart
    Private Function GetBMIInterpretation(dblBMI As Double) As String
        If (dblBMI > 0 And dblBMI < 18.5) Then
            Return "Underweight"
        ElseIf (dblBMI >= 18.5 And dblBMI <= 24.9) Then
            Return "Normal Weight"
        ElseIf (dblBMI >= 25 And dblBMI <= 29.9) Then
            Return "Overweight"
        Else
            Return "Obese"
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblStatus.Text = ""
        lblBMI.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()
        txtHeight.Focus()
    End Sub
End Class