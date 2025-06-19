# EdFi.OdsApi.Sdk.v73.Apis.All.CourseTranscriptsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCourseTranscriptById**](CourseTranscriptsApi.md#deletecoursetranscriptbyid) | **DELETE** /ed-fi/courseTranscripts/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesCourseTranscripts**](CourseTranscriptsApi.md#deletescoursetranscripts) | **GET** /ed-fi/courseTranscripts/deletes | Retrieves deleted resources based on change version. |
| [**GetCourseTranscripts**](CourseTranscriptsApi.md#getcoursetranscripts) | **GET** /ed-fi/courseTranscripts | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetCourseTranscriptsById**](CourseTranscriptsApi.md#getcoursetranscriptsbyid) | **GET** /ed-fi/courseTranscripts/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetCourseTranscriptsPartitions**](CourseTranscriptsApi.md#getcoursetranscriptspartitions) | **GET** /ed-fi/courseTranscripts/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesCourseTranscripts**](CourseTranscriptsApi.md#keychangescoursetranscripts) | **GET** /ed-fi/courseTranscripts/keyChanges | Retrieves resources key changes based on change version. |
| [**PostCourseTranscript**](CourseTranscriptsApi.md#postcoursetranscript) | **POST** /ed-fi/courseTranscripts | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutCourseTranscript**](CourseTranscriptsApi.md#putcoursetranscript) | **PUT** /ed-fi/courseTranscripts/{id} | Updates a resource based on the resource identifier. |

<a id="deletecoursetranscriptbyid"></a>
# **DeleteCourseTranscriptById**
> void DeleteCourseTranscriptById (string id, string ifMatch = null)

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
    public class DeleteCourseTranscriptByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCourseTranscriptById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.DeleteCourseTranscriptById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCourseTranscriptByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteCourseTranscriptByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.DeleteCourseTranscriptByIdWithHttpInfo: " + e.Message);
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

<a id="deletescoursetranscripts"></a>
# **DeletesCourseTranscripts**
> List&lt;TrackedChangesEdFiCourseTranscriptDelete&gt; DeletesCourseTranscripts (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesCourseTranscriptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiCourseTranscriptDelete> result = apiInstance.DeletesCourseTranscripts(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.DeletesCourseTranscripts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesCourseTranscriptsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiCourseTranscriptDelete>> response = apiInstance.DeletesCourseTranscriptsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.DeletesCourseTranscriptsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiCourseTranscriptDelete&gt;**](TrackedChangesEdFiCourseTranscriptDelete.md)

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

<a id="getcoursetranscripts"></a>
# **GetCourseTranscripts**
> List&lt;EdFiCourseTranscript&gt; GetCourseTranscripts (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string courseAttemptResultDescriptor = null, string courseCode = null, long courseEducationOrganizationId = null, long educationOrganizationId = null, int schoolYear = null, string studentUniqueId = null, string termDescriptor = null, long externalEducationOrganizationId = null, string responsibleTeacherStaffUniqueId = null, string courseRepeatCodeDescriptor = null, string attemptedCreditTypeDescriptor = null, string earnedCreditTypeDescriptor = null, string whenTakenGradeLevelDescriptor = null, string methodCreditEarnedDescriptor = null, string alternativeCourseTitle = null, string assigningOrganizationIdentificationCode = null, double attemptedCreditConversion = null, double attemptedCredits = null, string courseCatalogURL = null, string courseTitle = null, double earnedCreditConversion = null, double earnedCredits = null, string externalEducationOrganizationNameOfInstitution = null, string finalLetterGradeEarned = null, double finalNumericGradeEarned = null, string id = null, bool useSnapshot = null, string courseIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode2 = null, string courseCatalogURL2 = null, string identificationCode = null)

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
    public class GetCourseTranscriptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var courseAttemptResultDescriptor = "courseAttemptResultDescriptor_example";  // string | The result from the student's attempt to take the course. (optional) 
            var courseCode = "courseCode_example";  // string | A unique alphanumeric code assigned to a course. (optional) 
            var courseEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int | The identifier for the school year. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var termDescriptor = "termDescriptor_example";  // string | The term for the session during the school year. (optional) 
            var externalEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var responsibleTeacherStaffUniqueId = "responsibleTeacherStaffUniqueId_example";  // string | A unique alphanumeric code assigned to a responsibleteacherstaff. (optional) 
            var courseRepeatCodeDescriptor = "courseRepeatCodeDescriptor_example";  // string | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average. (optional) 
            var attemptedCreditTypeDescriptor = "attemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var earnedCreditTypeDescriptor = "earnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var whenTakenGradeLevelDescriptor = "whenTakenGradeLevelDescriptor_example";  // string | Student's grade level at time of course. (optional) 
            var methodCreditEarnedDescriptor = "methodCreditEarnedDescriptor_example";  // string | The method the credits were earned. (optional) 
            var alternativeCourseTitle = "alternativeCourseTitle_example";  // string | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the course identification code. (optional) 
            var attemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var attemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var courseCatalogURL = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var courseTitle = "courseTitle_example";  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). (optional) 
            var earnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var earnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var externalEducationOrganizationNameOfInstitution = "externalEducationOrganizationNameOfInstitution_example";  // string | Name of the external institution where the student completed the course; to be used only when the reference external education organization is not available. (optional) 
            var finalLetterGradeEarned = "finalLetterGradeEarned_example";  // string | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var finalNumericGradeEarned = 1.2D;  // double | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var id = "id_example";  // string |  (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var courseIdentificationSystemDescriptor = "courseIdentificationSystemDescriptor_example";  // string | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. (optional) 
            var assigningOrganizationIdentificationCode2 = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the Identification Code. (optional) 
            var courseCatalogURL2 = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \"/\". For example, consider the following SCED code-    subject = 20 Math    course = 272 Geometry    level = G General    credits = 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiCourseTranscript> result = apiInstance.GetCourseTranscripts(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, courseAttemptResultDescriptor, courseCode, courseEducationOrganizationId, educationOrganizationId, schoolYear, studentUniqueId, termDescriptor, externalEducationOrganizationId, responsibleTeacherStaffUniqueId, courseRepeatCodeDescriptor, attemptedCreditTypeDescriptor, earnedCreditTypeDescriptor, whenTakenGradeLevelDescriptor, methodCreditEarnedDescriptor, alternativeCourseTitle, assigningOrganizationIdentificationCode, attemptedCreditConversion, attemptedCredits, courseCatalogURL, courseTitle, earnedCreditConversion, earnedCredits, externalEducationOrganizationNameOfInstitution, finalLetterGradeEarned, finalNumericGradeEarned, id, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode2, courseCatalogURL2, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscripts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCourseTranscriptsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiCourseTranscript>> response = apiInstance.GetCourseTranscriptsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, courseAttemptResultDescriptor, courseCode, courseEducationOrganizationId, educationOrganizationId, schoolYear, studentUniqueId, termDescriptor, externalEducationOrganizationId, responsibleTeacherStaffUniqueId, courseRepeatCodeDescriptor, attemptedCreditTypeDescriptor, earnedCreditTypeDescriptor, whenTakenGradeLevelDescriptor, methodCreditEarnedDescriptor, alternativeCourseTitle, assigningOrganizationIdentificationCode, attemptedCreditConversion, attemptedCredits, courseCatalogURL, courseTitle, earnedCreditConversion, earnedCredits, externalEducationOrganizationNameOfInstitution, finalLetterGradeEarned, finalNumericGradeEarned, id, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode2, courseCatalogURL2, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsWithHttpInfo: " + e.Message);
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
| **courseAttemptResultDescriptor** | **string** | The result from the student&#39;s attempt to take the course. | [optional]  |
| **courseCode** | **string** | A unique alphanumeric code assigned to a course. | [optional]  |
| **courseEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **schoolYear** | **int** | The identifier for the school year. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **termDescriptor** | **string** | The term for the session during the school year. | [optional]  |
| **externalEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **responsibleTeacherStaffUniqueId** | **string** | A unique alphanumeric code assigned to a responsibleteacherstaff. | [optional]  |
| **courseRepeatCodeDescriptor** | **string** | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average. | [optional]  |
| **attemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **earnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **whenTakenGradeLevelDescriptor** | **string** | Student&#39;s grade level at time of course. | [optional]  |
| **methodCreditEarnedDescriptor** | **string** | The method the credits were earned. | [optional]  |
| **alternativeCourseTitle** | **string** | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the course identification code. | [optional]  |
| **attemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **attemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **courseCatalogURL** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
| **courseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). | [optional]  |
| **earnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **earnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **externalEducationOrganizationNameOfInstitution** | **string** | Name of the external institution where the student completed the course; to be used only when the reference external education organization is not available. | [optional]  |
| **finalLetterGradeEarned** | **string** | The final indicator of student performance in a class as submitted by the instructor. | [optional]  |
| **finalNumericGradeEarned** | **double** | The final indicator of student performance in a class as submitted by the instructor. | [optional]  |
| **id** | **string** |  | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **courseIdentificationSystemDescriptor** | **string** | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. | [optional]  |
| **assigningOrganizationIdentificationCode2** | **string** | The organization code or name assigning the Identification Code. | [optional]  |
| **courseCatalogURL2** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. | [optional]  |

