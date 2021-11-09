using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatchDemo.Domain.responseModels
{
    public class BaseResponseModel
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
}
