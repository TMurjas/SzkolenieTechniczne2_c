﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation.Results;

namespace SzkolenieTechniczne2.Cinema.Domain
{
    public class Result 
    {
        private Result(bool isSuccess, string message, IEnumerable<Error> errors)
        {
            IsSuccess = isSuccess;
            IsFailure = !isSuccess;
            Message = message;
            Errors = errors ?? Enumerable.Empty<Error>();
        }

        public bool IsSuccess { get; }
        public bool IsFailure { get; }
        public string Message { get; }
        public IEnumerable<Error> Errors { get; }

        public static Result Ok()
        => new(true, string.Empty, Enumerable.Empty<Error>());

        public static Result Fail(string message)
            => new(false, message, Enumerable.Empty<Error>());

        public static Result Fail(ValidationResult validationResult)
        {
            var errors = validationResult.Errors
                .Select(x => new Error(x.PropertyName, x.ErrorMessage));

            var message = string.Join(", ", validationResult.Errors.Select(x => x.ErrorMessage));

            return new Result(false, message, errors);
        }


        public class Error
        {
            public Error(String propertyName, String message)
            {
                PropertyName = propertyName;
                Message = message;
            }

            public string PropertyName { get; }
            public string Message { get; }
        }



    }



}
