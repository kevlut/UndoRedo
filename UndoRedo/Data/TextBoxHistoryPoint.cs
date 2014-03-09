﻿namespace UndoRedo.Data
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;

    public class TextBoxHistoryPoint
    {
        public TextBoxHistoryPoint(TextBoxBase sender, UndoAction action)
        {
            Sender = sender;
            Action = action;
            Timestamp = DateTime.UtcNow;
        }
        public DateTime Timestamp { get; private set; }
        public TextBoxBase Sender { get; private set; }
        public UndoAction Action { get; private set; }

        public void Undo()
        {
            if (Action != UndoAction.Undo)
                Sender.Undo();
            else if (Action != UndoAction.Redo)
                Sender.Redo();
            Sender.Focus();
        }
    }
}
