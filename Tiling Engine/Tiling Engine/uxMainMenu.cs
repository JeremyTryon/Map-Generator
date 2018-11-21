using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;  // Add this for serialization
using System.IO;    // Add this for serialization

namespace Tiling_Engine
{
    public partial class uxMainMenu : Form
    {
        private uxEditor editor;
        //private uxViewer viewer;
        private World _map;

        public uxMainMenu()
        {
            InitializeComponent();
            uxEditM.Enabled = false;
            uxViewM.Enabled = false;
        }

        private void uxNewM_Click(object sender, EventArgs e)
        {
            editor = new uxEditor();
            editor.MakeNew();
            this.Hide();
            editor.ShowDialog();
            _map = editor.ReturnMap();
            this.Show();
            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxLoadM_Click(object sender, EventArgs e)
        {
            LoadFile();

            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxEditM_Click(object sender, EventArgs e)
        {
            this.Hide();
            //editor.SetMap(_map);
            editor.ShowDialog();
            _map = editor.ReturnMap();
            this.Show();
        }

        private void uxViewM_Click(object sender, EventArgs e)
        {
            //viewer.SetMap(_map);
        }

        private void uxSandQ_Click(object sender, EventArgs e)
        {
            SaveFile();
            this.Close();
        }

        private void SaveFile()
        {
            string path;
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                bool append = false;

                using (Stream stream = File.Open(path, append ? FileMode.Append : FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, _map);
                }
            }
        }

        private void LoadFile()
        {
            editor = new uxEditor();
            string path;
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;

                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _map =  (World)binaryFormatter.Deserialize(stream);
                    editor.SetMap(_map);

                }
            }
        }
    }
}
