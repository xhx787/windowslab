using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace WPFTest.UI
{
    public class ChildPage : Page, IChildEvents
    {

        public MainWindow parentWindow;

#pragma warning disable 

        public event ChildEventHandler WaitIconEvent;
        public event ChildEventHandler NextEvent;
        public event ChildEventHandler QuitEvent;

#pragma warning restore 

        public object m_objectCur;
        public object ObjectCur { get { return m_objectCur; } set { m_objectCur = value; } }

        protected virtual void FireQuitEvent(object e)
        {
            //实例化委托事件，并发起调用
            ChildEventHandler handler = QuitEvent;
            if (handler != null)
                handler(e);
        }

        protected virtual void FireNextEvent(object e)
        {
            ChildEventHandler handler = NextEvent;
            if (handler != null)
                handler(e);
        }

        protected virtual void FireWaitIconEvent(object e)
        {
            ChildEventHandler handler = WaitIconEvent;
            if (handler != null)
                handler(e);
        }

        protected void btnLeftButtonUp_base(object sender, MouseEventArgs e)
        {
            if (ObjectCur != null)
            {
                ((Button)m_objectCur).Foreground = (SolidColorBrush)this.Resources["menu_foreground"];
            }
            ((Button)sender).Foreground = (SolidColorBrush)this.Resources["menu_foreground_hot"];

            ObjectCur = (Button)sender;
        }

        protected void btnClick_base(object sender, RoutedEventArgs e)
        {
            if (ObjectCur != null)
            {
                ((Button)m_objectCur).Foreground = (SolidColorBrush)this.Resources["menu_foreground"];
            }
            ((Button)sender).Foreground = (SolidColorBrush)this.Resources["menu_foreground_hot"];

            ObjectCur = (Button)sender;
        }
    }
}
