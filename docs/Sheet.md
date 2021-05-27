# IO.Swagger.Model.Sheet
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID | [optional] 
**Name** | **string** | Read-only sheet name derived from the sheet dimensions | 
**CreatedOn** | **DateTime?** | Created On | [optional] 
**ModifiedOn** | **DateTime?** | Modified On | [optional] 
**Version** | **string** | Version | [optional] 
**Description** | **string** | Description | [optional] 
**Notes** | **string** | Notes | [optional] 
**ExternalId** | **string** | External ID | [optional] 
**Dimension1** | **string** | First dimension of this sheet | 
**Cost** | **double?** | Cost of this sheet when cost not defined from grade | [optional] 
**CostUnits** | **string** | Cost unit type of this sheet when not defined from grade | [optional] 
**Dimension2** | **string** | Second dimension of this sheet | 
**Grain** | **string** | The grain of this sheet.  Grain is inferred by dimension2 when not specified. | [optional] 
**Type** | **string** |  | 
**Properties** | [**List&lt;PropertyObject&gt;**](PropertyObject.md) | Custom properties | [optional] 
**Path** | **string** | Path | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

