using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace PseudoDemo
{
    //Add PseudoClasses to the Control Class
    [PseudoClasses(":test")]
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();
            //Init the default value for the Control
            UpdatePseudoClasses(false);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void InputElement_OnPointerEnter(object? sender, PointerEventArgs e)
        {
            UpdatePseudoClasses(true);
        }

        private void InputElement_OnPointerLeave(object? sender, PointerEventArgs e)
        {
            UpdatePseudoClasses(false);
        }
        
        //This updates whether the current PseudoClass is active or not (I just took this from Button)
        private void UpdatePseudoClasses(bool isCustomPointerOver)
        {
            PseudoClasses.Set(":test", isCustomPointerOver);
        }
    }
}