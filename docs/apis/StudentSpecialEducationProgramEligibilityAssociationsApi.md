# EdFi.OdsApi.Sdk.v73.Apis.All.StudentSpecialEducationProgramEligibilityAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentSpecialEducationProgramEligibilityAssociationById**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#deletestudentspecialeducationprogrameligibilityassociationbyid) | **DELETE** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentSpecialEducationProgramEligibilityAssociations**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#deletesstudentspecialeducationprogrameligibilityassociations) | **GET** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentSpecialEducationProgramEligibilityAssociations**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#getstudentspecialeducationprogrameligibilityassociations) | **GET** /ed-fi/studentSpecialEducationProgramEligibilityAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentSpecialEducationProgramEligibilityAssociationsById**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#getstudentspecialeducationprogrameligibilityassociationsbyid) | **GET** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentSpecialEducationProgramEligibilityAssociationsPartitions**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#getstudentspecialeducationprogrameligibilityassociationspartitions) | **GET** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentSpecialEducationProgramEligibilityAssociations**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#keychangesstudentspecialeducationprogrameligibilityassociations) | **GET** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentSpecialEducationProgramEligibilityAssociation**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#poststudentspecialeducationprogrameligibilityassociation) | **POST** /ed-fi/studentSpecialEducationProgramEligibilityAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentSpecialEducationProgramEligibilityAssociation**](StudentSpecialEducationProgramEligibilityAssociationsApi.md#putstudentspecialeducationprogrameligibilityassociation) | **PUT** /ed-fi/studentSpecialEducationProgramEligibilityAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentspecialeducationprogrameligibilityassociationbyid"></a>
# **DeleteStudentSpecialEducationProgramEligibilityAssociationById**
> void DeleteStudentSpecialEducationProgramEligibilityAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentSpecialEducationProgramEligibilityAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSpecialEducationProgramEligibilityAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.DeleteStudentSpecialEducationProgramEligibilityAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentSpecialEducationProgramEligibilityAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentSpecialEducationProgramEligibilityAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.DeleteStudentSpecialEducationProgramEligibilityAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentspecialeducationprogrameligibilityassociations"></a>
# **DeletesStudentSpecialEducationProgramEligibilityAssociations**
> List&lt;TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationDelete&gt; DeletesStudentSpecialEducationProgramEligibilityAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentSpecialEducationProgramEligibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationDelete> result = apiInstance.DeletesStudentSpecialEducationProgramEligibilityAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.DeletesStudentSpecialEducationProgramEligibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationDelete>> response = apiInstance.DeletesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.DeletesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationDelete&gt;**](TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationDelete.md)

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

