# EdFi.OdsApi.Sdk.v73.Apis.All.StudentSpecialEducationProgramAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentSpecialEducationProgramAssociationById**](StudentSpecialEducationProgramAssociationsApi.md#deletestudentspecialeducationprogramassociationbyid) | **DELETE** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentSpecialEducationProgramAssociations**](StudentSpecialEducationProgramAssociationsApi.md#deletesstudentspecialeducationprogramassociations) | **GET** /ed-fi/studentSpecialEducationProgramAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentSpecialEducationProgramAssociations**](StudentSpecialEducationProgramAssociationsApi.md#getstudentspecialeducationprogramassociations) | **GET** /ed-fi/studentSpecialEducationProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentSpecialEducationProgramAssociationsById**](StudentSpecialEducationProgramAssociationsApi.md#getstudentspecialeducationprogramassociationsbyid) | **GET** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentSpecialEducationProgramAssociationsPartitions**](StudentSpecialEducationProgramAssociationsApi.md#getstudentspecialeducationprogramassociationspartitions) | **GET** /ed-fi/studentSpecialEducationProgramAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentSpecialEducationProgramAssociations**](StudentSpecialEducationProgramAssociationsApi.md#keychangesstudentspecialeducationprogramassociations) | **GET** /ed-fi/studentSpecialEducationProgramAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentSpecialEducationProgramAssociation**](StudentSpecialEducationProgramAssociationsApi.md#poststudentspecialeducationprogramassociation) | **POST** /ed-fi/studentSpecialEducationProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentSpecialEducationProgramAssociation**](StudentSpecialEducationProgramAssociationsApi.md#putstudentspecialeducationprogramassociation) | **PUT** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentspecialeducationprogramassociationbyid"></a>
# **DeleteStudentSpecialEducationProgramAssociationById**
> void DeleteStudentSpecialEducationProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentSpecialEducationProgramAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSpecialEducationProgramAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.DeleteStudentSpecialEducationProgramAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentSpecialEducationProgramAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentSpecialEducationProgramAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.DeleteStudentSpecialEducationProgramAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentspecialeducationprogramassociations"></a>
# **DeletesStudentSpecialEducationProgramAssociations**
> List&lt;TrackedChangesEdFiStudentSpecialEducationProgramAssociationDelete&gt; DeletesStudentSpecialEducationProgramAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentSpecialEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentSpecialEducationProgramAssociationDelete> result = apiInstance.DeletesStudentSpecialEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.DeletesStudentSpecialEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentSpecialEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSpecialEducationProgramAssociationDelete>> response = apiInstance.DeletesStudentSpecialEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.DeletesStudentSpecialEducationProgramAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSpecialEducationProgramAssociationDelete&gt;**](TrackedChangesEdFiStudentSpecialEducationProgramAssociationDelete.md)

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

