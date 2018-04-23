Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace StockCharting
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#code"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim stockChart As New ChartControl()

			' Create a stock series.
			Dim series1 As New Series("Series 1", ViewType.Stock)

			' Specify the date-time argument scale type for the series,
			' as it is qualitative, by default.
			series1.ArgumentScaleType = ScaleType.DateTime

			' Add points to it.
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 1), New Object() { 24.00, 25.00, 25.00, 24.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 2), New Object() { 23.625, 25.125, 24.00, 24.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 3), New Object() { 26.25, 28.25, 26.75, 27.00 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 4), New Object() { 26.50, 27.875, 26.875, 27.25 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 7), New Object() { 26.375, 27.50, 27.375, 26.75 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 8), New Object() { 25.75, 26.875, 26.75, 26.00 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 9), New Object() { 25.75, 26.75, 26.125, 26.25 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 10), New Object() { 25.75, 26.375, 26.375, 25.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 11), New Object() { 24.875, 26.125, 26.00, 25.375 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 14), New Object() { 25.125, 26.00, 25.625, 25.75 }))

			' Add the series to the chart.
			stockChart.Series.Add(series1)

			' Access the view-type-specific options of the series.
			Dim myView As StockSeriesView = CType(series1.View, StockSeriesView)

			myView.LineThickness = 2
			myView.LevelLineLength = 0.25

			' Specify the series reduction options.
			myView.ReductionOptions.Level = StockLevel.Close
			myView.ReductionOptions.Visible = True

			' Access the chart's diagram.
			Dim diagram As XYDiagram = (CType(stockChart.Diagram, XYDiagram))

			' Access the type-specific options of the diagram.
			diagram.AxisY.WholeRange.MinValue = 22

			' Exclude weekends from the X-axis range,
			' to avoid gaps in the chart's data.
			diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly = True

			' Hide the legend (if necessary).
			stockChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			stockChart.Titles.Add(New ChartTitle())
			stockChart.Titles(0).Text = "Stock Chart"

			' Add the chart to the form.
			stockChart.Dock = DockStyle.Fill
			Me.Controls.Add(stockChart)
		End Sub
		#End Region ' #code

	End Class
End Namespace
