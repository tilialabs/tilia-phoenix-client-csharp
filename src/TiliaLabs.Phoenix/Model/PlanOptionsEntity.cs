/* 
 * tilia Phoenix API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TiliaLabs.Phoenix.Client.SwaggerDateConverter;

namespace TiliaLabs.Phoenix.Model
{
    /// <summary>
    /// Settings used for plans
    /// </summary>
    [DataContract]
        public partial class PlanOptionsEntity :  IEquatable<PlanOptionsEntity>, IValidatableObject
    {
        /// <summary>
        /// Plan mode
        /// </summary>
        /// <value>Plan mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PlanModeEnum
        {
            /// <summary>
            /// Enum Standard for value: Standard
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard = 1,
            /// <summary>
            /// Enum LayoutByLayout for value: LayoutByLayout
            /// </summary>
            [EnumMember(Value = "LayoutByLayout")]
            LayoutByLayout = 2,
            /// <summary>
            /// Enum Sequential for value: Sequential
            /// </summary>
            [EnumMember(Value = "Sequential")]
            Sequential = 3,
            /// <summary>
            /// Enum CutAndStack for value: CutAndStack
            /// </summary>
            [EnumMember(Value = "CutAndStack")]
            CutAndStack = 4,
            /// <summary>
            /// Enum Lanes for value: Lanes
            /// </summary>
            [EnumMember(Value = "Lanes")]
            Lanes = 5        }
        /// <summary>
        /// Plan mode
        /// </summary>
        /// <value>Plan mode</value>
        [DataMember(Name="plan-mode", EmitDefaultValue=false)]
        public PlanModeEnum? PlanMode { get; set; }
        /// <summary>
        /// Finishing
        /// </summary>
        /// <value>Finishing</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FinishingEnum
        {
            /// <summary>
            /// Enum Inline for value: Inline
            /// </summary>
            [EnumMember(Value = "Inline")]
            Inline = 1,
            /// <summary>
            /// Enum Nearline for value: Nearline
            /// </summary>
            [EnumMember(Value = "Nearline")]
            Nearline = 2        }
        /// <summary>
        /// Finishing
        /// </summary>
        /// <value>Finishing</value>
        [DataMember(Name="finishing", EmitDefaultValue=false)]
        public FinishingEnum? Finishing { get; set; }
        /// <summary>
        /// Stacking order
        /// </summary>
        /// <value>Stacking order</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StackingOrderEnum
        {
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,
            /// <summary>
            /// Enum Reverse for value: Reverse
            /// </summary>
            [EnumMember(Value = "Reverse")]
            Reverse = 2        }
        /// <summary>
        /// Stacking order
        /// </summary>
        /// <value>Stacking order</value>
        [DataMember(Name="stacking-order", EmitDefaultValue=false)]
        public StackingOrderEnum? StackingOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanOptionsEntity" /> class.
        /// </summary>
        /// <param name="planMode">Plan mode.</param>
        /// <param name="stackSize">Stack size.</param>
        /// <param name="finishing">Finishing.</param>
        /// <param name="stackingOrder">Stacking order.</param>
        /// <param name="allowProductSpanning">Allow product spanning.</param>
        /// <param name="allowMultiplePressPasses">Allow multiple passes through press devices during printing.</param>
        /// <param name="fixedRunLength">Fixed run length.</param>
        public PlanOptionsEntity(PlanModeEnum? planMode = default(PlanModeEnum?), int? stackSize = default(int?), FinishingEnum? finishing = default(FinishingEnum?), StackingOrderEnum? stackingOrder = default(StackingOrderEnum?), bool? allowProductSpanning = default(bool?), bool? allowMultiplePressPasses = default(bool?), int? fixedRunLength = default(int?))
        {
            this.PlanMode = planMode;
            this.StackSize = stackSize;
            this.Finishing = finishing;
            this.StackingOrder = stackingOrder;
            this.AllowProductSpanning = allowProductSpanning;
            this.AllowMultiplePressPasses = allowMultiplePressPasses;
            this.FixedRunLength = fixedRunLength;
        }
        

        /// <summary>
        /// Stack size
        /// </summary>
        /// <value>Stack size</value>
        [DataMember(Name="stack-size", EmitDefaultValue=false)]
        public int? StackSize { get; set; }



        /// <summary>
        /// Allow product spanning
        /// </summary>
        /// <value>Allow product spanning</value>
        [DataMember(Name="allow-product-spanning", EmitDefaultValue=false)]
        public bool? AllowProductSpanning { get; set; }

        /// <summary>
        /// Allow multiple passes through press devices during printing
        /// </summary>
        /// <value>Allow multiple passes through press devices during printing</value>
        [DataMember(Name="allow-multiple-press-passes", EmitDefaultValue=false)]
        public bool? AllowMultiplePressPasses { get; set; }

        /// <summary>
        /// Fixed run length
        /// </summary>
        /// <value>Fixed run length</value>
        [DataMember(Name="fixed-run-length", EmitDefaultValue=false)]
        public int? FixedRunLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanOptionsEntity {\n");
            sb.Append("  PlanMode: ").Append(PlanMode).Append("\n");
            sb.Append("  StackSize: ").Append(StackSize).Append("\n");
            sb.Append("  Finishing: ").Append(Finishing).Append("\n");
            sb.Append("  StackingOrder: ").Append(StackingOrder).Append("\n");
            sb.Append("  AllowProductSpanning: ").Append(AllowProductSpanning).Append("\n");
            sb.Append("  AllowMultiplePressPasses: ").Append(AllowMultiplePressPasses).Append("\n");
            sb.Append("  FixedRunLength: ").Append(FixedRunLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlanOptionsEntity);
        }

        /// <summary>
        /// Returns true if PlanOptionsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanOptionsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanOptionsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanMode == input.PlanMode ||
                    (this.PlanMode != null &&
                    this.PlanMode.Equals(input.PlanMode))
                ) && 
                (
                    this.StackSize == input.StackSize ||
                    (this.StackSize != null &&
                    this.StackSize.Equals(input.StackSize))
                ) && 
                (
                    this.Finishing == input.Finishing ||
                    (this.Finishing != null &&
                    this.Finishing.Equals(input.Finishing))
                ) && 
                (
                    this.StackingOrder == input.StackingOrder ||
                    (this.StackingOrder != null &&
                    this.StackingOrder.Equals(input.StackingOrder))
                ) && 
                (
                    this.AllowProductSpanning == input.AllowProductSpanning ||
                    (this.AllowProductSpanning != null &&
                    this.AllowProductSpanning.Equals(input.AllowProductSpanning))
                ) && 
                (
                    this.AllowMultiplePressPasses == input.AllowMultiplePressPasses ||
                    (this.AllowMultiplePressPasses != null &&
                    this.AllowMultiplePressPasses.Equals(input.AllowMultiplePressPasses))
                ) && 
                (
                    this.FixedRunLength == input.FixedRunLength ||
                    (this.FixedRunLength != null &&
                    this.FixedRunLength.Equals(input.FixedRunLength))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PlanMode != null)
                    hashCode = hashCode * 59 + this.PlanMode.GetHashCode();
                if (this.StackSize != null)
                    hashCode = hashCode * 59 + this.StackSize.GetHashCode();
                if (this.Finishing != null)
                    hashCode = hashCode * 59 + this.Finishing.GetHashCode();
                if (this.StackingOrder != null)
                    hashCode = hashCode * 59 + this.StackingOrder.GetHashCode();
                if (this.AllowProductSpanning != null)
                    hashCode = hashCode * 59 + this.AllowProductSpanning.GetHashCode();
                if (this.AllowMultiplePressPasses != null)
                    hashCode = hashCode * 59 + this.AllowMultiplePressPasses.GetHashCode();
                if (this.FixedRunLength != null)
                    hashCode = hashCode * 59 + this.FixedRunLength.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}