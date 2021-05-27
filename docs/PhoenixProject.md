# IO.Swagger.Model.PhoenixProject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Job ID | 
**Name** | **string** | Job name | [optional] 
**Contact** | **string** | Job contact person | [optional] 
**Phone** | **string** | Job phone number | [optional] 
**_Client** | **string** | Job client name | [optional] 
**Notes** | **string** | Job notes | [optional] 
**Units** | **string** | Job units | [optional] 
**TemplatePath** | **string** | Job template path if job created from template | [optional] 
**RunLength** | **int?** | Total required run length of all layouts in project | [optional] 
**PressMinutes** | **float?** | Total estimated press time across project | [optional] 
**PlateCost** | **double?** | Total estimated plate costs across project | [optional] 
**StockCost** | **double?** | Total estimated stock costs across project | [optional] 
**PressCost** | **double?** | Total estimated press run costs across project | [optional] 
**DieCost** | **double?** | Total estimated die creation costs across project | [optional] 
**TotalCost** | **double?** | Total project cost | [optional] 
**Waste** | **double?** | Average sheet waste percentage across the project | [optional] 
**SheetUsage** | **double?** | Average sheet usage percentage across project | [optional] 
**Underrun** | **double?** | Average product underrun percentage across project | [optional] 
**Overrun** | **double?** | Average product overrun percentage across project | [optional] 
**LayoutCount** | **int?** | Number of layouts in the job | [optional] 
**Facility** | [**Facility**](Facility.md) |  | [optional] 
**Layouts** | [**List&lt;PhoenixLayoutEntity&gt;**](PhoenixLayoutEntity.md) | Layouts in the project | [optional] 
**Products** | [**List&lt;PhoenixProductEntity&gt;**](PhoenixProductEntity.md) | Products in the project in v1 format | [optional] 
**Products2** | [**List&lt;Product&gt;**](Product.md) | Products in the project in v2 format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

