using System.Windows.Controls;
using System;
using DevExpress.Xpf.Gauges;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void OnCreepingLineAnimationCompleted(object sender, EventArgs e) {
            BlinkingAnimation blinking = new BlinkingAnimation();
            matrix.Animation = blinking;
            digitalGaugeControl1.Text = "www.devexpress.com";
        }

    }
}
