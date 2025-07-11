﻿using Project2144.Models.TokenAuth;
using Project2144.Web.Controllers;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Project2144.Web.Tests.Controllers;

public class HomeController_Tests : Project2144WebTestBase
{
    [Fact]
    public async Task Index_Test()
    {
        await AuthenticateAsync(null, new AuthenticateModel
        {
            UserNameOrEmailAddress = "admin",
            Password = "123qwe"
        });

        //Act
        var response = await GetResponseAsStringAsync(
            GetUrl<HomeController>(nameof(HomeController.Index))
        );

        //Assert
        response.ShouldNotBeNullOrEmpty();
    }
}