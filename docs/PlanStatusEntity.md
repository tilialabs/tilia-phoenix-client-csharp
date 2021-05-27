# IO.Swagger.Model.PlanStatusEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | Current state of the given tool in the job | [optional] 
**RunningTime** | **float?** | Number of seconds the given tool has been running or was last run | [optional] 
**Errors** | [**List&lt;MessageEntity&gt;**](MessageEntity.md) | Any errors that have occurred during the current or last run of the given tool | [optional] 
**Warnings** | [**List&lt;MessageEntity&gt;**](MessageEntity.md) | Any warnings that have occurred during the current or last run of the given tool | [optional] 
**Results** | **int?** | Number of results generated | 
**LowestCost** | **float?** | Lowest total cost across all plan results so far | [optional] 
**LowestWaste** | **float?** | Lowest overall waste across all plan results so far | [optional] 
**LowestLayouts** | **int?** | Lowest number of layouts across all plan results so far | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

