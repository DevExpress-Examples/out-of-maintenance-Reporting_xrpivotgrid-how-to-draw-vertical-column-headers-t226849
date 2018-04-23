Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrinting

Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub xrPivotGrid1_PrintFieldValue(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs) Handles xrPivotGrid1.PrintFieldValue
            If e.Field IsNot Nothing AndAlso e.Field.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea Then
                Dim lb As New LabelBrick()
                lb.Padding = New PaddingInfo(2, 2, 5, 2, GraphicsUnit.Pixel)
                lb.Angle = 90
                lb.Text = e.Text
                lb.Rect = GraphicsUnitConverter.DocToPixel(e.Brick.Rect)
                e.Brick = lb
            End If
        End Sub

    End Class
End Namespace
