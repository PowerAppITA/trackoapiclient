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
    ///  Class for testing ExternalMailerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExternalMailerApiTests
    {
        private ExternalMailerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExternalMailerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalMailerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExternalMailerApi
            //Assert.IsInstanceOfType(typeof(ExternalMailerApi), instance, "instance is a ExternalMailerApi");
        }

        
        /// <summary>
        /// Test ExternalMailerHandlerMailup
        /// </summary>
        [Test]
        public void ExternalMailerHandlerMailupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary<string, string> message = null;
            //var response = instance.ExternalMailerHandlerMailup(message);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test ExternalMailerUpdateRequestStatus
        /// </summary>
        [Test]
        public void ExternalMailerUpdateRequestStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackofficeModelWSAPIHooksHandlerMailupData oMailUpObj = null;
            //var response = instance.ExternalMailerUpdateRequestStatus(oMailUpObj);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
    }

}
