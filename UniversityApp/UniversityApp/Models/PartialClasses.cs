using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models
	//Associating model classes with the metadata classes
{
	[MetadataType(typeof(StudentMetadata))]
	public partial class Student
	{
	}

	[MetadataType(typeof(EnrollmentMetadata))]
	public partial class Enrollment
	{
	}
}
//Notice that each class is marked as a partial class, and each matches
//the name and namespace as the class that is automatically generated.
//By applying the metadata attribute to the partial class, you ensure that
//the data validation attributes will be applied to the automatically-generated class.
//These attributes will not be lost when you regenerate the model classes because the
//metadata attribute is applied in partial classes that are not regenerated.