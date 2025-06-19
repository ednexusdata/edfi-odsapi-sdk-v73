# EdFi.OdsApi.Sdk.v73.Apis.All.StudentSchoolAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentSchoolAssociationById**](StudentSchoolAssociationsApi.md#deletestudentschoolassociationbyid) | **DELETE** /ed-fi/studentSchoolAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentSchoolAssociations**](StudentSchoolAssociationsApi.md#deletesstudentschoolassociations) | **GET** /ed-fi/studentSchoolAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentSchoolAssociations**](StudentSchoolAssociationsApi.md#getstudentschoolassociations) | **GET** /ed-fi/studentSchoolAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentSchoolAssociationsById**](StudentSchoolAssociationsApi.md#getstudentschoolassociationsbyid) | **GET** /ed-fi/studentSchoolAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentSchoolAssociationsPartitions**](StudentSchoolAssociationsApi.md#getstudentschoolassociationspartitions) | **GET** /ed-fi/studentSchoolAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentSchoolAssociations**](StudentSchoolAssociationsApi.md#keychangesstudentschoolassociations) | **GET** /ed-fi/studentSchoolAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentSchoolAssociation**](StudentSchoolAssociationsApi.md#poststudentschoolassociation) | **POST** /ed-fi/studentSchoolAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentSchoolAssociation**](StudentSchoolAssociationsApi.md#putstudentschoolassociation) | **PUT** /ed-fi/studentSchoolAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentschoolassociationbyid"></a>
# **DeleteStudentSchoolAssociationById**
> void DeleteStudentSchoolAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentSchoolAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSchoolAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.DeleteStudentSchoolAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentSchoolAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentSchoolAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.DeleteStudentSchoolAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentschoolassociations"></a>
# **DeletesStudentSchoolAssociations**
> List&lt;TrackedChangesEdFiStudentSchoolAssociationDelete&gt; DeletesStudentSchoolAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentSchoolAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentSchoolAssociationDelete> result = apiInstance.DeletesStudentSchoolAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.DeletesStudentSchoolAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentSchoolAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSchoolAssociationDelete>> response = apiInstance.DeletesStudentSchoolAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.DeletesStudentSchoolAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSchoolAssociationDelete&gt;**](TrackedChangesEdFiStudentSchoolAssociationDelete.md)

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

