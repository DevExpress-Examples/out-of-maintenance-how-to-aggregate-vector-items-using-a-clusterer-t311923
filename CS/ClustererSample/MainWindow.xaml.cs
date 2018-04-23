using System.Windows;
using DevExpress.Xpf.Map;

namespace ClustererSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MarkerClusterer_Clustered(object sender, ClusteredEventArgs e) {
            map.ZoomToFitLayerItems();
        }
    }
}
