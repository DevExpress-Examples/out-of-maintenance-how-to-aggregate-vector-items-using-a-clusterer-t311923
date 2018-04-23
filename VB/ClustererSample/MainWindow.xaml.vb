Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace ClustererSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MarkerClusterer_Clustered(ByVal sender As Object, ByVal e As ClusteredEventArgs)
            map.ZoomToFitLayerItems()
        End Sub
    End Class
End Namespace
