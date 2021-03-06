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
using Articy.Eai;

namespace Articy.Eai.Features
{
    
    
    [Serializable()]
    public class IndiceFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private String mnature_indice;
        
        public String nature_indice
        {
            get
            {
                return mnature_indice;
            }
            set
            {
                mnature_indice = value;
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.Eai.Features.IndiceFeature newClone = ((Articy.Eai.Features.IndiceFeature)(aClone));
            newClone.nature_indice = nature_indice;
        }
        
        public object CloneObject()
        {
            Articy.Eai.Features.IndiceFeature clone = new Articy.Eai.Features.IndiceFeature();
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
            if ((aProperty == "nature_indice"))
            {
                nature_indice = System.Convert.ToString(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "nature_indice"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(nature_indice);
            }
            return null;
        }
        #endregion
    }
}
