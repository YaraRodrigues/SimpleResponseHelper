using System;

namespace ResponseHelper.Utils
{
    public class Response
    {
        public int HttpCode { get; set; }
        public bool IsSuccess { get; set; }
        public Object ResponseObject { get; set; }
        public Exception Exception { get; set; }

        public Object GetResponseBaseadOnHttpCode()
        {
            return IsSuccessHttpCode() ? ResponseObject : Exception;
        }

        public bool IsSuccessHttpCode()
        {
            return (HttpCode >= 200 && HttpCode < 300);
        }
    }
}
