# IO.Swagger.Model.LayoutResultEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID of result | [optional] 
**Timestamp** | **float?** | Time this result was generated as measured in seconds since the start of this run | [optional] 
**PendingEstimations** | **bool?** | Whether this result has one or more pending estimations that have not been performed and could lead to more accurate cost and time estimates | [optional] 
**LayoutType** | **string** | Type of layout generated | [optional] 
**Sheet** | **string** | Sheet size used in layout result | [optional] 
**Things** | **List&lt;string&gt;** | Things used to process this layout | [optional] 
**RunLength** | **int?** | Required run length of layout | [optional] 
**PressMinutes** | **float?** | Estimated press time in minutes | [optional] 
**CuttingTime** | **float?** | Estimated cutting time in seconds | [optional] 
**TotalCost** | **float?** | Total estimated cost for the layout including all material and device costs | [optional] 
**PlateCost** | **float?** | Estimated plate cost | [optional] 
**StockCost** | **float?** | Estimated stock cost | [optional] 
**PressCost** | **float?** | Estimated press run cost | [optional] 
**CuttingCost** | **float?** | Estimated cutting cost | [optional] 
**Waste** | **float?** | Total sheet waste percentage | [optional] 
**SheetUsage** | **float?** | Sheet usage percentage per sheet | [optional] 
**MaxOverrun** | **float?** | Maximum overrun percentage across products in the layout | [optional] 
**TotalOverruns** | **int?** | Total number of overrun items | [optional] 
**Placed** | **int?** | (Deprecated, use items.count) Total number of component items placed in layout | [optional] 
**Items** | [**ItemStatsEntity**](ItemStatsEntity.md) |  | [optional] 
**CutComplexity** | **int?** | Estimated cutting complexity of layout | [optional] 
**Templates** | [**List&lt;PlacedTemplateEntity&gt;**](PlacedTemplateEntity.md) | All templates being used in layout | [optional] 
**Thumbnail** | [**ThumbnailEntity**](ThumbnailEntity.md) |  | [optional] 
**Press** | **string** | (Deprecated) Press used in layout result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

