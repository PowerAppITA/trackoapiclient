# IO.Swagger.trackoApiClient.SorgentiApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SorgentiGetList**](SorgentiApi.md#sorgentigetlist) | **POST** /api/Sorgenti/GetList | 


<a name="sorgentigetlist"></a>
# **SorgentiGetList**
> BackofficeModelAPICommonDataSourceResult SorgentiGetList (BackofficeModelSorgentiIndexMaskModel oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SorgentiGetListExample
    {
        public void main()
        {
            var apiInstance = new SorgentiApi();
            var oRequest = new BackofficeModelSorgentiIndexMaskModel(); // BackofficeModelSorgentiIndexMaskModel | 

            try
            {
                BackofficeModelAPICommonDataSourceResult result = apiInstance.SorgentiGetList(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SorgentiApi.SorgentiGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelSorgentiIndexMaskModel**](BackofficeModelSorgentiIndexMaskModel.md)|  | 

### Return type

[**BackofficeModelAPICommonDataSourceResult**](BackofficeModelAPICommonDataSourceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

