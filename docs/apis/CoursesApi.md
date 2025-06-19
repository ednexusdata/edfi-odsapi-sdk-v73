# EdFi.OdsApi.Sdk.v73.Apis.All.CoursesApi

All URIs are relative to *https://api.ed-fi.org:443/v7.3/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCourseById**](CoursesApi.md#deletecoursebyid) | **DELETE** /ed-fi/courses/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesCourses**](CoursesApi.md#deletescourses) | **GET** /ed-fi/courses/deletes | Retrieves deleted resources based on change version. |
| [**GetCourses**](CoursesApi.md#getcourses) | **GET** /ed-fi/courses | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetCoursesById**](CoursesApi.md#getcoursesbyid) | **GET** /ed-fi/courses/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**GetCoursesPartitions**](CoursesApi.md#getcoursespartitions) | **GET** /ed-fi/courses/partitions | Retrieves a set of page tokens to be used for efficient client-side parallel processing. |
| [**KeyChangesCourses**](CoursesApi.md#keychangescourses) | **GET** /ed-fi/courses/keyChanges | Retrieves resources key changes based on change version. |
| [**PostCourse**](CoursesApi.md#postcourse) | **POST** /ed-fi/courses | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutCourse**](CoursesApi.md#putcourse) | **PUT** /ed-fi/courses/{id} | Updates a resource based on the resource identifier. |

<a id="deletecoursebyid"></a>
# **DeleteCourseById**
> void DeleteCourseById (string id, string ifMatch = null)

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
    public class DeleteCourseByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCourseById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.DeleteCourseById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCourseByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteCourseByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.DeleteCourseByIdWithHttpInfo: " + e.Message);
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

<a id="deletescourses"></a>
# **DeletesCourses**
> List&lt;TrackedChangesEdFiCourseDelete&gt; DeletesCourses (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class DeletesCoursesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiCourseDelete> result = apiInstance.DeletesCourses(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.DeletesCourses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesCoursesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiCourseDelete>> response = apiInstance.DeletesCoursesWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.DeletesCoursesWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiCourseDelete&gt;**](TrackedChangesEdFiCourseDelete.md)

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

<a id="getcourses"></a>
# **GetCourses**
> List&lt;EdFiCourse&gt; GetCourses (int offset = null, int limit = null, string pageToken = null, int pageSize = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string courseCode = null, long educationOrganizationId = null, string careerPathwayDescriptor = null, string courseDefinedByDescriptor = null, string courseGPAApplicabilityDescriptor = null, string minimumAvailableCreditTypeDescriptor = null, string maximumAvailableCreditTypeDescriptor = null, string courseDescription = null, string courseTitle = null, DateOnly dateCourseAdopted = null, bool highSchoolCourseRequirement = null, string id = null, int maxCompletionsForCredit = null, double maximumAvailableCreditConversion = null, double maximumAvailableCredits = null, double minimumAvailableCreditConversion = null, double minimumAvailableCredits = null, int numberOfParts = null, int timeRequiredForCompletion = null, bool useSnapshot = null, string courseIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string courseCatalogURL = null, string identificationCode = null)

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
    public class GetCoursesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var pageToken = "pageToken_example";  // string | The token of the page to retrieve, obtained either from the \"Next-Page-Token\" header of the previous request, or from the \"partitions\" endpoint for the resource. Cannot be used with limit/offset paging. (optional) 
            var pageSize = 25;  // int | The maximum number of items to retrieve in the page. For use with pageToken (cursor paging) only. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var courseCode = "courseCode_example";  // string | A unique alphanumeric code assigned to a course. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var careerPathwayDescriptor = "careerPathwayDescriptor_example";  // string | Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum. (optional) 
            var courseDefinedByDescriptor = "courseDefinedByDescriptor_example";  // string | Specifies whether the course was defined by the SEA, LEA, School, or national organization. (optional) 
            var courseGPAApplicabilityDescriptor = "courseGPAApplicabilityDescriptor_example";  // string | An indicator of whether or not the course being described is included in the computation of the student's grade point average, and if so, if it is weighted differently from regular courses. (optional) 
            var minimumAvailableCreditTypeDescriptor = "minimumAvailableCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var maximumAvailableCreditTypeDescriptor = "maximumAvailableCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var courseDescription = "courseDescription_example";  // string | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. (optional) 
            var courseTitle = "courseTitle_example";  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). (optional) 
            var dateCourseAdopted = DateOnly.Parse("2013-10-20");  // DateOnly | Date the course was adopted by the education agency. (optional) 
            var highSchoolCourseRequirement = true;  // bool | An indication that this course may satisfy high school graduation requirements in the course's subject area. (optional) 
            var id = "id_example";  // string |  (optional) 
            var maxCompletionsForCredit = 56;  // int | Designates how many times the course may be taken with credit received by the student. (optional) 
            var maximumAvailableCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var maximumAvailableCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var minimumAvailableCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var minimumAvailableCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var numberOfParts = 56;  // int | The number of parts identified for a course. (optional) 
            var timeRequiredForCompletion = 56;  // int | The actual or estimated number of clock minutes required for class completion. This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var courseIdentificationSystemDescriptor = "courseIdentificationSystemDescriptor_example";  // string | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the Identification Code. (optional) 
            var courseCatalogURL = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \"/\". For example, consider the following SCED code-    subject = 20 Math    course = 272 Geometry    level = G General    credits = 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiCourse> result = apiInstance.GetCourses(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, courseCode, educationOrganizationId, careerPathwayDescriptor, courseDefinedByDescriptor, courseGPAApplicabilityDescriptor, minimumAvailableCreditTypeDescriptor, maximumAvailableCreditTypeDescriptor, courseDescription, courseTitle, dateCourseAdopted, highSchoolCourseRequirement, id, maxCompletionsForCredit, maximumAvailableCreditConversion, maximumAvailableCredits, minimumAvailableCreditConversion, minimumAvailableCredits, numberOfParts, timeRequiredForCompletion, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, courseCatalogURL, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.GetCourses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoursesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiCourse>> response = apiInstance.GetCoursesWithHttpInfo(offset, limit, pageToken, pageSize, minChangeVersion, maxChangeVersion, totalCount, courseCode, educationOrganizationId, careerPathwayDescriptor, courseDefinedByDescriptor, courseGPAApplicabilityDescriptor, minimumAvailableCreditTypeDescriptor, maximumAvailableCreditTypeDescriptor, courseDescription, courseTitle, dateCourseAdopted, highSchoolCourseRequirement, id, maxCompletionsForCredit, maximumAvailableCreditConversion, maximumAvailableCredits, minimumAvailableCreditConversion, minimumAvailableCredits, numberOfParts, timeRequiredForCompletion, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, courseCatalogURL, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.GetCoursesWithHttpInfo: " + e.Message);
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
| **courseCode** | **string** | A unique alphanumeric code assigned to a course. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **careerPathwayDescriptor** | **string** | Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum. | [optional]  |
| **courseDefinedByDescriptor** | **string** | Specifies whether the course was defined by the SEA, LEA, School, or national organization. | [optional]  |
| **courseGPAApplicabilityDescriptor** | **string** | An indicator of whether or not the course being described is included in the computation of the student&#39;s grade point average, and if so, if it is weighted differently from regular courses. | [optional]  |
| **minimumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **maximumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **courseDescription** | **string** | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. | [optional]  |
| **courseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). | [optional]  |
| **dateCourseAdopted** | **DateOnly** | Date the course was adopted by the education agency. | [optional]  |
| **highSchoolCourseRequirement** | **bool** | An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area. | [optional]  |
| **id** | **string** |  | [optional]  |
| **maxCompletionsForCredit** | **int** | Designates how many times the course may be taken with credit received by the student. | [optional]  |
| **maximumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **maximumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **minimumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **minimumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **numberOfParts** | **int** | The number of parts identified for a course. | [optional]  |
| **timeRequiredForCompletion** | **int** | The actual or estimated number of clock minutes required for class completion. This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **courseIdentificationSystemDescriptor** | **string** | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the Identification Code. | [optional]  |
| **courseCatalogURL** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
| **identificationCode** | **string** | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. | [optional]  |

### Return type

[**List&lt;EdFiCourse&gt;**](EdFiCourse.md)

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

<a id="getcoursesbyid"></a>
# **GetCoursesById**
> EdFiCourse GetCoursesById (string id, string ifNoneMatch = null, bool useSnapshot = null)

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
    public class GetCoursesByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCourse result = apiInstance.GetCoursesById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.GetCoursesById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoursesByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiCourse> response = apiInstance.GetCoursesByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.GetCoursesByIdWithHttpInfo: " + e.Message);
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

[**EdFiCourse**](EdFiCourse.md)

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

<a id="getcoursespartitions"></a>
# **GetCoursesPartitions**
> GetAbsenceEventCategoryDescriptorsPartitions200Response GetCoursesPartitions (int number = null, long minChangeVersion = null, long maxChangeVersion = null, string courseCode = null, long educationOrganizationId = null, string careerPathwayDescriptor = null, string courseDefinedByDescriptor = null, string courseGPAApplicabilityDescriptor = null, string minimumAvailableCreditTypeDescriptor = null, string maximumAvailableCreditTypeDescriptor = null, string courseDescription = null, string courseTitle = null, DateOnly dateCourseAdopted = null, bool highSchoolCourseRequirement = null, string id = null, int maxCompletionsForCredit = null, double maximumAvailableCreditConversion = null, double maximumAvailableCredits = null, double minimumAvailableCreditConversion = null, double minimumAvailableCredits = null, int numberOfParts = null, int timeRequiredForCompletion = null, bool useSnapshot = null, string courseIdentificationSystemDescriptor = null, string assigningOrganizationIdentificationCode = null, string courseCatalogURL = null, string identificationCode = null)

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
    public class GetCoursesPartitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var number = 56;  // int | The number of evenly distributed partitions to provide for client-side parallel processing. If unspecified, a reasonable set of partitions will be determined based on the total number of accessible items. (optional) 
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var courseCode = "courseCode_example";  // string | A unique alphanumeric code assigned to a course. (optional) 
            var educationOrganizationId = 789L;  // long | The identifier assigned to an education organization. (optional) 
            var careerPathwayDescriptor = "careerPathwayDescriptor_example";  // string | Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum. (optional) 
            var courseDefinedByDescriptor = "courseDefinedByDescriptor_example";  // string | Specifies whether the course was defined by the SEA, LEA, School, or national organization. (optional) 
            var courseGPAApplicabilityDescriptor = "courseGPAApplicabilityDescriptor_example";  // string | An indicator of whether or not the course being described is included in the computation of the student's grade point average, and if so, if it is weighted differently from regular courses. (optional) 
            var minimumAvailableCreditTypeDescriptor = "minimumAvailableCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var maximumAvailableCreditTypeDescriptor = "maximumAvailableCreditTypeDescriptor_example";  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var courseDescription = "courseDescription_example";  // string | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. (optional) 
            var courseTitle = "courseTitle_example";  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). (optional) 
            var dateCourseAdopted = DateOnly.Parse("2013-10-20");  // DateOnly | Date the course was adopted by the education agency. (optional) 
            var highSchoolCourseRequirement = true;  // bool | An indication that this course may satisfy high school graduation requirements in the course's subject area. (optional) 
            var id = "id_example";  // string |  (optional) 
            var maxCompletionsForCredit = 56;  // int | Designates how many times the course may be taken with credit received by the student. (optional) 
            var maximumAvailableCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var maximumAvailableCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var minimumAvailableCreditConversion = 1.2D;  // double | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var minimumAvailableCredits = 1.2D;  // double | The value of credits or units of value awarded for the completion of a course. (optional) 
            var numberOfParts = 56;  // int | The number of parts identified for a course. (optional) 
            var timeRequiredForCompletion = 56;  // int | The actual or estimated number of clock minutes required for class completion. This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)
            var courseIdentificationSystemDescriptor = "courseIdentificationSystemDescriptor_example";  // string | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. (optional) 
            var assigningOrganizationIdentificationCode = "assigningOrganizationIdentificationCode_example";  // string | The organization code or name assigning the Identification Code. (optional) 
            var courseCatalogURL = "courseCatalogURL_example";  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var identificationCode = "identificationCode_example";  // string | A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \"/\". For example, consider the following SCED code-    subject = 20 Math    course = 272 Geometry    level = G General    credits = 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. (optional) 

            try
            {
                // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
                GetAbsenceEventCategoryDescriptorsPartitions200Response result = apiInstance.GetCoursesPartitions(number, minChangeVersion, maxChangeVersion, courseCode, educationOrganizationId, careerPathwayDescriptor, courseDefinedByDescriptor, courseGPAApplicabilityDescriptor, minimumAvailableCreditTypeDescriptor, maximumAvailableCreditTypeDescriptor, courseDescription, courseTitle, dateCourseAdopted, highSchoolCourseRequirement, id, maxCompletionsForCredit, maximumAvailableCreditConversion, maximumAvailableCredits, minimumAvailableCreditConversion, minimumAvailableCredits, numberOfParts, timeRequiredForCompletion, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, courseCatalogURL, identificationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.GetCoursesPartitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoursesPartitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a set of page tokens to be used for efficient client-side parallel processing.
    ApiResponse<GetAbsenceEventCategoryDescriptorsPartitions200Response> response = apiInstance.GetCoursesPartitionsWithHttpInfo(number, minChangeVersion, maxChangeVersion, courseCode, educationOrganizationId, careerPathwayDescriptor, courseDefinedByDescriptor, courseGPAApplicabilityDescriptor, minimumAvailableCreditTypeDescriptor, maximumAvailableCreditTypeDescriptor, courseDescription, courseTitle, dateCourseAdopted, highSchoolCourseRequirement, id, maxCompletionsForCredit, maximumAvailableCreditConversion, maximumAvailableCredits, minimumAvailableCreditConversion, minimumAvailableCredits, numberOfParts, timeRequiredForCompletion, useSnapshot, courseIdentificationSystemDescriptor, assigningOrganizationIdentificationCode, courseCatalogURL, identificationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.GetCoursesPartitionsWithHttpInfo: " + e.Message);
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
| **courseCode** | **string** | A unique alphanumeric code assigned to a course. | [optional]  |
| **educationOrganizationId** | **long** | The identifier assigned to an education organization. | [optional]  |
| **careerPathwayDescriptor** | **string** | Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum. | [optional]  |
| **courseDefinedByDescriptor** | **string** | Specifies whether the course was defined by the SEA, LEA, School, or national organization. | [optional]  |
| **courseGPAApplicabilityDescriptor** | **string** | An indicator of whether or not the course being described is included in the computation of the student&#39;s grade point average, and if so, if it is weighted differently from regular courses. | [optional]  |
| **minimumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **maximumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional]  |
| **courseDescription** | **string** | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. | [optional]  |
| **courseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). | [optional]  |
| **dateCourseAdopted** | **DateOnly** | Date the course was adopted by the education agency. | [optional]  |
| **highSchoolCourseRequirement** | **bool** | An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area. | [optional]  |
| **id** | **string** |  | [optional]  |
| **maxCompletionsForCredit** | **int** | Designates how many times the course may be taken with credit received by the student. | [optional]  |
| **maximumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **maximumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **minimumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional]  |
| **minimumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional]  |
| **numberOfParts** | **int** | The number of parts identified for a course. | [optional]  |
| **timeRequiredForCompletion** | **int** | The actual or estimated number of clock minutes required for class completion. This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |
| **courseIdentificationSystemDescriptor** | **string** | A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. | [optional]  |
| **assigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the Identification Code. | [optional]  |
| **courseCatalogURL** | **string** | The URL for the course catalog that defines the course identification code. | [optional]  |
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

