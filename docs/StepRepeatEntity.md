# IO.Swagger.Model.StepRepeatEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rows** | **int?** | Number of rows in step and repeat grid when vertical-fill is not set or is None | [optional] 
**Columns** | **int?** | Number of columns in step and repeat grid when horizontal-fill is not set or is None | [optional] 
**HeadTurn** | **string** | Head turn rotation to apply on every other row and/or column | [optional] 
**InitialRotation** | **double?** | Initial rotation to apply to product when building step and repeat grid | [optional] 
**HorizontalGapType** | **string** | Horizontal gap type defining how horizontal gap(s) are interpreted.  Default: Edge | [optional] 
**VerticalGapType** | **string** | Vertical gap type defining how vertical gap(s) are interpreted.  Default: Edge | [optional] 
**HorizontalGap** | **string** | Horizontal gap scalar value | 
**VerticalGap** | **string** | Vertical gap scalar value | 
**EvenHorizontalGap** | **string** | Optional even horizontal gap scalar value.  When set, horizontal-gap is used for odd horizontal gap spacing while this gap value is used for even rows | [optional] 
**EvenVerticalGap** | **string** | Optional even vertical gap scalar value.  When set, vertical-gap is used for odd vertical gap spacing while this gap value is used for even rows | [optional] 
**Stagger** | **string** | Type of stagger to apply to rows or columns.  If not specified no stagger is applied. | [optional] 
**StaggerAmount** | **string** | Stagger amount when stagger is not None | [optional] 
**StaggerRestart** | **int?** | Number of rows or columns before stagger amount is restarted back to 0.  If not defined, stagger value continues to be applied to each subsequent row or column indefinitely. | [optional] 
**HorizontalFill** | **string** | Whether to automatically fill the sheet as much as possible in the horizontal direction.  By default horizontal-fill is off (None) in which case the columns field needs to be defined. | [optional] 
**VerticalFill** | **string** | Whether to automatically fill the sheet as much as possible in the vertical direction.  By default horizontal-fill is off (None) in which case the rows field needs to be defined. | [optional] 
**SheetMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**BleedOffset** | **string** | When set, a bleed offset is applied to each product in the step and repeat group and rectangular bleeds are automatically resolved.  If not set, product bleed masks are used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

