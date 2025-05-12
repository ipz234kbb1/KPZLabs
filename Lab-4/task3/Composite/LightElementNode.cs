using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private string _displayType;
        private bool _isSelfClosing;
        private List<LightNode> _children;

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            _tagName = tagName;
            _displayType = displayType;
            _isSelfClosing = isSelfClosing;
            _children = new List<LightNode>();
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public new void TriggerEvent(string eventType)
        {
            base.TriggerEvent(eventType);
        }

        public override string OuterHTML
        {
            get
            {
                if (_isSelfClosing)
                {
                    return $"<{_tagName} style=\"display: {_displayType}\" />";
                }

                var childrenHtml = string.Join("", _children.Select(child => child.OuterHTML));
                return $"<{_tagName} style=\"display: {_displayType}\">{childrenHtml}</{_tagName}>";
            }
        }

        public void Click()
        {
            TriggerEvent("click");
        }

        public void MouseOver()
        {
            TriggerEvent("mouseover");
        }

        public void MouseOut()
        {
            TriggerEvent("mouseout");
        }
    }
}