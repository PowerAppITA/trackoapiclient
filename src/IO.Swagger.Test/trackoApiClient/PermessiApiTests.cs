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
    ///  Class for testing PermessiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PermessiApiTests
    {
        private PermessiApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PermessiApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PermessiApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PermessiApi
            //Assert.IsInstanceOfType(typeof(PermessiApi), instance, "instance is a PermessiApi");
        }

        
        /// <summary>
        /// Test PermessiGetList
        /// </summary>
        [Test]
        public void PermessiGetListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackofficeModelAPIPermessiGetListRequestData oRequest = null;
            //var response = instance.PermessiGetList(oRequest);
            //Assert.IsInstanceOf<BackofficeModelAPIPermessiGetListResponseData> (response, "response is BackofficeModelAPIPermessiGetListResponseData");
        }
        
        /// <summary>
        /// Test PermessiSavePermessi
        /// </summary>
        [Test]
        public void PermessiSavePermessiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackofficeModelAPIPermessiSaveRequestData oRequest = null;
            //var response = instance.PermessiSavePermessi(oRequest);
            //Assert.IsInstanceOf<BackofficeModelAPICommonMessageModel> (response, "response is BackofficeModelAPICommonMessageModel");
        }
        
    }

}