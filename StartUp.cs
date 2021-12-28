using System;
using System.Windows.Forms;

namespace MapResizer
{
    public partial class MapResizer : Form
    {
        public MapResizer()
        {
            InitializeComponent();
        }

        private void MapResizeFunction(OpenFileDialog mapfile)
        {
            try
            {
                WorldSerialization worldSerialization = new WorldSerialization();
                worldSerialization.Load(mapfile.FileName);
                uint Size = worldSerialization.world.size;
                worldSerialization.world.size = uint.Parse(newsize.Text);
                worldSerialization.Save(mapfile.FileName.Replace(".map", ".mod.map"));
                MessageBox.Show("Map resized from " + Size.ToString() + " To " + newsize.Text + Environment.NewLine + "Saved as " + mapfile.SafeFileName.Replace(".map", ".mod.map"),"Saved");
                return;
            }
            catch
            {
                MessageBox.Show("Make sure your running this from the managed folder since it requires rust files.");
            }

        }

        private void convertbttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMapFile = new OpenFileDialog
            {
                Title = "Select Map File To Resize",
                DefaultExt = "map",
                Filter = "map files (*.map)|*.map",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openMapFile.ShowDialog() == DialogResult.OK)
            {
                MapResizeFunction(openMapFile);
            }
        }
    }
}
