# IO.Swagger.trackoApiClient.AccettazioniStoricoApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccettazioniStoricoGetList**](AccettazioniStoricoApi.md#accettazionistoricogetlist) | **POST** /api/AccettazioniStorico/GetList | 


<a name="accettazionistoricogetlist"></a>
# **AccettazioniStoricoGetList**
> Object AccettazioniStoricoGetList (ModelLayerBackDatatableResponseAccettazioniStoricoDtAjaxPost model)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccettazioniStoricoGetListExample
    {
        public void main()
        {
            var apiInstance = new AccettazioniStoricoApi();
            var model = new ModelLayerBackDatatableResponseAccettazioniStoricoDtAjaxPost(); // ModelLayerBackDatatableResponseAccettazioniStoricoDtAjaxPost | 

            try
            {
                Object result = apiInstance.AccettazioniStoricoGetList(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccettazioniStoricoApi.AccettazioniStoricoGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ModelLayerBackDatatableResponseAccettazioniStoricoDtAjaxPost**](ModelLayerBackDatatableResponseAccettazioniStoricoDtAjaxPost.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

