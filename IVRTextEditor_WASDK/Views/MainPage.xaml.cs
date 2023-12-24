using System.Collections.ObjectModel;
using IVRTextEditor_WASDK.ViewModels;
using IVRTextEditor_WASDK;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Text;

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

    private void fontcolorsplitbutton_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {

    }

    private void ColorButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
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

    private void fontbackgroundcolorsplitbutton_Click(SplitButton sender, SplitButtonClickEventArgs args)
    {

    }

    private void FontsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void ReplaceSelected_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void ReplaceAll_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
