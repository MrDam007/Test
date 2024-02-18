using Microsoft.AspNetCore.Mvc.Filters;

namespace Test.Midellwere
{
    public class FilterWithAttr: ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.Write("ssss");
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.Write("shayan");
            base.OnActionExecuting(context);
        }
    }
}
