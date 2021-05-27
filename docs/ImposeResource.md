# IO.Swagger.Model.ImposeResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Idref** | **int?** | ID of action resource is being applied to (Hot Folders only) | [optional] 
**Products** | **List&lt;string&gt;** | Names of products to include.  When not specified all products in the job are included | [optional] 
**Profiles** | **List&lt;string&gt;** | Optional profiles to use when running Imposition AI.  The default profile is used when this field is not set | [optional] 
**ProfilesInline** | [**List&lt;ImpositionAiProfileEntity&gt;**](ImpositionAiProfileEntity.md) | Optional inline fully defined profiles to use when running Imposition AI. | [optional] 
**StopMinutes** | **int?** | Number of minutes to allow this action to run before stopping.  Default is 60 minutes when not specified. | [optional] 
**Templates** | **List&lt;string&gt;** | Names of templates to use during Impose | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

