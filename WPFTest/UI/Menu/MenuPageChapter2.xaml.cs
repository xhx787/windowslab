using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest.UI.Menu
{
    /// <summary>
    /// MenuPageChapter2.xaml 的交互逻辑
    /// </summary>
    public partial class MenuPageChapter2 : ChildPage
    {
        public MenuPageChapter2()
        {
            m_objectCur = null;

            InitializeComponent();
        }

        private void ChildPage_Loaded(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter2_sy1");
        }

        private void sy1_Click(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter2_sy1");
            btnClick_base(sender, e);
        }

        private void sy2_Click(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter2_sy2");
            btnClick_base(sender, e);
        }

        private void sy3_Click(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter2_sy3");
            btnClick_base(sender, e);
        }
    }
}
