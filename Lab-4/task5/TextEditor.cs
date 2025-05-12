using System;
using System.Collections.Generic;

namespace Task5
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<TextDocumentMemento> _history;

        public TextEditor()
        {
            _document = new TextDocument();
            _history = new Stack<TextDocumentMemento>();
        }

        public void Write(string text)
        {
            SaveState();
            _document.Content += text;
        }

        public void SaveState()
        {
            _history.Push(_document.CreateMemento());
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
        }

        public string GetContent()
        {
            return _document.Content;
        }
    }
} 