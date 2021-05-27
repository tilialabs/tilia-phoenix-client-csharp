# IO.Swagger.Model.BoundPart
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID | [optional] 
**Name** | **string** | Name | 
**Grain** | **string** | Part grain | 
**Pages** | [**List&lt;Page&gt;**](Page.md) | Part pages | 
**ProcessSettings** | [**List&lt;ProcessSetting&gt;**](ProcessSetting.md) | Part process settings | 
**Rotation** | [**Rotation**](Rotation.md) |  | 
**PageSize** | [**Size**](Size.md) |  | 
**Sections** | [**List&lt;BoundSection&gt;**](BoundSection.md) | Part sections | 
**BindingMethod** | **string** | Binding method of this part | 
**PagesPerSection** | **int?** | Pages per section in this part | [optional] 
**BindingEdge** | **string** | Binding edge of this part | 
**JogEdge** | **string** | Jog edge of this part | 
**ReadingOrder** | **string** | Reading order of this part | 
**SelfCover** | **bool?** | Whether this part has a self cover or not | 
**Trim** | [**Trim**](Trim.md) |  | 
**Creep** | [**Creep**](Creep.md) |  | 
**AllowedFolds** | [**List&lt;FoldingPattern&gt;**](FoldingPattern.md) | Allowed folds in this part | [optional] 
**Type** | **string** |  | 
**Material** | [**Material**](Material.md) |  | [optional] 
**Processes** | [**List&lt;Process&gt;**](Process.md) | Part processes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

