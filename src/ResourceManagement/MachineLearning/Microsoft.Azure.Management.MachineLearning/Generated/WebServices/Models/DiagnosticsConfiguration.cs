// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Diagnostics settings for an Azure ML web service.
    /// </summary>
    public partial class DiagnosticsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsConfiguration class.
        /// </summary>
        public DiagnosticsConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsConfiguration class.
        /// </summary>
        /// <param name="level">Specifies the verbosity of the diagnostic
        /// output. Valid values are: None - disables tracing; Error -
        /// collects only error (stderr) traces; All - collects all traces
        /// (stdout and stderr). Possible values include: 'None', 'Error',
        /// 'All'</param>
        /// <param name="expiry">Specifies the date and time when the logging
        /// will cease. If null, diagnostic collection is not time
        /// limited.</param>
        public DiagnosticsConfiguration(string level, System.DateTime? expiry = default(System.DateTime?))
        {
            Level = level;
            Expiry = expiry;
        }

        /// <summary>
        /// Gets or sets specifies the verbosity of the diagnostic output.
        /// Valid values are: None - disables tracing; Error - collects only
        /// error (stderr) traces; All - collects all traces (stdout and
        /// stderr). Possible values include: 'None', 'Error', 'All'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets specifies the date and time when the logging will
        /// cease. If null, diagnostic collection is not time limited.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiry")]
        public System.DateTime? Expiry { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Level == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Level");
            }
        }
    }
}
