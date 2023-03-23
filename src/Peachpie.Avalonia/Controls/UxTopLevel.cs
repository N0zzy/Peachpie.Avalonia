﻿using Avalonia.Controls;
using Avalonia.Layout;

namespace Peachpie.Avalonia.Controls;

public abstract class UxTopLevel<T> : UxContentControl<T> where T : TopLevel
{
   
}

public abstract class UxTopLevel : UxTopLevel<TopLevel>
{
    
}