<a id="getstudentspecialeducationprogrameligibilityassociations"></a>
# **GetStudentSpecialEducationProgramEligibilityAssociations**
> List&lt;EdFiStudentSpecialEducationProgramEligibilityAssociation&gt; GetStudentSpecialEducationProgramEligibilityAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, DateOnly consentToEvaluationReceivedDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string eligibilityDelayReasonDescriptor = null, string eligibilityEvaluationTypeDescriptor = null, string evaluationDelayReasonDescriptor = null, string ideaPartDescriptor = null, DateOnly consentToEvaluationDate = null, DateOnly eligibilityConferenceDate = null, DateOnly eligibilityDeterminationDate = null, DateOnly eligibilityEvaluationDate = null, bool evaluationCompleteIndicator = null, int evaluationDelayDays = null, string evaluationLateReason = null, string id = null, bool ideaIndicator = null, DateOnly originalECIServicesDate = null, DateOnly transitionConferenceDate = null, DateOnly transitionNotificationDate = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramEligibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var consentToEvaluationReceivedDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the date on which the local education agency received written consent for the evaluation from the student's parent or guardian. This is the first day of the evaluation timeframe. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var eligibilityDelayReasonDescriptor = "eligibilityDelayReasonDescriptor_example";  // string | The reason why the eligibility determination was completed beyond the required timeframe. (optional) 
            var eligibilityEvaluationTypeDescriptor = "eligibilityEvaluationTypeDescriptor_example";  // string | Indicates if this is an initial evaluation or a reevaluation. (optional) 
            var evaluationDelayReasonDescriptor = "evaluationDelayReasonDescriptor_example";  // string | Refers to the justification as to why the evaluation report was completed beyond the state-established timeframe. This descriptor field will have allowed reasons as descriptor values. (optional) 
            var ideaPartDescriptor = "ideaPartDescriptor_example";  // string | Indicates if the evaluation is done under Part B IDEA or Part C IDEA. (optional) 
            var consentToEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date on which the student's parent gave a consent (Parent Consent Date). (optional) 
            var eligibilityConferenceDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year when the eligibility conference is held between the parent(s)/guardian(s) and the educational organization responsible staff member(s) to review and make decision on special education related services eligibility. (optional) 
            var eligibilityDeterminationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year the local education agency (LEA) held the admission, review, and dismissal committee meeting regarding the child's eligibility determination for special education and related services. An individualized education plan (IEP) would be developed and implemented for a child admitted into special education on this same date. (optional) 
            var eligibilityEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year when the written individual evaluation report was completed. (optional) 
            var evaluationCompleteIndicator = true;  // bool | Indicates the evaluation completed status. (optional) 
            var evaluationDelayDays = 56;  // int | Indicates the number of student absences, if any, beginning the first instructional day following the date on which the local education agency (LEA) received written parental or guardian consent for the evaluation. (optional) 
            var evaluationLateReason = "evaluationLateReason_example";  // string | Refers to additional information for delay in doing the evaluation. (optional) 
            var id = "id_example";  // string |  (optional) 
            var ideaIndicator = true;  // bool | Indicates whether or not the student was determined eligible as a result of an evaluation. (optional) 
            var originalECIServicesDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, date, and year when an infant or toddler, from birth through age 2, began participating in the early childhood intervention (ECI) program. (optional) 
            var transitionConferenceDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year when the transition conference was held (for a child receiving early childhood intervention (ECI) services) among the lead agency, the family, and the local education agency (LEA) where the child resides to discuss the child's potential eligibility for early childhood special education (ECSE) services. (optional) 
            var transitionNotificationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year the LEA Notification of Potentially Eligible for Special Education Services was sent by the early childhood intervention (ECI) contractor to the local education agency (LEA) to notify them that a child enrolled in ECI will shortly reach the age of eligibility for Part B services and the child is potentially eligible for services under Part B, early childhood special education (ECSE). The LEA Notification constitutes a referral to the LEA for an initial evaluation and eligibility determination of the child which the parent or guardian may opt out from the referral. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentSpecialEducationProgramEligibilityAssociation> result = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, consentToEvaluationReceivedDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, eligibilityDelayReasonDescriptor, eligibilityEvaluationTypeDescriptor, evaluationDelayReasonDescriptor, ideaPartDescriptor, consentToEvaluationDate, eligibilityConferenceDate, eligibilityDeterminationDate, eligibilityEvaluationDate, evaluationCompleteIndicator, evaluationDelayDays, evaluationLateReason, id, ideaIndicator, originalECIServicesDate, transitionConferenceDate, transitionNotificationDate, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentSpecialEducationProgramEligibilityAssociation>> response = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, consentToEvaluationReceivedDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, eligibilityDelayReasonDescriptor, eligibilityEvaluationTypeDescriptor, evaluationDelayReasonDescriptor, ideaPartDescriptor, consentToEvaluationDate, eligibilityConferenceDate, eligibilityDeterminationDate, eligibilityEvaluationDate, evaluationCompleteIndicator, evaluationDelayDays, evaluationLateReason, id, ideaIndicator, originalECIServicesDate, transitionConferenceDate, transitionNotificationDate, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo: " + e.Message);
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
| **consentToEvaluationReceivedDate** | **DateOnly** | Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programName** | **string** | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional]  |
| **programTypeDescriptor** | **string** | The type of program. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **eligibilityDelayReasonDescriptor** | **string** | The reason why the eligibility determination was completed beyond the required timeframe. | [optional]  |
| **eligibilityEvaluationTypeDescriptor** | **string** | Indicates if this is an initial evaluation or a reevaluation. | [optional]  |
| **evaluationDelayReasonDescriptor** | **string** | Refers to the justification as to why the evaluation report was completed beyond the state-established timeframe. This descriptor field will have allowed reasons as descriptor values. | [optional]  |
| **ideaPartDescriptor** | **string** | Indicates if the evaluation is done under Part B IDEA or Part C IDEA. | [optional]  |
| **consentToEvaluationDate** | **DateOnly** | The date on which the student&#39;s parent gave a consent (Parent Consent Date). | [optional]  |
| **eligibilityConferenceDate** | **DateOnly** | The month, day, and year when the eligibility conference is held between the parent(s)/guardian(s) and the educational organization responsible staff member(s) to review and make decision on special education related services eligibility. | [optional]  |
| **eligibilityDeterminationDate** | **DateOnly** | Indicates the month, day, and year the local education agency (LEA) held the admission, review, and dismissal committee meeting regarding the child&#39;s eligibility determination for special education and related services. An individualized education plan (IEP) would be developed and implemented for a child admitted into special education on this same date. | [optional]  |
| **eligibilityEvaluationDate** | **DateOnly** | Indicates the month, day, and year when the written individual evaluation report was completed. | [optional]  |
| **evaluationCompleteIndicator** | **bool** | Indicates the evaluation completed status. | [optional]  |
| **evaluationDelayDays** | **int** | Indicates the number of student absences, if any, beginning the first instructional day following the date on which the local education agency (LEA) received written parental or guardian consent for the evaluation. | [optional]  |
| **evaluationLateReason** | **string** | Refers to additional information for delay in doing the evaluation. | [optional]  |
| **id** | **string** |  | [optional]  |
| **ideaIndicator** | **bool** | Indicates whether or not the student was determined eligible as a result of an evaluation. | [optional]  |
| **originalECIServicesDate** | **DateOnly** | The month, date, and year when an infant or toddler, from birth through age 2, began participating in the early childhood intervention (ECI) program. | [optional]  |
| **transitionConferenceDate** | **DateOnly** | Indicates the month, day, and year when the transition conference was held (for a child receiving early childhood intervention (ECI) services) among the lead agency, the family, and the local education agency (LEA) where the child resides to discuss the child&#39;s potential eligibility for early childhood special education (ECSE) services. | [optional]  |
| **transitionNotificationDate** | **DateOnly** | Indicates the month, day, and year the LEA Notification of Potentially Eligible for Special Education Services was sent by the early childhood intervention (ECI) contractor to the local education agency (LEA) to notify them that a child enrolled in ECI will shortly reach the age of eligibility for Part B services and the child is potentially eligible for services under Part B, early childhood special education (ECSE). The LEA Notification constitutes a referral to the LEA for an initial evaluation and eligibility determination of the child which the parent or guardian may opt out from the referral. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentSpecialEducationProgramEligibilityAssociation&gt;**](EdFiStudentSpecialEducationProgramEligibilityAssociation.md)

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

