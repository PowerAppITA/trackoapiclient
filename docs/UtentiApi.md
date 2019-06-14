# IO.Swagger.trackoApiClient.UtentiApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UtentiGetList**](UtentiApi.md#utentigetlist) | **POST** /api/Utenti/GetList | 
[**UtentiLockAccountCredential**](UtentiApi.md#utentilockaccountcredential) | **POST** /api/Utenti/LockAccountCredential | 
[**UtentiSendAccountCredential**](UtentiApi.md#utentisendaccountcredential) | **POST** /api/Utenti/SendAccountCredential | 
[**UtentiUnlockAccountCredential**](UtentiApi.md#utentiunlockaccountcredential) | **POST** /api/Utenti/UnlockAccountCredential | 


<a name="utentigetlist"></a>
# **UtentiGetList**
> BackofficeModelAPICommonDataSourceResult UtentiGetList ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UtentiGetListExample
    {
        public void main()
        {
            var apiInstance = new UtentiApi();

            try
            {
                BackofficeModelAPICommonDataSourceResult result = apiInstance.UtentiGetList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtentiApi.UtentiGetList: " + e.Message );
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

<a name="utentilockaccountcredential"></a>
# **UtentiLockAccountCredential**
> BackofficeModelAPICommonMessageModel UtentiLockAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UtentiLockAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new UtentiApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.UtentiLockAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtentiApi.UtentiLockAccountCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **utenteId** | **int?**|  | 

### Return type

[**BackofficeModelAPICommonMessageModel**](BackofficeModelAPICommonMessageModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="utentisendaccountcredential"></a>
# **UtentiSendAccountCredential**
> BackofficeModelAPICommonMessageModel UtentiSendAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UtentiSendAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new UtentiApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.UtentiSendAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtentiApi.UtentiSendAccountCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **utenteId** | **int?**|  | 

### Return type

[**BackofficeModelAPICommonMessageModel**](BackofficeModelAPICommonMessageModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="utentiunlockaccountcredential"></a>
# **UtentiUnlockAccountCredential**
> BackofficeModelAPICommonMessageModel UtentiUnlockAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UtentiUnlockAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new UtentiApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.UtentiUnlockAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtentiApi.UtentiUnlockAccountCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **utenteId** | **int?**|  | 

### Return type

[**BackofficeModelAPICommonMessageModel**](BackofficeModelAPICommonMessageModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

