<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128605321/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T226849)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

# Cross Tab Report - How to draw vertical column headers

The **XRCrossTab** control that is available starting with version 19.2 supports this functionality out of the box. Use the header cells'  [Angle](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.Angle?v=19.2) property to rotate the text in the cells.

If you use a legacy **XRPivotGrid** control use the [XRPivotGrid.PrintFieldValue](https://documentation.devexpress.com/) event handler to render vertical headers. Check the previous branches (e.g. [15.1.4+](https://github.com/DevExpress-Examples/Reporting_xrpivotgrid-how-to-draw-vertical-column-headers-t226849/tree/15.1.4+)) for more details regarding this approach.
