# IO.Swagger.Model.Product
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID | [optional] 
**Name** | **string** | Name | 
**CreatedOn** | **DateTime?** | Created On | [optional] 
**ModifiedOn** | **DateTime?** | Modified On | [optional] 
**Version** | **string** | Version | [optional] 
**Description** | **string** | Description | [optional] 
**Notes** | **string** | Notes | [optional] 
**Quantity** | **int?** | Product order quantity | 
**DueDate** | **DateTime?** | Product due date | [optional] 
**Group** | **string** | Product group | [optional] 
**Priority** | **int?** | Product priority | [optional] 
**Overruns** | [**ScalarRange**](ScalarRange.md) |  | 
**Color** | **int?** | Product color in RGB | 
**Parts** | [**List&lt;PartObject&gt;**](PartObject.md) | Product parts that make up thisproduct | 
**Fulfilled** | **bool?** | Whether order quantities of all components in this product have been fulfilled | [optional] 
**Properties** | [**List&lt;PropertyObject&gt;**](PropertyObject.md) | Custom properties | [optional] 
**Path** | **string** | Path | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

