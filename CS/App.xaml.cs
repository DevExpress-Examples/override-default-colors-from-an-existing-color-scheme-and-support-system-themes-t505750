using DevExpress.Core;
using DevExpress.Themes.ColorKeys;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ColosSchemesDemo1 {
    sealed partial class App : Application {
        public App() {
            OverrideThemeColors();

            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        void OverrideThemeColors() {
            ThemeManager.GenericColorScheme.AllScopes.RibbonControlColors[RibbonControlColorKeys.HeaderBackground] = new DevExpress.Themes.ColorSet(
                Color.FromArgb(0xFF, 0x41, 0x83, 0x66),
                Color.FromArgb(0xFF, 0x16, 0x4B, 0x2F));
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderItemColors[RibbonHeaderItemColorKeys.ForegroundSelected] =
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.ForegroundSelected] = new DevExpress.Themes.ColorSet(
                Color.FromArgb(0xFF, 0x41, 0x83, 0x66),
                Color.FromArgb(0xFF, 0x16, 0x4B, 0x2F));
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.Background] = Color.FromArgb(0x33, 0x00, 0x00, 0x00);
            ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.Background] = Color.FromArgb(0xAA, 0xFF, 0xFF, 0xFF);
            ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.TabContentBackground] = Colors.Transparent;
            
            ThemeManager.Win8ColorScheme.AllScopes.RibbonControlColors[RibbonControlColorKeys.HeaderBackground] = new DevExpress.Themes.ColorSet(
                Color.FromArgb(0xFF, 0x1B, 0x47, 0x8A),
                Color.FromArgb(0xFF, 0x09, 0x34, 0x67));
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.ForegroundSelected] =
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderItemColors[RibbonHeaderItemColorKeys.ForegroundSelected] = new DevExpress.Themes.ColorSet(
                Color.FromArgb(0xFF, 0x2B, 0x57, 0x9A),
                Color.FromArgb(0xFF, 0x1B, 0x47, 0x8A));
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.Background] = Color.FromArgb(0x33, 0x00, 0x00, 0x00);
            ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.Background] = Color.FromArgb(0x77, 0xFF, 0xFF, 0xFF);
            ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.TabContentBackground] = Colors.Transparent;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e) {
            Frame rootFrame = Window.Current.Content as Frame;
            if(rootFrame == null) {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootFrame;
            }

            if(e.PrelaunchActivated == false) {
                if(rootFrame.Content == null)
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);

                Window.Current.Activate();
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e) {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
        void OnSuspending(object sender, SuspendingEventArgs e) {
            e.SuspendingOperation.GetDeferral().Complete();
        }
    }
}