<a id="getstudentspecialeducationprogrameligibilityassociationsbyid"></a>
# **GetStudentSpecialEducationProgramEligibilityAssociationsById**
> EdFiStudentSpecialEducationProgramEligibilityAssociation GetStudentSpecialEducationProgramEligibilityAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramEligibilityAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSpecialEducationProgramEligibilityAssociation result = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramEligibilityAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentSpecialEducationProgramEligibilityAssociation> response = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentSpecialEducationProgramEligibilityAssociation**](EdFiStudentSpecialEducationProgramEligibilityAssociation.md)

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

<a id="getstudentspecialeducationprogrameligibilityassociationspartitions"></a>
# **GetStudentSpecialEducationProgramEligibilityAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentSpecialEducationProgramEligibilityAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, DateOnly consentToEvaluationReceivedDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string eligibilityDelayReasonDescriptor = null, string eligibilityEvaluationTypeDescriptor = null, string evaluationDelayReasonDescriptor = null, string ideaPartDescriptor = null, DateOnly consentToEvaluationDate = null, DateOnly eligibilityConferenceDate = null, DateOnly eligibilityDeterminationDate = null, DateOnly eligibilityEvaluationDate = null, bool evaluationCompleteIndicator = null, int evaluationDelayDays = null, string evaluationLateReason = null, string id = null, bool ideaIndicator = null, DateOnly originalECIServicesDate = null, DateOnly transitionConferenceDate = null, DateOnly transitionNotificationDate = null, bool useSnapshot = null)

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
    public class GetStudentSpecialEducationProgramEligibilityAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var consentToEvaluationReceivedDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the date on which the local education agency received written consent for the evaluation from the student's parent or guardian. This is the first day of the evaluation timeframe. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var eligibilityDelayReasonDescriptor = "eligibilityDelayReasonDescriptor_example";  // string | The reason why the eligibility determination was completed beyond the required timeframe. (optional) 
            var eligibilityEvaluationTypeDescriptor = "eligibilityEvaluationTypeDescriptor_example";  // string | Indicates if this is an initial evaluation or a reevaluation. (optional) 
            var evaluationDelayReasonDescriptor = "evaluationDelayReasonDescriptor_example";  // string | Refers to the justification as to why the evaluation report was completed beyond the state-established timeframe. This descriptor field will have allowed reasons as descriptor values. (optional) 
            var ideaPartDescriptor = "ideaPartDescriptor_example";  // string | Indicates if the evaluation is done under Part B IDEA or Part C IDEA. (optional) 
            var consentToEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The date on which the student's parent gave a consent (Parent Consent Date). (optional) 
            var eligibilityConferenceDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year when the eligibility conference is held between the parent(s)/guardian(s) and the educational organization responsible staff member(s) to review and make decision on special education related services eligibility. (optional) 
            var eligibilityDeterminationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year the local education agency (LEA) held the admission, review, and dismissal committee meeting regarding the child's eligibility determination for special education and related services. An individualized education plan (IEP) would be developed and implemented for a child admitted into special education on this same date. (optional) 
            var eligibilityEvaluationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year when the written individual evaluation report was completed. (optional) 
            var evaluationCompleteIndicator = true;  // bool | Indicates the evaluation completed status. (optional) 
            var evaluationDelayDays = 56;  // int | Indicates the number of student absences, if any, beginning the first instructional day following the date on which the local education agency (LEA) received written parental or guardian consent for the evaluation. (optional) 
            var evaluationLateReason = "evaluationLateReason_example";  // string | Refers to additional information for delay in doing the evaluation. (optional) 
            var id = "id_example";  // string |  (optional) 
            var ideaIndicator = true;  // bool | Indicates whether or not the student was determined eligible as a result of an evaluation. (optional) 
            var originalECIServicesDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, date, and year when an infant or toddler, from birth through age 2, began participating in the early childhood intervention (ECI) program. (optional) 
            var transitionConferenceDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year when the transition conference was held (for a child receiving early childhood intervention (ECI) services) among the lead agency, the family, and the local education agency (LEA) where the child resides to discuss the child's potential eligibility for early childhood special education (ECSE) services. (optional) 
            var transitionNotificationDate = DateOnly.Parse("2013-10-20");  // DateOnly | Indicates the month, day, and year the LEA Notification of Potentially Eligible for Special Education Services was sent by the early childhood intervention (ECI) contractor to the local education agency (LEA) to notify them that a child enrolled in ECI will shortly reach the age of eligibility for Part B services and the child is potentially eligible for services under Part B, early childhood special education (ECSE). The LEA Notification constitutes a referral to the LEA for an initial evaluation and eligibility determination of the child which the parent or guardian may opt out from the referral. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociationsPartitions(number, minChangeVersion, maxChangeVersion, consentToEvaluationReceivedDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, eligibilityDelayReasonDescriptor, eligibilityEvaluationTypeDescriptor, evaluationDelayReasonDescriptor, ideaPartDescriptor, consentToEvaluationDate, eligibilityConferenceDate, eligibilityDeterminationDate, eligibilityEvaluationDate, evaluationCompleteIndicator, evaluationDelayDays, evaluationLateReason, id, ideaIndicator, originalECIServicesDate, transitionConferenceDate, transitionNotificationDate, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSpecialEducationProgramEligibilityAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentSpecialEducationProgramEligibilityAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, consentToEvaluationReceivedDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, eligibilityDelayReasonDescriptor, eligibilityEvaluationTypeDescriptor, evaluationDelayReasonDescriptor, ideaPartDescriptor, consentToEvaluationDate, eligibilityConferenceDate, eligibilityDeterminationDate, eligibilityEvaluationDate, evaluationCompleteIndicator, evaluationDelayDays, evaluationLateReason, id, ideaIndicator, originalECIServicesDate, transitionConferenceDate, transitionNotificationDate, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.GetStudentSpecialEducationProgramEligibilityAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **consentToEvaluationReceivedDate** | **DateOnly** | Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **programName** | **string** | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional]  |
