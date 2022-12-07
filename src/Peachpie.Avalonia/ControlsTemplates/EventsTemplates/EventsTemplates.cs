using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.LogicalTree;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Styling;
using Pchp.Core;
using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ApplicationEventsTemplates
{
    public static PhpValue OnResourcesChanged(Application control, Action<ResourcesChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h));

    public static PhpValue OnUrlsOpened(Application control, Action<UrlOpenedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<UrlOpenedEventArgs>)((_, args) => action(args)),
            h => control.UrlsOpened += h));
}

public static class AutoCompleteBoxEventsTemplates
{
    public static PhpValue OnTextChanged(AutoCompleteBox control, Action<TextChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h));

    public static PhpValue OnPopulating(AutoCompleteBox control, Action<PopulatingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PopulatingEventArgs>)((_, args) => action(args)),
            h => control.Populating += h));

    public static PhpValue OnPopulated(AutoCompleteBox control, Action<PopulatedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PopulatedEventArgs>)((_, args) => action(args)),
            h => control.Populated += h));

    public static PhpValue OnDropDownOpening(AutoCompleteBox control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownOpening += h));

    public static PhpValue OnDropDownOpened(AutoCompleteBox control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownOpened += h));

    public static PhpValue OnDropDownClosing(AutoCompleteBox control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownClosing += h));

    public static PhpValue OnDropDownClosed(AutoCompleteBox control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownClosed += h));

    public static PhpValue OnSelectionChanged(AutoCompleteBox control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}

public static class ButtonEventsTemplates
{
    public static PhpValue OnClick(Button control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Click += h));
}

public static class CalendarDatePickerEventsTemplates
{
    public static PhpValue OnCalendarClosed(CalendarDatePicker control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarClosed += h));

    public static PhpValue OnCalendarOpened(CalendarDatePicker control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarOpened += h));

    public static PhpValue OnDateValidationError(CalendarDatePicker control,
        Action<CalendarDatePickerDateValidationErrorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<CalendarDatePickerDateValidationErrorEventArgs>)((_, args) => action(args)),
            h => control.DateValidationError += h));

    public static PhpValue
        OnSelectedDateChanged(CalendarDatePicker control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h));
}

public static class CalendarEventsTemplates
{
    public static PhpValue OnSelectedDatesChanged(Calendar control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDatesChanged += h));

    public static PhpValue OnDisplayDateChanged(Calendar control, Action<CalendarDateChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CalendarDateChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayDateChanged += h));

    public static PhpValue OnDisplayModeChanged(Calendar control, Action<CalendarModeChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CalendarModeChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayModeChanged += h));
}

public static class ContextMenuEventsTemplates
{
    public static PhpValue OnContextMenuOpening(ContextMenu control, Action action) =>
        PhpValue.FromClass(control._setEvent((CancelEventHandler)((_, args) => action()),
            h => control.ContextMenuOpening += h));

    public static PhpValue OnContextMenuClosing(ContextMenu control, Action action) =>
        PhpValue.FromClass(control._setEvent((CancelEventHandler)((_, args) => action()),
            h => control.ContextMenuClosing += h));
}

public static class ControlEventsTemplates
{
    public static PhpValue OnContextRequested(Control control, Action<ContextRequestedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ContextRequestedEventArgs>)((_, args) => action(args)),
            h => control.ContextRequested += h));

    public static PhpValue OnLoaded(Control control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Loaded += h));

    public static PhpValue OnUnloaded(Control control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Unloaded += h));

    public static PhpValue OnSizeChanged(Control control, Action<SizeChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SizeChangedEventArgs>)((_, args) => action(args)),
            h => control.SizeChanged += h));
}

public static class DatePickerEventsTemplates
{
    public static PhpValue OnSelectedDateChanged(DatePicker control,
        Action<DatePickerSelectedValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<DatePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h));
}

public static class TimePickerEventsTemplates
{
    public static PhpValue OnSelectedTimeChanged(TimePicker control,
        Action<TimePickerSelectedValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<TimePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedTimeChanged += h));
}

public static class MenuBaseEventsTemplates
{
    public static PhpValue OnMenuOpened(MenuBase control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.MenuOpened += h));

    public static PhpValue OnMenuClosed(MenuBase control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.MenuClosed += h));
}

