# IO.Swagger.Model.PhoenixProductEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int?** | Unique item index | [optional] 
**Name** | **string** | Unique name of the product | 
**Color** | **string** | Product color as ARGB hex string | [optional] 
**Ordered** | **int?** | Ordered amount | [optional] 
**Description** | **string** | Product description | [optional] 
**Notes** | **string** | Product notes | [optional] 
**DieName** | **string** | (Deprecated) Product die name | [optional] 
**DieSource** | **string** | (Deprecated) Product die source | [optional] 
**DiePath** | **string** | (Deprecated) Product die source full path | [optional] 
**Stock** | **string** | (Deprecated) Product stock | [optional] 
**Grade** | **string** | (Deprecated) Product grade | [optional] 
**Grain** | **string** | (Deprecated) Grain direction of stock | [optional] 
**Width** | **string** | (Deprecated) Width of product die | [optional] 
**Height** | **string** | (Deprecated) Height of product die | [optional] 
**SpacingType** | **string** | (Deprecated) Spacing type of product | [optional] 
**Group** | **string** | Product group | [optional] 
**Priority** | **int?** | Product priority | [optional] 
**Rotation** | **string** | Rotation type of product | [optional] 
**Templates** | **List&lt;string&gt;** | List of templates this product can be used with | [optional] 
**Placed** | **int?** | Total number of products placed across layouts in the job | [optional] 
**Total** | **int?** | Total number of products to be printed | [optional] 
**Overrun** | **int?** | Total number of overruns above ordered quantity | [optional] 
**Properties** | [**List&lt;PropertyEntity&gt;**](PropertyEntity.md) | Product custom properties | [optional] 
**Layouts** | [**List&lt;LayoutPlacedEntity&gt;**](LayoutPlacedEntity.md) | Number of products placed in each layout | [optional] 
**Thumbnail** | [**ThumbnailEntity**](ThumbnailEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

