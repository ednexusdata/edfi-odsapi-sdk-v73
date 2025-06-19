# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStaffEducationOrganizationAssignmentAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Month, day, and year of the start or effective date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**StaffClassificationDescriptor** | **string** | The titles of employment, official status, or rank of education staff. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**Id** | **string** |  | [optional] 
**CredentialReference** | [**EdFiCredentialReference**](EdFiCredentialReference.md) |  | [optional] 
**EmploymentStaffEducationOrganizationEmploymentAssociationReference** | [**EdFiStaffEducationOrganizationEmploymentAssociationReference**](EdFiStaffEducationOrganizationEmploymentAssociationReference.md) |  | [optional] 
**EndDate** | **DateOnly** | Month, day, and year of the end or termination date of a staff member&#39;s employment, contract, or relationship with the education organization.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**FullTimeEquivalency** | **double** | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. | [optional] 
**OrderOfAssignment** | **int** | Describes whether the assignment is this the staff member&#39;s primary assignment, secondary assignment, etc. | [optional] 
**PositionTitle** | **string** | The descriptive name of an individual&#39;s position. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffEducationOrganizationAssignmentAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