public static class MenuItemEventsTemplates
{
    public static PhpValue OnClick(MenuItem control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Click += h));

    public static PhpValue OnPointerEnteredItem(MenuItem control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerEnteredItem += h));

    public static PhpValue OnPointerExitedItem(MenuItem control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerExitedItem += h));

    public static PhpValue OnSubmenuOpened(MenuItem control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.SubmenuOpened += h));
}

public static class NativeMenuEventsTemplates
{
    public static PhpValue OnNeedsUpdate(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.NeedsUpdate += h));

    public static PhpValue OnOpening(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Opening += h));

    public static PhpValue OnClosed(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Closed += h));
}

public static class NativeMenuItemEventsTemplates
{
    public static PhpValue OnClick(NativeMenuItem control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Click += h));
}

public static class NumericUpDownEventsTemplates
{
    public static PhpValue OnSpinned(NumericUpDown control, Action<SpinEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)),
            h => control.Spinned += h));

    public static PhpValue OnValueChanged(NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<NumericUpDownValueChangedEventArgs>)((_, args) => action(args)),
            h => control.ValueChanged += h));
}

public static class ItemsRepeaterEventsTemplates
{
    public static PhpValue OnElementClearing(ItemsRepeater control,
        Action<ItemsRepeaterElementClearingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementClearingEventArgs>)((_, args) => action(args)),
            h => control.ElementClearing += h));

    public static PhpValue OnElementIndexChanged(ItemsRepeater control,
        Action<ItemsRepeaterElementIndexChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementIndexChangedEventArgs>)((_, args) => action(args)),
            h => control.ElementIndexChanged += h));

    public static PhpValue OnElementPrepared(ItemsRepeater control,
        Action<ItemsRepeaterElementPreparedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementPreparedEventArgs>)((_, args) => action(args)),
            h => control.ElementPrepared += h));
}

public static class ScrollViewerEventsTemplates
{
    public static PhpValue OnScrollChanged(ScrollViewer control, Action<ScrollChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ScrollChangedEventArgs>)((_, args) => action(args)),
            h => control.ScrollChanged += h));
}

public static class SelectableTextBlockEventsTemplates
{
    public static PhpValue OnCopyingToClipboard(SelectableTextBlock control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CopyingToClipboard += h));
}

public static class SpinnerEventsTemplates
{
    public static PhpValue OnSpin(Spinner control, Action<SpinEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)),
            h => control.Spin += h));
}

public static class SplitButtonEventsTemplates
{
    public static PhpValue OnClick(SplitButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Click += h));
}

public static class ToggleSplitButtonEventsTemplates
{
    public static PhpValue OnIsCheckedChanged(ToggleSplitButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.IsCheckedChanged += h));
}

public static class SplitViewEventsTemplates
{
    public static PhpValue OnPaneClosed(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneClosed += h));

    public static PhpValue OnPaneClosing(SplitView control, Action<SplitViewPaneClosingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SplitViewPaneClosingEventArgs>)((_, args) => action(args)),
            h => control.PaneClosing += h));

    public static PhpValue OnPaneOpened(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneOpened += h));

    public static PhpValue OnPaneOpening(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneOpening += h));
}

public static class TextBoxEventsTemplates
{
    public static PhpValue OnCopyingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CopyingToClipboard += h));

    public static PhpValue OnCuttingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CuttingToClipboard += h));

    public static PhpValue OnPastingFromClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.PastingFromClipboard += h));

    public static PhpValue OnTextChanged(TextBox control, Action<TextChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h));

    public static PhpValue OnTextChanging(TextBox control, Action<TextChangingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangingEventArgs>)((_, args) => action(args)),
            h => control.TextChanging += h));
}

public static class TopLevelEventsTemplates
{
    public static PhpValue OnOpened(TopLevel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));

    public static PhpValue OnClosed(TopLevel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h));
}

public static class TrayIconEventsTemplates
{
    public static PhpValue OnClicked(TrayIcon control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Clicked += h));
}

public static class TreeViewEventsTemplates
{
    public static PhpValue OnSelectionChanged(TreeView control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}

public static class WindowEventsTemplates
{
    public static PhpValue OnClosing(Window control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.Closing += h));
}

