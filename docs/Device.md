# IO.Swagger.Model.Device
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
**Costing** | [**DeviceCosting**](DeviceCosting.md) |  | 
**Capabilities** | [**DeviceCapabilities**](DeviceCapabilities.md) |  | 
**Script** | [**Reference**](Reference.md) |  | [optional] 
**Manufacturer** | **string** | Manufacturer | 
**MediaRules** | [**MediaRules**](MediaRules.md) |  | 
**Placement** | [**Placement**](Placement.md) |  | 
**ProcessType** | [**ProcessType**](ProcessType.md) |  | 
**FeedType** | **string** | Feed type of this device | 
**Type** | **string** |  | 
**Properties** | [**List&lt;PropertyObject&gt;**](PropertyObject.md) | Custom properties | [optional] 
**Path** | **string** | Path | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

