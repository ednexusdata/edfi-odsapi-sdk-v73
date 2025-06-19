# EdFi.OdsApi.Sdk.v73.Apis.All.EducationContentsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteEducationContentById**](EducationContentsApi.md#deleteeducationcontentbyid) | **DELETE** /ed-fi/educationContents/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesEducationContents**](EducationContentsApi.md#deleteseducationcontents) | **GET** /ed-fi/educationContents/deletes | Retrieves deleted resources based on change version. |
| [**GetEducationContents**](EducationContentsApi.md#geteducationcontents) | **GET** /ed-fi/educationContents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetEducationContentsById**](EducationContentsApi.md#geteducationcontentsbyid) | **GET** /ed-fi/educationContents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetEducationContentsPartitions**](EducationContentsApi.md#geteducationcontentspartitions) | **GET** /ed-fi/educationContents/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesEducationContents**](EducationContentsApi.md#keychangeseducationcontents) | **GET** /ed-fi/educationContents/keyChanges | Retrieves resources key changes based on change version. |
| [**PostEducationContent**](EducationContentsApi.md#posteducationcontent) | **POST** /ed-fi/educationContents | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutEducationContent**](EducationContentsApi.md#puteducationcontent) | **PUT** /ed-fi/educationContents/{id} | Updates a resource based on the resource identifier. |

<a id="deleteeducationcontentbyid"></a>
# **DeleteEducationContentById**
> void DeleteEducationContentById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class DeleteEducationContentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteEducationContentById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.DeleteEducationContentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEducationContentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteEducationContentByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.DeleteEducationContentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteseducationcontents"></a>
# **DeletesEducationContents**
> List&lt;TrackedChangesEdFiEducationContentDelete&gt; DeletesEducationContents (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class DeletesEducationContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiEducationContentDelete> result = apiInstance.DeletesEducationContents(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.DeletesEducationContents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesEducationContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiEducationContentDelete>> response = apiInstance.DeletesEducationContentsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.DeletesEducationContentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. Must be false when using cursor paging (with pageToken). | [optional] [default to false] |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiEducationContentDelete&gt;**](TrackedChangesEdFiEducationContentDelete.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteducationcontents"></a>
# **GetEducationContents**
> List&lt;EdFiEducationContent&gt; GetEducationContents (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string contentIdentifier = null, string learningStandardId = null, string contentClassDescriptor = null, string costRateDescriptor = null, string interactivityStyleDescriptor = null, bool additionalAuthorsIndicator = null, double cost = null, string description = null, string id = null, string learningResourceMetadataURI = null, string varNamespace = null, DateOnly publicationDate = null, int publicationYear = null, string publisher = null, string shortDescription = null, string timeRequired = null, string useRightsURL = null, string version = null, bool useSnapshot = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class GetEducationContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var contentIdentifier = "contentIdentifier_example";  // string | A unique identifier for the education content. (optional) 
            var learningStandardId = "learningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var contentClassDescriptor = "contentClassDescriptor_example";  // string | The predominate type or kind characterizing the learning resource. (optional) 
            var costRateDescriptor = "costRateDescriptor_example";  // string | The rate by which the cost applies. (optional) 
            var interactivityStyleDescriptor = "interactivityStyleDescriptor_example";  // string | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. (optional) 
            var additionalAuthorsIndicator = true;  // bool | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \"et al\". (optional) 
            var cost = 1.2D;  // double | An amount that has to be paid or spent to buy or obtain the education content. (optional) 
            var description = "description_example";  // string | An extended written representation of the education content. (optional) 
            var id = "id_example";  // string |  (optional) 
            var learningResourceMetadataURI = "learningResourceMetadataURI_example";  // string | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace for the education content. (optional) 
            var publicationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date on which this content was first published. (optional) 
            var publicationYear = 56;  // int | The year at which this content was first published. (optional) 
            var publisher = "publisher_example";  // string | The organization credited with publishing the resource. (optional) 
            var shortDescription = "shortDescription_example";  // string | A short description or name of the entity. (optional) 
            var timeRequired = "timeRequired_example";  // string | Approximate or typical time that it takes to work with or through this learning resource for the typical intended target audience expressed in minutes. (optional) 
            var useRightsURL = "useRightsURL_example";  // string | The URL where the owner specifies permissions for using the resource. (optional) 
            var version = "version_example";  // string | The version identifier for the content. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiEducationContent> result = apiInstance.GetEducationContents(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, contentIdentifier, learningStandardId, contentClassDescriptor, costRateDescriptor, interactivityStyleDescriptor, additionalAuthorsIndicator, cost, description, id, learningResourceMetadataURI, varNamespace, publicationDate, publicationYear, publisher, shortDescription, timeRequired, useRightsURL, version, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.GetEducationContents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEducationContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiEducationContent>> response = apiInstance.GetEducationContentsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, contentIdentifier, learningStandardId, contentClassDescriptor, costRateDescriptor, interactivityStyleDescriptor, additionalAuthorsIndicator, cost, description, id, learningResourceMetadataURI, varNamespace, publicationDate, publicationYear, publisher, shortDescription, timeRequired, useRightsURL, version, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **pageToken** | **string** | The token of the page to retrieve, obtained either from the \&quot;Next-Page-Token\&quot; header of the previous request, or from the \&quot;partitions\&quot; endpoint for the resource. Cannot be used with limit/offset paging. | [optional]  |
| **pageSize** | **int** | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. Must be false when using cursor paging (with pageToken). | [optional] [default to false] |
| **contentIdentifier** | **string** | A unique identifier for the education content. | [optional]  |
| **learningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **contentClassDescriptor** | **string** | The predominate type or kind characterizing the learning resource. | [optional]  |
| **costRateDescriptor** | **string** | The rate by which the cost applies. | [optional]  |
| **interactivityStyleDescriptor** | **string** | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. | [optional]  |
| **additionalAuthorsIndicator** | **bool** | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;. | [optional]  |
| **cost** | **double** | An amount that has to be paid or spent to buy or obtain the education content. | [optional]  |
| **description** | **string** | An extended written representation of the education content. | [optional]  |
| **id** | **string** |  | [optional]  |
| **learningResourceMetadataURI** | **string** | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional]  |
| **varNamespace** | **string** | Namespace for the education content. | [optional]  |
| **publicationDate** | **DateOnly** | The date on which this content was first published. | [optional]  |
| **publicationYear** | **int** | The year at which this content was first published. | [optional]  |
| **publisher** | **string** | The organization credited with publishing the resource. | [optional]  |
| **shortDescription** | **string** | A short description or name of the entity. | [optional]  |
| **timeRequired** | **string** | Approximate or typical time that it takes to work with or through this learning resource for the typical intended target audience expressed in minutes. | [optional]  |
| **useRightsURL** | **string** | The URL where the owner specifies permissions for using the resource. | [optional]  |
| **version** | **string** | The version identifier for the content. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiEducationContent&gt;**](EdFiEducationContent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  * Next-Page-Token - A token that can be used to retrieve the next contiguous page of items. If not present, it indicates that there are no more items in the current cursor paging context (which is the current partition if the starting token was obtained using the partitions endpoint). <br>  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteducationcontentsbyid"></a>
# **GetEducationContentsById**
> EdFiEducationContent GetEducationContentsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class GetEducationContentsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiEducationContent result = apiInstance.GetEducationContentsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEducationContentsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiEducationContent> response = apiInstance.GetEducationContentsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**EdFiEducationContent**](EdFiEducationContent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteducationcontentspartitions"></a>
# **GetEducationContentsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetEducationContentsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string contentIdentifier = null, string learningStandardId = null, string contentClassDescriptor = null, string costRateDescriptor = null, string interactivityStyleDescriptor = null, bool additionalAuthorsIndicator = null, double cost = null, string description = null, string id = null, string learningResourceMetadataURI = null, string varNamespace = null, DateOnly publicationDate = null, int publicationYear = null, string publisher = null, string shortDescription = null, string timeRequired = null, string useRightsURL = null, string version = null, bool useSnapshot = null)

Retrieves a set of page tokens to be used for efficient client-side parallel processing.

Computes an evenly distributed set of partitions over the accessible data and returns a set of page tokens, each representing the first page of one of the partitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class GetEducationContentsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var contentIdentifier = "contentIdentifier_example";  // string | A unique identifier for the education content. (optional) 
            var learningStandardId = "learningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var contentClassDescriptor = "contentClassDescriptor_example";  // string | The predominate type or kind characterizing the learning resource. (optional) 
            var costRateDescriptor = "costRateDescriptor_example";  // string | The rate by which the cost applies. (optional) 
            var interactivityStyleDescriptor = "interactivityStyleDescriptor_example";  // string | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. (optional) 
            var additionalAuthorsIndicator = true;  // bool | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \"et al\". (optional) 
            var cost = 1.2D;  // double | An amount that has to be paid or spent to buy or obtain the education content. (optional) 
            var description = "description_example";  // string | An extended written representation of the education content. (optional) 
            var id = "id_example";  // string |  (optional) 
            var learningResourceMetadataURI = "learningResourceMetadataURI_example";  // string | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace for the education content. (optional) 
            var publicationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date on which this content was first published. (optional) 
            var publicationYear = 56;  // int | The year at which this content was first published. (optional) 
            var publisher = "publisher_example";  // string | The organization credited with publishing the resource. (optional) 
            var shortDescription = "shortDescription_example";  // string | A short description or name of the entity. (optional) 
            var timeRequired = "timeRequired_example";  // string | Approximate or typical time that it takes to work with or through this learning resource for the typical intended target audience expressed in minutes. (optional) 
            var useRightsURL = "useRightsURL_example";  // string | The URL where the owner specifies permissions for using the resource. (optional) 
            var version = "version_example";  // string | The version identifier for the content. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetEducationContentsPartitions(number, minChangeVersion, maxChangeVersion, contentIdentifier, learningStandardId, contentClassDescriptor, costRateDescriptor, interactivityStyleDescriptor, additionalAuthorsIndicator, cost, description, id, learningResourceMetadataURI, varNamespace, publicationDate, publicationYear, publisher, shortDescription, timeRequired, useRightsURL, version, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEducationContentsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetEducationContentsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, contentIdentifier, learningStandardId, contentClassDescriptor, costRateDescriptor, interactivityStyleDescriptor, additionalAuthorsIndicator, cost, description, id, learningResourceMetadataURI, varNamespace, publicationDate, publicationYear, publisher, shortDescription, timeRequired, useRightsURL, version, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsPartitionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **number** | **int** | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. | [optional]  |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **contentIdentifier** | **string** | A unique identifier for the education content. | [optional]  |
| **learningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **contentClassDescriptor** | **string** | The predominate type or kind characterizing the learning resource. | [optional]  |
| **costRateDescriptor** | **string** | The rate by which the cost applies. | [optional]  |
| **interactivityStyleDescriptor** | **string** | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. | [optional]  |
| **additionalAuthorsIndicator** | **bool** | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;. | [optional]  |
| **cost** | **double** | An amount that has to be paid or spent to buy or obtain the education content. | [optional]  |
| **description** | **string** | An extended written representation of the education content. | [optional]  |
| **id** | **string** |  | [optional]  |
| **learningResourceMetadataURI** | **string** | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional]  |
| **varNamespace** | **string** | Namespace for the education content. | [optional]  |
| **publicationDate** | **DateOnly** | The date on which this content was first published. | [optional]  |
| **publicationYear** | **int** | The year at which this content was first published. | [optional]  |
| **publisher** | **string** | The organization credited with publishing the resource. | [optional]  |
| **shortDescription** | **string** | A short description or name of the entity. | [optional]  |
| **timeRequired** | **string** | Approximate or typical time that it takes to work with or through this learning resource for the typical intended target audience expressed in minutes. | [optional]  |
| **useRightsURL** | **string** | The URL where the owner specifies permissions for using the resource. | [optional]  |
| **version** | **string** | The version identifier for the content. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**GetAbsenceEventCategoryDescriptorsPartitions200Response**](GetAbsenceEventCategoryDescriptorsPartitions200Response.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | The partitions were successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="keychangeseducationcontents"></a>
# **KeyChangesEducationContents**
> List&lt;TrackedChangesEdFiEducationContentKeyChange&gt; KeyChangesEducationContents (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class KeyChangesEducationContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiEducationContentKeyChange> result = apiInstance.KeyChangesEducationContents(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.KeyChangesEducationContents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesEducationContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiEducationContentKeyChange>> response = apiInstance.KeyChangesEducationContentsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.KeyChangesEducationContentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. Must be false when using cursor paging (with pageToken). | [optional] [default to false] |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiEducationContentKeyChange&gt;**](TrackedChangesEdFiEducationContentKeyChange.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="posteducationcontent"></a>
# **PostEducationContent**
> void PostEducationContent (EdFiEducationContent edFiEducationContent)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class PostEducationContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var edFiEducationContent = new EdFiEducationContent(); // EdFiEducationContent | The JSON representation of the \"educationContent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostEducationContent(edFiEducationContent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.PostEducationContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostEducationContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostEducationContentWithHttpInfo(edFiEducationContent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.PostEducationContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiEducationContent** | [**EdFiEducationContent**](EdFiEducationContent.md) | The JSON representation of the \&quot;educationContent\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **201** | The resource was created.  An ETag value is available in the ETag header, and the location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="puteducationcontent"></a>
# **PutEducationContent**
> void PutEducationContent (string id, EdFiEducationContent edFiEducationContent, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class PutEducationContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiEducationContent = new EdFiEducationContent(); // EdFiEducationContent | The JSON representation of the \"educationContent\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutEducationContent(id, edFiEducationContent, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EducationContentsApi.PutEducationContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutEducationContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutEducationContentWithHttpInfo(id, edFiEducationContent, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EducationContentsApi.PutEducationContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiEducationContent** | [**EdFiEducationContent**](EdFiEducationContent.md) | The JSON representation of the \&quot;educationContent\&quot; resource to be created or updated. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