public static class WindowBaseEventsTemplates
{
    public static PhpValue OnActivated(WindowBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Activated += h));

    public static PhpValue OnDeactivated(WindowBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Deactivated += h));

    public static PhpValue OnPositionChanged(WindowBase control, Action<PixelPointEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PixelPointEventArgs>)((_, args) => action(args)),
            h => control.PositionChanged += h));
}

public static class TextPresenterEventsTemplates
{
    public static PhpValue OnCaretBoundsChanged(TextPresenter control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.CaretBoundsChanged += h));
}

public static class NotificationCardEventsTemplates
{
    public static PhpValue OnNotificationClosed(NotificationCard control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.NotificationClosed += h));
}

public static class CalendarButtonEventsTemplates
{
    public static PhpValue
        OnCalendarLeftMouseButtonDown(CalendarButton control, Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonDown += h));

    public static PhpValue
        OnCalendarLeftMouseButtonUp(CalendarButton control, Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonUp += h));
}

public static class CalendarDayButtonEventsTemplates
{
    public static PhpValue OnCalendarDayButtonMouseDown(CalendarDayButton control,
        Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.CalendarDayButtonMouseDown += h));

    public static PhpValue OnCalendarDayButtonMouseUp(CalendarDayButton control,
        Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.CalendarDayButtonMouseUp += h));
}

public static class DateTimePickerPanelEventsTemplates
{
    public static PhpValue OnScrollInvalidated(DateTimePickerPanel control, Action action) =>
        PhpValue.FromClass(
            control._setEvent((EventHandler)((_, args) => action()), h => control.ScrollInvalidated += h));

    public static PhpValue OnSelectionChanged(DateTimePickerPanel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.SelectionChanged += h));
}

public static class PickerPresenterBaseEventsTemplates
{
    public static PhpValue OnConfirmed(PickerPresenterBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Confirmed += h));

    public static PhpValue OnDismissed(PickerPresenterBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Dismissed += h));
}

public static class FlyoutBaseEventsTemplates
{
    public static PhpValue OnClosed(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h));

    public static PhpValue OnClosing(FlyoutBase control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.Closing += h));

    public static PhpValue OnOpened(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));

    public static PhpValue OnOpening(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opening += h));
}

public static class PopupEventsTemplates
{
    public static PhpValue OnClosed(Popup control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Closed += h));

    public static PhpValue OnOpened(Popup control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));
}

public static class ScrollBarEventsTemplates
{
    public static PhpValue OnScroll(ScrollBar control, Action<ScrollEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ScrollEventArgs>)((_, args) => action(args)),
            h => control.Scroll += h));
}

public static class SelectingItemsControlEventsTemplates
{
    public static PhpValue
        OnSelectionChanged(SelectingItemsControl control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}

public static class TemplatedControlEventsTemplates
{
    public static PhpValue OnTemplateApplied(TemplatedControl control, Action<TemplateAppliedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TemplateAppliedEventArgs>)((_, args) => action(args)),
            h => control.TemplateApplied += h));
}

public static class ThumbEventsTemplates
{
    public static PhpValue OnDragStarted(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragStarted += h));

    public static PhpValue OnDragDelta(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragDelta += h));

    public static PhpValue OnDragCompleted(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragCompleted += h));
}

public static class ToggleButtonEventsTemplates
{
    public static PhpValue OnChecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Checked += h));

    public static PhpValue OnUnchecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Unchecked += h));

    public static PhpValue OnIndeterminate(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Indeterminate += h));
}

public static class AvaloniaObjectEventsTemplates
{
    public static PhpValue OnPropertyChanged(AvaloniaObject control, Action<AvaloniaPropertyChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<AvaloniaPropertyChangedEventArgs>)((_, args) => action(args)),
            h => control.PropertyChanged += h));
}

public static class StyledElementEventsTemplates
{
    public static PhpValue
        OnAttachedToLogicalTree(StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToLogicalTree += h));

    public static PhpValue OnDetachedFromLogicalTree(StyledElement control,
        Action<LogicalTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromLogicalTree += h));

    public static PhpValue OnDataContextChanged(StyledElement control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.DataContextChanged += h));

    public static PhpValue OnInitialized(StyledElement control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Initialized += h));

    public static PhpValue OnResourcesChanged(StyledElement control, Action<ResourcesChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h));
}

