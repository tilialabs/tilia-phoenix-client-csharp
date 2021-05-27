# IO.Swagger.Api.PresetsAPIApi

All URIs are relative to */phoenix*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddImpositionAiProfiles1**](PresetsAPIApi.md#addimpositionaiprofiles1) | **POST** /presets/imposition-ai | Add new Imposition AI profile
[**DeleteImpositionAiProfiles1**](PresetsAPIApi.md#deleteimpositionaiprofiles1) | **DELETE** /presets/imposition-ai/{profile-id} | Delete Imposition AI profile
[**EditImpositionAiProfiles1**](PresetsAPIApi.md#editimpositionaiprofiles1) | **PUT** /presets/imposition-ai/{profile-id} | Edit Imposition AI profile
[**GetCff2DieExportPresets**](PresetsAPIApi.md#getcff2dieexportpresets) | **GET** /presets/export/die/cff2 | List all CFF2 Die Layout Export Presets
[**GetCff2DieLayoutImportPresets1**](PresetsAPIApi.md#getcff2dielayoutimportpresets1) | **GET** /presets/import/die/cff2 | List all CFF2 Die Layout Import Presets
[**GetCoverSheetExportPresets**](PresetsAPIApi.md#getcoversheetexportpresets) | **GET** /presets/export/cover-sheet | List all Cover Sheet Export Presets
[**GetCuttingJdfExportPresets**](PresetsAPIApi.md#getcuttingjdfexportpresets) | **GET** /presets/export/jdf-cutting | List all JDF Export Presets
[**GetDdes2DieLayoutImportPresets1**](PresetsAPIApi.md#getddes2dielayoutimportpresets1) | **GET** /presets/import/die/ddes2 | List all DDES2 Die Layout Import Presets
[**GetDdes3DieLayoutImportPresets1**](PresetsAPIApi.md#getddes3dielayoutimportpresets1) | **GET** /presets/import/die/ddes3 | List all DDES3 Die Layout Import Presets
[**GetDxfDieLayoutImportPresets1**](PresetsAPIApi.md#getdxfdielayoutimportpresets1) | **GET** /presets/import/die/dxf | List all DXF Die Layout Import Presets
[**GetGangingProfiles**](PresetsAPIApi.md#getgangingprofiles) | **GET** /presets/ganging/profiles | List all Ganging Profiles (Deprecated)
[**GetHpJdfExportPresets**](PresetsAPIApi.md#gethpjdfexportpresets) | **GET** /presets/export/hp-jdf | List all HP JDF Export Presets
[**GetImposedJdfExportPresets**](PresetsAPIApi.md#getimposedjdfexportpresets) | **GET** /presets/export/jdf | List all JDF Export Presets
[**GetImposedPdfExportPresets**](PresetsAPIApi.md#getimposedpdfexportpresets) | **GET** /presets/export/pdf | List all PDF Export Presets
[**GetImpositionAiProfiles**](PresetsAPIApi.md#getimpositionaiprofiles) | **GET** /presets/imposition-ai/{profile-id} | Get Imposition AI profile by ID
[**GetImpositionAiProfiles1**](PresetsAPIApi.md#getimpositionaiprofiles1) | **GET** /presets/imposition-ai | Get list of all Imposition AI profile
[**GetImpositionAiProfiles3**](PresetsAPIApi.md#getimpositionaiprofiles3) | **GET** /presets/imposition-ai/profiles | List all Imposition AI Profiles (Deprecated)
[**GetJsonReportPresets**](PresetsAPIApi.md#getjsonreportpresets) | **GET** /presets/export/report/json | List all JSON Project Report Presets
[**GetPdfDieExportPresets**](PresetsAPIApi.md#getpdfdieexportpresets) | **GET** /presets/export/die/pdf | List all PDF Die Layout Export Presets
[**GetPdfDieLayoutImportPresets1**](PresetsAPIApi.md#getpdfdielayoutimportpresets1) | **GET** /presets/import/die/pdf | List all PDF Die Layout Import Presets
[**GetPdfReportPresets**](PresetsAPIApi.md#getpdfreportpresets) | **GET** /presets/export/report/pdf | List all PDF Project Report Presets
[**GetPdfVectorExportPresets**](PresetsAPIApi.md#getpdfvectorexportpresets) | **GET** /presets/export/pdf-vector | List all PDF Vector Export Presets
[**GetProductCsvImportPresets**](PresetsAPIApi.md#getproductcsvimportpresets) | **GET** /presets/import/product/csv | List all Product CSV Import Presets
[**GetXmlReportPresets**](PresetsAPIApi.md#getxmlreportpresets) | **GET** /presets/export/report/xml | List all XML Project Report Presets

<a name="addimpositionaiprofiles1"></a>
# **AddImpositionAiProfiles1**
> ResponseEntity AddImpositionAiProfiles1 (ImpositionAiProfileEntity body = null)

Add new Imposition AI profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddImpositionAiProfiles1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();
            var body = new ImpositionAiProfileEntity(); // ImpositionAiProfileEntity |  (optional) 

            try
            {
                // Add new Imposition AI profile
                ResponseEntity result = apiInstance.AddImpositionAiProfiles1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.AddImpositionAiProfiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImpositionAiProfileEntity**](ImpositionAiProfileEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteimpositionaiprofiles1"></a>
# **DeleteImpositionAiProfiles1**
> ResponseEntity DeleteImpositionAiProfiles1 (string profileId)

Delete Imposition AI profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteImpositionAiProfiles1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();
            var profileId = profileId_example;  // string | ID of Imposition AI profile to delete

            try
            {
                // Delete Imposition AI profile
                ResponseEntity result = apiInstance.DeleteImpositionAiProfiles1(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.DeleteImpositionAiProfiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| ID of Imposition AI profile to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editimpositionaiprofiles1"></a>
# **EditImpositionAiProfiles1**
> ResponseEntity EditImpositionAiProfiles1 (string profileId, ImpositionAiProfileEntity body = null)

Edit Imposition AI profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditImpositionAiProfiles1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();
            var profileId = profileId_example;  // string | ID of Imposition AI profile to edit
            var body = new ImpositionAiProfileEntity(); // ImpositionAiProfileEntity |  (optional) 

            try
            {
                // Edit Imposition AI profile
                ResponseEntity result = apiInstance.EditImpositionAiProfiles1(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.EditImpositionAiProfiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| ID of Imposition AI profile to edit | 
 **body** | [**ImpositionAiProfileEntity**](ImpositionAiProfileEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcff2dieexportpresets"></a>
# **GetCff2DieExportPresets**
> List<PresetEntity> GetCff2DieExportPresets ()

List all CFF2 Die Layout Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCff2DieExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all CFF2 Die Layout Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetCff2DieExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetCff2DieExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcff2dielayoutimportpresets1"></a>
# **GetCff2DieLayoutImportPresets1**
> List<PresetEntity> GetCff2DieLayoutImportPresets1 ()

List all CFF2 Die Layout Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCff2DieLayoutImportPresets1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all CFF2 Die Layout Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetCff2DieLayoutImportPresets1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetCff2DieLayoutImportPresets1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcoversheetexportpresets"></a>
# **GetCoverSheetExportPresets**
> List<PresetEntity> GetCoverSheetExportPresets ()

List all Cover Sheet Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCoverSheetExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all Cover Sheet Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetCoverSheetExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetCoverSheetExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcuttingjdfexportpresets"></a>
# **GetCuttingJdfExportPresets**
> List<PresetEntity> GetCuttingJdfExportPresets ()

List all JDF Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCuttingJdfExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all JDF Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetCuttingJdfExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetCuttingJdfExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getddes2dielayoutimportpresets1"></a>
# **GetDdes2DieLayoutImportPresets1**
> List<PresetEntity> GetDdes2DieLayoutImportPresets1 ()

List all DDES2 Die Layout Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDdes2DieLayoutImportPresets1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all DDES2 Die Layout Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetDdes2DieLayoutImportPresets1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetDdes2DieLayoutImportPresets1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getddes3dielayoutimportpresets1"></a>
# **GetDdes3DieLayoutImportPresets1**
> List<PresetEntity> GetDdes3DieLayoutImportPresets1 ()

List all DDES3 Die Layout Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDdes3DieLayoutImportPresets1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all DDES3 Die Layout Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetDdes3DieLayoutImportPresets1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetDdes3DieLayoutImportPresets1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdxfdielayoutimportpresets1"></a>
# **GetDxfDieLayoutImportPresets1**
> List<PresetEntity> GetDxfDieLayoutImportPresets1 ()

List all DXF Die Layout Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDxfDieLayoutImportPresets1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all DXF Die Layout Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetDxfDieLayoutImportPresets1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetDxfDieLayoutImportPresets1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgangingprofiles"></a>
# **GetGangingProfiles**
> List<PresetEntity> GetGangingProfiles ()

List all Ganging Profiles (Deprecated)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGangingProfilesExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all Ganging Profiles (Deprecated)
                List&lt;PresetEntity&gt; result = apiInstance.GetGangingProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetGangingProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethpjdfexportpresets"></a>
# **GetHpJdfExportPresets**
> List<PresetEntity> GetHpJdfExportPresets ()

List all HP JDF Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHpJdfExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all HP JDF Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetHpJdfExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetHpJdfExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimposedjdfexportpresets"></a>
# **GetImposedJdfExportPresets**
> List<PresetEntity> GetImposedJdfExportPresets ()

List all JDF Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImposedJdfExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all JDF Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetImposedJdfExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetImposedJdfExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimposedpdfexportpresets"></a>
# **GetImposedPdfExportPresets**
> List<PresetEntity> GetImposedPdfExportPresets ()

List all PDF Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImposedPdfExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all PDF Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetImposedPdfExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetImposedPdfExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimpositionaiprofiles"></a>
# **GetImpositionAiProfiles**
> ImpositionAiProfileEntity GetImpositionAiProfiles (string profileId)

Get Imposition AI profile by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImpositionAiProfilesExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();
            var profileId = profileId_example;  // string | ID of Imposition AI profile to get

            try
            {
                // Get Imposition AI profile by ID
                ImpositionAiProfileEntity result = apiInstance.GetImpositionAiProfiles(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetImpositionAiProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| ID of Imposition AI profile to get | 

### Return type

[**ImpositionAiProfileEntity**](ImpositionAiProfileEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimpositionaiprofiles1"></a>
# **GetImpositionAiProfiles1**
> List<ImpositionAiProfileEntity> GetImpositionAiProfiles1 ()

Get list of all Imposition AI profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImpositionAiProfiles1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // Get list of all Imposition AI profile
                List&lt;ImpositionAiProfileEntity&gt; result = apiInstance.GetImpositionAiProfiles1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetImpositionAiProfiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ImpositionAiProfileEntity>**](ImpositionAiProfileEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimpositionaiprofiles3"></a>
# **GetImpositionAiProfiles3**
> List<PresetEntity> GetImpositionAiProfiles3 ()

List all Imposition AI Profiles (Deprecated)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImpositionAiProfiles3Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all Imposition AI Profiles (Deprecated)
                List&lt;PresetEntity&gt; result = apiInstance.GetImpositionAiProfiles3();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetImpositionAiProfiles3: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getjsonreportpresets"></a>
# **GetJsonReportPresets**
> List<PresetEntity> GetJsonReportPresets ()

List all JSON Project Report Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJsonReportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all JSON Project Report Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetJsonReportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetJsonReportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpdfdieexportpresets"></a>
# **GetPdfDieExportPresets**
> List<PresetEntity> GetPdfDieExportPresets ()

List all PDF Die Layout Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPdfDieExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all PDF Die Layout Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetPdfDieExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetPdfDieExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpdfdielayoutimportpresets1"></a>
# **GetPdfDieLayoutImportPresets1**
> List<PresetEntity> GetPdfDieLayoutImportPresets1 ()

List all PDF Die Layout Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPdfDieLayoutImportPresets1Example
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all PDF Die Layout Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetPdfDieLayoutImportPresets1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetPdfDieLayoutImportPresets1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpdfreportpresets"></a>
# **GetPdfReportPresets**
> List<PresetEntity> GetPdfReportPresets ()

List all PDF Project Report Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPdfReportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all PDF Project Report Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetPdfReportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetPdfReportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpdfvectorexportpresets"></a>
# **GetPdfVectorExportPresets**
> List<PresetEntity> GetPdfVectorExportPresets ()

List all PDF Vector Export Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPdfVectorExportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all PDF Vector Export Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetPdfVectorExportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetPdfVectorExportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductcsvimportpresets"></a>
# **GetProductCsvImportPresets**
> List<PresetEntity> GetProductCsvImportPresets ()

List all Product CSV Import Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductCsvImportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all Product CSV Import Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetProductCsvImportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetProductCsvImportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getxmlreportpresets"></a>
# **GetXmlReportPresets**
> List<PresetEntity> GetXmlReportPresets ()

List all XML Project Report Presets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetXmlReportPresetsExample
    {
        public void main()
        {
            var apiInstance = new PresetsAPIApi();

            try
            {
                // List all XML Project Report Presets
                List&lt;PresetEntity&gt; result = apiInstance.GetXmlReportPresets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresetsAPIApi.GetXmlReportPresets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PresetEntity>**](PresetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
