using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winggit.Entities;
using static System.IO.Path;

namespace Winggit.Controls
{
    class FileIO
    {
        public FileIO()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = @"Text Files|*.txt",
                Title = @"Please Select Your Sightings File"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream sightingsStream = File.OpenRead(ofd.FileName);
            processFile(sightingsStream);
        }

        private void processFile(FileStream fileStream)
        {
        }
    }
}
