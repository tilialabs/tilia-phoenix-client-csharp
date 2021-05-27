# IO.Swagger.Model.GradeEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of library item | 
**Id** | **string** | Unique ID of this item (auto-generated, read-only) | [optional] 
**ExternalId** | **string** | Optional external ID of media item | [optional] 
**Description** | **string** | Asset description | [optional] 
**GradeDisplay** | **string** | Grade display | [optional] 
**Weight** | **double?** | Grade weight value | 
**WeightUnits** | **string** | Grade weight units | [optional] 
**WeightType** | **string** | Grade weight type for pound (Lb) standard weights | [optional] 
**Caliper** | **string** | Caliper value | 
**Cost** | **double?** | Cost of grade | [optional] 
**CostUnits** | **string** | Cost unit type of grade | [optional] 
**AnySheetSize** | **bool?** | When true, any sheet size that can fit on a given press is assumed available via a sheet converter, custom order, etc. | [optional] 
**Sheets** | [**List&lt;SheetEntity&gt;**](SheetEntity.md) | List of sheets specified for this grade | [optional] 
**Rolls** | [**List&lt;RollEntity&gt;**](RollEntity.md) | List of rolls specified for this grade | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

