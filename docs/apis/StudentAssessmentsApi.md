# EdFi.OdsApi.Sdk.v73.Apis.All.StudentAssessmentsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentAssessmentById**](StudentAssessmentsApi.md#deletestudentassessmentbyid) | **DELETE** /ed-fi/studentAssessments/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentAssessments**](StudentAssessmentsApi.md#deletesstudentassessments) | **GET** /ed-fi/studentAssessments/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentAssessments**](StudentAssessmentsApi.md#getstudentassessments) | **GET** /ed-fi/studentAssessments | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentAssessmentsById**](StudentAssessmentsApi.md#getstudentassessmentsbyid) | **GET** /ed-fi/studentAssessments/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentAssessmentsPartitions**](StudentAssessmentsApi.md#getstudentassessmentspartitions) | **GET** /ed-fi/studentAssessments/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentAssessments**](StudentAssessmentsApi.md#keychangesstudentassessments) | **GET** /ed-fi/studentAssessments/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentAssessment**](StudentAssessmentsApi.md#poststudentassessment) | **POST** /ed-fi/studentAssessments | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentAssessment**](StudentAssessmentsApi.md#putstudentassessment) | **PUT** /ed-fi/studentAssessments/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentassessmentbyid"></a>
# **DeleteStudentAssessmentById**
> void DeleteStudentAssessmentById (string id, string ifMatch = null)

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
    public class DeleteStudentAssessmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentAssessmentById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.DeleteStudentAssessmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentAssessmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentAssessmentByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.DeleteStudentAssessmentByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentassessments"></a>
