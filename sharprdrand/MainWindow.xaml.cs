using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; //!!
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sharprdrand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtblk.Text = getnumber().ToString();
        }

        [DllImport("G:\\__video_sharp\\sharprdrand\\x64\\Release\\rdrand.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern long getnumber();
    }
}


//csharp_masm_dll_visual_studio