<a id="getstudentschoolassociations"></a>
# **GetStudentSchoolAssociations**
> List&lt;EdFiStudentSchoolAssociation&gt; GetStudentSchoolAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, DateOnly entryDate = null, long schoolId = null, string studentUniqueId = null, string calendarCode = null, int schoolYear = null, long educationOrganizationId = null, string graduationPlanTypeDescriptor = null, int graduationSchoolYear = null, long nextYearSchoolId = null, int classOfSchoolYear = null, string enrollmentTypeDescriptor = null, string entryGradeLevelReasonDescriptor = null, string entryTypeDescriptor = null, string exitWithdrawTypeDescriptor = null, string entryGradeLevelDescriptor = null, string nextYearGradeLevelDescriptor = null, string residencyStatusDescriptor = null, string schoolChoiceBasisDescriptor = null, bool employedWhileEnrolled = null, DateOnly exitWithdrawDate = null, double fullTimeEquivalency = null, string id = null, bool primarySchool = null, bool repeatGradeIndicator = null, bool schoolChoice = null, bool schoolChoiceTransfer = null, bool termCompletionIndicator = null, bool useSnapshot = null)

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
    public class GetStudentSchoolAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var entryDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual enters and begins to receive instructional services in a school for each school year. The EntryDate value should be the date the student enrolled, or when the student's enrollment materially changed, such as with a grade promotion.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var schoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var calendarCode = "calendarCode_example";  // string | The identifier for the calendar. (optional) 
            var schoolYear = 56;  // int | The school year associated with the student's enrollment. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var graduationPlanTypeDescriptor = "graduationPlanTypeDescriptor_example";  // string | The type of academic plan the student is following for graduation. (optional) 
            var graduationSchoolYear = 56;  // int | The school year the student is expected to graduate. (optional) 
            var nextYearSchoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var classOfSchoolYear = 56;  // int | Projected high school graduation year. (optional) 
            var enrollmentTypeDescriptor = "enrollmentTypeDescriptor_example";  // string | The type of enrollment reflected by the StudentSchoolAssociation. (optional) 
            var entryGradeLevelReasonDescriptor = "entryGradeLevelReasonDescriptor_example";  // string | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. (optional) 
            var entryTypeDescriptor = "entryTypeDescriptor_example";  // string | The process by which a student enters a school during a given academic session. (optional) 
            var exitWithdrawTypeDescriptor = "exitWithdrawTypeDescriptor_example";  // string | The circumstances under which the student exited from membership in an educational institution. (optional) 
            var entryGradeLevelDescriptor = "entryGradeLevelDescriptor_example";  // string | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. (optional) 
            var nextYearGradeLevelDescriptor = "nextYearGradeLevelDescriptor_example";  // string | The anticipated grade level for the student for the next school year. (optional) 
            var residencyStatusDescriptor = "residencyStatusDescriptor_example";  // string | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. (optional) 
            var schoolChoiceBasisDescriptor = "schoolChoiceBasisDescriptor_example";  // string | The legal basis for the school choice enrollment according to local, state or federal policy or regulation. (The descriptor provides the list of available bases specific to the state (optional) 
            var employedWhileEnrolled = true;  // bool | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. (optional) 
            var exitWithdrawDate = DateOnly.Parse("2013-10-20");  // DateOnly | The recorded exit or withdraw date for the student.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var fullTimeEquivalency = 1.2D;  // double | The full-time equivalent ratio for the student s assignment to a school for services or instruction. For example, a full-time student would have an FTE value of 1 while a half-time student would have an FTE value of 0.5. (optional) 
            var id = "id_example";  // string |  (optional) 
            var primarySchool = true;  // bool | Indicates if a given enrollment record should be considered the primary record for a student. (optional) 
            var repeatGradeIndicator = true;  // bool | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. (optional) 
            var schoolChoice = true;  // bool | An indication of whether the student enrolled in this school under the provisions for public school choice (optional) 
            var schoolChoiceTransfer = true;  // bool | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. (optional) 
            var termCompletionIndicator = true;  // bool | Idicates whether or not a student completed the most recent school term. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentSchoolAssociation> result = apiInstance.GetStudentSchoolAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, entryDate, schoolId, studentUniqueId, calendarCode, schoolYear, educationOrganizationId, graduationPlanTypeDescriptor, graduationSchoolYear, nextYearSchoolId, classOfSchoolYear, enrollmentTypeDescriptor, entryGradeLevelReasonDescriptor, entryTypeDescriptor, exitWithdrawTypeDescriptor, entryGradeLevelDescriptor, nextYearGradeLevelDescriptor, residencyStatusDescriptor, schoolChoiceBasisDescriptor, employedWhileEnrolled, exitWithdrawDate, fullTimeEquivalency, id, primarySchool, repeatGradeIndicator, schoolChoice, schoolChoiceTransfer, termCompletionIndicator, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSchoolAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentSchoolAssociation>> response = apiInstance.GetStudentSchoolAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, entryDate, schoolId, studentUniqueId, calendarCode, schoolYear, educationOrganizationId, graduationPlanTypeDescriptor, graduationSchoolYear, nextYearSchoolId, classOfSchoolYear, enrollmentTypeDescriptor, entryGradeLevelReasonDescriptor, entryTypeDescriptor, exitWithdrawTypeDescriptor, entryGradeLevelDescriptor, nextYearGradeLevelDescriptor, residencyStatusDescriptor, schoolChoiceBasisDescriptor, employedWhileEnrolled, exitWithdrawDate, fullTimeEquivalency, id, primarySchool, repeatGradeIndicator, schoolChoice, schoolChoiceTransfer, termCompletionIndicator, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsWithHttpInfo: " + e.Message);
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
| **entryDate** | **DateOnly** | The month, day, and year on which an individual enters and begins to receive instructional services in a school for each school year. The EntryDate value should be the date the student enrolled, or when the student&#39;s enrollment materially changed, such as with a grade promotion.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **schoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **calendarCode** | **string** | The identifier for the calendar. | [optional]  |
| **schoolYear** | **int** | The school year associated with the student&#39;s enrollment. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **graduationPlanTypeDescriptor** | **string** | The type of academic plan the student is following for graduation. | [optional]  |
| **graduationSchoolYear** | **int** | The school year the student is expected to graduate. | [optional]  |
| **nextYearSchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **classOfSchoolYear** | **int** | Projected high school graduation year. | [optional]  |
| **enrollmentTypeDescriptor** | **string** | The type of enrollment reflected by the StudentSchoolAssociation. | [optional]  |
| **entryGradeLevelReasonDescriptor** | **string** | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. | [optional]  |
| **entryTypeDescriptor** | **string** | The process by which a student enters a school during a given academic session. | [optional]  |
| **exitWithdrawTypeDescriptor** | **string** | The circumstances under which the student exited from membership in an educational institution. | [optional]  |
| **entryGradeLevelDescriptor** | **string** | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. | [optional]  |
| **nextYearGradeLevelDescriptor** | **string** | The anticipated grade level for the student for the next school year. | [optional]  |
| **residencyStatusDescriptor** | **string** | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. | [optional]  |
| **schoolChoiceBasisDescriptor** | **string** | The legal basis for the school choice enrollment according to local, state or federal policy or regulation. (The descriptor provides the list of available bases specific to the state | [optional]  |
| **employedWhileEnrolled** | **bool** | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. | [optional]  |
| **exitWithdrawDate** | **DateOnly** | The recorded exit or withdraw date for the student.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **fullTimeEquivalency** | **double** | The full-time equivalent ratio for the student s assignment to a school for services or instruction. For example, a full-time student would have an FTE value of 1 while a half-time student would have an FTE value of 0.5. | [optional]  |
| **id** | **string** |  | [optional]  |
| **primarySchool** | **bool** | Indicates if a given enrollment record should be considered the primary record for a student. | [optional]  |
| **repeatGradeIndicator** | **bool** | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. | [optional]  |
| **schoolChoice** | **bool** | An indication of whether the student enrolled in this school under the provisions for public school choice | [optional]  |
| **schoolChoiceTransfer** | **bool** | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. | [optional]  |
| **termCompletionIndicator** | **bool** | Idicates whether or not a student completed the most recent school term. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentSchoolAssociation&gt;**](EdFiStudentSchoolAssociation.md)

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

