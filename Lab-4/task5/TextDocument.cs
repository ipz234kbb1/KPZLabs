using System;

namespace Task5
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }

        public void Restore(TextDocumentMemento memento)
        {
            Content = memento.Content;
        }
    }
} 