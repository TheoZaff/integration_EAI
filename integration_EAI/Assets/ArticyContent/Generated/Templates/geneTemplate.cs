// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using Articy.Unity.Interfaces;
using Articy.Unity;
using Articy.Eai.Features;
using Articy.Eai;

namespace Articy.Eai.Templates
{
    
    
    [Serializable()]
    public class geneTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        private void CloneProperties(object aClone)
        {
        }
        
        public object CloneObject()
        {
            Articy.Eai.Templates.geneTemplate clone = new Articy.Eai.Templates.geneTemplate();
            CloneProperties(clone);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            return null;
        }
        #endregion
    }
}
