# EdFi.OdsApi.Sdk.v73.Apis.All.StudentEducationOrganizationAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentEducationOrganizationAssociationById**](StudentEducationOrganizationAssociationsApi.md#deletestudenteducationorganizationassociationbyid) | **DELETE** /ed-fi/studentEducationOrganizationAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentEducationOrganizationAssociations**](StudentEducationOrganizationAssociationsApi.md#deletesstudenteducationorganizationassociations) | **GET** /ed-fi/studentEducationOrganizationAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentEducationOrganizationAssociations**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociations) | **GET** /ed-fi/studentEducationOrganizationAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentEducationOrganizationAssociationsById**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociationsbyid) | **GET** /ed-fi/studentEducationOrganizationAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStudentEducationOrganizationAssociationsPartitions**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociationspartitions) | **GET** /ed-fi/studentEducationOrganizationAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStudentEducationOrganizationAssociations**](StudentEducationOrganizationAssociationsApi.md#keychangesstudenteducationorganizationassociations) | **GET** /ed-fi/studentEducationOrganizationAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#poststudenteducationorganizationassociation) | **POST** /ed-fi/studentEducationOrganizationAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#putstudenteducationorganizationassociation) | **PUT** /ed-fi/studentEducationOrganizationAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudenteducationorganizationassociationbyid"></a>
# **DeleteStudentEducationOrganizationAssociationById**
> void DeleteStudentEducationOrganizationAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentEducationOrganizationAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentEducationOrganizationAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeleteStudentEducationOrganizationAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentEducationOrganizationAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentEducationOrganizationAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeleteStudentEducationOrganizationAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudenteducationorganizationassociations"></a>
# **DeletesStudentEducationOrganizationAssociations**
> List&lt;TrackedChangesEdFiStudentEducationOrganizationAssociationDelete&gt; DeletesStudentEducationOrganizationAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStudentEducationOrganizationAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentEducationOrganizationAssociationDelete> result = apiInstance.DeletesStudentEducationOrganizationAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeletesStudentEducationOrganizationAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentEducationOrganizationAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentEducationOrganizationAssociationDelete>> response = apiInstance.DeletesStudentEducationOrganizationAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeletesStudentEducationOrganizationAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentEducationOrganizationAssociationDelete&gt;**](TrackedChangesEdFiStudentEducationOrganizationAssociationDelete.md)

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

