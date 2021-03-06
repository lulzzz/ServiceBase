﻿namespace ServiceBase.Mvc.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class BadRequestFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is BadRequestObjectResult objResult)
            {
                objResult.Value = new ErrorModel
                {
                    Type = objResult.Value.GetType().Name,
                    Error = objResult.Value
                };
            }
        }
    }
}