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
    public class ModelTemplate_05Template : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueIndiceFeature mIndice = new ArticyValueIndiceFeature();
        
        public Articy.Eai.Features.IndiceFeature Indice
        {
            get
            {
                return mIndice.GetValue();
            }
            set
            {
                mIndice.SetValue(value);
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.Eai.Templates.ModelTemplate_05Template newClone = ((Articy.Eai.Templates.ModelTemplate_05Template)(aClone));
            if ((Indice != null))
            {
                newClone.Indice = ((Articy.Eai.Features.IndiceFeature)(Indice.CloneObject()));
            }
        }
        
        public object CloneObject()
        {
            Articy.Eai.Templates.ModelTemplate_05Template clone = new Articy.Eai.Templates.ModelTemplate_05Template();
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
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "Indice"))
                {
                    Indice.setProp(featureProperty, aValue);
                }
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "Indice"))
                {
                    return Indice.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}
