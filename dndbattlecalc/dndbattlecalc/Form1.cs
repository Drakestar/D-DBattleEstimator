using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dndbattlecalc
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<combatStats> heroes = new List<combatStats>();
        List<combatStats> enemies = new List<combatStats>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void herohp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int diceRoll(int quantity, int size)
        {
            int sum = 0;
            while(quantity > 0)
            {
                sum += rnd.Next(1, size+1);
                quantity--;
            }
            return sum;
        }

        private void fightClick(object sender, EventArgs e)
        {
            int turnsinterior = 0, attackroll = 0, damageroll = 0, damagetotal = 0;
            if (!heroes.Any() || !enemies.Any()) return;
            while (true)
            {
                turnsinterior++;
                turns.Text = turnsinterior.ToString();
                foreach (combatStats x in heroes)
                {
                    // If an enemy is under 0 health remove it
                    if (enemies[0].hp <= 0) enemies.RemoveAt(0);
                    if (!enemies.Any()) return;
                    // Get attack roll
                    attackroll = diceRoll(1, 20) + x.ab;
                    // See if you hit enemy
                    if (attackroll >= enemies[0].ac)
                    {
                        // Roll for damage and deal it
                        damageroll = diceRoll(x.die, x.dam) + x.bonus;
                        enemies[0].hp -= damageroll;
                    }
                }
                foreach (combatStats x in enemies)
                {
                    if (heroes[0].hp <= 0) heroes.RemoveAt(0);
                    if (!heroes.Any()) return;
                    attackroll = diceRoll(1, 20) + x.ab;
                    if (attackroll >= heroes[0].ac)
                    {
                        damageroll = diceRoll(x.die, x.dam) + x.bonus;
                        enemies[0].hp -= damageroll;
                        damagetotal += damageroll;
                        damagedone.Text = damagetotal.ToString();
                    }
                }
            }
        }

        private void FightPrepClick(object sender, EventArgs e)
        {
            if (hero0.Checked) heroes.Add(new combatStats (Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));
            if (hero0.Checked) heroes.Add(new combatStats(Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));
            if (hero0.Checked) heroes.Add(new combatStats(Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));
            if (hero0.Checked) heroes.Add(new combatStats(Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));
            if (hero0.Checked) heroes.Add(new combatStats(Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));
            if (hero0.Checked) heroes.Add(new combatStats(Convert.ToInt32(herohp0.Text), Convert.ToInt32(heroAC0.Text), Convert.ToInt32(heroAB0.Text), Convert.ToInt32(herodie0.Text), Convert.ToInt32(heroDam0.Text), Convert.ToInt32(heroBonus0.Text)));

            if (enemy0.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP0.Text), Convert.ToInt32(enemyAC0.Text), Convert.ToInt32(enemyAB0.Text), Convert.ToInt32(enemydie0.Text), Convert.ToInt32(enemyDam0.Text), Convert.ToInt32(enemyBonus0.Text)));
            if (enemy1.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP1.Text), Convert.ToInt32(enemyAC1.Text), Convert.ToInt32(enemyAB1.Text), Convert.ToInt32(enemydie1.Text), Convert.ToInt32(enemyDam1.Text), Convert.ToInt32(enemyBonus1.Text)));
            if (enemy2.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP2.Text), Convert.ToInt32(enemyAC2.Text), Convert.ToInt32(enemyAB2.Text), Convert.ToInt32(enemydie2.Text), Convert.ToInt32(enemyDam2.Text), Convert.ToInt32(enemyBonus2.Text)));
            if (enemy3.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP3.Text), Convert.ToInt32(enemyAC3.Text), Convert.ToInt32(enemyAB3.Text), Convert.ToInt32(enemydie3.Text), Convert.ToInt32(enemyDam3.Text), Convert.ToInt32(enemyBonus3.Text)));
            if (enemy4.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP4.Text), Convert.ToInt32(enemyAC4.Text), Convert.ToInt32(enemyAB4.Text), Convert.ToInt32(enemydie4.Text), Convert.ToInt32(enemyDam4.Text), Convert.ToInt32(enemyBonus4.Text)));
            if (enemy5.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP5.Text), Convert.ToInt32(enemyAC5.Text), Convert.ToInt32(enemyAB5.Text), Convert.ToInt32(enemydie5.Text), Convert.ToInt32(enemyDam5.Text), Convert.ToInt32(enemyBonus5.Text)));
            if (enemy6.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP6.Text), Convert.ToInt32(enemyAC6.Text), Convert.ToInt32(enemyAB6.Text), Convert.ToInt32(enemydie6.Text), Convert.ToInt32(enemyDam6.Text), Convert.ToInt32(enemyBonus6.Text)));
            if (enemy7.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP7.Text), Convert.ToInt32(enemyAC7.Text), Convert.ToInt32(enemyAB7.Text), Convert.ToInt32(enemydie7.Text), Convert.ToInt32(enemyDam7.Text), Convert.ToInt32(enemyBonus7.Text)));
            if (enemy8.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP8.Text), Convert.ToInt32(enemyAC8.Text), Convert.ToInt32(enemyAB8.Text), Convert.ToInt32(enemydie8.Text), Convert.ToInt32(enemyDam8.Text), Convert.ToInt32(enemyBonus8.Text)));
            if (enemy9.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP9.Text), Convert.ToInt32(enemyAC9.Text), Convert.ToInt32(enemyAB9.Text), Convert.ToInt32(enemydie9.Text), Convert.ToInt32(enemyDam9.Text), Convert.ToInt32(enemyBonus9.Text)));
            if (enemy10.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP10.Text), Convert.ToInt32(enemyAC10.Text), Convert.ToInt32(enemyAB10.Text), Convert.ToInt32(enemydie10.Text), Convert.ToInt32(enemyDam10.Text), Convert.ToInt32(enemyBonus10.Text)));
            if (enemy11.Checked) enemies.Add(new combatStats(Convert.ToInt32(enemyHP11.Text), Convert.ToInt32(enemyAC11.Text), Convert.ToInt32(enemyAB11.Text), Convert.ToInt32(enemydie11.Text), Convert.ToInt32(enemyDam11.Text), Convert.ToInt32(enemyBonus11.Text)));

        }
    }
}
