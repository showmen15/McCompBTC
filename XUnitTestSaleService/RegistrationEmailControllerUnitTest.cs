using SaleService.Controllers;
using SaleService.Model;
using Xunit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace XUnitTestSaleService
{
    public class RegistrationEmailControllerUnitTest
    {
        [Theory]
        [MemberData(nameof(GetEmails))]
        public void TestRegistrationEmail(UserEmail mail, bool expected)
        { 
            var dbContext = DbContextMocker.GetDatabaseBTCContext("RegistrationEmailDatabaseBTC{0}");
            var controller = new RegistrationEmailController(dbContext);

            controller.Post(mail);

            var regUser = dbContext.RegisterUsers.FirstOrDefault(uu => uu.Name == mail.Name);
            var regEmail = dbContext.RegisterUsersEmails.FirstOrDefault(mm => mm.Email == mail.Email);
            var valCode = dbContext.ValidationCodes.FirstOrDefault(vc => vc.IdUser == regUser.IdUser);
            var valWallet = dbContext.Wallet.FirstOrDefault(w => w.IdCode == valCode.IdCode);

            Assert.Equal(expected, regUser != null);
            Assert.Equal(expected, regEmail != null);
            Assert.Equal(expected, valCode != null);
            Assert.Equal(expected, valWallet != null);

            dbContext.Dispose();
        }

        public static IEnumerable<object[]> GetEmails()
        {
            yield return new object[]
            {
                new UserEmail{ Email = "szsz@agh.edu.pl", Name = "Szymon", Surname = "Szomin" },
                true
            };
        }
    }
}
