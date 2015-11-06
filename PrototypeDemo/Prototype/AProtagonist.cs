using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public abstract class AProtagonist
    {
        int m_health;
        int m_felony;
        double m_money;

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
       
        public int Felony
        {
            get { return m_felony; }
            set { m_felony = value; }
        }

        public double Money
        {
            get { return m_money; }
            set { m_money = value; }
        }

        public abstract AProtagonist Clone();
    }
}
