using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Core.Utilities.Results
{
    public class SuccessResult: Result
    {
        public SuccessResult(string message) : base(true, message)
        { 
        }
        public SuccessResult() : base(true)
        { 
        }
    }
}