<a id="getstudentspecialeducationprogramassociations"></a>
# **GetStudentSpecialEducationProgramAssociations**
> List&lt;EdFiStudentSpecialEducationProgramAssociation&gt; GetStudentSpecialEducationProgramAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, DateOnly beginDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string specialEducationExitReasonDescriptor = null, string specialEducationSettingDescriptor = null, bool ideaEligibility = null, DateOnly iepBeginDate = null, DateOnly iepEndDate = null, DateOnly iepReviewDate = null, DateOnly lastEvaluationDate = null, bool medicallyFragile = null, bool multiplyDisabled = null, double reductionInHoursPerWeekComparedToPeers = null, double schoolHoursPerWeek = null, bool shortenedSchoolDayIndicator = null, DateOnly specialEducationExitDate = null, string specialEducationExitExplained = null, double specialEducationHoursPerWeek = null, string reasonExitedDescriptor = null, DateOnly endDate = null, string id = null, bool servedOutsideOfRegularSession = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var beginDate = DateOnly.Parse("2013-10-20");  // DateOnly | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var specialEducationExitReasonDescriptor = "specialEducationExitReasonDescriptor_example";  // string | The reason why a person stops receiving special education services. (optional) 
            var specialEducationSettingDescriptor = "specialEducationSettingDescriptor_example";  // string | The major instructional setting (more than 50 percent of a student's special education program). (optional) 
            var ideaEligibility = true;  // bool | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). (optional) 
            var iepBeginDate = DateOnly.Parse("2013-10-20");  // DateOnly | The effective date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var iepEndDate = DateOnly.Parse("2013-10-20");  // DateOnly | The end date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var iepReviewDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date of the last IEP review. (optional) 
            var lastEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date of the last special education evaluation. (optional) 
            var medicallyFragile = true;  // bool | Indicates whether the student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements. (optional) 
            var multiplyDisabled = true;  // bool | Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. (optional) 
            var reductionInHoursPerWeekComparedToPeers = 1.2D;  // double | Records the number of hours reduced for the shortened school day for the IEP student as compared to peers in regular education. (optional) 
            var schoolHoursPerWeek = 1.2D;  // double | Indicate the total number of hours of instructional time per week for the school that the student attends. (optional) 
            var shortenedSchoolDayIndicator = true;  // bool | Indicator that the student's IEP requires a shortened school day. (optional) 
            var specialEducationExitDate = DateOnly.Parse("2013-10-20");  // DateOnly | The  month, day and year on which a person stops receiving special education services. (optional) 
            var specialEducationExitExplained = "specialEducationExitExplained_example";  // string | Explanation on why a person stops receiving special education services. (optional) 
            var specialEducationHoursPerWeek = 1.2D;  // double | The number of hours per week for special education instruction and therapy. (optional) 
            var reasonExitedDescriptor = "reasonExitedDescriptor_example";  // string | The reason the student left the program within a school or district. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var id = "id_example";  // string |  (optional) 
            var servedOutsideOfRegularSession = true;  // bool | Indicates whether the student received services during the summer session or between sessions. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentSpecialEducationProgramAssociation> result = apiInstance.GetStudentSpecialEducationProgramAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, specialEducationExitReasonDescriptor, specialEducationSettingDescriptor, ideaEligibility, iepBeginDate, iepEndDate, iepReviewDate, lastEvaluationDate, medicallyFragile, multiplyDisabled, reductionInHoursPerWeekComparedToPeers, schoolHoursPerWeek, shortenedSchoolDayIndicator, specialEducationExitDate, specialEducationExitExplained, specialEducationHoursPerWeek, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentSpecialEducationProgramAssociation>> response = apiInstance.GetStudentSpecialEducationProgramAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, specialEducationExitReasonDescriptor, specialEducationSettingDescriptor, ideaEligibility, iepBeginDate, iepEndDate, iepReviewDate, lastEvaluationDate, medicallyFragile, multiplyDisabled, reductionInHoursPerWeekComparedToPeers, schoolHoursPerWeek, shortenedSchoolDayIndicator, specialEducationExitDate, specialEducationExitExplained, specialEducationHoursPerWeek, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsWithHttpInfo: " + e.Message);
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
| **beginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programName** | **string** | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional]  |
| **programTypeDescriptor** | **string** | The type of program. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **specialEducationExitReasonDescriptor** | **string** | The reason why a person stops receiving special education services. | [optional]  |
| **specialEducationSettingDescriptor** | **string** | The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional]  |
| **ideaEligibility** | **bool** | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). | [optional]  |
| **iepBeginDate** | **DateOnly** | The effective date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **iepEndDate** | **DateOnly** | The end date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **iepReviewDate** | **DateOnly** | The date of the last IEP review. | [optional]  |
| **lastEvaluationDate** | **DateOnly** | The date of the last special education evaluation. | [optional]  |
| **medicallyFragile** | **bool** | Indicates whether the student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements. | [optional]  |
| **multiplyDisabled** | **bool** | Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. | [optional]  |
| **reductionInHoursPerWeekComparedToPeers** | **double** | Records the number of hours reduced for the shortened school day for the IEP student as compared to peers in regular education. | [optional]  |
| **schoolHoursPerWeek** | **double** | Indicate the total number of hours of instructional time per week for the school that the student attends. | [optional]  |
| **shortenedSchoolDayIndicator** | **bool** | Indicator that the student&#39;s IEP requires a shortened school day. | [optional]  |
| **specialEducationExitDate** | **DateOnly** | The  month, day and year on which a person stops receiving special education services. | [optional]  |
| **specialEducationExitExplained** | **string** | Explanation on why a person stops receiving special education services. | [optional]  |
| **specialEducationHoursPerWeek** | **double** | The number of hours per week for special education instruction and therapy. | [optional]  |
| **reasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional]  |
| **endDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **id** | **string** |  | [optional]  |
| **servedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentSpecialEducationProgramAssociation&gt;**](EdFiStudentSpecialEducationProgramAssociation.md)

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

