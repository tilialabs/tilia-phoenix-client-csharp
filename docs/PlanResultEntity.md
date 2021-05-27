# IO.Swagger.Model.PlanResultEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID of result | [optional] 
**Timestamp** | **float?** | Time this result was generated as measured in seconds since the start of this run | [optional] 
**PendingEstimations** | **bool?** | Whether this result has one or more pending estimations that have not been performed and could lead to more accurate cost and time estimates | [optional] 
**PressMinutes** | **float?** | Total estimated press time in minutes | [optional] 
**CuttingTime** | **float?** | Estimated total cutting time in seconds | [optional] 
**RunLength** | **int?** | Total run lengths across all layouts | [optional] 
**TotalCost** | **float?** | Total estimated cost for the job including all material and device costs | [optional] 
**PlateCost** | **float?** | Estimated total plate cost | [optional] 
**StockCost** | **float?** | Estimated total stock cost | [optional] 
**PressCost** | **float?** | Estimated total press run cost | [optional] 
**CuttingCost** | **float?** | Estimated total cutting cost | [optional] 
**Waste** | **float?** | Total sheet waste percentage | [optional] 
**SheetUsage** | **float?** | Sheet usage percentage per sheet | [optional] 
**TotalUnderruns** | **int?** | Total number of underrun items | [optional] 
**TotalOverruns** | **int?** | Total number of overrun items | [optional] 
**LayoutCount** | **int?** | Number of layouts in this plan result | [optional] 
**Layouts** | [**List&lt;LayoutResultEntity&gt;**](LayoutResultEntity.md) | Optional results for each layout | [optional] 
**Thumbnail** | [**ThumbnailEntity**](ThumbnailEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

