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
    /// A report of the id and an endpoint for checking the status of an
    /// operation
    /// </summary>
    public partial class OperationInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the OperationInfoResponse class.
        /// </summary>
        public OperationInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationInfoResponse class.
        /// </summary>
        /// <param name="id">the id of the operation</param>
        /// <param name="url">an endpoint for a summary of the
        /// operation</param>
        public OperationInfoResponse(System.Guid? id = default(System.Guid?), string url = default(string))
        {
            Id = id;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the operation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets an endpoint for a summary of the operation
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}