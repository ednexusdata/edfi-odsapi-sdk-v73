# EdFi.OdsApi.Sdk.v73.Apis.All.StaffsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStaffById**](StaffsApi.md#deletestaffbyid) | **DELETE** /ed-fi/staffs/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStaffs**](StaffsApi.md#deletesstaffs) | **GET** /ed-fi/staffs/deletes | Retrieves deleted resources based on change version. |
| [**GetStaffs**](StaffsApi.md#getstaffs) | **GET** /ed-fi/staffs | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStaffsById**](StaffsApi.md#getstaffsbyid) | **GET** /ed-fi/staffs/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetStaffsPartitions**](StaffsApi.md#getstaffspartitions) | **GET** /ed-fi/staffs/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesStaffs**](StaffsApi.md#keychangesstaffs) | **GET** /ed-fi/staffs/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStaff**](StaffsApi.md#poststaff) | **POST** /ed-fi/staffs | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStaff**](StaffsApi.md#putstaff) | **PUT** /ed-fi/staffs/{id} | Updates a resource based on the resource identifier. |

<a id="deletestaffbyid"></a>
# **DeleteStaffById**
> void DeleteStaffById (string id, string ifMatch = null)

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
    public class DeleteStaffByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.DeleteStaffById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStaffByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStaffByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.DeleteStaffByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstaffs"></a>
# **DeletesStaffs**
> List&lt;TrackedChangesEdFiStaffDelete&gt; DeletesStaffs (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesStaffsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStaffDelete> result = apiInstance.DeletesStaffs(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.DeletesStaffs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStaffsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStaffDelete>> response = apiInstance.DeletesStaffsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.DeletesStaffsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStaffDelete&gt;**](TrackedChangesEdFiStaffDelete.md)

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

<a id="getstaffs"></a>
# **GetStaffs**
> List&lt;EdFiStaff&gt; GetStaffs (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string staffUniqueId = null, string personId = null, string sourceSystemDescriptor = null, string citizenshipStatusDescriptor = null, string highestCompletedLevelOfEducationDescriptor = null, string sexDescriptor = null, DateOnly birthDate = null, string firstName = null, string genderIdentity = null, string generationCodeSuffix = null, bool highlyQualifiedTeacher = null, bool hispanicLatinoEthnicity = null, string id = null, string lastSurname = null, string loginId = null, string maidenName = null, string middleName = null, string personalTitlePrefix = null, string preferredFirstName = null, string preferredLastSurname = null, double yearsOfPriorProfessionalExperience = null, double yearsOfPriorTeachingExperience = null, bool useSnapshot = null, string staffIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string identificationCode = null)

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
    public class GetStaffsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var staffUniqueId = "staffUniqueId_example";  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var personId = "personId_example";  // string | A unique alphanumeric code assigned to a person. (optional) 
            var sourceSystemDescriptor = "sourceSystemDescriptor_example";  // string | This descriptor defines the originating record source system for the person. (optional) 
            var citizenshipStatusDescriptor = "citizenshipStatusDescriptor_example";  // string | An indicator of whether or not the person is a U.S. citizen. (optional) 
            var highestCompletedLevelOfEducationDescriptor = "highestCompletedLevelOfEducationDescriptor_example";  // string | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). (optional) 
            var sexDescriptor = "sexDescriptor_example";  // string | The birth sex of the staff member. (optional) 
            var birthDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual was born. (optional) 
            var firstName = "firstName_example";  // string | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (optional) 
            var genderIdentity = "genderIdentity_example";  // string | The gender the staff member identifies themselves as. (optional) 
            var generationCodeSuffix = "generationCodeSuffix_example";  // string | An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). (optional) 
            var highlyQualifiedTeacher = true;  // bool | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. (optional) 
            var hispanicLatinoEthnicity = true;  // bool | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = "id_example";  // string |  (optional) 
            var lastSurname = "lastSurname_example";  // string | The name borne in common by members of a family. (optional) 
            var loginId = "loginId_example";  // string | The login ID for the user; used for security access control interface. (optional) 
            var maidenName = "maidenName_example";  // string | The individual's maiden name. (optional) 
            var middleName = "middleName_example";  // string | A secondary name given to an individual at birth, baptism, or during another naming ceremony. (optional) 
            var personalTitlePrefix = "personalTitlePrefix_example";  // string | A prefix used to denote the title, degree, position, or seniority of the individual. (optional) 
            var preferredFirstName = "preferredFirstName_example";  // string | The first name the individual prefers, if different from their legal first name (optional) 
            var preferredLastSurname = "preferredLastSurname_example";  // string | The last name the individual prefers, if different from their legal last name (optional) 
            var yearsOfPriorProfessionalExperience = 1.2D;  // double | The total number of years that an individual has previously held a similar professional position in one or more education institutions prior to the current school year. (optional) 
            var yearsOfPriorTeachingExperience = 1.2D;  // double | The total number of years that an individual has previously held a teaching position in one or more education institutions prior to the current school year. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var staffIdentificationSystemDescriptor = "staffIdentificationSystemDescriptor_example";  // string | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a staff member. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the staff Identification Code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStaff> result = apiInstance.GetStaffs(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, staffUniqueId, personId, sourceSystemDescriptor, citizenshipStatusDescriptor, highestCompletedLevelOfEducationDescriptor, sexDescriptor, birthDate, firstName, genderIdentity, generationCodeSuffix, highlyQualifiedTeacher, hispanicLatinoEthnicity, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix, preferredFirstName, preferredLastSurname, yearsOfPriorProfessionalExperience, yearsOfPriorTeachingExperience, useSnapshot, staffIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.GetStaffs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStaff>> response = apiInstance.GetStaffsWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, staffUniqueId, personId, sourceSystemDescriptor, citizenshipStatusDescriptor, highestCompletedLevelOfEducationDescriptor, sexDescriptor, birthDate, firstName, genderIdentity, generationCodeSuffix, highlyQualifiedTeacher, hispanicLatinoEthnicity, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix, preferredFirstName, preferredLastSurname, yearsOfPriorProfessionalExperience, yearsOfPriorTeachingExperience, useSnapshot, staffIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.GetStaffsWithHttpInfo: " + e.Message);
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
| **staffUniqueId** | **string** | A unique alphanumeric code assigned to a staff. | [optional]  |
| **personId** | **string** | A unique alphanumeric code assigned to a person. | [optional]  |
| **sourceSystemDescriptor** | **string** | This descriptor defines the originating record source system for the person. | [optional]  |
| **citizenshipStatusDescriptor** | **string** | An indicator of whether or not the person is a U.S. citizen. | [optional]  |
| **highestCompletedLevelOfEducationDescriptor** | **string** | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). | [optional]  |
| **sexDescriptor** | **string** | The birth sex of the staff member. | [optional]  |
| **birthDate** | **DateOnly** | The month, day, and year on which an individual was born. | [optional]  |
| **firstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | [optional]  |
| **genderIdentity** | **string** | The gender the staff member identifies themselves as. | [optional]  |
| **generationCodeSuffix** | **string** | An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional]  |
| **highlyQualifiedTeacher** | **bool** | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. | [optional]  |
| **hispanicLatinoEthnicity** | **bool** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional]  |
| **id** | **string** |  | [optional]  |
| **lastSurname** | **string** | The name borne in common by members of a family. | [optional]  |
| **loginId** | **string** | The login ID for the user; used for security access control interface. | [optional]  |
| **maidenName** | **string** | The individual&#39;s maiden name. | [optional]  |
| **middleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional]  |
| **personalTitlePrefix** | **string** | A prefix used to denote the title, degree, position, or seniority of the individual. | [optional]  |
| **preferredFirstName** | **string** | The first name the individual prefers, if different from their legal first name | [optional]  |
| **preferredLastSurname** | **string** | The last name the individual prefers, if different from their legal last name | [optional]  |
| **yearsOfPriorProfessionalExperience** | **double** | The total number of years that an individual has previously held a similar professional position in one or more education institutions prior to the current school year. | [optional]  |
| **yearsOfPriorTeachingExperience** | **double** | The total number of years that an individual has previously held a teaching position in one or more education institutions prior to the current school year. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **staffIdentificationSystemDescriptor** | **string** | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a staff member. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the staff Identification Code. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. | [optional]  |

