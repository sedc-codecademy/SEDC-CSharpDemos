using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using WotLAEntities;

namespace WarOfTheLastAlliance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            var elf = new Elf();

            var human = new Human();

            var orc = new Orc();

            var creature = CreatureFactory.MakeCreature();

            //creatures.Add(elf);
            //creatures.Add(human);
            //creatures.Add(orc);

            //creatures[0].Name = "MyElf";

            //MessageBox.Show(elf.Name);
        }

        private void btnMakeCreature_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature();
            lbCreatures.Items.Add(creature);
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Elf);
            lbCreatures.Items.Add(creature);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Human);
            lbCreatures.Items.Add(creature);
        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Orc);
            lbCreatures.Items.Add(creature);
        }
    }
}
