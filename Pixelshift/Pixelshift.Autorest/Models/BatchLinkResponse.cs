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
    /// A summary with a url for a status report on a specific batch id
    /// </summary>
    public partial class BatchLinkResponse
    {
        /// <summary>
        /// Initializes a new instance of the BatchLinkResponse class.
        /// </summary>
        public BatchLinkResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchLinkResponse class.
        /// </summary>
        /// <param name="batchId">the id of the batch</param>
        /// <param name="created">the time that the batch was submitted</param>
        /// <param name="url">a url for a status report on the batch</param>
        public BatchLinkResponse(System.Guid? batchId = default(System.Guid?), System.DateTime? created = default(System.DateTime?), string url = default(string))
        {
            BatchId = batchId;
            Created = created;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the batch
        /// </summary>
        [JsonProperty(PropertyName = "batchId")]
        public System.Guid? BatchId { get; set; }

        /// <summary>
        /// Gets or sets the time that the batch was submitted
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets a url for a status report on the batch
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
