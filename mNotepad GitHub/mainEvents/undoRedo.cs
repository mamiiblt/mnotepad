using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mNotepad_GitHub.mainEvents
{
    public class undoRedo
    {
        private Stack<string> undoFS;
        private Stack<string> redoFS;
        public undoRedo()
        {
            undoFS = new Stack<string>();
            redoFS = new Stack<string>();
        }

        public void Clear()
        {
            undoFS.Clear();
            redoFS.Clear();
        }
        
        public void AddItem(string item)
        {
            undoFS.Push(item);
        }

        public string Undo()
        {
            string item = undoFS.Pop();
            redoFS.Push(item);
            return undoFS.First();
        }

        public string Redo()
        {
            if (redoFS.Count == 0)
                return undoFS.First();
            string item = redoFS.Pop();
            undoFS.Push(item);
            return undoFS.First();
        }

        public bool CanUndo()
        {
            return undoFS.Count > 1;
        }

        public bool CanRedo()
        {
            return redoFS.Count > 0;
        }

        public List<string> UndoItems()
        {
            return undoFS.ToList();
        }

        public List<string> RedoItems()
        {
            return redoFS.ToList();
        }
    }
}
