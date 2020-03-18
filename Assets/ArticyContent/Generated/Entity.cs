//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Project_Of_Death
{
    
    
    public class Entity : ArticyObject, IEntity, IPropertyProvider, IObjectWithColor, IObjectWithDisplayName, IObjectWithLocalizableDisplayName, IObjectWithUnresolvedDisplayName, IObjectWithPreviewImage, IObjectWithText, IObjectWithLocalizableText, IObjectWithUnresolvedText, IObjectWithAttachments, IObjectWithExternalId, IObjectWithShortId, IObjectWithPosition, IObjectWithZIndex, IObjectWithSize
    {
        
        [SerializeField()]
        private ArticyValueArticyModelList mAttachments = new ArticyValueArticyModelList();
        
        [SerializeField()]
        private String mLocaKey_DisplayName;
        
        [SerializeField()]
        private String mOverwritten_DisplayName = "";
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private String mLocaKey_Text;
        
        [SerializeField()]
        private String mOverwritten_Text = "";
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Vector2 mPosition;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private PreviewImage mPreviewImage = new PreviewImage();
        
        [SerializeField()]
        private UInt32 mShortId;
        
        public List<ArticyObject> Attachments
        {
            get
            {
                return mAttachments.GetValue();
            }
            set
            {
                var oldValue = mAttachments;
                mAttachments.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Attachments", oldValue.GetValue(), mAttachments.GetValue());
            }
        }
        
        public String LocaKey_DisplayName
        {
            get
            {
                return mLocaKey_DisplayName;
            }
        }
        
        public String Unresolved_DisplayName
        {
            get
            {
                if ((mOverwritten_DisplayName != ""))
                {
                    return mOverwritten_DisplayName;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_DisplayName);
            }
        }
        
        public String DisplayName
        {
            get
            {
                if ((mOverwritten_DisplayName != ""))
                {
                    return Articy.Unity.ArticyTextExtension.Resolve(this, mOverwritten_DisplayName);
                }
                return Articy.Unity.ArticyTextExtension.Resolve(this, mLocaKey_DisplayName);
            }
            set
            {
                var oldValue = Unresolved_DisplayName;
                mOverwritten_DisplayName = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayName", oldValue, mOverwritten_DisplayName);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                var oldValue = mColor;
                mColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Color", oldValue, mColor);
            }
        }
        
        public String LocaKey_Text
        {
            get
            {
                return mLocaKey_Text;
            }
        }
        
        public String Unresolved_Text
        {
            get
            {
                if ((mOverwritten_Text != ""))
                {
                    return mOverwritten_Text;
                }
                return Articy.Unity.ArticyDatabase.Localization.Localize(mLocaKey_Text);
            }
        }
        
        public String Text
        {
            get
            {
                if ((mOverwritten_Text != ""))
                {
                    return Articy.Unity.ArticyTextExtension.Resolve(this, mOverwritten_Text);
                }
                return Articy.Unity.ArticyTextExtension.Resolve(this, mLocaKey_Text);
            }
            set
            {
                var oldValue = Unresolved_Text;
                mOverwritten_Text = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Text", oldValue, mOverwritten_Text);
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                var oldValue = mExternalId;
                mExternalId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ExternalId", oldValue, mExternalId);
            }
        }
        
        public Vector2 Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                var oldValue = mPosition;
                mPosition = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Position", oldValue, mPosition);
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                var oldValue = mZIndex;
                mZIndex = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ZIndex", oldValue, mZIndex);
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                var oldValue = mSize;
                mSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Size", oldValue, mSize);
            }
        }
        
        public PreviewImage PreviewImage
        {
            get
            {
                return mPreviewImage;
            }
            set
            {
                var oldValue = mPreviewImage;
                mPreviewImage = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "PreviewImage", oldValue, mPreviewImage);
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                var oldValue = mShortId;
                mShortId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShortId", oldValue, mShortId);
            }
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Entity newClone = ((Entity)(aClone));
            mAttachments.CustomClone(newClone.mAttachments);
            newClone.mLocaKey_DisplayName = mLocaKey_DisplayName;
            newClone.mOverwritten_DisplayName = mOverwritten_DisplayName;
            newClone.Color = Color;
            newClone.mLocaKey_Text = mLocaKey_Text;
            newClone.mOverwritten_Text = mOverwritten_Text;
            newClone.ExternalId = ExternalId;
            newClone.Position = Position;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.PreviewImage = PreviewImage;
            newClone.ShortId = ShortId;
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            if ((mOverwritten_DisplayName != ""))
            {
                return true;
            }
            if ((mOverwritten_Text != ""))
            {
                return true;
            }
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "Attachments"))
            {
                Attachments = ((List<ArticyObject>)(aValue));
                return;
            }
            if ((aProperty == "DisplayName"))
            {
                DisplayName = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Position"))
            {
                Position = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "PreviewImage"))
            {
                PreviewImage = ((PreviewImage)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Attachments"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Attachments);
            }
            if ((aProperty == "DisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayName);
            }
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "Position"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Position);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "PreviewImage"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(PreviewImage);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
