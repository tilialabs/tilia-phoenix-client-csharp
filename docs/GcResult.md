# IO.Swagger.Model.GcResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status | 
**Processes** | **List&lt;string&gt;** | Processes involved | [optional] 
**Time** | [**TimeInfo**](TimeInfo.md) |  | [optional] 
**Cost** | [**CostInfo**](CostInfo.md) |  | [optional] 
**Messages** | [**List&lt;Message&gt;**](Message.md) | Messages reported during processing | [optional] 
**ExternalMessages** | [**List&lt;Message&gt;**](Message.md) | Messages reported by a third-party external estimation engine during processing | [optional] 
**ProcessType** | **string** | Process type | [optional] 
**SetupTime** | [**TimeInfo**](TimeInfo.md) |  | [optional] 
**TotalLayouts** | **int?** | Total number of layouts being processed by this device including setup, waste, and produced layouts | [optional] 
**SheetTurns** | **int?** | Number of sheet turns | 
**Stacks** | **int?** | Number of stacks that need to be cut | 
**Type** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

