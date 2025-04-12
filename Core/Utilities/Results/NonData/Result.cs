using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.NonData
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
        public Result(bool succuss, string message) : this(succuss)
        {
            Message = message;
        }
        public Result(bool succuss)
        {
            Success = succuss;
        }
    }
}
