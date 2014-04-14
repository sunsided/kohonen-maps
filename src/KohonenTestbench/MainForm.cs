using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using widemeadows.ml.kohonen.model;

namespace KohonenTestbench
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// The elements
        /// </summary>
        private Elements _elements;

        public MainForm()
        {
            InitializeComponent();
            LoadImports();
            PresentLoadedImports();
        }
        
        /// <summary>
        /// Loads the imports.
        /// </summary>
        private void LoadImports()
        {
            var elements = new Elements();

            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(elements);

            _elements = elements;
        }

        /// <summary>
        /// Presents the loaded imports.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        private void PresentLoadedImports()
        {
            var elements = _elements;
            Trace.Assert(elements != null, "No elements loaded.");

            // disable to prevent user interaction
            toolStripElements.Enabled = false;

            // add random number generators
            {
                var elementsToList = elements.RandomNumberGenerators;
                var list = toolStripDropDownButtonRngs.DropDownItems;
                list.Clear();
                AddElementToToolStripItemCollection(elementsToList, list);
            }

            // add metrics
            {
                var elementsToList = elements.Metrics;
                var list = toolStripDropDownButtonMetrics.DropDownItems;
                list.Clear();
                AddElementToToolStripItemCollection(elementsToList, list);
            }

            // add radius functions
            {
                var elementsToList = elements.RadiusFunctions;
                var list = toolStripDropDownButtonRadius.DropDownItems;
                list.Clear();
                AddElementToToolStripItemCollection(elementsToList, list);
            }

            // add neighborhood functions
            {
                var elementsToList = elements.NeighborhoodFunctions;
                var list = toolStripDropDownButtonNeighborhood.DropDownItems;
                list.Clear();
                AddElementToToolStripItemCollection(elementsToList, list);
            }

            // add learning rate functions
            {
                var elementsToList = elements.LearningRateFunctions;
                var list = toolStripDropDownButtonLearningRate.DropDownItems;
                list.Clear();
                AddElementToToolStripItemCollection(elementsToList, list);
            }

            // enable to prevent user interaction
            toolStripElements.Enabled = true;
        }

        /// <summary>
        /// Adds the element to drop down button.
        /// </summary>
        /// <param name="elementsToList">The elements to list.</param>
        /// <param name="list">The list.</param>
        private static void AddElementToToolStripItemCollection<T>(IEnumerable<Lazy<T, IMetadata>> elementsToList, ToolStripItemCollection list)
        {
            foreach (var contract in elementsToList)
            {
                var name = contract.Metadata.Name;
                var version = contract.Metadata.Version;
                var id = contract.Metadata.Id;

                var item = list.Add(name);
                item.ToolTipText = String.Format("{0} {1}", name, version);
                item.Tag = id;

                // TODO: if there is more than one version, pick the latest
                // TODO: alternatively, if there is more than one version, create a sub menu
            }
        }
    }
}
