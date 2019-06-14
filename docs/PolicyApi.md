# IO.Swagger.trackoApiClient.PolicyApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PolicyGetPolicy**](PolicyApi.md#policygetpolicy) | **POST** /api/Policy/GetPolicy | 
[**PolicySavePolicy**](PolicyApi.md#policysavepolicy) | **POST** /api/Policy/SavePolicy | 


<a name="policygetpolicy"></a>
# **PolicyGetPolicy**
> BackofficeModelAPIPolicyGetPolicyResponseData PolicyGetPolicy (BackofficeModelAPIPolicyGetPolicyRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PolicyGetPolicyExample
    {
        public void main()
        {
            var apiInstance = new PolicyApi();
            var oRequest = new BackofficeModelAPIPolicyGetPolicyRequestData(); // BackofficeModelAPIPolicyGetPolicyRequestData | 

            try
            {
                BackofficeModelAPIPolicyGetPolicyResponseData result = apiInstance.PolicyGetPolicy(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.PolicyGetPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIPolicyGetPolicyRequestData**](BackofficeModelAPIPolicyGetPolicyRequestData.md)|  | 

### Return type

[**BackofficeModelAPIPolicyGetPolicyResponseData**](BackofficeModelAPIPolicyGetPolicyResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policysavepolicy"></a>
# **PolicySavePolicy**
> BackofficeModelAPICommonMessageModel PolicySavePolicy (BackofficeModelAPIPolicySavePolicyRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PolicySavePolicyExample
    {
        public void main()
        {
            var apiInstance = new PolicyApi();
            var oRequest = new BackofficeModelAPIPolicySavePolicyRequestData(); // BackofficeModelAPIPolicySavePolicyRequestData | 

            try
            {
                BackofficeModelAPICommonMessageModel result = apiInstance.PolicySavePolicy(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.PolicySavePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPIPolicySavePolicyRequestData**](BackofficeModelAPIPolicySavePolicyRequestData.md)|  | 

### Return type

[**BackofficeModelAPICommonMessageModel**](BackofficeModelAPICommonMessageModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

