using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace FinalYearProject
{
    public class PopulatePositionLists
    {
        static int index = 0;
        public static BindingList<string>[] Positions = new BindingList<string>[11];

        public static void PopulateStriker(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || Int32.Parse(dr[192].ToString()) == 6 ||Int32.Parse(dr[192].ToString()) == 10
              || Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 15 || Int32.Parse(dr[192].ToString()) == 16)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 5 || Int32.Parse(dr[192].ToString()) == 7
                || Int32.Parse(dr[192].ToString()) == 8
                || Int32.Parse(dr[192].ToString()) == 11)
            {
                if (Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 13 || Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 9
                || Int32.Parse(dr[192].ToString()) == 14 || Int32.Parse(dr[192].ToString()) == 17 || Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 9 || Int32.Parse(dr[192].ToString()) == 11
                    || Int32.Parse(dr[192].ToString()) == 10)
                {
                    PopulatePosition(dr, Position);
                }

            }
        }
        public static void PopulateCenterBacks(DataRow dr, BindingList<string> Position)
        {
            if ((Int32.Parse(dr[192].ToString()) >= 2 && Int32.Parse(dr[192].ToString()) <= 9) || Int32.Parse(dr[192].ToString()) == 15) //formation
            {
                if (Int32.Parse(dr[193].ToString()) == 5 || Int32.Parse(dr[193].ToString()) == 6)
                {
                    PopulatePosition(dr, Position);
                }

            }

            if ((Int32.Parse(dr[192].ToString()) >= 10 && Int32.Parse(dr[192].ToString()) <= 13)
                || Int32.Parse(dr[192].ToString()) >= 16 && Int32.Parse(dr[192].ToString()) <= 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 5 || Int32.Parse(dr[193].ToString()) == 6 || Int32.Parse(dr[193].ToString()) == 4)
                {
                    PopulatePosition(dr, Position);
                }
            }

            if (Int32.Parse(dr[192].ToString()) == 14)
            {
                if (Int32.Parse(dr[193].ToString()) == 5 || Int32.Parse(dr[193].ToString()) == 6 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePosition(dr, Position);
                }
            }
        }
        public static void PopulatePosition(DataRow TeamData, BindingList<string> Position)
        {
            if (TeamData[3].ToString() != "")
                index = Position.IndexOf(TeamData[3].ToString() + ' ' + TeamData[2].ToString());
            else
                index = Position.IndexOf(TeamData[2].ToString());

            if (index >= 0)
            {
            }
            else
            {
                if (TeamData[3].ToString() != "")
                    Position.Add(TeamData[3].ToString() + ' ' + TeamData[2].ToString());
                else
                    Position.Add(TeamData[2].ToString());
                index = Position.IndexOf(TeamData[2].ToString());
            }

        }
        public static void PopulateCenterMidfielders(DataRow dr, BindingList<string> PositionNumber)
        {
            if (Int32.Parse(dr[192].ToString()) == 4)
            {
                if (Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) >= 2 && Int32.Parse(dr[192].ToString()) <= 4)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 5 || Int32.Parse(dr[192].ToString()) == 7 || Int32.Parse(dr[192].ToString()) == 6)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 8)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if ( Int32.Parse(dr[192].ToString()) == 9)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 11
                    || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 10 || Int32.Parse(dr[192].ToString()) == 12
                 || Int32.Parse(dr[192].ToString()) == 16)
            {
                if (Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 11)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 13)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 17)
            {
                if (Int32.Parse(dr[193].ToString()) == 9 || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 9 || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 14)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 10
                    || Int32.Parse(dr[193].ToString()) == 2 || Int32.Parse(dr[193].ToString()) == 3)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
        }
        public static void RightBack(DataRow dr, BindingList<string> Position)
        {
            if ((Int32.Parse(dr[192].ToString()) >= 2 && Int32.Parse(dr[192].ToString()) <= 11) || Int32.Parse(dr[192].ToString()) == 15) //formation
            {
                //Right Back
                if (Int32.Parse(dr[193].ToString()) == 2)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }
        public static void PopulateAttackingMidfielder(DataRow dr, BindingList<string> PositionNumber)
        {
            if (Int32.Parse(dr[192].ToString()) == 3)
            {
                if (Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 6 || Int32.Parse(dr[192].ToString()) == 14
                || Int32.Parse(dr[192].ToString()) == 16)
            {
                if (Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 8)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 9)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 12)
            {
                if (Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }
            }
            if (Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 17)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, PositionNumber);
                }

            }
        }
        public static void PopulateWingBack(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 14 || Int32.Parse(dr[192].ToString()) == 9 || Int32.Parse(dr[192].ToString()) == 10 || Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 13 || Int32.Parse(dr[192].ToString()) == 16 || Int32.Parse(dr[192].ToString()) == 17
                || Int32.Parse(dr[192].ToString()) == 18 || Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 2)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if ( Int32.Parse(dr[192].ToString()) == 11 || Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || (Int32.Parse(dr[192].ToString()) >= 5 && Int32.Parse(dr[192].ToString()) <=8 )) //formation
            {
                if (Int32.Parse(dr[193].ToString()) == 2 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 4)
            {
                if (Int32.Parse(dr[193].ToString()) == 2 || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

        }
        public static void PopulateLeftBack(DataRow dr, BindingList<string> Position)
        {
            if ((Int32.Parse(dr[192].ToString()) >= 2 && Int32.Parse(dr[192].ToString()) <= 11) || Int32.Parse(dr[192].ToString()) == 15) //formation
            {
                if (Int32.Parse(dr[193].ToString()) == 3)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }
        public static void PopulateAttMidfieldLeftRight(DataRow dr, BindingList<String> Position)
        {
            if ((Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || Int32.Parse(dr[192].ToString()) == 5
                || Int32.Parse(dr[192].ToString()) == 6 || Int32.Parse(dr[192].ToString()) == 8))
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 9)
            {
                if (Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if ((Int32.Parse(dr[192].ToString()) == 7))
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 10 || Int32.Parse(dr[192].ToString()) == 12)
            {
                if (Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if ((Int32.Parse(dr[192].ToString()) == 11))
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 13)
            {
                if (Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 14)
            {
                if (Int32.Parse(dr[193].ToString()) == 2 || Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 3)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }
            }
        }
        public static void PopulateLeftWingBack(DataRow dr, BindingList<string> Position)
        {
            if ((Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 14 || Int32.Parse(dr[192].ToString()) == 13 || Int32.Parse(dr[192].ToString()) == 16 || Int32.Parse(dr[192].ToString()) == 17
                || Int32.Parse(dr[192].ToString()) == 18 || Int32.Parse(dr[192].ToString()) == 15))
            {
                if (Int32.Parse(dr[193].ToString()) == 3)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if ((Int32.Parse(dr[192].ToString()) >= 2 && Int32.Parse(dr[192].ToString()) <= 8) || Int32.Parse(dr[192].ToString()) == 11) //formation
            {
                if (Int32.Parse(dr[193].ToString()) == 3 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }
        public static void PopulateRightMidfielder(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || Int32.Parse(dr[192].ToString()) == 5
                || Int32.Parse(dr[192].ToString()) == 6 || Int32.Parse(dr[192].ToString()) == 7 || Int32.Parse(dr[192].ToString()) == 11)
            {
                if (Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 13)
            {
                if (Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }
            }
            if (Int32.Parse(dr[192].ToString()) == 8)
            {
                if (Int32.Parse(dr[193].ToString()) == 2 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }
            }
            if (Int32.Parse(dr[192].ToString()) == 9||Int32.Parse(dr[192].ToString()) == 10 || Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 13
               || Int32.Parse(dr[192].ToString()) == 14 || Int32.Parse(dr[192].ToString()) == 15 || Int32.Parse(dr[192].ToString()) == 16 || Int32.Parse(dr[192].ToString()) == 17 || Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 2)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }
        public static void PopulateRightFrontThree(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || Int32.Parse(dr[192].ToString()) == 10
                || Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 16)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 3)
            {
                if (Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 9 || Int32.Parse(dr[192].ToString()) == 17
                || Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 9 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 5 || Int32.Parse(dr[192].ToString()) == 6)
            {
                if (Int32.Parse(dr[193].ToString()) == 10 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 7 || Int32.Parse(dr[192].ToString()) == 11)
            {
                if (Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 8)
            {
                if (Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 10
                    || Int32.Parse(dr[193].ToString()) == 11 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }


            if (Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 10
                    || Int32.Parse(dr[193].ToString()) == 11 || Int32.Parse(dr[193].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 13 || Int32.Parse(dr[192].ToString()) == 14)
            {
                if (Int32.Parse(dr[192].ToString()) == 11
                    || Int32.Parse(dr[192].ToString()) == 10
                    || Int32.Parse(dr[192].ToString()) == 9)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }

        public static void PopulateLeftMidfielder(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 3 || Int32.Parse(dr[192].ToString()) == 5
                || Int32.Parse(dr[192].ToString()) == 6 || Int32.Parse(dr[192].ToString()) == 7 || Int32.Parse(dr[192].ToString()) == 11
                || Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 8 || Int32.Parse(dr[192].ToString()) == 13)
            {
                if (Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 8||Int32.Parse(dr[192].ToString()) == 9||Int32.Parse(dr[192].ToString()) == 12 || Int32.Parse(dr[192].ToString()) == 13
            || Int32.Parse(dr[192].ToString()) == 16 || Int32.Parse(dr[192].ToString()) == 17 || Int32.Parse(dr[192].ToString()) == 18 || Int32.Parse(dr[192].ToString()) == 10
                || Int32.Parse(dr[192].ToString()) == 14 || Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 3)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }

        public static void PopulateDefensiveMidfielder(DataRow dr, BindingList<string> Position)
        {
            if (Int32.Parse(dr[192].ToString()) == 3)
            {
                if (Int32.Parse(dr[193].ToString()) == 4)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 2 || Int32.Parse(dr[192].ToString()) == 6 || Int32.Parse(dr[192].ToString()) == 8)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
            if (Int32.Parse(dr[192].ToString()) == 4 || Int32.Parse(dr[192].ToString()) == 9 || Int32.Parse(dr[192].ToString()) == 14)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 5 || Int32.Parse(dr[192].ToString()) == 7)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 10 || Int32.Parse(dr[192].ToString()) == 12
                 || Int32.Parse(dr[192].ToString()) == 16)
            {
                if (Int32.Parse(dr[193].ToString()) == 8
                    || Int32.Parse(dr[193].ToString()) == 7 || Int32.Parse(dr[193].ToString()) == 11)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 11)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 10)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 13 || Int32.Parse(dr[192].ToString()) == 17 || Int32.Parse(dr[192].ToString()) == 18)
            {
                if (Int32.Parse(dr[193].ToString()) == 8 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }

            if (Int32.Parse(dr[192].ToString()) == 15)
            {
                if (Int32.Parse(dr[193].ToString()) == 4 || Int32.Parse(dr[193].ToString()) == 7)
                {
                    PopulatePositionLists.PopulatePosition(dr, Position);
                }

            }
        }

        public static void PopulatePosition2(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 2://4-3-3 done
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 6://4-2-3-1
                case 7://4-3-2-1
                case 8://5-3-2
                case 9://5-4-1
                case 13://4-2-2-2
                    PopulatePositionLists.RightBack(dr, PopulatePositionLists.Positions[1]);
                    break;

                case 10://3-5-2
                case 11://3-4-3
                case 14://3-5-1-1
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateWingBack(dr, PopulatePositionLists.Positions[1]);
                    break;
                case 12://3-1-3-1-2
                    PopulatePositionLists.PopulateAttMidfieldLeftRight(dr, PopulatePositionLists.Positions[1]);

                    break;
            }
        }

        public static void PopulatePosition3(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 2://4-3-3 done
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 6://4-2-3-1
                case 7://4-3-2-1
                case 8://5-3-2
                case 9://5-4-1
                case 13://4-2-2-2
                    PopulatePositionLists.PopulateLeftBack(dr, PopulatePositionLists.Positions[2]);
                    break;

                case 10://3-5-2
                case 11://3-4-3
                case 14://3-5-1-1
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateLeftWingBack(dr, PopulatePositionLists.Positions[2]);
                    break;
                case 12://3-1-3-1-2
                    PopulatePositionLists.PopulateAttMidfieldLeftRight(dr, PopulatePositionLists.Positions[2]);
                    break;

            }
        }

        public static void PopulatePosition4(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 2://4-3-3 done
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 7://4-3-2-1
                    PopulatePositionLists.PopulateCenterMidfielders(dr, PopulatePositionLists.Positions[3]);
                    break;
                case 1://4-1-2-1-2
                case 5://4-1-4-1
                case 12://3-1-3-1-2
                case 6://4-2-3-1
                case 13://4-2-2-2
                    PopulatePositionLists.PopulateDefensiveMidfielder(dr, PopulatePositionLists.Positions[3]);
                    break;
                case 8://5-3-2
                case 9://5-4-1
                case 10://3-5-2
                case 11://3-4-3
                case 14://3-5-1-1
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateCenterBacks(dr, PopulatePositionLists.Positions[3]);
                    break;
            }
        }
        public static void PopulatePosition5And6(DataRow dr)
        {
            PopulatePositionLists.PopulateCenterBacks(dr, PopulatePositionLists.Positions[4]);
            PopulatePositionLists.PopulateCenterBacks(dr, Positions[5]);
        }

        public static void PopulatePosition7(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 9://5-4-1
                    PopulatePositionLists.PopulateRightMidfielder(dr, Positions[6]);
                    break;

                case 2://4-3-3 done
                case 8://5-3-2
                case 10://3-5-2
                case 11://3-4-3
                case 14://3-5-1-1
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateCenterMidfielders(dr, Positions[6]);
                    break;

                case 6://4-2-3-1
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[6]);
                    break;

                case 7://4-3-2-1
                    PopulatePositionLists.PopulateCenterMidfielders(dr, Positions[6]);
                    break;
                case 13://4-2-2-2
                    PopulatePositionLists.PopulateDefensiveMidfielder(dr, Positions[6]);
                    break;
                case 12://3-1-3-1-2
                    PopulatePositionLists.PopulateCenterBacks(dr, Positions[6]);
                    break;
            }
        }

        public static void PopulatePosition8(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 2://4-3-3 done
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 7://4-3-2-1
                case 8://5-3-2
                case 9://5-4-1
                case 14://3-5-1-1
                case 15://3-4-2-1
                case 16://3-4-1-2
                case 10://3-5-2
                case 11://3-4-3
                case 12://3-1-3-1-2
                    PopulatePositionLists.PopulateCenterMidfielders(dr, Positions[7]);
                    break;

                case 1://4-1-2-1-2
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[7]);
                    break;

                case 6://4-2-3-1
                    PopulatePositionLists.PopulateDefensiveMidfielder(dr, Positions[7]);
                    break;

                case 13://4-2-2-2
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[7]);
                    break;
            }
        }

        public static void PopulatePosition9(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 2://4-3-3 done
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 6://4-2-3-1
                case 7://4-3-2-1
                case 8://5-3-2
                case 9://5-4-1
                case 13://4-2-2-2
                case 12://3-1-3-1-2
                case 14://3-5-1-1
                case 10://3-5-2
                case 11://3-4-3
                    PopulatePositionLists.PopulateStriker(dr, Positions[8]);
                    break;
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[8]);
                    break;
            }
        }

        public static void PopulatePosition10(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 8://5-3-2
                case 10://3-5-2
                case 13://4-2-2-2
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateStriker(dr, Positions[9]);
                    break;
                case 2://4-3-3 done
                    PopulatePositionLists.PopulateRightMidfielder(dr, Positions[9]);
                    break;

                case 3://4-5-1 done
                case 5://4-1-4-1
                case 9://5-4-1
                    PopulatePositionLists.PopulateCenterMidfielders(dr, Positions[9]);
                    break;
                case 4://4-4-1-1
                case 12://3-1-3-1-2
                case 14://3-5-1-1
                case 6://4-2-3-1
                case 7://4-3-2-1
                case 15://3-4-2-1
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[9]);
                    break;

                case 11://3-4-3
                    PopulatePositionLists.PopulateRightFrontThree(dr, Positions[9]);
                    break;
            }
        }

        public static void PopulatePosition11(DataRow dr)
        {
            switch (Form1.getListBoxSelectedItem())
            {
                case 0://4-4-2
                case 1://4-1-2-1-2
                case 3://4-5-1 done
                case 4://4-4-1-1
                case 5://4-1-4-1
                case 9://5-4-1
                case 2://4-3-3 done

                    PopulatePositionLists.PopulateLeftMidfielder(dr, Positions[10]);
                    break;
                case 8://5-3-2
                case 14://3-5-1-1
                case 10://3-5-2
                    PopulatePositionLists.PopulateCenterMidfielders(dr, Positions[10]);
                    break;

                case 11://3-4-3
                    PopulatePositionLists.PopulateRightFrontThree(dr, Positions[10]);
                    break;

                case 12: //3-1-3-1-2
                case 15://3-4-2-1
                case 16://3-4-1-2
                    PopulatePositionLists.PopulateStriker(dr, Positions[10]);
                    break;

                case 6://4-2-3-1
                case 7://4-3-2-1
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[10]);

                    break;
                case 13://4-2-2-2
                    PopulatePositionLists.PopulateAttackingMidfielder(dr, Positions[10]);
                    break;
            }
        }
    }




}
