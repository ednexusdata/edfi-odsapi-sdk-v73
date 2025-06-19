# EdFi.OdsApi.Sdk.v73.Models.All.EdFiReportCard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**GradePointAverages** | [**List&lt;EdFiReportCardGradePointAverage&gt;**](EdFiReportCardGradePointAverage.md) | An unordered collection of reportCardGradePointAverages. A measure of average performance for courses taken by an individual. | [optional] 
**Grades** | [**List&lt;EdFiReportCardGrade&gt;**](EdFiReportCardGrade.md) | An unordered collection of reportCardGrades. Grades for the classes attended by the student for this grading period. | [optional] 
**NumberOfDaysAbsent** | **double** | The number of days an individual is absent when school is in session during a given reporting period. | [optional] 
**NumberOfDaysInAttendance** | **double** | The number of days an individual is present when school is in session during a given reporting period. | [optional] 
**NumberOfDaysTardy** | **int** | The number of days an individual is tardy during a given reporting period. | [optional] 
**StudentCompetencyObjectives** | [**List&lt;EdFiReportCardStudentCompetencyObjective&gt;**](EdFiReportCardStudentCompetencyObjective.md) | An unordered collection of reportCardStudentCompetencyObjectives. The student competency evaluations associated for this grading period. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the ReportCard entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

