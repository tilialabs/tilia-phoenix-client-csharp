# IO.Swagger.Model.DmResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status | 
**Processes** | **List&lt;string&gt;** | Processes involved | [optional] 
**Time** | [**TimeInfo**](TimeInfo.md) |  | [optional] 
**Cost** | [**CostInfo**](CostInfo.md) |  | [optional] 
**Messages** | [**List&lt;Message&gt;**](Message.md) | Messages reported during processing | [optional] 
**ExternalMessages** | [**List&lt;Message&gt;**](Message.md) | Messages reported by a third-party external estimation engine during processing | [optional] 
**DieType** | **string** | Die type | 
**NumberUps** | **int?** | Number of positions or \&quot;ups\&quot; in die | 
**RuleStats** | [**List&lt;DmRuleStats&gt;**](DmRuleStats.md) | Rule stats | [optional] 
**Type** | **string** |  | 
**CostPerUps** | **string** | Per-die position cost | [optional] 
**CostPerArea** | **string** | Per-area cost | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