### Return type

[**List&lt;EdFiStaff&gt;**](EdFiStaff.md)

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

<a id="getstaffsbyid"></a>
# **GetStaffsById**
> EdFiStaff GetStaffsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetStaffsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaff result = apiInstance.GetStaffsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.GetStaffsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStaff> response = apiInstance.GetStaffsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.GetStaffsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStaff**](EdFiStaff.md)

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

<a id="getstaffspartitions"></a>
# **GetStaffsPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetStaffsPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string staffUniqueId = null, string personId = null, string sourceSystemDescriptor = null, string citizenshipStatusDescriptor = null, string highestCompletedLevelOfEducationDescriptor = null, string sexDescriptor = null, DateOnly birthDate = null, string firstName = null, string genderIdentity = null, string generationCodeSuffix = null, bool highlyQualifiedTeacher = null, bool hispanicLatinoEthnicity = null, string id = null, string lastSurname = null, string loginId = null, string maidenName = null, string middleName = null, string personalTitlePrefix = null, string preferredFirstName = null, string preferredLastSurname = null, double yearsOfPriorProfessionalExperience = null, double yearsOfPriorTeachingExperience = null, bool useSnapshot = null, string staffIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string identificationCode = null)

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
    public class GetStaffsPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var staffUniqueId = "staffUniqueId_example";  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var personId = "personId_example";  // string | A unique alphanumeric code assigned to a person. (optional) 
            var sourceSystemDescriptor = "sourceSystemDescriptor_example";  // string | This descriptor defines the originating record source system for the person. (optional) 
            var citizenshipStatusDescriptor = "citizenshipStatusDescriptor_example";  // string | An indicator of whether or not the person is a U.S. citizen. (optional) 
            var highestCompletedLevelOfEducationDescriptor = "highestCompletedLevelOfEducationDescriptor_example";  // string | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). (optional) 
            var sexDescriptor = "sexDescriptor_example";  // string | The birth sex of the staff member. (optional) 
            var birthDate = DateOnly.Parse("2013-10-20");  // DateOnly | The month, day, and year on which an individual was born. (optional) 
            var firstName = "firstName_example";  // string | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (optional) 
            var genderIdentity = "genderIdentity_example";  // string | The gender the staff member identifies themselves as. (optional) 
            var generationCodeSuffix = "generationCodeSuffix_example";  // string | An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). (optional) 
            var highlyQualifiedTeacher = true;  // bool | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. (optional) 
            var hispanicLatinoEthnicity = true;  // bool | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = "id_example";  // string |  (optional) 
            var lastSurname = "lastSurname_example";  // string | The name borne in common by members of a family. (optional) 
            var loginId = "loginId_example";  // string | The login ID for the user; used for security access control interface. (optional) 
            var maidenName = "maidenName_example";  // string | The individual's maiden name. (optional) 
            var middleName = "middleName_example";  // string | A secondary name given to an individual at birth, baptism, or during another naming ceremony. (optional) 
            var personalTitlePrefix = "personalTitlePrefix_example";  // string | A prefix used to denote the title, degree, position, or seniority of the individual. (optional) 
            var preferredFirstName = "preferredFirstName_example";  // string | The first name the individual prefers, if different from their legal first name (optional) 
            var preferredLastSurname = "preferredLastSurname_example";  // string | The last name the individual prefers, if different from their legal last name (optional) 
            var yearsOfPriorProfessionalExperience = 1.2D;  // double | The total number of years that an individual has previously held a similar professional position in one or more education institutions prior to the current school year. (optional) 
            var yearsOfPriorTeachingExperience = 1.2D;  // double | The total number of years that an individual has previously held a teaching position in one or more education institutions prior to the current school year. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var staffIdentificationSystemDescriptor = "staffIdentificationSystemDescriptor_example";  // string | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a staff member. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the staff Identification Code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. (optional) 

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetStaffsPartitions(number, minChangeVersion, maxChangeVersion, staffUniqueId, personId, sourceSystemDescriptor, citizenshipStatusDescriptor, highestCompletedLevelOfEducationDescriptor, sexDescriptor, birthDate, firstName, genderIdentity, generationCodeSuffix, highlyQualifiedTeacher, hispanicLatinoEthnicity, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix, preferredFirstName, preferredLastSurname, yearsOfPriorProfessionalExperience, yearsOfPriorTeachingExperience, useSnapshot, staffIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.GetStaffsPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStaffsPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetStaffsPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, staffUniqueId, personId, sourceSystemDescriptor, citizenshipStatusDescriptor, highestCompletedLevelOfEducationDescriptor, sexDescriptor, birthDate, firstName, genderIdentity, generationCodeSuffix, highlyQualifiedTeacher, hispanicLatinoEthnicity, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix, preferredFirstName, preferredLastSurname, yearsOfPriorProfessionalExperience, yearsOfPriorTeachingExperience, useSnapshot, staffIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.GetStaffsPartitionsWithHttpInfo: " + e.Message);
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
| **staffUniqueId** | **string** | A unique alphanumeric code assigned to a staff. | [optional]  |
| **personId** | **string** | A unique alphanumeric code assigned to a person. | [optional]  |
| **sourceSystemDescriptor** | **string** | This descriptor defines the originating record source system for the person. | [optional]  |
| **citizenshipStatusDescriptor** | **string** | An indicator of whether or not the person is a U.S. citizen. | [optional]  |
| **highestCompletedLevelOfEducationDescriptor** | **string** | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). | [optional]  |
| **sexDescriptor** | **string** | The birth sex of the staff member. | [optional]  |
| **birthDate** | **DateOnly** | The month, day, and year on which an individual was born. | [optional]  |
| **firstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | [optional]  |
| **genderIdentity** | **string** | The gender the staff member identifies themselves as. | [optional]  |
| **generationCodeSuffix** | **string** | An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional]  |
| **highlyQualifiedTeacher** | **bool** | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. | [optional]  |
| **hispanicLatinoEthnicity** | **bool** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional]  |
| **id** | **string** |  | [optional]  |
| **lastSurname** | **string** | The name borne in common by members of a family. | [optional]  |
| **loginId** | **string** | The login ID for the user; used for security access control interface. | [optional]  |
| **maidenName** | **string** | The individual&#39;s maiden name. | [optional]  |
| **middleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional]  |
| **personalTitlePrefix** | **string** | A prefix used to denote the title, degree, position, or seniority of the individual. | [optional]  |
| **preferredFirstName** | **string** | The first name the individual prefers, if different from their legal first name | [optional]  |
| **preferredLastSurname** | **string** | The last name the individual prefers, if different from their legal last name | [optional]  |
| **yearsOfPriorProfessionalExperience** | **double** | The total number of years that an individual has previously held a similar professional position in one or more education institutions prior to the current school year. | [optional]  |
| **yearsOfPriorTeachingExperience** | **double** | The total number of years that an individual has previously held a teaching position in one or more education institutions prior to the current school year. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **staffIdentificationSystemDescriptor** | **string** | A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a staff member. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the staff Identification Code. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. | [optional]  |

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