# **DeletesStudentAssessments**
> List&lt;TrackedChangesEdFiStudentAssessmentDelete&gt; DeletesStudentAssessments (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentAssessmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentAssessmentDelete> result = apiInstance.DeletesStudentAssessments(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.DeletesStudentAssessments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentAssessmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentAssessmentDelete>> response = apiInstance.DeletesStudentAssessmentsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.DeletesStudentAssessmentsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentAssessmentDelete&gt;**](TrackedChangesEdFiStudentAssessmentDelete.md)

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

<a id="getstudentassessments"></a>
# **GetStudentAssessments**
> List&lt;EdFiStudentAssessment&gt; GetStudentAssessments (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string studentAssessmentIdentifier = null, string assessmentIdentifier = null, string varNamespace = null, string studentUniqueId = null, long reportedSchoolId = null, int schoolYear = null, string administrationEnvironmentDescriptor = null, string eventCircumstanceDescriptor = null, string whenAssessedGradeLevelDescriptor = null, string administrationLanguageDescriptor = null, string platformTypeDescriptor = null, string reasonNotTestedDescriptor = null, string retestIndicatorDescriptor = null, DateTime administrationDate = null, DateTime administrationEndDate = null, int assessedMinutes = null, string eventDescription = null, string id = null, string reportedSchoolIdentifier = null, string serialNumber = null, bool useSnapshot = null)

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
    public class GetStudentAssessmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var studentAssessmentIdentifier = "studentAssessmentIdentifier_example";  // string | A unique number or alphanumeric code assigned to an assessment administered to a student. (optional) 
            var assessmentIdentifier = "assessmentIdentifier_example";  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace for the assessment. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var reportedSchoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var schoolYear = 56;  // int | The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. (optional) 
            var administrationEnvironmentDescriptor = "administrationEnvironmentDescriptor_example";  // string | The environment in which the test was administered. (optional) 
            var eventCircumstanceDescriptor = "eventCircumstanceDescriptor_example";  // string | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. (optional) 
            var whenAssessedGradeLevelDescriptor = "whenAssessedGradeLevelDescriptor_example";  // string | The grade level of a student when assessed. (optional) 
            var administrationLanguageDescriptor = "administrationLanguageDescriptor_example";  // string | The language in which an assessment is written and/or administered. (optional) 
            var platformTypeDescriptor = "platformTypeDescriptor_example";  // string | The platform with which the assessment was delivered to the student during the assessment session. (optional) 
            var reasonNotTestedDescriptor = "reasonNotTestedDescriptor_example";  // string | The primary reason student is not tested. (optional) 
            var retestIndicatorDescriptor = "retestIndicatorDescriptor_example";  // string | Indicator if the test was a retake. (optional) 
            var administrationDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. (optional) 
            var administrationEndDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The date and time an assessment administration ended. (optional) 
            var assessedMinutes = 56;  // int | Reported time student was assessed in minutes. (optional) 
            var eventDescription = "eventDescription_example";  // string | Describes special events that occur before during or after the assessment session that may impact use of results. (optional) 
            var id = "id_example";  // string |  (optional) 
            var reportedSchoolIdentifier = "reportedSchoolIdentifier_example";  // string | A reported school identifier for the school the enrollment at the time of the assessment used when the assigned SchoolId is not known by the assessment vendor. (optional) 
            var serialNumber = "serialNumber_example";  // string | The unique number for the assessment form or answer document. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentAssessment> result = apiInstance.GetStudentAssessments(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, studentAssessmentIdentifier, assessmentIdentifier, varNamespace, studentUniqueId, reportedSchoolId, schoolYear, administrationEnvironmentDescriptor, eventCircumstanceDescriptor, whenAssessedGradeLevelDescriptor, administrationLanguageDescriptor, platformTypeDescriptor, reasonNotTestedDescriptor, retestIndicatorDescriptor, administrationDate, administrationEndDate, assessedMinutes, eventDescription, id, reportedSchoolIdentifier, serialNumber, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAssessmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentAssessment>> response = apiInstance.GetStudentAssessmentsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, studentAssessmentIdentifier, assessmentIdentifier, varNamespace, studentUniqueId, reportedSchoolId, schoolYear, administrationEnvironmentDescriptor, eventCircumstanceDescriptor, whenAssessedGradeLevelDescriptor, administrationLanguageDescriptor, platformTypeDescriptor, reasonNotTestedDescriptor, retestIndicatorDescriptor, administrationDate, administrationEndDate, assessedMinutes, eventDescription, id, reportedSchoolIdentifier, serialNumber, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsWithHttpInfo: " + e.Message);
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
| **studentAssessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment administered to a student. | [optional]  |
| **assessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment. | [optional]  |
| **varNamespace** | **string** | Namespace for the assessment. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **reportedSchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **schoolYear** | **int** | The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. | [optional]  |
| **administrationEnvironmentDescriptor** | **string** | The environment in which the test was administered. | [optional]  |
| **eventCircumstanceDescriptor** | **string** | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. | [optional]  |
| **whenAssessedGradeLevelDescriptor** | **string** | The grade level of a student when assessed. | [optional]  |
| **administrationLanguageDescriptor** | **string** | The language in which an assessment is written and/or administered. | [optional]  |
| **platformTypeDescriptor** | **string** | The platform with which the assessment was delivered to the student during the assessment session. | [optional]  |
| **reasonNotTestedDescriptor** | **string** | The primary reason student is not tested. | [optional]  |
| **retestIndicatorDescriptor** | **string** | Indicator if the test was a retake. | [optional]  |
| **administrationDate** | **DateTime** | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. | [optional]  |
| **administrationEndDate** | **DateTime** | The date and time an assessment administration ended. | [optional]  |
| **assessedMinutes** | **int** | Reported time student was assessed in minutes. | [optional]  |
| **eventDescription** | **string** | Describes special events that occur before during or after the assessment session that may impact use of results. | [optional]  |
| **id** | **string** |  | [optional]  |
| **reportedSchoolIdentifier** | **string** | A reported school identifier for the school the enrollment at the time of the assessment used when the assigned SchoolId is not known by the assessment vendor. | [optional]  |
| **serialNumber** | **string** | The unique number for the assessment form or answer document. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentAssessment&gt;**](EdFiStudentAssessment.md)

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

