// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pixelshift.Autorest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// a processing summary of an operation
    /// </summary>
    public partial class OperationStatusReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusReportResponse
        /// class.
        /// </summary>
        public OperationStatusReportResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusReportResponse
        /// class.
        /// </summary>
        /// <param name="created">when the operation was created</param>
        /// <param name="status">the current status of the operation. Possible
        /// values include: 'pending', 'failed', 'success'</param>
        /// <param name="error">if the operation has a status of "failed", this
        /// will contain an error message</param>
        /// <param name="elapsedMicroseconds">time taken for an
        /// operation</param>
        /// <param name="operationDescriptionUrl">an endpoint that provides the
        /// original operation parameters</param>
        public OperationStatusReportResponse(System.DateTime? created = default(System.DateTime?), OperationStatus? status = default(OperationStatus?), string error = default(string), double? elapsedMicroseconds = default(double?), string operationDescriptionUrl = default(string))
        {
            Created = created;
            Status = status;
            Error = error;
            ElapsedMicroseconds = elapsedMicroseconds;
            OperationDescriptionUrl = operationDescriptionUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets when the operation was created
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the current status of the operation. Possible values
        /// include: 'pending', 'failed', 'success'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets if the operation has a status of "failed", this will
        /// contain an error message
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets time taken for an operation
        /// </summary>
        [JsonProperty(PropertyName = "elapsedMicroseconds")]
        public double? ElapsedMicroseconds { get; set; }

        /// <summary>
        /// Gets or sets an endpoint that provides the original operation
        /// parameters
        /// </summary>
        [JsonProperty(PropertyName = "operationDescriptionUrl")]
        public string OperationDescriptionUrl { get; set; }

    }
}
