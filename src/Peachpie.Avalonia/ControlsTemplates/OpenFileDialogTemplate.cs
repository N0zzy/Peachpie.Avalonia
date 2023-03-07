using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates;
/*
public class OpenFileDialogEventArgs: EventArgs
{
    public string[] SelectedFiles { get; set; }

    public OpenFileDialogEventArgs(string[] files)
    {
        SelectedFiles = files;
    }
    
}

/// <summary>
/// Represents a system dialog that allows the user to select one or more files to open.
/// </summary>
[Obsolete("Use Window.StorageProvider API or TopLevel.StorageProvider API")]
public class OpenFileDialogTemplate : OpenFileDialog
{
    public delegate void OpenFileDialogHandler(object sender, OpenFileDialogEventArgs eventArgs );
    public event OpenFileDialogHandler FileSelected;
    
    public void OnFileSelected(Action<OpenFileDialogEventArgs> action)
    {
        FileSelected += (_, args) =>  action(args);
    }

    public OpenFileDialogTemplate(PhpArray filters)
    {
        foreach (var filter in filters)
        {
            var s = filter.Value;
            Filters?.Add(new FileDialogFilter() {Name = s["Name"].ToString(), Extensions = {s[0]["Extensions"].ToString()}});
        }
    }
    
    /// <summary>
    /// Открыть диалог выбора файлов
    /// </summary>
    /// <param name="window"></param>
    public async Task Open(UxWindow window)
    {
        string[] result = await ShowAsync(window.GetWrappedObject());
        
        if (result != null)
        {
            var eventArgs = new OpenFileDialogEventArgs(result);
            FileSelected?.Invoke(this, eventArgs);
        }
    }
}

*/