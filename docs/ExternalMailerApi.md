# IO.Swagger.trackoApiClient.ExternalMailerApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExternalMailerHandlerMailup**](ExternalMailerApi.md#externalmailerhandlermailup) | **POST** /api/ExternalMailer/HandlerMailup | 
[**ExternalMailerUpdateRequestStatus**](ExternalMailerApi.md#externalmailerupdaterequeststatus) | **POST** /api/ExternalMailer/UpdateRequestStatus | 


<a name="externalmailerhandlermailup"></a>
# **ExternalMailerHandlerMailup**
> int? ExternalMailerHandlerMailup (Dictionary<string, string> message)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalMailerHandlerMailupExample
    {
        public void main()
        {
            var apiInstance = new ExternalMailerApi();
            var message = new Dictionary<string, string>(); // Dictionary<string, string> | 

            try
            {
                int? result = apiInstance.ExternalMailerHandlerMailup(message);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalMailerApi.ExternalMailerHandlerMailup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **message** | [**Dictionary&lt;string, string&gt;**](string.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="externalmailerupdaterequeststatus"></a>
# **ExternalMailerUpdateRequestStatus**
> bool? ExternalMailerUpdateRequestStatus (BackofficeModelWSAPIHooksHandlerMailupData oMailUpObj)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExternalMailerUpdateRequestStatusExample
    {
        public void main()
        {
            var apiInstance = new ExternalMailerApi();
            var oMailUpObj = new BackofficeModelWSAPIHooksHandlerMailupData(); // BackofficeModelWSAPIHooksHandlerMailupData | 

            try
            {
                bool? result = apiInstance.ExternalMailerUpdateRequestStatus(oMailUpObj);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalMailerApi.ExternalMailerUpdateRequestStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oMailUpObj** | [**BackofficeModelWSAPIHooksHandlerMailupData**](BackofficeModelWSAPIHooksHandlerMailupData.md)|  | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

