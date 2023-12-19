Imports System.ComponentModel

Public Class Form1
    Private Class Client
        Public Property User As String
        Public Property Campaigns As New List(Of Campaign)

        Public Sub New(user As String)
            Me.User = user
        End Sub

        Public Overrides Function ToString() As String
            Return User
        End Function
    End Class

    Private Class Campaign
        Public Property User As String
        Public Property StartDate As Date
        Public Property EndDate As Date
        Public Property Budget As Decimal
        Public Property TMetrics As String
        Public Property PMetrics As New List(Of PerformanceMetric)

        Public Sub New(user As String, startDate As Date, endDate As Date, budget As Decimal, tMetrics As String)
            Me.User = user
            Me.StartDate = startDate
            Me.EndDate = endDate
            Me.Budget = budget
            Me.TMetrics = tMetrics
        End Sub

        Public Overrides Function ToString() As String
            Return User
        End Function
    End Class

    Private Class PerformanceMetric
        Public Property Clicks As Integer
        Public Property Conversions As Integer
        Public Property Impressions As Integer

        Public Sub New(clicks As Integer, conversions As Integer, impressions As Integer)
            Me.Clicks = clicks
            Me.Conversions = conversions
            Me.Impressions = impressions
        End Sub
    End Class

    Private clients As New BindingList(Of Client)
    Private selectedClient As Client

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstClients.DataSource = clients
        lstClients.DisplayMember = "User"

        cmbClients.DataSource = clients
        cmbClients.DisplayMember = "User"
    End Sub

    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs)
        Dim user As String = txtClientName.Text
        If Not String.IsNullOrEmpty(user) Then
            Dim newClient As New Client(user)
            clients.Add(newClient)
            txtClientName.Clear()
        Else
            MessageBox.Show("Please enter a client name.")
        End If
    End Sub

    Private Sub btnSaveCampaign_Click(sender As Object, e As EventArgs)
        If selectedClient IsNot Nothing Then
            Dim campaignName As String = txtCampaignName.Text
            Dim startDate As Date = dateStartDate.Value
            Dim endDate As Date = dateEndDate.Value
            Dim budget As Decimal
            If Decimal.TryParse(txtBudget.Text, budget) Then
                Dim tMetrics As String = txtTMetrics.Text
                Dim newCampaign As New Campaign(campaignName, startDate, endDate, budget, tMetrics)
                selectedClient.Campaigns.Add(newCampaign)
                txtCampaignName.Clear()
                txtBudget.Clear()
                txtTMetrics.Clear()
                UpdateCampaignListBox(selectedClient)
            Else
                MessageBox.Show("Please enter a valid budget value.")
            End If
        Else
            MessageBox.Show("Please select a client to associate the campaign with.")
        End If
    End Sub

    Private Sub btnSaveMetrics_Click(sender As Object, e As EventArgs)
        If selectedClient IsNot Nothing AndAlso lstCampaigns.SelectedItem IsNot Nothing Then
            Dim clicks As Integer
            Dim conversions As Integer
            Dim impressions As Integer

            If Integer.TryParse(txtClicks.Text, clicks) AndAlso
               Integer.TryParse(txtConversions.Text, conversions) AndAlso
               Integer.TryParse(txtImpressions.Text, impressions) Then

                Dim selectedCampaign As Campaign = TryCast(lstCampaigns.SelectedItem, Campaign)
                If selectedCampaign IsNot Nothing Then
                    Dim newMetric As New PerformanceMetric(clicks, conversions, impressions)
                    selectedCampaign.PMetrics.Add(newMetric)
                    txtClicks.Clear()
                    txtConversions.Clear()
                    txtImpressions.Clear()
                    UpdateMetricListBox(selectedCampaign)
                End If
            Else
                MessageBox.Show("Please enter valid numeric values for metrics.")
            End If
        Else
            MessageBox.Show("Please select both a client and a campaign to log metrics for.")
        End If
    End Sub

    Private Sub lstClients_SelectedIndexChanged(sender As Object, e As EventArgs)
        selectedClient = TryCast(lstClients.SelectedItem, Client)
        UpdateCampaignListBox(selectedClient)
    End Sub

    Private Sub lstCampaigns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCampaigns.SelectedIndexChanged
        Dim selectedCampaign As Campaign = TryCast(lstCampaigns.SelectedItem, Campaign)
        UpdateMetricListBox(selectedCampaign)
    End Sub

    Private Sub UpdateCampaignListBox(client As Client)
        lstCampaigns.DataSource = Nothing
        lstCampaigns.DataSource = client.Campaigns
        lstCampaigns.DisplayMember = "Name"
    End Sub

    Private Sub UpdateMetricListBox(campaign As Campaign)
        lstMetrics.DataSource = Nothing
        lstMetrics.DataSource = campaign.PMetrics
        lstMetrics.DisplayMember = "Clicks"
    End Sub
    Private Sub txtConversions_TextChanged(sender As Object, e As EventArgs) Handles txtConversions.TextChanged

    End Sub
End Class

