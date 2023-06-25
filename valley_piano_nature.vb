Option Explicit

'Declare Project Variables
Dim numFamilies, numIndividuals, numDistributionCenters, numRecipients, numVolunteers As Integer
Dim foodItems, foodProviders, storageFacilities, nutritionPrograms, foodDonations As String
Dim foodCost, foodDeliveryCost, storageCost, logisticsCost, advertisingCost As Double

'Initialize Project Variables
numFamilies = 0
numIndividuals = 0
numDistributionCenters = 0
numRecipients = 0
numVolunteers = 0
foodItems = ""
foodProviders = ""
storageFacilities = ""
nutritionPrograms = ""
foodDonations = ""
foodCost = 0
foodDeliveryCost = 0
storageCost = 0
logisticsCost = 0
advertisingCost = 0

'Define Project Parameters
Function DefineProjectParams()
   numFamilies = Inputbox("Input number of families in need:")
   numIndividuals = Inputbox("Input number of individuals in need:")
   numDistributionCenters = Inputbox("Input number of distribution centers:")
   numRecipients = Inputbox("Input number of total recipients:")
   numVolunteers = Inputbox("Input number of volunteers:")
   foodItems = Inputbox("Input types of food items:")
   foodProviders = Inputbox("Input food providers:")
   storageFacilities = Inputbox("Input storage facilities:")
   nutritionPrograms = Inputbox("Input nutrition programs:")
   foodDonations = Inputbox("Input food donations:")
   foodCost = Inputbox("Input cost of food:")
   foodDeliveryCost = Inputbox("Input cost of food delivery:")
   storageCost = Inputbox("Input cost of storage:")
   logisticsCost = Inputbox("Input cost of logistics:")
   advertisingCost = Inputbox("Input cost of advertising:")
End Function

'Calculate Food Costs
Function CalculateFoodCosts()
   foodCost = (numFamilies * foodItems) + (numIndividuals * foodItems)
   foodDeliveryCost = (numFamilies * foodItems * foodProviders) + (numIndividuals * foodItems * foodProviders)
End Function

'Calculate Storage Costs
Function CalculateStorageCosts()
    storageCost = (numDistributionCenters * storageFacilities)
    logisticsCost = (numRecipients * foodDeliveryCost)
End Function

'Calculate Advertising Costs
Function CalculateAdvertisingCosts()
    advertisingCost = (numVolunteers * nutritionPrograms) + (numRecipients * foodDonations)
End Function

'Main Subroutine
Sub Main()
    DefineProjectParams
    CalculateFoodCosts
    CalculateStorageCosts
    CalculateAdvertisingCosts
End Sub

'Invoke Main Subroutine
Main