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
        private List<Creature> creatures;

        public Form1()
        {
            InitializeComponent();
            creatures = new List<Creature>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDisplay()
        {
            lbCreatures.Items.Clear();
            lbCreatures.Items.AddRange(creatures.ToArray());
        }

        private void btnMakeCreature_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature();
            creatures.Add(creature);
            UpdateDisplay();
        }


        private void btnElf_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Elf);
            creatures.Add(creature);
            UpdateDisplay();

        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Human);
            creatures.Add(creature);
            UpdateDisplay();
        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            var creature = CreatureFactory.MakeCreature(CreatureType.Orc);
            creatures.Add(creature);
            UpdateDisplay();
        }

        private void btnAttaaaaaaack_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var index = r.Next(creatures.Count);
            var attacker = creatures[index];
            index = r.Next(creatures.Count);
            var victim = creatures[index];

            attacker.Attack(victim);
            UpdateDisplay();
        }

    }
}
