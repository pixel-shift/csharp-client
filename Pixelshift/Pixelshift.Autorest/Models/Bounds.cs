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
    /// Object used to represent border thickness.
    /// </summary>
    public partial class Bounds
    {
        /// <summary>
        /// Initializes a new instance of the Bounds class.
        /// </summary>
        public Bounds()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Bounds class.
        /// </summary>
        /// <param name="top">Width of top border.</param>
        /// <param name="left">Width of left border.</param>
        /// <param name="bottom">Width of bottom border.</param>
        /// <param name="right">Width of right border</param>
        public Bounds(int top, int left, int bottom, int right)
        {
            Top = top;
            Left = left;
            Bottom = bottom;
            Right = right;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets width of top border.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int Top { get; set; }

        /// <summary>
        /// Gets or sets width of left border.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int Left { get; set; }

        /// <summary>
        /// Gets or sets width of bottom border.
        /// </summary>
        [JsonProperty(PropertyName = "bottom")]
        public int Bottom { get; set; }

        /// <summary>
        /// Gets or sets width of right border
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public int Right { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Top > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Top", 1000);
            }
            if (Top < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Top", 0);
            }
            if (Left > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Left", 1000);
            }
            if (Left < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Left", 0);
            }
            if (Bottom > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Bottom", 1000);
            }
            if (Bottom < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Bottom", 0);
            }
            if (Right > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Right", 1000);
            }
            if (Right < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Right", 0);
            }
        }
    }
}
