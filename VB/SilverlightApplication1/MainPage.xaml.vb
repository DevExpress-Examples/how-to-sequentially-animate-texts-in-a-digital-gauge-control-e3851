Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System
Imports DevExpress.Xpf.Gauges

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCreepingLineAnimationCompleted(ByVal sender As Object, ByVal e As EventArgs)
			Dim blinking As New BlinkingAnimation()
			matrix.Animation = blinking
			digitalGaugeControl1.Text = "www.devexpress.com"
		End Sub

	End Class
End Namespace
