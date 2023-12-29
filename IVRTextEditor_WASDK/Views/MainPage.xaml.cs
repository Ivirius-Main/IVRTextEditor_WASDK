using System.Collections.ObjectModel;
using IVRTextEditor_WASDK.ViewModels;
using IVRTextEditor_WASDK;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Shapes;
using Microsoft.UI;
using Microsoft.UI.Composition.SystemBackdrops;

namespace IVRTextEditor_WASDK.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        this.NavigationCacheMode = Microsoft.UI.Xaml.Navigation.NavigationCacheMode.Required;
    }



    public List<string> Fonts
    {
        get
        {
            return CanvasTextFormat.GetSystemFontFamilies().OrderBy(f => f).ToList();
        }
    }

    public ObservableCollection<double> ZoomOptions { get; } = new ObservableCollection<double> { 8, 7, 6, 5, 4, 3, 2, 1, 0.75, 0.5, 0.25, 0.125 };

    public List<double> FontSizes
    {
        get;
    } = new List<double>()
            {
                8,
                9,
                10,
                11,
                12,
                14,
                16,
                18,
                20,
                24,
                28,
                36,
                48,
                72
            };

    private void Paste_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {

    }

    private void Cut_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Copy_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void IncreaseFontSize_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void DecreaseFontSize_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void BoldButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (ST != null)
        {
            FormatEffect CF = ST.CharacterFormat.Bold;
            switch (CF)
            {
                case FormatEffect.Off:
                    CF = FormatEffect.On;
                    break;
                default:
                    CF = FormatEffect.Off;
                    break;
            }
            ST.CharacterFormat.Bold = CF;
        }
    }

    private void ItalicButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (ST != null)
        {
            FormatEffect CF = ST.CharacterFormat.Italic;
            switch (CF)
            {
                case FormatEffect.Off:
                    CF = FormatEffect.On;
                    break;
                default:
                    CF = FormatEffect.Off;
                    break;
            }
            ST.CharacterFormat.Italic = CF;
        }
    }

    private void UnderlineButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        var MFItem = (MenuFlyoutItem)sender;
        ITextSelection ST = Editor.Document.Selection;
        if (!(ST == null))
        {
            UnderlineType CF = ST.CharacterFormat.Underline;
            if (MFItem.Text == "None") CF = UnderlineType.None;
            if (MFItem.Text == "Single") CF = UnderlineType.Single;
            if (MFItem.Text == "Dash") CF = UnderlineType.Dash;
            if (MFItem.Text == "Dotted") CF = UnderlineType.Dotted;
            if (MFItem.Text == "Double") CF = UnderlineType.Double;
            if (MFItem.Text == "Thick") CF = UnderlineType.Thick;
            if (MFItem.Text == "Wave") CF = UnderlineType.Wave;
            ST.CharacterFormat.Underline = CF;
        }
    }

    private void StrikethroughButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (ST != null)
        {
            FormatEffect CF = ST.CharacterFormat.Strikethrough;
            switch (CF)
            {
                case FormatEffect.Off:
                    CF = FormatEffect.On;
                    break;
                default:
                    CF = FormatEffect.Off;
                    break;
            }
            ST.CharacterFormat.Strikethrough = CF;
        }
    }

    private void SubscriptButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (!(ST == null))
        {
            FormatEffect CF = ST.CharacterFormat.Subscript;
            switch (CF)
            {
                case FormatEffect.Off:
                    CF = FormatEffect.On;
                    SubscriptButton.IsChecked = true;
                    break;
                default:
                    CF = FormatEffect.Off;
                    SubscriptButton.IsChecked = false;
                    break;
            }
            ST.CharacterFormat.Subscript = CF;
        }
    }

    private void SuperscriptButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (!(ST == null))
        {
            FormatEffect CF = ST.CharacterFormat.Superscript;
            switch (CF)
            {
                case FormatEffect.Off:
                    CF = FormatEffect.On;
                    SuperscriptButton.IsChecked = true;
                    break;
                default:
                    CF = FormatEffect.Off;
                    SuperscriptButton.IsChecked = false;
                    break;
            }
            ST.CharacterFormat.Superscript = CF;
        }
    }

    private void FontSizeCombo_TextSubmitted(ComboBox sender, ComboBoxTextSubmittedEventArgs args)
    {

    }

    private void fontSizeComboBox_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void FontSizeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void BackColorButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AlignLeftButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AlignCenterButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AlignRightButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AlignJustifyButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void ParagraphButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void NoneNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void DottedNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void NumberNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void LetterSmallNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void LetterBigNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void SmalliNumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void BigINumeral_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Button_Click_2(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AddImageButton_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {

    }

    private void Button_Click_4Async(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Button_Click_3Async(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void FindButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void RemoveHighlightButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void EditorContentHost_SizeChanged(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs e)
    {

    }

    private void editor_SelectionChanged(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Editor_TextChanged(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void ColorButton_Click(object sender, RoutedEventArgs e)
    {
        // Extract the color of the button that was clicked.
        Button clickedColor = (Button)sender;
        var borderone = (Border)clickedColor.Content;
        var bordertwo = (Border)borderone.Child;
        var rectangle = (Rectangle)bordertwo.Child;
        var color = (rectangle.Fill as SolidColorBrush).Color;
        Editor.Document.Selection.CharacterFormat.ForegroundColor = color;
        //FontColorMarker.SetValue(ForegroundProperty, new SolidColorBrush(color));
        Editor.Focus(FocusState.Keyboard);
    }

    private void fontcolorsplitbutton_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {
        // If you see this, remind me to look into the splitbutton color applying logic
    }

    private void FontsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ITextSelection ST = Editor.Document.Selection;
        if (ST != null && FontsCombo.SelectedItem != null)
        {
            ST.CharacterFormat.Name = FontsCombo.SelectedItem.ToString();
        }
        else return;
    }

    private void ReplaceSelected_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void ReplaceAll_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void fontbackgroundcolorsplitbutton_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {

    }

    private void BackPicker_ColorChanged(object Sender, ColorChangedEventArgs EvArgs)
    {
        //Configure font highlight
        if (!(Editor == null))
        {
            var ST = Editor.Document.Selection;
            if (!(ST == null))
            {
                _ = ST.CharacterFormat;
                var Br = new SolidColorBrush(BackPicker.Color);
                var CF = BackPicker.Color;
                ST.CharacterFormat.BackgroundColor = CF;
            }
        }
    }

    private void HighlightButton_Click(object Sender, RoutedEventArgs EvArgs)
    {
        //Configure font color
        var BTN = Sender as Button;
        ITextSelection ST = Editor.Document.Selection;
        if (!(ST == null))
        {
            _ = ST.CharacterFormat.ForegroundColor;
            Brush Br = BTN.Foreground;
            //BackAccent.Foreground = Br;
            ST.CharacterFormat.BackgroundColor = (BTN.Foreground as SolidColorBrush).Color;
        }
    }

    private void NullHighlightButton_Click(object Sender, RoutedEventArgs EvArgs)
    {
        //Configure font color
        ITextSelection ST = Editor.Document.Selection;
        if (!(ST == null))
        {
            _ = ST.CharacterFormat.ForegroundColor;
            //BackAccent.Foreground = new SolidColorBrush(Colors.Transparent);
            ST.CharacterFormat.BackgroundColor = Colors.Transparent;
        }
    }

    private void FontSizeBox_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
    {
        if (Editor != null && Editor.Document.Selection != null)
        {
            ITextSelection selectedText = Editor.Document.Selection;
            ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            charFormatting.Size = (float)sender.Value;
            selectedText.CharacterFormat = charFormatting;
        }   
    }

    private void Segmented_ItemClick(object sender, ItemClickEventArgs e)
    {
        if (HomeTab.IsSelected == true)
        {
            ribbonhome.Visibility = Visibility.Collapsed;
            ribbonhelp.Visibility = Visibility.Visible;
        }
        else
        {
            ribbonhome.Visibility = Visibility.Visible;
            ribbonhelp.Visibility = Visibility.Collapsed;
        }
    }

    private void Settings_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(SettingsPage));
    }

    private void utever_click(object sender, RoutedEventArgs e)
    {

    }
}
