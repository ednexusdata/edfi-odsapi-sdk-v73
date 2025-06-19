# EdFi.OdsApi.Sdk.v73.Apis.All.StudentMigrantEducationProgramAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentMigrantEducationProgramAssociationById**](StudentMigrantEducationProgramAssociationsApi.md#deletestudentmigranteducationprogramassociationbyid) | **DELETE** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentMigrantEducationProgramAssociations**](StudentMigrantEducationProgramAssociationsApi.md#deletesstudentmigranteducationprogramassociations) | **GET** /ed-fi/studentMigrantEducationProgramAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentMigrantEducationProgramAssociations**](StudentMigrantEducationProgramAssociationsApi.md#getstudentmigranteducationprogramassociations) | **GET** /ed-fi/studentMigrantEducationProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentMigrantEducationProgramAssociationsById**](StudentMigrantEducationProgramAssociationsApi.md#getstudentmigranteducationprogramassociationsbyid) | **GET** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentMigrantEducationProgramAssociationsPartitions**](StudentMigrantEducationProgramAssociationsApi.md#getstudentmigranteducationprogramassociationspartitions) | **GET** /ed-fi/studentMigrantEducationProgramAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentMigrantEducationProgramAssociations**](StudentMigrantEducationProgramAssociationsApi.md#keychangesstudentmigranteducationprogramassociations) | **GET** /ed-fi/studentMigrantEducationProgramAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentMigrantEducationProgramAssociation**](StudentMigrantEducationProgramAssociationsApi.md#poststudentmigranteducationprogramassociation) | **POST** /ed-fi/studentMigrantEducationProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentMigrantEducationProgramAssociation**](StudentMigrantEducationProgramAssociationsApi.md#putstudentmigranteducationprogramassociation) | **PUT** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentmigranteducationprogramassociationbyid"></a>
# **DeleteStudentMigrantEducationProgramAssociationById**
> void DeleteStudentMigrantEducationProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentMigrantEducationProgramAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentMigrantEducationProgramAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.DeleteStudentMigrantEducationProgramAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentMigrantEducationProgramAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentMigrantEducationProgramAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.DeleteStudentMigrantEducationProgramAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentmigranteducationprogramassociations"></a>
# **DeletesStudentMigrantEducationProgramAssociations**
> List&lt;TrackedChangesEdFiStudentMigrantEducationProgramAssociationDelete&gt; DeletesStudentMigrantEducationProgramAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentMigrantEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentMigrantEducationProgramAssociationDelete> result = apiInstance.DeletesStudentMigrantEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.DeletesStudentMigrantEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentMigrantEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentMigrantEducationProgramAssociationDelete>> response = apiInstance.DeletesStudentMigrantEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.DeletesStudentMigrantEducationProgramAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentMigrantEducationProgramAssociationDelete&gt;**](TrackedChangesEdFiStudentMigrantEducationProgramAssociationDelete.md)

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

