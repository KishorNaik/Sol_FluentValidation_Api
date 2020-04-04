using FluentValidation;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.ModelValidators
{
    public class UserCommunicationModelValidator : AbstractValidator<UserCommunicationModel>
    {
        public UserCommunicationModelValidator()
        {
            RuleFor(x => x.EmailId)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.MobileNo)
                .NotEmpty()
                .Must((mobileNo) => mobileNo.Length == 10)
                .WithMessage("Mobile no should be 10 digit no");

        }
    }
}
