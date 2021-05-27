# IO.Swagger.Model.PressEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of library item | 
**Id** | **string** | Unique ID of this item (auto-generated, read-only) | [optional] 
**ExternalId** | **string** | Optional external ID of media item | [optional] 
**Description** | **string** | Press description | [optional] 
**Manufacturer** | **string** | Press manufacturer | [optional] 
**Speed** | **double?** | Speed of press in speed units | [optional] 
**SpeedUnits** | **string** | Speed units | [optional] 
**CostPerHour** | **double?** | Cost to operate this press per hour | [optional] 
**MakeReadyTime** | **double?** | Per-color make ready time in minutes | [optional] 
**NumberOfColors** | **int?** | Maximum number of colors supported on this press | [optional] 
**MinRunLength** | **int?** | Minimum run length allowed for layouts | [optional] 
**BackSinglePass** | **bool?** | Whether this press supports single-pass double sided printing | [optional] 
**Workstyle** | **string** | Workstyle of single-pass double sided printing unit | [optional] 
**BackNumberOfColors** | **int?** | Maximum number of colors supported on back side when doing single-pass double sided printing | [optional] 
**BackSpeedReduction** | **double?** | Percentage of speed reduction when doing single-pass double sided printing | [optional] 
**MultiPass** | **bool?** | Whether to allow multiple passes through this press | [optional] 
**MinSheetWidth** | **string** | Minumum sheet width supported by this press | [optional] 
**MaxSheetWidth** | **string** | Maximum sheet width supported by this press | [optional] 
**MinSheetHeight** | **string** | Minumum sheet height supported by this press | [optional] 
**MaxSheetHeight** | **string** | Minumum sheet width supported by this press | [optional] 
**MinStockThickness** | **string** | Minimum stock thickness supported by this press | [optional] 
**MaxStockThickness** | **string** | Maximum stock thickness supported by this press | [optional] 
**MinStockWeight** | **double?** | Minimum stock weight supported by this press | [optional] 
**MaxStockWeight** | **double?** | Maximum stock weight supported by this press | [optional] 
**WeightUnits** | **string** | Units of min/max stock weight defined for this press.  Defaults to GSM when not specified. | [optional] 
**WeightType** | **string** | Weight type for American standard stock weight system for min/max stock weight defined for this press.  Defaults to Text when not specified. | [optional] 
**SheetHandling** | **string** | Sheet handling option for sheet orientation on this press.  Defaults to None when not specified. | [optional] 
**ImageMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**ContentMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**Gripper** | **string** | Gripper distance from bottom of sheet | [optional] 
**DefaultPlate** | **string** | Optional default plate to use when applying this press to a layout | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