<a id="getstudentmigranteducationprogramassociations"></a>
# **GetStudentMigrantEducationProgramAssociations**
> List&lt;EdFiStudentMigrantEducationProgramAssociation&gt; GetStudentMigrantEducationProgramAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, DateOnly beginDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string continuationOfServicesReasonDescriptor = null, DateOnly eligibilityExpirationDate = null, DateOnly lastQualifyingMove = null, bool priorityForServices = null, DateOnly qualifyingArrivalDate = null, DateOnly stateResidencyDate = null, DateOnly usInitialEntry = null, DateOnly usInitialSchoolEntry = null, DateOnly usMostRecentEntry = null, string reasonExitedDescriptor = null, DateOnly endDate = null, string id = null, bool servedOutsideOfRegularSession = null, bool useSnapshot = null)

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
    public class GetStudentMigrantEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
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
            var continuationOfServicesReasonDescriptor = "continuationOfServicesReasonDescriptor_example";  // string | The \"continuation of services\" provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). (optional) 
            var eligibilityExpirationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The eligibility expiration date is used to determine end of eligibility and to account for a child's eligibility expiring earlier than 36 months from the child's QAD. A child's eligibility would end earlier than 36 months from the child's QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by states' requirements), or if the child passes away. (optional) 
            var lastQualifyingMove = DateOnly.Parse("2013-10-20");  // DateOnly | Date the last qualifying move occurred; used to compute MEP status. (optional) 
            var priorityForServices = true;  // bool | Report migratory children who are classified as having \"priority for services\" because they are failing, or most at risk of failing to meet the state's challenging state academic content standards and challenging state student academic achievement standards, and their education has been interrupted during the regular school year. (optional) 
            var qualifyingArrivalDate = DateOnly.Parse("2013-10-20");  // DateOnly | The qualifying arrival date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child's eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. (optional) 
            var stateResidencyDate = DateOnly.Parse("2013-10-20");  // DateOnly | The verified state residency for the student. (optional) 
            var usInitialEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student first entered the U.S. (optional) 
            var usInitialSchoolEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student first entered a U.S. school. (optional) 
            var usMostRecentEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year of the student's most recent entry into the U.S. (optional) 
            var reasonExitedDescriptor = "reasonExitedDescriptor_example";  // string | The reason the student left the program within a school or district. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var id = "id_example";  // string |  (optional) 
            var servedOutsideOfRegularSession = true;  // bool | Indicates whether the student received services during the summer session or between sessions. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentMigrantEducationProgramAssociation> result = apiInstance.GetStudentMigrantEducationProgramAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, continuationOfServicesReasonDescriptor, eligibilityExpirationDate, lastQualifyingMove, priorityForServices, qualifyingArrivalDate, stateResidencyDate, usInitialEntry, usInitialSchoolEntry, usMostRecentEntry, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentMigrantEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentMigrantEducationProgramAssociation>> response = apiInstance.GetStudentMigrantEducationProgramAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, continuationOfServicesReasonDescriptor, eligibilityExpirationDate, lastQualifyingMove, priorityForServices, qualifyingArrivalDate, stateResidencyDate, usInitialEntry, usInitialSchoolEntry, usMostRecentEntry, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsWithHttpInfo: " + e.Message);
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
| **continuationOfServicesReasonDescriptor** | **string** | The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). | [optional]  |
| **eligibilityExpirationDate** | **DateOnly** | The eligibility expiration date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by states&#39; requirements), or if the child passes away. | [optional]  |
| **lastQualifyingMove** | **DateOnly** | Date the last qualifying move occurred; used to compute MEP status. | [optional]  |
| **priorityForServices** | **bool** | Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the state&#39;s challenging state academic content standards and challenging state student academic achievement standards, and their education has been interrupted during the regular school year. | [optional]  |
| **qualifyingArrivalDate** | **DateOnly** | The qualifying arrival date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. | [optional]  |
| **stateResidencyDate** | **DateOnly** | The verified state residency for the student. | [optional]  |
| **usInitialEntry** | **DateOnly** | The month, day, and year on which the student first entered the U.S. | [optional]  |
| **usInitialSchoolEntry** | **DateOnly** | The month, day, and year on which the student first entered a U.S. school. | [optional]  |
| **usMostRecentEntry** | **DateOnly** | The month, day, and year of the student&#39;s most recent entry into the U.S. | [optional]  |
| **reasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional]  |
| **endDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **id** | **string** |  | [optional]  |
| **servedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStudentMigrantEducationProgramAssociation&gt;**](EdFiStudentMigrantEducationProgramAssociation.md)

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

<a id="getstudentmigranteducationprogramassociationsbyid"></a>
# **GetStudentMigrantEducationProgramAssociationsById**
> EdFiStudentMigrantEducationProgramAssociation GetStudentMigrantEducationProgramAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentMigrantEducationProgramAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentMigrantEducationProgramAssociation result = apiInstance.GetStudentMigrantEducationProgramAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentMigrantEducationProgramAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentMigrantEducationProgramAssociation> response = apiInstance.GetStudentMigrantEducationProgramAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md)

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

<a id="getstudentmigranteducationprogramassociationspartitions"></a>
# **GetStudentMigrantEducationProgramAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentMigrantEducationProgramAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, DateOnly beginDate = null, long educationOrganizationId = null, long programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string continuationOfServicesReasonDescriptor = null, DateOnly eligibilityExpirationDate = null, DateOnly lastQualifyingMove = null, bool priorityForServices = null, DateOnly qualifyingArrivalDate = null, DateOnly stateResidencyDate = null, DateOnly usInitialEntry = null, DateOnly usInitialSchoolEntry = null, DateOnly usMostRecentEntry = null, string reasonExitedDescriptor = null, DateOnly endDate = null, string id = null, bool servedOutsideOfRegularSession = null, bool useSnapshot = null)

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
    public class GetStudentMigrantEducationProgramAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var beginDate = DateOnly.Parse("2013-10-20");  // DateOnly | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string | The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var continuationOfServicesReasonDescriptor = "continuationOfServicesReasonDescriptor_example";  // string | The \"continuation of services\" provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). (optional) 
            var eligibilityExpirationDate = DateOnly.Parse("2013-10-20");  // DateOnly | The eligibility expiration date is used to determine end of eligibility and to account for a child's eligibility expiring earlier than 36 months from the child's QAD. A child's eligibility would end earlier than 36 months from the child's QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by states' requirements), or if the child passes away. (optional) 
            var lastQualifyingMove = DateOnly.Parse("2013-10-20");  // DateOnly | Date the last qualifying move occurred; used to compute MEP status. (optional) 
            var priorityForServices = true;  // bool | Report migratory children who are classified as having \"priority for services\" because they are failing, or most at risk of failing to meet the state's challenging state academic content standards and challenging state student academic achievement standards, and their education has been interrupted during the regular school year. (optional) 
            var qualifyingArrivalDate = DateOnly.Parse("2013-10-20");  // DateOnly | The qualifying arrival date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child's eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. (optional) 
            var stateResidencyDate = DateOnly.Parse("2013-10-20");  // DateOnly | The verified state residency for the student. (optional) 
            var usInitialEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student first entered the U.S. (optional) 
            var usInitialSchoolEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student first entered a U.S. school. (optional) 
            var usMostRecentEntry = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year of the student's most recent entry into the U.S. (optional) 
            var reasonExitedDescriptor = "reasonExitedDescriptor_example";  // string | The reason the student left the program within a school or district. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var id = "id_example";  // string |  (optional) 
            var servedOutsideOfRegularSession = true;  // bool | Indicates whether the student received services during the summer session or between sessions. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentMigrantEducationProgramAssociationsPartitions(number, minChangeVersion, maxChangeVersion, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, continuationOfServicesReasonDescriptor, eligibilityExpirationDate, lastQualifyingMove, priorityForServices, qualifyingArrivalDate, stateResidencyDate, usInitialEntry, usInitialSchoolEntry, usMostRecentEntry, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentMigrantEducationProgramAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentMigrantEducationProgramAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, continuationOfServicesReasonDescriptor, eligibilityExpirationDate, lastQualifyingMove, priorityForServices, qualifyingArrivalDate, stateResidencyDate, usInitialEntry, usInitialSchoolEntry, usMostRecentEntry, reasonExitedDescriptor, endDate, id, servedOutsideOfRegularSession, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **continuationOfServicesReasonDescriptor** | **string** | The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). | [optional]  |
