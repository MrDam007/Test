using Microsoft.AspNetCore.Mvc.Filters;

namespace Test.Midellwere
{
    public class TestFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("hi");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
         
        }
    }
}
