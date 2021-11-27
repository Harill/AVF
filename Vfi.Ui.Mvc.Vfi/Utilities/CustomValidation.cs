using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Vfi.Ui.Mvc.Vfi.Utilities
{
    public class CustomValidation
    {
    }

    public class LessThanOrEqualToPropertyAttribute : ValidationAttribute, IClientValidatable
    {
        public string OtherProperty { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var propertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);

                var otherValue = propertyInfo.GetGetMethod().Invoke(validationContext.ObjectInstance, null);

                if ((double)otherValue < (double)value)
                    return new ValidationResult(ErrorMessage);
            }
            return base.IsValid(value, validationContext);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ValidationType = "lessthanorequaltoproperty",
                ErrorMessage = FormatErrorMessage(ErrorMessage),
            };

            rule.ValidationParameters.Add("otherproperty", OtherProperty);

            yield return rule;
        }
    }
}