<a id="keychangescourses"></a>
# **KeyChangesCourses**
> List&lt;TrackedChangesEdFiCourseKeyChange&gt; KeyChangesCourses (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

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
    public class KeyChangesCoursesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var offset = 56;  // int | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. Must be false when using cursor paging (with pageToken). (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiCourseKeyChange> result = apiInstance.KeyChangesCourses(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.KeyChangesCourses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesCoursesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiCourseKeyChange>> response = apiInstance.KeyChangesCoursesWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.KeyChangesCoursesWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiCourseKeyChange&gt;**](TrackedChangesEdFiCourseKeyChange.md)

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

<a id="postcourse"></a>
# **PostCourse**
> void PostCourse (EdFiCourse edFiCourse)

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
    public class PostCourseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var edFiCourse = new EdFiCourse(); // EdFiCourse | The JSON representation of the \"course\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCourse(edFiCourse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.PostCourse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCourseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostCourseWithHttpInfo(edFiCourse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.PostCourseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiCourse** | [**EdFiCourse**](EdFiCourse.md) | The JSON representation of the \&quot;course\&quot; resource to be created or updated. |  |

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

<a id="putcourse"></a>
# **PutCourse**
> void PutCourse (string id, EdFiCourse edFiCourse, string ifMatch = null)

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
    public class PutCourseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.3/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiCourse = new EdFiCourse(); // EdFiCourse | The JSON representation of the \"course\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutCourse(id, edFiCourse, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoursesApi.PutCourse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCourseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutCourseWithHttpInfo(id, edFiCourse, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoursesApi.PutCourseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiCourse** | [**EdFiCourse**](EdFiCourse.md) | The JSON representation of the \&quot;course\&quot; resource to be created or updated. |  |
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

