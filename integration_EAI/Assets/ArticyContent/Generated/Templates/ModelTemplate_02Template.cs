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
    public class ModelTemplate_02Template : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValuedialogueFeature mdialogue = new ArticyValuedialogueFeature();
        
        public Articy.Eai.Features.dialogueFeature dialogue
        {
            get
            {
                return mdialogue.GetValue();
            }
            set
            {
                mdialogue.SetValue(value);
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.Eai.Templates.ModelTemplate_02Template newClone = ((Articy.Eai.Templates.ModelTemplate_02Template)(aClone));
            if ((dialogue != null))
            {
                newClone.dialogue = ((Articy.Eai.Features.dialogueFeature)(dialogue.CloneObject()));
            }
        }
        
        public object CloneObject()
        {
            Articy.Eai.Templates.ModelTemplate_02Template clone = new Articy.Eai.Templates.ModelTemplate_02Template();
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
                if ((featurePath == "dialogue"))
                {
                    dialogue.setProp(featureProperty, aValue);
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
                if ((featurePath == "dialogue"))
                {
                    return dialogue.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}
