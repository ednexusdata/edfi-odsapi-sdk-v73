# EdFi.OdsApi.Sdk.v73.Apis.All.StaffEducationOrganizationAssignmentAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStaffEducationOrganizationAssignmentAssociationById**](StaffEducationOrganizationAssignmentAssociationsApi.md#deletestaffeducationorganizationassignmentassociationbyid) | **DELETE** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStaffEducationOrganizationAssignmentAssociations**](StaffEducationOrganizationAssignmentAssociationsApi.md#deletesstaffeducationorganizationassignmentassociations) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStaffEducationOrganizationAssignmentAssociations**](StaffEducationOrganizationAssignmentAssociationsApi.md#getstaffeducationorganizationassignmentassociations) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStaffEducationOrganizationAssignmentAssociationsById**](StaffEducationOrganizationAssignmentAssociationsApi.md#getstaffeducationorganizationassignmentassociationsbyid) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStaffEducationOrganizationAssignmentAssociationsPartitions**](StaffEducationOrganizationAssignmentAssociationsApi.md#getstaffeducationorganizationassignmentassociationspartitions) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStaffEducationOrganizationAssignmentAssociations**](StaffEducationOrganizationAssignmentAssociationsApi.md#keychangesstaffeducationorganizationassignmentassociations) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStaffEducationOrganizationAssignmentAssociation**](StaffEducationOrganizationAssignmentAssociationsApi.md#poststaffeducationorganizationassignmentassociation) | **POST** /ed-fi/staffEducationOrganizationAssignmentAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStaffEducationOrganizationAssignmentAssociation**](StaffEducationOrganizationAssignmentAssociationsApi.md#putstaffeducationorganizationassignmentassociation) | **PUT** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestaffeducationorganizationassignmentassociationbyid"></a>
# **DeleteStaffEducationOrganizationAssignmentAssociationById**
> void DeleteStaffEducationOrganizationAssignmentAssociationById (string id, string ifMatch = null)

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
    public class DeleteStaffEducationOrganizationAssignmentAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffEducationOrganizationAssignmentAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.DeleteStaffEducationOrganizationAssignmentAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStaffEducationOrganizationAssignmentAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStaffEducationOrganizationAssignmentAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.DeleteStaffEducationOrganizationAssignmentAssociationByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstaffeducationorganizationassignmentassociations"></a>
# **DeletesStaffEducationOrganizationAssignmentAssociations**
> List&lt;TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationDelete&gt; DeletesStaffEducationOrganizationAssignmentAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStaffEducationOrganizationAssignmentAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationDelete> result = apiInstance.DeletesStaffEducationOrganizationAssignmentAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.DeletesStaffEducationOrganizationAssignmentAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationDelete>> response = apiInstance.DeletesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.DeletesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationDelete&gt;**](TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationDelete.md)

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

