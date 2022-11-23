using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

    /// <summary>
    /// Displays <see cref="ContentControlTemplate.Content"/> according to a <see cref="FuncDataTemplate"/>.
    /// </summary>

    public class ContentControlTemplate : ContentControl
{
        
        /// <summary>
        /// 
        /// </summary>
        private readonly IDictionary<string, PhpValue> _dataContent;
        
        public ContentControlTemplate()
        {
            _dataContent = new Dictionary<string, PhpValue>();

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
         public PhpValue this[string key]
         {
             get {
                 return _dataContent[key];
             }
             set
             {
                 _dataContent[key] = value;
             }
         }

}

