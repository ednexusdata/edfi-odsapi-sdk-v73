# EdFi.OdsApi.Sdk.v73.Models.All.EdFiDisciplineIncident

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentIdentifier** | **string** | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**IncidentDate** | **DateOnly** | The month, day, and year on which the discipline incident occurred. | 
**Id** | **string** |  | [optional] 
**Behaviors** | [**List&lt;EdFiDisciplineIncidentBehavior&gt;**](EdFiDisciplineIncidentBehavior.md) | An unordered collection of disciplineIncidentBehaviors. Describes behavior by category and provides a detailed description. | [optional] 
**CaseNumber** | **string** | The case number assigned to the DisciplineIncident by law enforcement or other organization. | [optional] 
**ExternalParticipants** | [**List&lt;EdFiDisciplineIncidentExternalParticipant&gt;**](EdFiDisciplineIncidentExternalParticipant.md) | An unordered collection of disciplineIncidentExternalParticipants. Information on an individual involved in the discipline incident. | [optional] 
**IncidentCost** | **double** | The value of any quantifiable monetary loss directly resulting from the discipline incident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident. | [optional] 
**IncidentDescription** | **string** | The description for an incident. | [optional] 
**IncidentLocationDescriptor** | **string** | Identifies where the discipline incident occurred and whether or not it occurred on school. | [optional] 
**IncidentTime** | **string** | An indication of the time of day the incident took place. | [optional] 
**ReportedToLawEnforcement** | **bool** | Indicator of whether the incident was reported to law enforcement. | [optional] 
**ReporterDescriptionDescriptor** | **string** | Information on the type of individual who reported the discipline incident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;). | [optional] 
**ReporterName** | **string** | Identifies the reporter of the discipline incident by name. | [optional] 
**Weapons** | [**List&lt;EdFiDisciplineIncidentWeapon&gt;**](EdFiDisciplineIncidentWeapon.md) | An unordered collection of disciplineIncidentWeapons. Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the DisciplineIncident entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

