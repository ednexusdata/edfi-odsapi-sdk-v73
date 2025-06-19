# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentDisciplineIncidentBehaviorAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BehaviorDescriptor** | **string** | Describes behavior by category. | 
**DisciplineIncidentReference** | [**EdFiDisciplineIncidentReference**](EdFiDisciplineIncidentReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**BehaviorDetailedDescription** | **string** | Specifies a more granular level of detail of a behavior involved in the incident. | [optional] 
**DisciplineIncidentParticipationCodes** | [**List&lt;EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode&gt;**](EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode.md) | An unordered collection of studentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident. | [optional] 
**Weapons** | [**List&lt;EdFiStudentDisciplineIncidentBehaviorAssociationWeapon&gt;**](EdFiStudentDisciplineIncidentBehaviorAssociationWeapon.md) | An unordered collection of studentDisciplineIncidentBehaviorAssociationWeapons. Identifies the type(s) of weapon used by the student during a discipline incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentDisciplineIncidentBehaviorAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

