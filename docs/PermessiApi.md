# IO.Swagger.trackoApiClient.PermessiApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PermessiGetList**](PermessiApi.md#permessigetlist) | **POST** /api/Permessi/GetList | 
[**PermessiSavePermessi**](PermessiApi.md#permessisavepermessi) | **POST** /api/Permessi/SavePermessi | 


<a name="permessigetlist"></a>
# **PermessiGetList**
> BackofficeModelAPIPermessiGetListResponseData PermessiGetList (BackofficeModelAPIPermessiGetListRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermessiGetListExample
    {
        public void main()
        {
            var apiInstance = new PermessiApi();
            var oRequest = new BackofficeModelAPIPermessiGetListRequestData(); // BackofficeModelAPIPermessiGetListRequestData | 

            try
            {
                BackofficeModelAPIPermessiGetListResponseData result = apiInstance.PermessiGetList(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermessiApi.PermessiGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIPermessiGetListRequestData**](BackofficeModelAPIPermessiGetListRequestData.md)|  | 

### Return type

[**BackofficeModelAPIPermessiGetListResponseData**](BackofficeModelAPIPermessiGetListResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="permessisavepermessi"></a>
# **PermessiSavePermessi**
> BackofficeModelAPICommonMessageModel PermessiSavePermessi (BackofficeModelAPIPermessiSaveRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermessiSavePermessiExample
    {
        public void main()
        {
            var apiInstance = new PermessiApi();
            var oRequest = new BackofficeModelAPIPermessiSaveRequestData(); // BackofficeModelAPIPermessiSaveRequestData | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.PermessiSavePermessi(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermessiApi.PermessiSavePermessi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIPermessiSaveRequestData**](BackofficeModelAPIPermessiSaveRequestData.md)|  | 

### Return type

[**BackofficeModelAPICommonMessageModel**](BackofficeModelAPICommonMessageModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

