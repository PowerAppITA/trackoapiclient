# IO.Swagger.trackoApiClient.AccettazioniApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccettazioniGetList**](AccettazioniApi.md#accettazionigetlist) | **POST** /api/Accettazioni/GetList | 


<a name="accettazionigetlist"></a>
# **AccettazioniGetList**
> BackofficeModelAPICommonDataSourceResult AccettazioniGetList (BackofficeModelAccettazioniIndexMaskModel oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccettazioniGetListExample
    {
        public void main()
        {
            var apiInstance = new AccettazioniApi();
            var oRequest = new BackofficeModelAccettazioniIndexMaskModel(); // BackofficeModelAccettazioniIndexMaskModel | 

            try
            {
                BackofficeModelAPICommonDataSourceResult result = apiInstance.AccettazioniGetList(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccettazioniApi.AccettazioniGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAccettazioniIndexMaskModel**](BackofficeModelAccettazioniIndexMaskModel.md)|  | 

### Return type

[**BackofficeModelAPICommonDataSourceResult**](BackofficeModelAPICommonDataSourceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

