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
    /// Resize image with touch-from-outside semantics with automatic
    /// positioning of crop area using two different
    /// strategies
    /// </summary>
    [Newtonsoft.Json.JsonObject("Image_ResizeAutoCrop")]
    public partial class ImageResizeAutoCrop : TransformUnit
    {
        /// <summary>
        /// Initializes a new instance of the ImageResizeAutoCrop class.
        /// </summary>
        public ImageResizeAutoCrop()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageResizeAutoCrop class.
        /// </summary>
        /// <param name="width">Output width</param>
        /// <param name="height">Output height</param>
        /// <param name="strategy">Strategy used for positioning crop area.
        /// Possible values include: 'attention', 'entropy'</param>
        /// <param name="resizeKernel">The resampling algorithm used for
        /// resizing. Possible values include: 'lanczos3', 'lanczos2', 'cubic',
        /// 'nearest'</param>
        public ImageResizeAutoCrop(int width, int height, Strategy? strategy = default(Strategy?), ResizeKernel? resizeKernel = default(ResizeKernel?))
        {
            Width = width;
            Height = height;
            Strategy = strategy;
            ResizeKernel = resizeKernel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets output width
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets output height
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets strategy used for positioning crop area. Possible
        /// values include: 'attention', 'entropy'
        /// </summary>
        [JsonProperty(PropertyName = "strategy")]
        public Strategy? Strategy { get; set; }

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