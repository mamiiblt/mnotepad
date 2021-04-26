using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mNotepad_GitHub.mainEvents
{
    public class operationEdit
    {
        private undoRedo data;

        public operationEdit()
        {
            data = new undoRedo();
        }

        public bool TxtAreaTextChangeRequired { get; set; } = true;

        public string DateTime_Now()
        {
            return DateTime.Now.ToString();
        }

        public string UndoClicked()
        {
            TxtAreaTextChangeRequired = false;
            return data.Undo();
        }
        public string RedoClicked()
        {
            TxtAreaTextChangeRequired = false;
            return data.Redo();
        }

        public void Add_UndoRedo(string item)
        {
            data.AddItem(item);
        }

        public bool CanUndo()
        {
            return data.CanUndo();
        }

        public bool CanRedo()
        {
            return data.CanRedo();
        }
            
    }
}
