using FluentValidation;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.ModelValidators
{
    public class UsersModelValidator : AbstractValidator<UsersModel>
    {
        public UsersModelValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(3, 50);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(3,50);

            RuleFor(x => x.UserCommunication)
                   .SetValidator(new UserCommunicationModelValidator());
        }
    }
}