<a id="getstudentschoolassociationsbyid"></a>
# **GetStudentSchoolAssociationsById**
> EdFiStudentSchoolAssociation GetStudentSchoolAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentSchoolAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSchoolAssociation result = apiInstance.GetStudentSchoolAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSchoolAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentSchoolAssociation> response = apiInstance.GetStudentSchoolAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentSchoolAssociation**](EdFiStudentSchoolAssociation.md)

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

<a id="getstudentschoolassociationspartitions"></a>
# **GetStudentSchoolAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentSchoolAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, DateOnly entryDate = null, long schoolId = null, string studentUniqueId = null, string calendarCode = null, int schoolYear = null, long educationOrganizationId = null, string graduationPlanTypeDescriptor = null, int graduationSchoolYear = null, long nextYearSchoolId = null, int classOfSchoolYear = null, string enrollmentTypeDescriptor = null, string entryGradeLevelReasonDescriptor = null, string entryTypeDescriptor = null, string exitWithdrawTypeDescriptor = null, string entryGradeLevelDescriptor = null, string nextYearGradeLevelDescriptor = null, string residencyStatusDescriptor = null, string schoolChoiceBasisDescriptor = null, bool employedWhileEnrolled = null, DateOnly exitWithdrawDate = null, double fullTimeEquivalency = null, string id = null, bool primarySchool = null, bool repeatGradeIndicator = null, bool schoolChoice = null, bool schoolChoiceTransfer = null, bool termCompletionIndicator = null, bool useSnapshot = null)

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
    public class GetStudentSchoolAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var entryDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual enters and begins to receive instructional services in a school for each school year. The EntryDate value should be the date the student enrolled, or when the student's enrollment materially changed, such as with a grade promotion.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var schoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var calendarCode = "calendarCode_example";  // string | The identifier for the calendar. (optional) 
            var schoolYear = 56;  // int | The school year associated with the student's enrollment. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var graduationPlanTypeDescriptor = "graduationPlanTypeDescriptor_example";  // string | The type of academic plan the student is following for graduation. (optional) 
            var graduationSchoolYear = 56;  // int | The school year the student is expected to graduate. (optional) 
            var nextYearSchoolId = 789L;  // long | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (optional) 
            var classOfSchoolYear = 56;  // int | Projected high school graduation year. (optional) 
            var enrollmentTypeDescriptor = "enrollmentTypeDescriptor_example";  // string | The type of enrollment reflected by the StudentSchoolAssociation. (optional) 
            var entryGradeLevelReasonDescriptor = "entryGradeLevelReasonDescriptor_example";  // string | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. (optional) 
            var entryTypeDescriptor = "entryTypeDescriptor_example";  // string | The process by which a student enters a school during a given academic session. (optional) 
            var exitWithdrawTypeDescriptor = "exitWithdrawTypeDescriptor_example";  // string | The circumstances under which the student exited from membership in an educational institution. (optional) 
            var entryGradeLevelDescriptor = "entryGradeLevelDescriptor_example";  // string | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. (optional) 
            var nextYearGradeLevelDescriptor = "nextYearGradeLevelDescriptor_example";  // string | The anticipated grade level for the student for the next school year. (optional) 
            var residencyStatusDescriptor = "residencyStatusDescriptor_example";  // string | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. (optional) 
            var schoolChoiceBasisDescriptor = "schoolChoiceBasisDescriptor_example";  // string | The legal basis for the school choice enrollment according to local, state or federal policy or regulation. (The descriptor provides the list of available bases specific to the state (optional) 
            var employedWhileEnrolled = true;  // bool | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. (optional) 
            var exitWithdrawDate = DateOnly.Parse("2013-10-20");  // DateOnly | The recorded exit or withdraw date for the student.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var fullTimeEquivalency = 1.2D;  // double | The full-time equivalent ratio for the student s assignment to a school for services or instruction. For example, a full-time student would have an FTE value of 1 while a half-time student would have an FTE value of 0.5. (optional) 
            var id = "id_example";  // string |  (optional) 
            var primarySchool = true;  // bool | Indicates if a given enrollment record should be considered the primary record for a student. (optional) 
            var repeatGradeIndicator = true;  // bool | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. (optional) 
            var schoolChoice = true;  // bool | An indication of whether the student enrolled in this school under the provisions for public school choice (optional) 
            var schoolChoiceTransfer = true;  // bool | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. (optional) 
            var termCompletionIndicator = true;  // bool | Idicates whether or not a student completed the most recent school term. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentSchoolAssociationsPartitions(number, minChangeVersion, maxChangeVersion, entryDate, schoolId, studentUniqueId, calendarCode, schoolYear, educationOrganizationId, graduationPlanTypeDescriptor, graduationSchoolYear, nextYearSchoolId, classOfSchoolYear, enrollmentTypeDescriptor, entryGradeLevelReasonDescriptor, entryTypeDescriptor, exitWithdrawTypeDescriptor, entryGradeLevelDescriptor, nextYearGradeLevelDescriptor, residencyStatusDescriptor, schoolChoiceBasisDescriptor, employedWhileEnrolled, exitWithdrawDate, fullTimeEquivalency, id, primarySchool, repeatGradeIndicator, schoolChoice, schoolChoiceTransfer, termCompletionIndicator, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSchoolAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentSchoolAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, entryDate, schoolId, studentUniqueId, calendarCode, schoolYear, educationOrganizationId, graduationPlanTypeDescriptor, graduationSchoolYear, nextYearSchoolId, classOfSchoolYear, enrollmentTypeDescriptor, entryGradeLevelReasonDescriptor, entryTypeDescriptor, exitWithdrawTypeDescriptor, entryGradeLevelDescriptor, nextYearGradeLevelDescriptor, residencyStatusDescriptor, schoolChoiceBasisDescriptor, employedWhileEnrolled, exitWithdrawDate, fullTimeEquivalency, id, primarySchool, repeatGradeIndicator, schoolChoice, schoolChoiceTransfer, termCompletionIndicator, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **entryDate** | **DateOnly** | The month, day, and year on which an individual enters and begins to receive instructional services in a school for each school year. The EntryDate value should be the date the student enrolled, or when the student&#39;s enrollment materially changed, such as with a grade promotion.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **schoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **calendarCode** | **string** | The identifier for the calendar. | [optional]  |
