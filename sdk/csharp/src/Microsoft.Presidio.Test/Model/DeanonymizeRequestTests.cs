/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;
using Microsoft.Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Test.Model
{
    /// <summary>
    ///  Class for testing DeanonymizeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DeanonymizeRequestTests : IDisposable
    {
        private DeanonymizeRequest instance;
        private Dictionary<string, object> deanonymizers;
        private List<AnonymizerResult> results;

        public DeanonymizeRequestTests()
        {
            var decrypt = new Decrypt("decrypt", "3t6w9z$C&F)J@NcR");
            deanonymizers = new Dictionary<string, object>() {{"PERSON", decrypt}};
            var anonymizerResult = new AnonymizerResult(start: 11, end: 55, entityType: "PERSON");
            results = new List<AnonymizerResult>() {anonymizerResult};
            instance = new DeanonymizeRequest(text: "hello world", deanonymizers: deanonymizers, anonymizerResults: results);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeanonymizeRequest
        /// </summary>
        [Fact]
        public void DeanonymizeRequestInstanceTest()
        {
            Assert.IsInstanceOfType(typeof(DeanonymizeRequest),instance, "variable 'instance' is a DeanonymizeRequest");
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            Assert.IsTrue(instance.Text == "hello world");
        }
        /// <summary>
        /// Test the property 'Deanonymizers'
        /// </summary>
        [Fact]
        public void DeanonymizersTest()
        {
            Assert.IsTrue(instance.Deanonymizers == deanonymizers);
        }
        /// <summary>
        /// Test the property 'AnonymizerResults'
        /// </summary>
        [Fact]
        public void AnonymizerResultsTest()
        {
            Assert.IsTrue(instance.AnonymizerResults == results);
        }

    }

}
