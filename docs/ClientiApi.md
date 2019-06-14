# IO.Swagger.trackoApiClient.ClientiApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientiGetList**](ClientiApi.md#clientigetlist) | **POST** /api/Clienti/GetList | 


<a name="clientigetlist"></a>
# **ClientiGetList**
> BackofficeModelAPICommonDataSourceResult ClientiGetList ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClientiGetListExample
    {
        public void main()
        {
            var apiInstance = new ClientiApi();

            try
            {
                BackofficeModelAPICommonDataSourceResult result = apiInstance.ClientiGetList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientiApi.ClientiGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BackofficeModelAPICommonDataSourceResult**](BackofficeModelAPICommonDataSourceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