| **programTypeDescriptor** | **string** | The type of program. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **eligibilityDelayReasonDescriptor** | **string** | The reason why the eligibility determination was completed beyond the required timeframe. | [optional]  |
| **eligibilityEvaluationTypeDescriptor** | **string** | Indicates if this is an initial evaluation or a reevaluation. | [optional]  |
| **evaluationDelayReasonDescriptor** | **string** | Refers to the justification as to why the evaluation report was completed beyond the state-established timeframe. This descriptor field will have allowed reasons as descriptor values. | [optional]  |
| **ideaPartDescriptor** | **string** | Indicates if the evaluation is done under Part B IDEA or Part C IDEA. | [optional]  |
| **consentToEvaluationDate** | **DateOnly** | The date on which the student&#39;s parent gave a consent (Parent Consent Date). | [optional]  |
| **eligibilityConferenceDate** | **DateOnly** | The month, day, and year when the eligibility conference is held between the parent(s)/guardian(s) and the educational organization responsible staff member(s) to review and make decision on special education related services eligibility. | [optional]  |
| **eligibilityDeterminationDate** | **DateOnly** | Indicates the month, day, and year the local education agency (LEA) held the admission, review, and dismissal committee meeting regarding the child&#39;s eligibility determination for special education and related services. An individualized education plan (IEP) would be developed and implemented for a child admitted into special education on this same date. | [optional]  |
| **eligibilityEvaluationDate** | **DateOnly** | Indicates the month, day, and year when the written individual evaluation report was completed. | [optional]  |
| **evaluationCompleteIndicator** | **bool** | Indicates the evaluation completed status. | [optional]  |
| **evaluationDelayDays** | **int** | Indicates the number of student absences, if any, beginning the first instructional day following the date on which the local education agency (LEA) received written parental or guardian consent for the evaluation. | [optional]  |
| **evaluationLateReason** | **string** | Refers to additional information for delay in doing the evaluation. | [optional]  |
| **id** | **string** |  | [optional]  |
| **ideaIndicator** | **bool** | Indicates whether or not the student was determined eligible as a result of an evaluation. | [optional]  |
| **originalECIServicesDate** | **DateOnly** | The month, date, and year when an infant or toddler, from birth through age 2, began participating in the early childhood intervention (ECI) program. | [optional]  |
| **transitionConferenceDate** | **DateOnly** | Indicates the month, day, and year when the transition conference was held (for a child receiving early childhood intervention (ECI) services) among the lead agency, the family, and the local education agency (LEA) where the child resides to discuss the child&#39;s potential eligibility for early childhood special education (ECSE) services. | [optional]  |
| **transitionNotificationDate** | **DateOnly** | Indicates the month, day, and year the LEA Notification of Potentially Eligible for Special Education Services was sent by the early childhood intervention (ECI) contractor to the local education agency (LEA) to notify them that a child enrolled in ECI will shortly reach the age of eligibility for Part B services and the child is potentially eligible for services under Part B, early childhood special education (ECSE). The LEA Notification constitutes a referral to the LEA for an initial evaluation and eligibility determination of the child which the parent or guardian may opt out from the referral. | [optional]  |
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

