# EdFi.OdsApi.Sdk.v73.Apis.All.StudentAcademicRecordsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentAcademicRecordById**](StudentAcademicRecordsApi.md#deletestudentacademicrecordbyid) | **DELETE** /ed-fi/studentAcademicRecords/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentAcademicRecords**](StudentAcademicRecordsApi.md#deletesstudentacademicrecords) | **GET** /ed-fi/studentAcademicRecords/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentAcademicRecords**](StudentAcademicRecordsApi.md#getstudentacademicrecords) | **GET** /ed-fi/studentAcademicRecords | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentAcademicRecordsById**](StudentAcademicRecordsApi.md#getstudentacademicrecordsbyid) | **GET** /ed-fi/studentAcademicRecords/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentAcademicRecordsPartitions**](StudentAcademicRecordsApi.md#getstudentacademicrecordspartitions) | **GET** /ed-fi/studentAcademicRecords/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentAcademicRecords**](StudentAcademicRecordsApi.md#keychangesstudentacademicrecords) | **GET** /ed-fi/studentAcademicRecords/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentAcademicRecord**](StudentAcademicRecordsApi.md#poststudentacademicrecord) | **POST** /ed-fi/studentAcademicRecords | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentAcademicRecord**](StudentAcademicRecordsApi.md#putstudentacademicrecord) | **PUT** /ed-fi/studentAcademicRecords/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentacademicrecordbyid"></a>
# **DeleteStudentAcademicRecordById**
> void DeleteStudentAcademicRecordById (string id, string ifMatch = null)

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
    public class DeleteStudentAcademicRecordByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentAcademicRecordById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.DeleteStudentAcademicRecordById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentAcademicRecordByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentAcademicRecordByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.DeleteStudentAcademicRecordByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentacademicrecords"></a>
