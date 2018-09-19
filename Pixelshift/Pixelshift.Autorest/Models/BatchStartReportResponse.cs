// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pixelshift.Autorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Report indicating if a batch has been successfully submitted, providing
    /// an endpoint to monitor batch progress
    /// </summary>
    public partial class BatchStartReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the BatchStartReportResponse class.
        /// </summary>
        public BatchStartReportResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchStartReportResponse class.
        /// </summary>
        /// <param name="success">indicates that that batch was successfully
        /// submitted</param>
        /// <param name="error">if the batch was not submitted successfully,
        /// there will be an error message</param>
        /// <param name="id">the id of the batch</param>
        /// <param name="statusEndpoint">if the batch was submitted
        /// successfully, the url of an endpoint for checking batch
        /// progress</param>
        /// <param name="operationIds">if the batch was submitted successfully,
        /// a list of the ids of submitted operations,
        /// in the same order as the submitted operations</param>
        public BatchStartReportResponse(bool? success = default(bool?), string error = default(string), System.Guid? id = default(System.Guid?), string statusEndpoint = default(string), IList<System.Guid?> operationIds = default(IList<System.Guid?>))
        {
            Success = success;
            Error = error;
            Id = id;
            StatusEndpoint = statusEndpoint;
            OperationIds = operationIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates that that batch was successfully submitted
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or sets if the batch was not submitted successfully, there
        /// will be an error message
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the id of the batch
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets if the batch was submitted successfully, the url of an
        /// endpoint for checking batch progress
        /// </summary>
        [JsonProperty(PropertyName = "statusEndpoint")]
        public string StatusEndpoint { get; set; }

        /// <summary>
        /// Gets or sets if the batch was submitted successfully, a list of the
        /// ids of submitted operations,
        /// in the same order as the submitted operations
        /// </summary>
        [JsonProperty(PropertyName = "operationIds")]
        public IList<System.Guid?> OperationIds { get; set; }

    }
}