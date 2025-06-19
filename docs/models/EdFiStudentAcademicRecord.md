# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentAcademicRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermDescriptor** | **string** | The term for the session during the school year. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AcademicHonors** | [**List&lt;EdFiStudentAcademicRecordAcademicHonor&gt;**](EdFiStudentAcademicRecordAcademicHonor.md) | An unordered collection of studentAcademicRecordAcademicHonors. Academic distinctions earned by or awarded to the student. | [optional] 
**ClassRanking** | [**EdFiStudentAcademicRecordClassRanking**](EdFiStudentAcademicRecordClassRanking.md) |  | [optional] 
**CumulativeAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**CumulativeAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**CumulativeEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**Diplomas** | [**List&lt;EdFiStudentAcademicRecordDiploma&gt;**](EdFiStudentAcademicRecordDiploma.md) | An unordered collection of studentAcademicRecordDiplomas. Diploma(s) earned by the student. | [optional] 
**GradePointAverages** | [**List&lt;EdFiStudentAcademicRecordGradePointAverage&gt;**](EdFiStudentAcademicRecordGradePointAverage.md) | An unordered collection of studentAcademicRecordGradePointAverages. The grade point average for an individual computed as the grade points earned divided by the number of credits attempted. | [optional] 
**ProjectedGraduationDate** | **DateOnly** | The month and year the student is projected to graduate. | [optional] 
**Recognitions** | [**List&lt;EdFiStudentAcademicRecordRecognition&gt;**](EdFiStudentAcademicRecordRecognition.md) | An unordered collection of studentAcademicRecordRecognitions. Recognitions given to the student for accomplishments in a co-curricular or extracurricular activity. | [optional] 
**ReportCards** | [**List&lt;EdFiStudentAcademicRecordReportCard&gt;**](EdFiStudentAcademicRecordReportCard.md) | An unordered collection of studentAcademicRecordReportCards. Report cards for the student. | [optional] 
**SessionAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**SessionAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**SessionAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**SessionEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**SessionEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**SessionEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentAcademicRecord entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

