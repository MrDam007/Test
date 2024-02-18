namespace Test.Midellwere
{
    public class ErorHandelerMidellwere
    {
        public RequestDelegate _Next { get; set; }

        public ErorHandelerMidellwere(RequestDelegate next)
        {
            _Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Middleware logic goes here
            try
            {
                Console.WriteLine("Requestiscomming");

                await _Next(context);
            }
            catch (Exception)
            {
                Console.WriteLine("YouHaveError");
                context.Response.WriteAsync("You Have Error Depen");
            }
        }
    }
}
