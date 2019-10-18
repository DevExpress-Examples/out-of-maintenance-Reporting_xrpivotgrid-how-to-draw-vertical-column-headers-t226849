Namespace WindowsFormsApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Dim crossTabColumnDefinition1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xrCrossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
			Me.xrCrossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "localhost_NorthwindConnection"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductID"
			table1.Name = "Products"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "SupplierID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "CategoryID"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "QuantityPerUnit"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "UnitPrice"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "UnitsInStock"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "UnitsOnOrder"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ReorderLevel"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Discontinued"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Name = "Products"
			selectQuery1.Tables.Add(table1)
			columnExpression11.ColumnName = "OrderID"
			table2.Name = "Orders"
			columnExpression11.Table = table2
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "OrderDate"
			columnExpression12.Table = table2
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ShipAddress"
			columnExpression13.Table = table2
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ShipCity"
			columnExpression14.Table = table2
			column14.Expression = columnExpression14
			columnExpression15.ColumnName = "ShipRegion"
			columnExpression15.Table = table2
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "ShipPostalCode"
			columnExpression16.Table = table2
			column16.Expression = columnExpression16
			columnExpression17.ColumnName = "ShipCountry"
			columnExpression17.Table = table2
			column17.Expression = columnExpression17
			selectQuery2.Columns.Add(column11)
			selectQuery2.Columns.Add(column12)
			selectQuery2.Columns.Add(column13)
			selectQuery2.Columns.Add(column14)
			selectQuery2.Columns.Add(column15)
			selectQuery2.Columns.Add(column16)
			selectQuery2.Columns.Add(column17)
			selectQuery2.Name = "Orders"
			selectQuery2.Tables.Add(table2)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' Detail
			' 
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "[DataSource.CurrentRowIndex]==[DataSource.RowCount]-1"
			Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 47.5F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 48.66666F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 1R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 1R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 1R
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 1R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.Weight = 1R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 1R
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
			Me.Title.ForeColor = System.Drawing.Color.Maroon
			Me.Title.Name = "Title"
			' 
			' FieldCaption
			' 
			Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
			Me.FieldCaption.BorderColor = System.Drawing.Color.Black
			Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.FieldCaption.BorderWidth = 1F
			Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
			Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
			Me.FieldCaption.Name = "FieldCaption"
			' 
			' PageInfo
			' 
			Me.PageInfo.BackColor = System.Drawing.Color.Transparent
			Me.PageInfo.BorderColor = System.Drawing.Color.Black
			Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.PageInfo.BorderWidth = 1F
			Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.Black
			Me.PageInfo.Name = "PageInfo"
			' 
			' DataField
			' 
			Me.DataField.BackColor = System.Drawing.Color.Transparent
			Me.DataField.BorderColor = System.Drawing.Color.Black
			Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DataField.BorderWidth = 1F
			Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.DataField.ForeColor = System.Drawing.Color.Black
			Me.DataField.Name = "DataField"
			Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTab1})
			Me.ReportFooter.HeightF = 134F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' calculatedField1
			' 
			Me.calculatedField1.DataMember = "Orders"
			Me.calculatedField1.Name = "calculatedField1"
			' 
			' xrCrossTab1
			' 
			Me.xrCrossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTabCell1, Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9})
			crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			Me.xrCrossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F),
				crossTabColumnDefinition1,
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			})
			crossTabColumnField1.FieldName = "OrderDate"
			crossTabColumnField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateMonthYear
			Me.xrCrossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1})
			crossTabDataField1.FieldName = "OrderID"
			Me.xrCrossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1})
			Me.xrCrossTab1.DataMember = "Orders"
			Me.xrCrossTab1.DataSource = Me.sqlDataSource1
			Me.xrCrossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCrossTab1.Name = "xrCrossTab1"
			Me.xrCrossTab1.OriginalPivotGridLayout = resources.GetString("xrCrossTab1.OriginalPivotGridLayout")
			Me.xrCrossTab1.PrintOptions.PrintTotalsForSingleValues = False
			Me.xrCrossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(84F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
			})
			crossTabRowField1.FieldName = "ShipRegion"
			Me.xrCrossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1})
			Me.xrCrossTab1.SizeF = New System.Drawing.SizeF(312F, 134F)
			' 
			' xrCrossTabCell1
			' 
			Me.xrCrossTabCell1.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell1.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell1.BorderWidth = 1F
			Me.xrCrossTabCell1.ColumnIndex = 0
			Me.xrCrossTabCell1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell1.Name = "xrCrossTabCell1"
			Me.xrCrossTabCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell1.RowIndex = 0
			Me.xrCrossTabCell1.Text = "Ship Region"
			Me.xrCrossTabCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell2
			' 
			Me.xrCrossTabCell2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell2.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell2.BorderWidth = 1F
			Me.xrCrossTabCell2.ColumnIndex = 1
			Me.xrCrossTabCell2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
			Me.xrCrossTabCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell2.RowIndex = 1
			Me.xrCrossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell3
			' 
			Me.xrCrossTabCell3.Angle = 90F
			Me.xrCrossTabCell3.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell3.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell3.BorderWidth = 1F
			Me.xrCrossTabCell3.ColumnIndex = 1
			Me.xrCrossTabCell3.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
			Me.xrCrossTabCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell3.RowIndex = 0
			Me.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell3.TextFormatString = "{0:MMM, yyyy}"
			' 
			' xrCrossTabCell4
			' 
			Me.xrCrossTabCell4.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell4.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell4.BorderWidth = 1F
			Me.xrCrossTabCell4.ColumnIndex = 0
			Me.xrCrossTabCell4.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
			Me.xrCrossTabCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell4.RowIndex = 1
			Me.xrCrossTabCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell5
			' 
			Me.xrCrossTabCell5.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell5.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell5.BorderWidth = 1F
			Me.xrCrossTabCell5.ColumnIndex = 2
			Me.xrCrossTabCell5.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
			Me.xrCrossTabCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell5.RowIndex = 0
			Me.xrCrossTabCell5.Text = "Grand Total"
			Me.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell6
			' 
			Me.xrCrossTabCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell6.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell6.BorderWidth = 1F
			Me.xrCrossTabCell6.ColumnIndex = 2
			Me.xrCrossTabCell6.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
			Me.xrCrossTabCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell6.RowIndex = 1
			Me.xrCrossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell7
			' 
			Me.xrCrossTabCell7.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell7.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell7.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell7.BorderWidth = 1F
			Me.xrCrossTabCell7.ColumnIndex = 0
			Me.xrCrossTabCell7.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
			Me.xrCrossTabCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell7.RowIndex = 2
			Me.xrCrossTabCell7.Text = "Grand Total"
			Me.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell8
			' 
			Me.xrCrossTabCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell8.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell8.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell8.BorderWidth = 1F
			Me.xrCrossTabCell8.ColumnIndex = 1
			Me.xrCrossTabCell8.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
			Me.xrCrossTabCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell8.RowIndex = 2
			Me.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell9
			' 
			Me.xrCrossTabCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell9.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell9.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell9.BorderWidth = 1F
			Me.xrCrossTabCell9.ColumnIndex = 2
			Me.xrCrossTabCell9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
			Me.xrCrossTabCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell9.RowIndex = 2
			Me.xrCrossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedField1})
			Me.DataMember = "Orders"
			Me.DataSource = Me.sqlDataSource1
			Me.Landscape = True
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 48, 49)
			Me.PageHeight = 850
			Me.PageWidth = 1100
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
			Me.Version = "19.2"
			Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private DataField As DevExpress.XtraReports.UI.XRControlStyle
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
		Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField
		Private xrCrossTab1 As DevExpress.XtraReports.UI.XRCrossTab
		Private xrCrossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	End Class
End Namespace