<a id="getstaffeducationorganizationassignmentassociations"></a>
# **GetStaffEducationOrganizationAssignmentAssociations**
> List&lt;EdFiStaffEducationOrganizationAssignmentAssociation&gt; GetStaffEducationOrganizationAssignmentAssociations (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string staffClassificationDescriptor = null, DateOnly beginDate = null, long educationOrganizationId = null, string staffUniqueId = null, string credentialIdentifier = null, string stateOfIssueStateAbbreviationDescriptor = null, long employmentEducationOrganizationId = null, string employmentStatusDescriptor = null, DateOnly employmentHireDate = null, DateOnly endDate = null, double fullTimeEquivalency = null, string id = null, int orderOfAssignment = null, string positionTitle = null, bool useSnapshot = null)

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
    public class GetStaffEducationOrganizationAssignmentAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var staffClassificationDescriptor = "staffClassificationDescriptor_example";  // string | The titles of employment, official status, or rank of education staff. (optional) 
            var beginDate = DateOnly.Parse("2013-10-20");  // DateOnly | Month, day, and year of the start or effective date of a staff member's employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var staffUniqueId = "staffUniqueId_example";  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var credentialIdentifier = "credentialIdentifier_example";  // string | Identifier or serial number assigned to the credential. (optional) 
            var stateOfIssueStateAbbreviationDescriptor = "stateOfIssueStateAbbreviationDescriptor_example";  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (optional) 
            var employmentEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var employmentStatusDescriptor = "employmentStatusDescriptor_example";  // string | Reflects the type of employment or contract. (optional) 
            var employmentHireDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual was hired for a position.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | Month, day, and year of the end or termination date of a staff member's employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var fullTimeEquivalency = 1.2D;  // double | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. (optional) 
            var id = "id_example";  // string |  (optional) 
            var orderOfAssignment = 56;  // int | Describes whether the assignment is this the staff member's primary assignment, secondary assignment, etc. (optional) 
            var positionTitle = "positionTitle_example";  // string | The descriptive name of an individual's position. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStaffEducationOrganizationAssignmentAssociation> result = apiInstance.GetStaffEducationOrganizationAssignmentAssociations(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, staffClassificationDescriptor, beginDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, employmentEducationOrganizationId, employmentStatusDescriptor, employmentHireDate, endDate, fullTimeEquivalency, id, orderOfAssignment, positionTitle, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffEducationOrganizationAssignmentAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStaffEducationOrganizationAssignmentAssociation>> response = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, staffClassificationDescriptor, beginDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, employmentEducationOrganizationId, employmentStatusDescriptor, employmentHireDate, endDate, fullTimeEquivalency, id, orderOfAssignment, positionTitle, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsWithHttpInfo: " + e.Message);
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
| **staffClassificationDescriptor** | **string** | The titles of employment, official status, or rank of education staff. | [optional]  |
| **beginDate** | **DateOnly** | Month, day, and year of the start or effective date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **staffUniqueId** | **string** | A unique alphanumeric code assigned to a staff. | [optional]  |
| **credentialIdentifier** | **string** | Identifier or serial number assigned to the credential. | [optional]  |
| **stateOfIssueStateAbbreviationDescriptor** | **string** | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | [optional]  |
| **employmentEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **employmentStatusDescriptor** | **string** | Reflects the type of employment or contract. | [optional]  |
| **employmentHireDate** | **DateOnly** | The month, day, and year on which an individual was hired for a position.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **endDate** | **DateOnly** | Month, day, and year of the end or termination date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **fullTimeEquivalency** | **double** | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. | [optional]  |
| **id** | **string** |  | [optional]  |
| **orderOfAssignment** | **int** | Describes whether the assignment is this the staff member&#39;s primary assignment, secondary assignment, etc. | [optional]  |
| **positionTitle** | **string** | The descriptive name of an individual&#39;s position. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiStaffEducationOrganizationAssignmentAssociation&gt;**](EdFiStaffEducationOrganizationAssignmentAssociation.md)

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

<a id="getstaffeducationorganizationassignmentassociationsbyid"></a>
# **GetStaffEducationOrganizationAssignmentAssociationsById**
> EdFiStaffEducationOrganizationAssignmentAssociation GetStaffEducationOrganizationAssignmentAssociationsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStaffEducationOrganizationAssignmentAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffEducationOrganizationAssignmentAssociation result = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffEducationOrganizationAssignmentAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStaffEducationOrganizationAssignmentAssociation> response = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md)

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

<a id="getstaffeducationorganizationassignmentassociationspartitions"></a>
# **GetStaffEducationOrganizationAssignmentAssociationsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStaffEducationOrganizationAssignmentAssociationsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string staffClassificationDescriptor = null, DateOnly beginDate = null, long educationOrganizationId = null, string staffUniqueId = null, string credentialIdentifier = null, string stateOfIssueStateAbbreviationDescriptor = null, long employmentEducationOrganizationId = null, string employmentStatusDescriptor = null, DateOnly employmentHireDate = null, DateOnly endDate = null, double fullTimeEquivalency = null, string id = null, int orderOfAssignment = null, string positionTitle = null, bool useSnapshot = null)

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
    public class GetStaffEducationOrganizationAssignmentAssociationsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var staffClassificationDescriptor = "staffClassificationDescriptor_example";  // string | The titles of employment, official status, or rank of education staff. (optional) 
            var beginDate = DateOnly.Parse("2013-10-20");  // DateOnly | Month, day, and year of the start or effective date of a staff member's employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var staffUniqueId = "staffUniqueId_example";  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var credentialIdentifier = "credentialIdentifier_example";  // string | Identifier or serial number assigned to the credential. (optional) 
            var stateOfIssueStateAbbreviationDescriptor = "stateOfIssueStateAbbreviationDescriptor_example";  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (optional) 
            var employmentEducationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var employmentStatusDescriptor = "employmentStatusDescriptor_example";  // string | Reflects the type of employment or contract. (optional) 
            var employmentHireDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual was hired for a position.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | Month, day, and year of the end or termination date of a staff member's employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. (optional) 
            var fullTimeEquivalency = 1.2D;  // double | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. (optional) 
            var id = "id_example";  // string |  (optional) 
            var orderOfAssignment = 56;  // int | Describes whether the assignment is this the staff member's primary assignment, secondary assignment, etc. (optional) 
            var positionTitle = "positionTitle_example";  // string | The descriptive name of an individual's position. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsPartitions(number, minChangeVersion, maxChangeVersion, staffClassificationDescriptor, beginDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, employmentEducationOrganizationId, employmentStatusDescriptor, employmentHireDate, endDate, fullTimeEquivalency, id, orderOfAssignment, positionTitle, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffEducationOrganizationAssignmentAssociationsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, staffClassificationDescriptor, beginDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, employmentEducationOrganizationId, employmentStatusDescriptor, employmentHireDate, endDate, fullTimeEquivalency, id, orderOfAssignment, positionTitle, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsPartitionsWithHttpInfo: " + e.Message);
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
| **staffClassificationDescriptor** | **string** | The titles of employment, official status, or rank of education staff. | [optional]  |
| **beginDate** | **DateOnly** | Month, day, and year of the start or effective date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **staffUniqueId** | **string** | A unique alphanumeric code assigned to a staff. | [optional]  |
| **credentialIdentifier** | **string** | Identifier or serial number assigned to the credential. | [optional]  |
| **stateOfIssueStateAbbreviationDescriptor** | **string** | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | [optional]  |
| **employmentEducationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **employmentStatusDescriptor** | **string** | Reflects the type of employment or contract. | [optional]  |
| **employmentHireDate** | **DateOnly** | The month, day, and year on which an individual was hired for a position.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **endDate** | **DateOnly** | Month, day, and year of the end or termination date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional]  |
| **fullTimeEquivalency** | **double** | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. | [optional]  |
| **id** | **string** |  | [optional]  |
| **orderOfAssignment** | **int** | Describes whether the assignment is this the staff member&#39;s primary assignment, secondary assignment, etc. | [optional]  |
| **positionTitle** | **string** | The descriptive name of an individual&#39;s position. | [optional]  |
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

