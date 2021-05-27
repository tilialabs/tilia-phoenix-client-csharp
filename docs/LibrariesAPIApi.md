# IO.Swagger.Api.LibrariesAPIApi

All URIs are relative to */phoenix*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGrade**](LibrariesAPIApi.md#addgrade) | **POST** /libraries/stocks/{stockid}/grades | Add new grade to stock
[**AddMode1**](LibrariesAPIApi.md#addmode1) | **POST** /libraries/modes | Add new mode
[**AddPlate1**](LibrariesAPIApi.md#addplate1) | **POST** /libraries/plates | Add new plate
[**AddPress1**](LibrariesAPIApi.md#addpress1) | **POST** /libraries/presses | Add new press
[**AddProcess1**](LibrariesAPIApi.md#addprocess1) | **POST** /libraries/processes | Add new process
[**AddProcessType1**](LibrariesAPIApi.md#addprocesstype1) | **POST** /libraries/processtypes | Add new process type
[**AddRoll**](LibrariesAPIApi.md#addroll) | **POST** /libraries/stocks/{stockid}/grades/{gradeid}/rolls | Add new roll to grade
[**AddSheet**](LibrariesAPIApi.md#addsheet) | **POST** /libraries/stocks/{stockid}/grades/{gradeid}/sheets | Add new sheet to grade
[**AddStock1**](LibrariesAPIApi.md#addstock1) | **POST** /libraries/stocks | Add new stock
[**AddStock2**](LibrariesAPIApi.md#addstock2) | **POST** /libraries/v2/stocks | Add new stock
[**AddStockType1**](LibrariesAPIApi.md#addstocktype1) | **POST** /libraries/stocktypes | Add new stock type
[**AddThing1**](LibrariesAPIApi.md#addthing1) | **POST** /libraries/things | Add new thing
[**DeleteDieDesign1**](LibrariesAPIApi.md#deletediedesign1) | **DELETE** /libraries/diedesigns/{diedesignid} | Delete die design
[**DeleteGrade**](LibrariesAPIApi.md#deletegrade) | **DELETE** /libraries/stocks/{stockid}/grades/{gradeid} | Delete grade in stock
[**DeleteMode1**](LibrariesAPIApi.md#deletemode1) | **DELETE** /libraries/modes/{modeid} | Delete mode
[**DeletePlate1**](LibrariesAPIApi.md#deleteplate1) | **DELETE** /libraries/plates/{plateid} | Delete plate
[**DeletePress1**](LibrariesAPIApi.md#deletepress1) | **DELETE** /libraries/presses/{pressid} | Delete press
[**DeleteProcess1**](LibrariesAPIApi.md#deleteprocess1) | **DELETE** /libraries/processes/{processid} | Delete process
[**DeleteProcessType1**](LibrariesAPIApi.md#deleteprocesstype1) | **DELETE** /libraries/processtypes/{processtypeid} | Delete process type
[**DeleteRoll**](LibrariesAPIApi.md#deleteroll) | **DELETE** /libraries/stocks/{stockid}/grades/{gradeid}/rolls/{rollid} | Delete roll in grade
[**DeleteSheet**](LibrariesAPIApi.md#deletesheet) | **DELETE** /libraries/stocks/{stockid}/grades/{gradeid}/sheets/{sheetid} | Delete sheet in grade
[**DeleteStock1**](LibrariesAPIApi.md#deletestock1) | **DELETE** /libraries/stocks/{stockid} | Delete stock
[**DeleteStock2**](LibrariesAPIApi.md#deletestock2) | **DELETE** /libraries/v2/stocks/{stockid} | Delete stock
[**DeleteStockType1**](LibrariesAPIApi.md#deletestocktype1) | **DELETE** /libraries/stocktypes/{stocktypeid} | Delete stock type
[**DeleteTemplate1**](LibrariesAPIApi.md#deletetemplate1) | **DELETE** /libraries/templates/{templateid} | Delete template
[**DeleteThing1**](LibrariesAPIApi.md#deletething1) | **DELETE** /libraries/things/{thingid} | Delete thing
[**EditGrade**](LibrariesAPIApi.md#editgrade) | **PUT** /libraries/stocks/{stockid}/grades/{gradeid} | Edit grade
[**EditMode1**](LibrariesAPIApi.md#editmode1) | **PUT** /libraries/modes/{modeid} | Edit mode
[**EditPlate1**](LibrariesAPIApi.md#editplate1) | **PUT** /libraries/plates/{plateid} | Edit plate
[**EditPress1**](LibrariesAPIApi.md#editpress1) | **PUT** /libraries/presses/{pressid} | Edit press
[**EditProcess1**](LibrariesAPIApi.md#editprocess1) | **PUT** /libraries/processes/{processid} | Edit process
[**EditProcessType1**](LibrariesAPIApi.md#editprocesstype1) | **PUT** /libraries/processtypes/{processtypeid} | Edit process type
[**EditRoll**](LibrariesAPIApi.md#editroll) | **PUT** /libraries/stocks/{stockid}/grades/{gradeid}/rolls/{rollid} | Edit roll
[**EditSheet**](LibrariesAPIApi.md#editsheet) | **PUT** /libraries/stocks/{stockid}/grades/{gradeid}/sheets/{sheetid} | Edit sheet
[**EditStock1**](LibrariesAPIApi.md#editstock1) | **PUT** /libraries/stocks/{stockid} | Edit stock
[**EditStock2**](LibrariesAPIApi.md#editstock2) | **PUT** /libraries/v2/stocks/{stockid} | Edit stock
[**EditStockType1**](LibrariesAPIApi.md#editstocktype1) | **PUT** /libraries/stocktypes/{stocktypeid} | Edit stock type
[**EditThing1**](LibrariesAPIApi.md#editthing1) | **PUT** /libraries/things/{thingid} | Edit thing
[**GetDieDesign1**](LibrariesAPIApi.md#getdiedesign1) | **GET** /libraries/diedesigns/{diedesignid} | Get die design by ID
[**GetDieDesigns1**](LibrariesAPIApi.md#getdiedesigns1) | **GET** /libraries/diedesigns | Get list of all die designs
[**GetFoldingPatterns**](LibrariesAPIApi.md#getfoldingpatterns) | **GET** /libraries/folding | Get list of all folding patterns
[**GetGrade1**](LibrariesAPIApi.md#getgrade1) | **GET** /libraries/stocks/{stockid}/grades/{gradeid} | Get grade by ID
[**GetGrades**](LibrariesAPIApi.md#getgrades) | **GET** /libraries/stocks/{stockid}/grades | Get list of all grades in the stock
[**GetMarkSets**](LibrariesAPIApi.md#getmarksets) | **GET** /libraries/marksets | Get list of all mark sets
[**GetMarks**](LibrariesAPIApi.md#getmarks) | **GET** /libraries/marks | Get list of all marks
[**GetMode1**](LibrariesAPIApi.md#getmode1) | **GET** /libraries/modes/{modeid} | Get mode by ID
[**GetModes1**](LibrariesAPIApi.md#getmodes1) | **GET** /libraries/modes | Get list of all modes
[**GetPlate1**](LibrariesAPIApi.md#getplate1) | **GET** /libraries/plates/{plateid} | Get plate by ID
[**GetPlates1**](LibrariesAPIApi.md#getplates1) | **GET** /libraries/plates | Get list of all plates
[**GetPress1**](LibrariesAPIApi.md#getpress1) | **GET** /libraries/presses/{pressid} | Get press by ID
[**GetPresses1**](LibrariesAPIApi.md#getpresses1) | **GET** /libraries/presses | Get list of all presses
[**GetProcess1**](LibrariesAPIApi.md#getprocess1) | **GET** /libraries/processes/{processid} | Get process by ID
[**GetProcessType1**](LibrariesAPIApi.md#getprocesstype1) | **GET** /libraries/processtypes/{processtypeid} | Get process type by ID
[**GetProcessTypes1**](LibrariesAPIApi.md#getprocesstypes1) | **GET** /libraries/processtypes | Get list of all process types
[**GetProcesses1**](LibrariesAPIApi.md#getprocesses1) | **GET** /libraries/processes | Get list of all processes
[**GetRoll1**](LibrariesAPIApi.md#getroll1) | **GET** /libraries/stocks/{stockid}/grades/{gradeid}/rolls/{rollid} | Get roll by ID
[**GetRolls**](LibrariesAPIApi.md#getrolls) | **GET** /libraries/stocks/{stockid}/grades/{gradeid}/rolls | Get list of all rolls in the grade
[**GetSheet1**](LibrariesAPIApi.md#getsheet1) | **GET** /libraries/stocks/{stockid}/grades/{gradeid}/sheets/{sheetid} | Get sheet by ID
[**GetSheets**](LibrariesAPIApi.md#getsheets) | **GET** /libraries/stocks/{stockid}/grades/{gradeid}/sheets | Get list of all sheets in the grade
[**GetStock1**](LibrariesAPIApi.md#getstock1) | **GET** /libraries/stocks/{stockid} | Get stock by ID
[**GetStock2**](LibrariesAPIApi.md#getstock2) | **GET** /libraries/v2/stocks/{stockid} | Get stock by ID
[**GetStockType1**](LibrariesAPIApi.md#getstocktype1) | **GET** /libraries/stocktypes/{stocktypeid} | Get stock type by ID
[**GetStockTypes1**](LibrariesAPIApi.md#getstocktypes1) | **GET** /libraries/stocktypes | Get list of all stock types
[**GetStocks1**](LibrariesAPIApi.md#getstocks1) | **GET** /libraries/stocks | Get list of all stocks
[**GetStocks2**](LibrariesAPIApi.md#getstocks2) | **GET** /libraries/v2/stocks | Get list of all stocks
[**GetTemplate1**](LibrariesAPIApi.md#gettemplate1) | **GET** /libraries/templates/{templateid} | Get template by ID
[**GetTemplates1**](LibrariesAPIApi.md#gettemplates1) | **GET** /libraries/templates | Get list of all templates
[**GetThing1**](LibrariesAPIApi.md#getthing1) | **GET** /libraries/things/{thingid} | Get thing by ID
[**GetThings1**](LibrariesAPIApi.md#getthings1) | **GET** /libraries/things | Get list of all things
[**ImportDieDesign1**](LibrariesAPIApi.md#importdiedesign1) | **POST** /libraries/diedesigns | Import new die design
[**ImportTemplate1**](LibrariesAPIApi.md#importtemplate1) | **POST** /libraries/templates | Import new template

<a name="addgrade"></a>
# **AddGrade**
> ResponseEntity AddGrade (string stockid, GradeEntity body = null)

Add new grade to stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddGradeExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock
            var body = new GradeEntity(); // GradeEntity |  (optional) 

            try
            {
                // Add new grade to stock
                ResponseEntity result = apiInstance.AddGrade(stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddGrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock | 
 **body** | [**GradeEntity**](GradeEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addmode1"></a>
# **AddMode1**
> ResponseEntity AddMode1 (Mode body = null)

Add new mode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddMode1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new Mode(); // Mode |  (optional) 

            try
            {
                // Add new mode
                ResponseEntity result = apiInstance.AddMode1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddMode1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Mode**](Mode.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addplate1"></a>
# **AddPlate1**
> ResponseEntity AddPlate1 (PlateEntity body = null)

Add new plate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPlate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new PlateEntity(); // PlateEntity |  (optional) 

            try
            {
                // Add new plate
                ResponseEntity result = apiInstance.AddPlate1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddPlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlateEntity**](PlateEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addpress1"></a>
# **AddPress1**
> ResponseEntity AddPress1 (PressEntity body = null)

Add new press

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPress1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new PressEntity(); // PressEntity |  (optional) 

            try
            {
                // Add new press
                ResponseEntity result = apiInstance.AddPress1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddPress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PressEntity**](PressEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addprocess1"></a>
# **AddProcess1**
> ResponseEntity AddProcess1 (Process body = null)

Add new process

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddProcess1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new Process(); // Process |  (optional) 

            try
            {
                // Add new process
                ResponseEntity result = apiInstance.AddProcess1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddProcess1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Process**](Process.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addprocesstype1"></a>
# **AddProcessType1**
> ResponseEntity AddProcessType1 (ProcessType body = null)

Add new process type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddProcessType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new ProcessType(); // ProcessType |  (optional) 

            try
            {
                // Add new process type
                ResponseEntity result = apiInstance.AddProcessType1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddProcessType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProcessType**](ProcessType.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addroll"></a>
# **AddRoll**
> ResponseEntity AddRoll (string gradeid, string stockid, RollEntity body = null)

Add new roll to grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddRollExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock
            var body = new RollEntity(); // RollEntity |  (optional) 

            try
            {
                // Add new roll to grade
                ResponseEntity result = apiInstance.AddRoll(gradeid, stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddRoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 
 **body** | [**RollEntity**](RollEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsheet"></a>
# **AddSheet**
> ResponseEntity AddSheet (string gradeid, string stockid, SheetEntity body = null)

Add new sheet to grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddSheetExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock
            var body = new SheetEntity(); // SheetEntity |  (optional) 

            try
            {
                // Add new sheet to grade
                ResponseEntity result = apiInstance.AddSheet(gradeid, stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 
 **body** | [**SheetEntity**](SheetEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addstock1"></a>
# **AddStock1**
> ResponseEntity AddStock1 (StockEntity body = null)

Add new stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddStock1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new StockEntity(); // StockEntity |  (optional) 

            try
            {
                // Add new stock
                ResponseEntity result = apiInstance.AddStock1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddStock1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StockEntity**](StockEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addstock2"></a>
# **AddStock2**
> ResponseEntity AddStock2 (Stock body = null)

Add new stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddStock2Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new Stock(); // Stock |  (optional) 

            try
            {
                // Add new stock
                ResponseEntity result = apiInstance.AddStock2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddStock2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Stock**](Stock.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addstocktype1"></a>
# **AddStockType1**
> ResponseEntity AddStockType1 (StockType body = null)

Add new stock type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddStockType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new StockType(); // StockType |  (optional) 

            try
            {
                // Add new stock type
                ResponseEntity result = apiInstance.AddStockType1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddStockType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StockType**](StockType.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addthing1"></a>
# **AddThing1**
> ResponseEntity AddThing1 (Thing body = null)

Add new thing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddThing1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new Thing(); // Thing |  (optional) 

            try
            {
                // Add new thing
                ResponseEntity result = apiInstance.AddThing1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.AddThing1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Thing**](Thing.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletediedesign1"></a>
# **DeleteDieDesign1**
> ResponseEntity DeleteDieDesign1 (string diedesignid)

Delete die design

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDieDesign1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var diedesignid = diedesignid_example;  // string | ID of die design to delete

            try
            {
                // Delete die design
                ResponseEntity result = apiInstance.DeleteDieDesign1(diedesignid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteDieDesign1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diedesignid** | **string**| ID of die design to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletegrade"></a>
# **DeleteGrade**
> ResponseEntity DeleteGrade (string gradeid, string stockid)

Delete grade in stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGradeExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade to delete
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Delete grade in stock
                ResponseEntity result = apiInstance.DeleteGrade(gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteGrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade to delete | 
 **stockid** | **string**| ID of stock | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletemode1"></a>
# **DeleteMode1**
> ResponseEntity DeleteMode1 (string modeid)

Delete mode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMode1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var modeid = modeid_example;  // string | ID of mode to delete

            try
            {
                // Delete mode
                ResponseEntity result = apiInstance.DeleteMode1(modeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteMode1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modeid** | **string**| ID of mode to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteplate1"></a>
# **DeletePlate1**
> ResponseEntity DeletePlate1 (string plateid)

Delete plate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePlate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var plateid = plateid_example;  // string | ID of plate to delete

            try
            {
                // Delete plate
                ResponseEntity result = apiInstance.DeletePlate1(plateid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeletePlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plateid** | **string**| ID of plate to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepress1"></a>
# **DeletePress1**
> ResponseEntity DeletePress1 (string pressid)

Delete press

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePress1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var pressid = pressid_example;  // string | ID of press to delete

            try
            {
                // Delete press
                ResponseEntity result = apiInstance.DeletePress1(pressid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeletePress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pressid** | **string**| ID of press to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteprocess1"></a>
# **DeleteProcess1**
> ResponseEntity DeleteProcess1 (string processid)

Delete process

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcess1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processid = processid_example;  // string | ID of process to delete

            try
            {
                // Delete process
                ResponseEntity result = apiInstance.DeleteProcess1(processid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteProcess1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processid** | **string**| ID of process to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteprocesstype1"></a>
# **DeleteProcessType1**
> ResponseEntity DeleteProcessType1 (string processtypeid)

Delete process type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcessType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processtypeid = processtypeid_example;  // string | ID of process type to delete

            try
            {
                // Delete process type
                ResponseEntity result = apiInstance.DeleteProcessType1(processtypeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteProcessType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processtypeid** | **string**| ID of process type to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteroll"></a>
# **DeleteRoll**
> ResponseEntity DeleteRoll (string rollid, string gradeid, string stockid)

Delete roll in grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRollExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var rollid = rollid_example;  // string | ID of roll to delete
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Delete roll in grade
                ResponseEntity result = apiInstance.DeleteRoll(rollid, gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteRoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rollid** | **string**| ID of roll to delete | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesheet"></a>
# **DeleteSheet**
> ResponseEntity DeleteSheet (string sheetid, string gradeid, string stockid)

Delete sheet in grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSheetExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var sheetid = sheetid_example;  // string | ID of sheet to delete
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Delete sheet in grade
                ResponseEntity result = apiInstance.DeleteSheet(sheetid, gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sheetid** | **string**| ID of sheet to delete | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletestock1"></a>
# **DeleteStock1**
> ResponseEntity DeleteStock1 (string stockid)

Delete stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStock1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to delete

            try
            {
                // Delete stock
                ResponseEntity result = apiInstance.DeleteStock1(stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteStock1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletestock2"></a>
# **DeleteStock2**
> ResponseEntity DeleteStock2 (string stockid)

Delete stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStock2Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to delete

            try
            {
                // Delete stock
                ResponseEntity result = apiInstance.DeleteStock2(stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteStock2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletestocktype1"></a>
# **DeleteStockType1**
> ResponseEntity DeleteStockType1 (string stocktypeid)

Delete stock type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStockType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stocktypeid = stocktypeid_example;  // string | ID of stock type to delete

            try
            {
                // Delete stock type
                ResponseEntity result = apiInstance.DeleteStockType1(stocktypeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteStockType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stocktypeid** | **string**| ID of stock type to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetemplate1"></a>
# **DeleteTemplate1**
> ResponseEntity DeleteTemplate1 (string templateid)

Delete template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTemplate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var templateid = templateid_example;  // string | ID of template to delete

            try
            {
                // Delete template
                ResponseEntity result = apiInstance.DeleteTemplate1(templateid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteTemplate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateid** | **string**| ID of template to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletething1"></a>
# **DeleteThing1**
> ResponseEntity DeleteThing1 (string thingid)

Delete thing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteThing1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var thingid = thingid_example;  // string | ID of thing to delete

            try
            {
                // Delete thing
                ResponseEntity result = apiInstance.DeleteThing1(thingid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.DeleteThing1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thingid** | **string**| ID of thing to delete | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editgrade"></a>
# **EditGrade**
> ResponseEntity EditGrade (string gradeid, string stockid, GradeEntity body = null)

Edit grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditGradeExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade to edit
            var stockid = stockid_example;  // string | ID of stock
            var body = new GradeEntity(); // GradeEntity |  (optional) 

            try
            {
                // Edit grade
                ResponseEntity result = apiInstance.EditGrade(gradeid, stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditGrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade to edit | 
 **stockid** | **string**| ID of stock | 
 **body** | [**GradeEntity**](GradeEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editmode1"></a>
# **EditMode1**
> ResponseEntity EditMode1 (string modeid, Mode body = null)

Edit mode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditMode1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var modeid = modeid_example;  // string | ID of mode to edit
            var body = new Mode(); // Mode |  (optional) 

            try
            {
                // Edit mode
                ResponseEntity result = apiInstance.EditMode1(modeid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditMode1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modeid** | **string**| ID of mode to edit | 
 **body** | [**Mode**](Mode.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editplate1"></a>
# **EditPlate1**
> ResponseEntity EditPlate1 (string plateid, PlateEntity body = null)

Edit plate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditPlate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var plateid = plateid_example;  // string | ID of plate to edit
            var body = new PlateEntity(); // PlateEntity |  (optional) 

            try
            {
                // Edit plate
                ResponseEntity result = apiInstance.EditPlate1(plateid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditPlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plateid** | **string**| ID of plate to edit | 
 **body** | [**PlateEntity**](PlateEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editpress1"></a>
# **EditPress1**
> ResponseEntity EditPress1 (string pressid, PressEntity body = null)

Edit press

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditPress1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var pressid = pressid_example;  // string | ID of press to edit
            var body = new PressEntity(); // PressEntity |  (optional) 

            try
            {
                // Edit press
                ResponseEntity result = apiInstance.EditPress1(pressid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditPress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pressid** | **string**| ID of press to edit | 
 **body** | [**PressEntity**](PressEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editprocess1"></a>
# **EditProcess1**
> ResponseEntity EditProcess1 (string processid, Process body = null)

Edit process

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditProcess1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processid = processid_example;  // string | ID of process to edit
            var body = new Process(); // Process |  (optional) 

            try
            {
                // Edit process
                ResponseEntity result = apiInstance.EditProcess1(processid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditProcess1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processid** | **string**| ID of process to edit | 
 **body** | [**Process**](Process.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editprocesstype1"></a>
# **EditProcessType1**
> ResponseEntity EditProcessType1 (string processtypeid, ProcessType body = null)

Edit process type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditProcessType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processtypeid = processtypeid_example;  // string | ID of process type to edit
            var body = new ProcessType(); // ProcessType |  (optional) 

            try
            {
                // Edit process type
                ResponseEntity result = apiInstance.EditProcessType1(processtypeid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditProcessType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processtypeid** | **string**| ID of process type to edit | 
 **body** | [**ProcessType**](ProcessType.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editroll"></a>
# **EditRoll**
> ResponseEntity EditRoll (string rollid, string gradeid, string stockid, RollEntity body = null)

Edit roll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditRollExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var rollid = rollid_example;  // string | ID of roll to edit
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock
            var body = new RollEntity(); // RollEntity |  (optional) 

            try
            {
                // Edit roll
                ResponseEntity result = apiInstance.EditRoll(rollid, gradeid, stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditRoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rollid** | **string**| ID of roll to edit | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 
 **body** | [**RollEntity**](RollEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editsheet"></a>
# **EditSheet**
> ResponseEntity EditSheet (string sheetid, string gradeid, string stockid, SheetEntity body = null)

Edit sheet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditSheetExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var sheetid = sheetid_example;  // string | ID of sheet to edit
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock
            var body = new SheetEntity(); // SheetEntity |  (optional) 

            try
            {
                // Edit sheet
                ResponseEntity result = apiInstance.EditSheet(sheetid, gradeid, stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sheetid** | **string**| ID of sheet to edit | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 
 **body** | [**SheetEntity**](SheetEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editstock1"></a>
# **EditStock1**
> ResponseEntity EditStock1 (string stockid, StockEntity body = null)

Edit stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditStock1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to edit
            var body = new StockEntity(); // StockEntity |  (optional) 

            try
            {
                // Edit stock
                ResponseEntity result = apiInstance.EditStock1(stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditStock1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to edit | 
 **body** | [**StockEntity**](StockEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editstock2"></a>
# **EditStock2**
> ResponseEntity EditStock2 (string stockid, Stock body = null)

Edit stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditStock2Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to edit
            var body = new Stock(); // Stock |  (optional) 

            try
            {
                // Edit stock
                ResponseEntity result = apiInstance.EditStock2(stockid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditStock2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to edit | 
 **body** | [**Stock**](Stock.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editstocktype1"></a>
# **EditStockType1**
> ResponseEntity EditStockType1 (string stocktypeid, StockType body = null)

Edit stock type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditStockType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stocktypeid = stocktypeid_example;  // string | ID of stock type to edit
            var body = new StockType(); // StockType |  (optional) 

            try
            {
                // Edit stock type
                ResponseEntity result = apiInstance.EditStockType1(stocktypeid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditStockType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stocktypeid** | **string**| ID of stock type to edit | 
 **body** | [**StockType**](StockType.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editthing1"></a>
# **EditThing1**
> ResponseEntity EditThing1 (string thingid, Thing body = null)

Edit thing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditThing1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var thingid = thingid_example;  // string | ID of thing to edit
            var body = new Thing(); // Thing |  (optional) 

            try
            {
                // Edit thing
                ResponseEntity result = apiInstance.EditThing1(thingid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.EditThing1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thingid** | **string**| ID of thing to edit | 
 **body** | [**Thing**](Thing.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdiedesign1"></a>
# **GetDieDesign1**
> DieDesignEntity GetDieDesign1 (string diedesignid, bool? thumb = null)

Get die design by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDieDesign1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var diedesignid = diedesignid_example;  // string | ID of die design to get
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)

            try
            {
                // Get die design by ID
                DieDesignEntity result = apiInstance.GetDieDesign1(diedesignid, thumb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetDieDesign1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diedesignid** | **string**| ID of die design to get | 
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]

### Return type

[**DieDesignEntity**](DieDesignEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdiedesigns1"></a>
# **GetDieDesigns1**
> List<DieDesignEntity> GetDieDesigns1 (bool? thumb = null)

Get list of all die designs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDieDesigns1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)

            try
            {
                // Get list of all die designs
                List&lt;DieDesignEntity&gt; result = apiInstance.GetDieDesigns1(thumb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetDieDesigns1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]

### Return type

[**List<DieDesignEntity>**](DieDesignEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfoldingpatterns"></a>
# **GetFoldingPatterns**
> List<FoldingPatternEntity> GetFoldingPatterns ()

Get list of all folding patterns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFoldingPatternsExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all folding patterns
                List&lt;FoldingPatternEntity&gt; result = apiInstance.GetFoldingPatterns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetFoldingPatterns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FoldingPatternEntity>**](FoldingPatternEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgrade1"></a>
# **GetGrade1**
> GradeEntity GetGrade1 (string gradeid, string stockid)

Get grade by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGrade1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade to get
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get grade by ID
                GradeEntity result = apiInstance.GetGrade1(gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetGrade1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade to get | 
 **stockid** | **string**| ID of stock | 

### Return type

[**GradeEntity**](GradeEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getgrades"></a>
# **GetGrades**
> List<GradeEntity> GetGrades (string stockid)

Get list of all grades in the stock

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGradesExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get list of all grades in the stock
                List&lt;GradeEntity&gt; result = apiInstance.GetGrades(stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetGrades: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock | 

### Return type

[**List<GradeEntity>**](GradeEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmarksets"></a>
# **GetMarkSets**
> List<MarkSetEntity> GetMarkSets ()

Get list of all mark sets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarkSetsExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all mark sets
                List&lt;MarkSetEntity&gt; result = apiInstance.GetMarkSets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetMarkSets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarkSetEntity>**](MarkSetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmarks"></a>
# **GetMarks**
> List<MarkEntity> GetMarks ()

Get list of all marks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarksExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all marks
                List&lt;MarkEntity&gt; result = apiInstance.GetMarks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetMarks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarkEntity>**](MarkEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmode1"></a>
# **GetMode1**
> Mode GetMode1 (string modeid)

Get mode by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMode1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var modeid = modeid_example;  // string | ID of mode to get

            try
            {
                // Get mode by ID
                Mode result = apiInstance.GetMode1(modeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetMode1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modeid** | **string**| ID of mode to get | 

### Return type

[**Mode**](Mode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmodes1"></a>
# **GetModes1**
> List<Mode> GetModes1 ()

Get list of all modes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetModes1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all modes
                List&lt;Mode&gt; result = apiInstance.GetModes1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetModes1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Mode>**](Mode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getplate1"></a>
# **GetPlate1**
> PlateEntity GetPlate1 (string plateid)

Get plate by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var plateid = plateid_example;  // string | ID of plate to get

            try
            {
                // Get plate by ID
                PlateEntity result = apiInstance.GetPlate1(plateid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetPlate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plateid** | **string**| ID of plate to get | 

### Return type

[**PlateEntity**](PlateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getplates1"></a>
# **GetPlates1**
> List<PlateEntity> GetPlates1 ()

Get list of all plates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlates1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all plates
                List&lt;PlateEntity&gt; result = apiInstance.GetPlates1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetPlates1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PlateEntity>**](PlateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpress1"></a>
# **GetPress1**
> PressEntity GetPress1 (string pressid)

Get press by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPress1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var pressid = pressid_example;  // string | ID of press to get

            try
            {
                // Get press by ID
                PressEntity result = apiInstance.GetPress1(pressid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetPress1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pressid** | **string**| ID of press to get | 

### Return type

[**PressEntity**](PressEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpresses1"></a>
# **GetPresses1**
> List<PressEntity> GetPresses1 ()

Get list of all presses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPresses1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all presses
                List&lt;PressEntity&gt; result = apiInstance.GetPresses1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetPresses1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PressEntity>**](PressEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprocess1"></a>
# **GetProcess1**
> Process GetProcess1 (string processid)

Get process by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcess1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processid = processid_example;  // string | ID of process to get

            try
            {
                // Get process by ID
                Process result = apiInstance.GetProcess1(processid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetProcess1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processid** | **string**| ID of process to get | 

### Return type

[**Process**](Process.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprocesstype1"></a>
# **GetProcessType1**
> ProcessType GetProcessType1 (string processtypeid)

Get process type by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var processtypeid = processtypeid_example;  // string | ID of process type to get

            try
            {
                // Get process type by ID
                ProcessType result = apiInstance.GetProcessType1(processtypeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetProcessType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processtypeid** | **string**| ID of process type to get | 

### Return type

[**ProcessType**](ProcessType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprocesstypes1"></a>
# **GetProcessTypes1**
> List<ProcessType> GetProcessTypes1 ()

Get list of all process types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessTypes1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all process types
                List&lt;ProcessType&gt; result = apiInstance.GetProcessTypes1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetProcessTypes1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProcessType>**](ProcessType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprocesses1"></a>
# **GetProcesses1**
> List<Process> GetProcesses1 ()

Get list of all processes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcesses1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all processes
                List&lt;Process&gt; result = apiInstance.GetProcesses1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetProcesses1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Process>**](Process.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getroll1"></a>
# **GetRoll1**
> RollEntity GetRoll1 (string rollid, string gradeid, string stockid)

Get roll by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoll1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var rollid = rollid_example;  // string | ID of roll to get
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get roll by ID
                RollEntity result = apiInstance.GetRoll1(rollid, gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetRoll1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rollid** | **string**| ID of roll to get | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**RollEntity**](RollEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrolls"></a>
# **GetRolls**
> List<RollEntity> GetRolls (string gradeid, string stockid)

Get list of all rolls in the grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRollsExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get list of all rolls in the grade
                List&lt;RollEntity&gt; result = apiInstance.GetRolls(gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetRolls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**List<RollEntity>**](RollEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsheet1"></a>
# **GetSheet1**
> SheetEntity GetSheet1 (string sheetid, string gradeid, string stockid)

Get sheet by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSheet1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var sheetid = sheetid_example;  // string | ID of sheet to get
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get sheet by ID
                SheetEntity result = apiInstance.GetSheet1(sheetid, gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetSheet1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sheetid** | **string**| ID of sheet to get | 
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**SheetEntity**](SheetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsheets"></a>
# **GetSheets**
> List<SheetEntity> GetSheets (string gradeid, string stockid)

Get list of all sheets in the grade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSheetsExample
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var gradeid = gradeid_example;  // string | ID of grade
            var stockid = stockid_example;  // string | ID of stock

            try
            {
                // Get list of all sheets in the grade
                List&lt;SheetEntity&gt; result = apiInstance.GetSheets(gradeid, stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetSheets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradeid** | **string**| ID of grade | 
 **stockid** | **string**| ID of stock | 

### Return type

[**List<SheetEntity>**](SheetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstock1"></a>
# **GetStock1**
> StockEntity GetStock1 (string stockid)

Get stock by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStock1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to get

            try
            {
                // Get stock by ID
                StockEntity result = apiInstance.GetStock1(stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStock1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to get | 

### Return type

[**StockEntity**](StockEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstock2"></a>
# **GetStock2**
> Stock GetStock2 (string stockid)

Get stock by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStock2Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stockid = stockid_example;  // string | ID of stock to get

            try
            {
                // Get stock by ID
                Stock result = apiInstance.GetStock2(stockid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStock2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stockid** | **string**| ID of stock to get | 

### Return type

[**Stock**](Stock.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstocktype1"></a>
# **GetStockType1**
> StockType GetStockType1 (string stocktypeid)

Get stock type by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStockType1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var stocktypeid = stocktypeid_example;  // string | ID of stock type to get

            try
            {
                // Get stock type by ID
                StockType result = apiInstance.GetStockType1(stocktypeid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStockType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stocktypeid** | **string**| ID of stock type to get | 

### Return type

[**StockType**](StockType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstocktypes1"></a>
# **GetStockTypes1**
> List<StockType> GetStockTypes1 ()

Get list of all stock types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStockTypes1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all stock types
                List&lt;StockType&gt; result = apiInstance.GetStockTypes1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStockTypes1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<StockType>**](StockType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstocks1"></a>
# **GetStocks1**
> List<StockEntity> GetStocks1 ()

Get list of all stocks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStocks1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all stocks
                List&lt;StockEntity&gt; result = apiInstance.GetStocks1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStocks1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<StockEntity>**](StockEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstocks2"></a>
# **GetStocks2**
> List<Stock> GetStocks2 ()

Get list of all stocks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStocks2Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all stocks
                List&lt;Stock&gt; result = apiInstance.GetStocks2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetStocks2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Stock>**](Stock.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettemplate1"></a>
# **GetTemplate1**
> TemplateEntity GetTemplate1 (string templateid, bool? thumb = null)

Get template by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var templateid = templateid_example;  // string | ID of template to get
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)

            try
            {
                // Get template by ID
                TemplateEntity result = apiInstance.GetTemplate1(templateid, thumb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetTemplate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateid** | **string**| ID of template to get | 
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]

### Return type

[**TemplateEntity**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettemplates1"></a>
# **GetTemplates1**
> List<TemplateEntity> GetTemplates1 (bool? thumb = null)

Get list of all templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplates1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var thumb = true;  // bool? | Include thumbnail image or not (optional)  (default to false)

            try
            {
                // Get list of all templates
                List&lt;TemplateEntity&gt; result = apiInstance.GetTemplates1(thumb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetTemplates1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thumb** | **bool?**| Include thumbnail image or not | [optional] [default to false]

### Return type

[**List<TemplateEntity>**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getthing1"></a>
# **GetThing1**
> Thing GetThing1 (string thingid)

Get thing by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetThing1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var thingid = thingid_example;  // string | ID of thing to get

            try
            {
                // Get thing by ID
                Thing result = apiInstance.GetThing1(thingid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetThing1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thingid** | **string**| ID of thing to get | 

### Return type

[**Thing**](Thing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getthings1"></a>
# **GetThings1**
> List<Thing> GetThings1 ()

Get list of all things

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetThings1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();

            try
            {
                // Get list of all things
                List&lt;Thing&gt; result = apiInstance.GetThings1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.GetThings1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Thing>**](Thing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="importdiedesign1"></a>
# **ImportDieDesign1**
> ResponseEntity ImportDieDesign1 (ImportDieDesignEntity body = null)

Import new die design

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportDieDesign1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new ImportDieDesignEntity(); // ImportDieDesignEntity |  (optional) 

            try
            {
                // Import new die design
                ResponseEntity result = apiInstance.ImportDieDesign1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.ImportDieDesign1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImportDieDesignEntity**](ImportDieDesignEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="importtemplate1"></a>
# **ImportTemplate1**
> ResponseEntity ImportTemplate1 (ImportTemplateEntity body = null)

Import new template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportTemplate1Example
    {
        public void main()
        {
            var apiInstance = new LibrariesAPIApi();
            var body = new ImportTemplateEntity(); // ImportTemplateEntity |  (optional) 

            try
            {
                // Import new template
                ResponseEntity result = apiInstance.ImportTemplate1(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibrariesAPIApi.ImportTemplate1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImportTemplateEntity**](ImportTemplateEntity.md)|  | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
