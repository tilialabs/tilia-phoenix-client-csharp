# IO.Swagger.Model.AddProductEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name of the product | [optional] 
**Type** | **string** | Optional type of product: flat, tiled, bound, folded | [optional] 
**Color** | **string** | Product color specified as RGB or ARGB hex value with optional leading hex (&#x27;#&#x27;) symbol | [optional] 
**Ordered** | **int?** | Number of product ordered in the job | [optional] 
**Stock** | **string** | Stock of product | [optional] 
**Grade** | **string** | Grade of product stock | [optional] 
**Colors** | [**List&lt;PageColorEntity&gt;**](PageColorEntity.md) | Page colors for front side of flat products or all pages of bound and folded products | [optional] 
**BackColors** | [**List&lt;PageColorEntity&gt;**](PageColorEntity.md) | Page back colors for back side of flat products | [optional] 
**ColorSource** | **string** | Setting to specify how toset up colors for each page | [optional] 
**Grain** | **string** | Grain direction of product | [optional] 
**Width** | **string** | Width of product when creating a custom size product or the desired scaled width or scale percentage when creating the product die from a die design or artwork | [optional] 
**Height** | **string** | Height of product when creating a custom size product or the desired scaled height or scale percentage when creating the product die from a die design or artwork | [optional] 
**Rotation** | **string** | Rotation type to allow in product, defaults to Product settings defaults unless allowed-rotations is defined in which case &#x27;Custom&#x27; rotation type is assumed | [optional] 
**AllowedRotations** | **string** | Allowed rotations of product when rotation type is &#x27;Custom&#x27; | [optional] 
**Templates** | **List&lt;string&gt;** | List of templates this product can be used with | [optional] 
**ScaleProportionally** | **bool?** | Whether to scale proportionally when either width or height are not specified.  When false, only the dimension that is specified is scaled.  Defaults to false. | [optional] 
**Artwork** | **string** | Path to artwork file when creating product from artwork or snapping artwork into die | [optional] 
**Page** | **int?** | Page of artwork to use, defaults to page 1 when not defined | [optional] 
**BackArtwork** | **string** | Path to artwork file for back side of product when creating product from artwork or snapping artwork into die | [optional] 
**BackPage** | **int?** | Page of artwork to use for back side of product | [optional] 
**DieshapeSource** | **string** | Source type to use when creating dieshape for product.  If not defined, cad-file die takes priority, followed by dieshape library name, then height and width fields, and finally artwork Trimbox or artwork path line mappings depending on whether product settings automatically take dieshape from line mappings | [optional] 
**DieDesign** | **string** | Path to die in Die Design Library when using library die design for 1-up die of the product | [optional] 
**AutosnapInk** | **string** | PDF ink color to use for autosnapping artwork into 1-up die on the front side of the product | [optional] 
**BackAutosnapInk** | **string** | PDF ink color to use for autosnapping artwork into 1-up die on the back side of the product | [optional] 
**AutosnapLayer** | **string** | PDF layer to use for autosnapping artwork into 1-up die on the front side of the product | [optional] 
**BackAutosnapLayer** | **string** | PDF layer to use for autosnapping artwork into 1-up die on the back side of the product | [optional] 
**ShapeHandling** | **string** | Shape handling mode to use when finding closed path shapes from the dielines in the artwork.  &#x27;Multiple&#x27; mode will create a new product for each closed path shape detected in the artwork. | [optional] 
**PageHandling** | **string** | Multi-page artwork handling options for flat and tiled products | [optional] 
**FrontToBack** | **string** | Action to perform to copy or mirror artwork on the front side of the flat product to the back side | [optional] 
**CadFile** | **string** | Path of CAD file to use when defining product based on 1-up design in a CAD file | [optional] 
**CadDesign** | **string** | Design name of 1-up CAD design in the CAD file, defaults to first 1-up in the CAD file when not defined | [optional] 
**Group** | **string** | Optional product group used in Imposition AI | [optional] 
**Priority** | **int?** | Optional priority of product starting from 1 as highest priority | [optional] 
**DueDate** | **string** | Product due date | [optional] 
**BleedType** | **string** | Product bleed type &#x3D; [Margins, Contour, Cad, or None] | [optional] 
**BleedMargin** | **string** | Scalar offset from die design to generate bleed | [optional] 
**BleedMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**PageBleed** | **string** | Bleed margins of individual pages in bound and folded products | [optional] 
**SpacingType** | **string** | Product spacing type &#x3D; [Margins, Uniform, or Bleed] | [optional] 
**SpacingMargin** | **string** | Single scalar spacing offset when spacing type is Uniform | [optional] 
**SpacingMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**OffcutMargins** | [**MarginsEntity**](MarginsEntity.md) |  | [optional] 
**MinOverruns** | **string** | Minimum overrun percentage allowed for the product | [optional] 
**MaxOverruns** | **string** | Maximum overrun percentage allowed for the product | [optional] 
**Description** | **string** | Optional product description | [optional] 
**Notes** | **string** | Optional notes to associate with product | [optional] 
**ProcessSettings** | [**List&lt;ProcessSettingEntity&gt;**](ProcessSettingEntity.md) | List of process settings to use to control process-specific behavior | [optional] 
**Marks** | **List&lt;string&gt;** | Optional product marks to apply to the front side of the product | [optional] 
**BackMarks** | **List&lt;string&gt;** | Optional product marks to apply to the back side of the product | [optional] 
**FoldingPatterns** | **List&lt;string&gt;** | Optional folding bound work | [optional] 
**BindingMethod** | **string** | Optional binding method for bound work  | [optional] 
**BindingEdge** | **string** | Page binding edge for bound work | [optional] 
**JogEdge** | **string** | Jog edge for bound work.  When set, this edge must be perpendicular to the binding edge.  Setting jog to Bottom for left- or right-bound work results in &#x27;Foot to Foot&#x27; page orientation. | [optional] 
**ReadingOrder** | **string** | Reading order of pages in bound work | [optional] 
**Pages** | **int?** | Total number of pages field for bound and folded work | [optional] 
**PagesPerSection** | **int?** | Number of pages per section for multi-section bound work | [optional] 
**SelfCover** | **bool?** | Whether bound part includes cover or not | [optional] 
**Trim** | [**TrimEntity**](TrimEntity.md) |  | [optional] 
**NUp** | [**NUpEntity**](NUpEntity.md) |  | [optional] 
**Creep** | [**CreepEntity**](CreepEntity.md) |  | [optional] 
**BundleSize** | **int?** | Bundle size needed for product.  When set, Imposition AI tools will ensure layouts including this product will have run length multiples of this bundle size | [optional] 
**Properties** | [**List&lt;PropertyEntity&gt;**](PropertyEntity.md) | Optional custom properties to apply to the product | [optional] 
**Tiling** | [**Tiling**](Tiling.md) |  | [optional] 
**FrontInks** | **List&lt;string&gt;** | (Deprecated) Printing inks on front side of product | [optional] 
**BackInks** | **List&lt;string&gt;** | (Deprecated) Printing inks on back side of product | [optional] 
**CutInk** | **string** | (Deprecated) Spot ink color used to define cut lines in the artwork | [optional] 
**CreaseInk** | **string** | (Deprecated) Spot ink color used to define crease lines in the artwork | [optional] 
**BleedInk** | **string** | (Deprecated) Spot ink color used to define bleed lines in the artwork | [optional] 
**CutLayer** | **string** | (Deprecated) PDF layer name used to define cut lines in the artwork | [optional] 
**CreaseLayer** | **string** | (Deprecated) PDF layer name used to define crease lines in the artwork | [optional] 
**BleedLayer** | **string** | (Deprecated) PDF layer name used to define bleed lines in the artwork | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

