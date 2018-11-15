<!-- default file list -->
*Files to look at*:

* [App.xaml.cs](./CS/App.xaml.cs) (VB: [App.xaml.vb](./VB/ColosSchemesDemo1/App.xaml.vb))
* [MainPage.xaml](./CS/MainPage.xaml) (VB: [MainPage.xaml](./VB/ColosSchemesDemo1/MainPage.xaml))
* [MainPage.xaml.cs](./CS/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/ColosSchemesDemo1/MainPage.xaml))
* [MainViewModel.cs](./CS/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ColosSchemesDemo1/MainViewModel.vb))
* [RichEditEx.cs](./CS/RichEditEx.cs) (VB: [RichEditEx.vb](./VB/ColosSchemesDemo1/RichEditEx.vb))
* [ThemeFriendlyNameConverter.cs](./CS/ThemeFriendlyNameConverter.cs) (VB: [ThemeFriendlyNameConverter.vb](./VB/ColosSchemesDemo1/ThemeFriendlyNameConverter.vb))
* [generic.xaml](./CS/Themes/generic.xaml) (VB: [generic.xaml](./VB/ColosSchemesDemo1/Themes/generic.xaml))
<!-- default file list end -->
# Override default colors from an existing Color Scheme and support system themes


<p>This example illustrates how to override the default scheme colors for Windows 10 XAML controls and support system themes (Light, Default). With the current implementation, the RibbonControl header background is overridden in the Generic and Win8 schemes and has different values in these schemes for the Default and Light system themes.</p>
<p> </p>
<p>Starting with v17.1, colors can be defined in code by overriding specific values in related ThemeManager dictionaries.</p>
<p><strong> </strong></p>
<p>Note that the <strong>Dark </strong>system theme is determined as <strong>Default</strong>, so our theme manager uses the same colors for these themes in the Generic color scheme.</p>
<p><br>If you wish to do this in an older version, refer to the <a href="https://www.devexpress.com/Support/Center/p/T404208">How to override default colors from an existing Color Scheme in Windows 10 XAML controls and support system themes (Light, Default) [Deprecated]</a> example for a solution.</p>

<br/>


