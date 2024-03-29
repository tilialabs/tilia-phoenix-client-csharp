/* 
 * tilia Phoenix API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TiliaLabs.Phoenix.Api;
using TiliaLabs.Phoenix.Model;
using TiliaLabs.Phoenix.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TiliaLabs.Phoenix.Test
{
    /// <summary>
    ///  Class for testing AddProductEntity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AddProductEntityTests
    {
        // TODO uncomment below to declare an instance variable for AddProductEntity
        //private AddProductEntity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AddProductEntity
            //instance = new AddProductEntity();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddProductEntity
        /// </summary>
        [Test]
        public void AddProductEntityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AddProductEntity
            //Assert.IsInstanceOfType<AddProductEntity> (instance, "variable 'instance' is a AddProductEntity");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Test]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }
        /// <summary>
        /// Test the property 'Ordered'
        /// </summary>
        [Test]
        public void OrderedTest()
        {
            // TODO unit test for the property 'Ordered'
        }
        /// <summary>
        /// Test the property 'Stock'
        /// </summary>
        [Test]
        public void StockTest()
        {
            // TODO unit test for the property 'Stock'
        }
        /// <summary>
        /// Test the property 'Grade'
        /// </summary>
        [Test]
        public void GradeTest()
        {
            // TODO unit test for the property 'Grade'
        }
        /// <summary>
        /// Test the property 'Colors'
        /// </summary>
        [Test]
        public void ColorsTest()
        {
            // TODO unit test for the property 'Colors'
        }
        /// <summary>
        /// Test the property 'BackColors'
        /// </summary>
        [Test]
        public void BackColorsTest()
        {
            // TODO unit test for the property 'BackColors'
        }
        /// <summary>
        /// Test the property 'ColorSource'
        /// </summary>
        [Test]
        public void ColorSourceTest()
        {
            // TODO unit test for the property 'ColorSource'
        }
        /// <summary>
        /// Test the property 'Grain'
        /// </summary>
        [Test]
        public void GrainTest()
        {
            // TODO unit test for the property 'Grain'
        }
        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Test]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Test]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'Rotation'
        /// </summary>
        [Test]
        public void RotationTest()
        {
            // TODO unit test for the property 'Rotation'
        }
        /// <summary>
        /// Test the property 'AllowedRotations'
        /// </summary>
        [Test]
        public void AllowedRotationsTest()
        {
            // TODO unit test for the property 'AllowedRotations'
        }
        /// <summary>
        /// Test the property 'Templates'
        /// </summary>
        [Test]
        public void TemplatesTest()
        {
            // TODO unit test for the property 'Templates'
        }
        /// <summary>
        /// Test the property 'ScaleProportionally'
        /// </summary>
        [Test]
        public void ScaleProportionallyTest()
        {
            // TODO unit test for the property 'ScaleProportionally'
        }
        /// <summary>
        /// Test the property 'Artwork'
        /// </summary>
        [Test]
        public void ArtworkTest()
        {
            // TODO unit test for the property 'Artwork'
        }
        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Test]
        public void PageTest()
        {
            // TODO unit test for the property 'Page'
        }
        /// <summary>
        /// Test the property 'BackArtwork'
        /// </summary>
        [Test]
        public void BackArtworkTest()
        {
            // TODO unit test for the property 'BackArtwork'
        }
        /// <summary>
        /// Test the property 'BackPage'
        /// </summary>
        [Test]
        public void BackPageTest()
        {
            // TODO unit test for the property 'BackPage'
        }
        /// <summary>
        /// Test the property 'DieshapeSource'
        /// </summary>
        [Test]
        public void DieshapeSourceTest()
        {
            // TODO unit test for the property 'DieshapeSource'
        }
        /// <summary>
        /// Test the property 'DieDesign'
        /// </summary>
        [Test]
        public void DieDesignTest()
        {
            // TODO unit test for the property 'DieDesign'
        }
        /// <summary>
        /// Test the property 'AutosnapInk'
        /// </summary>
        [Test]
        public void AutosnapInkTest()
        {
            // TODO unit test for the property 'AutosnapInk'
        }
        /// <summary>
        /// Test the property 'BackAutosnapInk'
        /// </summary>
        [Test]
        public void BackAutosnapInkTest()
        {
            // TODO unit test for the property 'BackAutosnapInk'
        }
        /// <summary>
        /// Test the property 'AutosnapLayer'
        /// </summary>
        [Test]
        public void AutosnapLayerTest()
        {
            // TODO unit test for the property 'AutosnapLayer'
        }
        /// <summary>
        /// Test the property 'BackAutosnapLayer'
        /// </summary>
        [Test]
        public void BackAutosnapLayerTest()
        {
            // TODO unit test for the property 'BackAutosnapLayer'
        }
        /// <summary>
        /// Test the property 'ShapeHandling'
        /// </summary>
        [Test]
        public void ShapeHandlingTest()
        {
            // TODO unit test for the property 'ShapeHandling'
        }
        /// <summary>
        /// Test the property 'PageHandling'
        /// </summary>
        [Test]
        public void PageHandlingTest()
        {
            // TODO unit test for the property 'PageHandling'
        }
        /// <summary>
        /// Test the property 'FrontToBack'
        /// </summary>
        [Test]
        public void FrontToBackTest()
        {
            // TODO unit test for the property 'FrontToBack'
        }
        /// <summary>
        /// Test the property 'CadFile'
        /// </summary>
        [Test]
        public void CadFileTest()
        {
            // TODO unit test for the property 'CadFile'
        }
        /// <summary>
        /// Test the property 'CadDesign'
        /// </summary>
        [Test]
        public void CadDesignTest()
        {
            // TODO unit test for the property 'CadDesign'
        }
        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Test]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Test]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'BleedType'
        /// </summary>
        [Test]
        public void BleedTypeTest()
        {
            // TODO unit test for the property 'BleedType'
        }
        /// <summary>
        /// Test the property 'BleedMargin'
        /// </summary>
        [Test]
        public void BleedMarginTest()
        {
            // TODO unit test for the property 'BleedMargin'
        }
        /// <summary>
        /// Test the property 'BleedMargins'
        /// </summary>
        [Test]
        public void BleedMarginsTest()
        {
            // TODO unit test for the property 'BleedMargins'
        }
        /// <summary>
        /// Test the property 'PageBleed'
        /// </summary>
        [Test]
        public void PageBleedTest()
        {
            // TODO unit test for the property 'PageBleed'
        }
        /// <summary>
        /// Test the property 'SpacingType'
        /// </summary>
        [Test]
        public void SpacingTypeTest()
        {
            // TODO unit test for the property 'SpacingType'
        }
        /// <summary>
        /// Test the property 'SpacingMargin'
        /// </summary>
        [Test]
        public void SpacingMarginTest()
        {
            // TODO unit test for the property 'SpacingMargin'
        }
        /// <summary>
        /// Test the property 'SpacingMargins'
        /// </summary>
        [Test]
        public void SpacingMarginsTest()
        {
            // TODO unit test for the property 'SpacingMargins'
        }
        /// <summary>
        /// Test the property 'OffcutMargins'
        /// </summary>
        [Test]
        public void OffcutMarginsTest()
        {
            // TODO unit test for the property 'OffcutMargins'
        }
        /// <summary>
        /// Test the property 'MinOverruns'
        /// </summary>
        [Test]
        public void MinOverrunsTest()
        {
            // TODO unit test for the property 'MinOverruns'
        }
        /// <summary>
        /// Test the property 'MaxOverruns'
        /// </summary>
        [Test]
        public void MaxOverrunsTest()
        {
            // TODO unit test for the property 'MaxOverruns'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }
        /// <summary>
        /// Test the property 'ProcessSettings'
        /// </summary>
        [Test]
        public void ProcessSettingsTest()
        {
            // TODO unit test for the property 'ProcessSettings'
        }
        /// <summary>
        /// Test the property 'Marks'
        /// </summary>
        [Test]
        public void MarksTest()
        {
            // TODO unit test for the property 'Marks'
        }
        /// <summary>
        /// Test the property 'BackMarks'
        /// </summary>
        [Test]
        public void BackMarksTest()
        {
            // TODO unit test for the property 'BackMarks'
        }
        /// <summary>
        /// Test the property 'FoldingPatterns'
        /// </summary>
        [Test]
        public void FoldingPatternsTest()
        {
            // TODO unit test for the property 'FoldingPatterns'
        }
        /// <summary>
        /// Test the property 'BindingMethod'
        /// </summary>
        [Test]
        public void BindingMethodTest()
        {
            // TODO unit test for the property 'BindingMethod'
        }
        /// <summary>
        /// Test the property 'BindingEdge'
        /// </summary>
        [Test]
        public void BindingEdgeTest()
        {
            // TODO unit test for the property 'BindingEdge'
        }
        /// <summary>
        /// Test the property 'JogEdge'
        /// </summary>
        [Test]
        public void JogEdgeTest()
        {
            // TODO unit test for the property 'JogEdge'
        }
        /// <summary>
        /// Test the property 'ReadingOrder'
        /// </summary>
        [Test]
        public void ReadingOrderTest()
        {
            // TODO unit test for the property 'ReadingOrder'
        }
        /// <summary>
        /// Test the property 'Pages'
        /// </summary>
        [Test]
        public void PagesTest()
        {
            // TODO unit test for the property 'Pages'
        }
        /// <summary>
        /// Test the property 'PagesPerSection'
        /// </summary>
        [Test]
        public void PagesPerSectionTest()
        {
            // TODO unit test for the property 'PagesPerSection'
        }
        /// <summary>
        /// Test the property 'SelfCover'
        /// </summary>
        [Test]
        public void SelfCoverTest()
        {
            // TODO unit test for the property 'SelfCover'
        }
        /// <summary>
        /// Test the property 'Trim'
        /// </summary>
        [Test]
        public void TrimTest()
        {
            // TODO unit test for the property 'Trim'
        }
        /// <summary>
        /// Test the property 'NUp'
        /// </summary>
        [Test]
        public void NUpTest()
        {
            // TODO unit test for the property 'NUp'
        }
        /// <summary>
        /// Test the property 'Creep'
        /// </summary>
        [Test]
        public void CreepTest()
        {
            // TODO unit test for the property 'Creep'
        }
        /// <summary>
        /// Test the property 'BundleSize'
        /// </summary>
        [Test]
        public void BundleSizeTest()
        {
            // TODO unit test for the property 'BundleSize'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }
        /// <summary>
        /// Test the property 'Tiling'
        /// </summary>
        [Test]
        public void TilingTest()
        {
            // TODO unit test for the property 'Tiling'
        }
        /// <summary>
        /// Test the property 'FrontInks'
        /// </summary>
        [Test]
        public void FrontInksTest()
        {
            // TODO unit test for the property 'FrontInks'
        }
        /// <summary>
        /// Test the property 'BackInks'
        /// </summary>
        [Test]
        public void BackInksTest()
        {
            // TODO unit test for the property 'BackInks'
        }
        /// <summary>
        /// Test the property 'CutInk'
        /// </summary>
        [Test]
        public void CutInkTest()
        {
            // TODO unit test for the property 'CutInk'
        }
        /// <summary>
        /// Test the property 'CreaseInk'
        /// </summary>
        [Test]
        public void CreaseInkTest()
        {
            // TODO unit test for the property 'CreaseInk'
        }
        /// <summary>
        /// Test the property 'BleedInk'
        /// </summary>
        [Test]
        public void BleedInkTest()
        {
            // TODO unit test for the property 'BleedInk'
        }
        /// <summary>
        /// Test the property 'CutLayer'
        /// </summary>
        [Test]
        public void CutLayerTest()
        {
            // TODO unit test for the property 'CutLayer'
        }
        /// <summary>
        /// Test the property 'CreaseLayer'
        /// </summary>
        [Test]
        public void CreaseLayerTest()
        {
            // TODO unit test for the property 'CreaseLayer'
        }
        /// <summary>
        /// Test the property 'BleedLayer'
        /// </summary>
        [Test]
        public void BleedLayerTest()
        {
            // TODO unit test for the property 'BleedLayer'
        }

    }

}
