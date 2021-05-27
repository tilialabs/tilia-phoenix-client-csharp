# IO.Swagger.Model.SheetFedDigitalPress
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
**ExternalId** | **string** | External ID | [optional] 
**AllowPassThrough** | **bool?** | Allow pass-through | [optional] 
**Connections** | [**List&lt;Connector&gt;**](Connector.md) | Direct connections to other things | [optional] 
**Costing** | [**SfdpCosting**](SfdpCosting.md) |  | 
**Capabilities** | [**PressCapabilities**](PressCapabilities.md) |  | 
**Script** | [**Reference**](Reference.md) |  | [optional] 
**Manufacturer** | **string** | Manufacturer | 
**MediaRules** | [**PressMediaRules**](PressMediaRules.md) |  | 
**Placement** | [**PressPlacement**](PressPlacement.md) |  | 
**Operation** | [**OperationModes**](OperationModes.md) |  | 
**FrontUnits** | [**PressUnits**](PressUnits.md) |  | 
**SinglePassDoubleSided** | **bool?** | Single Pass Double Sided | [optional] 
**BackUnits** | [**PressUnits**](PressUnits.md) |  | [optional] 
**DoubleSidedSpeedReduction** | **string** | Double Sided Speed Reduction | [optional] 
**Gripper** | **string** | Gripper | [optional] 
**SheetTurn** | **string** | Sheet Turn | 
**FeedType** | **string** | Feed type of this device | 
**Type** | **string** |  | 
**ProcessType** | [**ProcessType**](ProcessType.md) |  | 
**Properties** | [**List&lt;PropertyObject&gt;**](PropertyObject.md) | Custom properties | [optional] 
**Path** | **string** | Path | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

