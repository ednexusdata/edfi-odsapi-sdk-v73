# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**AsOfDate** | **DateOnly** | Date of last update of the student&#39;s health record. | 
**Id** | **string** |  | [optional] 
**AdditionalImmunizations** | [**List&lt;EdFiStudentHealthAdditionalImmunization&gt;**](EdFiStudentHealthAdditionalImmunization.md) | An unordered collection of studentHealthAdditionalImmunizations. A record of additional immunizations satisfactorily received and reported. | [optional] 
**NonMedicalImmunizationExemptionDate** | **DateOnly** | The year, month and day of the nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian. | [optional] 
**NonMedicalImmunizationExemptionDescriptor** | **string** | The type of nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian. | [optional] 
**RequiredImmunizations** | [**List&lt;EdFiStudentHealthRequiredImmunization&gt;**](EdFiStudentHealthRequiredImmunization.md) | An unordered collection of studentHealthRequiredImmunizations. A record of the immunizations satisfactorily  received for those recommended to protect the student against vaccine-preventable diseases. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentHealth entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

