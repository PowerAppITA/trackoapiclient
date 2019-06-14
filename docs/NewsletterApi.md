# IO.Swagger.trackoApiClient.NewsletterApi

All URIs are relative to *https://areariservata.tracko.click*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NewsletterGetNewsletters**](NewsletterApi.md#newslettergetnewsletters) | **POST** /api/Newsletter/GetNewsletters | 
[**NewsletterSaveNewsletters**](NewsletterApi.md#newslettersavenewsletters) | **POST** /api/Newsletter/SaveNewsletters | 


<a name="newslettergetnewsletters"></a>
# **NewsletterGetNewsletters**
> BackofficeModelAPINewsletterGetNewslettersResponseData NewsletterGetNewsletters (BackofficeModelAPINewsletterGetNewslettersRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NewsletterGetNewslettersExample
    {
        public void main()
        {
            var apiInstance = new NewsletterApi();
            var oRequest = new BackofficeModelAPINewsletterGetNewslettersRequestData(); // BackofficeModelAPINewsletterGetNewslettersRequestData | 

            try
            {
                BackofficeModelAPINewsletterGetNewslettersResponseData result = apiInstance.NewsletterGetNewsletters(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewsletterApi.NewsletterGetNewsletters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPINewsletterGetNewslettersRequestData**](BackofficeModelAPINewsletterGetNewslettersRequestData.md)|  | 

### Return type

[**BackofficeModelAPINewsletterGetNewslettersResponseData**](BackofficeModelAPINewsletterGetNewslettersResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newslettersavenewsletters"></a>
# **NewsletterSaveNewsletters**
> BackofficeModelAPINewsletterSaveNewsletterResponseData NewsletterSaveNewsletters (BackofficeModelAPINewsletterSaveNewsletterRequestData oRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NewsletterSaveNewslettersExample
    {
        public void main()
        {
            var apiInstance = new NewsletterApi();
            var oRequest = new BackofficeModelAPINewsletterSaveNewsletterRequestData(); // BackofficeModelAPINewsletterSaveNewsletterRequestData | 

            try
            {
                BackofficeModelAPINewsletterSaveNewsletterResponseData result = apiInstance.NewsletterSaveNewsletters(oRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewsletterApi.NewsletterSaveNewsletters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oRequest** | [**BackofficeModelAPINewsletterSaveNewsletterRequestData**](BackofficeModelAPINewsletterSaveNewsletterRequestData.md)|  | 

### Return type

[**BackofficeModelAPINewsletterSaveNewsletterResponseData**](BackofficeModelAPINewsletterSaveNewsletterResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

