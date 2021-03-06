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
    public class playerFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mSmallScriptValue = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mSmallScriptValue_02 = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mSmallScriptValue_03 = new ArticyValueArticyScriptCondition();
        
        public ArticyScriptCondition SmallScriptValue
        {
            get
            {
                return mSmallScriptValue.GetValue();
            }
            set
            {
                mSmallScriptValue.SetValue(value);
            }
        }
        
        public ArticyScriptCondition SmallScriptValue_02
        {
            get
            {
                return mSmallScriptValue_02.GetValue();
            }
            set
            {
                mSmallScriptValue_02.SetValue(value);
            }
        }
        
        public ArticyScriptCondition SmallScriptValue_03
        {
            get
            {
                return mSmallScriptValue_03.GetValue();
            }
            set
            {
                mSmallScriptValue_03.SetValue(value);
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.Eai.Features.playerFeature newClone = ((Articy.Eai.Features.playerFeature)(aClone));
            if ((SmallScriptValue != null))
            {
                newClone.SmallScriptValue = ((ArticyScriptCondition)(SmallScriptValue.CloneObject()));
            }
            if ((SmallScriptValue_02 != null))
            {
                newClone.SmallScriptValue_02 = ((ArticyScriptCondition)(SmallScriptValue_02.CloneObject()));
            }
            if ((SmallScriptValue_03 != null))
            {
                newClone.SmallScriptValue_03 = ((ArticyScriptCondition)(SmallScriptValue_03.CloneObject()));
            }
        }
        
        public object CloneObject()
        {
            Articy.Eai.Features.playerFeature clone = new Articy.Eai.Features.playerFeature();
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
            if ((aProperty == "SmallScriptValue"))
            {
                SmallScriptValue = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "SmallScriptValue_02"))
            {
                SmallScriptValue_02 = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "SmallScriptValue_03"))
            {
                SmallScriptValue_03 = ((ArticyScriptCondition)(aValue));
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "SmallScriptValue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(SmallScriptValue);
            }
            if ((aProperty == "SmallScriptValue_02"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(SmallScriptValue_02);
            }
            if ((aProperty == "SmallScriptValue_03"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(SmallScriptValue_03);
            }
            return null;
        }
        #endregion
    }
}
