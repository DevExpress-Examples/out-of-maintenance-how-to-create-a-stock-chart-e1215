<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128573961/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1215)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/StockCharting/Form1.cs) (VB: [Form1.vb](./VB/StockCharting/Form1.vb))
<!-- default file list end -->
# How to create a Stock chart


<p>The following example demonstrates how to create a  <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument2987">Stock</a> chart at runtime.</p>
<p>Note that this series view type is associated with the  <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraChartsXYDiagramtopic">XY-Diagram</a> type, and you should cast your <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraChartsDiagramtopic">diagram</a> object to this type, in order to access its specific options.</p>
<p>Also, note that starting from the v2010 vol 2 version, you can exclude non-working days (weekends and holidays) from an axis range, via the <strong>WorkdaysOnly</strong> and <strong>WorkdaysOptions</strong> properties. For details on this, refer to <a href="https://www.devexpress.com/Support/Center/p/E2365">How to exclude weekends and holidays from the axis range</a>.</p>

<br/>


