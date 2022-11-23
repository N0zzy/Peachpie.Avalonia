﻿using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class RepeatButtonTemplate : RepeatButton, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(RepeatButton);

}