<a id="getstudenteducationorganizationassociations"></a>
# **GetStudentEducationOrganizationAssociations**
> List&lt;EdFiStudentEducationOrganizationAssociation&gt; GetStudentEducationOrganizationAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, long educationOrganizationId = null, string studentUniqueId = null, string barrierToInternetAccessInResidenceDescriptor = null, string internetAccessTypeInResidenceDescriptor = null, string internetPerformanceInResidenceDescriptor = null, string limitedEnglishProficiencyDescriptor = null, string primaryLearningDeviceAccessDescriptor = null, string primaryLearningDeviceAwayFromSchoolDescriptor = null, string primaryLearningDeviceProviderDescriptor = null, string sexDescriptor = null, string supporterMilitaryConnectionDescriptor = null, string genderIdentity = null, bool hispanicLatinoEthnicity = null, string id = null, bool internetAccessInResidence = null, string loginId = null, string profileThumbnail = null, bool useSnapshot = null, string studentIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string identificationCode = null)

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
    public class GetStudentEducationOrganizationAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var barrierToInternetAccessInResidenceDescriptor = "barrierToInternetAccessInResidenceDescriptor_example";  // string | An indication of the barrier to having internet access in the student s primary place of residence. (optional) 
            var internetAccessTypeInResidenceDescriptor = "internetAccessTypeInResidenceDescriptor_example";  // string | The primary type of internet service used in the student s primary place of residence. (optional) 
            var internetPerformanceInResidenceDescriptor = "internetPerformanceInResidenceDescriptor_example";  // string | An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence. (optional) 
            var limitedEnglishProficiencyDescriptor = "limitedEnglishProficiencyDescriptor_example";  // string | An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. (optional) 
            var primaryLearningDeviceAccessDescriptor = "primaryLearningDeviceAccessDescriptor_example";  // string | An indication of whether the primary learning device is shared or not shared with another individual. (optional) 
            var primaryLearningDeviceAwayFromSchoolDescriptor = "primaryLearningDeviceAwayFromSchoolDescriptor_example";  // string | The type of device the student uses most often to complete learning activities away from school. (optional) 
            var primaryLearningDeviceProviderDescriptor = "primaryLearningDeviceProviderDescriptor_example";  // string | The provider of the primary learning device. (optional) 
            var sexDescriptor = "sexDescriptor_example";  // string | The student's birth sex as reported to the education organization. (optional) 
            var supporterMilitaryConnectionDescriptor = "supporterMilitaryConnectionDescriptor_example";  // string | Military connection of the person/people whom the student is a dependent of. (optional) 
            var genderIdentity = "genderIdentity_example";  // string | The student's gender as last reported to the education organization. (optional) 
            var hispanicLatinoEthnicity = true;  // bool | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = "id_example";  // string |  (optional) 
            var internetAccessInResidence = true;  // bool | An indication of whether the student is able to access the internet in their primary place of residence. (optional) 
            var loginId = "loginId_example";  // string | The login ID for the user; used for security access control interface. (optional) 
            var profileThumbnail = "profileThumbnail_example";  // string | Locator reference for the student photo. The specification for that reference is left to local definition. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var studentIdentificationSystemDescriptor = "studentIdentificationSystemDescriptor_example";  // string | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the StudentIdentificationCode. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentEducationOrganizationAssociation> result = apiInstance.GetStudentEducationOrganizationAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, educationOrganizationId, studentUniqueId, barrierToInternetAccessInResidenceDescriptor, internetAccessTypeInResidenceDescriptor, internetPerformanceInResidenceDescriptor, limitedEnglishProficiencyDescriptor, primaryLearningDeviceAccessDescriptor, primaryLearningDeviceAwayFromSchoolDescriptor, primaryLearningDeviceProviderDescriptor, sexDescriptor, supporterMilitaryConnectionDescriptor, genderIdentity, hispanicLatinoEthnicity, id, internetAccessInResidence, loginId, profileThumbnail, useSnapshot, studentIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEducationOrganizationAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentEducationOrganizationAssociation>> response = apiInstance.GetStudentEducationOrganizationAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, educationOrganizationId, studentUniqueId, barrierToInternetAccessInResidenceDescriptor, internetAccessTypeInResidenceDescriptor, internetPerformanceInResidenceDescriptor, limitedEnglishProficiencyDescriptor, primaryLearningDeviceAccessDescriptor, primaryLearningDeviceAwayFromSchoolDescriptor, primaryLearningDeviceProviderDescriptor, sexDescriptor, supporterMilitaryConnectionDescriptor, genderIdentity, hispanicLatinoEthnicity, id, internetAccessInResidence, loginId, profileThumbnail, useSnapshot, studentIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsWithHttpInfo: " + e.Message);
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
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **barrierToInternetAccessInResidenceDescriptor** | **string** | An indication of the barrier to having internet access in the student s primary place of residence. | [optional]  |
| **internetAccessTypeInResidenceDescriptor** | **string** | The primary type of internet service used in the student s primary place of residence. | [optional]  |
| **internetPerformanceInResidenceDescriptor** | **string** | An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence. | [optional]  |
| **limitedEnglishProficiencyDescriptor** | **string** | An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. | [optional]  |
| **primaryLearningDeviceAccessDescriptor** | **string** | An indication of whether the primary learning device is shared or not shared with another individual. | [optional]  |
| **primaryLearningDeviceAwayFromSchoolDescriptor** | **string** | The type of device the student uses most often to complete learning activities away from school. | [optional]  |
| **primaryLearningDeviceProviderDescriptor** | **string** | The provider of the primary learning device. | [optional]  |
| **sexDescriptor** | **string** | The student&#39;s birth sex as reported to the education organization. | [optional]  |
| **supporterMilitaryConnectionDescriptor** | **string** | Military connection of the person/people whom the student is a dependent of. | [optional]  |
| **genderIdentity** | **string** | The student&#39;s gender as last reported to the education organization. | [optional]  |
| **hispanicLatinoEthnicity** | **bool** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional]  |
| **id** | **string** |  | [optional]  |
| **internetAccessInResidence** | **bool** | An indication of whether the student is able to access the internet in their primary place of residence. | [optional]  |
| **loginId** | **string** | The login ID for the user; used for security access control interface. | [optional]  |
| **profileThumbnail** | **string** | Locator reference for the student photo. The specification for that reference is left to local definition. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **studentIdentificationSystemDescriptor** | **string** | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the StudentIdentificationCode. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. | [optional]  |

### Return type

[**List&lt;EdFiStudentEducationOrganizationAssociation&gt;**](EdFiStudentEducationOrganizationAssociation.md)

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

