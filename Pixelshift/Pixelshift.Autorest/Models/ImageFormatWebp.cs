// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pixelshift.Autorest.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output to Webp
    /// </summary>
    [Newtonsoft.Json.JsonObject("ImageFormat_Webp")]
    public partial class ImageFormatWebp : TransformUnit
    {
        /// <summary>
        /// Initializes a new instance of the ImageFormatWebp class.
        /// </summary>
        public ImageFormatWebp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageFormatWebp class.
        /// </summary>
        /// <param name="quality">Webp compression level</param>
        public ImageFormatWebp(int? quality = default(int?))
        {
            Quality = quality;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets webp compression level
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public int? Quality { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Quality > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Quality", 100);
            }
            if (Quality < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Quality", 1);
            }
        }
    }
}