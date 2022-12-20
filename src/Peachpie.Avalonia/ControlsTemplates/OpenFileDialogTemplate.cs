using System;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates;

public class OpenFileDialogEventArgs: EventArgs
{
    public string Files { get; set; }
}

/// <summary>
/// Represents a system dialog that allows the user to select one or more files to open.
/// </summary>
[Obsolete("Use Window.StorageProvider API or TopLevel.StorageProvider API")]
public class OpenFileDialogTemplate : OpenFileDialog
{
    public delegate void OpenFileDialogHandler(string[] files);
    
    public event OpenFileDialogHandler FileSelected;
    
    public async Task Open(WindowTemplate window, Action<OpenFileDialogEventArgs> action )
    {
        var dialog = new OpenFileDialog();
        string[] result;
        
        result = await dialog.ShowAsync(window);

        if (result != null)
        {
            FileSelected?.Invoke(result);
        }
    }
    
}

