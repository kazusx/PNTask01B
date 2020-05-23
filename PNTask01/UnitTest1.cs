using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PNTask01
{

    public class UnitTest1
    {

        [Test]
        public async void VNPayTest()
        {
            IPaymentService service = new VNPayService(new VNPayService.Setting());//MOMOService();
            //register. call user registration process ( ex. show GUI)
            var id = await service.RegisterUser();
            //pay 
            service.Pay(id, "Payment for item1", 10000, "VND");
            //deposit
            var transactionOrError2 = service.Pay(id, "Deposit for item2", 10000, "VND", true);
            //deduct (pay 5000, return 5000)
            service.DeductFromDeposit(transactionOrError2.Item1, 5000);
            //unregister
            service.UnregisterUser(id);
        }

        [Test]
        public void TimeSpanExtendedTest()
        {
            var extended = new TimeUtil.DateTimeSpan()
                    { From = new DateTime(2020,4,1), To = new DateTime(2020,4,30)}
                .GetTimeSpanExtended();
			
            var extended2 = new TimeUtil.DateTimeSpan()
                    { From = new DateTime(2000,5,1), To = new DateTime(2000,5,31)}
                .GetTimeSpanExtended();
			
            var extended3 = new TimeUtil.DateTimeSpan()
                    { From = new DateTime(2000,5,1), To = new DateTime(2000,6,1)}
                .GetTimeSpanExtended();
			
            var extended4 = new TimeUtil.DateTimeSpan()
                    { From = new DateTime(2020,1,1), To = new DateTime(2021,2,1)}
                .GetTimeSpanExtended();
			
            Assert.IsTrue(extended.ToStringEx() == "1Months"); 
            Assert.IsTrue(extended2.ToStringEx() == "1Months");
            Assert.IsTrue(extended3.ToStringEx() == "1Months 1Days");
            Assert.IsTrue(extended4.ToStringEx() == "1Years 1Months 1Days");
            Assert.IsTrue(extended4.ToStringEx(true) == "1Years");
			
        }

    }
}