public static class VisualEventsTemplates
{
    public static PhpValue OnAttachedToVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToVisualTree += h));

    public static PhpValue OnDetachedFromVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromVisualTree += h));
}

public static class StyleBaseEventsTemplates
{
    public static PhpValue OnOwnerChanged(StyleBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h));
}

public static class StylesEventsTemplates
{
    public static PhpValue OnCollectionChanged(Styles control, Action action) =>
        PhpValue.FromClass(control._setEvent((NotifyCollectionChangedEventHandler)((_, args) => action()),
            h => control.CollectionChanged += h));

    public static PhpValue OnOwnerChanged(Styles control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h));
}

public static class AttachedLayoutEventsTemplates
{
    public static PhpValue OnMeasureInvalidated(AttachedLayout control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.MeasureInvalidated += h));

    public static PhpValue OnArrangeInvalidated(AttachedLayout control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.ArrangeInvalidated += h));
}

public static class LayoutableEventsTemplates
{
    public static PhpValue OnEffectiveViewportChanged(Layoutable control,
        Action<EffectiveViewportChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<EffectiveViewportChangedEventArgs>)((_, args) => action(args)),
            h => control.EffectiveViewportChanged += h));

    public static PhpValue OnLayoutUpdated(Layoutable control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.LayoutUpdated += h));
}

public static class InputElementEventsTemplates
{
    public static PhpValue OnGotFocus(InputElement control, Action<GotFocusEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<GotFocusEventArgs>)((_, args) => action(args)),
            h => control.GotFocus += h));

    public static PhpValue OnLostFocus(InputElement control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.LostFocus += h));

    public static PhpValue OnKeyDown(InputElement control, Action<KeyEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<KeyEventArgs>)((_, args) => action(args)),
            h => control.KeyDown += h));

    public static PhpValue OnKeyUp(InputElement control, Action<KeyEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<KeyEventArgs>)((_, args) => action(args)),
            h => control.KeyUp += h));

    public static PhpValue OnTextInput(InputElement control, Action<TextInputEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextInputEventArgs>)((_, args) => action(args)),
            h => control.TextInput += h));

    public static PhpValue OnTextInputMethodClientRequested(InputElement control,
        Action<TextInputMethodClientRequestedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<TextInputMethodClientRequestedEventArgs>)((_, args) => action(args)),
            h => control.TextInputMethodClientRequested += h));

    public static PhpValue OnPointerEntered(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerEntered += h));

    public static PhpValue OnPointerExited(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerExited += h));

    public static PhpValue OnPointerMoved(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerMoved += h));

    public static PhpValue OnPointerPressed(InputElement control, Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.PointerPressed += h));

    public static PhpValue OnPointerReleased(InputElement control, Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.PointerReleased += h));

    public static PhpValue OnPointerCaptureLost(InputElement control, Action<PointerCaptureLostEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerCaptureLostEventArgs>)((_, args) => action(args)),
            h => control.PointerCaptureLost += h));

    public static PhpValue OnPointerWheelChanged(InputElement control, Action<PointerWheelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerWheelEventArgs>)((_, args) => action(args)),
            h => control.PointerWheelChanged += h));

    public static PhpValue OnTapped(InputElement control, Action<TappedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TappedEventArgs>)((_, args) => action(args)),
            h => control.Tapped += h));

    public static PhpValue OnDoubleTapped(InputElement control, Action<TappedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TappedEventArgs>)((_, args) => action(args)),
            h => control.DoubleTapped += h));
}

public static class BrushEventsTemplates
{
    public static PhpValue OnInvalidated(Brush control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}

public static class DashStyleEventsTemplates
{
    public static PhpValue OnInvalidated(DashStyle control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}

public static class DrawingImageEventsTemplates
{
    public static PhpValue OnInvalidated(DrawingImage control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}

public static class ExperimentalAcrylicMaterialEventsTemplates
{
    public static PhpValue OnInvalidated(ExperimentalAcrylicMaterial control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}

public static class GeometryEventsTemplates
{
    public static PhpValue OnChanged(Geometry control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h));
}

public static class PenEventsTemplates
{
    public static PhpValue OnInvalidated(Pen control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}

public static class TransformEventsTemplates
{
    public static PhpValue OnChanged(Transform control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h));
}

public static class CroppedBitmapEventsTemplates
{
    public static PhpValue OnInvalidated(CroppedBitmap control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}