<a id="keychangesstudentspecialeducationprogrameligibilityassociations"></a>
# **KeyChangesStudentSpecialEducationProgramEligibilityAssociations**
> List&lt;TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyChange&gt; KeyChangesStudentSpecialEducationProgramEligibilityAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentSpecialEducationProgramEligibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyChange> result = apiInstance.KeyChangesStudentSpecialEducationProgramEligibilityAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.KeyChangesStudentSpecialEducationProgramEligibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyChange>> response = apiInstance.KeyChangesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.KeyChangesStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyChange&gt;**](TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyChange.md)

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

<a id="poststudentspecialeducationprogrameligibilityassociation"></a>
# **PostStudentSpecialEducationProgramEligibilityAssociation**
> void PostStudentSpecialEducationProgramEligibilityAssociation (EdFiStudentSpecialEducationProgramEligibilityAssociation edFiStudentSpecialEducationProgramEligibilityAssociation)

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
    public class PostStudentSpecialEducationProgramEligibilityAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var edFiStudentSpecialEducationProgramEligibilityAssociation = new EdFiStudentSpecialEducationProgramEligibilityAssociation(); // EdFiStudentSpecialEducationProgramEligibilityAssociation | The JSON representation of the \"studentSpecialEducationProgramEligibilityAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSpecialEducationProgramEligibilityAssociation(edFiStudentSpecialEducationProgramEligibilityAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.PostStudentSpecialEducationProgramEligibilityAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo(edFiStudentSpecialEducationProgramEligibilityAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.PostStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentSpecialEducationProgramEligibilityAssociation** | [**EdFiStudentSpecialEducationProgramEligibilityAssociation**](EdFiStudentSpecialEducationProgramEligibilityAssociation.md) | The JSON representation of the \&quot;studentSpecialEducationProgramEligibilityAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstudentspecialeducationprogrameligibilityassociation"></a>
