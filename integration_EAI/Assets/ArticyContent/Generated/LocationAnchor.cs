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

namespace Articy.Eai
{
    
    
    [Serializable()]
    public class LocationAnchor : IArticyBaseObject
    {
        
        [SerializeField()]
        private Single mAnchorPositionX;
        
        [SerializeField()]
        private Single mAnchorPositionY;
        
        [SerializeField()]
        private Color mAnchorColor;
        
        [SerializeField()]
        private LocationAnchorSize mAnchorSize = new LocationAnchorSize();
        
        public Single AnchorPositionX
        {
            get
            {
                return mAnchorPositionX;
            }
            set
            {
                mAnchorPositionX = value;
            }
        }
        
        public Single AnchorPositionY
        {
            get
            {
                return mAnchorPositionY;
            }
            set
            {
                mAnchorPositionY = value;
            }
        }
        
        public Color AnchorColor
        {
            get
            {
                return mAnchorColor;
            }
            set
            {
                mAnchorColor = value;
            }
        }
        
        public LocationAnchorSize AnchorSize
        {
            get
            {
                return mAnchorSize;
            }
            set
            {
                mAnchorSize = value;
            }
        }
        
        private void CloneProperties(object aClone)
        {
            LocationAnchor newClone = ((LocationAnchor)(aClone));
            newClone.AnchorPositionX = AnchorPositionX;
            newClone.AnchorPositionY = AnchorPositionY;
            newClone.AnchorColor = AnchorColor;
            newClone.AnchorSize = AnchorSize;
        }
        
        public object CloneObject()
        {
            LocationAnchor clone = new LocationAnchor();
            CloneProperties(clone);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
    }
}