| **schoolYear** | **int** | The school year associated with the student&#39;s enrollment. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **graduationPlanTypeDescriptor** | **string** | The type of academic plan the student is following for graduation. | [optional]  |
| **graduationSchoolYear** | **int** | The school year the student is expected to graduate. | [optional]  |
| **nextYearSchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional]  |
| **classOfSchoolYear** | **int** | Projected high school graduation year. | [optional]  |
| **enrollmentTypeDescriptor** | **string** | The type of enrollment reflected by the StudentSchoolAssociation. | [optional]  |
| **entryGradeLevelReasonDescriptor** | **string** | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. | [optional]  |
| **entryTypeDescriptor** | **string** | The process by which a student enters a school during a given academic session. | [optional]  |
| **exitWithdrawTypeDescriptor** | **string** | The circumstances under which the student exited from membership in an educational institution. | [optional]  |
| **entryGradeLevelDescriptor** | **string** | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. | [optional]  |
| **nextYearGradeLevelDescriptor** | **string** | The anticipated grade level for the student for the next school year. | [optional]  |
| **residencyStatusDescriptor** | **string** | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. | [optional]  |
| **schoolChoiceBasisDescriptor** | **string** | The legal basis for the school choice enrollment according to local, state or federal policy or regulation. (The descriptor provides the list of available bases specific to the state | [optional]  |
| **employedWhileEnrolled** | **bool** | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. | [optional]  |
| **exitWithdrawDate** | **DateOnly** | The recorded exit or withdraw date for the student.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **fullTimeEquivalency** | **double** | The full-time equivalent ratio for the student s assignment to a school for services or instruction. For example, a full-time student would have an FTE value of 1 while a half-time student would have an FTE value of 0.5. | [optional]  |
| **id** | **string** |  | [optional]  |
| **primarySchool** | **bool** | Indicates if a given enrollment record should be considered the primary record for a student. | [optional]  |
| **repeatGradeIndicator** | **bool** | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. | [optional]  |
| **schoolChoice** | **bool** | An indication of whether the student enrolled in this school under the provisions for public school choice | [optional]  |
| **schoolChoiceTransfer** | **bool** | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. | [optional]  |
| **termCompletionIndicator** | **bool** | Idicates whether or not a student completed the most recent school term. | [optional]  |
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

<a id="keychangesstudentschoolassociations"></a>
# **KeyChangesStudentSchoolAssociations**
> List&lt;TrackedChangesEdFiStudentSchoolAssociationKeyChange&gt; KeyChangesStudentSchoolAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentSchoolAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentSchoolAssociationKeyChange> result = apiInstance.KeyChangesStudentSchoolAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.KeyChangesStudentSchoolAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentSchoolAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSchoolAssociationKeyChange>> response = apiInstance.KeyChangesStudentSchoolAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.KeyChangesStudentSchoolAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSchoolAssociationKeyChange&gt;**](TrackedChangesEdFiStudentSchoolAssociationKeyChange.md)

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

