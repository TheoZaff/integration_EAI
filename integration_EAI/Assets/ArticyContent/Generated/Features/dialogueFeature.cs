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
    public class dialogueFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private String mMediumTextValue_02;
        
        [SerializeField()]
        private String mMediumTextValue_03;
        
        [SerializeField()]
        private String mMediumTextValue_04;
        
        [SerializeField()]
        private String mMediumTextValue_05;
        
        [SerializeField()]
        private Single mNumberValue;
        
        [SerializeField()]
        private Boolean mBooleanValue = new Boolean();
        
        [SerializeField()]
        private Single mNumberValue_02;
        
        [SerializeField()]
        private String mMediumTextValue;
        
        [SerializeField()]
        private String mMediumTextValue_06;
        
        [SerializeField()]
        private Boolean mBooleanValue_02 = new Boolean();
        
        [SerializeField()]
        private Boolean mBooleanValue_03 = new Boolean();
        
        [SerializeField()]
        private Single mNumberValue_03;
        
        public String MediumTextValue_02
        {
            get
            {
                return mMediumTextValue_02;
            }
            set
            {
                mMediumTextValue_02 = value;
            }
        }
        
        public String MediumTextValue_03
        {
            get
            {
                return mMediumTextValue_03;
            }
            set
            {
                mMediumTextValue_03 = value;
            }
        }
        
        public String MediumTextValue_04
        {
            get
            {
                return mMediumTextValue_04;
            }
            set
            {
                mMediumTextValue_04 = value;
            }
        }
        
        public String MediumTextValue_05
        {
            get
            {
                return mMediumTextValue_05;
            }
            set
            {
                mMediumTextValue_05 = value;
            }
        }
        
        public Single NumberValue
        {
            get
            {
                return mNumberValue;
            }
            set
            {
                mNumberValue = value;
            }
        }
        
        public Boolean BooleanValue
        {
            get
            {
                return mBooleanValue;
            }
            set
            {
                mBooleanValue = value;
            }
        }
        
        public Single NumberValue_02
        {
            get
            {
                return mNumberValue_02;
            }
            set
            {
                mNumberValue_02 = value;
            }
        }
        
        public String MediumTextValue
        {
            get
            {
                return mMediumTextValue;
            }
            set
            {
                mMediumTextValue = value;
            }
        }
        
        public String MediumTextValue_06
        {
            get
            {
                return mMediumTextValue_06;
            }
            set
            {
                mMediumTextValue_06 = value;
            }
        }
        
        public Boolean BooleanValue_02
        {
            get
            {
                return mBooleanValue_02;
            }
            set
            {
                mBooleanValue_02 = value;
            }
        }
        
        public Boolean BooleanValue_03
        {
            get
            {
                return mBooleanValue_03;
            }
            set
            {
                mBooleanValue_03 = value;
            }
        }
        
        public Single NumberValue_03
        {
            get
            {
                return mNumberValue_03;
            }
            set
            {
                mNumberValue_03 = value;
            }
        }
        
        private void CloneProperties(object aClone)
        {
            Articy.Eai.Features.dialogueFeature newClone = ((Articy.Eai.Features.dialogueFeature)(aClone));
            newClone.MediumTextValue_02 = MediumTextValue_02;
            newClone.MediumTextValue_03 = MediumTextValue_03;
            newClone.MediumTextValue_04 = MediumTextValue_04;
            newClone.MediumTextValue_05 = MediumTextValue_05;
            newClone.NumberValue = NumberValue;
            newClone.BooleanValue = BooleanValue;
            newClone.NumberValue_02 = NumberValue_02;
            newClone.MediumTextValue = MediumTextValue;
            newClone.MediumTextValue_06 = MediumTextValue_06;
            newClone.BooleanValue_02 = BooleanValue_02;
            newClone.BooleanValue_03 = BooleanValue_03;
            newClone.NumberValue_03 = NumberValue_03;
        }
        
        public object CloneObject()
        {
            Articy.Eai.Features.dialogueFeature clone = new Articy.Eai.Features.dialogueFeature();
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
            if ((aProperty == "MediumTextValue_02"))
            {
                MediumTextValue_02 = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "MediumTextValue_03"))
            {
                MediumTextValue_03 = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "MediumTextValue_04"))
            {
                MediumTextValue_04 = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "MediumTextValue_05"))
            {
                MediumTextValue_05 = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "NumberValue"))
            {
                NumberValue = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "BooleanValue"))
            {
                BooleanValue = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "NumberValue_02"))
            {
                NumberValue_02 = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "MediumTextValue"))
            {
                MediumTextValue = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "MediumTextValue_06"))
            {
                MediumTextValue_06 = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "BooleanValue_02"))
            {
                BooleanValue_02 = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "BooleanValue_03"))
            {
                BooleanValue_03 = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "NumberValue_03"))
            {
                NumberValue_03 = System.Convert.ToSingle(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "MediumTextValue_02"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue_02);
            }
            if ((aProperty == "MediumTextValue_03"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue_03);
            }
            if ((aProperty == "MediumTextValue_04"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue_04);
            }
            if ((aProperty == "MediumTextValue_05"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue_05);
            }
            if ((aProperty == "NumberValue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(NumberValue);
            }
            if ((aProperty == "BooleanValue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(BooleanValue);
            }
            if ((aProperty == "NumberValue_02"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(NumberValue_02);
            }
            if ((aProperty == "MediumTextValue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue);
            }
            if ((aProperty == "MediumTextValue_06"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(MediumTextValue_06);
            }
            if ((aProperty == "BooleanValue_02"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(BooleanValue_02);
            }
            if ((aProperty == "BooleanValue_03"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(BooleanValue_03);
            }
            if ((aProperty == "NumberValue_03"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(NumberValue_03);
            }
            return null;
        }
        #endregion
    }
}
