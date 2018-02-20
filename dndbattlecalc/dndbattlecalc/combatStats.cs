namespace dndbattlecalc
{
    public class combatStats
    {
        public int hp;
        public int ac;
        public int ab;
        public int die;
        public int dam;
        public int bonus;
        public combatStats(int hpin, int acin, int abin, int diein, int damin, int bonusin)
        {
            hp = hpin;
            ac = acin;
            ab = abin;
            die = diein;
            dam = damin;
            bonus = bonusin;
        }
    }
}