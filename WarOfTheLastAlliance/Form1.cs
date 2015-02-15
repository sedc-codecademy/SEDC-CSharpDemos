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
        //private Maia Gandalf;
        //private Maia Sauron;

        public Form1()
        {
            InitializeComponent();
            creatures = new List<Creature>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Gandalf = new Maia {Energy = 50, Mana = 1000};
            //Sauron = new Maia {Energy = 70, Mana = 2000};

            for (int i = 0; i < 30; i++)
            {
                btnMakeCreature_Click(null, null);
            }
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
            
            //var index = r.Next(creatures.Count);
            //var kutraDusha = creatures[index];

            //Sauron.Attack(kutraDusha);
            //lbStatus.Items.Add(string.Format("Sauron attacked {0}", kutraDusha));
            //Gandalf.Attack(kutraDusha);
            //lbStatus.Items.Add(string.Format("Gandalf attacked {0}", kutraDusha));

            var index = r.Next(creatures.Count);
            var attacker = creatures[index];
            
            if (attacker is IWeaponWeilder)
            {
                index = r.Next(creatures.Count);
                var victim = creatures[index];

                var realAttacker = (IWeaponWeilder)attacker;
                realAttacker.Attack(victim);
                lbStatus.Items.Add(string.Format("{0} attacked {1}", attacker, victim));
                UpdateDisplay();
            }
            else
            {
                lbStatus.Items.Add(string.Format("{0} froze in fear and cannot attack", attacker));
            }
        }

    }
}