<a id="poststudentschoolassociation"></a>
# **PostStudentSchoolAssociation**
> void PostStudentSchoolAssociation (EdFiStudentSchoolAssociation edFiStudentSchoolAssociation)

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
    public class PostStudentSchoolAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var edFiStudentSchoolAssociation = new EdFiStudentSchoolAssociation(); // EdFiStudentSchoolAssociation | The JSON representation of the \"studentSchoolAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSchoolAssociation(edFiStudentSchoolAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.PostStudentSchoolAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentSchoolAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentSchoolAssociationWithHttpInfo(edFiStudentSchoolAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.PostStudentSchoolAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentSchoolAssociation** | [**EdFiStudentSchoolAssociation**](EdFiStudentSchoolAssociation.md) | The JSON representation of the \&quot;studentSchoolAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstudentschoolassociation"></a>
# **PutStudentSchoolAssociation**
> void PutStudentSchoolAssociation (string id, EdFiStudentSchoolAssociation edFiStudentSchoolAssociation, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, if natural key values are being updated by the JSON body, those changes will be applied to the resource and will also cascade through to dependent resources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v73.Apis.All;
using EdFi.OdsApi.Sdk.v73.Client;
using EdFi.OdsApi.Sdk.v73.Models.All;

namespace Example
{
    public class PutStudentSchoolAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentSchoolAssociation = new EdFiStudentSchoolAssociation(); // EdFiStudentSchoolAssociation | The JSON representation of the \"studentSchoolAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentSchoolAssociation(id, edFiStudentSchoolAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.PutStudentSchoolAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentSchoolAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentSchoolAssociationWithHttpInfo(id, edFiStudentSchoolAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSchoolAssociationsApi.PutStudentSchoolAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentSchoolAssociation** | [**EdFiStudentSchoolAssociation**](EdFiStudentSchoolAssociation.md) | The JSON representation of the \&quot;studentSchoolAssociation\&quot; resource to be created or updated. |  |
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

