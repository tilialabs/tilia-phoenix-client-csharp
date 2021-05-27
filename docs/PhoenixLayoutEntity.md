# IO.Swagger.Model.PhoenixLayoutEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Layout id | [optional] 
**Index** | **int?** | Layout index | [optional] 
**Name** | **string** | Layout name | [optional] 
**Workstyle** | **string** | Workstyle of layout | [optional] 
**Trails** | [**List&lt;JobTrail&gt;**](JobTrail.md) | Facility job trails processing this layout | [optional] 
**RunLength** | **int?** | Required run length of layout | [optional] 
**PressMinutes** | **float?** | Estimated press time in minutes | [optional] 
**Plates** | **int?** | Number of plates needed (print inks) | [optional] 
**PlateCost** | **double?** | Estimated plate cost in layout | [optional] 
**StockCost** | **double?** | Estimated stock cost in layout | [optional] 
**PressCost** | **double?** | Estimated press run cost in layout | [optional] 
**DieCost** | **double?** | Estimated die creation cost in layout | [optional] 
**TotalCost** | **double?** | Estimated total layout cost | [optional] 
**Waste** | **double?** | Total sheet waste percentage | [optional] 
**SheetUsage** | **double?** | Sheet usage percentage per sheet | [optional] 
**Underrun** | **double?** | Product underrun percentage in layout | [optional] 
**Overrun** | **double?** | Product overrun percentage in layout | [optional] 
**Placed** | **int?** | Total number of pieces placed in layout | [optional] 
**ProductCount** | **int?** | Total number of unique products in layout | [optional] 
**Random** | **string** | Random unique layout identifier | [optional] 
**Templates** | [**List&lt;PlacedTemplateEntity&gt;**](PlacedTemplateEntity.md) | All templates being used in layout | [optional] 
**ToolStats** | [**ToolStatsEntity**](ToolStatsEntity.md) |  | [optional] 
**PriorityStats** | [**List&lt;PriorityStatsEntity&gt;**](PriorityStatsEntity.md) | Product priority-based stats | [optional] 
**Surfaces** | [**List&lt;SurfaceEntity&gt;**](SurfaceEntity.md) | Surfaces in layout | [optional] 
**Front** | [**SurfaceEntity**](SurfaceEntity.md) |  | [optional] 
**Back** | [**SurfaceEntity**](SurfaceEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

