namespace EmiApp
{
    public class Calculator : ICalculator
    {
        public Response CalculateDailyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount;
                var i = request.InterestRateInPercentage/100;
                var r = (double)p * Math.Pow(1 + (i / 365), 365 * t);
                response.EmiPayment = (decimal)r;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            throw new NotImplementedException();
        }
        public Response CalculateContinousEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount;
                var i = request.InterestRateInPercentage/100;
                double e = 2.7183;
                var d = (double)p * Math.Pow(e, (i * t));
                response.EmiPayment = (decimal)d;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            throw new NotImplementedException();
        }
        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 12, power);
                response.EmiPayment = (decimal)accumulated;
              
                // convert to response object
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }
    }
}