<a id="keychangesstaffs"></a>
# **KeyChangesStaffs**
> List&lt;TrackedChangesEdFiStaffKeyChange&gt; KeyChangesStaffs (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesStaffsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStaffKeyChange> result = apiInstance.KeyChangesStaffs(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.KeyChangesStaffs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStaffsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStaffKeyChange>> response = apiInstance.KeyChangesStaffsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.KeyChangesStaffsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStaffKeyChange&gt;**](TrackedChangesEdFiStaffKeyChange.md)

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

<a id="poststaff"></a>
# **PostStaff**
> void PostStaff (EdFiStaff edFiStaff)

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
    public class PostStaffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var edFiStaff = new EdFiStaff(); // EdFiStaff | The JSON representation of the \"staff\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaff(edFiStaff);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.PostStaff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStaffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStaffWithHttpInfo(edFiStaff);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.PostStaffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiStaff** | [**EdFiStaff**](EdFiStaff.md) | The JSON representation of the \&quot;staff\&quot; resource to be created or updated. |  |

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

<a id="putstaff"></a>
# **PutStaff**
> void PutStaff (string id, EdFiStaff edFiStaff, string ifMatch = null)

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
    public class PutStaffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiStaff = new EdFiStaff(); // EdFiStaff | The JSON representation of the \"staff\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStaff(id, edFiStaff, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffsApi.PutStaff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStaffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStaffWithHttpInfo(id, edFiStaff, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffsApi.PutStaffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiStaff** | [**EdFiStaff**](EdFiStaff.md) | The JSON representation of the \&quot;staff\&quot; resource to be created or updated. |  |
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

