using Basy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class ParameterList : Form
    {
        private List<Parameter> _parameters = new List<Parameter>();

        public ParameterList(List<Parameter> parameters)
        {
            InitializeComponent();
            this._parameters = parameters;
        }

        private void ParameterList_Load(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            lbParameters.Items.Clear();

            foreach (Parameter param in _parameters)
            {
                lbParameters.Items.Add(param);
            }
        }
    }
}
