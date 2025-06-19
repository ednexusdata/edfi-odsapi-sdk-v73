# EdFi.OdsApi.Sdk.v73.Apis.All.LearningStandardsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteLearningStandardById**](LearningStandardsApi.md#deletelearningstandardbyid) | **DELETE** /ed-fi/learningStandards/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesLearningStandards**](LearningStandardsApi.md#deleteslearningstandards) | **GET** /ed-fi/learningStandards/deletes | Retrieves deleted resources based on change version. |
| [**GetLearningStandards**](LearningStandardsApi.md#getlearningstandards) | **GET** /ed-fi/learningStandards | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetLearningStandardsById**](LearningStandardsApi.md#getlearningstandardsbyid) | **GET** /ed-fi/learningStandards/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetLearningStandardsPartitions**](LearningStandardsApi.md#getlearningstandardspartitions) | **GET** /ed-fi/learningStandards/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesLearningStandards**](LearningStandardsApi.md#keychangeslearningstandards) | **GET** /ed-fi/learningStandards/keyChanges | Retrieves resources key changes based on change version. |
| [**PostLearningStandard**](LearningStandardsApi.md#postlearningstandard) | **POST** /ed-fi/learningStandards | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutLearningStandard**](LearningStandardsApi.md#putlearningstandard) | **PUT** /ed-fi/learningStandards/{id} | Updates a resource based on the resource identifier. |

<a id="deletelearningstandardbyid"></a>
# **DeleteLearningStandardById**
> void DeleteLearningStandardById (string id, string ifMatch = null)

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
    public class DeleteLearningStandardByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteLearningStandardById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.DeleteLearningStandardById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLearningStandardByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteLearningStandardByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.DeleteLearningStandardByIdWithHttpInfo: " + e.Message);
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

<a id="deleteslearningstandards"></a>
# **DeletesLearningStandards**
> List&lt;TrackedChangesEdFiLearningStandardDelete&gt; DeletesLearningStandards (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesLearningStandardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiLearningStandardDelete> result = apiInstance.DeletesLearningStandards(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.DeletesLearningStandards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesLearningStandardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiLearningStandardDelete>> response = apiInstance.DeletesLearningStandardsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.DeletesLearningStandardsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiLearningStandardDelete&gt;**](TrackedChangesEdFiLearningStandardDelete.md)

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

<a id="getlearningstandards"></a>
# **GetLearningStandards**
> List&lt;EdFiLearningStandard&gt; GetLearningStandards (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string learningStandardId = null, string parentLearningStandardId = null, string learningStandardCategoryDescriptor = null, string learningStandardScopeDescriptor = null, string courseTitle = null, string description = null, string id = null, string learningStandardItemCode = null, string varNamespace = null, string successCriteria = null, string uri = null, bool useSnapshot = null, string contentStandardName = null, string identificationCode = null)

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
    public class GetLearningStandardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var learningStandardId = "learningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var parentLearningStandardId = "parentLearningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var learningStandardCategoryDescriptor = "learningStandardCategoryDescriptor_example";  // string | An additional classification of the type of a specific learning standard. (optional) 
            var learningStandardScopeDescriptor = "learningStandardScopeDescriptor_example";  // string | Signals the scope of usage the standard. Does not necessarily relate the standard to the governing body. (optional) 
            var courseTitle = "courseTitle_example";  // string | The official course title with which this learning standard is associated. (optional) 
            var description = "description_example";  // string | The text of the statement. The textual content that either describes a specific competency such as \"Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\" or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \"Understand and apply the Pythagorean Theorem,\" or \"Geometry\". (optional) 
            var id = "id_example";  // string |  (optional) 
            var learningStandardItemCode = "learningStandardItemCode_example";  // string | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). (optional) 
            var varNamespace = "varNamespace_example";  // string | The namespace of the organization or entity who governs the standard. It is recommended the namespaces observe a URI format and begin with a domain name under the governing organization or entity control. (optional) 
            var successCriteria = "successCriteria_example";  // string | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning standard. (optional) 
            var uri = "uri_example";  // string | An unambiguous reference to the statement using a network-resolvable URI. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var contentStandardName = "contentStandardName_example";  // string | The name of the content standard, for example Common Core. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a Learning Standard. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiLearningStandard> result = apiInstance.GetLearningStandards(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, learningStandardId, parentLearningStandardId, learningStandardCategoryDescriptor, learningStandardScopeDescriptor, courseTitle, description, id, learningStandardItemCode, varNamespace, successCriteria, uri, useSnapshot, contentStandardName, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLearningStandardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiLearningStandard>> response = apiInstance.GetLearningStandardsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, learningStandardId, parentLearningStandardId, learningStandardCategoryDescriptor, learningStandardScopeDescriptor, courseTitle, description, id, learningStandardItemCode, varNamespace, successCriteria, uri, useSnapshot, contentStandardName, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsWithHttpInfo: " + e.Message);
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
| **learningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **parentLearningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **learningStandardCategoryDescriptor** | **string** | An additional classification of the type of a specific learning standard. | [optional]  |
| **learningStandardScopeDescriptor** | **string** | Signals the scope of usage the standard. Does not necessarily relate the standard to the governing body. | [optional]  |
| **courseTitle** | **string** | The official course title with which this learning standard is associated. | [optional]  |
| **description** | **string** | The text of the statement. The textual content that either describes a specific competency such as \&quot;Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\&quot; or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \&quot;Understand and apply the Pythagorean Theorem,\&quot; or \&quot;Geometry\&quot;. | [optional]  |
| **id** | **string** |  | [optional]  |
| **learningStandardItemCode** | **string** | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). | [optional]  |
| **varNamespace** | **string** | The namespace of the organization or entity who governs the standard. It is recommended the namespaces observe a URI format and begin with a domain name under the governing organization or entity control. | [optional]  |
| **successCriteria** | **string** | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning standard. | [optional]  |
| **uri** | **string** | An unambiguous reference to the statement using a network-resolvable URI. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **contentStandardName** | **string** | The name of the content standard, for example Common Core. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a Learning Standard. | [optional]  |

### Return type

[**List&lt;EdFiLearningStandard&gt;**](EdFiLearningStandard.md)

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

<a id="getlearningstandardsbyid"></a>
# **GetLearningStandardsById**
> EdFiLearningStandard GetLearningStandardsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetLearningStandardsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiLearningStandard result = apiInstance.GetLearningStandardsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLearningStandardsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiLearningStandard> response = apiInstance.GetLearningStandardsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsByIdWithHttpInfo: " + e.Message);
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

[**EdFiLearningStandard**](EdFiLearningStandard.md)

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

<a id="getlearningstandardspartitions"></a>
# **GetLearningStandardsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetLearningStandardsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string learningStandardId = null, string parentLearningStandardId = null, string learningStandardCategoryDescriptor = null, string learningStandardScopeDescriptor = null, string courseTitle = null, string description = null, string id = null, string learningStandardItemCode = null, string varNamespace = null, string successCriteria = null, string uri = null, bool useSnapshot = null, string contentStandardName = null, string identificationCode = null)

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
    public class GetLearningStandardsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var learningStandardId = "learningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var parentLearningStandardId = "parentLearningStandardId_example";  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var learningStandardCategoryDescriptor = "learningStandardCategoryDescriptor_example";  // string | An additional classification of the type of a specific learning standard. (optional) 
            var learningStandardScopeDescriptor = "learningStandardScopeDescriptor_example";  // string | Signals the scope of usage the standard. Does not necessarily relate the standard to the governing body. (optional) 
            var courseTitle = "courseTitle_example";  // string | The official course title with which this learning standard is associated. (optional) 
            var description = "description_example";  // string | The text of the statement. The textual content that either describes a specific competency such as \"Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\" or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \"Understand and apply the Pythagorean Theorem,\" or \"Geometry\". (optional) 
            var id = "id_example";  // string |  (optional) 
            var learningStandardItemCode = "learningStandardItemCode_example";  // string | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). (optional) 
            var varNamespace = "varNamespace_example";  // string | The namespace of the organization or entity who governs the standard. It is recommended the namespaces observe a URI format and begin with a domain name under the governing organization or entity control. (optional) 
            var successCriteria = "successCriteria_example";  // string | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning standard. (optional) 
            var uri = "uri_example";  // string | An unambiguous reference to the statement using a network-resolvable URI. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var contentStandardName = "contentStandardName_example";  // string | The name of the content standard, for example Common Core. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a Learning Standard. (optional) 

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetLearningStandardsPartitions(number, minChangeVersion, maxChangeVersion, learningStandardId, parentLearningStandardId, learningStandardCategoryDescriptor, learningStandardScopeDescriptor, courseTitle, description, id, learningStandardItemCode, varNamespace, successCriteria, uri, useSnapshot, contentStandardName, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLearningStandardsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetLearningStandardsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, learningStandardId, parentLearningStandardId, learningStandardCategoryDescriptor, learningStandardScopeDescriptor, courseTitle, description, id, learningStandardItemCode, varNamespace, successCriteria, uri, useSnapshot, contentStandardName, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsPartitionsWithHttpInfo: " + e.Message);
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
| **learningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **parentLearningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional]  |
| **learningStandardCategoryDescriptor** | **string** | An additional classification of the type of a specific learning standard. | [optional]  |
| **learningStandardScopeDescriptor** | **string** | Signals the scope of usage the standard. Does not necessarily relate the standard to the governing body. | [optional]  |
| **courseTitle** | **string** | The official course title with which this learning standard is associated. | [optional]  |
| **description** | **string** | The text of the statement. The textual content that either describes a specific competency such as \&quot;Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\&quot; or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \&quot;Understand and apply the Pythagorean Theorem,\&quot; or \&quot;Geometry\&quot;. | [optional]  |
| **id** | **string** |  | [optional]  |
| **learningStandardItemCode** | **string** | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). | [optional]  |
| **varNamespace** | **string** | The namespace of the organization or entity who governs the standard. It is recommended the namespaces observe a URI format and begin with a domain name under the governing organization or entity control. | [optional]  |
| **successCriteria** | **string** | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning standard. | [optional]  |
| **uri** | **string** | An unambiguous reference to the statement using a network-resolvable URI. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **contentStandardName** | **string** | The name of the content standard, for example Common Core. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a Learning Standard. | [optional]  |

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

<a id="keychangeslearningstandards"></a>
# **KeyChangesLearningStandards**
> List&lt;TrackedChangesEdFiLearningStandardKeyChange&gt; KeyChangesLearningStandards (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesLearningStandardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiLearningStandardKeyChange> result = apiInstance.KeyChangesLearningStandards(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.KeyChangesLearningStandards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesLearningStandardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiLearningStandardKeyChange>> response = apiInstance.KeyChangesLearningStandardsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.KeyChangesLearningStandardsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiLearningStandardKeyChange&gt;**](TrackedChangesEdFiLearningStandardKeyChange.md)

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

<a id="postlearningstandard"></a>
# **PostLearningStandard**
> void PostLearningStandard (EdFiLearningStandard edFiLearningStandard)

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
    public class PostLearningStandardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var edFiLearningStandard = new EdFiLearningStandard(); // EdFiLearningStandard | The JSON representation of the \"learningStandard\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostLearningStandard(edFiLearningStandard);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.PostLearningStandard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostLearningStandardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostLearningStandardWithHttpInfo(edFiLearningStandard);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.PostLearningStandardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiLearningStandard** | [**EdFiLearningStandard**](EdFiLearningStandard.md) | The JSON representation of the \&quot;learningStandard\&quot; resource to be created or updated. |  |

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

<a id="putlearningstandard"></a>
# **PutLearningStandard**
> void PutLearningStandard (string id, EdFiLearningStandard edFiLearningStandard, string ifMatch = null)

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
    public class PutLearningStandardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiLearningStandard = new EdFiLearningStandard(); // EdFiLearningStandard | The JSON representation of the \"learningStandard\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutLearningStandard(id, edFiLearningStandard, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.PutLearningStandard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutLearningStandardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutLearningStandardWithHttpInfo(id, edFiLearningStandard, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LearningStandardsApi.PutLearningStandardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiLearningStandard** | [**EdFiLearningStandard**](EdFiLearningStandard.md) | The JSON representation of the \&quot;learningStandard\&quot; resource to be created or updated. |  |
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