### Return type

[**List&lt;EdFiCourseTranscript&gt;**](EdFiCourseTranscript.md)

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

<a id="getcoursetranscriptsbyid"></a>
# **GetCourseTranscriptsById**
> EdFiCourseTranscript GetCourseTranscriptsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetCourseTranscriptsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCourseTranscript result = apiInstance.GetCourseTranscriptsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCourseTranscriptsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiCourseTranscript> response = apiInstance.GetCourseTranscriptsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsByIdWithHttpInfo: " + e.Message);
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

[**EdFiCourseTranscript**](EdFiCourseTranscript.md)

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

<a id="getcoursetranscriptspartitions"></a>
# **GetCourseTranscriptsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetCourseTranscriptsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string courseAttemptResultDescriptor = null, string courseCode = null, long courseEducationOrganizationId = null, long educationOrganizationId = null, int schoolYear = null, string studentUniqueId = null, string termDescriptor = null, long externalEducationOrganizationId = null, string responsibleTeacherStaffUniqueId = null, string courseRepeatCodeDescriptor = null, string attemptedCreditTypeDescriptor = null, string earnedCreditTypeDescriptor = null, string whenTakenGradeLevelDescriptor = null, string methodCreditEarnedDescriptor = null, string alternativeCourseTitle = null, string assigningOrganizationIdentificationCode = null, double attemptedCreditConversion = null, double attemptedCredits = null, string courseCatalogURL = null, string courseTitle = null, double earnedCreditConversion = null, double earnedCredits = null, string externalEducationOrganizationNameOfInstitution = null, string finalLetterGradeEarned = null, double finalNumericGradeEarned = null, string id = null, bool useSnapshot = null, string courseIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode2 = null, string courseCatalogURL2 = null, string identificationCode = null)

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
    public class GetCourseTranscriptsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var courseAttemptResultDescriptor = "courseAttemptResultDescriptor_example";  // string | The result from the student's attempt to take the course. (optional) 
            var courseCode = "courseCode_example";  // string | A unique alphanumeric code assigned to a course. (optional) 
            var courseEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int | The identifier for the school year. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var termDescriptor = "termDescriptor_example";  // string | The term for the session during the school year. (optional) 
            var externalEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var responsibleTeacherStaffUniqueId = "responsibleTeacherStaffUniqueId_example";  // string | A unique alphanumeric code assigned to a responsibleteacherstaff. (optional) 
            var courseRepeatCodeDescriptor = "courseRepeatCodeDescriptor_example";  // string | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average. (optional) 
            var attemptedCreditTypeDescriptor = "attemptedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var earnedCreditTypeDescriptor = "earnedCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var whenTakenGradeLevelDescriptor = "whenTakenGradeLevelDescriptor_example";  // string | Student's grade level at time of course. (optional) 
            var methodCreditEarnedDescriptor = "methodCreditEarnedDescriptor_example";  // string | The method the credits were earned. (optional) 
            var alternativeCourseTitle = "alternativeCourseTitle_example";  // string | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the course identification code. (optional) 
            var attemptedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var attemptedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var courseCatalogURL = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var courseTitle = "courseTitle_example";  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). (optional) 
            var earnedCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var earnedCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var externalEducationOrganizationNameOfInstitution = "externalEducationOrganizationNameOfInstitution_example";  // string | Name of the external institution where the student completed the course; to be used only when the reference external education organization is not available. (optional) 
            var finalLetterGradeEarned = "finalLetterGradeEarned_example";  // string | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var finalNumericGradeEarned = 1.2D;  // double | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var id = "id_example";  // string |  (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var courseIdentificationSystemDescriptor = "courseIdentificationSystemDescriptor_example";  // string | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. (optional) 
            var assigningOrganizationIdentificationCode2 = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the Identification Code. (optional) 
            var courseCatalogURL2 = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \"/\". For example, consider the following SCED code-    subject = 20 Math    course = 272 Geometry    level = G General    credits = 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. (optional) 

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetCourseTranscriptsPartitions(number, minChangeVersion, maxChangeVersion, courseAttemptResultDescriptor, courseCode, courseEducationOrganizationId, educationOrganizationId, schoolYear, studentUniqueId, termDescriptor, externalEducationOrganizationId, responsibleTeacherStaffUniqueId, courseRepeatCodeDescriptor, attemptedCreditTypeDescriptor, earnedCreditTypeDescriptor, whenTakenGradeLevelDescriptor, methodCreditEarnedDescriptor, alternativeCourseTitle, assigningOrganizationIdentificationCode, attemptedCreditConversion, attemptedCredits, courseCatalogURL, courseTitle, earnedCreditConversion, earnedCredits, externalEducationOrganizationNameOfInstitution, finalLetterGradeEarned, finalNumericGradeEarned, id, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode2, courseCatalogURL2, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCourseTranscriptsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetCourseTranscriptsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, courseAttemptResultDescriptor, courseCode, courseEducationOrganizationId, educationOrganizationId, schoolYear, studentUniqueId, termDescriptor, externalEducationOrganizationId, responsibleTeacherStaffUniqueId, courseRepeatCodeDescriptor, attemptedCreditTypeDescriptor, earnedCreditTypeDescriptor, whenTakenGradeLevelDescriptor, methodCreditEarnedDescriptor, alternativeCourseTitle, assigningOrganizationIdentificationCode, attemptedCreditConversion, attemptedCredits, courseCatalogURL, courseTitle, earnedCreditConversion, earnedCredits, externalEducationOrganizationNameOfInstitution, finalLetterGradeEarned, finalNumericGradeEarned, id, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode2, courseCatalogURL2, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsPartitionsWithHttpInfo: " + e.Message);
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
| **courseAttemptResultDescriptor** | **string** | The result from the student&#39;s attempt to take the course. | [optional]  |
| **courseCode** | **string** | A unique alphanumeric code assigned to a course. | [optional]  |
| **courseEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **schoolYear** | **int** | The identifier for the school year. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **termDescriptor** | **string** | The term for the session during the school year. | [optional]  |
| **externalEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **responsibleTeacherStaffUniqueId** | **string** | A unique alphanumeric code assigned to a responsibleteacherstaff. | [optional]  |
| **courseRepeatCodeDescriptor** | **string** | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average. | [optional]  |
| **attemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **earnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **whenTakenGradeLevelDescriptor** | **string** | Student&#39;s grade level at time of course. | [optional]  |
| **methodCreditEarnedDescriptor** | **string** | The method the credits were earned. | [optional]  |
| **alternativeCourseTitle** | **string** | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the course identification code. | [optional]  |
| **attemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **attemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **courseCatalogURL** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
| **courseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). | [optional]  |
| **earnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **earnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **externalEducationOrganizationNameOfInstitution** | **string** | Name of the external institution where the student completed the course; to be used only when the reference external education organization is not available. | [optional]  |
| **finalLetterGradeEarned** | **string** | The final indicator of student performance in a class as submitted by the instructor. | [optional]  |
| **finalNumericGradeEarned** | **double** | The final indicator of student performance in a class as submitted by the instructor. | [optional]  |
| **id** | **string** |  | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **courseIdentificationSystemDescriptor** | **string** | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. | [optional]  |
| **assigningOrganizationIdentificationCode2** | **string** | The organization code or name assigning the Identification Code. | [optional]  |
| **courseCatalogURL2** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. | [optional]  |

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

