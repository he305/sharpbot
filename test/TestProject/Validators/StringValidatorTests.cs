using Xunit;
using Common.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions;

namespace Common.Validators.Tests
{
    public class StringValidatorTests
    {
        [Fact()]
        public void ValidateEmptyShouldFail()
        {
            string str = "";
            Assert.Throws<StringValidationException>(() => StringValidator.Validate(str));
        }

        [Fact()]
        public void ValidateWhiteSpacesShouldFail() {
            string str = "\t\n";
            Assert.Throws<StringValidationException>(() => StringValidator.Validate(str));
        }

        [Fact()]
        public void ValidateOk() {
            string str = "1\t";

            var exception = Record.Exception(() => StringValidator.Validate(str));
            Assert.Null(exception);
        }
    }
}