<a id="getstudenteducationorganizationassociationsbyid"></a>
# **GetStudentEducationOrganizationAssociationsById**
> EdFiStudentEducationOrganizationAssociation GetStudentEducationOrganizationAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStudentEducationOrganizationAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentEducationOrganizationAssociation result = apiInstance.GetStudentEducationOrganizationAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEducationOrganizationAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentEducationOrganizationAssociation> response = apiInstance.GetStudentEducationOrganizationAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md)

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

<a id="getstudenteducationorganizationassociationspartitions"></a>
# **GetStudentEducationOrganizationAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStudentEducationOrganizationAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, long educationOrganizationId = null, string studentUniqueId = null, string barrierToInternetAccessInResidenceDescriptor = null, string internetAccessTypeInResidenceDescriptor = null, string internetPerformanceInResidenceDescriptor = null, string limitedEnglishProficiencyDescriptor = null, string primaryLearningDeviceAccessDescriptor = null, string primaryLearningDeviceAwayFromSchoolDescriptor = null, string primaryLearningDeviceProviderDescriptor = null, string sexDescriptor = null, string supporterMilitaryConnectionDescriptor = null, string genderIdentity = null, bool hispanicLatinoEthnicity = null, string id = null, bool internetAccessInResidence = null, string loginId = null, string profileThumbnail = null, bool useSnapshot = null, string studentIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string identificationCode = null)

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
    public class GetStudentEducationOrganizationAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var barrierToInternetAccessInResidenceDescriptor = "barrierToInternetAccessInResidenceDescriptor_example";  // string | An indication of the barrier to having internet access in the student s primary place of residence. (optional) 
            var internetAccessTypeInResidenceDescriptor = "internetAccessTypeInResidenceDescriptor_example";  // string | The primary type of internet service used in the student s primary place of residence. (optional) 
            var internetPerformanceInResidenceDescriptor = "internetPerformanceInResidenceDescriptor_example";  // string | An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence. (optional) 
            var limitedEnglishProficiencyDescriptor = "limitedEnglishProficiencyDescriptor_example";  // string | An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. (optional) 
            var primaryLearningDeviceAccessDescriptor = "primaryLearningDeviceAccessDescriptor_example";  // string | An indication of whether the primary learning device is shared or not shared with another individual. (optional) 
            var primaryLearningDeviceAwayFromSchoolDescriptor = "primaryLearningDeviceAwayFromSchoolDescriptor_example";  // string | The type of device the student uses most often to complete learning activities away from school. (optional) 
            var primaryLearningDeviceProviderDescriptor = "primaryLearningDeviceProviderDescriptor_example";  // string | The provider of the primary learning device. (optional) 
            var sexDescriptor = "sexDescriptor_example";  // string | The student's birth sex as reported to the education organization. (optional) 
            var supporterMilitaryConnectionDescriptor = "supporterMilitaryConnectionDescriptor_example";  // string | Military connection of the person/people whom the student is a dependent of. (optional) 
            var genderIdentity = "genderIdentity_example";  // string | The student's gender as last reported to the education organization. (optional) 
            var hispanicLatinoEthnicity = true;  // bool | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = "id_example";  // string |  (optional) 
            var internetAccessInResidence = true;  // bool | An indication of whether the student is able to access the internet in their primary place of residence. (optional) 
            var loginId = "loginId_example";  // string | The login ID for the user; used for security access control interface. (optional) 
            var profileThumbnail = "profileThumbnail_example";  // string | Locator reference for the student photo. The specification for that reference is left to local definition. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var studentIdentificationSystemDescriptor = "studentIdentificationSystemDescriptor_example";  // string | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the StudentIdentificationCode. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. (optional) 

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStudentEducationOrganizationAssociationsPartitions(number, minChangeVersion, maxChangeVersion, educationOrganizationId, studentUniqueId, barrierToInternetAccessInResidenceDescriptor, internetAccessTypeInResidenceDescriptor, internetPerformanceInResidenceDescriptor, limitedEnglishProficiencyDescriptor, primaryLearningDeviceAccessDescriptor, primaryLearningDeviceAwayFromSchoolDescriptor, primaryLearningDeviceProviderDescriptor, sexDescriptor, supporterMilitaryConnectionDescriptor, genderIdentity, hispanicLatinoEthnicity, id, internetAccessInResidence, loginId, profileThumbnail, useSnapshot, studentIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEducationOrganizationAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStudentEducationOrganizationAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, educationOrganizationId, studentUniqueId, barrierToInternetAccessInResidenceDescriptor, internetAccessTypeInResidenceDescriptor, internetPerformanceInResidenceDescriptor, limitedEnglishProficiencyDescriptor, primaryLearningDeviceAccessDescriptor, primaryLearningDeviceAwayFromSchoolDescriptor, primaryLearningDeviceProviderDescriptor, sexDescriptor, supporterMilitaryConnectionDescriptor, genderIdentity, hispanicLatinoEthnicity, id, internetAccessInResidence, loginId, profileThumbnail, useSnapshot, studentIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **barrierToInternetAccessInResidenceDescriptor** | **string** | An indication of the barrier to having internet access in the student s primary place of residence. | [optional]  |
| **internetAccessTypeInResidenceDescriptor** | **string** | The primary type of internet service used in the student s primary place of residence. | [optional]  |
| **internetPerformanceInResidenceDescriptor** | **string** | An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence. | [optional]  |
| **limitedEnglishProficiencyDescriptor** | **string** | An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. | [optional]  |
| **primaryLearningDeviceAccessDescriptor** | **string** | An indication of whether the primary learning device is shared or not shared with another individual. | [optional]  |
| **primaryLearningDeviceAwayFromSchoolDescriptor** | **string** | The type of device the student uses most often to complete learning activities away from school. | [optional]  |
| **primaryLearningDeviceProviderDescriptor** | **string** | The provider of the primary learning device. | [optional]  |
| **sexDescriptor** | **string** | The student&#39;s birth sex as reported to the education organization. | [optional]  |
| **supporterMilitaryConnectionDescriptor** | **string** | Military connection of the person/people whom the student is a dependent of. | [optional]  |
| **genderIdentity** | **string** | The student&#39;s gender as last reported to the education organization. | [optional]  |
| **hispanicLatinoEthnicity** | **bool** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional]  |
| **id** | **string** |  | [optional]  |
| **internetAccessInResidence** | **bool** | An indication of whether the student is able to access the internet in their primary place of residence. | [optional]  |
| **loginId** | **string** | The login ID for the user; used for security access control interface. | [optional]  |
| **profileThumbnail** | **string** | Locator reference for the student photo. The specification for that reference is left to local definition. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **studentIdentificationSystemDescriptor** | **string** | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the StudentIdentificationCode. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. | [optional]  |

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

