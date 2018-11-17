using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models
{
	//Instead of adding validation to the model classes
	//Validating here allows the validation to remain even 
	//if the database models are changed.
	public class StudentMetadata
	{
		[StringLength(50)]
		[Display(Name = "Last Name")]
		public string LastName;

		[StringLength(50)]
		[Display(Name = "First Name")]
		public string FirstName;

		[Display(Name = "Enrollment Date")]
		public Nullable<System.DateTime> EnrollmentDate;
	}

	public class EnrollmentMetadata
	{
		[Range(0, 4)]
		public Nullable<decimal> Grade;
	}
}