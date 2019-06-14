# IO.Swagger.trackoApiClient.AccettazioniStoricoApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccettazioniStoricoGetList**](AccettazioniStoricoApi.md#accettazionistoricogetlist) | **POST** /api/AccettazioniStorico/GetList | 
[**AccettazioniStoricoLockAccountCredential**](AccettazioniStoricoApi.md#accettazionistoricolockaccountcredential) | **POST** /api/AccettazioniStorico/LockAccountCredential | 
[**AccettazioniStoricoSendAccountCredential**](AccettazioniStoricoApi.md#accettazionistoricosendaccountcredential) | **POST** /api/AccettazioniStorico/SendAccountCredential | 
[**AccettazioniStoricoUnlockAccountCredential**](AccettazioniStoricoApi.md#accettazionistoricounlockaccountcredential) | **POST** /api/AccettazioniStorico/UnlockAccountCredential | 


<a name="accettazionistoricogetlist"></a>
# **AccettazioniStoricoGetList**
> BackofficeModelAPICommonDataSourceResult AccettazioniStoricoGetList ()



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

            try
            {
                BackofficeModelAPICommonDataSourceResult result = apiInstance.AccettazioniStoricoGetList();
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
This endpoint does not need any parameter.

### Return type

[**BackofficeModelAPICommonDataSourceResult**](BackofficeModelAPICommonDataSourceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accettazionistoricolockaccountcredential"></a>
# **AccettazioniStoricoLockAccountCredential**
> BackofficeModelAPICommonMessageModel AccettazioniStoricoLockAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccettazioniStoricoLockAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new AccettazioniStoricoApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.AccettazioniStoricoLockAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccettazioniStoricoApi.AccettazioniStoricoLockAccountCredential: " + e.Message );
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

<a name="accettazionistoricosendaccountcredential"></a>
# **AccettazioniStoricoSendAccountCredential**
> BackofficeModelAPICommonMessageModel AccettazioniStoricoSendAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccettazioniStoricoSendAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new AccettazioniStoricoApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.AccettazioniStoricoSendAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccettazioniStoricoApi.AccettazioniStoricoSendAccountCredential: " + e.Message );
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

<a name="accettazionistoricounlockaccountcredential"></a>
# **AccettazioniStoricoUnlockAccountCredential**
> BackofficeModelAPICommonMessageModel AccettazioniStoricoUnlockAccountCredential (int? utenteId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccettazioniStoricoUnlockAccountCredentialExample
    {
        public void main()
        {
            var apiInstance = new AccettazioniStoricoApi();
            var utenteId = 56;  // int? | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.AccettazioniStoricoUnlockAccountCredential(utenteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccettazioniStoricoApi.AccettazioniStoricoUnlockAccountCredential: " + e.Message );
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

