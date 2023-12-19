<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        lstClients = New ListBox()
        txtClientName = New TextBox()
        txtCampaignName = New TextBox()
        btnSaveCampaign = New Button()
        btnSaveClient = New Button()
        Label3 = New Label()
        Label4 = New Label()
        dateStartDate = New DateTimePicker()
        dateEndDate = New DateTimePicker()
        lblBudget = New Label()
        txtBudget = New TextBox()
        Label5 = New Label()
        txtTMetrics = New TextBox()
        cmbClients = New ComboBox()
        btnSaveMetrics = New Button()
        btnViewReport = New Button()
        lstMetrics = New ListBox()
        lblClicks = New Label()
        txtClicks = New TextBox()
        lblConversions = New Label()
        txtConversions = New TextBox()
        Label6 = New Label()
        txtImpressions = New TextBox()
        lstCampaigns = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 0
        Label1.Text = "Clients:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "Campaigns:"
        ' 
        ' lstClients
        ' 
        lstClients.FormattingEnabled = True
        lstClients.ItemHeight = 15
        lstClients.Location = New Point(5, 81)
        lstClients.Name = "lstClients"
        lstClients.Size = New Size(120, 94)
        lstClients.TabIndex = 3
        ' 
        ' txtClientName
        ' 
        txtClientName.Location = New Point(48, 1)
        txtClientName.Name = "txtClientName"
        txtClientName.Size = New Size(100, 23)
        txtClientName.TabIndex = 4
        ' 
        ' txtCampaignName
        ' 
        txtCampaignName.Location = New Point(67, 35)
        txtCampaignName.Name = "txtCampaignName"
        txtCampaignName.Size = New Size(100, 23)
        txtCampaignName.TabIndex = 5
        ' 
        ' btnSaveCampaign
        ' 
        btnSaveCampaign.Location = New Point(173, 41)
        btnSaveCampaign.Name = "btnSaveCampaign"
        btnSaveCampaign.Size = New Size(75, 23)
        btnSaveCampaign.TabIndex = 6
        btnSaveCampaign.Text = "Save"
        btnSaveCampaign.UseVisualStyleBackColor = True
        ' 
        ' btnSaveClient
        ' 
        btnSaveClient.Location = New Point(154, 9)
        btnSaveClient.Name = "btnSaveClient"
        btnSaveClient.Size = New Size(75, 23)
        btnSaveClient.TabIndex = 7
        btnSaveClient.Text = "Save"
        btnSaveClient.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 8
        Label3.Text = "Start"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 15)
        Label4.TabIndex = 9
        Label4.Text = "End"
        ' 
        ' dateStartDate
        ' 
        dateStartDate.Location = New Point(42, 209)
        dateStartDate.Name = "dateStartDate"
        dateStartDate.Size = New Size(200, 23)
        dateStartDate.TabIndex = 10
        ' 
        ' dateEndDate
        ' 
        dateEndDate.Location = New Point(42, 243)
        dateEndDate.Name = "dateEndDate"
        dateEndDate.Size = New Size(200, 23)
        dateEndDate.TabIndex = 11
        ' 
        ' lblBudget
        ' 
        lblBudget.AutoSize = True
        lblBudget.Location = New Point(408, 119)
        lblBudget.Name = "lblBudget"
        lblBudget.Size = New Size(48, 15)
        lblBudget.TabIndex = 12
        lblBudget.Text = "Budget:"
        ' 
        ' txtBudget
        ' 
        txtBudget.Location = New Point(462, 111)
        txtBudget.Name = "txtBudget"
        txtBudget.Size = New Size(100, 23)
        txtBudget.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(408, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 14
        Label5.Text = "Target Metrics:"
        ' 
        ' txtTMetrics
        ' 
        txtTMetrics.Location = New Point(498, 147)
        txtTMetrics.Name = "txtTMetrics"
        txtTMetrics.Size = New Size(100, 23)
        txtTMetrics.TabIndex = 15
        ' 
        ' cmbClients
        ' 
        cmbClients.FormattingEnabled = True
        cmbClients.Location = New Point(662, 119)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(121, 23)
        cmbClients.TabIndex = 16
        ' 
        ' btnSaveMetrics
        ' 
        btnSaveMetrics.Location = New Point(662, 163)
        btnSaveMetrics.Name = "btnSaveMetrics"
        btnSaveMetrics.Size = New Size(90, 23)
        btnSaveMetrics.TabIndex = 17
        btnSaveMetrics.Text = "Save Metrics"
        btnSaveMetrics.UseVisualStyleBackColor = True
        ' 
        ' btnViewReport
        ' 
        btnViewReport.Location = New Point(271, 119)
        btnViewReport.Name = "btnViewReport"
        btnViewReport.Size = New Size(75, 23)
        btnViewReport.TabIndex = 18
        btnViewReport.Text = "View Rep"
        btnViewReport.UseVisualStyleBackColor = True
        ' 
        ' lstMetrics
        ' 
        lstMetrics.FormattingEnabled = True
        lstMetrics.ItemHeight = 15
        lstMetrics.Location = New Point(408, 322)
        lstMetrics.Name = "lstMetrics"
        lstMetrics.Size = New Size(120, 94)
        lstMetrics.TabIndex = 19
        ' 
        ' lblClicks
        ' 
        lblClicks.AutoSize = True
        lblClicks.Location = New Point(406, 186)
        lblClicks.Name = "lblClicks"
        lblClicks.Size = New Size(102, 15)
        lblClicks.TabIndex = 20
        lblClicks.Text = "Amount of Clicks:"
        ' 
        ' txtClicks
        ' 
        txtClicks.Location = New Point(514, 178)
        txtClicks.Name = "txtClicks"
        txtClicks.Size = New Size(100, 23)
        txtClicks.TabIndex = 21
        ' 
        ' lblConversions
        ' 
        lblConversions.AutoSize = True
        lblConversions.Location = New Point(406, 226)
        lblConversions.Name = "lblConversions"
        lblConversions.Size = New Size(75, 15)
        lblConversions.TabIndex = 22
        lblConversions.Text = "Conversions:"
        ' 
        ' txtConversions
        ' 
        txtConversions.Location = New Point(487, 223)
        txtConversions.Name = "txtConversions"
        txtConversions.Size = New Size(100, 23)
        txtConversions.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(406, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 24
        Label6.Text = "Impressions:"
        ' 
        ' txtImpressions
        ' 
        txtImpressions.Location = New Point(485, 255)
        txtImpressions.Name = "txtImpressions"
        txtImpressions.Size = New Size(100, 23)
        txtImpressions.TabIndex = 25
        ' 
        ' lstCampaigns
        ' 
        lstCampaigns.FormattingEnabled = True
        lstCampaigns.ItemHeight = 15
        lstCampaigns.Location = New Point(574, 322)
        lstCampaigns.Name = "lstCampaigns"
        lstCampaigns.Size = New Size(120, 94)
        lstCampaigns.TabIndex = 26
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstCampaigns)
        Controls.Add(txtImpressions)
        Controls.Add(Label6)
        Controls.Add(txtConversions)
        Controls.Add(lblConversions)
        Controls.Add(txtClicks)
        Controls.Add(lblClicks)
        Controls.Add(lstMetrics)
        Controls.Add(btnViewReport)
        Controls.Add(btnSaveMetrics)
        Controls.Add(cmbClients)
        Controls.Add(txtTMetrics)
        Controls.Add(Label5)
        Controls.Add(txtBudget)
        Controls.Add(lblBudget)
        Controls.Add(dateEndDate)
        Controls.Add(dateStartDate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSaveClient)
        Controls.Add(btnSaveCampaign)
        Controls.Add(txtCampaignName)
        Controls.Add(txtClientName)
        Controls.Add(lstClients)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstClients As ListBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents txtCampaignName As TextBox
    Friend WithEvents btnSaveCampaign As Button
    Friend WithEvents btnSaveClient As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dateStartDate As DateTimePicker
    Friend WithEvents dateEndDate As DateTimePicker
    Friend WithEvents lblBudget As Label
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTMetrics As TextBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents btnSaveMetrics As Button
    Friend WithEvents btnViewReport As Button
    Friend WithEvents lstMetrics As ListBox
    Friend WithEvents lblClicks As Label
    Friend WithEvents txtClicks As TextBox
    Friend WithEvents lblConversions As Label
    Friend WithEvents txtConversions As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImpressions As TextBox
    Friend WithEvents lstCampaigns As ListBox
End Class
