using Microsoft.Maui.Controls.Shapes;

namespace SafeAreaEdgesAndroid;

public partial class CustomHeaderControl : ContentView
{
    #region StaticProperties_Icon
    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set
        {
            SetValue(IconProperty, value);
            OnPropertyChanged();
        }
    }

    public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon),
                                                                          typeof(string),
                                                                          typeof(CustomHeaderControl),
                                                                          defaultBindingMode: BindingMode.TwoWay,
                                                                          propertyChanged: OnIconPropertyChanged
                                                                         );

    private static void OnIconPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.Icon = (string)newvalue;
        control.HeaderIcon.Source = control.Icon;
        control.InvalidateMeasure();
    }
    #endregion

    #region StaticProperties_TextColor
    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set
        {
            SetValue(TextColorProperty, value);
            OnPropertyChanged();
        }
    }

    public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor),
                                                                               typeof(Color),
                                                                               typeof(CustomHeaderControl),
                                                                               defaultBindingMode: BindingMode.TwoWay,
                                                                               propertyChanged: OnTextColorPropertyChanged
                                                                              );

    private static void OnTextColorPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.TextColor = (Color)newvalue;
        control.InvalidateMeasure();
    }

    #endregion

    #region StaticProperties_BorderColor
    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set
        {
            SetValue(BorderColorProperty, value);
            OnPropertyChanged();
        }
    }

    public static BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor),
                                                                                 typeof(Color),
                                                                                 typeof(CustomHeaderControl),
                                                                                 defaultBindingMode: BindingMode.TwoWay,
                                                                                 propertyChanged: OnBorderColorPropertyChanged
                                                                                );


    private static void OnBorderColorPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.BorderColor = (Color)newvalue;
        control.InvalidateMeasure();
    }

    #endregion

    #region StaticProperties_BorderCornerRadius
    public double CornerRadius
    {
        get => (double)GetValue(CornerRadiusProperty);
        set
        {
            SetValue(CornerRadiusProperty, value);
            OnPropertyChanged();
        }
    }


    public static BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
                                                                                  typeof(double),
                                                                                  typeof(CustomHeaderControl),
                                                                                  defaultBindingMode: BindingMode.TwoWay,
                                                                                  propertyChanged: OnCornerRadiusPropertyChanged
                                                                                 );


    private static void OnCornerRadiusPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.CornerRadius = (double)newvalue;
        control.FlyoutButtonBorder.StrokeShape = new RoundRectangle() { CornerRadius = new CornerRadius(control.CornerRadius) };
        control.PageIconBorder.StrokeShape = new RoundRectangle() { CornerRadius = new CornerRadius(control.CornerRadius) };
        control.InvalidateMeasure();
    }

    #endregion

    #region StaticProperties_PageTitle
    public string PageTitle
    {
        get => (string)GetValue(PageTitleProperty);
        set
        {
            SetValue(PageTitleProperty, value);
            OnPropertyChanged();
        }
    }


    public static BindableProperty PageTitleProperty = BindableProperty.Create(nameof(CornerRadius),
                                                                               typeof(string),
                                                                               typeof(CustomHeaderControl),
                                                                               defaultBindingMode: BindingMode.TwoWay,
                                                                               propertyChanged: OnPageTitlePropertyChanged
                                                                              );


    private static void OnPageTitlePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.PageTitle = (string)newvalue;
        control.TitleLabel.Text = control.PageTitle;
        control.InvalidateMeasure();
    }

    #endregion

    #region StaticProperties_ItemsBackroundColor
    public Color ItemsBackgroundColor
    {
        get => (Color)GetValue(ItemsBackgroundColorProperty);
        set
        {
            SetValue(ItemsBackgroundColorProperty, value);
            OnPropertyChanged();
        }
    }


    public static BindableProperty ItemsBackgroundColorProperty = BindableProperty.Create(nameof(ItemsBackgroundColor),
                                                                                         typeof(Color),
                                                                                         typeof(CustomHeaderControl),
                                                                                         defaultBindingMode: BindingMode.TwoWay,
                                                                                         propertyChanged: OnItemsBackgroundColorPropertyChanged
                                                                                        );


    private static void OnItemsBackgroundColorPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (CustomHeaderControl)bindable;
        control.ItemsBackgroundColor = (Color)newvalue;
        control.FlyoutButtonBorder.BackgroundColor = (Color)newvalue;
        control.PageIconBorder.BackgroundColor = (Color)newvalue;

        control.InvalidateMeasure();
    }

    #endregion


    public CustomHeaderControl()
    {
        InitializeComponent();
    }

    private void FlyoutMenuButton_OnTapped(object? sender, TappedEventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
