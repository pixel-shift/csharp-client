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
    /// Resize image with touch-from-outside semantics where width and height
    /// represent minimums. e.g. the image will
    /// be no smaller that the bounding-box.
    /// Aspect ratio is preserved, so image will be larger than or equal to the
    /// bounding box in one dimension, and
    /// exactly fit the other dimension
    /// </summary>
    [Newtonsoft.Json.JsonObject("Image_ResizeMin")]
    public partial class ImageResizeMin : TransformUnit
    {
        /// <summary>
        /// Initializes a new instance of the ImageResizeMin class.
        /// </summary>
        public ImageResizeMin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageResizeMin class.
        /// </summary>
        /// <param name="width">Minimum width</param>
        /// <param name="height">Minimum height</param>
        /// <param name="resizeKernel">The resampling algorithm used for
        /// resizing. Possible values include: 'lanczos3', 'lanczos2', 'cubic',
        /// 'nearest'</param>
        public ImageResizeMin(int width, int height, ResizeKernel? resizeKernel = default(ResizeKernel?))
        {
            Width = width;
            Height = height;
            ResizeKernel = resizeKernel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum width
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets minimum height
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

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
