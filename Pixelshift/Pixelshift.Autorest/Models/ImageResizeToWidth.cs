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
    /// Resize the image to a specific width. Height will depend on aspect
    /// ratio of image.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Image_ResizeToWidth")]
    public partial class ImageResizeToWidth : TransformUnit
    {
        /// <summary>
        /// Initializes a new instance of the ImageResizeToWidth class.
        /// </summary>
        public ImageResizeToWidth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageResizeToWidth class.
        /// </summary>
        /// <param name="resizeKernel">The resampling algorithm used for
        /// resizing. Possible values include: 'lanczos3', 'lanczos2', 'cubic',
        /// 'nearest'</param>
        public ImageResizeToWidth(int width, ResizeKernel? resizeKernel = default(ResizeKernel?))
        {
            Width = width;
            ResizeKernel = resizeKernel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the resampling algorithm used for resizing. Possible
        /// values include: 'lanczos3', 'lanczos2', 'cubic', 'nearest'
        /// </summary>
        [JsonProperty(PropertyName = "resizeKernel")]
        public ResizeKernel? ResizeKernel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}