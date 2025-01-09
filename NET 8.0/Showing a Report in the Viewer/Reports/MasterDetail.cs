using System;
using System.Drawing;
//using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace StiReports
{
    
	public class StiMasterDetail : Stimulsoft.Report.StiReport
    {
        
		public StiMasterDetail()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentCategories;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand1;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiImage Image1;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiCheckBox CheckBox1;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Dictionary.StiCountFunctionService Text6_Count;
        public Stimulsoft.Report.StiStyle StyleHeader1;
        public Stimulsoft.Report.StiStyle StyleHeader2;
        public Stimulsoft.Report.StiStyle StyleHeader3;
        public Stimulsoft.Report.StiStyle StyleHeader4;
        public Stimulsoft.Report.StiStyle StyleData1;
        public Stimulsoft.Report.StiStyle StyleData2;
        public Stimulsoft.Report.StiStyle StyleFooter1;
        public Stimulsoft.Report.StiStyle StyleFooter2;
        public CategoriesDataSource Categories;
        public ProductsDataSource Products;
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text7
            e.StoreToPrinted = true;
            e.Value = "#%#{PageNofM}";
        }
        
        public string Text7_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            // CheckerInfo: Text Text7
            return ToString(sender, PageNofM, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text20
            e.Value = ToString(sender, ReportAuthor, true);
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text23
            e.Value = ToString(sender, ReportName, true);
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text5
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text8
            e.Value = "Date: " + ToString(sender, Today.ToString("Y"), true);
        }
        
        public void DataBand1__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            // CheckerInfo: Bookmark DataBand1
            e.Value = ToString(Categories.CategoryName);
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text17
            e.Value = ToString(sender, Categories.CategoryName, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text18
            e.Value = ToString(sender, Categories.Description, true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text11
            e.Value = "Quantity per unit";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text12
            e.Value = "Price";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text13
            e.Value = "Units in stock";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text10
            e.Value = "Name";
        }
        
        public void DataBand2__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            // CheckerInfo: Bookmark DataBand2
            e.Value = ToString(Products.ProductName);
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text1
            e.Value = ToString(sender, Products.ProductName, true);
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text2
            e.Value = ToString(sender, Products.QuantityPerUnit, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text3
            e.Value = this.Text3.TextFormat.Format(CheckExcelValue(sender, Products.UnitPrice));
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text4
            e.Value = this.Text4.TextFormat.Format(CheckExcelValue(sender, Products.UnitsInStock));
        }
        
        public void CheckBox1__GetChecked(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            // CheckerInfo: Checked CheckBox1
            e.Value = Products.Discontinued;
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text9
            e.Value = ToString(sender, Line, true);
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text6
            e.StoreToPrinted = true;
            e.Value = "#%#Count: {Count()}";
        }
        
        public string Text6_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            // CheckerInfo: Text Text6
            return "Count: " + ToString(sender, ((long)(StiReport.ChangeType(this.Text6_Count.GetValue(), typeof(long), true))), true);
        }
        
        public void DataBand2__BeginRender(object sender, System.EventArgs e)
        {
            this.Text6_Count.Init();
            this.Text6.TextValue = "";
        }
        
        public void DataBand2__EndRender(object sender, System.EventArgs e)
        {
            this.Text6.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text6_GetValue_End));
        }
        
        public void DataBand2__Rendering(object sender, System.EventArgs e)
        {
            // CheckerInfo: Text Text6
            try
            {
                this.Text6_Count.CalcItem(null);
            }
            catch (System.Exception ex)
            {
                StiLogService.Write(this.GetType(), "DataBand2 RenderingEvent Text6_Count ...ERROR");
                StiLogService.Write(this.GetType(), ex);
                this.WriteToReportRenderingMessages("Text6_Count " + ex.Message);
            }
        }
        
        public void Master_DetailWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text7.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text7_GetValue_End));
        }
        
        public void CheckEndRenderRuntimes__EndRender(object sender, System.EventArgs e)
        {
            Stimulsoft.Report.Components.StiSimpleText.CheckEndRenderRuntimes(this);
            Stimulsoft.Report.Components.StiSimpleText.ProcessEndRenderSetText(this);
        }
        
        private void InitializeComponent()
        {
            this.Products = new ProductsDataSource();
            this.Categories = new CategoriesDataSource();
            this.ParentCategories = new Stimulsoft.Report.Dictionary.StiDataRelation("Relation", "Categories", "Categories", this.Categories, this.Products, new string[] {
                        "CategoryID"}, new string[] {
                        "CategoryID"}, true);
            this.Dictionary.Resources.Add(new Stimulsoft.Report.Dictionary.StiResource("CategoriesProducts", "CategoriesProducts", Stimulsoft.Report.Dictionary.StiResourceType.Xml, Stimulsoft.Base.Helpers.StiPacker.UnpackFromString("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"), false));
            this.NeedsCompiling = false;
            this.Text6_Count = new Stimulsoft.Report.Dictionary.StiCountFunctionService();
            this.CalculationMode = Stimulsoft.Report.StiCalculationMode.Interpretation;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Key = "d3b8d6cee03143c898b0bcaed6b9b698";
            this.ReferencedAssemblies = new string[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Master-Detail";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2022, 9, 13, 14, 26, 10, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "The sample demonstrates how to create a Master-Detail report.";
            this.ReportGuid = "2854046f93494f1984abf4774b52d658";
            this.ReportImage = StiImageConverter.StringToImage("iVBORw0KGgoAAAANSUhEUgAAASAAAAGWCAMAAADvzq7aAAAABGdBTUEAALGPC/xhBQAAAYBQTFRF\r\nRTIqvLq9ucfL/7OA7vP3+OfYsbzI0N7o9vv82ObuzLu25ubm5u/20ca7qqmrxMTE7+/v//TpxM7Y\r\n++/n/6971NTUlJKX/9W399jI6N/b/8qppnRY2c7JzwMB/9zH/08lx9XetYtp073H3t7f8F5R3tTN\r\nt5mM/8+zpq61rLW7zs7O5jAfj2Av/8SekZyp/7yS8dzpl6Wz//v0t66rsKee5ejuu7Sw+bqv2Kye\r\n3Y1z38zY/6+B/vfz09fe541Q3NjWtrC47+fk0cfG1dze1ZeL4NzW8ezlx8jL4uzwxM3P/+vxz8zH\r\n/4lzp6Cm+Me688zc/+HWcYeY/9DE4tbfxH100sfQV2l88cTO7+bv/4ZRv7+///b5/9Kq9fz38rSj\r\n+ZSQws3I69PA25+j4OLj7p5s7sOr1tzY/Kp+oqCcz9LT6vPy9/f78/P38vf78vf3+/v/+v//+/v7\r\n9/f3///68/P78/Py9/f/9/fy//v8+fPy7Pj/w8PD7/H2/7SG8PL2////E9H/0QAAABl0RVh0U29m\r\ndHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAEtISURBVHhe7Z2Pf5rW/v+FEERRRC06rMtcmFVs\r\njE0MbGvi8EcVrdctXZusH7b13o6t04JV49cmjT/Ov/59HNTEX1Frunu71WdTxQPngC8PB86b9zlv\r\nE1gzF9Nkwppx1gItYC3QAtYCLWAt0ALWAi1gLdAC1gItYC3QAtYCLWAt0ALWAi1gLdAC1gItYC3Q\r\nAtYCLWBSoPNcpw5AS8Am0sdp0LRATyYC4IybnVRgMvV/Cy3Qdfi+SdkmV1lxY82QzTI6+nHApED3\r\nTKd58Otd05ORtKO4a+QTZNNkMpmeDPeYLV0Ok/c2TbujG/6v2b9nOjVZ9uMosJomvwSxc0qMfHSb\r\nTvdypfxIisG0QCYefGYyPQH7UgIDoCVl6lbTEwzsS1wdpFTaKOEz0x4hmk7rwM3kgXPHFKgZWx8V\r\nsY9MoD9Me28kzGp6cumWL88zOisAVq03WQG4uebO6WWdY2wAsMxrAL4x7bXumvBRzSCTAn15enoK\r\n7p2ePgH3Tk2nts1T0ym6YzLt/Xr31OQBd6FyfYEA+NJkeXlqOnWJJtNpHm59+dlHV4NE05M82Dw1\r\n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");
            this.ReportName = "Master-Detail";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.HundredthsOfInch;
            this.ReportVersion = "2025.1.3.0";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "668294ae17e449b3a64981d08bcc7b69";
            this.Page1.Name = "Page1";
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.A4;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1071, 749, 20);
            this.PageFooterBand1.Guid = "81832642d9dd434e8bc74557b8c11f4f";
            this.PageFooterBand1.Name = "PageFooterBand1";
            this.PageFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.PageFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 749, 20);
            this.Text7.ComponentStyle = "Footer1";
            this.Text7.Guid = "06c16bd4f8654a7eaf7c4c1d0f7129d7";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand1.Interaction = null;
            // 
            // ReportTitleBand1
            // 
            this.ReportTitleBand1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 749, 90);
            this.ReportTitleBand1.Guid = "905f0f46e13241e19fd2f7aa451444b7";
            this.ReportTitleBand1.Name = "ReportTitleBand1";
            this.ReportTitleBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.ReportTitleBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 0, 179, 50);
            this.Text20.ComponentStyle = "Header1";
            this.Text20.Guid = "897fb52156e64324a824be76ee88fae4";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 3, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 570, 50);
            this.Text23.ComponentStyle = "Header1";
            this.Text23.Guid = "19634b0ee5c44765ab98ce802b22586f";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(2, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.CanGrow = true;
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 50, 570, 20);
            this.Text5.ComponentStyle = "Footer1";
            this.Text5.Guid = "2369064ead1d4d228af99659029df6fb";
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(6, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.CanGrow = true;
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 50, 179, 20);
            this.Text8.ComponentStyle = "Footer1";
            this.Text8.Guid = "b97466bd2d874a9fa9011b4544cbd232";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 4, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.DataBand1__GetBookmark);
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 150, 749, 120);
            this.DataBand1.ComponentStyle = "Header3";
            this.DataBand1.DataSourceName = "Categories";
            this.DataBand1.KeepChildTogether = true;
            this.DataBand1.KeepDetails = Stimulsoft.Report.Components.StiKeepDetails.KeepDetailsTogether;
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new string[] {
                    "ASC",
                    "CategoryName"};
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Transparent, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(130, 10, 480, 40);
            this.Text17.ComponentStyle = "Header2";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(130, 50, 480, 30);
            this.Text18.ComponentStyle = "Footer2";
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(4, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Image1
            // 
            this.Image1 = new Stimulsoft.Report.Components.StiImage();
            this.Image1.AspectRatio = true;
            this.Image1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 10, 110, 70);
            this.Image1.DataColumn = "Categories.Picture";
            this.Image1.IconColor = System.Drawing.Color.FromArgb(255, 68, 114, 196);
            this.Image1.Name = "Image1";
            this.Image1.Stretch = true;
            this.Image1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 183, 117, 64), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Image1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Image1.ImageBytes = null;
            this.Image1.Interaction = null;
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(270, 90, 200, 30);
            this.Text11.ComponentStyle = "Header4";
            this.Text11.Guid = "41a1a54b7aa249ceaed3997071bbe482";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.Top | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 194, 194));
            this.Text11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(470, 90, 120, 30);
            this.Text12.ComponentStyle = "Header4";
            this.Text12.Guid = "95da4813875a4915a96a703787ae167f";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.Top | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 194, 194));
            this.Text12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 3, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(590, 90, 159, 30);
            this.Text13.ComponentStyle = "Header4";
            this.Text13.Guid = "f65b4242b4264a90ad68223cc9038560";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Top | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 194, 194));
            this.Text13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 90, 270, 30);
            this.Text10.ComponentStyle = "Header4";
            this.Text10.Guid = "43745fb857524156a7ef640aca6fd1d3";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Top | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 194, 194));
            this.Text10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.Interaction = null;
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.DataBand2__GetBookmark);
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 310, 749, 20);
            this.DataBand2.DataRelationName = "Relation";
            this.DataBand2.DataSourceName = "Products";
            this.DataBand2.EvenStyle = "Data2";
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.Sort = new string[] {
                    "ASC",
                    "ProductName"};
            this.DataBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand2.BusinessObjectGuid = null;
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.CanGrow = true;
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(30, 0, 240, 20);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.GrowToHeight = true;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.CanGrow = true;
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(270, 0, 200, 20);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.GrowToHeight = true;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.CanGrow = true;
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(470, 0, 120, 20);
            this.Text3.ComponentStyle = "Data1";
            this.Text3.GrowToHeight = true;
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text3.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.CanGrow = true;
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(590, 0, 140, 20);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.GrowToHeight = true;
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text4.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 2, ",", 3, true, true, " ");
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // CheckBox1
            // 
            this.CheckBox1 = new Stimulsoft.Report.Components.StiCheckBox();
            this.CheckBox1.GetChecked += new Stimulsoft.Report.Events.StiValueEventHandler(this.CheckBox1__GetChecked);
            this.CheckBox1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(730, 0, 19, 20);
            this.CheckBox1.ComponentStyle = "Data1";
            this.CheckBox1.ContourColor = System.Drawing.Color.Transparent;
            this.CheckBox1.GrowToHeight = true;
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.CheckBox1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.CheckBox1.Interaction = null;
            this.CheckBox1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.CanGrow = true;
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 30, 20);
            this.Text9.ComponentStyle = "Data1";
            this.Text9.GrowToHeight = true;
            this.Text9.Guid = "5583620051ec4064b1730ec735258737";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand2.Interaction = null;
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 370, 749, 40);
            this.FooterBand1.Name = "FooterBand1";
            this.FooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 749, 20);
            this.Text6.ComponentStyle = "Footer1";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text6.Name = "Text6";
            // 
            // Text6_Count
            // 
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.FooterBand1.Interaction = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(39, 39, 39, 39);
            // 
            // StyleHeader1
            // 
            this.StyleHeader1 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader1.Name = "Header1";
            this.StyleHeader1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader1.Image = null;
            this.StyleHeader1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleHeader2
            // 
            this.StyleHeader2 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader2.Name = "Header2";
            this.StyleHeader2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader2.Image = null;
            this.StyleHeader2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            // 
            // StyleHeader3
            // 
            this.StyleHeader3 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader3.Name = "Header3";
            this.StyleHeader3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Transparent, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.StyleHeader3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader3.Image = null;
            this.StyleHeader3.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            // 
            // StyleHeader4
            // 
            this.StyleHeader4 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader4.AllowUseBorderFormatting = false;
            this.StyleHeader4.AllowUseBorderSides = false;
            this.StyleHeader4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleHeader4.Name = "Header4";
            this.StyleHeader4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader4.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Top | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 194, 194));
            this.StyleHeader4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StyleHeader4.Image = null;
            this.StyleHeader4.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            // 
            // StyleData1
            // 
            this.StyleData1 = new Stimulsoft.Report.StiStyle();
            this.StyleData1.Name = "Data1";
            this.StyleData1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleData1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleData1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleData1.Image = null;
            this.StyleData1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleData1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleData2
            // 
            this.StyleData2 = new Stimulsoft.Report.StiStyle();
            this.StyleData2.Name = "Data2";
            this.StyleData2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 255, 255, 255), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleData2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 242, 246));
            this.StyleData2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleData2.Image = null;
            this.StyleData2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleData2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleFooter1
            // 
            this.StyleFooter1 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter1.AllowUseBorderSides = false;
            this.StyleFooter1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter1.Name = "Footer1";
            this.StyleFooter1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleFooter1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleFooter1.Image = null;
            this.StyleFooter1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleFooter1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            // 
            // StyleFooter2
            // 
            this.StyleFooter2 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter2.Name = "Footer2";
            this.StyleFooter2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleFooter2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleFooter2.Image = null;
            this.StyleFooter2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleFooter2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Page1.Report = this;
            this.PageFooterBand1.Page = this.Page1;
            this.PageFooterBand1.Parent = this.Page1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.PageFooterBand1;
            this.ReportTitleBand1.Page = this.Page1;
            this.ReportTitleBand1.Parent = this.Page1;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.ReportTitleBand1;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.ReportTitleBand1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.ReportTitleBand1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.ReportTitleBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.DataBand1;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.DataBand1;
            this.Image1.Page = this.Page1;
            this.Image1.Parent = this.DataBand1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.DataBand1;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.DataBand1;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.DataBand1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.DataBand1;
            this.DataBand2.MasterComponent = this.DataBand1;
            this.DataBand2.Page = this.Page1;
            this.DataBand2.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand2;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.DataBand2;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.DataBand2;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.DataBand2;
            this.CheckBox1.Page = this.Page1;
            this.CheckBox1.Parent = this.DataBand2;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.DataBand2;
            this.FooterBand1.Page = this.Page1;
            this.FooterBand1.Parent = this.Page1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.FooterBand1;
            this.DataBand2.BeginRender += new System.EventHandler(this.DataBand2__BeginRender);
            this.DataBand2.EndRender += new System.EventHandler(this.DataBand2__EndRender);
            this.DataBand2.Rendering += new System.EventHandler(this.DataBand2__Rendering);
            this.EndRender += new System.EventHandler(this.Master_DetailWordsToEnd__EndRender);
            this.AggregateFunctions = new object[] {
                    this.Text6_Count};
            this.EndRender += new System.EventHandler(this.CheckEndRenderRuntimes__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text7});
            // 
            // Add to ReportTitleBand1.Components
            // 
            this.ReportTitleBand1.Components.Clear();
            this.ReportTitleBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text20,
                        this.Text23,
                        this.Text5,
                        this.Text8});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text17,
                        this.Text18,
                        this.Image1,
                        this.Text11,
                        this.Text12,
                        this.Text13,
                        this.Text10});
            // 
            // Add to DataBand2.Components
            // 
            this.DataBand2.Components.Clear();
            this.DataBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text2,
                        this.Text3,
                        this.Text4,
                        this.CheckBox1,
                        this.Text9});
            // 
            // Add to FooterBand1.Components
            // 
            this.FooterBand1.Components.Clear();
            this.FooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand1,
                        this.ReportTitleBand1,
                        this.DataBand1,
                        this.DataBand2,
                        this.FooterBand1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleHeader1,
                        this.StyleHeader2,
                        this.StyleHeader3,
                        this.StyleHeader4,
                        this.StyleData1,
                        this.StyleData2,
                        this.StyleFooter1,
                        this.StyleFooter2});
            this.Dictionary.Relations.Add(this.ParentCategories);
            this.Categories.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryName", "CategoryName", "CategoryName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Description", "Description", "Description", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Picture", "Picture", "Picture", typeof(string), null)});
            this.DataSources.Add(this.Categories);
            this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discontinued", "Discontinued", "Discontinued", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReorderLevel", "ReorderLevel", "ReorderLevel", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsOnOrder", "UnitsOnOrder", "UnitsOnOrder", typeof(string), null)});
            this.DataSources.Add(this.Products);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiXmlDatabase("Demo", "", "resource://CategoriesProducts", "", Stimulsoft.Report.StiXmlType.AdoNetXml, Stimulsoft.Report.Dictionary.StiColumnTypeProcessing.LeaveUnprocessed));
        }
        
        // CheckerInfo: *None* *Relations*
        #region Relation ParentCategories
        public class ParentCategoriesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentCategoriesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual string CategoryID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryID"], typeof(string), true)));
                }
            }
            
            public virtual string CategoryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryName"], typeof(string), true)));
                }
            }
            
            public virtual string Description
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Description"], typeof(string), true)));
                }
            }
            
            public virtual string Picture
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Picture"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentCategories
        
        // CheckerInfo: *None* *DataSources*
        #region DataSource Categories
        public class CategoriesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CategoriesDataSource() : 
                    base("Demo.Categories", "Categories", "Categories", "72730a1a016843a4bb556e9e3f06f108")
            {
            }
            
            public virtual string CategoryID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryID"], typeof(string), true)));
                }
            }
            
            public virtual string CategoryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryName"], typeof(string), true)));
                }
            }
            
            public virtual string Description
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Description"], typeof(string), true)));
                }
            }
            
            public virtual string Picture
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Picture"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Categories
        
        #region DataSource Products
        public class ProductsDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public ProductsDataSource() : 
                    base("Demo.Products", "Products", "Products", "d3e21884098b48c38a5fd7f515c8c3c6")
            {
            }
            
            public virtual string CategoryID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryID"], typeof(string), true)));
                }
            }
            
            public virtual string Discontinued
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Discontinued"], typeof(string), true)));
                }
            }
            
            public virtual string ProductID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProductID"], typeof(string), true)));
                }
            }
            
            public virtual string ProductName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProductName"], typeof(string), true)));
                }
            }
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                }
            }
            
            public virtual string ReorderLevel
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ReorderLevel"], typeof(string), true)));
                }
            }
            
            public virtual string SupplierID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["SupplierID"], typeof(string), true)));
                }
            }
            
            public virtual string UnitPrice
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["UnitPrice"], typeof(string), true)));
                }
            }
            
            public virtual string UnitsInStock
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["UnitsInStock"], typeof(string), true)));
                }
            }
            
            public virtual string UnitsOnOrder
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["UnitsOnOrder"], typeof(string), true)));
                }
            }
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("Relation"));
                }
            }
        }
        #endregion DataSource Products
        #endregion StiReport Designer generated code - do not modify
    }
}