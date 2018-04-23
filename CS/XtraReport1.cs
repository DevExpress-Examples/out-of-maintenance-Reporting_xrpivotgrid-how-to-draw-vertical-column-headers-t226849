using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrPivotGrid1_PrintFieldValue(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs e)
        {
            if (e.Field != null && e.Field.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
                {
                    TextBrick tb = e.Brick as TextBrick;
                    LabelBrick lb = tb.PrintingSystem.CreateBrick("LabelBrick") as LabelBrick;
                    lb.Padding = new PaddingInfo(2, 2, 5, 2, GraphicsUnit.Pixel);
                    lb.Angle = 90;
                    lb.Text = e.Text;
                    lb.Rect = GraphicsUnitConverter.DocToPixel(e.Brick.Rect);
                    tb.IsVisible = false;
                    tb.PrintingSystem.Graph.DrawBrick(lb);
                }
        }

    }
}
