# IO.Swagger.Model.SheetEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of library item | 
**Id** | **string** | Unique ID of this item (auto-generated, read-only) | [optional] 
**ExternalId** | **string** | Optional external ID of media item | [optional] 
**Description** | **string** | Asset description | [optional] 
**StockId** | **string** | ID of the stock of this sheet | [optional] 
**GradeId** | **string** | ID of the grade of this sheet | [optional] 
**Dimension1** | **string** | First dimension of this sheet | 
**Dimension2** | **string** | Second dimension of this sheet | 
**Cost** | **double?** | Cost of this sheet when cost not defined from grade | [optional] 
**CostUnits** | **string** | Cost unit type of this sheet when not defined from grade | [optional] 
**Grain** | **string** | The grain of this sheet.  Grain is inferred by dimension2 when not specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

