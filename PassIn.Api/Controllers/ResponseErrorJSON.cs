using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PassIn.Api.Controllers
{
    internal class ResponseErrorJSON : ModelStateDictionary
    {
        private string message;

        public ResponseErrorJSON(string message)
        {
            this.message = message;
        }
    }
}