# IO.Swagger.Api.ProjectsAPIApi

All URIs are relative to */phoenix*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyImposeResult1**](ProjectsAPIApi.md#applyimposeresult1) | **POST** /jobs/{projectid}/impose/{layoutindex}/result/{resultid}/apply | Apply result from most recent Impose run
[**ApplyOptimizeResult1**](ProjectsAPIApi.md#applyoptimizeresult1) | **POST** /jobs/{projectid}/optimize/{layoutindex}/result/{resultid}/apply | Apply result from most recent Optimize run
[**ApplyPartialPlan1**](ProjectsAPIApi.md#applypartialplan1) | **POST** /jobs/{projectid}/plan/results/{resultid}/apply/{start}/{end} | Apply result from most recent plan run
[**ApplyPlanResult1**](ProjectsAPIApi.md#applyplanresult1) | **POST** /jobs/{projectid}/plan/results/{resultid}/apply | Apply result from most recent plan run
[**ApplyPopulateResult1**](ProjectsAPIApi.md#applypopulateresult1) | **POST** /jobs/{projectid}/populate/{layoutindex}/result/{resultid}/apply | Apply result from most recent Populate run
[**ApplyProductMark**](ProjectsAPIApi.md#applyproductmark) | **POST** /jobs/{projectid}/products/{productname}/marks/apply | Apply a smart product mark to this product
[**CreateJob**](ProjectsAPIApi.md#createjob) | **POST** /jobs | Create a new project
[**CreateLayout1**](ProjectsAPIApi.md#createlayout1) | **POST** /jobs/{projectid}/layouts | Create a new layout
[**CreateProduct1**](ProjectsAPIApi.md#createproduct1) | **POST** /jobs/{projectid}/products | Create new product
[**DeleteJob1**](ProjectsAPIApi.md#deletejob1) | **DELETE** /jobs/{projectid} | Close the project with ID of {projectid}
[**DeleteLayout1**](ProjectsAPIApi.md#deletelayout1) | **DELETE** /jobs/{projectid}/layouts/{layoutindex} | Delete layout from the project by index
[**DeleteOutputFile1**](ProjectsAPIApi.md#deleteoutputfile1) | **DELETE** /jobs/{projectid}/files/output/{fileid} | Delete output project files from this project with specific file ID
[**DeleteProduct1**](ProjectsAPIApi.md#deleteproduct1) | **DELETE** /jobs/{projectid}/products/{productname} | Delete product with name {productname} from the project
[**DeleteUploadedFile1**](ProjectsAPIApi.md#deleteuploadedfile1) | **DELETE** /jobs/{projectid}/files/upload/{fileid} | Delete uploaded project file from this project
[**DownloadOutputFile1**](ProjectsAPIApi.md#downloadoutputfile1) | **GET** /jobs/{projectid}/files/output/{fileid}/{filepath} | Download specific output file content
[**DownloadUploadedFile1**](ProjectsAPIApi.md#downloaduploadedfile1) | **GET** /jobs/{projectid}/files/upload/{fileid}/{filepath} | Download specific uploaded file content
[**EditLayout1**](ProjectsAPIApi.md#editlayout1) | **PUT** /jobs/{projectid}/layouts/{layoutindex} | Edit layout properties
[**ExportCff2DieLayout**](ProjectsAPIApi.md#exportcff2dielayout) | **POST** /jobs/{projectid}/export/die/cff2 | Export CFF2 Die Layout of current project
[**ExportCoverSheet**](ProjectsAPIApi.md#exportcoversheet) | **POST** /jobs/{projectid}/export/cover-sheet | Export layout cover sheet(s) of the given project
[**ExportCuttingJdf**](ProjectsAPIApi.md#exportcuttingjdf) | **POST** /jobs/{projectid}/export/jdf-cutting | Export JDF Cutting Data of the given project
[**ExportDxfDieLayout**](ProjectsAPIApi.md#exportdxfdielayout) | **POST** /jobs/{projectid}/export/die/dxf | Export DXF Die Layout of current project
[**ExportHpJdf**](ProjectsAPIApi.md#exporthpjdf) | **POST** /jobs/{projectid}/export/hp-jdf | Export HP JDF of the given project
[**ExportImposedJdf**](ProjectsAPIApi.md#exportimposedjdf) | **POST** /jobs/{projectid}/export/jdf | Export Layout JDF of the given project
[**ExportImposedPdf**](ProjectsAPIApi.md#exportimposedpdf) | **POST** /jobs/{projectid}/export/pdf | Export Layout PDF of current project
[**ExportJsonReport1**](ProjectsAPIApi.md#exportjsonreport1) | **POST** /jobs/{projectid}/export/report/json | Export JSON Project Report of the given project
[**ExportPdfDieLayout**](ProjectsAPIApi.md#exportpdfdielayout) | **POST** /jobs/{projectid}/export/die/pdf | Export PDF Die Layout of current project
[**ExportPdfReport**](ProjectsAPIApi.md#exportpdfreport) | **POST** /jobs/{projectid}/export/report/pdf | Export PDF Project Report of the given project
[**ExportProductTilingReport**](ProjectsAPIApi.md#exportproducttilingreport) | **POST** /jobs/{projectid}/products/{productname}/export/tiling-report | Export Tiling report of the given product
[**ExportTilingReport**](ProjectsAPIApi.md#exporttilingreport) | **POST** /jobs/{projectid}/export/tiling-report | Export Tiling report of the given project
[**ExportVectorPdf**](ProjectsAPIApi.md#exportvectorpdf) | **POST** /jobs/{projectid}/export/pdf-vector | Export Vector Separation of the given project
[**ExportXmlReport1**](ProjectsAPIApi.md#exportxmlreport1) | **POST** /jobs/{projectid}/export/report/xml | Export XML Project Report of the given project
[**ExportZcc**](ProjectsAPIApi.md#exportzcc) | **POST** /jobs/{projectid}/export/die/zcc | Export Zund Cut Center Layout of current project
[**GetImposeResult1**](ProjectsAPIApi.md#getimposeresult1) | **GET** /jobs/{projectid}/impose/{layoutindex}/result/{resultid} | A single Impose result by ID
[**GetImposeResults1**](ProjectsAPIApi.md#getimposeresults1) | **GET** /jobs/{projectid}/impose/{layoutindex}/results | A list of most recent Impose results
[**GetJob1**](ProjectsAPIApi.md#getjob1) | **GET** /jobs/{projectid} | Get project at current {projectid}
[**GetJobs**](ProjectsAPIApi.md#getjobs) | **GET** /jobs | Get a list of all projects
[**GetLayout1**](ProjectsAPIApi.md#getlayout1) | **GET** /jobs/{projectid}/layouts/{layoutindex} | Get project layout by index
[**GetLayoutBack1**](ProjectsAPIApi.md#getlayoutback1) | **GET** /jobs/{projectid}/layouts/{layoutindex}/back | Get back side of layout
[**GetLayoutFront1**](ProjectsAPIApi.md#getlayoutfront1) | **GET** /jobs/{projectid}/layouts/{layoutindex}/front | Get front side of layout
[**GetLayoutPlate1**](ProjectsAPIApi.md#getlayoutplate1) | **GET** /jobs/{projectid}/layouts/{layoutindex}/plate | Get layout plate
[**GetLayoutPress1**](ProjectsAPIApi.md#getlayoutpress1) | **GET** /jobs/{projectid}/layouts/{layoutindex}/press | Get layout press
[**GetLayoutSheet1**](ProjectsAPIApi.md#getlayoutsheet1) | **GET** /jobs/{projectid}/layouts/{layoutindex}/sheet | Get layout sheet
[**GetLayouts1**](ProjectsAPIApi.md#getlayouts1) | **GET** /jobs/{projectid}/layouts | Get list of all layouts in the project
[**GetOptimizeResult1**](ProjectsAPIApi.md#getoptimizeresult1) | **GET** /jobs/{projectid}/optimize/{layoutindex}/result/{resultid} | A single Optimize result by ID
[**GetOptimizeResults1**](ProjectsAPIApi.md#getoptimizeresults1) | **GET** /jobs/{projectid}/optimize/{layoutindex}/results | A list of most recent Optimize results
[**GetOutputFile1**](ProjectsAPIApi.md#getoutputfile1) | **GET** /jobs/{projectid}/files/output/{fileid} | Get output project file by ID
[**GetOutputFiles1**](ProjectsAPIApi.md#getoutputfiles1) | **GET** /jobs/{projectid}/files/output | Get all output files currently saved to this project
[**GetPlanResult1**](ProjectsAPIApi.md#getplanresult1) | **GET** /jobs/{projectid}/plan/results/{resultid} | A single plan result by ID
[**GetPlanResults1**](ProjectsAPIApi.md#getplanresults1) | **GET** /jobs/{projectid}/plan/results | A list of most recent Plan results
[**GetPopulateResult1**](ProjectsAPIApi.md#getpopulateresult1) | **GET** /jobs/{projectid}/populate/{layoutindex}/result/{resultid} | A single Populate result by ID
[**GetPopulateResults1**](ProjectsAPIApi.md#getpopulateresults1) | **GET** /jobs/{projectid}/populate/{layoutindex}/results | A list of most recent Populate results
[**GetProduct1**](ProjectsAPIApi.md#getproduct1) | **GET** /jobs/{projectid}/products/{productname} | Get product with name of {productname}
[**GetProducts1**](ProjectsAPIApi.md#getproducts1) | **GET** /jobs/{projectid}/products | Get all products of the current project
[**GetUploadedFile1**](ProjectsAPIApi.md#getuploadedfile1) | **GET** /jobs/{projectid}/files/upload/{fileid} | Get uploaded project file by ID
[**GetUploadedFiles1**](ProjectsAPIApi.md#getuploadedfiles1) | **GET** /jobs/{projectid}/files/upload | Get all files currently uploaded to this project
[**ImportDieTemplate1**](ProjectsAPIApi.md#importdietemplate1) | **POST** /jobs/{projectid}/import/die-template | Import die template
[**ImportProductCsv**](ProjectsAPIApi.md#importproductcsv) | **POST** /jobs/{projectid}/products/import/csv | Import products from CSV file
[**Impose1**](ProjectsAPIApi.md#impose1) | **POST** /jobs/{projectid}/impose/{layoutindex} | Run Impose tool to generate layouts
[**OpenJob**](ProjectsAPIApi.md#openjob) | **POST** /jobs/open | Open existing project file
[**Optimize1**](ProjectsAPIApi.md#optimize1) | **POST** /jobs/{projectid}/optimize/{layoutindex} | Run Optimize tool to generate layouts
[**PlaceDieTemplate**](ProjectsAPIApi.md#placedietemplate) | **POST** /jobs/{projectid}/layouts/{layoutindex}/place/die-template | Place die template
[**Plan1**](ProjectsAPIApi.md#plan1) | **POST** /jobs/{projectid}/plan | Run Plan tool to generate project plans
[**PlanStart1**](ProjectsAPIApi.md#planstart1) | **POST** /jobs/{projectid}/plan/start | Start running Plan tool asynchronously to generate project plans
[**PlanStatus1**](ProjectsAPIApi.md#planstatus1) | **GET** /jobs/{projectid}/plan/status | Get current plan tool running status
[**PlanStop1**](ProjectsAPIApi.md#planstop1) | **POST** /jobs/{projectid}/plan/stop | Stop plan tool if it is currently running
[**Populate1**](ProjectsAPIApi.md#populate1) | **POST** /jobs/{projectid}/populate/{layoutindex} | Run Populate tool to generate layouts
[**ResizeLayoutSheet1**](ProjectsAPIApi.md#resizelayoutsheet1) | **PUT** /jobs/{projectid}/layouts/{layoutindex}/sheet | Resize layout sheet
[**Run**](ProjectsAPIApi.md#run) | **POST** /jobs/{projectid}/script | Run a script on the current project
[**SaveJob1**](ProjectsAPIApi.md#savejob1) | **POST** /jobs/{projectid}/save | Save project
[**SaveJobTemplate**](ProjectsAPIApi.md#savejobtemplate) | **POST** /jobs/{projectid}/save-template | Save project template
[**SetLayoutPlate1**](ProjectsAPIApi.md#setlayoutplate1) | **POST** /jobs/{projectid}/layouts/{layoutindex}/plate | Set layout plate
[**SetLayoutPress1**](ProjectsAPIApi.md#setlayoutpress1) | **POST** /jobs/{projectid}/layouts/{layoutindex}/press | Set layout press
[**SetLayoutSheet1**](ProjectsAPIApi.md#setlayoutsheet1) | **POST** /jobs/{projectid}/layouts/{layoutindex}/sheet | Set layout sheet
[**Snap**](ProjectsAPIApi.md#snap) | **POST** /jobs/{projectid}/snap | Snap artwork to products or die numbers in project
[**SnapProduct**](ProjectsAPIApi.md#snapproduct) | **POST** /jobs/{projectid}/products/{productname}/snap | Snap artwork to a given side of the product
[**StepRepeat**](ProjectsAPIApi.md#steprepeat) | **POST** /jobs/{projectid}/layouts/{layoutindex}/step-repeat | Generate step and repeat group
[**UploadFile1**](ProjectsAPIApi.md#uploadfile1) | **POST** /jobs/{projectid}/files/upload | Upload new file to project

<a name="applyimposeresult1"></a>
# **ApplyImposeResult1**
> ResponseEntity ApplyImposeResult1 (int? layoutindex, int? resultid, string projectid)

Apply result from most recent Impose run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyImposeResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | Id of result to apply
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Apply result from most recent Impose run
                ResponseEntity result = apiInstance.ApplyImposeResult1(layoutindex, resultid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyImposeResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| Id of result to apply | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applyoptimizeresult1"></a>
# **ApplyOptimizeResult1**
> ResponseEntity ApplyOptimizeResult1 (int? layoutindex, int? resultid, string projectid)

Apply result from most recent Optimize run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyOptimizeResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | Id of result to apply
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Apply result from most recent Optimize run
                ResponseEntity result = apiInstance.ApplyOptimizeResult1(layoutindex, resultid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyOptimizeResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| Id of result to apply | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applypartialplan1"></a>
# **ApplyPartialPlan1**
> ResponseEntity ApplyPartialPlan1 (int? resultid, int? start, int? end, string projectid)

Apply result from most recent plan run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyPartialPlan1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var resultid = 56;  // int? | Id of result to apply
            var start = 56;  // int? | First layout to apply from plan starting from 1
            var end = 56;  // int? | Last layout to apply from plan
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Apply result from most recent plan run
                ResponseEntity result = apiInstance.ApplyPartialPlan1(resultid, start, end, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyPartialPlan1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resultid** | **int?**| Id of result to apply | 
 **start** | **int?**| First layout to apply from plan starting from 1 | 
 **end** | **int?**| Last layout to apply from plan | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applyplanresult1"></a>
# **ApplyPlanResult1**
> ResponseEntity ApplyPlanResult1 (int? resultid, string projectid)

Apply result from most recent plan run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyPlanResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var resultid = 56;  // int? | Id of result to apply
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Apply result from most recent plan run
                ResponseEntity result = apiInstance.ApplyPlanResult1(resultid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyPlanResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resultid** | **int?**| Id of result to apply | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applypopulateresult1"></a>
# **ApplyPopulateResult1**
> ResponseEntity ApplyPopulateResult1 (int? layoutindex, int? resultid, string projectid)

Apply result from most recent Populate run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyPopulateResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | Id of result to apply
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Apply result from most recent Populate run
                ResponseEntity result = apiInstance.ApplyPopulateResult1(layoutindex, resultid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyPopulateResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| Id of result to apply | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applyproductmark"></a>
# **ApplyProductMark**
> ResponseEntity ApplyProductMark (string productname, string projectid, ApplyMarkResource body = null)

Apply a smart product mark to this product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplyProductMarkExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var productname = productname_example;  // string | 
            var projectid = projectid_example;  // string | ID of the job
            var body = new ApplyMarkResource(); // ApplyMarkResource |  (optional) 

            try
            {
                // Apply a smart product mark to this product
                ResponseEntity result = apiInstance.ApplyProductMark(productname, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ApplyProductMark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productname** | **string**|  | 
 **projectid** | **string**| ID of the job | 
 **body** | [**ApplyMarkResource**](ApplyMarkResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createjob"></a>
# **CreateJob**
> ResponseEntity CreateJob (CreateJobResource body = null)

Create a new project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateJobExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var body = new CreateJobResource(); // CreateJobResource |  (optional) 

            try
            {
                // Create a new project
                ResponseEntity result = apiInstance.CreateJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.CreateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateJobResource**](CreateJobResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createlayout1"></a>
# **CreateLayout1**
> PhoenixLayoutEntity CreateLayout1 (string projectid)

Create a new layout

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLayout1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Create a new layout
                PhoenixLayoutEntity result = apiInstance.CreateLayout1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.CreateLayout1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**PhoenixLayoutEntity**](PhoenixLayoutEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproduct1"></a>
# **CreateProduct1**
> ResponseEntity CreateProduct1 (string projectid, AddProductEntity body = null)

Create new product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProduct1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new AddProductEntity(); // AddProductEntity |  (optional) 

            try
            {
                // Create new product
                ResponseEntity result = apiInstance.CreateProduct1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.CreateProduct1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**AddProductEntity**](AddProductEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletejob1"></a>
# **DeleteJob1**
> ResponseEntity DeleteJob1 (string projectid)

Close the project with ID of {projectid}

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteJob1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Close the project with ID of {projectid}
                ResponseEntity result = apiInstance.DeleteJob1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DeleteJob1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletelayout1"></a>
# **DeleteLayout1**
> ResponseEntity DeleteLayout1 (int? layoutindex, string projectid)

Delete layout from the project by index

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLayout1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Delete layout from the project by index
                ResponseEntity result = apiInstance.DeleteLayout1(layoutindex, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DeleteLayout1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteoutputfile1"></a>
# **DeleteOutputFile1**
> ResponseEntity DeleteOutputFile1 (string fileid, string projectid)

Delete output project files from this project with specific file ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOutputFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of uploaded project file to get
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Delete output project files from this project with specific file ID
                ResponseEntity result = apiInstance.DeleteOutputFile1(fileid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DeleteOutputFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of uploaded project file to get | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproduct1"></a>
# **DeleteProduct1**
> ResponseEntity DeleteProduct1 (string productname, string projectid)

Delete product with name {productname} from the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProduct1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var productname = productname_example;  // string | 
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Delete product with name {productname} from the project
                ResponseEntity result = apiInstance.DeleteProduct1(productname, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DeleteProduct1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productname** | **string**|  | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuploadedfile1"></a>
# **DeleteUploadedFile1**
> ResponseEntity DeleteUploadedFile1 (string fileid, string projectid)

Delete uploaded project file from this project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUploadedFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of uploaded project file to get
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Delete uploaded project file from this project
                ResponseEntity result = apiInstance.DeleteUploadedFile1(fileid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DeleteUploadedFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of uploaded project file to get | 
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadoutputfile1"></a>
# **DownloadOutputFile1**
> List<byte[]> DownloadOutputFile1 (string fileid, string filepath, string projectid)

Download specific output file content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadOutputFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of output project file to get
            var filepath = filepath_example;  // string | Relative path of specific file contents to download
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Download specific output file content
                List&lt;byte[]&gt; result = apiInstance.DownloadOutputFile1(fileid, filepath, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DownloadOutputFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of output project file to get | 
 **filepath** | **string**| Relative path of specific file contents to download | 
 **projectid** | **string**| ID of the job | 

### Return type

**List<byte[]>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloaduploadedfile1"></a>
# **DownloadUploadedFile1**
> List<byte[]> DownloadUploadedFile1 (string fileid, string filepath, string projectid)

Download specific uploaded file content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadUploadedFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of uploaded project file to get
            var filepath = filepath_example;  // string | Relative path of specific file contents to download
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Download specific uploaded file content
                List&lt;byte[]&gt; result = apiInstance.DownloadUploadedFile1(fileid, filepath, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.DownloadUploadedFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of uploaded project file to get | 
 **filepath** | **string**| Relative path of specific file contents to download | 
 **projectid** | **string**| ID of the job | 

### Return type

**List<byte[]>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editlayout1"></a>
# **EditLayout1**
> ResponseEntity EditLayout1 (int? layoutindex, string projectid, EditLayoutResource body = null)

Edit layout properties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditLayout1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new EditLayoutResource(); // EditLayoutResource |  (optional) 

            try
            {
                // Edit layout properties
                ResponseEntity result = apiInstance.EditLayout1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.EditLayout1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**EditLayoutResource**](EditLayoutResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportcff2dielayout"></a>
# **ExportCff2DieLayout**
> ResponseEntity ExportCff2DieLayout (string projectid, ExportCff2LayoutResource body = null)

Export CFF2 Die Layout of current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportCff2DieLayoutExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportCff2LayoutResource(); // ExportCff2LayoutResource |  (optional) 

            try
            {
                // Export CFF2 Die Layout of current project
                ResponseEntity result = apiInstance.ExportCff2DieLayout(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportCff2DieLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportCff2LayoutResource**](ExportCff2LayoutResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportcoversheet"></a>
# **ExportCoverSheet**
> ResponseEntity ExportCoverSheet (string projectid, ExportCoverSheetResource body = null)

Export layout cover sheet(s) of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportCoverSheetExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportCoverSheetResource(); // ExportCoverSheetResource |  (optional) 

            try
            {
                // Export layout cover sheet(s) of the given project
                ResponseEntity result = apiInstance.ExportCoverSheet(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportCoverSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportCoverSheetResource**](ExportCoverSheetResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportcuttingjdf"></a>
# **ExportCuttingJdf**
> ResponseEntity ExportCuttingJdf (string projectid, ExportCuttingJdfResource body = null)

Export JDF Cutting Data of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportCuttingJdfExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportCuttingJdfResource(); // ExportCuttingJdfResource |  (optional) 

            try
            {
                // Export JDF Cutting Data of the given project
                ResponseEntity result = apiInstance.ExportCuttingJdf(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportCuttingJdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportCuttingJdfResource**](ExportCuttingJdfResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportdxfdielayout"></a>
# **ExportDxfDieLayout**
> ResponseEntity ExportDxfDieLayout (string projectid, ExportDxfLayoutResource body = null)

Export DXF Die Layout of current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportDxfDieLayoutExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportDxfLayoutResource(); // ExportDxfLayoutResource |  (optional) 

            try
            {
                // Export DXF Die Layout of current project
                ResponseEntity result = apiInstance.ExportDxfDieLayout(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportDxfDieLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportDxfLayoutResource**](ExportDxfLayoutResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exporthpjdf"></a>
# **ExportHpJdf**
> ResponseEntity ExportHpJdf (string projectid, ExportHpJdfResource body = null)

Export HP JDF of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportHpJdfExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportHpJdfResource(); // ExportHpJdfResource |  (optional) 

            try
            {
                // Export HP JDF of the given project
                ResponseEntity result = apiInstance.ExportHpJdf(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportHpJdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportHpJdfResource**](ExportHpJdfResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportimposedjdf"></a>
# **ExportImposedJdf**
> ResponseEntity ExportImposedJdf (string projectid, ExportJdfResource body = null)

Export Layout JDF of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportImposedJdfExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportJdfResource(); // ExportJdfResource |  (optional) 

            try
            {
                // Export Layout JDF of the given project
                ResponseEntity result = apiInstance.ExportImposedJdf(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportImposedJdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportJdfResource**](ExportJdfResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportimposedpdf"></a>
# **ExportImposedPdf**
> ResponseEntity ExportImposedPdf (string projectid, ExportPdfResource body = null)

Export Layout PDF of current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportImposedPdfExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportPdfResource(); // ExportPdfResource |  (optional) 

            try
            {
                // Export Layout PDF of current project
                ResponseEntity result = apiInstance.ExportImposedPdf(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportImposedPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportPdfResource**](ExportPdfResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportjsonreport1"></a>
# **ExportJsonReport1**
> ResponseEntity ExportJsonReport1 (string projectid, ExportJsonReportResource body = null)

Export JSON Project Report of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportJsonReport1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportJsonReportResource(); // ExportJsonReportResource |  (optional) 

            try
            {
                // Export JSON Project Report of the given project
                ResponseEntity result = apiInstance.ExportJsonReport1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportJsonReport1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportJsonReportResource**](ExportJsonReportResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportpdfdielayout"></a>
# **ExportPdfDieLayout**
> ResponseEntity ExportPdfDieLayout (string projectid, ExportPdfLayoutResource body = null)

Export PDF Die Layout of current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportPdfDieLayoutExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportPdfLayoutResource(); // ExportPdfLayoutResource |  (optional) 

            try
            {
                // Export PDF Die Layout of current project
                ResponseEntity result = apiInstance.ExportPdfDieLayout(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportPdfDieLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportPdfLayoutResource**](ExportPdfLayoutResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportpdfreport"></a>
# **ExportPdfReport**
> ResponseEntity ExportPdfReport (string projectid, ExportPdfReportResource body = null)

Export PDF Project Report of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportPdfReportExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportPdfReportResource(); // ExportPdfReportResource |  (optional) 

            try
            {
                // Export PDF Project Report of the given project
                ResponseEntity result = apiInstance.ExportPdfReport(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportPdfReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportPdfReportResource**](ExportPdfReportResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportproducttilingreport"></a>
# **ExportProductTilingReport**
> ResponseEntity ExportProductTilingReport (string productname, string projectid, ExportTilingReportResource body = null)

Export Tiling report of the given product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportProductTilingReportExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var productname = productname_example;  // string | 
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportTilingReportResource(); // ExportTilingReportResource |  (optional) 

            try
            {
                // Export Tiling report of the given product
                ResponseEntity result = apiInstance.ExportProductTilingReport(productname, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportProductTilingReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productname** | **string**|  | 
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportTilingReportResource**](ExportTilingReportResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exporttilingreport"></a>
# **ExportTilingReport**
> ResponseEntity ExportTilingReport (string projectid, ExportTilingReportResource body = null)

Export Tiling report of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportTilingReportExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportTilingReportResource(); // ExportTilingReportResource |  (optional) 

            try
            {
                // Export Tiling report of the given project
                ResponseEntity result = apiInstance.ExportTilingReport(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportTilingReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportTilingReportResource**](ExportTilingReportResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportvectorpdf"></a>
# **ExportVectorPdf**
> ResponseEntity ExportVectorPdf (string projectid, ExportVectorSeparationResource body = null)

Export Vector Separation of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportVectorPdfExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportVectorSeparationResource(); // ExportVectorSeparationResource |  (optional) 

            try
            {
                // Export Vector Separation of the given project
                ResponseEntity result = apiInstance.ExportVectorPdf(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportVectorPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportVectorSeparationResource**](ExportVectorSeparationResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportxmlreport1"></a>
# **ExportXmlReport1**
> ResponseEntity ExportXmlReport1 (string projectid, ExportXmlReportResource body = null)

Export XML Project Report of the given project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportXmlReport1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportXmlReportResource(); // ExportXmlReportResource |  (optional) 

            try
            {
                // Export XML Project Report of the given project
                ResponseEntity result = apiInstance.ExportXmlReport1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportXmlReport1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportXmlReportResource**](ExportXmlReportResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportzcc"></a>
# **ExportZcc**
> ResponseEntity ExportZcc (string projectid, ExportZccLayoutResource body = null)

Export Zund Cut Center Layout of current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportZccExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ExportZccLayoutResource(); // ExportZccLayoutResource |  (optional) 

            try
            {
                // Export Zund Cut Center Layout of current project
                ResponseEntity result = apiInstance.ExportZcc(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ExportZcc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ExportZccLayoutResource**](ExportZccLayoutResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimposeresult1"></a>
# **GetImposeResult1**
> LayoutResultEntity GetImposeResult1 (int? layoutindex, int? resultid, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A single Impose result by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImposeResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | ID of result to retrieve
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A single Impose result by ID
                LayoutResultEntity result = apiInstance.GetImposeResult1(layoutindex, resultid, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetImposeResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| ID of result to retrieve | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**LayoutResultEntity**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getimposeresults1"></a>
# **GetImposeResults1**
> List<LayoutResultEntity> GetImposeResults1 (int? layoutindex, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A list of most recent Impose results

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImposeResults1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail images or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A list of most recent Impose results
                List&lt;LayoutResultEntity&gt; result = apiInstance.GetImposeResults1(layoutindex, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetImposeResults1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail images or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**List<LayoutResultEntity>**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getjob1"></a>
# **GetJob1**
> PhoenixProject GetJob1 (string projectid, string productVersion = null)

Get project at current {projectid}

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJob1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var productVersion = productVersion_example;  // string | Product model version (optional)  (default to V1)

            try
            {
                // Get project at current {projectid}
                PhoenixProject result = apiInstance.GetJob1(projectid, productVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetJob1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **productVersion** | **string**| Product model version | [optional] [default to V1]

### Return type

[**PhoenixProject**](PhoenixProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getjobs"></a>
# **GetJobs**
> List<PhoenixProject> GetJobs ()

Get a list of all projects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJobsExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();

            try
            {
                // Get a list of all projects
                List&lt;PhoenixProject&gt; result = apiInstance.GetJobs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PhoenixProject>**](PhoenixProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayout1"></a>
# **GetLayout1**
> PhoenixLayoutEntity GetLayout1 (int? layoutindex, string projectid, bool? frontThumb = null, bool? backThumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get project layout by index

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayout1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var frontThumb = true;  // bool? | Whether to include thumbnail image of the front surface of this layout (optional)  (default to false)
            var backThumb = true;  // bool? | Whether to include thumbnail image of the back surface of this layout (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image(s) (optional)  (default to Colors)

            try
            {
                // Get project layout by index
                PhoenixLayoutEntity result = apiInstance.GetLayout1(layoutindex, projectid, frontThumb, backThumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayout1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **frontThumb** | **bool?**| Whether to include thumbnail image of the front surface of this layout | [optional] [default to false]
 **backThumb** | **bool?**| Whether to include thumbnail image of the back surface of this layout | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image(s) | [optional] [default to Colors]

### Return type

[**PhoenixLayoutEntity**](PhoenixLayoutEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayoutback1"></a>
# **GetLayoutBack1**
> SurfaceEntity GetLayoutBack1 (int? layoutindex, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get back side of layout

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutBack1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Whether to include thumbnail image of surface (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // Get back side of layout
                SurfaceEntity result = apiInstance.GetLayoutBack1(layoutindex, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayoutBack1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Whether to include thumbnail image of surface | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**SurfaceEntity**](SurfaceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayoutfront1"></a>
# **GetLayoutFront1**
> SurfaceEntity GetLayoutFront1 (int? layoutindex, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get front side of layout

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutFront1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Whether to include thumbnail image of surface (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // Get front side of layout
                SurfaceEntity result = apiInstance.GetLayoutFront1(layoutindex, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayoutFront1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Whether to include thumbnail image of surface | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**SurfaceEntity**](SurfaceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayoutplate1"></a>
# **GetLayoutPlate1**
> PlateEntity GetLayoutPlate1 (int? layoutindex, string projectid)

Get layout plate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutPlate1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get layout plate
                PlateEntity result = apiInstance.GetLayoutPlate1(layoutindex, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayoutPlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 

### Return type

[**PlateEntity**](PlateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayoutpress1"></a>
# **GetLayoutPress1**
> PressEntity GetLayoutPress1 (int? layoutindex, string projectid)

Get layout press

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutPress1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get layout press
                PressEntity result = apiInstance.GetLayoutPress1(layoutindex, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayoutPress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 

### Return type

[**PressEntity**](PressEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayoutsheet1"></a>
# **GetLayoutSheet1**
> SheetEntity GetLayoutSheet1 (int? layoutindex, string projectid)

Get layout sheet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayoutSheet1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get layout sheet
                SheetEntity result = apiInstance.GetLayoutSheet1(layoutindex, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayoutSheet1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 

### Return type

[**SheetEntity**](SheetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlayouts1"></a>
# **GetLayouts1**
> List<PhoenixLayoutEntity> GetLayouts1 (string projectid, bool? frontThumb = null, bool? backThumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get list of all layouts in the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLayouts1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var frontThumb = true;  // bool? | Whether to include thumbnail images of the front surfaces of the layouts (optional)  (default to false)
            var backThumb = true;  // bool? | Whether to include thumbnail images of the back surfaces of the layouts (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail images (optional)  (default to Colors)

            try
            {
                // Get list of all layouts in the project
                List&lt;PhoenixLayoutEntity&gt; result = apiInstance.GetLayouts1(projectid, frontThumb, backThumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetLayouts1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **frontThumb** | **bool?**| Whether to include thumbnail images of the front surfaces of the layouts | [optional] [default to false]
 **backThumb** | **bool?**| Whether to include thumbnail images of the back surfaces of the layouts | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail images | [optional] [default to Colors]

### Return type

[**List<PhoenixLayoutEntity>**](PhoenixLayoutEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoptimizeresult1"></a>
# **GetOptimizeResult1**
> LayoutResultEntity GetOptimizeResult1 (int? layoutindex, int? resultid, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A single Optimize result by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOptimizeResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | ID of result to retrieve
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A single Optimize result by ID
                LayoutResultEntity result = apiInstance.GetOptimizeResult1(layoutindex, resultid, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetOptimizeResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| ID of result to retrieve | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**LayoutResultEntity**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoptimizeresults1"></a>
# **GetOptimizeResults1**
> List<LayoutResultEntity> GetOptimizeResults1 (int? layoutindex, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A list of most recent Optimize results

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOptimizeResults1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail images or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A list of most recent Optimize results
                List&lt;LayoutResultEntity&gt; result = apiInstance.GetOptimizeResults1(layoutindex, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetOptimizeResults1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail images or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**List<LayoutResultEntity>**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoutputfile1"></a>
# **GetOutputFile1**
> JobFilesEntity GetOutputFile1 (string fileid, string projectid)

Get output project file by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of output project file to get
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get output project file by ID
                JobFilesEntity result = apiInstance.GetOutputFile1(fileid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetOutputFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of output project file to get | 
 **projectid** | **string**| ID of the job | 

### Return type

[**JobFilesEntity**](JobFilesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoutputfiles1"></a>
# **GetOutputFiles1**
> List<JobFilesEntity> GetOutputFiles1 (string projectid)

Get all output files currently saved to this project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputFiles1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get all output files currently saved to this project
                List&lt;JobFilesEntity&gt; result = apiInstance.GetOutputFiles1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetOutputFiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**List<JobFilesEntity>**](JobFilesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getplanresult1"></a>
# **GetPlanResult1**
> PlanResultEntity GetPlanResult1 (int? resultid, string projectid, bool? layouts = null, bool? thumb = null, bool? planThumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A single plan result by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var resultid = 56;  // int? | ID of result to retrieve
            var projectid = projectid_example;  // string | ID of the job
            var layouts = true;  // bool? | Include individual layout results (optional)  (default to false)
            var thumb = true;  // bool? | Include thumbnail images in layout results or not (optional)  (default to false)
            var planThumb = true;  // bool? | Include composite thumbnail image of layouts in plan result or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in layout result thumbnail images (optional)  (default to Colors)

            try
            {
                // A single plan result by ID
                PlanResultEntity result = apiInstance.GetPlanResult1(resultid, projectid, layouts, thumb, planThumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetPlanResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resultid** | **int?**| ID of result to retrieve | 
 **projectid** | **string**| ID of the job | 
 **layouts** | **bool?**| Include individual layout results | [optional] [default to false]
 **thumb** | **bool?**| Include thumbnail images in layout results or not | [optional] [default to false]
 **planThumb** | **bool?**| Include composite thumbnail image of layouts in plan result or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in layout result thumbnail images | [optional] [default to Colors]

### Return type

[**PlanResultEntity**](PlanResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getplanresults1"></a>
# **GetPlanResults1**
> List<PlanResultEntity> GetPlanResults1 (string projectid, int? limit = null, int? start = null, string sorting = null, bool? layouts = null, bool? thumb = null, bool? planThumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A list of most recent Plan results

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanResults1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var limit = 56;  // int? | Optional limit to number of results returned.  0 or not-specified signifies return all results. (optional)  (default to 0)
            var start = 56;  // int? | Optional 1-based start index of results after sorting (optional)  (default to 0)
            var sorting = sorting_example;  // string | Optional sorting to control order of results.  By default results are sorted by lowest cost first. (optional)  (default to Cost)
            var layouts = true;  // bool? | Include individual layout results (optional)  (default to false)
            var thumb = true;  // bool? | Include individual thumbnail images in layout results or not (optional)  (default to false)
            var planThumb = true;  // bool? | Include composite thumbnail image of layouts in plan result or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in layout result thumbnail images.  Note: Artwork rendering can be compute intensive and result in slow response times, especially when there are many results being returned. (optional)  (default to Colors)

            try
            {
                // A list of most recent Plan results
                List&lt;PlanResultEntity&gt; result = apiInstance.GetPlanResults1(projectid, limit, start, sorting, layouts, thumb, planThumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetPlanResults1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **limit** | **int?**| Optional limit to number of results returned.  0 or not-specified signifies return all results. | [optional] [default to 0]
 **start** | **int?**| Optional 1-based start index of results after sorting | [optional] [default to 0]
 **sorting** | **string**| Optional sorting to control order of results.  By default results are sorted by lowest cost first. | [optional] [default to Cost]
 **layouts** | **bool?**| Include individual layout results | [optional] [default to false]
 **thumb** | **bool?**| Include individual thumbnail images in layout results or not | [optional] [default to false]
 **planThumb** | **bool?**| Include composite thumbnail image of layouts in plan result or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in layout result thumbnail images.  Note: Artwork rendering can be compute intensive and result in slow response times, especially when there are many results being returned. | [optional] [default to Colors]

### Return type

[**List<PlanResultEntity>**](PlanResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpopulateresult1"></a>
# **GetPopulateResult1**
> LayoutResultEntity GetPopulateResult1 (int? layoutindex, int? resultid, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A single Populate result by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPopulateResult1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var resultid = 56;  // int? | ID of result to retrieve
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A single Populate result by ID
                LayoutResultEntity result = apiInstance.GetPopulateResult1(layoutindex, resultid, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetPopulateResult1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **resultid** | **int?**| ID of result to retrieve | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**LayoutResultEntity**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpopulateresults1"></a>
# **GetPopulateResults1**
> List<LayoutResultEntity> GetPopulateResults1 (int? layoutindex, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

A list of most recent Populate results

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPopulateResults1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Include thumbnail images or not (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // A list of most recent Populate results
                List&lt;LayoutResultEntity&gt; result = apiInstance.GetPopulateResults1(layoutindex, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetPopulateResults1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Include thumbnail images or not | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**List<LayoutResultEntity>**](LayoutResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproduct1"></a>
# **GetProduct1**
> PhoenixProductEntity GetProduct1 (string productname, string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get product with name of {productname}

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProduct1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var productname = productname_example;  // string | 
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Whether to include thumbnail image of product (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail image (optional)  (default to Colors)

            try
            {
                // Get product with name of {productname}
                PhoenixProductEntity result = apiInstance.GetProduct1(productname, projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetProduct1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productname** | **string**|  | 
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Whether to include thumbnail image of product | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail image | [optional] [default to Colors]

### Return type

[**PhoenixProductEntity**](PhoenixProductEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproducts1"></a>
# **GetProducts1**
> List<PhoenixProductEntity> GetProducts1 (string projectid, bool? thumb = null, int? thumbWidth = null, int? thumbHeight = null, string renderMode = null)

Get all products of the current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProducts1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var thumb = true;  // bool? | Whether to include thumbnail image of products (optional)  (default to false)
            var thumbWidth = 56;  // int? | Thumbnail width in pixels (optional)  (default to 200)
            var thumbHeight = 56;  // int? | Thumbnail height in pixels (optional)  (default to 200)
            var renderMode = renderMode_example;  // string | Render mode to use in thumbnail images (optional)  (default to Colors)

            try
            {
                // Get all products of the current project
                List&lt;PhoenixProductEntity&gt; result = apiInstance.GetProducts1(projectid, thumb, thumbWidth, thumbHeight, renderMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetProducts1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **thumb** | **bool?**| Whether to include thumbnail image of products | [optional] [default to false]
 **thumbWidth** | **int?**| Thumbnail width in pixels | [optional] [default to 200]
 **thumbHeight** | **int?**| Thumbnail height in pixels | [optional] [default to 200]
 **renderMode** | **string**| Render mode to use in thumbnail images | [optional] [default to Colors]

### Return type

[**List<PhoenixProductEntity>**](PhoenixProductEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuploadedfile1"></a>
# **GetUploadedFile1**
> JobFilesEntity GetUploadedFile1 (string fileid, string projectid)

Get uploaded project file by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUploadedFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var fileid = fileid_example;  // string | ID of uploaded project file to get
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get uploaded project file by ID
                JobFilesEntity result = apiInstance.GetUploadedFile1(fileid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetUploadedFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileid** | **string**| ID of uploaded project file to get | 
 **projectid** | **string**| ID of the job | 

### Return type

[**JobFilesEntity**](JobFilesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuploadedfiles1"></a>
# **GetUploadedFiles1**
> List<JobFilesEntity> GetUploadedFiles1 (string projectid)

Get all files currently uploaded to this project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUploadedFiles1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get all files currently uploaded to this project
                List&lt;JobFilesEntity&gt; result = apiInstance.GetUploadedFiles1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.GetUploadedFiles1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**List<JobFilesEntity>**](JobFilesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="importdietemplate1"></a>
# **ImportDieTemplate1**
> ResponseEntity ImportDieTemplate1 (string projectid, ImportDieTemplateResource body = null)

Import die template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportDieTemplate1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ImportDieTemplateResource(); // ImportDieTemplateResource |  (optional) 

            try
            {
                // Import die template
                ResponseEntity result = apiInstance.ImportDieTemplate1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ImportDieTemplate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ImportDieTemplateResource**](ImportDieTemplateResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="importproductcsv"></a>
# **ImportProductCsv**
> ResponseEntity ImportProductCsv (string projectid, ImportProductCsvResource body = null)

Import products from CSV file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportProductCsvExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new ImportProductCsvResource(); // ImportProductCsvResource |  (optional) 

            try
            {
                // Import products from CSV file
                ResponseEntity result = apiInstance.ImportProductCsv(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ImportProductCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**ImportProductCsvResource**](ImportProductCsvResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="impose1"></a>
# **Impose1**
> ResponseEntity Impose1 (int? layoutindex, string projectid, ImposeResource body = null)

Run Impose tool to generate layouts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Impose1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new ImposeResource(); // ImposeResource |  (optional) 

            try
            {
                // Run Impose tool to generate layouts
                ResponseEntity result = apiInstance.Impose1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Impose1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**ImposeResource**](ImposeResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="openjob"></a>
# **OpenJob**
> ResponseEntity OpenJob (FormDataContentDisposition file = null)

Open existing project file

The file needs to be updated via form data.  The filename content disposition header excluding filename extension is used to define the project ID if present, otherwise the existing project ID in the project is used.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenJobExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var file = new FormDataContentDisposition(); // FormDataContentDisposition |  (optional) 

            try
            {
                // Open existing project file
                ResponseEntity result = apiInstance.OpenJob(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.OpenJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | [**FormDataContentDisposition**](FormDataContentDisposition.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="optimize1"></a>
# **Optimize1**
> ResponseEntity Optimize1 (int? layoutindex, string projectid, OptimizeResource body = null)

Run Optimize tool to generate layouts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Optimize1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new OptimizeResource(); // OptimizeResource |  (optional) 

            try
            {
                // Run Optimize tool to generate layouts
                ResponseEntity result = apiInstance.Optimize1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Optimize1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**OptimizeResource**](OptimizeResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placedietemplate"></a>
# **PlaceDieTemplate**
> ResponseEntity PlaceDieTemplate (int? layoutindex, string projectid, PlaceDieTemplateResource body = null)

Place die template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaceDieTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new PlaceDieTemplateResource(); // PlaceDieTemplateResource |  (optional) 

            try
            {
                // Place die template
                ResponseEntity result = apiInstance.PlaceDieTemplate(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.PlaceDieTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**PlaceDieTemplateResource**](PlaceDieTemplateResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="plan1"></a>
# **Plan1**
> ResponseEntity Plan1 (string projectid, PlanResource body = null)

Run Plan tool to generate project plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Plan1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new PlanResource(); // PlanResource |  (optional) 

            try
            {
                // Run Plan tool to generate project plans
                ResponseEntity result = apiInstance.Plan1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Plan1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**PlanResource**](PlanResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="planstart1"></a>
# **PlanStart1**
> ResponseEntity PlanStart1 (string projectid, PlanResource body = null)

Start running Plan tool asynchronously to generate project plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlanStart1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new PlanResource(); // PlanResource |  (optional) 

            try
            {
                // Start running Plan tool asynchronously to generate project plans
                ResponseEntity result = apiInstance.PlanStart1(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.PlanStart1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**PlanResource**](PlanResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="planstatus1"></a>
# **PlanStatus1**
> PlanStatusEntity PlanStatus1 (string projectid)

Get current plan tool running status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlanStatus1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Get current plan tool running status
                PlanStatusEntity result = apiInstance.PlanStatus1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.PlanStatus1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**PlanStatusEntity**](PlanStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="planstop1"></a>
# **PlanStop1**
> ResponseEntity PlanStop1 (string projectid)

Stop plan tool if it is currently running

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlanStop1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job

            try
            {
                // Stop plan tool if it is currently running
                ResponseEntity result = apiInstance.PlanStop1(projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.PlanStop1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="populate1"></a>
# **Populate1**
> ResponseEntity Populate1 (int? layoutindex, string projectid, PopulateResource body = null)

Run Populate tool to generate layouts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Populate1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new PopulateResource(); // PopulateResource |  (optional) 

            try
            {
                // Run Populate tool to generate layouts
                ResponseEntity result = apiInstance.Populate1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Populate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**PopulateResource**](PopulateResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resizelayoutsheet1"></a>
# **ResizeLayoutSheet1**
> ResponseEntity ResizeLayoutSheet1 (int? layoutindex, string projectid, ResizeSheetResource body = null)

Resize layout sheet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResizeLayoutSheet1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new ResizeSheetResource(); // ResizeSheetResource |  (optional) 

            try
            {
                // Resize layout sheet
                ResponseEntity result = apiInstance.ResizeLayoutSheet1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.ResizeLayoutSheet1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**ResizeSheetResource**](ResizeSheetResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="run"></a>
# **Run**
> ResponseEntity Run (string projectid, RunScriptResource body = null)

Run a script on the current project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new RunScriptResource(); // RunScriptResource |  (optional) 

            try
            {
                // Run a script on the current project
                ResponseEntity result = apiInstance.Run(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Run: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**RunScriptResource**](RunScriptResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="savejob1"></a>
# **SaveJob1**
> void SaveJob1 (string projectid, SaveJobResource body = null)

Save project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveJob1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new SaveJobResource(); // SaveJobResource |  (optional) 

            try
            {
                // Save project
                apiInstance.SaveJob1(projectid, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SaveJob1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**SaveJobResource**](SaveJobResource.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="savejobtemplate"></a>
# **SaveJobTemplate**
> ResponseEntity SaveJobTemplate (string projectid, SaveJobTemplateResource body = null)

Save project template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveJobTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new SaveJobTemplateResource(); // SaveJobTemplateResource |  (optional) 

            try
            {
                // Save project template
                ResponseEntity result = apiInstance.SaveJobTemplate(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SaveJobTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**SaveJobTemplateResource**](SaveJobTemplateResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setlayoutplate1"></a>
# **SetLayoutPlate1**
> ResponseEntity SetLayoutPlate1 (int? layoutindex, string projectid, SetPlateResource body = null)

Set layout plate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetLayoutPlate1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new SetPlateResource(); // SetPlateResource |  (optional) 

            try
            {
                // Set layout plate
                ResponseEntity result = apiInstance.SetLayoutPlate1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SetLayoutPlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**SetPlateResource**](SetPlateResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setlayoutpress1"></a>
# **SetLayoutPress1**
> ResponseEntity SetLayoutPress1 (int? layoutindex, string projectid, SetPressResource body = null)

Set layout press

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetLayoutPress1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new SetPressResource(); // SetPressResource |  (optional) 

            try
            {
                // Set layout press
                ResponseEntity result = apiInstance.SetLayoutPress1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SetLayoutPress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**SetPressResource**](SetPressResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setlayoutsheet1"></a>
# **SetLayoutSheet1**
> ResponseEntity SetLayoutSheet1 (int? layoutindex, string projectid, SetSheetResource body = null)

Set layout sheet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetLayoutSheet1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new SetSheetResource(); // SetSheetResource |  (optional) 

            try
            {
                // Set layout sheet
                ResponseEntity result = apiInstance.SetLayoutSheet1(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SetLayoutSheet1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**SetSheetResource**](SetSheetResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="snap"></a>
# **Snap**
> ResponseEntity Snap (string projectid, AutosnapResource body = null)

Snap artwork to products or die numbers in project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SnapExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var body = new AutosnapResource(); // AutosnapResource |  (optional) 

            try
            {
                // Snap artwork to products or die numbers in project
                ResponseEntity result = apiInstance.Snap(projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.Snap: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **body** | [**AutosnapResource**](AutosnapResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="snapproduct"></a>
# **SnapProduct**
> ResponseEntity SnapProduct (string productname, string projectid, AutosnapArtworkEntity body = null)

Snap artwork to a given side of the product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SnapProductExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var productname = productname_example;  // string | 
            var projectid = projectid_example;  // string | ID of the job
            var body = new AutosnapArtworkEntity(); // AutosnapArtworkEntity |  (optional) 

            try
            {
                // Snap artwork to a given side of the product
                ResponseEntity result = apiInstance.SnapProduct(productname, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.SnapProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productname** | **string**|  | 
 **projectid** | **string**| ID of the job | 
 **body** | [**AutosnapArtworkEntity**](AutosnapArtworkEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="steprepeat"></a>
# **StepRepeat**
> ResponseEntity StepRepeat (int? layoutindex, string projectid, StepRepeatResource body = null)

Generate step and repeat group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StepRepeatExample
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var layoutindex = 56;  // int? | Index of layout
            var projectid = projectid_example;  // string | ID of the job
            var body = new StepRepeatResource(); // StepRepeatResource |  (optional) 

            try
            {
                // Generate step and repeat group
                ResponseEntity result = apiInstance.StepRepeat(layoutindex, projectid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.StepRepeat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutindex** | **int?**| Index of layout | 
 **projectid** | **string**| ID of the job | 
 **body** | [**StepRepeatResource**](StepRepeatResource.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadfile1"></a>
# **UploadFile1**
> ResponseEntity UploadFile1 (string projectid, FormDataContentDisposition file = null)

Upload new file to project

The URI returned in the response entity can be used to download the file content directly or referred to when adding products.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectsAPIApi();
            var projectid = projectid_example;  // string | ID of the job
            var file = new FormDataContentDisposition(); // FormDataContentDisposition |  (optional) 

            try
            {
                // Upload new file to project
                ResponseEntity result = apiInstance.UploadFile1(projectid, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsAPIApi.UploadFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectid** | **string**| ID of the job | 
 **file** | [**FormDataContentDisposition**](FormDataContentDisposition.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
