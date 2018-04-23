Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid
Imports DXExample.DemoData

Namespace Prevent_Group_Rows_from_Expanding
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			gridControl1.ItemsSource = Invoice.GetData()
		End Sub
		Private Sub gridControl1_GroupRowExpanding(ByVal sender As Object, ByVal e As RowAllowEventArgs)
			If e.Row Is Nothing OrElse (CType(e.Row, Invoice)).Status = InvoiceStatus.Invalidated AndAlso gridControl1.Columns("Status").GroupIndex <> -1 Then
				e.Allow = False
			End If
		End Sub
	End Class
End Namespace
