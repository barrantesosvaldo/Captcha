using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Proyecto_III.Model
{
    public class StorageCharacter
    {
        private Bitmap characterBitmap;
        private string characterString;

        public StorageCharacter(Bitmap bitmap, string character)
        {
            characterBitmap = bitmap;
            characterString = character;
        }

        public Bitmap getBitmap()
        {
            return characterBitmap;
        }

        public string getCharacterString()
        {
            return characterString;
        }
    }
}
