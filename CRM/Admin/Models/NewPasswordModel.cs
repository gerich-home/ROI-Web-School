namespace Crm.Admin.Models
{
<<<<<<< HEAD
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public struct NewPasswordModel : IValidatableObject
	{
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			return new[] {
				Password == ConfirmPassword
=======
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class NewPasswordModel : IValidatableObject
	{
		private string _value;
		private string _confirmation;

		[Display(Name = "Enter")]
		[DataType(DataType.Password)]
		public string Value
		{
			get { return IsConfirmed ? _value : string.Empty; }
			set { _value = value; }
		}

		[Display(Name = "Confirm")]
		[DataType(DataType.Password)]
		public string Confirmation
		{
			get { return IsConfirmed ? _confirmation : string.Empty; }
			set { _confirmation = value; }
		}

		public bool IsConfirmed { get { return _value == Confirmation; } }

		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			return new[] {
				Value == Confirmation
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
					? ValidationResult.Success
					: new ValidationResult(
						"Password and Confirmation Password must match.",
						new[] {"Password", "ConfirmPassword"}
					)
			};
		}
<<<<<<< HEAD
=======

		public static implicit operator string(NewPasswordModel model)
		{
			if (!model.IsConfirmed)
				throw new InvalidOperationException("Password is incorrectly confirmed.");
			return model.Value;
		}
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
	}
}