<a id="getstudentspecialeducationprogramassociationsbyid"></a>
# **GetStudentSpecialEducationProgramAssociationsById**
> EdFiStudentSpecialEducationProgramAssociation GetStudentSpecialEducationProgramAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSpecialEducationProgramAssociation result = apiInstance.GetStudentSpecialEducationProgramAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentSpecialEducationProgramAssociation> response = apiInstance.GetStudentSpecialEducationProgramAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md)

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

<a id="getstudentspecialeducationprogramassociationspartitions"></a>
# **GetStudentSpecialEducationProgramAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentSpecialEducationProgramAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, DateOnly beginDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string specialEducationExitReasonDescriptor = null, string specialEducationSettingDescriptor = null, bool ideaEligibility = null, DateOnly iepBeginDate = null, DateOnly iepEndDate = null, DateOnly iepReviewDate = null, DateOnly lastEvaluationDate = null, bool medicallyFragile = null, bool multiplyDisabled = null, double reductionInHoursPerWeekComparedToPeers = null, double schoolHoursPerWeek = null, bool shortenedSchoolDayIndicator = null, DateOnly specialEducationExitDate = null, string specialEducationExitExplained = null, double specialEducationHoursPerWeek = null, string reasonExitedDescriptor = null, DateOnly endDate = null, string id = null, bool servedOutsideOfRegularSession = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var beginDate = DateOnly.Parse("2013-10-20");  // DateOnly | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var specialEducationExitReasonDescriptor = "specialEducationExitReasonDescriptor_example";  // string | The reason why a person stops receiving special education services. (optional) 
            var specialEducationSettingDescriptor = "specialEducationSettingDescriptor_example";  // string | The major instructional setting (more than 50 percent of a student's special education program). (optional) 
            var ideaEligibility = true;  // bool | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). (optional) 
            var iepBeginDate = DateOnly.Parse("2013-10-20");  // DateOnly | The effective date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var iepEndDate = DateOnly.Parse("2013-10-20");  // DateOnly | The end date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var iepReviewDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date of the last IEP review. (optional) 
            var lastEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date of the last special education evaluation. (optional) 
            var medicallyFragile = true;  // bool | Indicates whether the student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements. (optional) 
            var multiplyDisabled = true;  // bool | Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. (optional) 
            var reductionInHoursPerWeekComparedToPeers = 1.2D;  // double | Records the number of hours reduced for the shortened school day for the IEP student as compared to peers in regular education. (optional) 
            var schoolHoursPerWeek = 1.2D;  // double | Indicate the total number of hours of instructional time per week for the school that the student attends. (optional) 
            var shortenedSchoolDayIndicator = true;  // bool | Indicator that the student's IEP requires a shortened school day. (optional) 
            var specialEducationExitDate = DateOnly.Parse("2013-10-20");  // DateOnly | The  month, day and year on which a person stops receiving special education services. (optional) 
            var specialEducationExitExplained = "specialEducationExitExplained_example";  // string | Explanation on why a person stops receiving special education services. (optional) 
            var specialEducationHoursPerWeek = 1.2D;  // double | The number of hours per week for special education instruction and therapy. (optional) 
            var reasonExitedDescriptor = "reasonExitedDescriptor_example";  // string | The reason the student left the program within a school or district. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var id = "id_example";  // string |  (optional) 
            var servedOutsideOfRegularSession = true;  // bool | Indicates whether the student received services during the summer session or between sessions. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentSpecialEducationProgramAssociationsPartitions(number, minChangeVersion, maxChangeVersion, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, specialEducationExitReasonDescriptor, specialEducationSettingDescriptor, ideaEligibility, iepBeginDate, iepEndDate, iepReviewDate, lastEvaluationDate, medicallyFragile, multiplyDisabled, reductionInHoursPerWeekComparedToPeers, schoolHoursPerWeek, shortenedSchoolDayIndicator, specialEducationExitDate, specialEducationExitExplained, specialEducationHoursPerWeek, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentSpecialEducationProgramAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, specialEducationExitReasonDescriptor, specialEducationSettingDescriptor, ideaEligibility, iepBeginDate, iepEndDate, iepReviewDate, lastEvaluationDate, medicallyFragile, multiplyDisabled, reductionInHoursPerWeekComparedToPeers, schoolHoursPerWeek, shortenedSchoolDayIndicator, specialEducationExitDate, specialEducationExitExplained, specialEducationHoursPerWeek, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **beginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programName** | **string** | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional]  |
