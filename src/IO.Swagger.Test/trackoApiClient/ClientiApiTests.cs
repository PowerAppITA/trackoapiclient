/* 
 * Tracko
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.trackoApiClient;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ClientiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ClientiApiTests
    {
        private ClientiApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClientiApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ClientiApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ClientiApi
            //Assert.IsInstanceOfType(typeof(ClientiApi), instance, "instance is a ClientiApi");
        }

        
        /// <summary>
        /// Test ClientiGetList
        /// </summary>
        [Test]
        public void ClientiGetListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ClientiGetList();
            //Assert.IsInstanceOf<BackofficeModelAPICommonDataSourceResult> (response, "response is BackofficeModelAPICommonDataSourceResult");
        }
        
    }

}
