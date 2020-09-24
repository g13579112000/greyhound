using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound
{
    public class Greyhound
    {

        public int StartingPosition, RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        Random Random = new Random();

        #region 廢 Code
        //public void Racing()
        //{
        //    Dog[] Dogs = new Dog[4];
        //    List<int> ramdomMap = new List<int>();
        //    int[] order = new int[Dogs.Length];
        //    for (int i = 0; i <= Dogs.Length; i++)
        //    {
        //        ramdomMap.Add(i);
        //    }

        //    for (int i = 0; i <= Dogs.Length; i++)
        //    {
        //        int randomNumber = Random.Next(Dogs.Length);
        //        ramdomMap[randomNumber] = order[i];
        //        ramdomMap.Remove(randomNumber);

        //    }
        //    for (int i = 0; i <= order.Length; i++)
        //    {
        //        int distance = Dogs[order[i]].Run();
        //        Point p = MyPictureBox.Location;
        //        p.X += distance;
        //        MyPictureBox.Location = p;
        //    }
        //}
        #endregion

        public void Run()
        {
            Random Number = new Random();
            int distance = Number.Next(1, 5);
            Point point = MyPictureBox.Location;
            point.X += distance;
            MyPictureBox.Location = point;
            Location = point.X;
        }

        public void TakeStartingPosition()
        {
            Point point = MyPictureBox.Location;
            point.X = StartingPosition;
            MyPictureBox.Location = point;
        }
    }
}
