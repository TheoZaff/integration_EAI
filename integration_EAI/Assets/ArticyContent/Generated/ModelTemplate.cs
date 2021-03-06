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
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.Eai.Features;

namespace Articy.Eai
{
    
    
    public class ModelTemplate : Dialogue, IDialogue, IPropertyProvider, IObjectWithFeaturedialogue
    {
        
        [SerializeField()]
        private ArticyValueModelTemplateTemplate mTemplate = new ArticyValueModelTemplateTemplate();
        
        private static Articy.Eai.Templates.ModelTemplateTemplateConstraint mConstraints = new Articy.Eai.Templates.ModelTemplateTemplateConstraint();
        
        public Articy.Eai.Templates.ModelTemplateTemplate Template
        {
            get
            {
                return mTemplate.GetValue();
            }
            set
            {
                mTemplate.SetValue(value);
            }
        }
        
        public static Articy.Eai.Templates.ModelTemplateTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public dialogueFeature GetFeaturedialogue()
        {
            return Template.dialogue;
        }
        
        protected override void CloneProperties(object aClone)
        {
            ModelTemplate newClone = ((ModelTemplate)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.Eai.Templates.ModelTemplateTemplate)(Template.CloneObject()));
            }
            base.CloneProperties(newClone);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if (aProperty.Contains("."))
            {
                Template.setProp(aProperty, aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if (aProperty.Contains("."))
            {
                return Template.getProp(aProperty);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