<a id="keychangescoursetranscripts"></a>
# **KeyChangesCourseTranscripts**
> List&lt;TrackedChangesEdFiCourseTranscriptKeyChange&gt; KeyChangesCourseTranscripts (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesCourseTranscriptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiCourseTranscriptKeyChange> result = apiInstance.KeyChangesCourseTranscripts(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.KeyChangesCourseTranscripts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesCourseTranscriptsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiCourseTranscriptKeyChange>> response = apiInstance.KeyChangesCourseTranscriptsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.KeyChangesCourseTranscriptsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiCourseTranscriptKeyChange&gt;**](TrackedChangesEdFiCourseTranscriptKeyChange.md)

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

<a id="postcoursetranscript"></a>
# **PostCourseTranscript**
> void PostCourseTranscript (EdFiCourseTranscript edFiCourseTranscript)

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
    public class PostCourseTranscriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var edFiCourseTranscript = new EdFiCourseTranscript(); // EdFiCourseTranscript | The JSON representation of the \"courseTranscript\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCourseTranscript(edFiCourseTranscript);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.PostCourseTranscript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCourseTranscriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostCourseTranscriptWithHttpInfo(edFiCourseTranscript);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.PostCourseTranscriptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiCourseTranscript** | [**EdFiCourseTranscript**](EdFiCourseTranscript.md) | The JSON representation of the \&quot;courseTranscript\&quot; resource to be created or updated. |  |

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

<a id="putcoursetranscript"></a>
# **PutCourseTranscript**
> void PutCourseTranscript (string id, EdFiCourseTranscript edFiCourseTranscript, string ifMatch = null)

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
    public class PutCourseTranscriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiCourseTranscript = new EdFiCourseTranscript(); // EdFiCourseTranscript | The JSON representation of the \"courseTranscript\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutCourseTranscript(id, edFiCourseTranscript, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.PutCourseTranscript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCourseTranscriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutCourseTranscriptWithHttpInfo(id, edFiCourseTranscript, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CourseTranscriptsApi.PutCourseTranscriptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiCourseTranscript** | [**EdFiCourseTranscript**](EdFiCourseTranscript.md) | The JSON representation of the \&quot;courseTranscript\&quot; resource to be created or updated. |  |
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