<a id="keychangesstudenteducationorganizationassociations"></a>
# **KeyChangesStudentEducationOrganizationAssociations**
> List&lt;TrackedChangesEdFiStudentEducationOrganizationAssociationKeyChange&gt; KeyChangesStudentEducationOrganizationAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStudentEducationOrganizationAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentEducationOrganizationAssociationKeyChange> result = apiInstance.KeyChangesStudentEducationOrganizationAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.KeyChangesStudentEducationOrganizationAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentEducationOrganizationAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentEducationOrganizationAssociationKeyChange>> response = apiInstance.KeyChangesStudentEducationOrganizationAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.KeyChangesStudentEducationOrganizationAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentEducationOrganizationAssociationKeyChange&gt;**](TrackedChangesEdFiStudentEducationOrganizationAssociationKeyChange.md)

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

<a id="poststudenteducationorganizationassociation"></a>
# **PostStudentEducationOrganizationAssociation**
> void PostStudentEducationOrganizationAssociation (EdFiStudentEducationOrganizationAssociation edFiStudentEducationOrganizationAssociation)

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
    public class PostStudentEducationOrganizationAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var edFiStudentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociation(); // EdFiStudentEducationOrganizationAssociation | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentEducationOrganizationAssociation(edFiStudentEducationOrganizationAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PostStudentEducationOrganizationAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentEducationOrganizationAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentEducationOrganizationAssociationWithHttpInfo(edFiStudentEducationOrganizationAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PostStudentEducationOrganizationAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStudentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md) | The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstudenteducationorganizationassociation"></a>
# **PutStudentEducationOrganizationAssociation**
> void PutStudentEducationOrganizationAssociation (string id, EdFiStudentEducationOrganizationAssociation edFiStudentEducationOrganizationAssociation, string ifMatch = null)

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
    public class PutStudentEducationOrganizationAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStudentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociation(); // EdFiStudentEducationOrganizationAssociation | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentEducationOrganizationAssociation(id, edFiStudentEducationOrganizationAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PutStudentEducationOrganizationAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentEducationOrganizationAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentEducationOrganizationAssociationWithHttpInfo(id, edFiStudentEducationOrganizationAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PutStudentEducationOrganizationAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStudentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md) | The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. |  |
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