<a id="getstudentassessmentsbyid"></a>
# **GetStudentAssessmentsById**
> EdFiStudentAssessment GetStudentAssessmentsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentAssessmentsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentAssessment result = apiInstance.GetStudentAssessmentsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAssessmentsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentAssessment> response = apiInstance.GetStudentAssessmentsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentAssessment**](EdFiStudentAssessment.md)

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

<a id="getstudentassessmentspartitions"></a>
# **GetStudentAssessmentsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentAssessmentsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string studentAssessmentIdentifier = null, string assessmentIdentifier = null, string varNamespace = null, string studentUniqueId = null, long reportedSchoolId = null, int schoolYear = null, string administrationEnvironmentDescriptor = null, string eventCircumstanceDescriptor = null, string whenAssessedGradeLevelDescriptor = null, string administrationLanguageDescriptor = null, string platformTypeDescriptor = null, string reasonNotTestedDescriptor = null, string retestIndicatorDescriptor = null, DateTime administrationDate = null, DateTime administrationEndDate = null, int assessedMinutes = null, string eventDescription = null, string id = null, string reportedSchoolIdentifier = null, string serialNumber = null, bool useSnapshot = null)

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
    public class GetStudentAssessmentsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var studentAssessmentIdentifier = "studentAssessmentIdentifier_example";  // string | A unique number or alphanumeric code assigned to an assessment administered to a student. (optional) 
            var assessmentIdentifier = "assessmentIdentifier_example";  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace for the assessment. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var reportedSchoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var schoolYear = 56;  // int | The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. (optional) 
            var administrationEnvironmentDescriptor = "administrationEnvironmentDescriptor_example";  // string | The environment in which the test was administered. (optional) 
            var eventCircumstanceDescriptor = "eventCircumstanceDescriptor_example";  // string | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. (optional) 
            var whenAssessedGradeLevelDescriptor = "whenAssessedGradeLevelDescriptor_example";  // string | The grade level of a student when assessed. (optional) 
            var administrationLanguageDescriptor = "administrationLanguageDescriptor_example";  // string | The language in which an assessment is written and/or administered. (optional) 
            var platformTypeDescriptor = "platformTypeDescriptor_example";  // string | The platform with which the assessment was delivered to the student during the assessment session. (optional) 
            var reasonNotTestedDescriptor = "reasonNotTestedDescriptor_example";  // string | The primary reason student is not tested. (optional) 
            var retestIndicatorDescriptor = "retestIndicatorDescriptor_example";  // string | Indicator if the test was a retake. (optional) 
            var administrationDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. (optional) 
            var administrationEndDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The date and time an assessment administration ended. (optional) 
            var assessedMinutes = 56;  // int | Reported time student was assessed in minutes. (optional) 
            var eventDescription = "eventDescription_example";  // string | Describes special events that occur before during or after the assessment session that may impact use of results. (optional) 
            var id = "id_example";  // string |  (optional) 
            var reportedSchoolIdentifier = "reportedSchoolIdentifier_example";  // string | A reported school identifier for the school the enrollment at the time of the assessment used when the assigned SchoolId is not known by the assessment vendor. (optional) 
            var serialNumber = "serialNumber_example";  // string | The unique number for the assessment form or answer document. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentAssessmentsPartitions(number, minChangeVersion, maxChangeVersion, studentAssessmentIdentifier, assessmentIdentifier, varNamespace, studentUniqueId, reportedSchoolId, schoolYear, administrationEnvironmentDescriptor, eventCircumstanceDescriptor, whenAssessedGradeLevelDescriptor, administrationLanguageDescriptor, platformTypeDescriptor, reasonNotTestedDescriptor, retestIndicatorDescriptor, administrationDate, administrationEndDate, assessedMinutes, eventDescription, id, reportedSchoolIdentifier, serialNumber, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentAssessmentsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentAssessmentsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, studentAssessmentIdentifier, assessmentIdentifier, varNamespace, studentUniqueId, reportedSchoolId, schoolYear, administrationEnvironmentDescriptor, eventCircumstanceDescriptor, whenAssessedGradeLevelDescriptor, administrationLanguageDescriptor, platformTypeDescriptor, reasonNotTestedDescriptor, retestIndicatorDescriptor, administrationDate, administrationEndDate, assessedMinutes, eventDescription, id, reportedSchoolIdentifier, serialNumber, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsPartitionsWithHttpInfo: " + e.Message);
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
| **studentAssessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment administered to a student. | [optional]  |
| **assessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment. | [optional]  |
| **varNamespace** | **string** | Namespace for the assessment. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **reportedSchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **schoolYear** | **int** | The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. | [optional]  |
| **administrationEnvironmentDescriptor** | **string** | The environment in which the test was administered. | [optional]  |
| **eventCircumstanceDescriptor** | **string** | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. | [optional]  |
| **whenAssessedGradeLevelDescriptor** | **string** | The grade level of a student when assessed. | [optional]  |
| **administrationLanguageDescriptor** | **string** | The language in which an assessment is written and/or administered. | [optional]  |
| **platformTypeDescriptor** | **string** | The platform with which the assessment was delivered to the student during the assessment session. | [optional]  |
| **reasonNotTestedDescriptor** | **string** | The primary reason student is not tested. | [optional]  |
| **retestIndicatorDescriptor** | **string** | Indicator if the test was a retake. | [optional]  |
| **administrationDate** | **DateTime** | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. | [optional]  |
| **administrationEndDate** | **DateTime** | The date and time an assessment administration ended. | [optional]  |
| **assessedMinutes** | **int** | Reported time student was assessed in minutes. | [optional]  |
| **eventDescription** | **string** | Describes special events that occur before during or after the assessment session that may impact use of results. | [optional]  |
| **id** | **string** |  | [optional]  |
| **reportedSchoolIdentifier** | **string** | A reported school identifier for the school the enrollment at the time of the assessment used when the assigned SchoolId is not known by the assessment vendor. | [optional]  |
| **serialNumber** | **string** | The unique number for the assessment form or answer document. | [optional]  |
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

