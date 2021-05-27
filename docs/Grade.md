# IO.Swagger.Model.Grade
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID | [optional] 
**Name** | **string** | Read-only grade name derived from weight and/or caliper of the grade depending on grade display | 
**CreatedOn** | **DateTime?** | Created On | [optional] 
**ModifiedOn** | **DateTime?** | Modified On | [optional] 
**Version** | **string** | Version | [optional] 
**Description** | **string** | Description | [optional] 
**Notes** | **string** | Notes | [optional] 
**ExternalId** | **string** | External ID | [optional] 
**GradeDisplay** | **string** | Grade display | [optional] 
**Weight** | **double?** | Grade weight value | 
**WeightUnits** | **string** | Grade weight units | [optional] 
**WeightType** | **string** | Grade weight type for pound (Lb) standard weights | [optional] 
**Caliper** | **string** | Caliper value | 
**Cost** | **double?** | Cost of grade | [optional] 
**CostUnits** | **string** | Cost unit type of grade | [optional] 
**AnySheetSize** | **bool?** | When true, any sheet size that can fit on a given press is assumed available via a sheet converter, custom order, etc. | [optional] 
**Sheets** | [**List&lt;Sheet&gt;**](Sheet.md) | List of sheets specified for this grade | [optional] 
**Rolls** | [**List&lt;Roll&gt;**](Roll.md) | List of rolls specified for this grade | [optional] 
**Properties** | [**List&lt;PropertyObject&gt;**](PropertyObject.md) | Custom properties | [optional] 
**Path** | **string** | Path | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

