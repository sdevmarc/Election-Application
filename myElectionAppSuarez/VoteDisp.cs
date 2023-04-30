using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myElectionAppSuarez
{   
    class VoteDisp
    {
        private int Teresita;
        private int Gemalyn;

        private int Anton;
        private int Rodrigo;

        private int Ronald;
        private int Lenie;

        private int Francis;
        private int Joel;

        private int Trisha;
        private int Flordeliza;

        private int Vhon;
        private int Herald;

        private int Gerald;
        private int Alpha;

        private int Jacob;
        private int Beauty;

        
        public int getCount(int a)
        {
            if(a == 1)
            {
                return Teresita;
            }
            else if(a == 2)
            {
                return Gemalyn;
            }
            else if (a == 3)
            {
                return Anton;
            }
            else if (a == 4)
            {
                return Rodrigo;
            }
            else if (a == 5)
            {
                return Ronald;
            }
            else if (a == 6)
            {
                return Lenie;
            }
            else if (a == 7)
            {
                return Francis;
            }
            else if (a == 8)
            {
                return Joel;
            }
            else if (a == 9)
            {
                return Trisha;
            }
            else if (a == 10)
            {
                return Flordeliza;
            }
            else if (a == 11)
            {
                return Vhon;
            }
            else if (a == 12)
            {
                return Herald;
            }
            else if (a == 13)
            {
                return Gerald;
            }
            else if (a == 14)
            {
                return Alpha;
            }
            else if (a == 15)
            {
                return Jacob;
            }
            else if (a == 16)
            {
                return Beauty;
            }
            return a;
        }

        public void makeVote(int a)
        {
            if (a == 1)
            {
                Teresita = getCount(1) + 1;
            }
            else if (a == 2)
            {
                Gemalyn = getCount(2) + 1;
            }
            else if (a == 3)
            {
                Anton = getCount(3) + 1;
            }
            else if (a == 4)
            {
                Rodrigo = getCount(4) + 1;
            }
            else if (a == 5)
            {
                Ronald = getCount(5) + 1;
            }
            else if (a == 6)
            {
                Lenie = getCount(6) + 1;
            }
            else if (a == 7)
            {
                Francis = getCount(7) + 1;
            }
            else if (a == 8)
            {
                Joel = getCount(8) + 1;
            }
            else if (a == 9)
            {
                Trisha = getCount(9) + 1;
            }
            else if (a == 10)
            {
                Flordeliza = getCount(10) + 1;
            }
            else if (a == 11)
            {
                Vhon = getCount(11) + 1;
            }
            else if (a == 12)
            {
                Herald = getCount(12) + 1;
            }
            else if (a == 13)
            {
                Gerald = getCount(13) + 1;
            }
            else if (a == 14)
            {
                Alpha = getCount(14) + 1;
            }
            else if (a == 15)
            {
                Jacob = getCount(15) + 1;
            }
            else if (a == 16)
            {
                Beauty = getCount(16) + 1;
            }
        }


    }
}
