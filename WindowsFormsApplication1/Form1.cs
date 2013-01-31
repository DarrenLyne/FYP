using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalYearProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <  PopulatePositionLists.Positions.Length; i++)
            {
                 PopulatePositionLists.Positions[i] = new BindingList<string>();
            }
            for (int i = 1; i < OpenExcelFile.dt.Rows.Count; i++)
            {
                PopulatePositionLists.PopulatePosition2(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition3(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition4(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition5And6(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition7(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition8(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition9(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition10(OpenExcelFile.dt.Rows[i]);
                PopulatePositionLists.PopulatePosition11(OpenExcelFile.dt.Rows[i]);
            }
            this.GoalKeeper.DataSource = PopulatePositionLists.Positions[0];
            this.comboBox2.DataSource = PopulatePositionLists.Positions[1];
            this.comboBox12.DataSource = PopulatePositionLists.Positions[2];
            this.comboBox6.DataSource = PopulatePositionLists.Positions[3];
            this.comboBox3.DataSource = PopulatePositionLists.Positions[4];
            this.comboBox4.DataSource = PopulatePositionLists.Positions[5];
            this.comboBox5.DataSource = PopulatePositionLists.Positions[6];
            this.comboBox7.DataSource = PopulatePositionLists.Positions[7];
            this.comboBox11.DataSource = PopulatePositionLists.Positions[8];
            this.comboBox9.DataSource = PopulatePositionLists.Positions[9];
            this.comboBox8.DataSource = PopulatePositionLists.Positions[10];

            switch (listBox1.SelectedIndex)
            {
                case 0://4-4-2
                    SetBackFour();
                    SetPosition7(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition4(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition8(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition11(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition9(new Point(351, 311), new Point(355, 336), new Point(367, 352));
                    SetPosition10(new Point(206, 311), new Point(210, 336), new Point(228, 352));
                    break;

                case 1://4-1-2-1-2
                    SetBackFour();
                    SetPosition4(new Point(280, 170), new Point(284, 195), new Point(307, 215));
                    SetPosition7(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition8(new Point(280, 240), new Point(284, 265), new Point(307, 280));
                    SetPosition9(new Point(351, 311), new Point(355, 336), new Point(367, 352));
                    SetPosition10(new Point(206, 311), new Point(210, 336), new Point(228, 352));
                    SetPosition11(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    break;
                case 2://4-3-3 done
                    SetBackFour();
                    SetPosition7(new Point(116, 210), new Point(120, 235), new Point(140, 251));
                    SetPosition4(new Point(280, 210), new Point(284, 235), new Point(307, 251));
                    SetPosition8(new Point(426, 210), new Point(430, 235), new Point(454, 251));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(116, 311), new Point(120, 336), new Point(140, 352));
                    SetPosition11(new Point(426, 311), new Point(430, 336), new Point(454, 352));
                    break;
                case 3://4-5-1 done
                    SetPosition7(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition11(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(181, 170), new Point(185, 195), new Point(204, 211));
                    SetPosition8(new Point(363, 170), new Point(367, 195), new Point(389, 211));
                    SetPosition10(new Point(280, 240), new Point(284, 265), new Point(307, 280));
                    SetBackFour();
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    break;
                case 4://4-4-1-1
                    SetBackFour();
                    SetPosition7(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition4(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition8(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition11(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition10(new Point(280, 300), new Point(284, 325), new Point(307, 340));
                    SetPosition9(new Point(280, 371), new Point(284, 396), new Point(307, 412));
                    break;
                case 5://4-1-4-1
                    SetBackFour();
                    SetPosition4(new Point(280, 170), new Point(284, 195), new Point(307, 211));
                    SetPosition7(new Point(6, 242), new Point(6, 269), new Point(30, 285));
                    SetPosition8(new Point(181, 242), new Point(185, 269), new Point(204, 285));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(363, 242), new Point(367, 269), new Point(389, 285));
                    SetPosition11(new Point(540, 242), new Point(545, 269), new Point(571, 285));
                    break;
                case 6://4-2-3-1
                    SetBackFour();
                    SetPosition4(new Point(351, 170), new Point(355, 195), new Point(367, 211));
                    SetPosition7(new Point(116, 242), new Point(120, 269), new Point(140, 285));
                    SetPosition8(new Point(206, 170), new Point(210, 195), new Point(228, 211));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(280, 242), new Point(284, 269), new Point(307, 285));
                    SetPosition11(new Point(426, 242), new Point(430, 269), new Point(454, 285));
                    break;
                case 7://4-3-2-1
                    SetBackFour();
                    SetPosition4(new Point(280, 170), new Point(284, 195), new Point(307, 211));
                    SetPosition7(new Point(426, 170), new Point(430, 195), new Point(454, 211));
                    SetPosition8(new Point(116, 170), new Point(120, 195), new Point(140, 211));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(206, 242), new Point(210, 269), new Point(228, 285));
                    SetPosition11(new Point(351, 242), new Point(355, 269), new Point(367, 285));
                    break;
                case 8://5-3-2
                    SetPosition2(new Point(6, 110), new Point(6, 142), new Point(30, 158));
                    SetPosition3(new Point(540, 110), new Point(545, 142), new Point(571, 158));
                    SetPosition4(new Point(410, 110), new Point(410, 142), new Point(425, 158));
                    SetPosition6(new Point(146, 110), new Point(150, 142), new Point(168, 158));
                    SetPosition5(new Point(280, 110), new Point(284, 142), new Point(307, 158));
                    SetPosition7(new Point(116, 210), new Point(120, 235), new Point(140, 251));
                    SetPosition8(new Point(280, 210), new Point(284, 235), new Point(307, 251));
                    SetPosition9(new Point(351, 311), new Point(355, 336), new Point(367, 352));
                    SetPosition10(new Point(206, 311), new Point(210, 336), new Point(228, 352));
                    SetPosition11(new Point(426, 210), new Point(430, 235), new Point(454, 251));
                    break;
                case 9://5-4-1
                    SetPosition2(new Point(6, 110), new Point(6, 142), new Point(30, 158));
                    SetPosition3(new Point(540, 110), new Point(545, 142), new Point(571, 158));
                    SetPosition4(new Point(410, 110), new Point(410, 142), new Point(425, 158));
                    SetPosition6(new Point(146, 110), new Point(150, 142), new Point(168, 158));
                    SetPosition5(new Point(280, 110), new Point(284, 142), new Point(307, 158));
                    SetPosition7(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition8(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition11(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    break;
                case 10://3-5-2
                    SetPosition2(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition3(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(181, 170), new Point(185, 195), new Point(204, 211));
                    SetPosition8(new Point(363, 170), new Point(367, 195), new Point(389, 211));
                    SetPosition9(new Point(363, 311), new Point(367, 336), new Point(389, 352));
                    SetPosition10(new Point(181, 311), new Point(185, 336), new Point(204, 352));
                    SetPosition11(new Point(280, 240), new Point(284, 265), new Point(307, 280));
                    break;
                case 11://3-4-3
                    SetPosition2(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition3(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition8(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition9(new Point(280, 311), new Point(284, 336), new Point(307, 352));
                    SetPosition10(new Point(116, 311), new Point(120, 336), new Point(140, 352));
                    SetPosition11(new Point(426, 311), new Point(430, 336), new Point(454, 352));
                    break;
                case 12://3-1-3-1-2
                    SetPosition2(new Point(116, 235), new Point(120, 260), new Point(140, 276));
                    SetPosition3(new Point(426, 235), new Point(430, 260), new Point(454, 276));
                    SetPosition4(new Point(280, 165), new Point(284, 190), new Point(307, 206));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition8(new Point(280, 235), new Point(284, 260), new Point(307, 276));
                    SetPosition9(new Point(181, 371), new Point(185, 396), new Point(204, 412));
                    SetPosition10(new Point(280, 300), new Point(284, 325), new Point(307, 340));
                    SetPosition11(new Point(363, 371), new Point(367, 396), new Point(389, 412));
                    break;
                case 13://4-2-2-2
                    SetBackFour();
                    SetPosition4(new Point(181, 170), new Point(185, 195), new Point(204, 211));
                    SetPosition7(new Point(363, 170), new Point(367, 195), new Point(389, 211));
                    SetPosition8(new Point(181, 242), new Point(185, 269), new Point(204, 285));
                    SetPosition9(new Point(363, 311), new Point(367, 336), new Point(389, 352));
                    SetPosition10(new Point(181, 311), new Point(185, 336), new Point(204, 352));
                    SetPosition11(new Point(363, 242), new Point(367, 269), new Point(389, 285));
                    break;
                case 14://3-5-1-1
                    SetPosition2(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition3(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(181, 170), new Point(185, 195), new Point(204, 211));
                    SetPosition8(new Point(363, 170), new Point(367, 195), new Point(389, 211));
                    SetPosition9(new Point(280, 371), new Point(284, 396), new Point(307, 412));
                    SetPosition10(new Point(280, 300), new Point(284, 325), new Point(307, 340));
                    SetPosition11(new Point(280, 235), new Point(284, 260), new Point(307, 276));
                    break;
                case 15://3-4-2-1

                    SetPosition2(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition3(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition8(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition9(new Point(363, 300), new Point(367, 325), new Point(389, 340));
                    SetPosition10(new Point(181, 300), new Point(185, 325), new Point(204, 340));
                    SetPosition11(new Point(280, 371), new Point(284, 396), new Point(307, 412));
                    break;
                case 16://3-4-1-2
                    SetPosition2(new Point(6, 210), new Point(6, 235), new Point(30, 251));
                    SetPosition3(new Point(540, 210), new Point(545, 235), new Point(571, 251));
                    SetPosition4(new Point(426, 90), new Point(430, 122), new Point(454, 138));
                    SetPosition6(new Point(116, 90), new Point(120, 122), new Point(140, 138));
                    SetPosition5(new Point(280, 90), new Point(284, 122), new Point(307, 138));
                    SetPosition7(new Point(181, 210), new Point(185, 235), new Point(204, 251));
                    SetPosition8(new Point(363, 210), new Point(367, 235), new Point(389, 251));
                    SetPosition9(new Point(280, 300), new Point(284, 325), new Point(307, 340));
                    SetPosition10(new Point(181, 371), new Point(185, 396), new Point(204, 412));
                    SetPosition11(new Point(363, 371), new Point(367, 396), new Point(389, 412));
                    break;
                default:
                    break;
            }

        }

        private void SetBackFour()
        {
            SetPosition2(new Point(6, 90), new Point(6, 122), new Point(30, 138));
            SetPosition3(new Point(540, 90), new Point(545, 122), new Point(571, 138));
            SetPosition6(new Point(363, 90), new Point(367, 122), new Point(389, 138));
            SetPosition5(new Point(181, 90), new Point(185, 122), new Point(204, 138));
        }

        private void SetPosition2(Point comboLocation,Point labelLocation, Point buttonLocation)
        {
            //position 2 done
            this.comboBox2.Location = comboLocation;
            this.label12.Location = labelLocation;
            this.button1.Location = buttonLocation;

        }
        private void SetPosition3(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox12.Location = comboLocation;
            this.label22.Location = labelLocation;
            this.button9.Location = buttonLocation;
        }
        private void SetPosition4(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox6.Location = comboLocation;
            this.label17.Location = labelLocation;
            this.button5.Location = buttonLocation;
        }
        private void SetPosition6(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox4.Location = comboLocation;
            this.label15.Location = labelLocation;
            this.button10.Location = buttonLocation;

        }
        private void SetPosition5(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox3.Location = comboLocation;
            this.label14.Location = labelLocation;
            this.button11.Location = buttonLocation;
        }
        private void SetPosition7(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox5.Location = comboLocation;
            this.label18.Location = labelLocation;
            this.button8.Location = buttonLocation;
        }
        private void SetPosition8(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox7.Location = comboLocation;
            this.label16.Location = labelLocation;
            this.button4.Location = buttonLocation;
        }
        private void SetPosition9(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox11.Location = comboLocation;
            this.label20.Location = labelLocation;
            this.button6.Location = buttonLocation;
        }
        private void SetPosition10(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox9.Location = comboLocation;
            this.label19.Location = labelLocation;
            this.button7.Location = buttonLocation;
        }
        private void SetPosition11(Point comboLocation, Point labelLocation, Point buttonLocation)
        {
            this.comboBox8.Location = comboLocation;
            this.label21.Location = labelLocation;
            this.button3.Location = buttonLocation;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public static int getListBoxSelectedItem()
        {
            return listBox1.SelectedIndex;
        }

        private void GoalKeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = GoalKeeper.SelectedValue.ToString();
            test = "Reina";
            int i = OpenExcelFile.playerData.FindIndex(s => s.Surname == test);

        }

    }
}
