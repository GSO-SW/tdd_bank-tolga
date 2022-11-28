using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        static private int kontoNr;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
            kontoNr = 1 + kontoNr;
        }

        public void Einzahlen(int betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
