<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBMI
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
        Panel1 = New Panel()
        lblStatus = New Label()
        lblBMI = New Label()
        lblStatusHeading = New Label()
        lblBMIHeading = New Label()
        btnClear = New Button()
        btnCompute = New Button()
        txtWeight = New TextBox()
        txtHeight = New TextBox()
        lblWeight = New Label()
        lblHeight = New Label()
        lblSystem = New Label()
        lstSystem = New ListBox()
        lblHeading = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(lblBMI)
        Panel1.Controls.Add(lblStatusHeading)
        Panel1.Controls.Add(lblBMIHeading)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnCompute)
        Panel1.Controls.Add(txtWeight)
        Panel1.Controls.Add(txtHeight)
        Panel1.Controls.Add(lblWeight)
        Panel1.Controls.Add(lblHeight)
        Panel1.Controls.Add(lblSystem)
        Panel1.Controls.Add(lstSystem)
        Panel1.Controls.Add(lblHeading)
        Panel1.Dock = DockStyle.Right
        Panel1.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(372, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(428, 450)
        Panel1.TabIndex = 0
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblStatus.ForeColor = Color.Black
        lblStatus.Location = New Point(267, 414)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(90, 25)
        lblStatus.TabIndex = 12
        lblStatus.Text = "Label4"
        lblStatus.Visible = False
        ' 
        ' lblBMI
        ' 
        lblBMI.AutoSize = True
        lblBMI.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblBMI.ForeColor = Color.Black
        lblBMI.Location = New Point(267, 367)
        lblBMI.Name = "lblBMI"
        lblBMI.Size = New Size(90, 25)
        lblBMI.TabIndex = 11
        lblBMI.Text = "Label3"
        lblBMI.Visible = False
        ' 
        ' lblStatusHeading
        ' 
        lblStatusHeading.AutoSize = True
        lblStatusHeading.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblStatusHeading.ForeColor = Color.LightCoral
        lblStatusHeading.Location = New Point(62, 414)
        lblStatusHeading.Name = "lblStatusHeading"
        lblStatusHeading.Size = New Size(188, 25)
        lblStatusHeading.TabIndex = 10
        lblStatusHeading.Text = "Weight Status:"
        ' 
        ' lblBMIHeading
        ' 
        lblBMIHeading.AutoSize = True
        lblBMIHeading.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblBMIHeading.ForeColor = Color.LightCoral
        lblBMIHeading.Location = New Point(124, 367)
        lblBMIHeading.Name = "lblBMIHeading"
        lblBMIHeading.Size = New Size(67, 25)
        lblBMIHeading.TabIndex = 9
        lblBMIHeading.Text = "BMI:"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGreen
        btnClear.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(205, 313)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(135, 51)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.LightGreen
        btnCompute.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        btnCompute.ForeColor = Color.White
        btnCompute.Location = New Point(70, 313)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(135, 51)
        btnCompute.TabIndex = 7
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(303, 247)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(70, 33)
        txtWeight.TabIndex = 6
        txtWeight.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(303, 209)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(70, 33)
        txtHeight.TabIndex = 5
        txtHeight.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(62, 250)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(212, 25)
        lblWeight.TabIndex = 4
        lblWeight.Text = "Enter your Weight:"
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Location = New Point(62, 209)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(208, 25)
        lblHeight.TabIndex = 3
        lblHeight.Text = "Enter your Height:"
        ' 
        ' lblSystem
        ' 
        lblSystem.AutoSize = True
        lblSystem.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSystem.ForeColor = Color.White
        lblSystem.Location = New Point(101, 81)
        lblSystem.Name = "lblSystem"
        lblSystem.Size = New Size(247, 25)
        lblSystem.TabIndex = 2
        lblSystem.Text = "Select Your System:"
        ' 
        ' lstSystem
        ' 
        lstSystem.BackColor = Color.Khaki
        lstSystem.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstSystem.ForeColor = Color.White
        lstSystem.FormattingEnabled = True
        lstSystem.ItemHeight = 25
        lstSystem.Items.AddRange(New Object() {"Imperial System (Inches)", "Metric System (Meters)"})
        lstSystem.Location = New Point(55, 121)
        lstSystem.Name = "lstSystem"
        lstSystem.Size = New Size(318, 54)
        lstSystem.TabIndex = 1
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.Black
        lblHeading.Location = New Point(17, 29)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(394, 25)
        lblHeading.TabIndex = 0
        lblHeading.Text = "BODY MASS INDEX CALCULATOR"
        ' 
        ' frmBMI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bmi
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmBMI"
        Text = "Body Mass Index (BMI) Calculator with CDC Chart"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblSystem As Label
    Friend WithEvents lstSystem As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblStatusHeading As Label
    Friend WithEvents lblBMIHeading As Label

End Class