# **DeletesStudentAcademicRecords**
> List&lt;TrackedChangesEdFiStudentAcademicRecordDelete&gt; DeletesStudentAcademicRecords (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentAcademicRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentAcademicRecordDelete> result = apiInstance.DeletesStudentAcademicRecords(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.DeletesStudentAcademicRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentAcademicRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentAcademicRecordDelete>> response = apiInstance.DeletesStudentAcademicRecordsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.DeletesStudentAcademicRecordsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentAcademicRecordDelete&gt;**](TrackedChangesEdFiStudentAcademicRecordDelete.md)

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

<a id="getstudentacademicrecords"></a>
# **GetStudentAcademicRecords**
> List&lt;EdFiStudentAcademicRecord&gt; GetStudentAcademicRecords (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string termDescriptor = null, long educationOrganizationId = null, int schoolYear = null, string studentUniqueId = null, string cumulativeEarnedCreditTypeDescriptor = null, string cumulativeAttemptedCreditTypeDescriptor = null, string sessionEarnedCreditTypeDescriptor = null, string sessionAttemptedCreditTypeDescriptor = null, double cumulativeAttemptedCreditConversion = null, double cumulativeAttemptedCredits = null, double cumulativeEarnedCreditConversion = null, double cumulativeEarnedCredits = null, string id = null, DateOnly projectedGraduationDate = null, double sessionAttemptedCreditConversion = null, double sessionAttemptedCredits = null, double sessionEarnedCreditConversion = null, double sessionEarnedCredits = null, bool useSnapshot = null)

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
    public class GetStudentAcademicRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var termDescriptor = "termDescriptor_example";  // string | The term for the session during the school year. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int | The identifier for the school year. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var cumulativeEarnedCreditTypeDescriptor = "cumulativeEarnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditTypeDescriptor = "cumulativeAttemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditTypeDescriptor = "sessionEarnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionAttemptedCreditTypeDescriptor = "sessionAttemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeAttemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeEarnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeEarnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var id = "id_example";  // string |  (optional) 
            var projectedGraduationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month and year the student is projected to graduate. (optional) 
            var sessionAttemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionAttemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionEarnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentAcademicRecord> result = apiInstance.GetStudentAcademicRecords(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, termDescriptor, educationOrganizationId, schoolYear, studentUniqueId, cumulativeEarnedCreditTypeDescriptor, cumulativeAttemptedCreditTypeDescriptor, sessionEarnedCreditTypeDescriptor, sessionAttemptedCreditTypeDescriptor, cumulativeAttemptedCreditConversion, cumulativeAttemptedCredits, cumulativeEarnedCreditConversion, cumulativeEarnedCredits, id, projectedGraduationDate, sessionAttemptedCreditConversion, sessionAttemptedCredits, sessionEarnedCreditConversion, sessionEarnedCredits, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAcademicRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentAcademicRecord>> response = apiInstance.GetStudentAcademicRecordsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, termDescriptor, educationOrganizationId, schoolYear, studentUniqueId, cumulativeEarnedCreditTypeDescriptor, cumulativeAttemptedCreditTypeDescriptor, sessionEarnedCreditTypeDescriptor, sessionAttemptedCreditTypeDescriptor, cumulativeAttemptedCreditConversion, cumulativeAttemptedCredits, cumulativeEarnedCreditConversion, cumulativeEarnedCredits, id, projectedGraduationDate, sessionAttemptedCreditConversion, sessionAttemptedCredits, sessionEarnedCreditConversion, sessionEarnedCredits, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsWithHttpInfo: " + e.Message);
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
| **termDescriptor** | **string** | The term for the session during the school year. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **schoolYear** | **int** | The identifier for the school year. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **cumulativeEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **cumulativeAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **cumulativeEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **id** | **string** |  | [optional]  |
| **projectedGraduationDate** | **DateOnly** | The month and year the student is projected to graduate. | [optional]  |
| **sessionAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **sessionAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **sessionEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentAcademicRecord&gt;**](EdFiStudentAcademicRecord.md)

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

<a id="getstudentacademicrecordsbyid"></a>
# **GetStudentAcademicRecordsById**
> EdFiStudentAcademicRecord GetStudentAcademicRecordsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentAcademicRecordsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentAcademicRecord result = apiInstance.GetStudentAcademicRecordsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAcademicRecordsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentAcademicRecord> response = apiInstance.GetStudentAcademicRecordsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md)

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

