namespace Composite;
using System.Collections.Generic;
using System.Text;
public class LightElementNode : LightNode
    {
        private string _tagName;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<string> _cssClasses;
        private List<LightNode> _children;

        public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            _tagName = tagName;
            _isBlock = isBlock;
            _isSelfClosing = isSelfClosing;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
        }

        public string TagName
        {
            get { return _tagName; }
        }

        public bool IsBlock
        {
            get { return _isBlock; }
            set { _isBlock = value; }
        }

        public bool IsSelfClosing
        {
            get { return _isSelfClosing; }
            set { _isSelfClosing = value; }
        }

        public int ChildCount
        {
            get { return _children.Count; }
        }

        public void AddCssClass(string className)
        {
            if (!_cssClasses.Contains(className))
            {
                _cssClasses.Add(className);
            }
        }

        public void RemoveCssClass(string className)
        {
            _cssClasses.Remove(className);
        }

        public List<string> GetCssClasses()
        {
            return _cssClasses;
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
        }

        public string RenderInnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in _children)
            {
                sb.Append(child.RenderOuterHTML());
            }
            return sb.ToString();
        }

        public override string RenderOuterHTML()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("<");
            sb.Append(_tagName);
            
            if (_cssClasses.Count > 0)
            {
                sb.Append(" class=\"");
                sb.Append(string.Join(" ", _cssClasses));
                sb.Append("\"");
            }
            
            if (_isSelfClosing)
            {
                sb.Append(" />");
                return sb.ToString();
            }
            
            sb.Append(">");
            
            sb.Append(RenderInnerHTML());
            
            sb.Append("</");
            sb.Append(_tagName);
            sb.Append(">");
            
            return sb.ToString();
        }
    }