# **PutStudentSpecialEducationProgramEligibilityAssociation**
> void PutStudentSpecialEducationProgramEligibilityAssociation (string id, EdFiStudentSpecialEducationProgramEligibilityAssociation edFiStudentSpecialEducationProgramEligibilityAssociation, string ifMatch = null)

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
    public class PutStudentSpecialEducationProgramEligibilityAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentSpecialEducationProgramEligibilityAssociation = new EdFiStudentSpecialEducationProgramEligibilityAssociation(); // EdFiStudentSpecialEducationProgramEligibilityAssociation | The JSON representation of the \"studentSpecialEducationProgramEligibilityAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentSpecialEducationProgramEligibilityAssociation(id, edFiStudentSpecialEducationProgramEligibilityAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.PutStudentSpecialEducationProgramEligibilityAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo(id, edFiStudentSpecialEducationProgramEligibilityAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSpecialEducationProgramEligibilityAssociationsApi.PutStudentSpecialEducationProgramEligibilityAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentSpecialEducationProgramEligibilityAssociation** | [**EdFiStudentSpecialEducationProgramEligibilityAssociation**](EdFiStudentSpecialEducationProgramEligibilityAssociation.md) | The JSON representation of the \&quot;studentSpecialEducationProgramEligibilityAssociation\&quot; resource to be created or updated. |  |
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