| **programTypeDescriptor** | **string** | The type of program. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **specialEducationExitReasonDescriptor** | **string** | The reason why a person stops receiving special education services. | [optional]  |
| **specialEducationSettingDescriptor** | **string** | The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional]  |
| **ideaEligibility** | **bool** | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). | [optional]  |
| **iepBeginDate** | **DateOnly** | The effective date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **iepEndDate** | **DateOnly** | The end date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **iepReviewDate** | **DateOnly** | The date of the last IEP review. | [optional]  |
| **lastEvaluationDate** | **DateOnly** | The date of the last special education evaluation. | [optional]  |
| **medicallyFragile** | **bool** | Indicates whether the student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements. | [optional]  |
| **multiplyDisabled** | **bool** | Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. | [optional]  |
| **reductionInHoursPerWeekComparedToPeers** | **double** | Records the number of hours reduced for the shortened school day for the IEP student as compared to peers in regular education. | [optional]  |
| **schoolHoursPerWeek** | **double** | Indicate the total number of hours of instructional time per week for the school that the student attends. | [optional]  |
| **shortenedSchoolDayIndicator** | **bool** | Indicator that the student&#39;s IEP requires a shortened school day. | [optional]  |
| **specialEducationExitDate** | **DateOnly** | The  month, day and year on which a person stops receiving special education services. | [optional]  |
| **specialEducationExitExplained** | **string** | Explanation on why a person stops receiving special education services. | [optional]  |
| **specialEducationHoursPerWeek** | **double** | The number of hours per week for special education instruction and therapy. | [optional]  |
| **reasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional]  |
| **endDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **id** | **string** |  | [optional]  |
| **servedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional]  |
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

<a id="keychangesstudentspecialeducationprogramassociations"></a>
# **KeyChangesStudentSpecialEducationProgramAssociations**
> List&lt;TrackedChangesEdFiStudentSpecialEducationProgramAssociationKeyChange&gt; KeyChangesStudentSpecialEducationProgramAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentSpecialEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentSpecialEducationProgramAssociationKeyChange> result = apiInstance.KeyChangesStudentSpecialEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.KeyChangesStudentSpecialEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentSpecialEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSpecialEducationProgramAssociationKeyChange>> response = apiInstance.KeyChangesStudentSpecialEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.KeyChangesStudentSpecialEducationProgramAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSpecialEducationProgramAssociationKeyChange&gt;**](TrackedChangesEdFiStudentSpecialEducationProgramAssociationKeyChange.md)

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

<a id="poststudentspecialeducationprogramassociation"></a>
# **PostStudentSpecialEducationProgramAssociation**
> void PostStudentSpecialEducationProgramAssociation (EdFiStudentSpecialEducationProgramAssociation edFiStudentSpecialEducationProgramAssociation)

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
    public class PostStudentSpecialEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var edFiStudentSpecialEducationProgramAssociation = new EdFiStudentSpecialEducationProgramAssociation(); // EdFiStudentSpecialEducationProgramAssociation | The JSON representation of the \"studentSpecialEducationProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSpecialEducationProgramAssociation(edFiStudentSpecialEducationProgramAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PostStudentSpecialEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentSpecialEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentSpecialEducationProgramAssociationWithHttpInfo(edFiStudentSpecialEducationProgramAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PostStudentSpecialEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentSpecialEducationProgramAssociation** | [**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md) | The JSON representation of the \&quot;studentSpecialEducationProgramAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstudentspecialeducationprogramassociation"></a>
# **PutStudentSpecialEducationProgramAssociation**
> void PutStudentSpecialEducationProgramAssociation (string id, EdFiStudentSpecialEducationProgramAssociation edFiStudentSpecialEducationProgramAssociation, string ifMatch = null)

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
    public class PutStudentSpecialEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentSpecialEducationProgramAssociation = new EdFiStudentSpecialEducationProgramAssociation(); // EdFiStudentSpecialEducationProgramAssociation | The JSON representation of the \"studentSpecialEducationProgramAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentSpecialEducationProgramAssociation(id, edFiStudentSpecialEducationProgramAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PutStudentSpecialEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentSpecialEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentSpecialEducationProgramAssociationWithHttpInfo(id, edFiStudentSpecialEducationProgramAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PutStudentSpecialEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentSpecialEducationProgramAssociation** | [**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md) | The JSON representation of the \&quot;studentSpecialEducationProgramAssociation\&quot; resource to be created or updated. |  |
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