<a id="keychangesstudentassessments"></a>
# **KeyChangesStudentAssessments**
> List&lt;TrackedChangesEdFiStudentAssessmentKeyChange&gt; KeyChangesStudentAssessments (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentAssessmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentAssessmentKeyChange> result = apiInstance.KeyChangesStudentAssessments(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.KeyChangesStudentAssessments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentAssessmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentAssessmentKeyChange>> response = apiInstance.KeyChangesStudentAssessmentsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.KeyChangesStudentAssessmentsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentAssessmentKeyChange&gt;**](TrackedChangesEdFiStudentAssessmentKeyChange.md)

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

<a id="poststudentassessment"></a>
# **PostStudentAssessment**
> void PostStudentAssessment (EdFiStudentAssessment edFiStudentAssessment)

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
    public class PostStudentAssessmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var edFiStudentAssessment = new EdFiStudentAssessment(); // EdFiStudentAssessment | The JSON representation of the \"studentAssessment\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentAssessment(edFiStudentAssessment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.PostStudentAssessment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentAssessmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentAssessmentWithHttpInfo(edFiStudentAssessment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.PostStudentAssessmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentAssessment** | [**EdFiStudentAssessment**](EdFiStudentAssessment.md) | The JSON representation of the \&quot;studentAssessment\&quot; resource to be created or updated. |  |

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

<a id="putstudentassessment"></a>
# **PutStudentAssessment**
> void PutStudentAssessment (string id, EdFiStudentAssessment edFiStudentAssessment, string ifMatch = null)

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
    public class PutStudentAssessmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentAssessment = new EdFiStudentAssessment(); // EdFiStudentAssessment | The JSON representation of the \"studentAssessment\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentAssessment(id, edFiStudentAssessment, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.PutStudentAssessment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentAssessmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentAssessmentWithHttpInfo(id, edFiStudentAssessment, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentAssessmentsApi.PutStudentAssessmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentAssessment** | [**EdFiStudentAssessment**](EdFiStudentAssessment.md) | The JSON representation of the \&quot;studentAssessment\&quot; resource to be created or updated. |  |
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

