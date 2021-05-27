# IO.Swagger.Model.ImportDieDesignEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of template asset to create including folders if desired.  If name is not specified, file name minus extension will be used as the name. | [optional] 
**Id** | **string** | ID of asset to use.  If not specified a unique ID will be generated. | [optional] 
**CreateFolder** | **bool?** | Boolean controlling whether to create a folder when folder or parent folder(s) does not exist.  By default non-existent folders are not created automatically. | [optional] 
**Path** | **string** | Full path of template file to import | 
**Preset** | **string** | Name of preset to use during import | [optional] 
**DieName** | **string** | Name of die in CAD file to import.  By default if die name is not specified and the CAD file contains multiple dies, the first die listed in the CAD data is used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

