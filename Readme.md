*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

#Cross Tab Report - How to draw vertical column headers

The **XRCrossTab** control that is available starting with version 19.2 supports this functionality out of the box. Use the header cells'  [Angle](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell.Angle?v=19.2) property to rotate the text in the cells.

If you use a legacy **XRPivotGrid** control use the [XRPivotGrid.PrintFieldValue](https://documentation.devexpress.com/) event handler to render vertical headers. Check the previous branches (e.g. [15.1.4+](https://github.com/DevExpress-Examples/Reporting_xrpivotgrid-how-to-draw-vertical-column-headers-t226849/tree/15.1.4+)) for more details regarding this approach.