<a id="getstudentacademicrecordspartitions"></a>
# **GetStudentAcademicRecordsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentAcademicRecordsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string termDescriptor = null, long educationOrganizationId = null, int schoolYear = null, string studentUniqueId = null, string cumulativeEarnedCreditTypeDescriptor = null, string cumulativeAttemptedCreditTypeDescriptor = null, string sessionEarnedCreditTypeDescriptor = null, string sessionAttemptedCreditTypeDescriptor = null, double cumulativeAttemptedCreditConversion = null, double cumulativeAttemptedCredits = null, double cumulativeEarnedCreditConversion = null, double cumulativeEarnedCredits = null, string id = null, DateOnly projectedGraduationDate = null, double sessionAttemptedCreditConversion = null, double sessionAttemptedCredits = null, double sessionEarnedCreditConversion = null, double sessionEarnedCredits = null, bool useSnapshot = null)

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
    public class GetStudentAcademicRecordsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var termDescriptor = "termDescriptor_example";  // string | The term for the session during the school year. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int | The identifier for the school year. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var cumulativeEarnedCreditTypeDescriptor = "cumulativeEarnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditTypeDescriptor = "cumulativeAttemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditTypeDescriptor = "sessionEarnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionAttemptedCreditTypeDescriptor = "sessionAttemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeAttemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeEarnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeEarnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var id = "id_example";  // string |  (optional) 
            var projectedGraduationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month and year the student is projected to graduate. (optional) 
            var sessionAttemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionAttemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionEarnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentAcademicRecordsPartitions(number, minChangeVersion, maxChangeVersion, termDescriptor, educationOrganizationId, schoolYear, studentUniqueId, cumulativeEarnedCreditTypeDescriptor, cumulativeAttemptedCreditTypeDescriptor, sessionEarnedCreditTypeDescriptor, sessionAttemptedCreditTypeDescriptor, cumulativeAttemptedCreditConversion, cumulativeAttemptedCredits, cumulativeEarnedCreditConversion, cumulativeEarnedCredits, id, projectedGraduationDate, sessionAttemptedCreditConversion, sessionAttemptedCredits, sessionEarnedCreditConversion, sessionEarnedCredits, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAcademicRecordsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentAcademicRecordsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, termDescriptor, educationOrganizationId, schoolYear, studentUniqueId, cumulativeEarnedCreditTypeDescriptor, cumulativeAttemptedCreditTypeDescriptor, sessionEarnedCreditTypeDescriptor, sessionAttemptedCreditTypeDescriptor, cumulativeAttemptedCreditConversion, cumulativeAttemptedCredits, cumulativeEarnedCreditConversion, cumulativeEarnedCredits, id, projectedGraduationDate, sessionAttemptedCreditConversion, sessionAttemptedCredits, sessionEarnedCreditConversion, sessionEarnedCredits, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsPartitionsWithHttpInfo: " + e.Message);
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
| **termDescriptor** | **string** | The term for the session during the school year. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **schoolYear** | **int** | The identifier for the school year. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **cumulativeEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **cumulativeAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **cumulativeEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **cumulativeEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **id** | **string** |  | [optional]  |
| **projectedGraduationDate** | **DateOnly** | The month and year the student is projected to graduate. | [optional]  |
| **sessionAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **sessionAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **sessionEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **sessionEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
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

<a id="keychangesstudentacademicrecords"></a>
# **KeyChangesStudentAcademicRecords**
> List&lt;TrackedChangesEdFiStudentAcademicRecordKeyChange&gt; KeyChangesStudentAcademicRecords (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentAcademicRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentAcademicRecordKeyChange> result = apiInstance.KeyChangesStudentAcademicRecords(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.KeyChangesStudentAcademicRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentAcademicRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentAcademicRecordKeyChange>> response = apiInstance.KeyChangesStudentAcademicRecordsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.KeyChangesStudentAcademicRecordsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentAcademicRecordKeyChange&gt;**](TrackedChangesEdFiStudentAcademicRecordKeyChange.md)

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

<a id="poststudentacademicrecord"></a>
# **PostStudentAcademicRecord**
> void PostStudentAcademicRecord (EdFiStudentAcademicRecord edFiStudentAcademicRecord)

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
    public class PostStudentAcademicRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var edFiStudentAcademicRecord = new EdFiStudentAcademicRecord(); // EdFiStudentAcademicRecord | The JSON representation of the \"studentAcademicRecord\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentAcademicRecord(edFiStudentAcademicRecord);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.PostStudentAcademicRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentAcademicRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentAcademicRecordWithHttpInfo(edFiStudentAcademicRecord);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.PostStudentAcademicRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentAcademicRecord** | [**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md) | The JSON representation of the \&quot;studentAcademicRecord\&quot; resource to be created or updated. |  |

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

<a id="putstudentacademicrecord"></a>
# **PutStudentAcademicRecord**
> void PutStudentAcademicRecord (string id, EdFiStudentAcademicRecord edFiStudentAcademicRecord, string ifMatch = null)

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
    public class PutStudentAcademicRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentAcademicRecord = new EdFiStudentAcademicRecord(); // EdFiStudentAcademicRecord | The JSON representation of the \"studentAcademicRecord\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentAcademicRecord(id, edFiStudentAcademicRecord, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.PutStudentAcademicRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentAcademicRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentAcademicRecordWithHttpInfo(id, edFiStudentAcademicRecord, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAcademicRecordsApi.PutStudentAcademicRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentAcademicRecord** | [**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md) | The JSON representation of the \&quot;studentAcademicRecord\&quot; resource to be created or updated. |  |
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

