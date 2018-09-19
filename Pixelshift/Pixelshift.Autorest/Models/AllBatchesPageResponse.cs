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
    /// a model for a long list of batches with potential future paging support
    /// </summary>
    public partial class AllBatchesPageResponse
    {
        /// <summary>
        /// Initializes a new instance of the AllBatchesPageResponse class.
        /// </summary>
        public AllBatchesPageResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AllBatchesPageResponse class.
        /// </summary>
        /// <param name="pageIndex">the current page (0 based)</param>
        /// <param name="totalPages">the total number of pages</param>
        /// <param name="batches">a list of batches with urls for individual
        /// batch reports</param>
        public AllBatchesPageResponse(int? pageIndex = default(int?), int? totalPages = default(int?), IList<BatchLinkResponse> batches = default(IList<BatchLinkResponse>))
        {
            PageIndex = pageIndex;
            TotalPages = totalPages;
            Batches = batches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current page (0 based)
        /// </summary>
        [JsonProperty(PropertyName = "pageIndex")]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the total number of pages
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets a list of batches with urls for individual batch
        /// reports
        /// </summary>
        [JsonProperty(PropertyName = "batches")]
        public IList<BatchLinkResponse> Batches { get; set; }

    }
}
