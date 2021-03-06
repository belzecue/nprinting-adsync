/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Net;
using NUnit.Framework;
using Qlik.NPrinting.Rest.Client.Api;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;

namespace Qlik.NPrinting.Rest.Client.Test.Api
{
    
    /// <summary>
    ///  Class for testing AppsApi
    /// </summary>
    [TestFixture]
    internal class AppsApiTests : BaseNPrintingClinetTest
    {
        private AppsApi _instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            _instance = new AppsApi(NprintingApiClient);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AppsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AppsApi>(_instance, "response is AppsApi");
        }


        /// <summary>
        /// Test AppsGet
        /// </summary>
        [Test]
        public void AppsGetTest()
        {
            var response = _instance.AppsGet();
            Assert.IsInstanceOf<AppListResponse>(response, "response is AppListResponse");
        }

        /// <summary>
        /// Test AppsIdInvalidGetTest
        /// </summary>
        [Test(Description = "Should get an error (404 Not Found) trying to get a not existing App.")]
        public void AppsIdInvalidGetTest()
        {
            Guid id = Guid.NewGuid();
            var ex = Assert.Throws<ApiException>(() => _instance.AppsIdGet(id));
            Assert.That(ex.ErrorCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        /// <summary>
        /// Test AppsIdGetTest
        /// </summary>
        [Test(Description = "Get the App by Id")]
        public void AppsIdGetTest()
        {
            var appListResponse = _instance.AppsGet();
            var appResponse =  _instance.AppsIdGetWithHttpInfo(appListResponse.Data.Items[0].Id);
            Assert.That(appResponse.StatusCode, Is.EqualTo((int) HttpStatusCode.OK));
        }
    }
    
}