| **eligibilityExpirationDate** | **DateOnly** | The eligibility expiration date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by states&#39; requirements), or if the child passes away. | [optional]  |
| **lastQualifyingMove** | **DateOnly** | Date the last qualifying move occurred; used to compute MEP status. | [optional]  |
| **priorityForServices** | **bool** | Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the state&#39;s challenging state academic content standards and challenging state student academic achievement standards, and their education has been interrupted during the regular school year. | [optional]  |
| **qualifyingArrivalDate** | **DateOnly** | The qualifying arrival date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. | [optional]  |
| **stateResidencyDate** | **DateOnly** | The verified state residency for the student. | [optional]  |
| **usInitialEntry** | **DateOnly** | The month, day, and year on which the student first entered the U.S. | [optional]  |
| **usInitialSchoolEntry** | **DateOnly** | The month, day, and year on which the student first entered a U.S. school. | [optional]  |
| **usMostRecentEntry** | **DateOnly** | The month, day, and year of the student&#39;s most recent entry into the U.S. | [optional]  |
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

<a id="keychangesstudentmigranteducationprogramassociations"></a>
# **KeyChangesStudentMigrantEducationProgramAssociations**
> List&lt;TrackedChangesEdFiStudentMigrantEducationProgramAssociationKeyChange&gt; KeyChangesStudentMigrantEducationProgramAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentMigrantEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentMigrantEducationProgramAssociationKeyChange> result = apiInstance.KeyChangesStudentMigrantEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.KeyChangesStudentMigrantEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentMigrantEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentMigrantEducationProgramAssociationKeyChange>> response = apiInstance.KeyChangesStudentMigrantEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.KeyChangesStudentMigrantEducationProgramAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentMigrantEducationProgramAssociationKeyChange&gt;**](TrackedChangesEdFiStudentMigrantEducationProgramAssociationKeyChange.md)

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

<a id="poststudentmigranteducationprogramassociation"></a>
# **PostStudentMigrantEducationProgramAssociation**
> void PostStudentMigrantEducationProgramAssociation (EdFiStudentMigrantEducationProgramAssociation edFiStudentMigrantEducationProgramAssociation)

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
    public class PostStudentMigrantEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var edFiStudentMigrantEducationProgramAssociation = new EdFiStudentMigrantEducationProgramAssociation(); // EdFiStudentMigrantEducationProgramAssociation | The JSON representation of the \"studentMigrantEducationProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentMigrantEducationProgramAssociation(edFiStudentMigrantEducationProgramAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PostStudentMigrantEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentMigrantEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentMigrantEducationProgramAssociationWithHttpInfo(edFiStudentMigrantEducationProgramAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PostStudentMigrantEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentMigrantEducationProgramAssociation** | [**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md) | The JSON representation of the \&quot;studentMigrantEducationProgramAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstudentmigranteducationprogramassociation"></a>
# **PutStudentMigrantEducationProgramAssociation**
> void PutStudentMigrantEducationProgramAssociation (string id, EdFiStudentMigrantEducationProgramAssociation edFiStudentMigrantEducationProgramAssociation, string ifMatch = null)

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
    public class PutStudentMigrantEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentMigrantEducationProgramAssociation = new EdFiStudentMigrantEducationProgramAssociation(); // EdFiStudentMigrantEducationProgramAssociation | The JSON representation of the \"studentMigrantEducationProgramAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentMigrantEducationProgramAssociation(id, edFiStudentMigrantEducationProgramAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PutStudentMigrantEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentMigrantEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentMigrantEducationProgramAssociationWithHttpInfo(id, edFiStudentMigrantEducationProgramAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PutStudentMigrantEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentMigrantEducationProgramAssociation** | [**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md) | The JSON representation of the \&quot;studentMigrantEducationProgramAssociation\&quot; resource to be created or updated. |  |
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

