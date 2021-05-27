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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TiliaLabs.Phoenix.Client;
using TiliaLabs.Phoenix.Api;
using TiliaLabs.Phoenix.Model;

namespace TiliaLabs.Phoenix.Test
{
    /// <summary>
    ///  Class for testing LibrariesAPIApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LibrariesAPIApiTests
    {
        private LibrariesAPIApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LibrariesAPIApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LibrariesAPIApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LibrariesAPIApi
            //Assert.IsInstanceOfType(typeof(LibrariesAPIApi), instance, "instance is a LibrariesAPIApi");
        }

        /// <summary>
        /// Test AddGrade
        /// </summary>
        [Test]
        public void AddGradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //GradeEntity body = null;
            //var response = instance.AddGrade(stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddMode1
        /// </summary>
        [Test]
        public void AddMode1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Mode body = null;
            //var response = instance.AddMode1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddPlate1
        /// </summary>
        [Test]
        public void AddPlate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlateEntity body = null;
            //var response = instance.AddPlate1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddPress1
        /// </summary>
        [Test]
        public void AddPress1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PressEntity body = null;
            //var response = instance.AddPress1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddProcess1
        /// </summary>
        [Test]
        public void AddProcess1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Process body = null;
            //var response = instance.AddProcess1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddProcessType1
        /// </summary>
        [Test]
        public void AddProcessType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProcessType body = null;
            //var response = instance.AddProcessType1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddRoll
        /// </summary>
        [Test]
        public void AddRollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //RollEntity body = null;
            //var response = instance.AddRoll(gradeid, stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddSheet
        /// </summary>
        [Test]
        public void AddSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //SheetEntity body = null;
            //var response = instance.AddSheet(gradeid, stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddStock1
        /// </summary>
        [Test]
        public void AddStock1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StockEntity body = null;
            //var response = instance.AddStock1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddStock2
        /// </summary>
        [Test]
        public void AddStock2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Stock body = null;
            //var response = instance.AddStock2(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddStockType1
        /// </summary>
        [Test]
        public void AddStockType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StockType body = null;
            //var response = instance.AddStockType1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test AddThing1
        /// </summary>
        [Test]
        public void AddThing1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Thing body = null;
            //var response = instance.AddThing1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteDieDesign1
        /// </summary>
        [Test]
        public void DeleteDieDesign1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string diedesignid = null;
            //var response = instance.DeleteDieDesign1(diedesignid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteGrade
        /// </summary>
        [Test]
        public void DeleteGradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.DeleteGrade(gradeid, stockid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteMode1
        /// </summary>
        [Test]
        public void DeleteMode1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string modeid = null;
            //var response = instance.DeleteMode1(modeid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeletePlate1
        /// </summary>
        [Test]
        public void DeletePlate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string plateid = null;
            //var response = instance.DeletePlate1(plateid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeletePress1
        /// </summary>
        [Test]
        public void DeletePress1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pressid = null;
            //var response = instance.DeletePress1(pressid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteProcess1
        /// </summary>
        [Test]
        public void DeleteProcess1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processid = null;
            //var response = instance.DeleteProcess1(processid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteProcessType1
        /// </summary>
        [Test]
        public void DeleteProcessType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processtypeid = null;
            //var response = instance.DeleteProcessType1(processtypeid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteRoll
        /// </summary>
        [Test]
        public void DeleteRollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rollid = null;
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.DeleteRoll(rollid, gradeid, stockid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteSheet
        /// </summary>
        [Test]
        public void DeleteSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sheetid = null;
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.DeleteSheet(sheetid, gradeid, stockid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteStock1
        /// </summary>
        [Test]
        public void DeleteStock1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //var response = instance.DeleteStock1(stockid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteStock2
        /// </summary>
        [Test]
        public void DeleteStock2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //var response = instance.DeleteStock2(stockid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteStockType1
        /// </summary>
        [Test]
        public void DeleteStockType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stocktypeid = null;
            //var response = instance.DeleteStockType1(stocktypeid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteTemplate1
        /// </summary>
        [Test]
        public void DeleteTemplate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateid = null;
            //var response = instance.DeleteTemplate1(templateid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test DeleteThing1
        /// </summary>
        [Test]
        public void DeleteThing1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string thingid = null;
            //var response = instance.DeleteThing1(thingid);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditGrade
        /// </summary>
        [Test]
        public void EditGradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //GradeEntity body = null;
            //var response = instance.EditGrade(gradeid, stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditMode1
        /// </summary>
        [Test]
        public void EditMode1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string modeid = null;
            //Mode body = null;
            //var response = instance.EditMode1(modeid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditPlate1
        /// </summary>
        [Test]
        public void EditPlate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string plateid = null;
            //PlateEntity body = null;
            //var response = instance.EditPlate1(plateid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditPress1
        /// </summary>
        [Test]
        public void EditPress1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pressid = null;
            //PressEntity body = null;
            //var response = instance.EditPress1(pressid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditProcess1
        /// </summary>
        [Test]
        public void EditProcess1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processid = null;
            //Process body = null;
            //var response = instance.EditProcess1(processid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditProcessType1
        /// </summary>
        [Test]
        public void EditProcessType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processtypeid = null;
            //ProcessType body = null;
            //var response = instance.EditProcessType1(processtypeid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditRoll
        /// </summary>
        [Test]
        public void EditRollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rollid = null;
            //string gradeid = null;
            //string stockid = null;
            //RollEntity body = null;
            //var response = instance.EditRoll(rollid, gradeid, stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditSheet
        /// </summary>
        [Test]
        public void EditSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sheetid = null;
            //string gradeid = null;
            //string stockid = null;
            //SheetEntity body = null;
            //var response = instance.EditSheet(sheetid, gradeid, stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditStock1
        /// </summary>
        [Test]
        public void EditStock1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //StockEntity body = null;
            //var response = instance.EditStock1(stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditStock2
        /// </summary>
        [Test]
        public void EditStock2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //Stock body = null;
            //var response = instance.EditStock2(stockid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditStockType1
        /// </summary>
        [Test]
        public void EditStockType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stocktypeid = null;
            //StockType body = null;
            //var response = instance.EditStockType1(stocktypeid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test EditThing1
        /// </summary>
        [Test]
        public void EditThing1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string thingid = null;
            //Thing body = null;
            //var response = instance.EditThing1(thingid, body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test GetDieDesign1
        /// </summary>
        [Test]
        public void GetDieDesign1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string diedesignid = null;
            //bool? thumb = null;
            //var response = instance.GetDieDesign1(diedesignid, thumb);
            //Assert.IsInstanceOf<DieDesignEntity> (response, "response is DieDesignEntity");
        }
        /// <summary>
        /// Test GetDieDesigns1
        /// </summary>
        [Test]
        public void GetDieDesigns1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? thumb = null;
            //var response = instance.GetDieDesigns1(thumb);
            //Assert.IsInstanceOf<List<DieDesignEntity>> (response, "response is List<DieDesignEntity>");
        }
        /// <summary>
        /// Test GetFoldingPatterns
        /// </summary>
        [Test]
        public void GetFoldingPatternsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFoldingPatterns();
            //Assert.IsInstanceOf<List<FoldingPatternEntity>> (response, "response is List<FoldingPatternEntity>");
        }
        /// <summary>
        /// Test GetGrade1
        /// </summary>
        [Test]
        public void GetGrade1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.GetGrade1(gradeid, stockid);
            //Assert.IsInstanceOf<GradeEntity> (response, "response is GradeEntity");
        }
        /// <summary>
        /// Test GetGrades
        /// </summary>
        [Test]
        public void GetGradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //var response = instance.GetGrades(stockid);
            //Assert.IsInstanceOf<List<GradeEntity>> (response, "response is List<GradeEntity>");
        }
        /// <summary>
        /// Test GetMarkSets
        /// </summary>
        [Test]
        public void GetMarkSetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMarkSets();
            //Assert.IsInstanceOf<List<MarkSetEntity>> (response, "response is List<MarkSetEntity>");
        }
        /// <summary>
        /// Test GetMarks
        /// </summary>
        [Test]
        public void GetMarksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMarks();
            //Assert.IsInstanceOf<List<MarkEntity>> (response, "response is List<MarkEntity>");
        }
        /// <summary>
        /// Test GetMode1
        /// </summary>
        [Test]
        public void GetMode1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string modeid = null;
            //var response = instance.GetMode1(modeid);
            //Assert.IsInstanceOf<Mode> (response, "response is Mode");
        }
        /// <summary>
        /// Test GetModes1
        /// </summary>
        [Test]
        public void GetModes1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetModes1();
            //Assert.IsInstanceOf<List<Mode>> (response, "response is List<Mode>");
        }
        /// <summary>
        /// Test GetPlate1
        /// </summary>
        [Test]
        public void GetPlate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string plateid = null;
            //var response = instance.GetPlate1(plateid);
            //Assert.IsInstanceOf<PlateEntity> (response, "response is PlateEntity");
        }
        /// <summary>
        /// Test GetPlates1
        /// </summary>
        [Test]
        public void GetPlates1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPlates1();
            //Assert.IsInstanceOf<List<PlateEntity>> (response, "response is List<PlateEntity>");
        }
        /// <summary>
        /// Test GetPress1
        /// </summary>
        [Test]
        public void GetPress1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pressid = null;
            //var response = instance.GetPress1(pressid);
            //Assert.IsInstanceOf<PressEntity> (response, "response is PressEntity");
        }
        /// <summary>
        /// Test GetPresses1
        /// </summary>
        [Test]
        public void GetPresses1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPresses1();
            //Assert.IsInstanceOf<List<PressEntity>> (response, "response is List<PressEntity>");
        }
        /// <summary>
        /// Test GetProcess1
        /// </summary>
        [Test]
        public void GetProcess1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processid = null;
            //var response = instance.GetProcess1(processid);
            //Assert.IsInstanceOf<Process> (response, "response is Process");
        }
        /// <summary>
        /// Test GetProcessType1
        /// </summary>
        [Test]
        public void GetProcessType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processtypeid = null;
            //var response = instance.GetProcessType1(processtypeid);
            //Assert.IsInstanceOf<ProcessType> (response, "response is ProcessType");
        }
        /// <summary>
        /// Test GetProcessTypes1
        /// </summary>
        [Test]
        public void GetProcessTypes1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetProcessTypes1();
            //Assert.IsInstanceOf<List<ProcessType>> (response, "response is List<ProcessType>");
        }
        /// <summary>
        /// Test GetProcesses1
        /// </summary>
        [Test]
        public void GetProcesses1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetProcesses1();
            //Assert.IsInstanceOf<List<Process>> (response, "response is List<Process>");
        }
        /// <summary>
        /// Test GetRoll1
        /// </summary>
        [Test]
        public void GetRoll1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rollid = null;
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.GetRoll1(rollid, gradeid, stockid);
            //Assert.IsInstanceOf<RollEntity> (response, "response is RollEntity");
        }
        /// <summary>
        /// Test GetRolls
        /// </summary>
        [Test]
        public void GetRollsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.GetRolls(gradeid, stockid);
            //Assert.IsInstanceOf<List<RollEntity>> (response, "response is List<RollEntity>");
        }
        /// <summary>
        /// Test GetSheet1
        /// </summary>
        [Test]
        public void GetSheet1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sheetid = null;
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.GetSheet1(sheetid, gradeid, stockid);
            //Assert.IsInstanceOf<SheetEntity> (response, "response is SheetEntity");
        }
        /// <summary>
        /// Test GetSheets
        /// </summary>
        [Test]
        public void GetSheetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gradeid = null;
            //string stockid = null;
            //var response = instance.GetSheets(gradeid, stockid);
            //Assert.IsInstanceOf<List<SheetEntity>> (response, "response is List<SheetEntity>");
        }
        /// <summary>
        /// Test GetStock1
        /// </summary>
        [Test]
        public void GetStock1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //var response = instance.GetStock1(stockid);
            //Assert.IsInstanceOf<StockEntity> (response, "response is StockEntity");
        }
        /// <summary>
        /// Test GetStock2
        /// </summary>
        [Test]
        public void GetStock2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stockid = null;
            //var response = instance.GetStock2(stockid);
            //Assert.IsInstanceOf<Stock> (response, "response is Stock");
        }
        /// <summary>
        /// Test GetStockType1
        /// </summary>
        [Test]
        public void GetStockType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stocktypeid = null;
            //var response = instance.GetStockType1(stocktypeid);
            //Assert.IsInstanceOf<StockType> (response, "response is StockType");
        }
        /// <summary>
        /// Test GetStockTypes1
        /// </summary>
        [Test]
        public void GetStockTypes1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStockTypes1();
            //Assert.IsInstanceOf<List<StockType>> (response, "response is List<StockType>");
        }
        /// <summary>
        /// Test GetStocks1
        /// </summary>
        [Test]
        public void GetStocks1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStocks1();
            //Assert.IsInstanceOf<List<StockEntity>> (response, "response is List<StockEntity>");
        }
        /// <summary>
        /// Test GetStocks2
        /// </summary>
        [Test]
        public void GetStocks2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStocks2();
            //Assert.IsInstanceOf<List<Stock>> (response, "response is List<Stock>");
        }
        /// <summary>
        /// Test GetTemplate1
        /// </summary>
        [Test]
        public void GetTemplate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateid = null;
            //bool? thumb = null;
            //var response = instance.GetTemplate1(templateid, thumb);
            //Assert.IsInstanceOf<TemplateEntity> (response, "response is TemplateEntity");
        }
        /// <summary>
        /// Test GetTemplates1
        /// </summary>
        [Test]
        public void GetTemplates1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? thumb = null;
            //var response = instance.GetTemplates1(thumb);
            //Assert.IsInstanceOf<List<TemplateEntity>> (response, "response is List<TemplateEntity>");
        }
        /// <summary>
        /// Test GetThing1
        /// </summary>
        [Test]
        public void GetThing1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string thingid = null;
            //var response = instance.GetThing1(thingid);
            //Assert.IsInstanceOf<Thing> (response, "response is Thing");
        }
        /// <summary>
        /// Test GetThings1
        /// </summary>
        [Test]
        public void GetThings1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetThings1();
            //Assert.IsInstanceOf<List<Thing>> (response, "response is List<Thing>");
        }
        /// <summary>
        /// Test ImportDieDesign1
        /// </summary>
        [Test]
        public void ImportDieDesign1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImportDieDesignEntity body = null;
            //var response = instance.ImportDieDesign1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        /// <summary>
        /// Test ImportTemplate1
        /// </summary>
        [Test]
        public void ImportTemplate1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImportTemplateEntity body = null;
            //var response = instance.ImportTemplate1(body);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
    }

}