<a id="keychangesstaffeducationorganizationassignmentassociations"></a>
# **KeyChangesStaffEducationOrganizationAssignmentAssociations**
> List&lt;TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationKeyChange&gt; KeyChangesStaffEducationOrganizationAssignmentAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStaffEducationOrganizationAssignmentAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationKeyChange> result = apiInstance.KeyChangesStaffEducationOrganizationAssignmentAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.KeyChangesStaffEducationOrganizationAssignmentAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationKeyChange>> response = apiInstance.KeyChangesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.KeyChangesStaffEducationOrganizationAssignmentAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationKeyChange&gt;**](TrackedChangesEdFiStaffEducationOrganizationAssignmentAssociationKeyChange.md)

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

<a id="poststaffeducationorganizationassignmentassociation"></a>
# **PostStaffEducationOrganizationAssignmentAssociation**
> void PostStaffEducationOrganizationAssignmentAssociation (EdFiStaffEducationOrganizationAssignmentAssociation edFiStaffEducationOrganizationAssignmentAssociation)

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
    public class PostStaffEducationOrganizationAssignmentAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var edFiStaffEducationOrganizationAssignmentAssociation = new EdFiStaffEducationOrganizationAssignmentAssociation(); // EdFiStaffEducationOrganizationAssignmentAssociation | The JSON representation of the \"staffEducationOrganizationAssignmentAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffEducationOrganizationAssignmentAssociation(edFiStaffEducationOrganizationAssignmentAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PostStaffEducationOrganizationAssignmentAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStaffEducationOrganizationAssignmentAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStaffEducationOrganizationAssignmentAssociationWithHttpInfo(edFiStaffEducationOrganizationAssignmentAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PostStaffEducationOrganizationAssignmentAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStaffEducationOrganizationAssignmentAssociation** | [**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md) | The JSON representation of the \&quot;staffEducationOrganizationAssignmentAssociation\&quot; resource to be created or updated. |  |

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

<a id="putstaffeducationorganizationassignmentassociation"></a>
# **PutStaffEducationOrganizationAssignmentAssociation**
> void PutStaffEducationOrganizationAssignmentAssociation (string id, EdFiStaffEducationOrganizationAssignmentAssociation edFiStaffEducationOrganizationAssignmentAssociation, string ifMatch = null)

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
    public class PutStaffEducationOrganizationAssignmentAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStaffEducationOrganizationAssignmentAssociation = new EdFiStaffEducationOrganizationAssignmentAssociation(); // EdFiStaffEducationOrganizationAssignmentAssociation | The JSON representation of the \"staffEducationOrganizationAssignmentAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStaffEducationOrganizationAssignmentAssociation(id, edFiStaffEducationOrganizationAssignmentAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PutStaffEducationOrganizationAssignmentAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStaffEducationOrganizationAssignmentAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStaffEducationOrganizationAssignmentAssociationWithHttpInfo(id, edFiStaffEducationOrganizationAssignmentAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PutStaffEducationOrganizationAssignmentAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStaffEducationOrganizationAssignmentAssociation** | [**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md) | The JSON representation of the \&quot;staffEducationOrganizationAssignmentAssociation\&quot; resource to be created or updated. |  |
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

