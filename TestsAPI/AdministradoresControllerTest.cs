using API_Copa_do_Mundo_2022.Controllers;
using API_Copa_do_Mundo_2022.Models;
using API_Copa_do_Mundo_2022.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TestsAPI.ClassTest;
using Xunit;

namespace TestsAPI
{
    public class AdministradoresControllerTest
    {
        AdministradoresController _controller;
        IAdministradoresController _service;
        DbContexto _db;
        public AdministradoresControllerTest()
        {
            _service = new AdministradoresControllerClass();
            _controller = new AdministradoresController(_db);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Administrador>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
