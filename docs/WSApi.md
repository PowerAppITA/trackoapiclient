# IO.Swagger.trackoApiClient.WSApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WSAddRequest**](WSApi.md#wsaddrequest) | **POST** /api/WS/AddRequest | 
[**WSGetPolicy**](WSApi.md#wsgetpolicy) | **POST** /api/WS/GetPolicy | 
[**WSRetrivePanelLink**](WSApi.md#wsretrivepanellink) | **POST** /api/WS/RetrivePanelLink | 
[**WSUpdateMultipleRequestStatus**](WSApi.md#wsupdatemultiplerequeststatus) | **POST** /api/WS/UpdateMultipleRequestStatus | 
[**WSUpdateRequestStatus**](WSApi.md#wsupdaterequeststatus) | **POST** /api/WS/UpdateRequestStatus | 


<a name="wsaddrequest"></a>
# **WSAddRequest**
> BackofficeModelAPIWSContactAddRequestResponseData WSAddRequest (BackofficeModelAPIWSContactAddRequestRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WSAddRequestExample
    {
        public void main()
        {
            var apiInstance = new WSApi();
            var oRequest = new BackofficeModelAPIWSContactAddRequestRequestData(); // BackofficeModelAPIWSContactAddRequestRequestData | 

            try
            {
                BackofficeModelAPIWSContactAddRequestResponseData result = apiInstance.WSAddRequest(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WSApi.WSAddRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIWSContactAddRequestRequestData**](BackofficeModelAPIWSContactAddRequestRequestData.md)|  | 

### Return type

[**BackofficeModelAPIWSContactAddRequestResponseData**](BackofficeModelAPIWSContactAddRequestResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wsgetpolicy"></a>
# **WSGetPolicy**
> BackofficeModelAPIWSPolicyGetPolicyResponseData WSGetPolicy (BackofficeModelAPIWSPolicyGetPolicyRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WSGetPolicyExample
    {
        public void main()
        {
            var apiInstance = new WSApi();
            var oRequest = new BackofficeModelAPIWSPolicyGetPolicyRequestData(); // BackofficeModelAPIWSPolicyGetPolicyRequestData | 

            try
            {
                BackofficeModelAPIWSPolicyGetPolicyResponseData result = apiInstance.WSGetPolicy(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WSApi.WSGetPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIWSPolicyGetPolicyRequestData**](BackofficeModelAPIWSPolicyGetPolicyRequestData.md)|  | 

### Return type

[**BackofficeModelAPIWSPolicyGetPolicyResponseData**](BackofficeModelAPIWSPolicyGetPolicyResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wsretrivepanellink"></a>
# **WSRetrivePanelLink**
> BackofficeModelAPIWSContactRetrivePanelLinkResponseData WSRetrivePanelLink (BackofficeModelAPIWSContactRetrivePanelLinkRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WSRetrivePanelLinkExample
    {
        public void main()
        {
            var apiInstance = new WSApi();
            var oRequest = new BackofficeModelAPIWSContactRetrivePanelLinkRequestData(); // BackofficeModelAPIWSContactRetrivePanelLinkRequestData | 

            try
            {
                BackofficeModelAPIWSContactRetrivePanelLinkResponseData result = apiInstance.WSRetrivePanelLink(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WSApi.WSRetrivePanelLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIWSContactRetrivePanelLinkRequestData**](BackofficeModelAPIWSContactRetrivePanelLinkRequestData.md)|  | 

### Return type

[**BackofficeModelAPIWSContactRetrivePanelLinkResponseData**](BackofficeModelAPIWSContactRetrivePanelLinkResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wsupdatemultiplerequeststatus"></a>
# **WSUpdateMultipleRequestStatus**
> BackofficeModelAPIWSContactUpdateMultipleRequestStatusResponseData WSUpdateMultipleRequestStatus (BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WSUpdateMultipleRequestStatusExample
    {
        public void main()
        {
            var apiInstance = new WSApi();
            var oRequest = new BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestData(); // BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestData | 

            try
            {
                BackofficeModelAPIWSContactUpdateMultipleRequestStatusResponseData result = apiInstance.WSUpdateMultipleRequestStatus(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WSApi.WSUpdateMultipleRequestStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestData**](BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestData.md)|  | 

### Return type

[**BackofficeModelAPIWSContactUpdateMultipleRequestStatusResponseData**](BackofficeModelAPIWSContactUpdateMultipleRequestStatusResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wsupdaterequeststatus"></a>
# **WSUpdateRequestStatus**
> BackofficeModelAPIWSContactUpdateRequestStatusResponseData WSUpdateRequestStatus (BackofficeModelAPIWSContactUpdateRequestStatusRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WSUpdateRequestStatusExample
    {
        public void main()
        {
            var apiInstance = new WSApi();
            var oRequest = new BackofficeModelAPIWSContactUpdateRequestStatusRequestData(); // BackofficeModelAPIWSContactUpdateRequestStatusRequestData | 

            try
            {
                BackofficeModelAPIWSContactUpdateRequestStatusResponseData result = apiInstance.WSUpdateRequestStatus(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WSApi.WSUpdateRequestStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIWSContactUpdateRequestStatusRequestData**](BackofficeModelAPIWSContactUpdateRequestStatusRequestData.md)|  | 

### Return type

[**BackofficeModelAPIWSContactUpdateRequestStatusResponseData**](BackofficeModelAPIWSContactUpdateRequestStatusResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

