using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
	public class EventRegistration
	{
		[Required(ErrorMessage = "The FullName field is required.")]
		[MinLength(3, ErrorMessage = "The field FullName must be a string with a minimum length of 3 and a maximum length of 100.")]
		[Display(Name = "Full Name")]
		public string FullName { get; set; }
		[Required(ErrorMessage = "The Email field is required.")]
		[EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
		[Display(Name = "Email Address")]
		public string Email { get; set; }
		[Required(ErrorMessage = "The EventCode field is required.")]
		[StringLength(20, ErrorMessage = "The event code cannot be greater than 20 characters.")]
		[Display(Name = "Event Code")]
		public string EventCode { get; set; }
		[Required(ErrorMessage = "The Tickets field is required.")]
		[Range(1, 10, ErrorMessage = "The field Tickets must be between 1 and 10.")]
		[Display(Name = "Number of Tickets")]
		public int Tickets { get; set; }

		[Display(Name = "Referral Code (Optional)")]
		public string? ReferralCode { get; set; }
	}
}